using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TM200Demo
{
    public class ChineseLanguage
    {
        public static void language(
                            ComboBox cbbLockBank, 
                            ComboBox cbbOperationType,
                            ComboBox cbbFrequencyBand,
                            ComboBox  cbbBeepControl) {
            // 加密操作区
            cbbLockBank.Items.Clear();
            cbbLockBank.Items.Add("灭活密码区");
            cbbLockBank.Items.Add("访问密码区");
            cbbLockBank.Items.Add("EPC");
            cbbLockBank.Items.Add("TID");
            cbbLockBank.Items.Add("用户区");

            cbbOperationType.Items.Clear();
            cbbOperationType.Items.Add("开放");
            cbbOperationType.Items.Add("永久开放");
            cbbOperationType.Items.Add("锁定");
            cbbOperationType.Items.Add("永久锁定");

            // 工作模式
            //cbbWorkMode.Items.Add("主从模式");
            //cbbWorkMode.Items.Add("定时模式");
            //cbbWorkMode.Items.Add("触发模式");

            // 触发模式
            //cbbTrigSwitch.Items.Add("关");
            //cbbTrigSwitch.Items.Add("高电平触发");

            // 通信方式
            //cbbCommMode.Items.Add("RS485/RJ45");
            //cbbCommMode.Items.Add("韦根");
            //cbbCommMode.Items.Add("RS232");
            // 读卡模式
            //cbbSingOrMulti.Items.Add("单标签");
            //cbbSingOrMulti.Items.Add("多标签");
            // 频率设置
            //cbbFrequency_Mode.Items.Add("跳频");
            //cbbFrequency_Mode.Items.Add("定频");


            // cbbFreqModeEU.Items.Add("跳频");
            //cbbFreqModeEU.Items.Add("定频");
            // 频率标名

            cbbFrequencyBand.Items.Clear();
            cbbFrequencyBand.Items.Add("CHINA-2");
            cbbFrequencyBand.Items.Add("USA");
            cbbFrequencyBand.Items.Add("JAPAN(暂不支持)");
            cbbFrequencyBand.Items.Add("MALAYSIA(暂不支持)");
            cbbFrequencyBand.Items.Add("ETSI");
            cbbFrequencyBand.Items.Add("CHINA-1");
            cbbFrequencyBand.Items.Add("自定义");
            //cboBand.Items.Add("国标");
            // 读卡声音控制
            cbbBeepControl.Items.Add("关闭");
            cbbBeepControl.Items.Add("打开");
            //cbbBeepControl.Items.Add("只响一声");
            // USB输出格式
            //cbbUsbFormat.Items.Add("韦根26(1字节+2字节)，8位10进制数");
            //cbbUsbFormat.Items.Add("韦根26(3字节)，8位十进制数");
            //cbbUsbFormat.Items.Add("00+3字节16进制");
            //cbbUsbFormat.Items.Add("4字节16进制");
            //cbbUsbFormat.Items.Add("12字节16进制");
            //cbbUsbFormat.Items.Add("12字节TID");
            //cbbUsbFormat.Items.Add("0000+前3字节16进制");
            //cbbUsbFormat.Items.Add("原始数据(保证原始数据是Ascii)");
            //cbbUsbFormat.Items.Add("条码输出");
            //cbbEPCDataFormat.Items.Add("非固定长度");
            //cbbEPCDataFormat.Items.Add("12字节");
            //cbbEPCDataFormat.SelectedIndex = 1;
        }
    }
}
