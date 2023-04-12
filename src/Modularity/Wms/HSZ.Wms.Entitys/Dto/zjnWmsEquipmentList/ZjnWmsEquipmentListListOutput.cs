﻿using System;

namespace HSZ.wms.Entitys.Dto.ZjnWmsEquipmentList
{
    /// <summary>
    /// 设备入库管理输入参数
    /// </summary>
    public class ZjnWmsEquipmentListListOutput
    {
        /// <summary>
        /// 唯一id
        /// </summary>
        public string F_id { get; set; }
        
        /// <summary>
        /// 设备编号
        /// </summary>
        public string F_EquipmentSerialNumber { get; set; }
        
        /// <summary>
        /// 设备名称
        /// </summary>
        public string F_DeviceName { get; set; }
        
        /// <summary>
        /// 类型
        /// </summary>
        public string F_Type { get; set; }


        public string F_TheBinding { get; set; }

        /// <summary>
        /// 绑定终点设备
        /// </summary>
        public string F_PositionTo { get; set; }


    }
}