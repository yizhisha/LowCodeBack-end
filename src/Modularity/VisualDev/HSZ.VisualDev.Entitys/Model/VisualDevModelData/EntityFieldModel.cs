﻿namespace HSZ.VisualDev.Entitys.Model.VisualDevModelData
{
    /// <summary>
    /// 版 本 zjn-Standard v1.0.0.0
    /// Copyright (c) 2003-2022 江西合力泰科技股份有限公司
    /// 创建人：合力泰-框架开发组
    /// 日 期：2022.05.05
    /// 描 述：实体字段模型
    /// </summary>
    public class EntityFieldModel
    {
        /// <summary>
        /// 字段名称
        /// </summary>
        public string field { get; set; }

        // <summary>
        /// 字段说明
        /// </summary>
        public string fieldName { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        public string dataType { get; set; }

        /// <summary>
        /// 数据长度
        /// </summary>
        public string dataLength { get; set; }

        /// <summary>
        /// 主键
        /// </summary>
        public int? primaryKey { get; set; }
    }
}
