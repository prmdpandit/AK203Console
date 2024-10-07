using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Resources;

namespace TM200Demo
{
    public class BasicOperation
    {
        public static void InitTableInfoColumns(ResourceManager rm,System.Windows.Forms.ListView listView)
        {
            listView.Columns.Clear();
            listView.Columns.Add(rm.GetString("strLvHeadNo"), 45, HorizontalAlignment.Center);

            listView.Columns.Add("Id", 0, HorizontalAlignment.Center);
            listView.Columns.Add("EPC", 300, HorizontalAlignment.Center);
            listView.Columns.Add("TID", 300, HorizontalAlignment.Center);
            listView.Columns.Add("User", 150, HorizontalAlignment.Center);
            listView.Columns.Add("PC", 60, HorizontalAlignment.Center);

            listView.Columns.Add(rm.GetString("strLvHeadCount"), 60, HorizontalAlignment.Center);
            listView.Columns.Add(rm.GetString("strLvHeadAntNo"), 60, HorizontalAlignment.Center);
            listView.Columns.Add(rm.GetString("strLvCurrentRssi"), 60, HorizontalAlignment.Center);
            listView.Columns.Add(rm.GetString("strLvHeadDevNo"), 60, HorizontalAlignment.Center);
            listView.Columns.Add(rm.GetString("strLvChannelDoorDirection"), 100, HorizontalAlignment.Center);

            listView.Columns.Add(rm.GetString("strLvUart_IP"), 150, HorizontalAlignment.Center);
            listView.Columns.Add(rm.GetString("strLvCurrentTime"), 200, HorizontalAlignment.Center);
           
            listView.Columns.Add(rm.GetString("strLvAlarmStatus"), 100, HorizontalAlignment.Center);
            listView.Columns.Add(rm.GetString("strLvPrivateData"), 100, HorizontalAlignment.Center);
            listView.Columns.Add(rm.GetString("strLvTemperature"), 100, HorizontalAlignment.Center);
            listView.Columns.Add(rm.GetString("strLvUserCustomeData"), 150, HorizontalAlignment.Center);
        }
        
        private static void GetSerialPortList(ref ComboBox comboBoxSP)
        {
            comboBoxSP.Items.Clear();
            comboBoxSP.Items.AddRange(SerialPort.GetPortNames());
            if (comboBoxSP.Items.Count > 0)
            {
                comboBoxSP.SelectedIndex = 0;
            }
        }

        public static void InitalConnectType(ComboBox cbbSerialPort, ComboBox cbbBaudRate)
        {
            cbbBaudRate.Items.Clear();
            cbbBaudRate.Items.Add("9600");
            cbbBaudRate.Items.Add("19200");
            cbbBaudRate.Items.Add("38400");
            cbbBaudRate.Items.Add("57600");
            cbbBaudRate.Items.Add("115200");
            cbbBaudRate.SelectedIndex = 0;

            GetSerialPortList(ref cbbSerialPort);
            if (cbbSerialPort.Items.Count > 0)
            {
                cbbSerialPort.SelectedIndex = 0;
            }
        }
    }
}
