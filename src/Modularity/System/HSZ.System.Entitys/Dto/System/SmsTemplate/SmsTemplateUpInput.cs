﻿using HSZ.Dependency;
using System;
using System.Collections.Generic;

namespace HSZ.System.Entitys.Dto.SmsTemplate
{
    /// <summary>
    /// 版 本 zjn-Standard v1.0.0.0
    /// Copyright (c) 2003-2022 江西合力泰科技股份有限公司
    /// 创建人：合力泰-框架开发组
    /// 日 期：2022.05.05
    /// 描 述： base_sms_template更新输入参数
    /// </summary>
    [SuppressSniffer]
    public class SmsTemplateUpInput : SmsTemplateCrInput
    {
        /// <summary>
        /// 自然主键
        /// </summary>
        public string id { get; set; }
        
    }
}
