﻿using HSZ.Dependency;
using System;

namespace HSZ.WorkFlow.Entitys.Dto.FlowEngine
{
    /// <summary>
    /// 版 本 zjn-Standard v1.0.0.0
    /// Copyright (c) 2003-2022 江西合力泰科技股份有限公司
    /// 创建人：合力泰-框架开发组
    /// 日 期：2022.05.05
    /// 描 述：
    /// </summary>
    [SuppressSniffer]
    public class FlowEngineListAllOutput
    {
        /// <summary>
        /// id
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 流程编号
        /// </summary>
        public string enCode { get; set; }
        /// <summary>
        /// 流程名称
        /// </summary>
        public string fullName { get; set; }
        /// <summary>
        /// 流程类型(数据字典-工作流-流程类型)
        /// </summary>
        public int? type { get; set; }
        /// <summary>
        /// 流程分类(数据字典-工作流-流程分类)
        /// </summary>
        public string category { get; set; }
        /// <summary>
        /// 表单类型(数据字典-流程表单类型)
        /// </summary>
        public int? formType { get; set; }
        /// <summary>
        /// 表单JSON包
        /// </summary>
        public string formData { get; set; }
        /// <summary>
        /// 版本类型
        /// </summary>
        public int? visibleType { get; set; }
        /// <summary>
        /// 图标
        /// </summary>
        public string icon { get; set; }
        /// <summary>
        /// 图标背景
        /// </summary>
        public string iconBackground { get; set; }
        /// <summary>
        /// 流程JOSN包
        /// </summary>
        public string flowTemplateJson { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string creatorUser { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? creatorTime { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public string lastModifyUser { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? lastModifyTime { get; set; }
        /// <summary>
        /// 说明
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 标识
        /// </summary>
        public int? enabledMark { get; set; }
        /// <summary>
        /// 排序码
        /// </summary>
        public long? sortCode { get; set; }
    }
}
