﻿using HSZ.Dependency;
using System;

namespace HSZ.Extend.Entitys.Dto.WorkLog
{
    /// <summary>
    /// 版 本 zjn-Standard v1.0.0.0
    /// Copyright (c) 2003-2022 江西合力泰科技股份有限公司
    /// 创建人：合力泰-框架开发组
    /// 日 期：2022.05.05
    /// 描 述：
    /// </summary>
    [SuppressSniffer]
    public class WorkLogListOutput
    {
        /// <summary>
        /// id
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 问题内容
        /// </summary>
        public string question { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? creatorTime { get; set; }
        /// <summary>
        /// 今日内容
        /// </summary>
        public string todayContent { get; set; }
        /// <summary>
        /// 明日内容
        /// </summary>
        public string tomorrowContent { get; set; }
        /// <summary>
        /// 接收人
        /// </summary>
        public string toUserId { get; set; }
        /// <summary>
        ///修改时间
        /// </summary>
        public DateTime? lastModifyTime { get; set; }


        /// <summary>
        /// 排序码
        /// </summary>
        public long? sortCode { get; set; }
    }
}
