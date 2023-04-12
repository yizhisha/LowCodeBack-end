﻿using HSZ.Common.Filter;
using System.Collections.Generic;

namespace HSZ.wms.Entitys.Dto.HltHrT3
{
    /// <summary>
    /// 调用类型列表查询输入
    /// </summary>
    public class HltHrT3ListQueryInput : PageInputBase
    {
        /// <summary>
        /// 选择导出数据key
        /// </summary>
        public string selectKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int dataType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string t2 { get; set; }
        
    }
}