using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TM200Demo
{
    public sealed class EPC_data : System.IComparable
    {
        /// <summary>
        /// 标签编号
        /// </summary>
        public string tagId;

        /// <summary>
        /// EPC区
        /// </summary>
        public string epc;

        /// <summary>
        /// TID区
        /// </summary>
        public string tid;

        /// <summary>
        /// User区
        /// </summary>
        public string user;

        /// <summary>
        /// 读取相同标签次数
        /// </summary>
        public int count;

        /// <summary>
        /// 设备编号
        /// </summary>
        public string deviceId;

        /// <summary>
        /// 通讯接口(例:IP 192.168.1.200或串口COM1)
        /// </summary>
        public string host;

        /// <summary>
        /// 天线编号
        /// </summary>
        public string antennaId;

        /// <summary>
        /// 信号强度
        /// </summary>
        public string rssi;

        /// <summary>
        /// 指EPC区域的数据长度(例如:30 00)12个字节的长度
        /// </summary>
        public string pcValue;

        /// <summary>
        /// 标签区域(0.保留区，1.EPC区 2.TID区 3.用户区)
        /// </summary>
        public string tagArea;

        /// <summary>
        /// 报警数据
        /// </summary>
        public string alarmStatus;

        /// <summary>
        /// 私有数据
        /// </summary>
        public string privateData;

        /// <summary>
        /// 读取标签的时间
        /// </summary>
        public string readTagTime;

        /// <summary>
        /// 用户自定义数据
        /// </summary>
        public string userCustomeData;

        /// <summary>
        /// 模块温度
        /// </summary>
        public string temperature;

        /// <summary>
        /// 通道门方向
        /// </summary>
        public string direction;

        public int CompareTo(object obj)
        {
            EPC_data temp = (EPC_data)obj;
            {
                return string.Compare(this.tagId, temp.tagId);
            }
        }
    }
}
