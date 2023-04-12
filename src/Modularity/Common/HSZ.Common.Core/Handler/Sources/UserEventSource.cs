﻿using HSZ.EventBus;
using HSZ.System.Entitys.Permission;
using System;
using System.Threading;

namespace HSZ.EventHandler
{
    /// <summary>
    /// 版 本 zjn-Standard v1.0.0.0
    /// Copyright (c) 2003-2022 江西合力泰科技股份有限公司
    /// 创建人：合力泰-框架开发组
    /// 日 期：2022.05.05
    /// 描 述：用户事件源
    /// </summary>
    public class UserEventSource : IEventSource
    {
        public UserEventSource(string eventId, string tenantId, string enantDbName, UserEntity entity)
        {
            EventId = eventId;
            TenantId = tenantId;
            TenantDbName = enantDbName;
            Entity = entity;
        }

        /// <summary>
        /// 租户ID
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// 租户数据库名称
        /// </summary>
        public string TenantDbName { get; set; }

        /// <summary>
        /// 用户实体
        /// </summary>
        public UserEntity Entity { get; set; }

        /// <summary>
        /// 事件 Id
        /// </summary>
        public string EventId { get; }

        /// <summary>
        /// 事件承载（携带）数据
        /// </summary>
        public object Payload { get; }

        /// <summary>
        /// 取消任务 Token
        /// </summary>
        /// <remarks>用于取消本次消息处理</remarks>
        public CancellationToken CancellationToken { get; }

        /// <summary>
        /// 事件创建时间
        /// </summary>
        public DateTime CreatedTime { get; } = DateTime.UtcNow;
    }
}