﻿using HSZ.Common.Core.Manager;
using HSZ.ClayObject;
using HSZ.Common.Configuration;
using HSZ.Common.Model.NPOI;
using HSZ.DataEncryption;
using HSZ.Common.Enum;
using HSZ.Common.Extension;
using HSZ.Common.Filter;
using HSZ.Common.Helper;
using HSZ.Dependency;
using HSZ.DynamicApiController;
using HSZ.Entitys.wms;
using HSZ.FriendlyException;
using HSZ.JsonSerialization;
using HSZ.wms.Entitys.Dto.ZjnReportProductstructurePack;
using HSZ.wms.Interfaces.ZjnReportProductstructurePack;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using SqlSugar;
using SqlSugar.IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yitter.IdGenerator;

namespace HSZ.wms.ZjnReportProductstructurePack
{
    /// <summary>
    /// 库存结构分析（集成）服务
    /// </summary>
    [ApiDescriptionSettings(Tag = "wms",Name = "ZjnReportProductstructurePack", Order = 200)]
    [Route("api/wms/[controller]")]
    public class ZjnReportProductstructurePackService : IZjnReportProductstructurePackService, IDynamicApiController, ITransient
    {
        private readonly ISqlSugarRepository<ZjnReportProductstructurePackEntity> _zjnReportProductstructurePackRepository;
        private readonly IUserManager _userManager;
        private readonly SqlSugarScope _db;

        /// <summary>
        /// 初始化一个<see cref="ZjnReportProductstructurePackService"/>类型的新实例
        /// </summary>
        public ZjnReportProductstructurePackService(ISqlSugarRepository<ZjnReportProductstructurePackEntity> zjnReportProductstructurePackRepository,
            IUserManager userManager)
        {
            _zjnReportProductstructurePackRepository = zjnReportProductstructurePackRepository;
            _userManager = userManager;
            //只能作为事务处理
            _db = DbScoped.SugarScope;
        }

        /// <summary>
        /// 获取库存结构分析（集成）
        /// </summary>
        /// <param name="id">参数</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<dynamic> GetInfo(string id)
        {
            var output = (await _zjnReportProductstructurePackRepository.GetFirstAsync(p => p.Id == id)).Adapt<ZjnReportProductstructurePackInfoOutput>();
            return output;
        }

        /// <summary>
		/// 获取库存结构分析（集成）列表
		/// </summary>
		/// <param name="input">请求参数</param>
		/// <returns></returns>
        [HttpGet("")]
        public async Task<dynamic> GetList([FromQuery] ZjnReportProductstructurePackListQueryInput input)
        {
            var sidx = input.sidx == null ? "F_Id" : input.sidx;
            var data = await _zjnReportProductstructurePackRepository.AsSugarClient().Queryable<ZjnReportProductstructurePackEntity>()
                .WhereIF(!string.IsNullOrEmpty(input.F_ProductsCode), a => a.ProductsCode.Contains(input.F_ProductsCode))
                .WhereIF(!string.IsNullOrEmpty(input.F_ProductsName), a => a.ProductsName.Contains(input.F_ProductsName))
                .WhereIF(!string.IsNullOrEmpty(input.F_Batch), a => a.Batch.Contains(input.F_Batch))
                .Select((a
)=> new ZjnReportProductstructurePackListOutput
                {
                    F_Id = a.Id,
                    F_ProductsCode = a.ProductsCode,
                    F_ProductsName = a.ProductsName,
                    F_Batch = a.Batch,
                    F_EntryTime = a.EntryTime,
                    F_ProductsQuantity = a.ProductsQuantity,
                    F_ProductsUnit = a.ProductsUnit,
                    F_LocationAge = a.LocationAge,
                    F_CombineType = a.CombineType,
                    F_ProjectNum = a.ProjectNum,
                    F_PackingType = a.PackingType,
                    F_BatteryType = a.BatteryType,
                    F_BatteryCount = a.BatteryCount,
                    F_ProductionMark = a.ProductionMark,
                    F_InventoryMark = a.InventoryMark,
                    F_ClassMark = a.ClassMark,
                    F_Voltage = a.Voltage,
                    F_Ah = a.Ah,
                    F_BatteryCapacity = a.BatteryCapacity,
                    F_ProductionTime = a.ProductionTime,
                    F_LineNum = a.LineNum,
                    F_LineStatus = a.LineStatus,
                    F_Location = a.Location,
                    F_Freeze = a.Freeze,
                    F_FreezeResult = a.FreezeResult,
                }).OrderBy(sidx+" "+input.sort).ToPagedListAsync(input.currentPage, input.pageSize);
                return PageResult<ZjnReportProductstructurePackListOutput>.SqlSugarPageResult(data);
        }

