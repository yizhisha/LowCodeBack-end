﻿using HSZ.Dependency;

namespace HSZ.Extend.Entitys.Model
{
    /// <summary>
    /// 版 本 zjn-Standard v1.0.0.0
    /// Copyright (c) 2003-2022 江西合力泰科技股份有限公司
    /// 创建人：合力泰-框架开发组
    /// 日 期：2022.05.05
    /// 描 述：
    /// </summary>
    [SuppressSniffer]
    public class GoodsModel
    {
        /// <summary>
        /// 商品id
        /// </summary>
        public string goodsId { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string goodsName { get; set; }
        /// <summary>
        /// 规格型号
        /// </summary>
        public string specifications { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string unit { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal? qty { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal? price { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public decimal? amount { get; set; }
        /// <summary>
        /// 折扣
        /// </summary>
        public decimal? discount { get; set; }
        /// <summary>
        /// 税率
        /// </summary>
        public decimal? cess { get; set; }
        /// <summary>
        /// 实际单价
        /// </summary>
        public decimal? actualPrice { get; set; }
        /// <summary>
        /// 实际金额
        /// </summary>
        public decimal? actualAmount { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 商品编码
        /// </summary>
        public string goodsCode { get; set; }
        /// <summary>
        /// id
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 距离
        /// </summary>
        public string remove { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public long? sortCode { get; set; }
    }
}
