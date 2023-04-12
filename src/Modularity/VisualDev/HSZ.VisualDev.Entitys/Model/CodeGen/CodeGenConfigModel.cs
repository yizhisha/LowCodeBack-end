﻿using HSZ.VisualDev.Entitys.Model.VisualDevModelData;
using System.Collections.Generic;

namespace HSZ.VisualDev.Entitys.Model.CodeGen
{
    /// <summary>
    /// 版 本 zjn-Standard v1.0.0.0
    /// Copyright (c) 2003-2022 江西合力泰科技股份有限公司
    /// 创建人：合力泰-框架开发组
    /// 日 期：2022.05.05
    /// 描 述：代码生成详细配置参数
    /// </summary>
    public class CodeGenConfigModel
    {
        /// <summary>
        /// 业务名
        /// </summary>
        public string BusName { get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        public string NameSpace { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// 主键
        /// </summary>
        public string PrimaryKey { get; set; }

        /// <summary>
        /// 主表
        /// </summary>
        public string MainTable { get; set; }

        /// <summary>
        /// 原本名称
        /// </summary>
        public string OriginalMainTableName { get; set; }

        /// <summary>
        /// 主表(首字母小写)
        /// </summary>
        public string LowerMainTable => string.IsNullOrWhiteSpace(MainTable)
                                      ? null
                                      : MainTable.Substring(0, 1).ToLower() + MainTable[1..];

        /// <summary>
        /// 服务列表
        /// </summary>
        public List<string> ServiceList { get; set; }

        /// <summary>
        /// 列表分页
        /// </summary>
        public bool hasPage { get; set; }

        /// <summary>
        /// 功能列表
        /// </summary>
        public List<CodeGenFunctionModel> Function { get; set; }

        /// <summary>
        /// 表字段
        /// </summary>
        public List<TableColumnConfigModel> TableField { get; set; }

        /// <summary>
        /// 表关系
        /// </summary>
        public List<CodeGenTableRelationsModel> TableRelations { get; set; }
    }
}