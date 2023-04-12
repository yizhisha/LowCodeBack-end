﻿using HSZ.Common.Enum;
using HSZ.Common.Filter;
using HSZ.Dependency;
using HSZ.DynamicApiController;
using HSZ.FriendlyException;
using HSZ.System.Entitys.Dto.System.ModuleDataAuthorize;
using HSZ.System.Entitys.Permission;
using HSZ.System.Entitys.System;
using HSZ.System.Interfaces.System;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using SqlSugar;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HSZ.System.Service.System
{
    /// <summary>
    /// 版 本 zjn-Standard v1.0.0.0
    /// Copyright (c) 2003-2022 江西合力泰科技股份有限公司
    /// 创建人：合力泰-框架开发组
    /// 日 期：2022.05.05
    /// 描 述：数据权限
    /// </summary>
    [ApiDescriptionSettings(Tag = "System", Name = "ModuleDataAuthorize", Order = 214)]
    [Route("api/system/[controller]")]
    public class ModuleDataAuthorizeService : IModuleDataAuthorizeSerive, IDynamicApiController, ITransient
    {
        private readonly ISqlSugarRepository<ModuleDataAuthorizeEntity> _moduleDataAuthorizeRepository; //系统功能按钮表仓储
        private readonly ISqlSugarRepository<AuthorizeEntity> _authorizeRepository; //权限操作表仓储
        private readonly ISqlSugarRepository<UserEntity> _userRepository; //用户仓储
        private readonly ISqlSugarRepository<RoleEntity> _roleRepository;

        /// <summary>
        /// 初始化一个<see cref="ModuleDataAuthorizeService"/>类型的新实例
        /// </summary>
        /// <param name="moduleDataAuthorizeRepository"></param>
        /// <param name="authorizeRepository"></param>
        /// <param name="userRepository"></param>
        /// <param name="roleRepository"></param>
        public ModuleDataAuthorizeService(ISqlSugarRepository<ModuleDataAuthorizeEntity> moduleDataAuthorizeRepository, ISqlSugarRepository<AuthorizeEntity> authorizeRepository, ISqlSugarRepository<UserEntity> userRepository, ISqlSugarRepository<RoleEntity> roleRepository)
        {
            _moduleDataAuthorizeRepository = moduleDataAuthorizeRepository;
            _authorizeRepository = authorizeRepository;
            _userRepository = userRepository;
            _roleRepository = roleRepository;
        }

        #region GET

        /// <summary>
        /// 列表
        /// </summary>
        /// <param name="moduleId">功能主键</param>
        /// <param name="input">参数</param>
        /// <returns></returns>
        [HttpGet("{moduleId}/List")]
        public async Task<dynamic> GetList(string moduleId, [FromQuery] KeywordInput input)
        {
            var list = await GetList(moduleId);
            if (!string.IsNullOrEmpty(input.keyword))
            {
                list = list.FindAll(t => t.EnCode.Contains(input.keyword) || t.FullName.Contains(input.keyword));
            }
            var treeList = list.Adapt<List<ModuleDataAuthorizeListOutput>>();
            return new { list = treeList };
        }

        /// <summary>
        /// 信息
        /// </summary>
        /// <param name="id">主键值</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<dynamic> GetInfo_Api(string id)
        {
            var data = await GetInfo(id);
            var output = data.Adapt<ModuleDataAuthorizeInfoOutput>();
            return output;
        }

        #endregion

        #region POST

        /// <summary>
        /// 新建
        /// </summary>
        /// <param name="input">实体对象</param>
        /// <returns></returns>
        [HttpPost("")]
        public async Task Create([FromBody] ModuleDataAuthorizeCrInput input)
        {
            var entity = input.Adapt<ModuleDataAuthorizeEntity>();
            var isOk = await Create(entity);
            if (isOk < 1)
                throw HSZException.Oh(ErrorCode.COM1000);
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="id">主键值</param>
        /// <param name="input">实体对象</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task Update(string id, [FromBody] ModuleDataAuthorizeUpInput input)
        {
            var entity = input.Adapt<ModuleDataAuthorizeEntity>();
            var isOk = await Update(entity);
            if (isOk < 1)
                throw HSZException.Oh(ErrorCode.COM1001);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">主键值</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            var entity = await GetInfo(id);
            if (entity == null)
                throw HSZException.Oh(ErrorCode.COM1005);
            var isOk = await Delete(entity);
            if (isOk < 1)
                throw HSZException.Oh(ErrorCode.COM1001);
        }

        #endregion

        #region PublicMethod

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        [NonAction]
        public async Task<List<ModuleDataAuthorizeEntity>> GetList()
        {
            return await _moduleDataAuthorizeRepository.AsQueryable().Where(x => x.DeleteMark == null).OrderBy(o => o.SortCode).ToListAsync();
        }

        /// <summary>
        /// 列表
        /// </summary>
        /// <param name="moduleId">功能主键</param>
        /// <returns></returns>
        [NonAction]
        public async Task<List<ModuleDataAuthorizeEntity>> GetList(string moduleId)
        {
            return await _moduleDataAuthorizeRepository.AsQueryable().Where(x => x.DeleteMark == null && x.ModuleId == moduleId).OrderBy(o => o.SortCode).OrderBy(x => x.CreatorTime, OrderByType.Desc).OrderBy(t => t.LastModifyTime, OrderByType.Desc).ToListAsync();
        }

        /// <summary>
        /// 信息
        /// </summary>
        /// <param name="id">主键值</param>
        /// <returns></returns>
        [NonAction]
        public async Task<ModuleDataAuthorizeEntity> GetInfo(string id)
        {
            return await _moduleDataAuthorizeRepository.GetFirstAsync(x => x.Id == id && x.DeleteMark == null);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        [NonAction]
        public async Task<int> Delete(ModuleDataAuthorizeEntity entity)
        {
            return await _moduleDataAuthorizeRepository.AsUpdateable(entity).IgnoreColumns(ignoreAllNullColumns: true).CallEntityMethod(m => m.Delete()).ExecuteCommandAsync();
        }

        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        [NonAction]
        public async Task<int> Create(ModuleDataAuthorizeEntity entity)
        {
            return await _moduleDataAuthorizeRepository.AsInsertable(entity).CallEntityMethod(m => m.Creator()).ExecuteCommandAsync();
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        [NonAction]
        public async Task<int> Update(ModuleDataAuthorizeEntity entity)
        {
            return await _moduleDataAuthorizeRepository.AsUpdateable(entity).IgnoreColumns(ignoreAllNullColumns: true).CallEntityMethod(m => m.LastModify()).ExecuteCommandAsync();
        }

        /// <summary>
        /// 获取资源列表
        /// </summary>
        /// <param name="isAdmin"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [NonAction]
        public async Task<dynamic> GetResourceList(bool isAdmin, string userId)
        {
            var output = new List<ModuleDataAuthorizeOutput>();
            if (!isAdmin)
            {
                var role = _userRepository.GetFirst(u => u.Id == userId).RoleId;
                if (!string.IsNullOrEmpty(role))
                {
                    var roleArray = role.Split(',');
                    var roleId = await _roleRepository.AsQueryable().In(r => r.Id, roleArray).Where(r => r.EnabledMark==1 && r.DeleteMark == null).Select(r => r.Id).ToListAsync();
                    var items = await _authorizeRepository.AsQueryable().In(a => a.ObjectId, roleId).Where(a => a.ItemType == "resource").Select(a => a.ItemId).ToListAsync();
                    var buttons = await _moduleDataAuthorizeRepository.AsQueryable().In(a => a.Id, items).Where(a => a.EnabledMark == 1 && a.DeleteMark == null).Select<ModuleDataAuthorizeEntity>().OrderBy(q => q.SortCode).ToListAsync();
                    output = buttons.Adapt<List<ModuleDataAuthorizeOutput>>();
                }
            }
            else
            {
                var buttons = await _moduleDataAuthorizeRepository.AsQueryable().Where(a => a.EnabledMark == 1).Select<ModuleDataAuthorizeEntity>().OrderBy(q => q.SortCode).ToListAsync();
                output = buttons.Adapt<List<ModuleDataAuthorizeOutput>>();
            }
            return output;
        }

        #endregion
    }
}
