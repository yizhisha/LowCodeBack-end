﻿using HSZ.Dependency;
using System;

namespace HSZ.System.Entitys.Dto.System.ComFields
{
    /// <summary>
    /// 版 本 zjn-Standard v1.0.0.0
    /// Copyright (c) 2003-2022 江西合力泰科技股份有限公司
    /// 创建人：合力泰-框架开发组
    /// 日 期：2022.05.05
    /// 描 述：
    /// </summary>
    [SuppressSniffer]
    public class ComFieldsInfoOutput
    {
        /// <summary>
        /// id
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 长度
        /// </summary>
        public string dataLength { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public string dataType { get; set; }

        /// <summary>
        /// 允许空(1-允许，0-不允许)
        /// </summary>
        public int allowNull { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime? creatorTime { get; set; }

        /// <summary>
        /// 列名
        /// </summary>
        public string field { get; set; }

        /// <summary>
        /// 字段注释
        /// </summary>
        public string fieldName { get; set; }
    }
}
