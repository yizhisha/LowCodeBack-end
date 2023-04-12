﻿using HSZ.Common.Const;
using HSZ.Common.Entity;
using SqlSugar;
using System;

namespace HSZ.Extend.Entitys
{
    /// <summary>
    /// 版 本 zjn-Standard v1.0.0.0
    /// Copyright (c) 2003-2022 江西合力泰科技股份有限公司
    /// 创建人：合力泰-框架开发组
    /// 日 期：2022.05.05
    /// 描 述：订单信息
    /// </summary>
    [SugarTable("ZJN_EXT_ORDER")]
    [Tenant(ClaimConst.TENANT_ID)]
    public class OrderEntity : CLDEntityBase
    {
        /// <summary>
        /// 客户Id
        /// </summary>
        [SugarColumn(ColumnName = "F_CUSTOMERID")]
        public string CustomerId { get; set; }
        /// <summary>
        /// 客户名称
        /// </summary>
        [SugarColumn(ColumnName = "F_CUSTOMERNAME")]
        public string CustomerName { get; set; }
        /// <summary>
        /// 业务员Id
        /// </summary>
        [SugarColumn(ColumnName = "F_SALESMANID")]
        public string SalesmanId { get; set; }
        /// <summary>
        /// 业务员
        /// </summary>
        [SugarColumn(ColumnName = "F_SALESMANNAME")]
        public string SalesmanName { get; set; }
        /// <summary>
        /// 订单日期
        /// </summary>
        [SugarColumn(ColumnName = "F_ORDERDATE")]
        public DateTime? OrderDate { get; set; }
        /// <summary>
        /// 订单编码
        /// </summary>
        [SugarColumn(ColumnName = "F_ORDERCODE")]
        public string OrderCode { get; set; }
        /// <summary>
        /// 运输方式
        /// </summary>
        [SugarColumn(ColumnName = "F_TRANSPORTMODE")]
        public string TransportMode { get; set; }
        /// <summary>
        /// 发货日期
        /// </summary>
        [SugarColumn(ColumnName = "F_DELIVERYDATE")]
        public DateTime? DeliveryDate { get; set; }
        /// <summary>
        /// 发货地址
        /// </summary>
        [SugarColumn(ColumnName = "F_DELIVERYADDRESS")]
        public string DeliveryAddress { get; set; }
        /// <summary>
        /// 付款方式
        /// </summary>
        [SugarColumn(ColumnName = "F_PAYMENTMODE")]
        public string PaymentMode { get; set; }
        /// <summary>
        /// 应收金额
        /// </summary>
        [SugarColumn(ColumnName = "F_RECEIVABLEMONEY")]
        public decimal? ReceivableMoney { get; set; }
        /// <summary>
        /// 定金比率
        /// </summary>
        [SugarColumn(ColumnName = "F_EARNESTRATE")]
        public decimal? EarnestRate { get; set; }
        /// <summary>
        /// 预付定金
        /// </summary>
        [SugarColumn(ColumnName = "F_PREPAYEARNEST")]
        public decimal? PrepayEarnest { get; set; }
        /// <summary>
        /// 当前状态
        /// </summary>
        [SugarColumn(ColumnName = "F_CURRENTSTATE")]
        public int? CurrentState { get; set; }
        /// <summary>
        /// 附件信息
        /// </summary>
        [SugarColumn(ColumnName = "F_FILEJSON")]
        public string FileJson { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [SugarColumn(ColumnName = "F_DESCRIPTION")]
        public string Description { get; set; }
        /// <summary>
        /// 排序码
        /// </summary>
        [SugarColumn(ColumnName = "F_SORTCODE")]
        public long? SortCode { get; set; }
    }
}