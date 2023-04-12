﻿using HSZ.Dependency;
using System;
using System.Collections.Generic;

namespace HSZ.WorkFlow.Entitys.Dto.WorkFlowForm.PaymentApply
{
    /// <summary>
    /// 版 本 zjn-Standard v1.0.0.0
    /// Copyright (c) 2003-2022 江西合力泰科技股份有限公司
    /// 创建人：合力泰-框架开发组
    /// 日 期：2022.05.05
    /// 描 述：
    /// </summary>
    [SuppressSniffer]
    public class PaymentApplyCrInput
    {
        /// <summary>
        /// 
        /// </summary>
        public int? status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string billNo { get; set; }
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
        public string openingBank { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string flowId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? amountPaid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? applyAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? applyDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string applyUser { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string beneficiaryAccount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string departmental { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string paymentType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string paymentUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string projectCategory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string projectLeader { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string purposeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string receivableContact { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string settlementMethod { get; set; }
        /// <summary>
        /// 候选人
        /// </summary>
        public Dictionary<string, List<string>> candidateList { get; set; }
    }
}
