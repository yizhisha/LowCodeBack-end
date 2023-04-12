﻿using HSZ.Common.Const;
using HSZ.Common.Entity;
using SqlSugar;
using System;

namespace HSZ.WorkFlow.Entitys
{
    /// <summary>
    /// 版 本 zjn-Standard v1.0.0.0
    /// Copyright (c) 2003-2022 江西合力泰科技股份有限公司
    /// 创建人：合力泰-框架开发组
    /// 日 期：2022.05.05
    /// 描 述：流程任务
    /// </summary>
    [SugarTable("ZJN_FLOW_TASK")]
    [Tenant(ClaimConst.TENANT_ID)]
    public class FlowTaskEntity : CLDEntityBase
    {
        /// <summary>
        /// 父id
        /// </summary>
        [SugarColumn(ColumnName = "F_PARENTID")]
        public string ParentId { get; set; }
        /// <summary>
        /// 实例进程
        /// </summary>
        [SugarColumn(ColumnName = "F_PROCESSID")]
        public string ProcessId { get; set; }
        /// <summary>
        /// 任务编码
        /// </summary>
        [SugarColumn(ColumnName = "F_ENCODE")]
        public string EnCode { get; set; }
        /// <summary>
        /// 任务标题
        /// </summary>
        [SugarColumn(ColumnName = "F_FULLNAME")]
        public string FullName { get; set; }
        /// <summary>
        /// 紧急程度
        /// </summary>
        [SugarColumn(ColumnName = "F_FLOWURGENT")]
        public int? FlowUrgent { get; set; }
        /// <summary>
        /// 流程主键
        /// </summary>
        [SugarColumn(ColumnName = "F_FLOWID")]
        public string FlowId { get; set; }
        /// <summary>
        /// 流程编码
        /// </summary>
        [SugarColumn(ColumnName = "F_FLOWCODE")]
        public string FlowCode { get; set; }
        /// <summary>
        /// 流程名称
        /// </summary>
        [SugarColumn(ColumnName = "F_FLOWNAME")]
        public string FlowName { get; set; }
        /// <summary>
        /// 流程类型
        /// </summary>
        [SugarColumn(ColumnName = "F_FLOWTYPE")]
        public int? FlowType { get; set; }
        /// <summary>
        /// 流程分类
        /// </summary>
        [SugarColumn(ColumnName = "F_FLOWCATEGORY")]
        public string FlowCategory { get; set; }
        /// <summary>
        /// 流程表单
        /// </summary>
        [SugarColumn(ColumnName = "F_FLOWFORM")]
        public string FlowForm { get; set; }
        /// <summary>
        /// 表单内容
        /// </summary>
        [SugarColumn(ColumnName = "F_FLOWFORMCONTENTJSON")]
        public string FlowFormContentJson { get; set; }
        /// <summary>
        /// 流程模板
        /// </summary>
        [SugarColumn(ColumnName = "F_FLOWTEMPLATEJSON")]
        public string FlowTemplateJson { get; set; }
        /// <summary>
        /// 流程版本
        /// </summary>
        [SugarColumn(ColumnName = "F_FLOWVERSION")]
        public string FlowVersion { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        [SugarColumn(ColumnName = "F_STARTTIME")]
        public DateTime? StartTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        [SugarColumn(ColumnName = "F_ENDTIME")]
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// 当前步骤
        /// </summary>
        [SugarColumn(ColumnName = "F_THISSTEP")]
        public string ThisStep { get; set; }
        /// <summary>
        /// 当前步骤Id
        /// </summary>
        [SugarColumn(ColumnName = "F_THISSTEPID")]
        public string ThisStepId { get; set; }
        /// <summary>
        /// 重要等级
        /// </summary>
        [SugarColumn(ColumnName = "F_GRADE")]
        public string Grade { get; set; }
        /// <summary>
        /// 任务状态：【0-草稿、1-处理、2-通过、3-驳回、4-撤销、5-终止】
        /// </summary>
        [SugarColumn(ColumnName = "F_STATUS")]
        public int Status { get; set; }=0;
        /// <summary>
        /// 完成情况
        /// </summary>
        [SugarColumn(ColumnName = "F_COMPLETION")]
        public int? Completion { get; set; }
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
        /// <summary>
        /// 同步异步（0：同步，1：异步）
        /// </summary>
        [SugarColumn(ColumnName = "F_ISASYNC")]
        public int? IsAsync { get; set; }
        /// <summary>
        /// 是否批量（0：否，1：是）
        /// </summary>
        [SugarColumn(ColumnName = "F_ISBATCH")]
        public int? IsBatch { get; set; }
    }
}