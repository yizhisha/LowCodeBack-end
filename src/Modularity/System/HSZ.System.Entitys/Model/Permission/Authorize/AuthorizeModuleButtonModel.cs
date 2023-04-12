﻿using HSZ.Dependency;

namespace HSZ.System.Entitys.Model.Permission.Authorize
{
    /// <summary>
    /// 版 本 zjn-Standard v1.0.0.0
    /// Copyright (c) 2003-2022 江西合力泰科技股份有限公司
    /// 创建人：合力泰-框架开发组
    /// 日 期：2022.05.05
    /// 描 述：模块按钮权限模型
    /// </summary>
    [SuppressSniffer]
    public class AuthorizeModuleButtonModel
    {
        /// <summary>
        /// 按钮主键
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 按钮上级
        /// </summary>
        public string ParentId { get; set; }

        /// <summary>
        /// 按钮名称
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// 按钮编码
        /// </summary>
        public string EnCode { get; set; }

        /// <summary>
        /// 按钮图标
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 请求地址
        /// </summary>
        public string UrlAddress { get; set; }

        /// <summary>
        /// 功能主键
        /// </summary>
        public string ModuleId { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public long? SortCode { get; set; }
    }
}
