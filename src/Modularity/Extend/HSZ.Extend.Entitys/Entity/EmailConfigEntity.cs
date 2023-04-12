﻿using HSZ.Common.Const;
using HSZ.Common.Entity;
using SqlSugar;

namespace HSZ.Extend.Entitys
{
    /// <summary>
    /// 版 本 zjn-Standard v1.0.0.0
    /// Copyright (c) 2003-2022 江西合力泰科技股份有限公司
    /// 创建人：合力泰-框架开发组
    /// 日 期：2022.05.05
    /// 描 述：邮件配置
    /// </summary>
    [SugarTable("ZJN_EXT_EMAIL_CONFIG")]
    [Tenant(ClaimConst.TENANT_ID)]
    public class EmailConfigEntity: CEntityBase
    {
        /// <summary>
        /// POP3服务
        /// </summary>
        [SugarColumn(ColumnName = "F_POP3HOST")]
        public string POP3Host { get; set; }
        /// <summary>
        /// POP3端口
        /// </summary>
        [SugarColumn(ColumnName = "F_POP3PORT")]
        public int? POP3Port { get; set; }
        /// <summary>
        /// SMTP服务
        /// </summary>
        [SugarColumn(ColumnName = "F_SMTPHOST")]
        public string SMTPHost { get; set; }
        /// <summary>
        /// SMTP端口
        /// </summary>
        [SugarColumn(ColumnName = "F_SMTPPORT")]
        public int? SMTPPort { get; set; }
        /// <summary>
        /// 账户
        /// </summary>
        [SugarColumn(ColumnName = "F_ACCOUNT")]
        public string Account { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [SugarColumn(ColumnName = "F_PASSWORD")]
        public string Password { get; set; }
        /// <summary>
        /// SSL登录
        /// </summary>
        [SugarColumn(ColumnName = "F_SSL")]
        public int? Ssl { get; set; }
        /// <summary>
        /// 发件人名称
        /// </summary>
        [SugarColumn(ColumnName = "F_SENDERNAME")]
        public string SenderName { get; set; }
        /// <summary>
        /// 我的文件夹
        /// </summary>
        [SugarColumn(ColumnName = "F_FOLDERJSON")]
        public string FolderJson { get; set; }
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
        /// 有效标志
        /// </summary>
        [SugarColumn(ColumnName = "F_ENABLEDMARK")]
        public int? EnabledMark { get; set; }
    }
}