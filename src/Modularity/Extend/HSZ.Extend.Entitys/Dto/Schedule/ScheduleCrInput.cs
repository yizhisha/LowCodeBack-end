﻿using HSZ.Dependency;
using System;

namespace HSZ.Extend.Entitys.Dto.Schedule
{
    /// <summary>
    /// 版 本 zjn-Standard v1.0.0.0
    /// Copyright (c) 2003-2022 江西合力泰科技股份有限公司
    /// 创建人：合力泰-框架开发组
    /// 日 期：2022.05.05
    /// 描 述：新建日程安排
    /// </summary>
    [SuppressSniffer]
    public class ScheduleCrInput
    {
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? startTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? endTime { get; set; }
        /// <summary>
        /// 日程内容
        /// </summary>
        public string content { get; set; }
        /// <summary>
        /// 微信提醒(1-提醒，0-不提醒)
        /// </summary>
        public int? weChatAlert { get; set; }
        /// <summary>
        /// 邮件提醒(1-提醒，0-不提醒)
        /// </summary>
        public int? mailAlert { get; set; }
        /// <summary>
        /// 短信提醒(1-提醒，0-不提醒)
        /// </summary>
        public int? mobileAlert { get; set; }
        /// <summary>
        /// APP提醒(1-提醒，0-不提醒)
        /// </summary>
        public int? appAlert { get; set; }
        /// <summary>
        /// 提醒设置
        /// </summary>
        public int? early { get; set; }
        /// <summary>
        /// 日程颜色	
        /// </summary>
        public string colour { get; set; }
        /// <summary>
        /// 颜色样式
        /// </summary>
        public string colourCss { get; set; }
    }
}
