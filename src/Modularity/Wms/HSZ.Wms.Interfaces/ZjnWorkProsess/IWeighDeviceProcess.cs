﻿using HSZ.Common.TaskResultPubilcParms;
using HSZ.Entitys.wms;
using HSZ.wms.Entitys.Dto.ZjnWmsTaskDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSZ.Wms.Interfaces.ZjnWorkProsess
{
    /// <summary>
    /// 子任务业务处理 --- 称重业务
    /// </summary>
    public interface IWeighDeviceProcess
    {
        /// <summary>
        /// 称重机业务处理  LES信息暂未上传
        /// </summary>
        /// <param name="WmsTaskData">子任务数据</param>
        /// <param name="TaskState">状态</param>
        /// <param name="parameter">重量</param>
        /// <returns></returns>
        public Task<ZjnWmsTaskDetailsInfoOutput> TaskDetailsStart(ZjnWmsTaskDetailsEntity WmsTaskData, int TaskState, TaskResultPubilcParameter parameter);
    }
}
