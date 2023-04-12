﻿using HSZ.Dependency;
using System.Collections.Generic;

namespace HSZ.WorkFlow.Entitys.Model.Properties
{
    /// <summary>
    /// 版 本 zjn-Standard v1.0.0.0
    /// Copyright (c) 2003-2022 江西合力泰科技股份有限公司
    /// 创建人：合力泰-框架开发组
    /// 日 期：2022.05.05
    /// 描 述：
    /// </summary>
    [SuppressSniffer]
    public class ConditionProperties
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 条件明细
        /// </summary>
        public List<ConditionsModel> conditions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string initiator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int priority { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool isDefault { get; set; }
    }
    public class ConditionsModel
    {
        /// <summary>
        /// 字段名称
        /// </summary>
        public string fieldName { get; set; }
        /// <summary>
        /// 比较名称
        /// </summary>
        public string symbolName { get; set; }
        /// <summary>
        /// 字段值
        /// </summary>
        public string filedValue { get; set; }
        /// <summary>
        /// 逻辑名称
        /// </summary>
        public string logicName { get; set; }
        /// <summary>
        /// 字段
        /// </summary>
        public string field { get; set; }
        /// <summary>
        /// 逻辑符号
        /// </summary>
        public string logic { get; set; }
        /// <summary>
        /// 比较符号
        /// </summary>
        public string symbol { get; set; }
    }
}
