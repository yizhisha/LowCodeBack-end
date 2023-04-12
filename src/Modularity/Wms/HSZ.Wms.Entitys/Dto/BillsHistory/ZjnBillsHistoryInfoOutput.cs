﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HSZ.wms.Entitys.Dto.ZjnBillsHistory
{
    /// <summary>
    /// 入库明细-APP端输出参数
    /// </summary>
    public class ZjnBillsHistoryInfoOutput
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string id { get; set; }
        
        /// <summary>
        /// 子单据Id
        /// </summary>
        public string orderNo { get; set; }
        
        /// <summary>
        /// 单据类型
        /// </summary>
        public string orderType { get; set; }

        /// <summary>
        /// 物料id
        /// </summary>
        public string productsNo { get; set; }

        /// <summary>
        /// 物料名称
        /// </summary>
        public string productsName { get; set; }
        
        /// <summary>
        /// 物料类型
        /// </summary>
        public string productsType { get; set; }
        
        /// <summary>
        /// 物料规格
        /// </summary>
        public string productsStyle { get; set; }
        
        /// <summary>
        /// 物料数量
        /// </summary>
        public decimal productsTotal { get; set; }
        
        /// <summary>
        /// 物料单位
        /// </summary>
        public string productsUnit { get; set; }
        
        /// <summary>
        /// 物料等级
        /// </summary>
        public string productsGrade { get; set; }
        
        /// <summary>
        /// 物料批次
        /// </summary>
        public string productsBach { get; set; }
        
        /// <summary>
        /// 客户
        /// </summary>
        public string productsUser { get; set; }
        
        /// <summary>
        /// 供应商
        /// </summary>
        public string productsSupplier { get; set; }
        
        /// <summary>
        /// 物料货位
        /// </summary>
        public string productsLocation { get; set; }

        /// <summary>
        /// 物料货位
        /// </summary>
        public string ProductsLocation { get; set; }

        /// <summary>
        /// 托盘号
        /// </summary>
        public string TheTray { get; set; }
        /// <summary>
        /// 容器号
        /// </summary>
        public string TheContainer { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string CreateUser { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public string LastModifyUserId { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? LastModifyTime { get; set; }


        /// <summary>
        /// 校验状态
        /// </summary>

        public string InspectionStatus { get; set; }
        /// <summary>
        /// 失效日期
        /// </summary>
       
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// 采购单号
        /// </summary>
        public string PurchaseOrder { get; set; }
        /// <summary>
        /// 校验类型
        /// </summary>
        public string TestType { get; set; }


        public DateTime? TheDateOfProduction { get; set; }

        public string BatchDeliveryQuantity { get; set; }
    }
}