        /// <summary>
        /// 新建库存结构分析（集成）
        /// </summary>
        /// <param name="input">参数</param>
        /// <returns></returns>
        [HttpPost("")]
        public async Task Create([FromBody] ZjnReportProductstructurePackCrInput input)
        {
            var userInfo = await _userManager.GetUserInfo();
            var entity = input.Adapt<ZjnReportProductstructurePackEntity>();
            entity.Id = YitIdHelper.NextId().ToString();
            
            var isOk = await _zjnReportProductstructurePackRepository.AsInsertable(entity).IgnoreColumns(ignoreNullColumn: true).ExecuteCommandAsync();
            if (!(isOk > 0)) throw HSZException.Oh(ErrorCode.COM1000);
        }

        /// <summary>
		/// 获取库存结构分析（集成）无分页列表
		/// </summary>
		/// <param name="input">请求参数</param>
		/// <returns></returns>
        [NonAction]
        public async Task<dynamic> GetNoPagingList([FromQuery] ZjnReportProductstructurePackListQueryInput input)
        {
            var sidx = input.sidx == null ? "F_Id" : input.sidx;
            var data = await _zjnReportProductstructurePackRepository.AsSugarClient().Queryable<ZjnReportProductstructurePackEntity>()
                .WhereIF(!string.IsNullOrEmpty(input.F_ProductsCode), a => a.ProductsCode.Contains(input.F_ProductsCode))
                .WhereIF(!string.IsNullOrEmpty(input.F_ProductsName), a => a.ProductsName.Contains(input.F_ProductsName))
                .WhereIF(!string.IsNullOrEmpty(input.F_Batch), a => a.Batch.Contains(input.F_Batch))
                .Select((a
)=> new ZjnReportProductstructurePackListOutput
                {
                    F_Id = a.Id,
                    F_ProductsCode = a.ProductsCode,
                    F_ProductsName = a.ProductsName,
                    F_Batch = a.Batch,
                    F_EntryTime = a.EntryTime,
                    F_ProductsQuantity = a.ProductsQuantity,
                    F_ProductsUnit = a.ProductsUnit,
                    F_LocationAge = a.LocationAge,
                    F_CombineType = a.CombineType,
                    F_ProjectNum = a.ProjectNum,
                    F_PackingType = a.PackingType,
                    F_BatteryType = a.BatteryType,
                    F_BatteryCount = a.BatteryCount,
                    F_ProductionMark = a.ProductionMark,
                    F_InventoryMark = a.InventoryMark,
                    F_ClassMark = a.ClassMark,
                    F_Voltage = a.Voltage,
                    F_Ah = a.Ah,
                    F_BatteryCapacity = a.BatteryCapacity,
                    F_ProductionTime = a.ProductionTime,
                    F_LineNum = a.LineNum,
                    F_LineStatus = a.LineStatus,
                    F_Location = a.Location,
                    F_Freeze = a.Freeze,
                    F_FreezeResult = a.FreezeResult,
                }).OrderBy(sidx+" "+input.sort).ToListAsync();
                return data;
        }

