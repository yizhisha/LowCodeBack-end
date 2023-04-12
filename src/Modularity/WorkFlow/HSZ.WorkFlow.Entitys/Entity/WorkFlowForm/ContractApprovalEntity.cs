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
    /// 描 述：合同审批
    /// </summary>
    [SugarTable("ZJN_WFORM_CONTRACT_APPROVAL")]
    [Tenant(ClaimConst.TENANT_ID)]
    public class ContractApprovalEntity : EntityBase<string>
    {
        /// <summary>
        /// 流程主键
        /// </summary>
        [SugarColumn(ColumnName = "F_FLOWID")]
        public string FlowId { get; set; }
        /// <summary>
        /// 流程标题
        /// </summary>
        [SugarColumn(ColumnName = "F_FLOWTITLE")]
        public string FlowTitle { get; set; }
        /// <summary>
        /// 紧急程度
        /// </summary>
        [SugarColumn(ColumnName = "F_FLOWURGENT")]
        public int? FlowUrgent { get; set; }
        /// <summary>
        /// 流程单据
        /// </summary>
        [SugarColumn(ColumnName = "F_BILLNO")]
        public string BillNo { get; set; }
        /// <summary>
        /// 甲方单位
        /// </summary>
        [SugarColumn(ColumnName = "F_FIRSTPARTYUNIT")]
        public string FirstPartyUnit { get; set; }
        /// <summary>
        /// 乙方单位
        /// </summary>
        [SugarColumn(ColumnName = "F_SECONDPARTYUNIT")]
        public string SecondPartyUnit { get; set; }
        /// <summary>
        /// 甲方负责人
        /// </summary>
        [SugarColumn(ColumnName = "F_FIRSTPARTYPERSON")]
        public string FirstPartyPerson { get; set; }
        /// <summary>
        /// 乙方负责人
        /// </summary>
        [SugarColumn(ColumnName = "F_SECONDPARTYPERSON")]
        public string SecondPartyPerson { get; set; }
        /// <summary>
        /// 甲方联系方式
        /// </summary>
        [SugarColumn(ColumnName = "F_FIRSTPARTYCONTACT")]
        public string FirstPartyContact { get; set; }
        /// <summary>
        /// 乙方联系方式
        /// </summary>
        [SugarColumn(ColumnName = "F_SECONDPARTYCONTACT")]
        public string SecondPartyContact { get; set; }
        /// <summary>
        /// 合同名称
        /// </summary>
        [SugarColumn(ColumnName = "F_CONTRACTNAME")]
        public string ContractName { get; set; }
        /// <summary>
        /// 合同分类
        /// </summary>
        [SugarColumn(ColumnName = "F_CONTRACTCLASS")]
        public string ContractClass { get; set; }
        /// <summary>
        /// 合同类型
        /// </summary>
        [SugarColumn(ColumnName = "F_CONTRACTTYPE")]
        public string ContractType { get; set; }
        /// <summary>
        /// 合同编码
        /// </summary>
        [SugarColumn(ColumnName = "F_CONTRACTID")]
        public string ContractId { get; set; }
        /// <summary>
        /// 业务人员
        /// </summary>
        [SugarColumn(ColumnName = "F_BUSINESSPERSON")]
        public string BusinessPerson { get; set; }
        /// <summary>
        /// 签约时间
        /// </summary>
        [SugarColumn(ColumnName = "F_SIGNINGDATE")]
        public DateTime? SigningDate { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        [SugarColumn(ColumnName = "F_STARTDATE")]
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        [SugarColumn(ColumnName = "F_ENDDATE")]
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// 收入金额
        /// </summary>
        [SugarColumn(ColumnName = "F_INCOMEAMOUNT")]
        public decimal? IncomeAmount { get; set; }
        /// <summary>
        /// 填写人员
        /// </summary>
        [SugarColumn(ColumnName = "F_INPUTPERSON")]
        public string InputPerson { get; set; }
        /// <summary>
        /// 相关附件
        /// </summary>
        [SugarColumn(ColumnName = "F_FILEJSON")]
        public string FileJson { get; set; }
        /// <summary>
        /// 主要内容
        /// </summary>
        [SugarColumn(ColumnName = "F_PRIMARYCOVERAGE")]
        public string PrimaryCoverage { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [SugarColumn(ColumnName = "F_DESCRIPTION")]
        public string Description { get; set; }
    }
}
