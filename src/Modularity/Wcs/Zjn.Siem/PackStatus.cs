﻿using Newtonsoft.Json;
using S7.Net.Types;
using System.ComponentModel;

namespace Zjn.Siem
{
    /// <summary>
    /// PLC常规控制包，状态
    /// </summary>
    public class PackStatus:PackBase
    {

        /// <summary>
        /// 设备编号
        /// </summary>
        [DisplayName("设备"), PackStart(0), PackLength(8), Category("PLC报文"), Description("8 Byte,类型为S7String")]
        public byte[] DeviceCode
        {
            set
            {
                this.DeviceCodeM = value;
                this.device = Sharp7.S7.GetStringAt(this.DeviceCode, 0);
            }
            get
            { return this.DeviceCodeM; }
        }
        private byte[] DeviceCodeM = new byte[8];

        /// <summary>
        /// 任务编号
        /// </summary>
        [DisplayName("任务"), PackStart(8), PackLength(4), Category("PLC报文"), Description("4 Byte")]
        public int TaskCode { set; get; }

        /// <summary>
        /// 目标设备
        /// </summary>
        [DisplayName("目标"), PackStart(12), PackLength(8), Category("PLC报文"), Description("12 Byte,类型为S7String")]
        public byte[] TargetDevice { set; get; } = new byte[8];


        /// <summary>
        /// 托盘条码
        /// </summary>
        [DisplayName("托盘"), PackStart(20), PackLength(34), Category("PLC报文"), Description("34 Byte,类型为S7String")]
        public byte[] TrayCode { set; get; } = new byte[34];


        /// <summary>
        /// 占位状态
        /// </summary>
        [DisplayName("占位"), PackStart(54), PackLength(2), Category("PLC报文"), Description("2 Byte")]
        public short ExistTray { set; get; }


        /// <summary>
        /// 报警类型
        /// </summary>
        [DisplayName("报警"), PackStart(56), PackLength(2), Category("PLC报文"), Description("2 Byte")]
        public short Alarm { set; get; }


        /// <summary>
        /// 动作类型
        /// </summary>
        [DisplayName("状态"), PackStart(58), PackLength(2), Category("PLC报文"), Description("2 Byte")]
        public short Status { set; get; }


        /// <summary>
        /// 动作类型
        /// </summary>
        [DisplayName("预留1"), PackStart(60), PackLength(2), Category("PLC报文"), Description("2 Byte")]
        public short Reserve1 { set; get; }

        /// <summary>
        /// 动作类型
        /// </summary>
        [DisplayName("预留2"), PackStart(62), PackLength(2), Category("PLC报文"), Description("2 Byte")]
        public short Reserve2 { set; get; }

        /// <summary>
        /// 设备编号S
        /// </summary>
        [DisplayName("设备S"),  Description("字符串"), JsonIgnore()]
        public string DeviceCode_S
        {
            get
            {
                return Sharp7.S7.GetStringAt(this.DeviceCode, 0);
            }
        }

        /// <summary>
        /// 目标设备S
        /// </summary>
        [DisplayName("目标S"), Description("字符串"), JsonIgnore()]
        public string TargetDevice_S
        {
            get
            {
                return Sharp7.S7.GetStringAt(this.TargetDevice, 0);
            }
        }

        /// <summary>
        /// 托盘编码S
        /// </summary>
        [DisplayName("托盘S"), Description("字符串"), JsonIgnore()]
        public string TrayCode_S
        {
            get
            {
                return Sharp7.S7.GetStringAt(this.TrayCode, 0);
            }
        }

        /// <summary>
        /// 包对象名称
        /// </summary>
        [JsonIgnore()]
        public override string PackType
        {
            get { return "STATUS"; }
        }

        /// <summary>
        /// 对象大小
        /// </summary>
        [DisplayName("包体大小"), Description("字节数,64 Byte"), JsonIgnore()]
        public override int PackSize
        {
            get
            {
                return (int)Class.GetClassSize(this);
            }
        }
    }

    /// <summary>
    /// DB包列表
    /// </summary>
    public class PackStatusList
    {
        public PackStatusList(int count)
        {
            this.List = new PackStatus[count];
        }

        public PackStatus[] List { set; get; }
    }
}