        /// <summary>
		/// 导出库存结构分析（集成）
		/// </summary>
		/// <param name="input">请求参数</param>
		/// <returns></returns>
        [HttpGet("Actions/Export")]
        public async Task<dynamic> Export([FromQuery] ZjnReportProductstructurePackListQueryInput input)
        {
            var userInfo = await _userManager.GetUserInfo();
            var exportData = new List<ZjnReportProductstructurePackListOutput>();
            if (input.dataType == 0)
            {
                var data = Clay.Object(await this.GetList(input));
                exportData = data.Solidify<PageResult<ZjnReportProductstructurePackListOutput>>().list;
            }
            else
            {
                exportData = await this.GetNoPagingList(input);
            }
            List<ParamsModel> paramList = "[{\"value\":\"物料编码\",\"field\":\"productsCode\"},{\"value\":\"物料名称\",\"field\":\"productsName\"},{\"value\":\"32位批次号\",\"field\":\"batch\"},{\"value\":\"入库时间\",\"field\":\"entryTime\"},{\"value\":\"物料数量\",\"field\":\"productsQuantity\"},{\"value\":\"物料单位\",\"field\":\"productsUnit\"},{\"value\":\"库龄\",\"field\":\"locationAge\"},{\"value\":\"集成方式\",\"field\":\"combineType\"},{\"value\":\"项目号\",\"field\":\"projectNum\"},{\"value\":\"包装方式\",\"field\":\"packingType\"},{\"value\":\"电池型号\",\"field\":\"batteryType\"},{\"value\":\"电池数量\",\"field\":\"batteryCount\"},{\"value\":\"产品标识\",\"field\":\"productionMark\"},{\"value\":\"库存标识\",\"field\":\"inventoryMark\"},{\"value\":\"等级标识\",\"field\":\"classMark\"},{\"value\":\"电压\",\"field\":\"voltage\"},{\"value\":\"安时\",\"field\":\"ah\"},{\"value\":\"电池容量（GWh）\",\"field\":\"batteryCapacity\"},{\"value\":\"生产时间\",\"field\":\"productionTime\"},{\"value\":\"生产线\",\"field\":\"lineNum\"},{\"value\":\"生产线状态\",\"field\":\"lineStatus\"},{\"value\":\"位置\",\"field\":\"location\"},{\"value\":\"是否冻结\",\"field\":\"freeze\"},{\"value\":\"冻结原因\",\"field\":\"freezeResult\"},]".ToList<ParamsModel>();
            ExcelConfig excelconfig = new ExcelConfig();
            excelconfig.FileName = "库存结构分析（集成）.xls";
            excelconfig.HeadFont = "微软雅黑";
            excelconfig.HeadPoint = 10;
            excelconfig.IsAllSizeColumn = true;
            excelconfig.ColumnModel = new List<ExcelColumnModel>();
            List<string> selectKeyList = input.selectKey.Split(',').ToList();
            foreach (var item in selectKeyList)
            {
                var isExist = paramList.Find(p => p.field == item);
                if (isExist != null)
                {
                    excelconfig.ColumnModel.Add(new ExcelColumnModel() { Column = isExist.field, ExcelColumn = isExist.value });
                }
            }
            var addPath = FileVariable.TemporaryFilePath + excelconfig.FileName;
            ExcelExportHelper<ZjnReportProductstructurePackListOutput>.Export(exportData, excelconfig, addPath);
            var fileName = _userManager.UserId + "|" + addPath + "|xls";
            var output = new
            {
                name = excelconfig.FileName,
                url = "/api/File/Download?encryption=" + DESCEncryption.Encrypt(fileName, "HSZ")
            };
            return output;
        }

        /// <summary>
        /// 批量删除库存结构分析（集成）
        /// </summary>
        /// <param name="ids">主键数组</param>
        /// <returns></returns>
        [HttpPost("batchRemove")]
        public async Task BatchRemove([FromBody] List<string> ids)
        {
            var entitys = await _zjnReportProductstructurePackRepository.AsQueryable().In(it => it.Id, ids).ToListAsync();
            if (entitys.Count > 0)
            {
                try
                {
                    //开启事务
                    _db.BeginTran();
                    //批量删除库存结构分析（集成）
                    await _zjnReportProductstructurePackRepository.AsDeleteable().In(d => d.Id,ids).ExecuteCommandAsync();
                    //关闭事务
                    _db.CommitTran();
                }
                catch (Exception)
                {
                    //回滚事务
                    _db.RollbackTran();
                    throw HSZException.Oh(ErrorCode.COM1002);
                }
            }
        }

        /// <summary>
        /// 更新库存结构分析（集成）
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="input">参数</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task Update(string id, [FromBody] ZjnReportProductstructurePackUpInput input)
        {
            var entity = input.Adapt<ZjnReportProductstructurePackEntity>();
            var isOk = await _zjnReportProductstructurePackRepository.AsUpdateable(entity).IgnoreColumns(ignoreAllNullColumns: true).ExecuteCommandAsync();
            if (!(isOk > 0)) throw HSZException.Oh(ErrorCode.COM1001);
        }

        /// <summary>
        /// 删除库存结构分析（集成）
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            var entity = await _zjnReportProductstructurePackRepository.GetFirstAsync(p => p.Id.Equals(id));
            _ = entity ?? throw HSZException.Oh(ErrorCode.COM1005);
            var isOk = await _zjnReportProductstructurePackRepository.AsDeleteable().Where(d => d.Id == id).ExecuteCommandAsync();
            if (!(isOk > 0)) throw HSZException.Oh(ErrorCode.COM1002);
        }
    }
}


