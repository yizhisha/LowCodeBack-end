﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSZ.VisualDev.Interfaces
{
    /// <summary>
    /// 版 本 zjn-Standard v1.0.0.0
    /// Copyright (c) 2003-2022 江西合力泰科技股份有限公司
    /// 创建人：合力泰-框架开发组
    /// 日 期：2022.05.05
    /// 描 述：业务契约：门户设计
    /// </summary>
    public interface IPortalService
    {
        /// <summary>
        /// 获取默认门户
        /// </summary>
        /// <returns></returns>
        Task<string> GetDefault();
    }
}
