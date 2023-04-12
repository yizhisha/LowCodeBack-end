﻿using HSZ.Common.Filter;
using System.Collections.Generic;

namespace HSZ.wms.Entitys.Dto.ZjnWcsWorkDevice
{
    /// <summary>
    /// 设备信息管理列表查询输入
    /// </summary>
    public class ZjnWcsWorkDeviceListQueryInput : PageInputBase
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
        /// 设备编号
        /// </summary>
        public string DeviceID { get; set; }
        
        /// <summary>
        /// 设备名称
        /// </summary>
        public string caption { get; set; }
        
        /// <summary>
        /// 设备类型
        /// </summary>
        public string DeviceType { get; set; }
        
    }
}