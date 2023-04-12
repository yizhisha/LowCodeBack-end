﻿using HSZ.Common.Util;
using HSZ.Dependency;

namespace HSZ.System.Entitys.Dto.Permission.Department
{
    /// <summary>
    /// 版 本 zjn-Standard v1.0.0.0
    /// Copyright (c) 2003-2022 江西合力泰科技股份有限公司
    /// 创建人：合力泰-框架开发组
    /// 日 期：2022.05.05
    /// 描 述：部门下拉树输出
    /// </summary>
    [SuppressSniffer]
    public class DepartmentSelectorOutput : TreeModel
    {
        /// <summary>
        /// 部门名称
        /// </summary>
        public string fullName { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int? enabledMark { get; set; }

        /// <summary>
        /// 当前节点标识
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        public string icon { get; set; } = "icon-sz icon-sz-tree-department1";

        /// <summary>
        /// 排序
        /// </summary>
        public long? sortCode { get; set; }
    }
}
