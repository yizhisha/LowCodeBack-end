﻿using HSZ.Common.Core.Manager;
using HSZ.Common.Enum;
using HSZ.Common.Extension;
using HSZ.Dependency;
using HSZ.DynamicApiController;
using HSZ.FriendlyException;
using HSZ.System.Entitys.Dto.Permission.OrganizeAdministrator;
using HSZ.System.Entitys.Model.Permission.User;
using HSZ.System.Entitys.Permission;
using HSZ.System.Interfaces.Permission;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using SqlSugar;
using SqlSugar.IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSZ.System.Service.Permission
{
    /// <summary>
    /// 版 本 zjn-Standard v1.0.0.0
    /// Copyright (c) 2003-2022 江西合力泰科技股份有限公司
    /// 创建人：合力泰-框架开发组
    /// 日 期：2022.05.05
    /// 描 述：分级管理
    /// </summary>
    [ApiDescriptionSettings(Tag = "Permission", Name = "OrganizeAdministrator", Order = 166)]
    [Route("api/permission/[controller]")]
    public class OrganizeAdministratorService : IOrganizeAdministratorService, IDynamicApiController, ITransient
    {
        private readonly ISqlSugarRepository<OrganizeAdministratorEntity> _organizeAdministratorRepository;
        private readonly IOrganizeService _organizeService;
        private readonly IUserManager _userManager;
        private readonly SqlSugarScope Db;

        /// <summary>
        /// 初始化一个<see cref="OrganizeAdministratorService"/>类型的新实例
        /// </summary>
        public OrganizeAdministratorService(ISqlSugarRepository<OrganizeAdministratorEntity> organizeAdministratorRepository,
            IUserManager userManager, IOrganizeService organizeService)
        {
            _organizeAdministratorRepository = organizeAdministratorRepository;
            _userManager = userManager;
            _organizeService = organizeService;
            Db = DbScoped.SugarScope;
        }

        #region GET

        /// <summary>
        /// 拉取机构分级管理
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<dynamic> GetInfo(string id)
        {
            var list = await _organizeAdministratorRepository.AsQueryable().Where(it => it.OrganizeId == id && it.DeleteMark == null).OrderBy(it => it.CreatorTime, OrderByType.Asc).ToListAsync();
            var entity = list.FirstOrDefault().Adapt<OrganizeAdministratorInfoOutput>();
            if (entity != null)
            {
                entity.userId = String.Join(",", list.Select(it => it.UserId));
            }
            else
            {
                return new OrganizeAdministratorInfoOutput
                {
                    organizeId = id
                };
            }
            return entity;
        }

        #endregion

        #region POST

        /// <summary>
        /// 更新机构分级管理
        /// </summary>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task Update([FromBody] OrganizeAdminIsTratorUpInput input)
        {
            var user = await _userManager.GetUserInfo();
            if (!user.dataScope.Any(it => it.organizeId == input.organizeId && it.Edit == true) && !user.isAdministrator)
            {
                throw HSZException.Oh(ErrorCode.D1013);
            }
            var oldUserIds = await _organizeAdministratorRepository.AsQueryable().Where(it => it.OrganizeId == input.organizeId && it.DeleteMark == null).Select(it => it.UserId).ToListAsync();
            try
            {
                //开启事务
                Db.BeginTran();
                // 计算旧用户数组与新用户数组差
                var addList = input.userId.Split(',').Except(oldUserIds).ToList();
                var editList = input.userId.Split(',').Intersect(oldUserIds).ToList();
                var delList = oldUserIds.Except(input.userId.Split(',')).ToList();
                // 创建新数据
                if (addList.Count > 0)
                {
                    var addEntityList = new List<OrganizeAdministratorEntity>();
                    addList.ForEach(it =>
                    {
                        var entity = input.Adapt<OrganizeAdministratorEntity>();
                        entity.UserId = it;
                        addEntityList.Add(entity);
                    });
                    await _organizeAdministratorRepository.AsInsertable(addEntityList).CallEntityMethod(m => m.Creator()).ExecuteCommandAsync();
                }
                // 修改旧数据
                if (editList.Count > 0)
                {
                    var editEntityList = await _organizeAdministratorRepository.AsQueryable().Where(it => it.OrganizeId == input.organizeId && editList.Contains(SqlFunc.ToString(it.UserId))).ToListAsync();
                    editEntityList.ForEach(it =>
                    {
                        it.ThisLayerAdd = input.thisLayerAdd;
                        it.ThisLayerEdit = input.thisLayerEdit;
                        it.ThisLayerDelete = input.thisLayerDelete;
                        it.SubLayerAdd = input.subLayerAdd;
                        it.SubLayerEdit = input.subLayerEdit;
                        it.SubLayerDelete = input.subLayerDelete;
                        it.LastModifyTime = new DateTime();
                        it.LastModifyUserId = _userManager.UserId;
                    });
                    await _organizeAdministratorRepository.AsUpdateable(editEntityList).UpdateColumns(it => new
                    {
                        it.ThisLayerAdd,
                        it.ThisLayerEdit,
                        it.ThisLayerDelete,
                        it.SubLayerAdd,
                        it.SubLayerEdit,
                        it.SubLayerDelete,
                        it.LastModifyTime,
                        it.LastModifyUserId
                    }).ExecuteCommandAsync();
                }
                // 删除旧数据
                if (delList.Count > 0)
                {
                    await _organizeAdministratorRepository.AsSugarClient().Updateable<OrganizeAdministratorEntity>().SetColumns(it => new OrganizeAdministratorEntity()
                    {
                        EnabledMark = 0,
                        DeleteMark = 1,
                        DeleteTime = SqlFunc.GetDate(),
                        DeleteUserId = _userManager.UserId
                    }).Where(it => delList.Contains(SqlFunc.ToString(it.UserId)) && it.OrganizeId == input.organizeId).ExecuteCommandAsync();
                }
                Db.CommitTran();
            }
            catch (Exception)
            {
                Db.RollbackTran();
                throw HSZException.Oh(ErrorCode.D2300);
                throw;
            }
        }

        #endregion

        #region PublicMethod

        /// <summary>
        /// 获取用户数据范围
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [NonAction]
        public async Task<List<UserDataScope>> GetUserDataScope(string userId)
        {
            List<UserDataScope> data = new List<UserDataScope>();
            List<UserDataScope> subData = new List<UserDataScope>();
            List<UserDataScope> inteList = new List<UserDataScope>();
            var list = await _organizeAdministratorRepository.AsQueryable().Where(it => SqlFunc.ToString(it.UserId) == userId && it.DeleteMark == null).ToListAsync();
            //填充数据
            foreach (var item in list)
            {
                if (item.SubLayerAdd.ToBool() || item.SubLayerEdit.ToBool() || item.SubLayerDelete.ToBool())
                {
                    var subsidiary = await _organizeService.GetSubsidiary(item.OrganizeId);
                    subsidiary.Remove(item.OrganizeId);
                    subsidiary.ForEach(it =>
                    {
                        subData.Add(new UserDataScope()
                        {
                            organizeId = it,
                            Add = item.SubLayerAdd.ToBool(),
                            Edit = item.SubLayerEdit.ToBool(),
                            Delete = item.SubLayerDelete.ToBool()
                        });
                    });
                }
                if (item.ThisLayerAdd.ToBool() || item.ThisLayerEdit.ToBool() || item.ThisLayerDelete.ToBool())
                {
                    data.Add(new UserDataScope()
                    {
                        organizeId = item.OrganizeId,
                        Add = item.ThisLayerAdd.ToBool(),
                        Edit = item.ThisLayerEdit.ToBool(),
                        Delete = item.ThisLayerDelete.ToBool()
                    });
                }
            }
            //比较数据
            //所有分级数据权限以本级权限为主 子级为辅
            //将本级数据与子级数据对比 对比出子级数据内组织ID存在本级数据的组织ID
            var intersection = data.Select(it => it.organizeId).Intersect(subData.Select(it => it.organizeId)).ToList();
            intersection.ForEach(it =>
            {
                var parent = data.Find(item => item.organizeId == it);
                var child = subData.Find(item => item.organizeId == it);
                var add = false;
                var edit = false;
                var delete = false;
                if (parent.Add || child.Add)
                {
                    add = true;
                }
                if (parent.Edit || child.Edit)
                {
                    edit = true;
                }
                if (parent.Delete || child.Delete)
                {
                    delete = true;
                }
                inteList.Add(new UserDataScope()
                {
                    organizeId = it,
                    Add = add,
                    Edit = edit,
                    Delete = delete
                });
                data.Remove(parent);
                subData.Remove(child);
            });
            return data.Union(subData).Union(inteList).ToList();
        }


        #endregion
    }
}
