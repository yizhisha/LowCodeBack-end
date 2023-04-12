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
    /// 描 述：工作日志分享
    /// </summary>
    [SugarTable("ZJN_EXT_WORKLOG_SHARE")]
    [Tenant(ClaimConst.TENANT_ID)]
    public class WorkLogShareEntity : EntityBase<string>
    {
        /// <summary>
        /// 日志主键
        /// </summary>
        /// <returns></returns>
        [SugarColumn(ColumnName = "F_WORKLOGID")]
        public string WorkLogId { get; set; }
        /// <summary>
        /// 共享人员
        /// </summary>
        /// <returns></returns>
        [SugarColumn(ColumnName = "F_SHAREUSERID")]
        public string ShareUserId { get; set; }
        /// <summary>
        /// 共享时间
        /// </summary>
        /// <returns></returns>
        [SugarColumn(ColumnName = "F_SHARETIME")]
        public DateTime? ShareTime { get; set; }
    }
}