﻿using System;
using System.Collections.Generic;

namespace ZJN.Agv.Entitys.Dto.AgvCreateOrder
{
    /// <summary>
    /// 立库下单修改输入参数
    /// </summary>
    public class ZjnBaseStdCreateorderCrInput
    {
        /// <summary>
        /// 业务关系编码
        /// </summary>
        public string brCode { get; set; }
        
        /// <summary>
        /// 终点库区编码
        /// </summary>
        public string endAreaCode { get; set; }
        
        /// <summary>
        /// 终点库位编码
        /// </summary>
        public string endLocCode { get; set; }
        
        /// <summary>
        /// LES订单ID
        /// </summary>
        public string lesOrderId { get; set; }
        
        /// <summary>
        /// 外部订单ID
        /// </summary>
        public string outerOrderId { get; set; }
        
        /// <summary>
        /// 起点库区编码
        /// </summary>
        public string startAreaCode { get; set; }
        
        /// <summary>
        /// 起点库位编码
        /// </summary>
        public string startLocCode { get; set; }
        
        /// <summary>
        /// 托盘编码
        /// </summary>
        public string trayId { get; set; }

        /// <summary>
        /// 附加信息
        /// </summary>
        public extendInfo extendInfo { get; set; }

    }

    public class extendInfo
    {
        public int deviceOffset { get; set; }


    }
}