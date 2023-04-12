﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HSZ.wms.Entitys.Dto.ZjnRoadwayInboundPlan
{
    /// <summary>
    /// 巷道入库策略均衡输出参数
    /// </summary>
    public class ZjnRoadwayInboundPlanInfoOutput
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public string id { get; set; }
        
        /// <summary>
        /// 巷道分组编号
        /// </summary>
        public string roadwayGroupNo { get; set; }
        
        /// <summary>
        /// 巷道分组名称
        /// </summary>
        public string roadwayGroupName { get; set; }
        
        /// <summary>
        /// 当前巷道
        /// </summary>
        public string nowroadwayGroup { get; set; }
        
        /// <summary>
        /// 当前顺序
        /// </summary>
        public int? nowroadwayGroupCode { get; set; }
        
    }
}