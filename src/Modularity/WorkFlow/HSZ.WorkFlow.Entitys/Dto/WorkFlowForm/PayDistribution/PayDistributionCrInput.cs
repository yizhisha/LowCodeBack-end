﻿using HSZ.Dependency;
using System.Collections.Generic;

namespace HSZ.WorkFlow.Entitys.Dto.WorkFlowForm.PayDistribution
{
    /// <summary>
    /// 版 本 zjn-Standard v1.0.0.0
    /// Copyright (c) 2003-2022 江西合力泰科技股份有限公司
    /// 创建人：合力泰-框架开发组
    /// 日 期：2022.05.05
    /// 描 述：
    /// </summary>
    [SuppressSniffer]
    public class PayDistributionCrInput
    {
        /// <summary>
        /// 
        /// </summary>
        public int? status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string flowTitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? flowUrgent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string billNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string flowId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string actualAttendance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? allowance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? baseSalary { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string department { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? grossPay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? incomeTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? insurance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string issuingUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string month { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? overtimePay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? payroll { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? performance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string position { get; set; }
        /// <summary>
        /// 候选人
        /// </summary>
        public Dictionary<string, List<string>> candidateList { get; set; }
    }
}
