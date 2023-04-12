﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HSZ.wms.Entitys.Dto.ZjnRecordTrayGoods
{
    /// <summary>
    /// 托盘货物绑定表输出参数
    /// </summary>
    public class ZjnWmsTrayGoodsInfoOutput
    {
        /// <summary>
        /// 唯一ID
        /// </summary>
        public string id { get; set; }
        
        /// <summary>
        /// 货物ID
        /// </summary>
        public string goodsId { get; set; }
        
        /// <summary>
        /// 货物代码
        /// </summary>
        public string goodsCode { get; set; }
        
        /// <summary>
        /// 数量
        /// </summary>
        public int? quantity { get; set; }
        
        /// <summary>
        /// 单位
        /// </summary>
        public string unit { get; set; }
        
        /// <summary>
        /// 托盘编号
        /// </summary>
        public string trayNo { get; set; }
        
    }
}