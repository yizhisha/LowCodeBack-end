﻿using HSZ.Common.Const;
using HSZ.Common.Entity;
using SqlSugar;

namespace HSZ.WorkFlow.Entitys
{
    /// <summary>
    /// 版 本 zjn-Standard v1.0.0.0
    /// Copyright (c) 2003-2022 江西合力泰科技股份有限公司
    /// 创建人：合力泰-框架开发组
    /// 日 期：2022.05.05
    /// 描 述：成品入库单明细
    /// </summary>
    [SugarTable("ZJN_WFORM_FINISHED_PRODUCT_ENTRY")]
    [Tenant(ClaimConst.TENANT_ID)]
    public class FinishedProductEntryEntity : EntityBase<string>
    {
        /// <summary>
        /// 入库单号
        /// </summary>
        [SugarColumn(ColumnName = "F_WAREHOUSEID")]
        public string WarehouseId { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        [SugarColumn(ColumnName = "F_GOODSNAME")]
        public string GoodsName { get; set; }
        /// <summary>
        /// 规格型号
        /// </summary>
        [SugarColumn(ColumnName = "F_SPECIFICATIONS")]
        public string Specifications { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        [SugarColumn(ColumnName = "F_UNIT")]
        public string Unit { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        [SugarColumn(ColumnName = "F_QTY")]
        public string Qty { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        [SugarColumn(ColumnName = "F_PRICE")]
        public decimal? Price { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        [SugarColumn(ColumnName = "F_AMOUNT")]
        public decimal? Amount { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [SugarColumn(ColumnName = "F_DESCRIPTION")]
        public string Description { get; set; }
        /// <summary>
        /// 排序号
        /// </summary>
        [SugarColumn(ColumnName = "F_SORTCODE")]
        public long? SortCode { get; set; }
    }
}