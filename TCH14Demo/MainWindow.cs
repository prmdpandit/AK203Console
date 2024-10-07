using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Resources;
using System.Net;
using System.Net.Sockets;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO.Ports;
using System.Configuration;
using System.Data.OleDb;
using System.Collections;
using System.Threading.Tasks;
using AK203.Repository;
//using System.Web.UI.WebControls;

namespace TM200Demo
{
    public partial class MainWindow : Form
    {
        //static Dictionary<String, EPC_data> Tag_data = new Dictionary<String, EPC_data>();

        public static List<EPC_data> Tag_data = new List<EPC_data>();

        //static SortedList<string, EPC_data> sortList = new SortedList<string, EPC_data>();
        //static List<EPC_data> Tag_data = new List<EPC_data>();
        static int itemIndex = 0; // 记录需要更新的EPC数据索引
        int addStart = 0;
        int addEnd = 0;
        int counts = 1;
        // 加载字符串资源
        static ResourceManager[] rmArray = new ResourceManager[2]{
                        new ResourceManager("TM200Demo.SimpChinese", typeof(MainWindow).Assembly),
                        new ResourceManager("TM200Demo.English", typeof(MainWindow).Assembly)};

        public static ResourceManager rm = rmArray[0];
        static byte deviceNo = 0;
        // 数据产生时，触发此事件，更新ListView控件
        public delegate void UpdateControlEventHandler(EPC_data epcdata, bool bNewTag);
        public static event UpdateControlEventHandler UpdateControl;
        //private static SynchronizationContext m_SyncContext = null;

        public delegate void UpdateConnectEventHandler(string key, UIntPtr hDev);
        public static event UpdateConnectEventHandler UpdateConnect;

        static string tagId;

        public FUN_SOCKET_CB socket_callback = new FUN_SOCKET_CB(SocketCallBack);

        public static FUN_DATA_CB data_callback = new FUN_DATA_CB(DataCallBack);

        //存放已连接的对象
        public static Dictionary<string, UIntPtr> hashMap = new Dictionary<string, UIntPtr>();

        private static string getDeviceKey(string host, UIntPtr hDev)
        {
            //ushort device_id = 0;
            ////int result = TM200.QueryDeviceIdNotEPROM(hDev, ref device_id);
            //int result = TM200.QueryDeviceId(hDev, ref device_id);
            //string device = "null";
            //if(result > 0){
            //    device = device_id.ToString().PadLeft(5, '0');
            //}
            //return host + "_(" + hDev + ")_" + device;
            return host + "_(" + hDev + ")";
        }

        public static void SocketCallBack(ref SocketInfoStruct socketInfo)
        {
            try
            {
                string host = Encoding.Default.GetString(socketInfo.IP);//IP地址
                int baudrateOrPort = socketInfo.port; //端口号
                host = host.Replace("\0", "");
                //Console.WriteLine("IP: " + host + " PORT: " + baudrateOrPort);
                UIntPtr hDev = UIntPtr.Zero;
                int result = TM200.TCPServerConnect(ref hDev, socketInfo.socket, data_callback, host, baudrateOrPort);//添加连接的对象;
                if (result > 0)
                {
                    //string keys = host + "_(" + hDev + ")";// "_已连接";
                    string keys = getDeviceKey(host, hDev);
                    hashMap.Add(keys, hDev);
                    mainWindow.BeginInvoke(UpdateConnect, keys, hDev);
                }
            }
            catch (Exception e)
            {
                mainWindow.lblMessageHit.Text = e.Message;
            }
        }

        private void UpdateTreeListView(string keys, UIntPtr hDev)
        {
            try
            {
                lock (hashMap)
                {
                    //hashMap.Add(keys, hDev);
                    TreeNode node1 = new TreeNode(keys);
                    tvConnectList.Nodes[0].Nodes[2].Nodes.Add(node1);
                    tvConnectList.ExpandAll();
                    tvConnectList.SelectedNode = node1;
                    //lblMessageHit.Text = keys;
                }
            }
            catch (Exception e)
            {
                lblMessageHit.Text = e.Message;
            }
        }

        private static void networkException(UIntPtr hDevs, OutputInfoStruct outputInfo)
        {
            try
            {
                TM200.DisconnectDev(hDevs);//掉线了进行销毁
                byte type = outputInfo.connect_type;
                string message = "";
                switch (type)
                {
                    case 0: //串口
                        message = rm.GetString("strMessageSerialportConnectException");
                        connectException(hDevs, outputInfo, 0);
                        break;
                    case 1:  //TCP Client
                        message = rm.GetString("strMessageTCPClientConnectException");
                        connectException(hDevs, outputInfo, 1);
                        break;
                    case 2:  //监听端口TCP Server
                        message = rm.GetString("strMessageTCPServerConnectException");
                        connectException(hDevs, outputInfo, 2);
                        break;
                }
                message += " ";
                mainWindow.lblMessageHit.Text = message;
            }
            catch (Exception e)
            {
                mainWindow.lblMessageHit.Text = e.Message;
            }
        }

        private static void connectException(UIntPtr hDevs, OutputInfoStruct outputInfo, int type)
        {
            string value = outputInfo.host;
            string key = value + "_(" + hDevs + ")";// "_已连接";
            string findKey = "";
            foreach (string item in hashMap.Keys)
            {
                int index = item.LastIndexOf(')');
                if (index > 0)
                {
                    string temp = item.Substring(0, index + 1);
                    if (temp == key)
                    {
                        findKey = item;
                        break;
                    }
                }
            }
            if (findKey.Length < 1)
            {
                return;
            }
            hashMap.Remove(findKey);
            TreeNode node = null;
            lock (mainWindow.tvConnectList)
            {
                foreach (TreeNode item in mainWindow.tvConnectList.Nodes[0].Nodes[type].Nodes)
                {
                    if (item.Text == findKey)
                    {
                        node = item;
                        mainWindow.tvConnectList.Nodes[0].Nodes[type].Nodes.Remove(node);
                        break;
                    }
                }
            }
            if (hashMap.Count == 0 && type != 2)
            {
                mainWindow.btnTCPClientConnect.Enabled = true;
                mainWindow.btnSerialPortConnect.Enabled = true;
                mainWindow.btnStartMonitor.Enabled = true;
                mainWindow.btnStopMonitor.Enabled = true;
            }
        }

        public static void DataCallBack(UIntPtr hDevs, ref OutputInfoStruct outputInfo)
        {
            if (outputInfo.connect_exception == 1)//Network Excpetion
            {
                networkException(hDevs, outputInfo);
            }
            if (outputInfo.std_data == 1)
            {
                mainWindow.UpdateTag(outputInfo);
            }
        }

        private void tagTypeUhf08(OutputInfoStruct outputInfo)
        {
            String tagArea = outputInfo.standard_data.data_format.tag_area;
            switch (tagArea)
            {
                //case "0":
                //epc = tagId;
                //break;
                case "1":
                    epc = tagId;
                    secondIndex[0]++;
                    secondIndex[1] = 0;
                    secondIndex[2] = 0;
                    secondIndex[3] = 0;
                    if (secondIndex[0] == 1)
                    {
                        listView.Columns[1].Width = 0;
                        listView.Columns[2].Width = 300;
                        listView.Columns[3].Width = 0;
                        listView.Columns[4].Width = 0;
                    }
                    break;
                case "2":
                    tid = tagId;
                    secondIndex[0] = 0;
                    secondIndex[1]++;
                    secondIndex[2] = 0;
                    secondIndex[3] = 0;
                    if (secondIndex[1] == 1)
                    {
                        listView.Columns[1].Width = 0;
                        listView.Columns[2].Width = 0;
                        listView.Columns[3].Width = 300;
                        listView.Columns[4].Width = 0;
                    }
                    break;
                case "3":
                    user = tagId;
                    secondIndex[0] = 0;
                    secondIndex[1] = 0;
                    secondIndex[2]++;
                    secondIndex[3] = 0;
                    if (secondIndex[2] == 1)
                    {
                        listView.Columns[1].Width = 0;
                        listView.Columns[2].Width = 0;
                        listView.Columns[3].Width = 0;
                        listView.Columns[4].Width = 300;
                    }
                    break;
                case "0":
                default:
                    secondIndex[0] = 0;
                    secondIndex[1] = 0;
                    secondIndex[2] = 0;
                    secondIndex[3]++;
                    if (secondIndex[3] == 1)
                    {
                        listView.Columns[1].Width = 300;
                        listView.Columns[2].Width = 0;
                        listView.Columns[3].Width = 0;
                        listView.Columns[4].Width = 0;
                    }
                    break;
            }
        }

        private void tagTypeUhf0D(OutputInfoStruct outputInfo)
        {
            byte area = outputInfo.standard_data.tag_data.tag_area;
            switch (area)
            {
                case 0:

                    break;
                case 1:
                    thirdIndex[0]++;
                    thirdIndex[1] = 0;
                    thirdIndex[2] = 0;
                    thirdIndex[3] = 0;
                    thirdIndex[4] = 0;
                    if (thirdIndex[0] == 1)
                    {
                        listView.Columns[1].Width = 0;
                        listView.Columns[2].Width = 300;
                        listView.Columns[3].Width = 0;
                        listView.Columns[4].Width = 0;
                    }

                    break;
                case 2:
                    thirdIndex[0] = 0;
                    thirdIndex[1]++;
                    thirdIndex[2] = 0;
                    thirdIndex[3] = 0;
                    thirdIndex[4] = 0;
                    if (thirdIndex[1] == 1)
                    {
                        listView.Columns[1].Width = 0;
                        listView.Columns[2].Width = 0;
                        listView.Columns[3].Width = 300;
                        listView.Columns[4].Width = 0;
                    }
                    break;
                case 3:
                    thirdIndex[0] = 0;
                    thirdIndex[1] = 0;
                    thirdIndex[2]++;
                    thirdIndex[3] = 0;
                    thirdIndex[4] = 0;
                    if (thirdIndex[2] == 1)
                    {
                        listView.Columns[1].Width = 0;
                        listView.Columns[2].Width = 0;
                        listView.Columns[3].Width = 0;
                        listView.Columns[4].Width = 300;
                    }
                    break;
                case 4:
                    thirdIndex[0] = 0;
                    thirdIndex[1] = 0;
                    thirdIndex[2] = 0;
                    thirdIndex[3]++;
                    thirdIndex[4] = 0;
                    if (thirdIndex[3] == 1)
                    {
                        listView.Columns[1].Width = 0;
                        listView.Columns[2].Width = 300;
                        listView.Columns[3].Width = 300;
                        listView.Columns[4].Width = 0;
                    }
                    break;
                case 5:
                    thirdIndex[0] = 0;
                    thirdIndex[1] = 0;
                    thirdIndex[2] = 0;
                    thirdIndex[3] = 0;
                    thirdIndex[4]++;
                    if (thirdIndex[4] == 1)
                    {
                        listView.Columns[1].Width = 0;
                        listView.Columns[2].Width = 300;
                        listView.Columns[3].Width = 0;
                        listView.Columns[4].Width = 300;
                    }
                    break;
            }

            for (int i = 0; i < outputInfo.standard_data.tag_data.area_data[1].length; ++i)
            {
                epc += string.Format("{0:X2} ", outputInfo.standard_data.tag_data.area_data[1].data[i]);
            }
            for (int i = 0; i < outputInfo.standard_data.tag_data.area_data[2].length; ++i)
            {
                tid += string.Format("{0:X2} ", outputInfo.standard_data.tag_data.area_data[2].data[i]);
            }
            for (int i = 0; i < outputInfo.standard_data.tag_data.area_data[3].length; ++i)
            {
                user += string.Format("{0:X2} ", outputInfo.standard_data.tag_data.area_data[3].data[i]);
            }
        }

        int[] firstIndex = new int[3];//控制列宽显示
        int[] secondIndex = new int[4];//标签类型0x08控制列宽显示
        int[] thirdIndex = new int[5];//标签类型0x0D控制列宽显示

        private void firstIndexInital() {
            for (int i = 0; i < firstIndex.Length; i++)
            {
                firstIndex[i] = 0;
            }
        }

        private void secondIndexInital()
        {
            for (int i = 0; i < secondIndex.Length; i++)
            {
                secondIndex[i] = 0;
            }
        }

        private void thirdIndexInital()
        {
            for (int i = 0; i < thirdIndex.Length; i++)
            {
                thirdIndex[i] = 0;
            }
        }

        private void TagTypeUhf(byte tagType, OutputInfoStruct outputInfo)
        {
            switch (tagType)
            {
                case 0x08:
                    firstIndexInital();
                    thirdIndexInital();
                    tagTypeUhf08(outputInfo);
                    break;
                case 0x0D:
                    firstIndexInital();
                    secondIndexInital();
                    tagTypeUhf0D(outputInfo);
                    break;
                default:
                    firstIndex[0] = 0;
                    firstIndex[1] = 0;
                    firstIndex[2]++;
                    secondIndexInital();
                    thirdIndexInital();
                    if (firstIndex[2] == 1)
                    {
                        listView.Columns[1].Width = 150;
                        listView.Columns[2].Width = 0;
                        listView.Columns[3].Width = 0;
                        listView.Columns[4].Width = 0;
                    }
                    break;
            }
        }

        string epc = "";
        string tid = "";
        string user = "";

        private void UpdateTag(OutputInfoStruct outputInfo)
        {
                bool bNewTag = true;
                EPC_data epcdata = null;
                lock (Tag_data)
                {
                    tagId = "";
                    epc = "";
                    tid = "";
                    user = "";
                    byte[] data = new byte[32];
                    for (int i = 0; i < outputInfo.standard_data.data_len; ++i)
                    {
                        tagId += string.Format("{0:X2} ", outputInfo.standard_data.id_data[i]);
                    }
                    byte tagType = outputInfo.standard_data.tag_type;
                    TagTypeUhf(tagType, outputInfo);
                    for (int i = 0; i < Tag_data.Count; ++i)
                    {
                        if (Tag_data[i].tagId == tagId)
                        {
                            Tag_data[i].count++;
                            epcdata = Tag_data[i];
                            epcdata.epc = epc;
                            epcdata.tid = tid;
                            epcdata.user = user;
                            epcdata.tagArea = outputInfo.standard_data.data_format.tag_area;
                            epcdata.pcValue = outputInfo.standard_data.data_format.pc_value;
                            epcdata.antennaId = outputInfo.standard_data.data_format.ant_id;
                            epcdata.deviceId = outputInfo.device_id;
                            epcdata.host = outputInfo.host;
                            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                            epcdata.readTagTime = time;
                            epcdata.rssi = outputInfo.standard_data.data_format.RSSI;
                            epcdata.alarmStatus = outputInfo.standard_data.data_format.alarm_status;
                            if (outputInfo.standard_data.tag_data.temper == 1)
                            {
                                epcdata.temperature = outputInfo.standard_data.tag_data.tempper_value;
                            }
                            epcdata.privateData = outputInfo.standard_data.data_format.private_data;
                            int userDataLength = outputInfo.standard_data.data_format.user_data_length;
                            epcdata.userCustomeData = outputInfo.standard_data.data_format.user_data;
                            bNewTag = false;     // 不是新标签
                            break;
                        }
                    }
                    if (bNewTag)
                    {
                        epcdata = new EPC_data();
                        epcdata.tagId = tagId;
                        epcdata.epc = epc;
                        epcdata.tid = tid;
                        epcdata.user = user;
                        epcdata.tagArea = outputInfo.standard_data.data_format.tag_area;
                        epcdata.pcValue = outputInfo.standard_data.data_format.pc_value;
                        epcdata.antennaId = outputInfo.standard_data.data_format.ant_id;
                        epcdata.deviceId = outputInfo.device_id;
                        epcdata.host = outputInfo.host;
                        string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        epcdata.readTagTime = time;
                        epcdata.rssi = outputInfo.standard_data.data_format.RSSI;
                        epcdata.alarmStatus = outputInfo.standard_data.data_format.alarm_status;
                        if (outputInfo.standard_data.tag_data.temper == 1)
                        {
                            epcdata.temperature = outputInfo.standard_data.tag_data.tempper_value;
                        }
                        epcdata.privateData = outputInfo.standard_data.data_format.private_data;
                        int userDataLength = outputInfo.standard_data.data_format.user_data_length;
                        epcdata.userCustomeData = outputInfo.standard_data.data_format.user_data;
                        Tag_data.Add(epcdata);
                    }
                }
                UpdateListView(epcdata, bNewTag);
        }

        private void UpdateListView(EPC_data epcdata, bool newTag)
        {
            listView.BeginInvoke(new Action(() =>{
            lock (Tag_data)
            {
                //listView.BeginUpdate();//防listview闪烁开始
                lblCount.BeginInvoke(new Action(() =>{
                    lblCount.Text = (int.Parse(lblCount.Text) + 1).ToString();
                }));
                if (newTag)
                {
                    int count = int.Parse(lblTagCount.Text) + 1;
                    lblTagCount.Text = "" + count;// string.Format("{0:D} ", count);// 更新标签计数
                    int index = listView.Items.Count + 1;

                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = index.ToString();
                    listViewItem.SubItems.Add(epcdata.tagId);
                    listViewItem.SubItems.Add(epcdata.epc);
                    listViewItem.SubItems.Add(epcdata.tid);
                    listViewItem.SubItems.Add(epcdata.user);
                    listViewItem.SubItems.Add(epcdata.pcValue);
                    listViewItem.SubItems.Add("1");
                    listViewItem.SubItems.Add(epcdata.antennaId);
                    listViewItem.SubItems.Add(epcdata.rssi);
                    listViewItem.SubItems.Add(epcdata.deviceId);
                    listViewItem.SubItems.Add(epcdata.direction);
                    listViewItem.SubItems.Add(epcdata.host);
                    listViewItem.SubItems.Add(epcdata.readTagTime);
                    listViewItem.SubItems.Add(epcdata.alarmStatus);
                    listViewItem.SubItems.Add(epcdata.privateData);
                    listViewItem.SubItems.Add(epcdata.temperature);
                    listViewItem.SubItems.Add(epcdata.userCustomeData);
                    listView.Items.Add(listViewItem);
                    listView.Items[listView.Items.Count - 1].EnsureVisible();//显示内容自动滚动到最后一行
                }
                else
                {
                    lock (listView.Items)
                    {
                        bool flag = true;
                        for (int index = 0; flag && index < listView.Items.Count; index++)
                        {
                            if (epcdata.tagId == listView.Items[index].SubItems[1].Text)
                            {
                                listView.Items[index].SubItems[2].Text = epcdata.epc;
                                listView.Items[index].SubItems[3].Text = epcdata.tid;
                                listView.Items[index].SubItems[4].Text = epcdata.user;
                                listView.Items[index].SubItems[5].Text = epcdata.pcValue;
                                String tagCount = listView.Items[index].SubItems[6].Text;
                                listView.Items[index].SubItems[6].Text = (int.Parse(tagCount) + 1).ToString();
                                listView.Items[index].SubItems[7].Text = epcdata.antennaId;
                                listView.Items[index].SubItems[8].Text = epcdata.rssi;
                                listView.Items[index].SubItems[9].Text = epcdata.deviceId;
                                listView.Items[index].SubItems[10].Text = epcdata.direction;
                                listView.Items[index].SubItems[11].Text = epcdata.host;
                                listView.Items[index].SubItems[12].Text = epcdata.readTagTime;
                                listView.Items[index].SubItems[13].Text = epcdata.alarmStatus;
                                listView.Items[index].SubItems[14].Text = epcdata.privateData;
                                listView.Items[index].SubItems[15].Text = epcdata.temperature;
                                listView.Items[index].SubItems[16].Text = epcdata.userCustomeData;
                                flag = false;
                            }
                        }
                    }
                }
              }
            }));
        }

        #region Main

        public static MainWindow mainWindow;

        static string IniFilePath = Application.StartupPath + "\\Config.ini";
        private readonly IUnitOfWork unitOfWork;

        /******************************************************  Main  Start ********************************************************************************************/
        private void LoadChallanNo()
        {

            try
            {
                var challans = unitOfWork.StockIssues.GetAll().OrderByDescending(o=>o.Id).ToList();
                cmbSelectChalan.DataSource = challans;
                cmbSelectChalan.DisplayMember = "Challan_No"; // This is the property to display in the ComboBox
                cmbSelectChalan.ValueMember = "Id"; // This is the property that will be used as the value
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading StockIssues: " + ex.Message);
            }

        }
        private void cmbSelectChalan_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (cmbSelectChalan.SelectedValue != null)
            {
                int selectedId = (int)cmbSelectChalan.SelectedValue;

                // Fetch the selected StockIssue entity by ID
                var selectedChallan = unitOfWork.StockIssues.GetById(selectedId);

                // Check if the selectedChallan is not null
                if (selectedChallan != null)
                {
                    // Fill controls with properties from the selected StockIssue entity
                    txtArmyNo.Text = selectedChallan.Issue_To_Army_No;
                    dateTimePickerChallanDate.Text = selectedChallan.Challan_Dt?.ToString("yyyy-MM-dd"); // Format date as needed
                    txtTotalQty.Text = selectedChallan.Total_Qty.ToString();
                    dateTimePickerIssueDate.Text = selectedChallan.Issue_Dt?.ToString("yyyy-MM-dd"); ;
                   

                    // Add any other controls you wish to populate
                }
                else
                {
                    MessageBox.Show("No record found for the selected Challan.");
                }
            }
            else
            {
                // Optionally clear the controls if no selection
                txtArmyNo.Clear();
                txtTotalQty.Clear();
              
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (cmbSelectChalan.SelectedValue == null)
            {
                MessageBox.Show("Please select a Challan.");
                return;
            }

            if (listView.Items.Count == 0)
            {
                MessageBox.Show("Please add at least one item to save.");
                return;
            }

            try
            {
                // Get the selected Challan ID
                int selectedChallanId = (int)cmbSelectChalan.SelectedValue;

                if (Convert.ToInt32(txtTotalQty.Text) == listView.Items.Count)
                {
                    // Iterate over ListView items to save each RFID entry
                    foreach (System.Windows.Forms.ListViewItem item in listView.Items)
                    {
                        // Assume "EPC" and "ANT" are the names of your columns in the ListView
                        string epc = item.SubItems[1].Text; // Adjust index as necessary


                        // Create a new StockIssueItemRfid entity
                        var stockIssueItemRfid = new StockIssueItemRfid
                        {
                            Stock_Issue_Id = selectedChallanId,
                            EquipmentRfid = epc

                        };

                        // Save the entity using UnitOfWork
                        unitOfWork.StockIssueItemRfids.Insert(stockIssueItemRfid);
                      
                    }

                    // Commit changes to the database
                    unitOfWork.StockIssueItemRfids.Save();

                    MessageBox.Show("Stock Issue RFID items saved successfully.");
                }
                else {
                    MessageBox.Show("Stock Issue RFID items is not matching with challan total Qty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving: " + ex.Message);
            }
        }

        public MainWindow(IUnitOfWork _unitOfWork)
        {
            try
            {
                InitializeComponent();
                unitOfWork = _unitOfWork;
                LoadChallanNo();
                //SetStyle(
                //  ControlStyles.AllPaintingInWmPaint |  //全部在窗口绘制消息中绘图
                //  ControlStyles.OptimizedDoubleBuffer, true); //使用双缓冲
                //this.SetStyle(ControlStyles.EnableNotifyMessage, true);
                //UpdateStyles();
                //DoubleBuffered = true;

                // 允许跨线程更新窗口控件
                Control.CheckForIllegalCrossThreadCalls = false;
                InitalContrl();
                UpdateControl = new UpdateControlEventHandler(UpdateListView);  //订阅UpdateControl事件
                UpdateConnect = new UpdateConnectEventHandler(UpdateTreeListView);
                mainWindow = this;

                tvConnectList.HideSelection = false;
                tvConnectList.DrawMode = TreeViewDrawMode.OwnerDrawText;
                tvConnectList.DrawNode += new DrawTreeNodeEventHandler(tvConnectList_DrawNode);
                cbbBaudRate.SelectedIndex = 4;
                cbbMatchMode.SelectedIndex = 0;
            }
            catch (Exception e)
            {
                lblMessageHit.Text = "MainWindow " + e.Message;
            }
        }

        protected override void OnNotifyMessage(Message m)
        {
            //Filter out the WM_ERASEBKGND message
            if (m.Msg != 0x14)
            {
                base.OnNotifyMessage(m);
            }
        }
        /******************************************************  Main  End ********************************************************************************************/


        /// <summary>
        /// 绘制颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvConnectList_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            //e.DrawDefault = true; //我这里用默认颜色即可，只需要在TreeView失去焦点时选中节点仍然突显
            //return;
            //or  自定义颜色
            if ((e.State & TreeNodeStates.Selected) != 0)
            {
                //演示为绿底白字
                e.Graphics.FillRectangle(Brushes.DarkCyan, e.Node.Bounds);//DarkBlue

                Font nodeFont = e.Node.NodeFont;
                if (nodeFont == null)
                {
                    nodeFont = ((TreeView)sender).Font;
                }
                Rectangle focusBounds = e.Bounds;
                focusBounds.Size = new Size(focusBounds.Width + 10, focusBounds.Height + 10);
                e.Graphics.DrawString(e.Node.Text, nodeFont, Brushes.White, Rectangle.Inflate(focusBounds, 0, 0));
            }
            else
            {
                e.DrawDefault = true;
            }

            if ((e.State & TreeNodeStates.Focused) != 0)
            {
                using (Pen focusPen = new Pen(Color.Black))
                {
                    focusPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                    Rectangle focusBounds = e.Node.Bounds;
                    focusBounds.Size = new Size(focusBounds.Width - 1, focusBounds.Height - 1);
                    e.Graphics.DrawRectangle(focusPen, focusBounds);
                }
            }

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            tvConnectList.ExpandAll();
            tvConnectList.HideSelection = false;
            tabControl.TabPages.Remove(tpAntennaParams);
            tabControl.TabPages.Remove(tpTagAccess);
            tabControl.TabPages.Remove(tpOtherOpreation);
            tabControl.TabPages.Remove(tpSetCommParam);
            tabControl.TabPages.Remove(tbSetReaderParam);
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.D0)
            {
            }
            else if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.D1)
            {
            }
        }

        #endregion Main

        /// <summary>
        /// 关闭
        /// 2015-11-9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(rm.GetString("MainWindowFormClosing"), rm.GetString("ClosePrompt"), MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        #region 初始化值
        /*********************************** 以下是初始化值和不常变动的 2021-03-06 Start **************************************************************/

        static UIntPtr hServerSocket = UIntPtr.Zero;

        private void btnStartMonitor_Click(object sender, EventArgs e)
        {
            if (tbTCPServerPort.Text == "")
            {
                MessageBox.Show(rm.GetString("strMsgSelectRates"));
                return;
            }
            int port = Convert.ToInt32(tbTCPServerPort.Text);
            int result = TM200.StartListening(ref hServerSocket, socket_callback, (short)port);
            if (result > 0)
            {
                lblMessageHit.Text = rm.GetString("strMessageStartMonitorSuccessed");
                btnStartMonitor.Enabled = false;
                btnSerialPortConnect.Enabled = false;
                btnTCPClientConnect.Enabled = false;
            }
            else
            {
                lblMessageHit.Text = rm.GetString("strMessageStartMonitorFailure");
            }
        }

        private void btnStopMonitor_Click(object sender, EventArgs e)
        {
            if (hServerSocket == UIntPtr.Zero)
            {
                lblMessageHit.Text = rm.GetString("strMessagePleaseStartMonitor");
                return;
            }
            int index = 2;
            int result = TM200.StopListening(hServerSocket);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMessageStopMonitorFailure");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMessageStopMonitorSuccessed");
            btnStartMonitor.Enabled = true;
            btnSerialPortConnect.Enabled = true;
            btnTCPClientConnect.Enabled = true;
            lock (hashMap)
            {
                for (int i = 0; i < hashMap.Count; i++)
                {
                    TreeNode node = null;
                    string key = hashMap.ElementAt(i).Key;
                    Console.WriteLine(key);
                    lock (tvConnectList.Nodes[0].Nodes[2])
                    {
                        foreach (TreeNode item in tvConnectList.Nodes[0].Nodes[index].Nodes)
                        {
                            if (item.Text == key)
                            {
                                node = item;
                                tvConnectList.Nodes[0].Nodes[index].Nodes.Remove(node);
                                break;
                            }
                        }
                    }
                    TM200.DisconnectDev(hashMap[key]);
                }
            }
            hashMap.Clear();
            //Console.WriteLine("断开监听*****************************************************************");
        }


        /*********************************** 以下是初始化值和不常变动的 2021-03-06 End **************************************************************/
        #endregion 初始化值

        public static void SaveTxt()
        {
            string fileName = "";
            string saveFileName = "";
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "txt";
            saveDialog.Filter = "文本文件(*.txt)|*.txt";
            saveDialog.FileName = DateTime.Now.ToString("yyyyMMddHHmmss");
            saveDialog.ShowDialog();
            saveFileName = saveDialog.FileName;
            if (saveFileName.IndexOf(":") < 0) return; //被点了取消

            // foreach (EPC_data epc in Tag_data)
            //{
            //ExcelDataParse.WriteFileSeparator(epc.epc.Replace(" ", "") + ",", saveFileName);
            // }
        }
        /*********************************** 连接方式 2021-03-06 Start **************************************************************/

        /*********************************** 连接方式 2021-03-06 End **************************************************************/

        /// <summary>
        /// 通信连接
        /// 2015-11-9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {

            //else // SerialCommPort
            //{
            //    if (comboBoxSerialCommPort.SelectedIndex >= 0)
            //    {
            //        CommPort = int.Parse(comboBoxSerialCommPort.Text.Trim("COM".ToCharArray()));
            //        //PortOrBaudRate = 9600;
            //        if (cmb_rates.Text == "")
            //        {
            //            MessageBox.Show(rm.GetString("strMsgSelectRates"));
            //        }
            //        else
            //        {
            //            //PortOrBaudRate = Convert.ToInt32(cmb_rates.Text);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show(rm.GetString("strMsgSelectPort"));
            //        return;
            //    }
            //}
            //if (!Regex.IsMatch(tbDeviceNo.Text, "^[0-9]+$"))
            //{
            //    MessageBox.Show(rm.GetString("strMsgNotDigit"));
            //    return;
            //}
        }

        private void UpdateListEPC(object state)
        {
            UpdateEPC updateEPC = state as UpdateEPC;
        }

        public static void WriteFile(string strTxt, string path)
        {
            using (StreamWriter wlog = File.AppendText(path))
            {
                wlog.Write("{0}", strTxt);
                wlog.Write(wlog.NewLine);
            }
        }

        private void txtTemperature2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符
                }
            }
        }

        /// <summary>
        /// 闭合时间
        /// 2016-01-08
        /// hz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbRelayTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键
            if ((e.KeyChar == 0x2D) && (((ComboBox)sender).Text.Length == 0)) return;   //处理负数
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((ComboBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符
                }
            }
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            //  lock (Tag_data)
            //  {
            SaveTxt();
            //}
        }

        private void tabControl_Click(object sender, EventArgs e)
        {
            /* if (tabControl.SelectedTab.Name != "TagAccess" || tabControl.SelectedTab.Name != "SetCommParam" || tabControl.SelectedTab.Name != "SetReaderParam" || tabControl.SelectedTab.Name != "OtherOpreation")
             {
                 tabControl.SelectedIndex = 0;
                 DialogResult dr = MessageBox.Show(rm.GetString("strReadStopTips"), rm.GetString("Tips"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                 if (dr == DialogResult.OK)
                 {
                     tabControl.SelectTab(General);
                 }
             }*/
            tabControl.SelectedIndex = 0;
            DialogResult dr = MessageBox.Show(rm.GetString("strReadStopTips"), rm.GetString("Tips"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        DataTable tabInfo = null;

        private void button6_Click(object sender, EventArgs e)
        {
            byte[] byteArray = new byte[256];
            TagTID.Text = "";
            byte data_len = 0;
            if (1 == 0)
            {
                for (int i = 3; i < 2 * 6 + 3; i++) // 前面３个字节为输入的参数
                {
                    TagTID.Text += string.Format("{0:X2} ", byteArray[i]);
                }
                if (tabInfo == null)
                {
                    tabInfo = ExcelDataParse.GetTagInfo();
                }
                bool noValue = true;
                for (int row = 0; row < tabInfo.Rows.Count; row++)
                {
                    if (tabInfo.Rows[row][0].ToString() == TagTID.Text.Replace(" ", "").Substring(0, 8))
                    {
                        noValue = false;
                        label6.Text = tabInfo.Rows[row][1].ToString();
                        label15.Text = tabInfo.Rows[row][2].ToString();
                        label10.Text = tabInfo.Rows[row][3].ToString().Replace(" ", "");
                    }
                }
                if (noValue)
                {
                    label6.Text = "/";
                    label15.Text = "/";
                    label10.Text = "/";
                }
            }
        }

        #region 基本操作
        /********************************************基本操作 2021-03-09 Start**************************************************************/
        private void btnUpdateSerialPort_Click(object sender, EventArgs e)
        {
            // 获得串口列表
            GetSerialPortList(ref cbbSerialPort);
            if (cbbSerialPort.Items.Count > 0)
            {
                cbbSerialPort.SelectedIndex = 0;
            }
        }

        private void btnReadOnce_Click(object sender, EventArgs e)
        {
            ThreadStart childref = new ThreadStart(singleReadTag);
            //创建Thread类的实例
            Thread childThread = new Thread(childref);
            childThread.Start(); //开始一个线程
        }

        private void btnUpdateTCPClient_Click(object sender, EventArgs e)
        {
            try
            {
                cbbTCPClientIP.Items.Clear();
                cbbTCPClientIP.Text = "";
                cbbTCPClientIP.SelectedIndex = -1;
                int result = 0;
                result = JTDM.StartSearchDev(out JTDM.m_DevCnt);
                if (result > 0)
                {
                    for (int i = 0; i < JTDM.m_DevCnt; i++)
                    {
                        byte mode = 0;
                        result = JTDM.QueryNetworkMode((byte)i, out mode);
                        if (result > 0 && mode == 0)
                        {
                            byte[] IP = new byte[50];
                            result = JTDM.QueryIP((byte)i, IP);
                            if (result > 0)
                            {
                                string IP_address = System.Text.Encoding.ASCII.GetString(IP);
                                cbbTCPClientIP.Items.Add(IP_address);
                            }
                        }
                    }
                    if (cbbTCPClientIP.Items.Count > 0)
                    {
                        cbbTCPClientIP.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception e2)
            {
                lblMessageHit.Text = e2.Message;
            }
        }

        private void btnTCPClientConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!Regex.IsMatch(cbbTCPClientIP.Text, "^[0-9.]+$")) || cbbTCPClientIP.Text.Length < 7 || cbbTCPClientIP.Text.Length > 15)
                {
                    lblMessageHit.Text = rm.GetString("strMsgInvalidIPAdd");
                    return;
                }
                if (!Regex.IsMatch(tbTCPClientPort.Text, "^[0-9]+$") || tbTCPClientPort.Text.Length > 5)
                {
                    lblMessageHit.Text = rm.GetString("strMsgInvalidPort");
                    return;
                }
                string IP = cbbTCPClientIP.Text;
                int port = Convert.ToInt32(tbTCPClientPort.Text);
                foreach (string keys in hashMap.Keys)
                {
                    int index = keys.IndexOf('_');
                    if (index != -1)
                    {
                        string temp = keys.Substring(0, index);
                        if (IP == temp)
                        {
                            lblMessageHit.Text = rm.GetString("strMessageRepeatedConnection");
                            return;
                        }
                    }
                }
                UIntPtr device = UIntPtr.Zero;
                int result = TM200.ConnectDev(ref device, data_callback, IP, port);
                if (result < 1)
                {
                    lblMessageHit.Text = rm.GetString("strMsgConnectFailure");
                    return;
                }

                lblMessageHit.Text = rm.GetString("strMsgConnectSuccessed");
                //string key = IP + "_(" + device + ")";// "_已连接";
                string key = getDeviceKey(IP, device);
                hashMap.Add(key, device);
                TreeNode node1 = new TreeNode(key);
                tvConnectList.Nodes[0].Nodes[1].Nodes.Add(node1);
                tvConnectList.ExpandAll();
                tvConnectList.SelectedNode = node1;
                btnStartMonitor.Enabled = false;
                btnStopMonitor.Enabled = false;
            }
            catch (Exception e2)
            {
                lblMessageHit.Text = e2.Message;
            }
        }

        private void btnTCPClientDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                int result = TM200.DisconnectDev(hashMap[key]);
                if (result < 1)
                {
                    lblMessageHit.Text = rm.GetString("strMsgDisconnectConnectFailure");
                    return;
                }
                hashMap.Remove(key);
                lblMessageHit.Text = rm.GetString("strMsgDisconnectConnectSuccessed");
                TreeNode node = tvConnectList.SelectedNode;
                tvConnectList.Nodes[0].Nodes[1].Nodes.Remove(node);
                if (hashMap.Count == 0)
                {
                    btnStartMonitor.Enabled = true;
                    btnStopMonitor.Enabled = true;
                }
                //Console.WriteLine(key + " : " + "断开*******************************************************************************");
            }
            catch (Exception e2)
            {
                lblMessageHit.Text = e2.Message;
            }
        }

        private void QueryLocalHost(ComboBox localHost)
        {
            try
            {
                localHost.Items.Clear();
                localHost.Text = "";

                byte[] IP = new byte[50];
                byte count = 0;
                int result = JTDM.QueryLocalHosts(IP, out count);
                string[] host = (System.Text.Encoding.ASCII.GetString(IP)).Replace("\0", "").Split(',');
                for (int i = 0; i < count; i++)
                {
                    localHost.Items.Add(host[i]);
                }
                if (count > 0)
                {
                    localHost.SelectedIndex = 0;
                }
            }
            catch (Exception e2)
            {
                lblMessageHit.Text = e2.Message;
            }
        }

        private void btnUpdateTCPServer_Click(object sender, EventArgs e)
        {
            QueryLocalHost(cbbTCPServerIP);
        }

        private void btnSerialPortConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbSerialPort.SelectedIndex == -1)
                {
                    return;
                }
                if (!Regex.IsMatch(cbbBaudRate.Text, "^[0-9]+$"))
                {
                    lblMessageHit.Text = rm.GetString("strMsgSelectBaudRate");
                    return;
                }
                String serialport = cbbSerialPort.Text;
                foreach (string keys in hashMap.Keys)
                {
                    int index = keys.IndexOf('_');
                    if (index != -1)
                    {
                        string temp = keys.Substring(0, index);
                        if (serialport == temp)
                        {
                            lblMessageHit.Text = rm.GetString("strMessageRepeatedConnection");
                            return;
                        }
                    }
                }
                int baudRate = Convert.ToInt32(cbbBaudRate.Text);
                UIntPtr device = UIntPtr.Zero;
                int result = TM200.ConnectDev(ref device, data_callback, serialport, baudRate);
                if (result < 1)
                {
                    lblMessageHit.Text = rm.GetString("strMsgConnectFailure");
                    return;
                }
                lblMessageHit.Text = rm.GetString("strMsgConnectSuccessed");
                //string key = serialport + "_(" + device + ")" + ;// "_已连接";
                string key = getDeviceKey(serialport, device);
                hashMap.Add(key, device);
                TreeNode node1 = new TreeNode(key);
                tvConnectList.Nodes[0].Nodes[0].Nodes.Add(node1);
                tvConnectList.ExpandAll();
                tvConnectList.SelectedNode = node1;
                if (hashMap.Count > 0)
                {
                    btnStartMonitor.Enabled = false;
                    btnStopMonitor.Enabled = false;
                }
            }
            catch (Exception e2)
            {
                lblMessageHit.Text = e2.Message;
            }
        }

        public string selecteDevice()
        {
            lblMessageHit.Text = "";
            TreeNode node = tvConnectList.SelectedNode;
            if (node == null || node.Text == ConnectType.online || node.Parent.Text == ConnectType.online)
            {
                lblMessageHit.Text = rm.GetString("MsgChoosebtnConnect");
                return null;
            }
            string ipText = node.Text;
            foreach (var item in hashMap)
            {
                if (item.Key == ipText)
                {
                    return ipText;
                }
            }
            return null;
        }

        private void btnSerialPortDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                int result = TM200.DisconnectDev(hashMap[key]);
                if (result < 1)
                {
                    lblMessageHit.Text = rm.GetString("strMsgDisconnectConnectFailure");
                    return;
                }
                hashMap.Remove(key);
                lblMessageHit.Text = rm.GetString("strMsgDisconnectConnectSuccess");
                TreeNode node = tvConnectList.SelectedNode;
                tvConnectList.Nodes[0].Nodes[0].Nodes.Remove(node);
                if (hashMap.Count == 0)
                {
                    btnStartMonitor.Enabled = true;
                    btnStopMonitor.Enabled = true;
                }
            }
            catch (Exception e2)
            {
                lblMessageHit.Text = e2.Message;
            }
        }

        private void tvConnectList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                //MessageBox.Show(e.Node.Text);
                int index = 0;
                string value = e.Node.Text;
                string key = value.Substring(0, 1);
                if (key != "S" && key != "T" && key != "O")
                {
                    value = e.Node.Parent.Text;
                    //MessageBox.Show(value);
                }
                switch (value)
                {
                    case ConnectType.serialport:
                        index = 0;
                        break;
                    case ConnectType.TCPClient:
                        index = 1;
                        break;
                    case ConnectType.TCPServer:
                        index = 2;
                        break;
                    default:
                        index = 3;
                        break;
                }
                if (index < 3)
                {
                    tbConnect.SelectedIndexChanged -= new System.EventHandler(this.tbConnect_SelectedIndexChanged);
                    tbConnect.SelectedIndex = index;
                    tbConnect.SelectedIndexChanged += new System.EventHandler(this.tbConnect_SelectedIndexChanged);
                }
            }
            catch (Exception e2)
            {
                lblMessageHit.Text = e2.Message;
            }
        }

        private void tbConnect_SelectedIndexChanged(object sender, EventArgs e)
        {
            tvConnectList.SelectedNode = null;
        }

        private void btnBrushVersion_Click(object sender, EventArgs e)
        {
            lblVersion.Text = "";
            lblMessageHit.Text = "";
        }

        private void btnReadVersion_Click(object sender, EventArgs e)
        {
            ThreadStart childref = new ThreadStart(queryVersion);
            Thread childThread = new Thread(childref);
            childThread.Start();
        }

        private void queryVersion()
        {
            try
            {
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                byte[] version = new byte[100];
                int result = TM200.QueryVersion(hashMap[key], version);
                string showInfo = "";
                lblVersion.Text = "";
                lblMessageHit.Text = "";
                if (result > 0)
                {
                    string ver = System.Text.Encoding.ASCII.GetString(version);
                    lblVersion.Text = ver;
                    showInfo = rm.GetString("strMsgQueryVersionSuccessed");
                }
                else
                {
                    showInfo = rm.GetString("strMsgQueryVersionFailure");
                }
                lblMessageHit.Text = showInfo;
            }
            catch (Exception e)
            {
                lblMessageHit.Text = e.Message;
            }
        }

        #region 数据添加到Table

        static ListViewItem[] lvi = new ListViewItem[1];

       
        private void export(List<EPC_data> list)
        {
            //string path = AppDomain.CurrentDomain.BaseDirectory + "url_" + Guid.NewGuid().ToString() + ".xls";
            string dateTime = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss_fff");
            string path = AppDomain.CurrentDomain.BaseDirectory + dateTime + ".xls";
            StringBuilder sb = new StringBuilder();
            int index = 0;

            foreach (EPC_data item in list)
            {
                //EPC_data item = kv.Value;
                if (index == 0)
                {
                    sb.Append("No.\t");
                    sb.Append("TagId\t");
                    sb.Append("EPC\t");
                    sb.Append("TID\t");
                    sb.Append("User\t");
                    sb.Append("Count\t");
                    sb.Append("Antenna\t");
                    sb.Append("RSSI\t");
                    sb.Append("DeviceNo\t");
                    sb.Append("Direction\t");
                    sb.Append("Uart/IP\t");
                    sb.Append("DateTime\t");
                    sb.Append("Alarm State\t");
                    sb.Append("Private Data\t");
                    sb.Append("Temperature\t");
                    sb.AppendLine("User Custom Data\t");
                }
                index++;
                sb.Append(index);
                sb.Append("\t");
                sb.Append(item.tagId);
                sb.Append("\t");
                sb.Append(item.epc);
                sb.Append("\t");
                sb.Append(item.tid);
                sb.Append("\t");
                sb.Append(item.user);
                sb.Append("\t");
                sb.Append(item.count);
                sb.Append("\t");
                sb.Append(item.antennaId);
                sb.Append("\t");
                sb.Append(" " + item.rssi);
                sb.Append("\t");
                sb.Append(item.deviceId);
                sb.Append("\t");
                sb.Append(item.direction);
                sb.Append("\t");
                sb.Append(item.host);
                sb.Append("\t");
                sb.Append(" " + item.readTagTime);
                sb.Append("\t");
                sb.Append(" " + item.alarmStatus);
                sb.Append("\t");
                sb.Append(" " + item.privateData);
                sb.Append("\t");
                sb.Append(" " + item.temperature);
                sb.Append("\t");
                sb.Append(" " + item.userCustomeData);
                sb.AppendLine("\t");
                // Console.Write(string.Format("{0}:{1}", item.Key, item.Value));
            }
            System.IO.File.WriteAllText(path, sb.ToString(), Encoding.ASCII);
            lblMessageHit.BeginInvoke(new Action(() =>
            {
                string temp = path;
                //string temp = "File Name: " + path;
                lblMessageHit.Text = temp;
            }));
        }

        private void UpdateLV()
        {
            try
            {
                listView.BeginUpdate();
                listView.Items.Clear();
                for (int i = 1; i <= Tag_data.Count; ++i)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = i.ToString();
                    lvi.SubItems.Add(Tag_data[i - 1].tagId);
                    lvi.SubItems.Add(Tag_data[i - 1].epc);
                    lvi.SubItems.Add(Tag_data[i - 1].tid);
                    lvi.SubItems.Add(Tag_data[i - 1].user);
                    lvi.SubItems.Add(Tag_data[i - 1].pcValue);
                    lvi.SubItems.Add(Tag_data[i - 1].count.ToString());
                    lvi.SubItems.Add(Tag_data[i - 1].antennaId);
                    lvi.SubItems.Add(Tag_data[i - 1].rssi);
                    lvi.SubItems.Add(Tag_data[i - 1].deviceId.ToString());
                    lvi.SubItems.Add(Tag_data[i - 1].direction);
                    lvi.SubItems.Add(Tag_data[i - 1].host);
                    lvi.SubItems.Add(Tag_data[i - 1].readTagTime);
                    lvi.SubItems.Add(Tag_data[i - 1].alarmStatus);
                    lvi.SubItems.Add(Tag_data[i - 1].privateData);
                    lvi.SubItems.Add(Tag_data[i - 1].temperature);
                    lvi.SubItems.Add(Tag_data[i - 1].userCustomeData);
                    listView.Items.Add(lvi);
                }
                listView.EndUpdate();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        private void beginInv()
        {
            try
            {
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                currentStatus = true;
                btnClearListView.Enabled = false;
                int result = TM200.BeginInv(hashMap[key]);
                if (result > 0)
                {
                    lblMessageHit.Text = rm.GetString("strMessageContinueReadTagSuccessed");
                    return;
                }
                else
                {
                    lblMessageHit.Text = rm.GetString("strMessageContinueReadTagFailure");
                }
            }
            catch (Exception e)
            {
                lblMessageHit.Text = e.Message;
            }
        }

        static Boolean currentStatus = false;
        /// <summary>
        /// 开始连续寻卡
        /// 2015-11-9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            ThreadStart childref = new ThreadStart(beginInv);
            Thread childThread = new Thread(childref);
            childThread.Start();
        }

        private void stopInv()
        {

            try
            {
                string key = selecteDevice();
                currentStatus = false;
                if (null == key)
                {
                    return;
                }
                btnClearListView.Enabled = true;
                int result = TM200.StopInv(hashMap[key]);
                if (result == 0)
                {
                    lblMessageHit.Text = rm.GetString("strMessageStopContinueReadTagFailure");
                    return;
                }
                lblMessageHit.Text = rm.GetString("strMessageStopContinueReadTagSuccessed");
            }
            catch (Exception e)
            {
                lblMessageHit.Text = e.Message;
            }
        }

        /// <summary>
        /// 停止连续寻卡
        /// 2015-11-9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            ThreadStart childref = new ThreadStart(stopInv);
            Thread childThread = new Thread(childref);
            childThread.Start();
        }

        /// <summary>
        /// 清空
        /// 2015-11-9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (currentStatus)
            {
                lblMessageHit.Text = "请先停止，再操作清空!";
                return;
            }
            for (int i = 0; i < firstIndex.Length; i++)
            {
                firstIndex[i] = 0;//控制列宽显示
            }
            for (int i = 0; i < secondIndex.Length; i++)
            {
                secondIndex[i] = 0;//标签类型0x08控制列宽显示
            }
            for (int i = 0; i < thirdIndex.Length; i++)
            {
                thirdIndex[i] = 0;//标签类型0x0D控制列宽显示
            }
            lblTagCount.Text = "0";
            lblCount.Text = "0";
            //sortList.Clear();
            Tag_data.Clear();
            listView.Items.Clear();
        }

        /// <summary>
        /// 升序
        /// 2015-11-9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbAsc_CheckedChanged(object sender, EventArgs e)
        {
            lock (Tag_data)
            {
                Tag_data.Sort();
                UpdateLV();
            }
        }

        /// <summary>
        /// 降序
        /// 2015-11-9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbDesc_CheckedChanged(object sender, EventArgs e)
        {
            lock (Tag_data)
            {
                Tag_data.Sort();
                Tag_data.Reverse();
                UpdateLV();
            }
        }


        #endregion 数据添加到Table

        #region 更新串口列表
        public void GetSerialPortList(ref ComboBox comboBoxSP)
        {
            comboBoxSP.Items.Clear();
            string[] uart = SerialPort.GetPortNames();
            for (int i = uart.Length - 1; i >= 0; i--)
            {
                comboBoxSP.Items.Add(uart[i]);
            }
            //comboBoxSP.Items.AddRange();
            if (comboBoxSP.Items.Count > 0)
            {
                comboBoxSP.SelectedIndex = 0;
            }
        }
        #endregion 更新串口列表

        /********************************************基本操作 2021-03-09 End**************************************************************/
        #endregion 基本操作

        #region 标签操作
        /********************************************标签操作 2021-03-09 Start**************************************************************/
        private void btnClearData_Click(object sender, EventArgs e)
        {
            tbRWData.Text = "";
            counts = 1;
            tbRWData.Focus();
        }

        private void cbbStartAdd_SelectedIndexChanged(object sender, EventArgs e)
        { // 根据起始地址，确定长度选项
            int nItem = cbbStartAdd.SelectedIndex; // 取出起始地址索引值
            int maxLength = addEnd - addStart - nItem + 1;
            cbbLength.Items.Clear();
            for (int i = 1; i <= maxLength; ++i)
            {
                cbbLength.Items.Add(i.ToString());
            }
            cbbLength.SelectedIndex = maxLength - 1;
        }

        private void cbbRWBank_SelectedIndexChanged(object sender, EventArgs e)
        {   // 根据操作区域，确定有效的起始地址
            if (cbbRWBank.SelectedIndex == 0) // 保留区
            {
                addStart = 0;
                addEnd = 3;
            }
            else if (cbbRWBank.SelectedIndex == 1) // EPC区
            {
                addStart = 2;
                addEnd = 7;
            }
            else if (cbbRWBank.SelectedIndex == 2) // TID
            {
                addStart = 0;
                addEnd = 5;
            }
            else if (cbbRWBank.SelectedIndex == 3) // User
            {
                addStart = 0;
                addEnd = 31;
                //addEnd = 128;
            }
            cbbStartAdd.Items.Clear();
            for (int i = addStart; i <= addEnd; ++i)
            {
                cbbStartAdd.Items.Add(i.ToString());
            }
            cbbStartAdd.SelectedIndex = 0;
        }

        private void singleReadTag()
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            int result = TM200.SingleTagInv(hashMap[key]);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMessageReadOnceFailure");
                return;
            }
            else
            {
                lblMessageHit.Text = rm.GetString("strMessageReadOnceSuccessed");
            }
            //InsertTag(outData, data_len, antenna_no, device_no, IP_or_comm);
        }

        private void btnReadFastTag_Click(object sender, EventArgs e)
        {
            ThreadStart childref = new ThreadStart(readFastTag);
            Thread childThread = new Thread(childref);
            childThread.Start();
        }

        private void btnFastWrite_Click(object sender, EventArgs e)
        {
            ThreadStart childref = new ThreadStart(fastWriteTag);
            Thread childThread = new Thread(childref);
            childThread.Start();
        }
        private void btnClearFWData_Click(object sender, EventArgs e)
        {
            tbFWData.Text = "";
            tbFWData.Focus();
        }

        private void btnReadData_Click(object sender, EventArgs e)
        {

            bool result = chkMatchParameter.Checked;
            if (result)
            {
                ThreadStart childref = new ThreadStart(tagReadDataParams);
                Thread childThread = new Thread(childref);
                childThread.Start();
            }
            else 
            {
                ThreadStart childref = new ThreadStart(tagReadData);
                Thread childThread = new Thread(childref);
                childThread.Start();
            }
        }

        private void btnWriteData_Click(object sender, EventArgs e)
        {
              bool result = chkMatchParameter.Checked;
              if (result)
              {
                  ThreadStart childref = new ThreadStart(tagWriteDataParams);
                  Thread childThread = new Thread(childref);
                  childThread.Start();
              }
              else 
              {
                  ThreadStart childref = new ThreadStart(tagWrietData);
                  Thread childThread = new Thread(childref);
                  childThread.Start();
              }
        }

        private void CallBack(object sender, EventArgs e)
        {
            connReadTag();
        }

        private void btn_connRead_Click(object sender, EventArgs e)
        {
            // 设置事件
            timerConnRead.Tick += new EventHandler(CallBack);
            timerConnRead.Enabled = true;
            timerConnRead.Interval = 1000;
        }

        private void btn_stoptimer_Click(object sender, EventArgs e)
        {
            timerConnRead.Enabled = false;   //停止连续读取定时器
        }

        private void btnInitTag_Click(object sender, EventArgs e)
        {
            ThreadStart childref = new ThreadStart(initTag);
            Thread childThread = new Thread(childref);
            childThread.Start();
        }

        private void btnKillTag_Click(object sender, EventArgs e)
        {
            bool result = chkMatchParameter.Checked;
            if (result)
            {
                ThreadStart childref = new ThreadStart(killTagParams);
                Thread childThread = new Thread(childref);
                childThread.Start();
            }
            else 
            {
                ThreadStart childref = new ThreadStart(killTag);
                Thread childThread = new Thread(childref);
                childThread.Start();
            }
        }

        private void btnLockTag_Click(object sender, EventArgs e)
        {
            bool result = chkMatchParameter.Checked;
            if (result)
            {
                ThreadStart childref = new ThreadStart(lockTagParams);
                Thread childThread = new Thread(childref);
                childThread.Start();
            }
            else 
            {
                ThreadStart childref = new ThreadStart(lockTag);
                Thread childThread = new Thread(childref);
                childThread.Start();
            }
        }

        private void unLockTag()
        {
            string strpwd = tbLockAccessPwd.Text.Replace(" ", "");
            if (strpwd.Length != 8)
            {
                lblMessageHit.Text = rm.GetString("strMsgPwdMustEight");
                return;
            }
            if (!DataConvert.IsHexCharacter(strpwd))
            {
                lblMessageHit.Text = rm.GetString("strMsgPwdInvalidChar");
                return;
            }
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            byte[] pwd = new byte[4];
            for (int i = 0; i < 4; ++i)
            {
                pwd[i] = Convert.ToByte(strpwd.Substring(i * 2, 2), 16); // 把字符串的子串转为16进制的8位无符号整数
            }
            int unlockBank = cbbLockBank.SelectedIndex;
            if (-1 == unlockBank)
            {
                lblMessageHit.Text = rm.GetString("strMsgSelecOprBank");
                return;
            }
            if (1 == 0)
            {
                lblMessageHit.Text = rm.GetString("strMsgSucceedUnlock");
            }
            else
            {
                lblMessageHit.Text = rm.GetString("strMsgFailedUnlock");
            }
        }

        private void lockTag()
        {
            int lockBank = -1;
            int lockType = -1;
            lblMessageHit.Text = "";

            string strpwd = tbLockAccessPwd.Text.Replace(" ", "");
            if (strpwd.Length != 8)
            {
                lblMessageHit.Text = rm.GetString("strMsgPwdMustEight");
                return;
            }
            if (!DataConvert.IsHexCharacter(strpwd))
            {
                lblMessageHit.Text = rm.GetString("strMsgPwdInvalidChar");
                return;
            }
            if ((lockBank = cbbLockBank.SelectedIndex) == -1)
            {
                lblMessageHit.Text = rm.GetString("strMsgSelecOprBank");
                return;
            }

            if ((lockType = cbbLockType.SelectedIndex) == -1)
            {
                lblMessageHit.Text = rm.GetString("strMsgSelecOprBank");
                return;
            }
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            byte[] pwd = new byte[4];
            for (int i = 0; i < 4; ++i)
            {
                pwd[i] = Convert.ToByte(strpwd.Substring(i * 2, 2), 16); // 把字符串的子串转为16进制的8位无符号整数
            }
            int result = TM200.LockOrUnlockTag(hashMap[key], (byte)lockBank, (byte)lockType, pwd);
            if (1 == result)
            {
                lblMessageHit.Text = rm.GetString("strMsgSucceedLock");
            }
            else
            {
                lblMessageHit.Text = rm.GetString("strMsgFailedLock");
            }
            return;
        }

        private void lockTagParams()
        {
            int lockBank = -1;
            int lockType = -1;
            lblMessageHit.Text = "";

            string strpwd = tbLockAccessPwd.Text.Replace(" ", "");
            if (strpwd.Length != 8)
            {
                lblMessageHit.Text = rm.GetString("strMsgPwdMustEight");
                return;
            }
            if (!DataConvert.IsHexCharacter(strpwd))
            {
                lblMessageHit.Text = rm.GetString("strMsgPwdInvalidChar");
                return;
            }
            if ((lockBank = cbbLockBank.SelectedIndex) == -1)
            {
                lblMessageHit.Text = rm.GetString("strMsgSelecOprBank");
                return;
            }

            if ((lockType = cbbLockType.SelectedIndex) == -1)
            {
                lblMessageHit.Text = rm.GetString("strMsgSelecOprBank");
                return;
            }
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            byte[] pwd = new byte[4];
            for (int i = 0; i < 4; ++i)
            {
                pwd[i] = Convert.ToByte(strpwd.Substring(i * 2, 2), 16); // 把字符串的子串转为16进制的8位无符号整数
            }
            int Length = -1;
            int StartAdd = -1;
            string strMatchData = tbMatchData.Text.Replace(" ", "");
            if (strMatchData.Length == 0)
            {
                lblMessageHit.Text = rm.GetString("strMsgDataNotEmpty");
                return;
            }
            if (!Regex.IsMatch(strMatchData, "^[0-9A-Fa-f]+$"))
            {
                lblMessageHit.Text = rm.GetString("strMsgPwdInvalidChar");
                return;
            }
            if (strMatchData.Length % 4 != 0)
            {
                lblMessageHit.Text = rm.GetString("strMsgDataMustFourTimes");
                return;
            }
            int length = strMatchData.Length / 2;
            byte[] matchData = new byte[64];
            for (int i = 0; i < length; ++i)
            {
                matchData[i] = Convert.ToByte(strMatchData.Substring(2 * i, 2), 16);
            }
            StartAdd = int.Parse(cbbStartAdd.Text);
            Length = int.Parse(cbbLength.Text);

            string strData = tbRWData.Text.Replace(" ", "");// 去空格
            if (strData.Length % 4 != 0 || strData.Length / 4 != Length)
            {
                lblMessageHit.Text = rm.GetString("strMsgLengthDiff");
                return;
            }
            if (!DataConvert.IsHexCharacter(strData))
            {
                lblMessageHit.Text = rm.GetString("strMsgPwdInvalidChar");
                return;
            }

            byte[] byteArray = new byte[256];
            for (int i = 0; i < 2 * Length; ++i)
            {
                byteArray[i] = Convert.ToByte(strData.Substring(2 * i, 2), 16);
            }
            byte mode = (byte)cbbMatchMode.SelectedIndex;
            int result = TM200.LockOrUnlockTagMatchParameter(hashMap[key], (byte)lockBank, (byte)lockType, pwd, mode, (byte)length, matchData);
            if (1 == result)
            {
                lblMessageHit.Text = rm.GetString("strMsgSucceedLock");
            }
            else
            {
                lblMessageHit.Text = rm.GetString("strMsgFailedLock");
            }
            return;
        }

        private void killTag()
        {
            string strKillPwd = tbKillKillPwd.Text.Replace(" ", "");
            if (strKillPwd.Length != 8)
            {
                lblMessageHit.Text = rm.GetString("strMsgPwdMustEight");
                return;
            }
            if (!DataConvert.IsHexCharacter(strKillPwd))
            {
                lblMessageHit.Text = rm.GetString("strMsgPwdInvalidChar");
                return;
            }
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            byte[] byteAccessPwd = new byte[4];
            byte[] byteKillPwd = new byte[4];
            for (int i = 0; i < 4; ++i)
            {
                byteKillPwd[i] = Convert.ToByte(strKillPwd.Substring(i * 2, 2), 16);
            }
            int result = TM200.KillTag(hashMap[key], byteKillPwd);
            if (1 == result)
            {
                lblMessageHit.Text = rm.GetString("strMsgSucceedDes");
            }
            else
            {
                lblMessageHit.Text = rm.GetString("strMsgFailedDes");
            }
        }

        private void killTagParams()
        {
            string strKillPwd = tbKillKillPwd.Text.Replace(" ", "");
            if (strKillPwd.Length != 8)
            {
                lblMessageHit.Text = rm.GetString("strMsgPwdMustEight");
                return;
            }
            if (!DataConvert.IsHexCharacter(strKillPwd))
            {
                lblMessageHit.Text = rm.GetString("strMsgPwdInvalidChar");
                return;
            }
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            byte[] byteAccessPwd = new byte[4];
            byte[] byteKillPwd = new byte[4];
            for (int i = 0; i < 4; ++i)
            {
                byteKillPwd[i] = Convert.ToByte(strKillPwd.Substring(i * 2, 2), 16);
            }

            string strMatchData = tbMatchData.Text.Replace(" ", "");
            if (strMatchData.Length == 0)
            {
                lblMessageHit.Text = rm.GetString("strMsgDataNotEmpty");
                return;
            }
            if (!Regex.IsMatch(strMatchData, "^[0-9A-Fa-f]+$"))
            {
                lblMessageHit.Text = rm.GetString("strMsgPwdInvalidChar");
                return;
            }
            if (strMatchData.Length % 4 != 0)
            {
                lblMessageHit.Text = rm.GetString("strMsgDataMustFourTimes");
                return;
            }

            int length = strMatchData.Length / 2;
            byte[] matchData = new byte[64];
            for (int i = 0; i < length; ++i)
            {
                matchData[i] = Convert.ToByte(strMatchData.Substring(2 * i, 2), 16);
            }

            byte mode = (byte)cbbMatchMode.SelectedIndex;
            int result = TM200.KillTagMatchParameter(hashMap[key], byteKillPwd, mode, (byte)length, matchData);
            if (1 == result)
            {
                lblMessageHit.Text = rm.GetString("strMsgSucceedDes");
            }
            else
            {
                lblMessageHit.Text = rm.GetString("strMsgFailedDes");
            }
        }

        private void connReadTag()
        {
            int RWBank = -1;
            int StartAdd = -1;
            int Length = -1;
            if ((RWBank = cbbRWBank.SelectedIndex) == -1)
            {
                lblMessageHit.Text = rm.GetString("strMsgSelectRWBank");
                return;
            }
            if ((StartAdd = cbbStartAdd.SelectedIndex) == -1)
            {
                lblMessageHit.Text = rm.GetString("strMsgSelectStartAdd");
                return;
            }
            StartAdd = int.Parse(cbbStartAdd.Text);
            if ((Length = cbbLength.SelectedIndex) == -1)
            {
                lblMessageHit.Text = rm.GetString("strMsgSelectLength");
                return;
            }
            Length = int.Parse(cbbLength.Text);
            byte[] byteArray = new byte[100];
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            byte data_len = 0;
            timerConnRead.Enabled = true;   //开启连续读取定时器
            timerConnRead.Interval = 1500;
            //tbRWData.Text = string.Empty;
            int result = TM200.ReadTagData(hashMap[key], (byte)RWBank, (byte)StartAdd, (byte)Length, byteArray, ref data_len);
            if (0 == result)
            {
                lblMessageHit.Text = rm.GetString("strMsgFailedReadData");
                return;
            }
            string tags = string.Empty;
            for (int i = 0; i < data_len; i++) // 前面３个字节为输入的参数
            {
                tags += string.Format("{0:X2} ", byteArray[i]);
            }
            if (tbRWData.Text == "")
            {
                tbRWData.Text = counts + "." + " " + tags;
                counts = counts + 1;
                //tbRWData.Text = tags;
            }
            else
            {
                //tbRWData.Text =tbRWData.Text +"\r"+"\n"+ tags;
                tbRWData.Text = tbRWData.Text + "\r" + "\n" + counts + "." + " " + tags;
                counts = counts + 1;
            }
            tbRWData.Focus();
            this.tbRWData.Select(this.tbRWData.TextLength, 0);//光标定位到文本最后
            this.tbRWData.ScrollToCaret();//滚动到光标处
            lblMessageHit.Text = rm.GetString("strMsgSussecReadData");
        }

        private void tagWrietData()
        {
            int RWBank = -1;
            int StartAdd = -1;
            int Length = -1;
            if ((RWBank = cbbRWBank.SelectedIndex) == -1)
            {
                lblMessageHit.Text = rm.GetString("strMsgSelectRWBank");
                return;
            }
            StartAdd = int.Parse(cbbStartAdd.Text);
            Length = int.Parse(cbbLength.Text);

            string strData = tbRWData.Text.Replace(" ", "");// 去空格
            if (strData.Length % 4 != 0 || strData.Length / 4 != Length)
            {
                lblMessageHit.Text = rm.GetString("strMsgLengthDiff");
                return;
            }
            if (!DataConvert.IsHexCharacter(strData))
            {
                lblMessageHit.Text = rm.GetString("strMsgPwdInvalidChar");
                return;
            }

            byte[] byteArray = new byte[256];
            for (int i = 0; i < 2 * Length; ++i)
            {
                byteArray[i] = Convert.ToByte(strData.Substring(2 * i, 2), 16);
            }
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            int result = TM200.WriteTagData(hashMap[key], (byte)RWBank, (byte)StartAdd, (byte)Length, byteArray);
            if (0 == result)
            {
                lblMessageHit.Text = rm.GetString("strMsgFailedWrite");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMsgSucceedWrite");
        }

        private void tagReadData()
        {
            try
            {
                int RWBank = -1;
                int StartAdd = -1;
                int Length = -1;
                if ((RWBank = cbbRWBank.SelectedIndex) == -1)
                {
                    lblMessageHit.Text = rm.GetString("strMsgSelectRWBank");
                    return;
                }
                StartAdd = int.Parse(cbbStartAdd.Text);
                Length = int.Parse(cbbLength.Text);
                byte[] byteArray = new byte[100];
                tbRWData.Text = "";
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                byte data_len = 0;
                tbRWData.Text = string.Empty;
                int result = TM200.ReadTagData(hashMap[key], (byte)RWBank, (byte)StartAdd, (byte)Length, byteArray, ref data_len);
                if (0 == result)
                {
                    lblMessageHit.Text = rm.GetString("strMsgFailedReadData");
                    return;
                }
                for (int i = 0; i < data_len; i++) // 前面３个字节为输入的参数
                {
                    tbRWData.Text += string.Format("{0:X2} ", byteArray[i]);
                }
                lblMessageHit.Text = rm.GetString("strMsgSussecReadData");
            }
            catch
            {
                lblMessageHit.Text = rm.GetString("strMsgFailedReadData");
            }
        }

        private void tagReadDataParams()
        {
            try
            {
                int RWBank = -1;
                int StartAdd = -1;
                int Length = -1;
                if ((RWBank = cbbRWBank.SelectedIndex) == -1)
                {
                    lblMessageHit.Text = rm.GetString("strMsgSelectRWBank");
                    return;
                }
                string strData = tbMatchData.Text.Replace(" ", "");
                if (strData.Length == 0)
                {
                    lblMessageHit.Text = rm.GetString("strMsgDataNotEmpty");
                    return;
                }
                if (!Regex.IsMatch(strData, "^[0-9A-Fa-f]+$"))
                {
                    lblMessageHit.Text = rm.GetString("strMsgPwdInvalidChar");
                    return;
                }
                if (strData.Length % 4 != 0)
                {
                    lblMessageHit.Text = rm.GetString("strMsgDataMustFourTimes");
                    return;
                }
                int length = strData.Length / 2;
                byte[] matchData = new byte[64];
                for (int i = 0; i < length; ++i)
                {
                    matchData[i] = Convert.ToByte(strData.Substring(2 * i, 2), 16);
                }
                StartAdd = int.Parse(cbbStartAdd.Text);
                Length = int.Parse(cbbLength.Text);
                byte[] byteArray = new byte[100];
                tbRWData.Text = "";
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                byte data_len = 0;
                tbRWData.Text = string.Empty;
                byte mode = (byte)cbbMatchMode.SelectedIndex;
                int result = TM200.ReadTagDataMatchParameter(hashMap[key], (byte)RWBank, (byte)StartAdd, (byte)Length, byteArray, ref data_len, mode, (byte)length, matchData);
                if (0 == result)
                {
                    lblMessageHit.Text = rm.GetString("strMsgFailedReadData");
                    return;
                }
                for (int i = 0; i < data_len; i++) // 前面３个字节为输入的参数
                {
                    tbRWData.Text += string.Format("{0:X2} ", byteArray[i]);
                }
                lblMessageHit.Text = rm.GetString("strMsgSussecReadData");
            }
            catch
            {
                lblMessageHit.Text = rm.GetString("strMsgFailedReadData");
            }
        }

        private void tagWriteDataParams()
        {
            try
            {
                int RWBank = -1;
                int StartAdd = -1;
                int Length = -1;
                if ((RWBank = cbbRWBank.SelectedIndex) == -1)
                {
                    lblMessageHit.Text = rm.GetString("strMsgSelectRWBank");
                    return;
                }
                string strMatchData = tbMatchData.Text.Replace(" ", "");
                if (strMatchData.Length == 0)
                {
                    lblMessageHit.Text = rm.GetString("strMsgDataNotEmpty");
                    return;
                }
                if (!Regex.IsMatch(strMatchData, "^[0-9A-Fa-f]+$"))
                {
                    lblMessageHit.Text = rm.GetString("strMsgPwdInvalidChar");
                    return;
                }
                if (strMatchData.Length % 4 != 0)
                {
                    lblMessageHit.Text = rm.GetString("strMsgDataMustFourTimes");
                    return;
                }

                int length = strMatchData.Length / 2;
                byte[] matchData = new byte[64];
                for (int i = 0; i < length; ++i)
                {
                    matchData[i] = Convert.ToByte(strMatchData.Substring(2 * i, 2), 16);
                }
                StartAdd = int.Parse(cbbStartAdd.Text);
                Length = int.Parse(cbbLength.Text);

                string strData = tbRWData.Text.Replace(" ", "");// 去空格
                if (strData.Length % 4 != 0 || strData.Length / 4 != Length)
                {
                    lblMessageHit.Text = rm.GetString("strMsgLengthDiff");
                    return;
                }
                if (!DataConvert.IsHexCharacter(strData))
                {
                    lblMessageHit.Text = rm.GetString("strMsgPwdInvalidChar");
                    return;
                }

                byte[] byteArray = new byte[256];
                for (int i = 0; i < 2 * Length; ++i)
                {
                    byteArray[i] = Convert.ToByte(strData.Substring(2 * i, 2), 16);
                }
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                byte mode = (byte)cbbMatchMode.SelectedIndex;
                int result = TM200.WriteTagDataMatchParameter(hashMap[key], (byte)RWBank, (byte)StartAdd, (byte)Length, byteArray, mode, (byte)length, matchData);
                if (0 == result)
                {
                    lblMessageHit.Text = rm.GetString("strMsgFailedWrite");
                    return;
                }
                lblMessageHit.Text = rm.GetString("strMsgSucceedWrite");
            }
            catch
            {
                lblMessageHit.Text = rm.GetString("strMsgFailedReadData");
            }
        }

        private void fastWriteTag()
        {
            try
            {
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                string strData = tbFWData.Text.Replace(" ", "");
                if (strData.Length == 0)
                {
                    lblMessageHit.Text = rm.GetString("strMsgDataNotEmpty");
                    return;
                }
                if (!Regex.IsMatch(strData, "^[0-9A-Fa-f]+$"))
                {
                    lblMessageHit.Text = rm.GetString("strMsgPwdInvalidChar");
                    return;
                }
                if (strData.Length % 4 != 0)
                {
                    lblMessageHit.Text = rm.GetString("strMsgDataMustFourTimes");
                    return;
                }
                int leng = strData.Length / 2;
                byte[] byteArray = new byte[64];
                for (int i = 0; i < leng; ++i)
                {
                    byteArray[i] = Convert.ToByte(strData.Substring(2 * i, 2), 16);
                }
                string strEpc = strData;
                byte dateLength = (byte)(leng / 2);
                byte startAddress = (byte)(8 - dateLength);
                int result = TM200.WriteTagData(hashMap[key], 1, startAddress, dateLength, byteArray);
                if (1 > result)
                {
                    lblMessageHit.Text = rm.GetString("strMsgFailedWrite");
                    return;
                }
                lblMessageHit.Text = rm.GetString("strMsgSucceedWrite");
                if (chkZD.Checked)//自动增1 2016-04-08 hz
                {
                    strEpc = PageFun.AddStr(strData, 1, 0);
                    for (int i = 0; i < leng - 1; ++i)
                    {
                        // strEpc += string.Format("{0:X2} ", byteArray[i]);
                        strEpc = PageFun.AddStr(strData, 1, 0);
                    }
                }
                for (int i = 0; i < leng; ++i)
                {
                    byteArray[i] = Convert.ToByte(strEpc.Substring(2 * i, 2), 16);
                }
                strEpc = "";
                for (int i = 0; i < leng; ++i)
                {
                    strEpc += string.Format("{0:X2} ", byteArray[i]);
                }
                tbFWData.Text = strEpc;
            }
            catch (Exception e)
            {
                lblMessageHit.Text = e.Message;
            }
        }

        private void readFastTag()
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            byte bank = 1;
            byte begin = 2;
            byte length = 6;
            byte[] data = new byte[12];
            byte data_len = 0;
            tbFWData.Text = string.Empty;
            int result = TM200.ReadTagData(hashMap[key], bank, begin, length, data, ref data_len);
            if (0 < result)
            {
                for (int i = 0; i < data_len; i++) // 前面３个字节为输入的参数
                {
                    tbFWData.Text += string.Format("{0:X2} ", data[i]);
                }
                lblMessageHit.Text = rm.GetString("strMsgSussecReadData");
            }
            else
            {
                lblMessageHit.Text = rm.GetString("strMsgFailedReadData");
            }
        }

        private void initTag()
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            byte[] data = { 0x30, 0x00 };
            int result = TM200.WriteTagData(hashMap[key], 1, 1, 1, data);
            if (0 < result)
            {
                lblMessageHit.Text = rm.GetString("strMsgSucceedInit");
            }
            else
            {
                lblMessageHit.Text = rm.GetString("strMsgFailedInit");
            }
        }
        /********************************************标签操作 2021-03-09 End**************************************************************/
        #endregion 标签操作

        #region 读写器参数设置
        /********************************************读写器参数设置 2021-03-09 Start**************************************************************/
        private void SetReaderParam_Enter(object sender, EventArgs e)
        {
            //btnReadWorkMode_Click(null, null);
            //btnReadCommMode_Click(null, null);
            //btnReadFreq_Click(null, null);
            //btnAntRead_Click(null, null);
            //btnReadWorkMode_Click(null, null);
        }

        private void btnDefaultWorkMode_Click(object sender, EventArgs e)
        {
            tbWorkMode.SelectedIndex = 0;
            tbNeighJudge.Text = "5";
            tbDelay.Text = "10";
        }

        private void tbWorkMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tbNeighJudge.Visible = chkAjaDisc.Checked;
            switch (tbWorkMode.SelectedIndex)
            {
                case 0: // 主从
                    break;
                case 1:// 定时
                    //cbbReadSpeed.SelectedIndex = 1;
                    //tbTiming.Text = "20";
                    break;
                case 2: // 触发
                    //tbTiming.Text = "5";
                    tbDelay.Text = "10";
                    tbNeighJudge.Text = "5";
                    //cbbTrigSwitch.SelectedIndex = 1;
                    break;
            }
        }

        private void btnDefaultCommMode_Click(object sender, EventArgs e)
        {
            tbCommMode.SelectedIndex = 2;
            cbbBaud_Rate.SelectedIndex = 0;
            cbbRS485BaudRate.SelectedIndex = 0;
            tbPulseWidth.Text = "10";
            tbPulseCycle.Text = "16";
            cbbWiegandProtocol.SelectedIndex = 0;
            cbbWigginsTakePlaceValue.SelectedIndex = 9;
        }

        private void btnReadWorkMode_Click(object sender, EventArgs e)
        {
            queryWorkMode();
        }

        private void chkAjaDisc_CheckedChanged(object sender, EventArgs e)
        {
            //tbNeighJudge.Visible = chkAjaDisc.Checked;
        }

        private void btnSetWorkMode_Click(object sender, EventArgs e)
        {
            updateWorkMode();
        }

        private void btnReadCommMode_Click(object sender, EventArgs e)
        {
            queryCommMode();
        }

        private void btnSetCommMode_Click(object sender, EventArgs e)
        {
            updateCommMode();
        }

        private void updateCommMode()
        {
            // 通信模式参数变量
            int commMode = 0;
            //通信方式
            if ((commMode = tbCommMode.SelectedIndex) == -1)
            {
                lblMessageHit.Text = rm.GetString("strMsgInvalidCommMode");
                return;
            }
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            int result = 0;
            int baudRate = 0;
            switch (commMode)
            {
                case 0://RS232
                case 1://RS485
                    if ((baudRate = cbbBaud_Rate.SelectedIndex) == -1)
                    {
                        lblMessageHit.Text = rm.GetString("strSetRate");
                        return;
                    }
                    if ((baudRate = cbbRS485BaudRate.SelectedIndex) == -1)
                    {
                        lblMessageHit.Text = rm.GetString("strSetRate");
                        return;
                    }
                    if (commMode == 0)
                    {
                        baudRate = cbbBaud_Rate.SelectedIndex;
                    }
                    else
                    {
                        baudRate = cbbRS485BaudRate.SelectedIndex;
                    }
                    result = TM200.UpdateSerialPortBaudrate(hashMap[key], (byte)commMode, (byte)baudRate);
                    if (result == 0)
                    {
                        lblMessageHit.Text = rm.GetString("strMsgFailedReadCommMode");
                        return;
                    }
                    break;
                case 2: //韦根
                    // 韦根协议
                    int wiegandProto = 0;
                    int pulseWidth = 0;
                    int pulseCycle = 0;
                    int wiegandValue = 0;
                    if ((wiegandProto = cbbWiegandProtocol.SelectedIndex) == -1)
                    {
                        lblMessageHit.Text = rm.GetString("strMsgInvalidWiegandProto");
                        return;
                    }
                    // 韦根脉冲宽度
                    if (!int.TryParse(tbPulseWidth.Text, out pulseWidth))
                    {
                        lblMessageHit.Text = rm.GetString("strMsgInvalidPulseWidth");
                        return;
                    }
                    // 脉冲周期
                    if (!int.TryParse(tbPulseCycle.Text, out pulseCycle))
                    {
                        lblMessageHit.Text = rm.GetString("strMsgInvalidPulseCycle");
                        return;
                    }
                    // 韦根取位值
                    if ((wiegandValue = cbbWigginsTakePlaceValue.SelectedIndex) == -1)
                    {
                        lblMessageHit.Text = rm.GetString("strMsgInvalidWiegandValue");
                        //return;
                    }
                    result = TM200.UpdateWeigenPulseCycle(hashMap[key], (byte)pulseCycle);
                    if (result == 0)
                    {
                        lblMessageHit.Text = rm.GetString("strMsgFailedReadCommMode");
                        return;
                    }
                    result = TM200.UpdateWeigenProtocol(hashMap[key], (byte)wiegandProto);
                    if (result == 0)
                    {
                        lblMessageHit.Text = rm.GetString("strMsgFailedReadCommMode");
                        return;
                    }
                    result = TM200.UpdateWeigenPulseWidth(hashMap[key], (byte)pulseWidth);
                    if (result == 0)
                    {
                        lblMessageHit.Text = rm.GetString("strMsgFailedReadCommMode");
                        return;
                    }
                    break;
                case 3://串口RJ45
                    break;
                case 4://wifi
                    break;
                case 5://3G/4G
                    break;

            }
            result = TM200.UpdateCommunicationType(hashMap[key], (byte)commMode);
            if (0 == result)
            {
                lblMessageHit.Text = rm.GetString("strMsgFailedSetCommMode");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMsgSucceedSetCommMode");
        }

        private void queryWeigenData()
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            byte width = 0;
            byte cycle = 0;
            byte proto = 0;
            byte value = 0;
            int result = TM200.QueryWeigenProtocol(hashMap[key], ref proto);
            if (result == 0)
            {
                lblMessageHit.Text = rm.GetString("strMsgFailedReadCommMode");
                return;
            }
            result = TM200.QueryWeigenPulseCycle(hashMap[key], ref cycle);
            if (result == 0)
            {
                lblMessageHit.Text = rm.GetString("strMsgFailedReadCommMode");
                return;
            }
            result = TM200.QueryWeigenPulseWidth(hashMap[key], ref width);
            if (result == 0)
            {
                lblMessageHit.Text = rm.GetString("strMsgFailedReadCommMode");
                return;
            }
            result = TM200.UpdateWeigenProtocol(hashMap[key], (byte)proto);
            if (result == 0)
            {
                lblMessageHit.Text = rm.GetString("strMsgFailedReadCommMode");
                return;
            }
            result = TM200.UpdateWeigenPulseWidth(hashMap[key], (byte)width);
            if (result == 0)
            {
                lblMessageHit.Text = rm.GetString("strMsgFailedReadCommMode");
                return;
            }
            result = TM200.UpdateWeigenPulseCycle(hashMap[key], (byte)cycle);
            if (result == 0)
            {
                lblMessageHit.Text = rm.GetString("strMsgFailedReadCommMode");
                return;
            }
            proto = (byte)(proto > 3 ? -1 : proto);
            //cbbWigginsTakePlaceValue.SelectedIndex = value > 61 ? 61 : value;
            cbbWiegandProtocol.SelectedIndex = proto;
            tbPulseCycle.Text = string.Format("{0:d}", cycle);
            tbPulseWidth.Text = string.Format("{0:d}", width);
        }

        private void queryCommMode()
        {
            try
            {
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                byte communicationType = 0;
                int result = TM200.QueryCommunicationType(hashMap[key], ref communicationType);
                if (result == 0)
                {
                    lblMessageHit.Text = rm.GetString("strMsgFailedReadCommMode");
                    return;
                }
                tbCommMode.SelectedIndex = communicationType;
                byte baudRate = 0;
                bool total = false;
                switch (communicationType)
                {
                    case 0://RS232
                    case 1://RS485   
                        result = TM200.QuerySerialPortBaudrate(hashMap[key], communicationType, ref baudRate);
                        if (result == 0)
                        {
                            lblMessageHit.Text = rm.GetString("strMsgFailedReadCommMode");
                            return;
                        }
                        if (communicationType == 0)
                        {
                            cbbBaud_Rate.SelectedIndex = baudRate;
                        }
                        else if (communicationType == 1)
                        {
                            cbbRS485BaudRate.SelectedIndex = baudRate;
                        }
                        break;
                    case 4: //WIFI
                        break;
                    case 5: //3G/4G
                        break;
                }
                queryWeigenData();
                lblMessageHit.Text = rm.GetString("strMsgSucceedReadCommMode");
            }
            catch (Exception e)
            {
                lblMessageHit.Text = e.Message;
            }
        }

        private void updateWorkMode()
        {
            try
            {
                int workMode = 0;
                int delayTime = 0;
                // 工作模式
                if ((workMode = tbWorkMode.SelectedIndex) == -1)
                {
                    lblMessageHit.Text = rm.GetString("strMsgInvalidWordMode");
                    return;
                }
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                UIntPtr device = hashMap[key];
                byte mode = (byte)tbWorkMode.SelectedIndex;
                int result = 0;
                switch (mode)
                {
                    case 0://主从模式
                        break;
                    case 1: //定时模式
                        break;
                    case 2: //触发模式
                        result = TM200.UpdateTriggerDelayTime(device, (byte)delayTime);
                        if (0 == result)
                        {
                            lblMessageHit.Text = rm.GetString("strMsgFailedSetWorkMode");
                            return;
                        }
                        break;
                }
                result = TM200.UpdateWorkMode(device, mode);
                if (0 == result)
                {
                    lblMessageHit.Text = rm.GetString("strMsgFailedSetWorkMode");
                    return;
                }
                lblMessageHit.Text = rm.GetString("strMsgSucceedSetWorkMode");
            }
            catch (Exception e)
            {
                lblMessageHit.Text = e.Message;
            }
        }

        private void queryWorkMode()
        {
            try
            {
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                UIntPtr device = hashMap[key];
                byte mode = 0;
                int result = TM200.QueryWorkMode(device, out mode);
                if (0 == result)
                {
                    lblMessageHit.Text = rm.GetString("strMsgFailedReadCommMode");
                    return;
                }
                tbWorkMode.SelectedIndex = mode;
                switch (mode)
                {
                    case 0://主从模式
                        break;
                    case 1://定时模式
                        break;
                    case 2://触发模式
                        byte delayTime = 0;
                        result = TM200.QueryTriggerDelayTime(device, ref delayTime);
                        if (0 == result)
                        {
                            lblMessageHit.Text = rm.GetString("strMsgFailedReadCommMode");
                            return;
                        }
                        tbDelay.Text = string.Format("{0:d}", delayTime);
                        break;
                    default:
                        break;

                }
                //byte stataus = 0;
                //byte adjacentDiscriminantTime = 0;
                //tbNeighJudge.Text = string.Format("{0:d}", adjacentDiscriminantTime);
                lblMessageHit.Text = rm.GetString("strMsgSucceedGetWorkMode");
            }
            catch
            {
                lblMessageHit.Text = rm.GetString("strMsgFailedReadCommMode");
            }
        }

        /********************************************读写器参数设置 2021-03-09 End**************************************************************/
        #endregion 读写器参数设置

        #region 通讯参数设置

        private void labDestIP_Click(object sender, EventArgs e)
        {
            cbbDestIP.Items.Clear();
            cbbDestIP.Text = "";

            byte[] IP = new byte[50];
            byte count = 0;
            int result = JTDM.QueryLocalHosts(IP, out count);
            string[] host = (System.Text.Encoding.ASCII.GetString(IP)).Replace("\0", "").Split(',');
            for (int i = 0; i < count; i++)
            {
                cbbDestIP.Items.Add(host[i]);
            }
            if (count > 0)
            {
                cbbDestIP.SelectedIndex = 0;
            }
        }

        private void lvZl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvZl.Items.Count > 0)
            {
                JTDM.m_SelectedDevNo = (byte)(lvZl.Items.IndexOf(lvZl.FocusedItem));
                UpdateCommParamControl(JTDM.m_SelectedDevNo);
            }
        }

        /// <summary>
        /// 搜索设备
        /// 2015-11-9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchDev_Click(object sender, EventArgs e)
        {
            try
            {
                lvZl.Items.Clear();
                JTDM.StartSearchDev(out JTDM.m_DevCnt);
                lock (lvZl.Items)
                {
                    for (byte i = 0; i < JTDM.m_DevCnt; ++i)
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = (i + 1).ToString();
                        byte[] IP = new byte[100];
                        byte[] deviceId = new byte[100];
                        int port = 0;

                        JTDM.QueryIP(i, IP);
                        JTDM.QueryPort(i, out port);
                        JTDM.QueryDevID(i, deviceId);

                        string IP_Address = System.Text.Encoding.ASCII.GetString(IP);
                        string ID = System.Text.Encoding.ASCII.GetString(deviceId);
                        string port_data = port + "";
                        lvi.SubItems.Add(IP_Address);
                        lvi.SubItems.Add(port_data);
                        lvi.SubItems.Add(ID);
                        lvZl.Items.Add(lvi);
                    }
                }
                if (JTDM.m_DevCnt > 0)
                {
                    JTDM.m_SelectedDevNo = 0;
                    UpdateCommParamControl(JTDM.m_SelectedDevNo); // 更新页面控件           
                    lvZl.FocusedItem = lvZl.Items[0];// 设置第一项为焦点项
                }

            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// 编辑设备
        /// 2015-11-9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifyDev_Click(object sender, EventArgs e)
        {
            if (lvZl.SelectedItems != null)
            {
                listViewDev_ItemActivate(sender, e);
            }
        }

        /// <summary>
        /// 设置默认参数
        /// 2015-11-9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDefaultParams_Click(object sender, EventArgs e)
        {
            comboBoxNetMode.SelectedIndex = 0;
            comboBoxIPMode.SelectedIndex = 0;
            textBoxIPAdd.Text = "192.168.1.200";
            textBoxNetMask.Text = "255.255.255.0";
            textBoxPortNo.Text = "4196";
            textBoxGateway.Text = "192.168.1.1";
            tbDestIP.Text = "192.168.1.100";
            cbbDestIP.Text = "192.168.1.100";

            textBoxDestPort.Text = "4196";
            comboBoxBaudRate.SelectedIndex = 4;
            comboBoxDataBits.SelectedIndex = 0;
            comboBoxCheckBits.SelectedIndex = 0;
        }

        /// <summary>
        /// 设置通信参数
        /// 2015-11-9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetParams_Click(object sender, EventArgs e)
        {
            if (-1 == comboBoxNetMode.SelectedIndex)
            {
                lblMessageHit.Text = rm.GetString("strMsgSelectNetMode");
                return;
            }
            if (-1 == comboBoxIPMode.SelectedIndex)
            {
                lblMessageHit.Text = rm.GetString("strMsgSelectIPMode");
                return;
            }
            if (-1 == comboBoxBaudRate.SelectedIndex)
            {
                lblMessageHit.Text = rm.GetString("strMsgSelectBaudRate");
                return;
            }
            if (-1 == comboBoxDataBits.SelectedIndex)
            {
                lblMessageHit.Text = rm.GetString("strMsgSelectDataBits");
                return;
            }
            if (-1 == comboBoxDataBits.SelectedIndex)
            {
                lblMessageHit.Text = rm.GetString("strMsgSelectParity");
                return;
            }
            // 检查IP地址
            if (!DataConvert.IsValidIP(textBoxIPAdd.Text))
            {
                lblMessageHit.Text = rm.GetString("strMsgInvalidIP");
                return;
            }
            // 检查掩码
            if (!DataConvert.IsValidIP(textBoxNetMask.Text))
            {
                lblMessageHit.Text = rm.GetString("strMsgInvalidMask");
                return;
            }
            // 检查网关
            if (!DataConvert.IsValidIP(textBoxGateway.Text))
            {
                lblMessageHit.Text = rm.GetString("strMsgInvalidGateway");
                return;
            }
            // 检查目标IP
            //if (!DataConvert.IsValidIP(tbDestIP.Text))
            //{
            //    MessageBox.Show(rm.GetString("strMsgInvalidDestIP"));
            //    return;
            //}
            if (!DataConvert.IsValidIP(cbbDestIP.Text))
            {
                lblMessageHit.Text = rm.GetString("strMsgInvalidDestIP");
                return;
            }


            // 检查端口号
            int value = int.Parse(textBoxPortNo.Text);
            if (value < 1000 || value > 65535)
            {
                lblMessageHit.Text = rm.GetString("strMsgInvalidPort");
                return;
            }
            value = int.Parse(textBoxDestPort.Text);
            if (value < 1000 || value > 65535)
            {
                lblMessageHit.Text = rm.GetString("strMsgInvalidDestPort");
                return;
            }
            ushort port = DataConvert.ReverseByte(ushort.Parse(textBoxPortNo.Text));
            ushort destport = DataConvert.ReverseByte(ushort.Parse(textBoxDestPort.Text));

            byte[] ip = new byte[32];
            byte[] netmask = new byte[32];
            byte[] gateway = new byte[32];
            byte[] destip = new byte[32];

            ip = Encoding.ASCII.GetBytes(textBoxIPAdd.Text);
            netmask = Encoding.ASCII.GetBytes(textBoxNetMask.Text);
            gateway = Encoding.ASCII.GetBytes(textBoxGateway.Text);

            destip = Encoding.ASCII.GetBytes(tbDestIP.Text);

            destip = Encoding.ASCII.GetBytes(cbbDestIP.Text);

            JTDM.UpdateNetworkMode(JTDM.m_SelectedDevNo, (byte)comboBoxNetMode.SelectedIndex);
            JTDM.UpdateIPMode(JTDM.m_SelectedDevNo, (byte)comboBoxIPMode.SelectedIndex);
            JTDM.UpdateIP(JTDM.m_SelectedDevNo, ip);
            JTDM.UpdateSubnetMask(JTDM.m_SelectedDevNo, netmask);
            JTDM.UpdatePort(JTDM.m_SelectedDevNo, port);
            JTDM.UpdateGateWay(JTDM.m_SelectedDevNo, gateway);
            JTDM.UpdateDestName(JTDM.m_SelectedDevNo, destip);
            JTDM.UpdateDestPort(JTDM.m_SelectedDevNo, destport);
            JTDM.UpdateBaudrateIndex(JTDM.m_SelectedDevNo, (byte)comboBoxBaudRate.SelectedIndex);
            JTDM.UpdateDataBits(JTDM.m_SelectedDevNo, (byte)comboBoxDataBits.SelectedIndex);
            JTDM.UpdateParity(JTDM.m_SelectedDevNo, (byte)comboBoxCheckBits.SelectedIndex);

            int res = JTDM.UpdateParam(JTDM.m_SelectedDevNo);
            if (res == 1)
            {
                lblMessageHit.Text = rm.GetString("strMsgSucceedSetCommParam");
            }
            else
            {
                lblMessageHit.Text = rm.GetString("strMsgFailedSetCommParam");
            }
        }

        private void listViewDev_ItemActivate(object sender, EventArgs e)
        {
            if (lvZl.Items.Count > 0)
            {
                JTDM.m_SelectedDevNo = (byte)(lvZl.Items.IndexOf(lvZl.FocusedItem));
                UpdateCommParamControl(JTDM.m_SelectedDevNo);
            }
        }

        private void UpdateCommParamControl(byte index)
        {
            if (JTDM.m_DevCnt > 0)
            {
                byte networkMode = 0;
                byte IPMode = 0;
                byte[] IPAdd = new byte[100];
                byte[] NetMask = new byte[100];
                int PortNo = 0;
                byte[] Gateway = new byte[100];
                byte[] DestIP = new byte[100];
                ushort DestPort = 0;
                byte BaudRate = 0;
                byte DataBits = 0;
                byte CheckBits = 0;

                JTDM.QueryNetworkMode(index, out networkMode);
                JTDM.QueryIPMode(index, out IPMode);
                JTDM.QueryIP(index, IPAdd);
                JTDM.QuerySubnetMask(index, NetMask);
                JTDM.QueryPort(index, out PortNo);
                JTDM.QueryGateWay(index, Gateway);
                JTDM.QueryDestName(index, DestIP);
                JTDM.QueryDestPort(index, out DestPort);
                JTDM.QueryBaudrateIndex(index, out BaudRate);
                JTDM.QueryDataBits(index, out DataBits);
                JTDM.QueryParity(index, out CheckBits);

                comboBoxNetMode.SelectedIndex = networkMode;
                comboBoxIPMode.SelectedIndex = IPMode;
                textBoxIPAdd.Text = System.Text.Encoding.ASCII.GetString(IPAdd);
                textBoxNetMask.Text = System.Text.Encoding.ASCII.GetString(NetMask);
                textBoxPortNo.Text = PortNo.ToString();
                textBoxGateway.Text = System.Text.Encoding.ASCII.GetString(Gateway);

                cbbDestIP.Items.Clear();
                tbDestIP.Text = System.Text.Encoding.ASCII.GetString(DestIP);
                cbbDestIP.Text = System.Text.Encoding.ASCII.GetString(DestIP);


                textBoxDestPort.Text = DestPort.ToString();
                comboBoxBaudRate.SelectedIndex = BaudRate;
                comboBoxDataBits.SelectedIndex = DataBits;
                comboBoxCheckBits.SelectedIndex = CheckBits;
            }
        }

        #endregion 通讯参数设置

        #region 其它操作
        /********************************************其化参数设置 2021-03-09 Start**************************************************************/
        private byte GetAnt()
        {
            //if (rbAnt1.Checked) return 1;
            //if (rbAnt2.Checked) return 2;
            //if (rbAnt3.Checked) return 3;
            //if (rbAnt4.Checked) return 4;
            //if (rbAnt5.Checked) return 5;
            //if (rbAnt6.Checked) return 6;
            //if (rbAnt7.Checked) return 7;
            //if (rbAnt8.Checked) return 8;
            return 0;
        }


        private void btnReadSerialNumber_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            byte[] serialNumber = new byte[100];
            byte len = 0;
            int result = 0;
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMessageQueryDeviceSerialNumberFailure");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMessageQueryDeviceSerialNumberSuccessed");
            lblMessageHit.Text += System.Text.Encoding.ASCII.GetString(serialNumber);
        }

        static string value = null;

        private static void addSerialNumber()
        {
            int index = 0;
            StringBuilder sb = new StringBuilder();
            string curretnTime = DateTime.Now.ToString("yyyyMMdd");
            sb.Append(curretnTime);

            string outString = "";
            string outIndex = "";
            FileOperation.GetValue("Config", "snTime", out outString, IniFilePath);
            FileOperation.GetValue("Config", "snIndex", out outIndex, IniFilePath);
            if (outString == curretnTime)
            {
                value = curretnTime;
                if (!Regex.IsMatch(outIndex, @"^-?[1-9]\d*$|^0$"))
                {
                    outIndex = index.ToString();
                }
                index = int.Parse(outIndex);
                value += index.ToString().PadLeft(4, '0');
                value = (long.Parse(value)).ToString();
            }
            else
            {
                index = 0;
                string date = index.ToString().PadLeft(4, '0');
                sb.Append(date);
                value = sb.ToString();
            }

        }

        static int changed = 0;

        private void tbSerialNumber_TextChanged(object sender, EventArgs e)
        {
            changed = 1;
        }

        private void OtherOpreation_Enter_Fun(object sender, EventArgs e)
        {
            //btnReadBeep_Click(null, null);
            //btnReadPower_Click(null, null);
            //btnReadDeviceId_Click(null, null);
            //btnReadUsbFormat_Click(null,null);
            //btnReadEPCDataFormat_Click(null, null);
            //btnAntRead_Click(null, null);
            //btnGetReadMode_Click(null, null);
            //btnReadDataArea_Click(null, null);
        }

        /// <summary>
        /// 查询设备号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadDeviceId_Click(object sender, EventArgs e)
        {
            queryDeviceId();
        }

        /// <summary>
        /// 设置设备号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetDeviceId_Click(object sender, EventArgs e)
        {
            updateDeviceId();
        }


        /// <summary>
        /// 查询读卡模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetReadMode_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 设置读卡模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetReadMode_Click(object sender, EventArgs e)
        {
            updateSingleOrMultiTag();
        }

        /// <summary>
        /// 查询天线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAntRead_Click(object sender, EventArgs e)
        {
            QueryAntParam();
        }

        /// <summary>
        /// 设置天线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAntSet_Click(object sender, EventArgs e)
        {
            updateAntParam();
        }

        /// <summary>
        /// 查询蜂鸣器(声音)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadBeep_Click(object sender, EventArgs e)
        {
            queryBuzzer();
        }

        /// <summary>
        /// 设置蜂鸣器(声音)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetBeep_Click(object sender, EventArgs e)
        {
            updateBuzzer();
        }

        /// <summary>
        /// 查询读数据区域
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadDataArea_Click(object sender, EventArgs e)
        {
            queryDataArea();
        }

        /// <summary>
        /// 设置读数据区域
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetDataArea_Click(object sender, EventArgs e)
        {
            updateDataArea();
        }

        /// <summary>
        /// 读取非USB数据输出格式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadEPCDataFormat_Click(object sender, EventArgs e)
        {
            queryNotUsbOutputFormat();
        }

        /// <summary>
        /// 设置非USB数据输出格式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetEPCDataFormat_Click(object sender, EventArgs e)
        {
            updateNotUsbOutputFormat();
        }

        /// <summary>
        /// 读取USB数据输出格式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadUsbFormat_Click(object sender, EventArgs e)
        {
            queryUsbOutputFormat();
        }

        /// <summary>
        /// 设置USB数据输出格式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetUsbFormat_Click(object sender, EventArgs e)
        {
            updateUsbOutputFormat();
        }

        /// <summary>
        /// 设置GPIO继电器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetRelayTime_Click(object sender, EventArgs e)
        {
            updateRelayContrl();
        }

        /// <summary>
        /// 标签授权
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTagAuth_Click(object sender, EventArgs e)
        {
            tagAuther();
        }

        /// <summary>
        /// 查询授权码头
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQueryAuthorization_Click(object sender, EventArgs e)
        {
            queryTagAuthorization();
        }

        /// <summary>
        /// 修改授权码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifyAuthPwd_Click(object sender, EventArgs e)
        {
            modifyAuthPwd();
        }

        /// <summary>
        /// 自动授权
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAutoAuthorization_Click(object sender, EventArgs e)
        {
            autoAuthorization();
        }

        Thread autoAuthorizationThread;
        string AuthorizationSuccess;
        string NoneAuthorizationTag;

        private void autoAuthorization()
        {
            try
            {
                //if (btnAutoAuthorization.Text == rm.GetString("startAutoAuthorization"))
                //{
                //    autoAuthorizationThread = new Thread(new ThreadStart(AuthorizationMethod));
                //    autoAuthorizationThread.Start();
                //    btnAutoAuthorization.Text = rm.GetString("stopAutoAuthorization");
                //}
                //else if (btnAutoAuthorization.Text == rm.GetString("stopAutoAuthorization"))
                //{
                //    autoAuthorizationThread.Abort();
                //    btnAutoAuthorization.Text = rm.GetString("startAutoAuthorization");
                //}
            }
            catch (Exception e)
            {
                lblMessageHit.Text = e.Message;
            }
        }

        private void AuthorizationMethod()
        {
            try
            {
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                UIntPtr device = hashMap[key];
                while (autoAuthorizationThread.IsAlive)
                {
                    //if (0 < TM200.TagAuther(device))
                    //{
                    //    lblMessageHit.Text = rm.GetString("strMsgSucceedAuth");
                    //    lblMessageHit.ForeColor = Color.Green;
                    //}
                    //else
                    //{
                    //    lblMessageHit.Text = rm.GetString("NoneAuthorizationTag");
                    //    lblMessageHit.ForeColor = Color.Black;
                    //}
                    //Thread.Sleep(500);
                }
            }
            catch (Exception e)
            {
                lblMessageHit.Text = e.Message;
            }
        }

        private void modifyAuthPwd()
        {
            try
            {
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                UIntPtr device = hashMap[key];

                //string strAuthPwd = tbAuthPwd.Text.Replace(" ", "");
                //string strNewAuthPwd = tbNewAuthPwd.Text.Replace(" ", "");
                //if (tbAuthPwd.Text.Length != 4 || tbNewAuthPwd.Text.Length != 4)
                //{
                //    lblMessageHit.Text = rm.GetString("strMsgPwdMustFour");
                //    return;
                //}
                //if (!Regex.IsMatch(tbAuthPwd.Text, "^[0-9A-Fa-f]+$") || !Regex.IsMatch(tbNewAuthPwd.Text, "^[0-9A-Fa-f]+$"))
                //{
                //    lblMessageHit.Text = rm.GetString("strMsgInvalidChar");
                //    return;
                //}

                byte[] oldPwd = new Byte[2];
                byte[] newPwd = new Byte[2];

                for (int i = 0; i < 2; i++)
                {
                    //oldPwd[i] = Convert.ToByte(strAuthPwd.Substring(i * 2, 2), 16);
                    //newPwd[i] = Convert.ToByte(strNewAuthPwd.Substring(i * 2, 2), 16);
                }

                byte[] pwd = new byte[10];
                byte pwd_len = 0;
                int result = 0;
                if (0 < result)
                {
                    lblMessageHit.Text = rm.GetString("strMsgSuccedSetAuthPwd");
                }
                else
                {
                    lblMessageHit.Text = rm.GetString("strMsgFailedSetAuthPwd");
                    return;
                }
                if (pwd[0] == oldPwd[0] && pwd[1] == oldPwd[1])
                {
                    ///result = TM200.UpdateAutherPwd(device, newPwd, (byte)newPwd.Length);
                    if (0 < result)
                    {
                        lblMessageHit.Text = rm.GetString("strMsgSuccedSetAuthPwd");
                    }
                    else
                    {
                        lblMessageHit.Text = rm.GetString("strMsgFailedSetAuthPwd");
                    }
                }
                else
                {
                    lblMessageHit.Text = rm.GetString("strMsgInvalidOldPwd");
                    return;
                }

            }
            catch (Exception e)
            {
                lblMessageHit.Text = e.Message;
            }
        }

        private void tagAuther()
        {
            try
            {
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                UIntPtr device = hashMap[key];
                int result = 0;
                if (0 < result)
                {
                    lblMessageHit.Text = rm.GetString("strMsgSucceedAuth");
                }
                else
                {
                    lblMessageHit.Text = rm.GetString("strMsgFailedAuth");
                }
            }
            catch (Exception e)
            {
                lblMessageHit.Text = e.Message;
            }
        }

        private void queryTagAuthorization()
        {
            try
            {
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                UIntPtr device = hashMap[key];
                byte[] pwd = new byte[10];
                byte pwd_len = 0;
                int result = 0;
                if (0 < result)
                {
                    lblMessageHit.Text = rm.GetString("strGetAuthorizationCodeSuccessed");
                }
                else
                {
                    lblMessageHit.Text = rm.GetString("strGetAuthorizationCodeFailure");
                }
                //tbAuthPwd.Text = pwd[0].ToString("X2") + pwd[1].ToString("X2");
            }
            catch (Exception e)
            {
                lblMessageHit.Text = e.Message;
            }
        }

        private void updateRelayContrl()
        {
            try
            {
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                UIntPtr device = hashMap[key];
                byte mode = (byte)tbRelayMode.SelectedIndex;
                DevGPIO GPIO = new DevGPIO();
                if (mode == 1)
                {
                    uint relayTime = uint.Parse(cbbRelayTime.Text);
                    GPIO.auto_delay_time = relayTime;
                }
                GPIO.initiative_or_passivity = mode;
                GPIO.passivity_input1 = (byte)(rbOpen1.Checked ? 1 : 0);
                GPIO.passivity_input2 = (byte)(rbOpen2.Checked ? 1 : 0);
                int result = TM200.UpdateGPIO(hashMap[key], GPIO);
                if (1 == result)
                {
                    lblMessageHit.Text = rm.GetString("strMsgSucceedInvalidbtnSetRelayTime");
                }
                else
                {
                    lblMessageHit.Text = rm.GetString("strMsgFailedInvalidbtnSetRelayTime");
                    return;
                }

            }
            catch (Exception e)
            {
                lblMessageHit.Text = e.Message;
            }
        }

        private void queryUsbOutputFormat()
        {
            try
            {
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                UIntPtr device = hashMap[key];
                byte format = 0;
                int result = 0;
                if (result < 1)
                {
                    lblMessageHit.Text = rm.GetString("strMessageQueryUSB_DeviceOutputFormatFailure");
                    return;
                }
                lblMessageHit.Text = rm.GetString("strMessageQueryUSB_DeviceOutputFormatSuccessed");
                //cbbUsbFormat.SelectedIndex = format > 9 ? -1 : format;
                //MessageBox.Show(rm.GetString("strGetDoubleUSBFailed"));
            }
            catch (Exception e)
            {
                lblMessageHit.Text = e.Message;
            }
        }

        private void updateUsbOutputFormat()
        {
            try
            {
                //if (-1 == cbbUsbFormat.SelectedIndex)
                //{
                //    lblMessageHit.Text = rm.GetString("strMsgInvalidUsbFormat");
                //    return;
                //}
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                UIntPtr device = hashMap[key];
                //byte format = (byte)cbbUsbFormat.SelectedIndex;
                //int result = 0;
                //if (result < 1)
                //{
                //    lblMessageHit.Text = rm.GetString("strMsgFailedSetUsbFormat");
                //    return;
                //}
                lblMessageHit.Text = rm.GetString("strMsgSucceedSetUsbFormat");
            }
            catch (Exception e)
            {
                lblMessageHit.Text = e.Message;
            }
        }

        private void queryNotUsbOutputFormat()
        {
            try
            {
                string key = selecteDevice();
                if (null == key)
                {
                    lblMessageHit.Text = rm.GetString("strMessagePleaseChoose");
                    return;
                }
                UIntPtr device = hashMap[key];
                byte format = 0;
                int result = 0;
                if (result < 1)
                {
                    lblMessageHit.Text = rm.GetString("strMessageQueryNotUSB_DeviceOutputFormatFailure");
                    return;
                }
                lblMessageHit.Text = rm.GetString("strMessageQueryNotUSB_DeviceOutputFormatSuccessed");
                //cbbEPCDataFormat.SelectedIndex = format > 2 ? -1 : format; 
            }
            catch (Exception e)
            {
                lblMessageHit.Text = e.Message;
            }
        }

        private void updateNotUsbOutputFormat()
        {
            try
            {
                //if (-1 == cbbEPCDataFormat.SelectedIndex)
                //{
                //    //lblMessageHit.Text = "下标有误";
                //    return;
                //}
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                UIntPtr device = hashMap[key];
                //byte format = (byte)cbbEPCDataFormat.SelectedIndex;
                //int result = 0;
                //if (result < 1)
                //{
                //    lblMessageHit.Text = rm.GetString("strMessageUpdateNotUSB_DeviceOutputFormatFailure");
                //    return;
                //}
                //lblMessageHit.Text = rm.GetString("strMessageUpdateNotUSB_DeviceOutputFormatSuccessed");
            }
            catch (Exception e)
            {
                lblMessageHit.Text = e.Message;
            }
        }

        private void queryDataArea()
        {
            try
            {
                string key = selecteDevice();
                if (null == key)
                {
                    lblMessageHit.Text = rm.GetString("strMessagePleaseChoose");
                    return;
                }
                byte operation_area = 0;
                int result = TM200.QueryTagReadCardArea(hashMap[key], ref operation_area);
                if (result < 1)
                {
                    lblMessageHit.Text = rm.GetString("strMessageQueryOperationAreaFailure");
                    return;
                }
                lblMessageHit.Text = rm.GetString("strMessageQueryOperationAreaSuccessed");
                cbbDataArea.SelectedIndex = operation_area;
            }
            catch (Exception e)
            {
                lblMessageHit.Text = e.Message;
            }
        }

        private void updateDataArea()
        {
            try
            {
                if (-1 == cbbDataArea.SelectedIndex)
                {
                    lblMessageHit.Text = rm.GetString("strMessagePleaseChoose");
                    return;
                }
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                byte operation_area = (byte)cbbDataArea.SelectedIndex;
                int result = TM200.UpdateTagReadCardArea(hashMap[key], operation_area);
                if (result < 1)
                {
                    lblMessageHit.Text = rm.GetString("strMessageUpdateOperationAreaFailure");
                    return;
                }
                lblMessageHit.Text = rm.GetString("strMessageUpdateOperationAreaSuccessed");
            }
            catch (Exception e)
            {
                lblMessageHit.Text = e.Message;
            }
        }

        private void queryBuzzer()
        {
            try
            {
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                UIntPtr device = hashMap[key];
                byte status = 0;
                int result = TM200.QueryBuzzer(hashMap[key], ref status);
                if (result < 1)
                {
                    lblMessageHit.Text = rm.GetString("strGetBeepFailed");
                    return;
                }
                lblMessageHit.Text = rm.GetString("strGetBeepSuccessed");
                int length = 2;
                cbbBeepControl.SelectedIndex = status > length ? -1 : status;
            }
            catch (Exception e)
            {
                lblMessageHit.Text = e.Message;
            }
        }

        private void updateBuzzer()
        {
            try
            {
                if (-1 == cbbBeepControl.SelectedIndex)
                {
                    lblMessageHit.Text = rm.GetString("strMsgInvalidBeepControl");
                    return;
                }

                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                UIntPtr device = hashMap[key];
                byte status = (byte)cbbBeepControl.SelectedIndex;
                int result = TM200.UpdateBuzzer(device, status);
                if (result < 1)
                {
                    lblMessageHit.Text = rm.GetString("strMsgFailedBeepControl");
                    return;
                }
                lblMessageHit.Text = rm.GetString("strMsgSucceedBeepControl");
            }
            catch (Exception e)
            {
                lblMessageHit.Text = e.Message;
            }
        }

        private void QueryAnteParmValue(int channelCount)
        {
            if (channelCount >= 1)
            {
                chkAnt1.Checked = antennaIds[0].Checked;
                cbbPower1.Text = antennaPowers[0].Text;
                cbbWorkTime1.Text = antennaWorkTimes[0].Text;
                cbbGapTime1.Text = antennaGapTimes[0].Text;
            }
            if (channelCount >= 2)
            {
                chkAnt2.Checked = antennaIds[1].Checked;
                cbbPower2.Text = antennaPowers[1].Text;
                cbbWorkTime2.Text = antennaWorkTimes[1].Text;
                cbbGapTime2.Text = antennaGapTimes[1].Text;
            }
            if (channelCount >= 4)
            {
                chkAnt3.Checked = antennaIds[2].Checked;
                chkAnt4.Checked = antennaIds[3].Checked;

                cbbPower3.Text = antennaPowers[2].Text;
                cbbPower4.Text = antennaPowers[3].Text;

                cbbWorkTime3.Text = antennaWorkTimes[2].Text;
                cbbWorkTime4.Text = antennaWorkTimes[3].Text;

                cbbGapTime3.Text = antennaGapTimes[2].Text;
                cbbGapTime4.Text = antennaGapTimes[3].Text;
            }

            if (channelCount >= 16)
            {
                chkAnt5.Checked = antennaIds[4].Checked;
                chkAnt6.Checked = antennaIds[5].Checked;
                chkAnt7.Checked = antennaIds[6].Checked;
                chkAnt8.Checked = antennaIds[7].Checked;
                chkAnt9.Checked = antennaIds[8].Checked;
                chkAnt10.Checked = antennaIds[9].Checked;
                chkAnt11.Checked = antennaIds[10].Checked;
                chkAnt12.Checked = antennaIds[11].Checked;
                chkAnt13.Checked = antennaIds[12].Checked;
                chkAnt14.Checked = antennaIds[13].Checked;
                chkAnt15.Checked = antennaIds[14].Checked;
                chkAnt16.Checked = antennaIds[15].Checked;

                cbbPower5.Text = antennaPowers[4].Text;
                cbbPower6.Text = antennaPowers[5].Text;
                cbbPower7.Text = antennaPowers[6].Text;
                cbbPower8.Text = antennaPowers[7].Text;
                cbbPower9.Text = antennaPowers[8].Text;
                cbbPower10.Text = antennaPowers[9].Text;
                cbbPower11.Text = antennaPowers[10].Text;
                cbbPower12.Text = antennaPowers[11].Text;
                cbbPower13.Text = antennaPowers[12].Text;
                cbbPower14.Text = antennaPowers[13].Text;
                cbbPower15.Text = antennaPowers[14].Text;
                cbbPower16.Text = antennaPowers[15].Text;

                cbbWorkTime5.Text = antennaWorkTimes[4].Text;
                cbbWorkTime6.Text = antennaWorkTimes[5].Text;
                cbbWorkTime7.Text = antennaWorkTimes[6].Text;
                cbbWorkTime8.Text = antennaWorkTimes[7].Text;
                cbbWorkTime9.Text = antennaWorkTimes[8].Text;
                cbbWorkTime10.Text = antennaWorkTimes[9].Text;
                cbbWorkTime11.Text = antennaWorkTimes[10].Text;
                cbbWorkTime12.Text = antennaWorkTimes[11].Text;
                cbbWorkTime13.Text = antennaWorkTimes[12].Text;
                cbbWorkTime14.Text = antennaWorkTimes[13].Text;
                cbbWorkTime15.Text = antennaWorkTimes[14].Text;
                cbbWorkTime16.Text = antennaWorkTimes[15].Text;

                cbbGapTime5.Text = antennaGapTimes[4].Text;
                cbbGapTime6.Text = antennaGapTimes[5].Text;
                cbbGapTime7.Text = antennaGapTimes[6].Text;
                cbbGapTime8.Text = antennaGapTimes[7].Text;
                cbbGapTime9.Text = antennaGapTimes[8].Text;
                cbbGapTime10.Text = antennaGapTimes[9].Text;
                cbbGapTime11.Text = antennaGapTimes[10].Text;
                cbbGapTime12.Text = antennaGapTimes[11].Text;
                cbbGapTime13.Text = antennaGapTimes[12].Text;
                cbbGapTime14.Text = antennaGapTimes[13].Text;
                cbbGapTime15.Text = antennaGapTimes[14].Text;
                cbbGapTime16.Text = antennaGapTimes[15].Text;
            }
        }

        private void QueryAntParam()
        {
            try
            {
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                UIntPtr device = hashMap[key];
                byte[] ants = new byte[8];
                AntennaChannelStruct antennaChannel = new AntennaChannelStruct();
                int result = TM200.QueryAntennaConfig(device, ref antennaChannel);
                if (result < 1)
                {
                    lblMessageHit.Text = rm.GetString("strMsgFailedInvalidbtnAntRead");
                    return;
                }
                for (int i = 0; i < antennaChannel.channelCount; i++)
                {
                    antennaIds[i] = new CheckBox();
                    antennaPowers[i] = new ComboBox();
                    antennaWorkTimes[i] = new ComboBox();
                    antennaGapTimes[i] = new ComboBox();

                    antennaIds[i].Checked = antennaChannel.config[i].enable == 1;
                    string power =  Convert.ToString(antennaChannel.config[i].power);
                    string workTimes = Convert.ToString(antennaChannel.config[i].workTime);
                    string gapTimes = Convert.ToString(antennaChannel.config[i].freeTime);

                    antennaPowers[i].Items.Add(power);
                    antennaWorkTimes[i].Items.Add(workTimes);
                    antennaGapTimes[i].Items.Add(gapTimes);

                    antennaPowers[i].SelectedItem = power;
                    antennaWorkTimes[i].SelectedItem = workTimes;
                    antennaGapTimes[i].SelectedItem = gapTimes;
                }
                QueryAnteParmValue(antennaChannel.channelCount);
                lblMessageHit.Text = rm.GetString("strMsgSucceedGetAnt");
            }
            catch (Exception e)
            {
                lblMessageHit.Text = e.Message;
            }
        }

        private byte GetChannelCount()
        {
            byte channelCount = 0;
            if (rbChannel1.Checked)
            {
                channelCount = 1;
            }
            if (rbChannel2.Checked)
            {
                channelCount = 2;
            }
            if (rbChannel4.Checked)
            {
                channelCount = 4;
            }
            if (rbChannel16.Checked)
            {
                channelCount = 16;
            }
            return channelCount;
        }

        private void AntennaPowers() {
            string power1 = cbbPower1.Text;
            antennaPowers[0].Items.Add(power1);
            antennaPowers[0].SelectedItem = power1;

            string power2 = cbbPower2.Text;
            antennaPowers[1].Items.Add(power2);
            antennaPowers[1].SelectedItem = power2;

            string power3 = cbbPower3.Text;
            antennaPowers[2].Items.Add(power3);
            antennaPowers[2].SelectedItem = power3;

            string power4 = cbbPower4.Text;
            antennaPowers[3].Items.Add(power4);
            antennaPowers[3].SelectedItem = power4;

            string power5 = cbbPower5.Text;
            antennaPowers[4].Items.Add(power5);
            antennaPowers[4].SelectedItem = power5;

            string power6 = cbbPower6.Text;
            antennaPowers[5].Items.Add(power6);
            antennaPowers[5].SelectedItem = power6;

            string power7 = cbbPower7.Text;
            antennaPowers[6].Items.Add(power7);
            antennaPowers[6].SelectedItem = power7;

            string power8 = cbbPower8.Text;
            antennaPowers[7].Items.Add(power8);
            antennaPowers[7].SelectedItem = power8;

            string power9 = cbbPower9.Text;
            antennaPowers[8].Items.Add(power9);
            antennaPowers[8].SelectedItem = power9;

            string power10 = cbbPower10.Text;
            antennaPowers[9].Items.Add(power10);
            antennaPowers[9].SelectedItem = power10;

            string power11 = cbbPower11.Text;
            antennaPowers[10].Items.Add(power11);
            antennaPowers[10].SelectedItem = power11;

            string power12 = cbbPower12.Text;
            antennaPowers[11].Items.Add(power12);
            antennaPowers[11].SelectedItem = power12;

            string power13 = cbbPower13.Text;
            antennaPowers[12].Items.Add(power13);
            antennaPowers[12].SelectedItem = power13;

            string power14 = cbbPower14.Text;
            antennaPowers[13].Items.Add(power14);
            antennaPowers[13].SelectedItem = power14;

            string power15 = cbbPower15.Text;
            antennaPowers[14].Items.Add(power15);
            antennaPowers[14].SelectedItem = power15;

            string power16 = cbbPower16.Text;
            antennaPowers[15].Items.Add(power16);
            antennaPowers[15].SelectedItem = power16;
        }

        private void AntennaWorkTimes() 
        {
            string workTimes1 = cbbWorkTime1.Text;
            antennaWorkTimes[0].Items.Add(workTimes1);
            antennaWorkTimes[0].SelectedItem = workTimes1;

            string workTimes2 = cbbWorkTime2.Text;
            antennaWorkTimes[1].Items.Add(workTimes2);
            antennaWorkTimes[1].SelectedItem = workTimes2;

            string workTimes3 = cbbWorkTime3.Text;
            antennaWorkTimes[2].Items.Add(workTimes3);
            antennaWorkTimes[2].SelectedItem = workTimes3;

            string workTimes4 = cbbWorkTime4.Text;
            antennaWorkTimes[3].Items.Add(workTimes4);
            antennaWorkTimes[3].SelectedItem = workTimes4;

            string workTimes5 = cbbWorkTime5.Text;
            antennaWorkTimes[4].Items.Add(workTimes5);
            antennaWorkTimes[4].SelectedItem = workTimes5;

            string workTimes6 = cbbWorkTime6.Text;
            antennaWorkTimes[5].Items.Add(workTimes6);
            antennaWorkTimes[5].SelectedItem = workTimes6;

            string workTimes7 = cbbWorkTime7.Text;
            antennaWorkTimes[6].Items.Add(workTimes7);
            antennaWorkTimes[6].SelectedItem = workTimes7;

            string workTimes8 = cbbWorkTime8.Text;
            antennaWorkTimes[7].Items.Add(workTimes8);
            antennaWorkTimes[7].SelectedItem = workTimes8;

            string workTimes9 = cbbWorkTime9.Text;
            antennaWorkTimes[8].Items.Add(workTimes9);
            antennaWorkTimes[8].SelectedItem = workTimes9;

            string workTimes10 = cbbWorkTime10.Text;
            antennaWorkTimes[9].Items.Add(workTimes10);
            antennaWorkTimes[9].SelectedItem = workTimes10;

            string workTimes11 = cbbWorkTime11.Text;
            antennaWorkTimes[10].Items.Add(workTimes11);
            antennaWorkTimes[10].SelectedItem = workTimes11;

            string workTimes12 = cbbWorkTime12.Text;
            antennaWorkTimes[11].Items.Add(workTimes12);
            antennaWorkTimes[11].SelectedItem = workTimes12;

            string workTimes13 = cbbWorkTime13.Text;
            antennaWorkTimes[12].Items.Add(workTimes13);
            antennaWorkTimes[12].SelectedItem = workTimes13;

            string workTimes14 = cbbWorkTime14.Text;
            antennaWorkTimes[13].Items.Add(workTimes14);
            antennaWorkTimes[13].SelectedItem = workTimes14;

            string workTimes15 = cbbWorkTime15.Text;
            antennaWorkTimes[14].Items.Add(workTimes15);
            antennaWorkTimes[14].SelectedItem = workTimes15;

            string workTimes16 = cbbWorkTime16.Text;
            antennaWorkTimes[15].Items.Add(workTimes16);
            antennaWorkTimes[15].SelectedItem = workTimes16;
        }

        private void AntennaGapTimes()
        {
            string gapTimes1 = cbbGapTime1.Text;
            antennaGapTimes[0].Items.Add(gapTimes1);
            antennaGapTimes[0].SelectedItem = gapTimes1;

            string gapTimes2 = cbbGapTime2.Text;
            antennaGapTimes[1].Items.Add(gapTimes2);
            antennaGapTimes[1].SelectedItem = gapTimes2;

            string gapTimes3 = cbbGapTime3.Text;
            antennaGapTimes[2].Items.Add(gapTimes3);
            antennaGapTimes[2].SelectedItem = gapTimes3;

            string gapTimes4 = cbbGapTime4.Text;
            antennaGapTimes[3].Items.Add(gapTimes4);
            antennaGapTimes[3].SelectedItem = gapTimes4;

            string gapTimes5 = cbbGapTime5.Text;
            antennaGapTimes[4].Items.Add(gapTimes5);
            antennaGapTimes[4].SelectedItem = gapTimes5;

            string gapTimes6 = cbbGapTime6.Text;
            antennaGapTimes[5].Items.Add(gapTimes6);
            antennaGapTimes[5].SelectedItem = gapTimes6;

            string gapTimes7 = cbbGapTime7.Text;
            antennaGapTimes[6].Items.Add(gapTimes7);
            antennaGapTimes[6].SelectedItem = gapTimes7;

            string gapTimes8 = cbbGapTime8.Text;
            antennaGapTimes[7].Items.Add(gapTimes8);
            antennaGapTimes[7].SelectedItem = gapTimes8;

            string gapTimes9 = cbbGapTime9.Text;
            antennaGapTimes[8].Items.Add(gapTimes9);
            antennaGapTimes[8].SelectedItem = gapTimes9;

            string gapTimes10 = cbbGapTime10.Text;
            antennaGapTimes[9].Items.Add(gapTimes10);
            antennaGapTimes[9].SelectedItem = gapTimes10;

            string gapTimes11 = cbbGapTime11.Text;
            antennaGapTimes[10].Items.Add(gapTimes11);
            antennaGapTimes[10].SelectedItem = gapTimes11;

            string gapTimes12 = cbbGapTime12.Text;
            antennaGapTimes[11].Items.Add(gapTimes12);
            antennaGapTimes[11].SelectedItem = gapTimes12;

            string gapTimes13 = cbbGapTime13.Text;
            antennaGapTimes[12].Items.Add(gapTimes13);
            antennaGapTimes[12].SelectedItem = gapTimes13;

            string gapTimes14 = cbbGapTime14.Text;
            antennaGapTimes[13].Items.Add(gapTimes14);
            antennaGapTimes[13].SelectedItem = gapTimes14;

            string gapTimes15 = cbbGapTime15.Text;
            antennaGapTimes[14].Items.Add(gapTimes15);
            antennaGapTimes[14].SelectedItem = gapTimes15;

            string gapTimes16 = cbbGapTime16.Text;
            antennaGapTimes[15].Items.Add(gapTimes16);
            antennaGapTimes[15].SelectedItem = gapTimes16;
        }

        private void AssignmentAntennaParamsValue()
        {
            antennaIds[0].Checked = chkAnt1.Checked;
            antennaIds[1].Checked = chkAnt2.Checked;
            antennaIds[2].Checked = chkAnt3.Checked;
            antennaIds[3].Checked = chkAnt4.Checked;
            antennaIds[4].Checked = chkAnt5.Checked;
            antennaIds[5].Checked = chkAnt6.Checked;
            antennaIds[6].Checked = chkAnt7.Checked;
            antennaIds[7].Checked = chkAnt8.Checked;
            antennaIds[8].Checked = chkAnt9.Checked;
            antennaIds[9].Checked = chkAnt10.Checked;
            antennaIds[10].Checked = chkAnt11.Checked;
            antennaIds[11].Checked = chkAnt12.Checked;
            antennaIds[12].Checked = chkAnt13.Checked;
            antennaIds[13].Checked = chkAnt14.Checked;
            antennaIds[14].Checked = chkAnt15.Checked;
            antennaIds[15].Checked = chkAnt16.Checked;

            AntennaPowers();
            AntennaWorkTimes();
            AntennaGapTimes();
        }

        private void updateAntParam()
        {
            try
            {
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                QueryAntennaData();
                UIntPtr device = hashMap[key];
                AntennaChannelStruct antennaChannel = new AntennaChannelStruct();
                byte channel = GetChannelCount();
                if (channel == 0)
                {
                    lblMessageHit.Text = rm.GetString("strMsgFailedSetAnt");
                    return;
                }
                antennaChannel.channelCount = channel;
                AssignmentAntennaParamsValue();
                ChannelConfigStruct[] config = new ChannelConfigStruct[64];
                for (int i = 0; i < channel; i++)
                {
                    config[i] = new ChannelConfigStruct();
                    config[i].antennId = (byte)(i + 1);
                    config[i].enable = (byte)(antennaIds[i].Checked ? 1 : 0);
                    config[i].power = Byte.Parse(antennaPowers[i].SelectedItem.ToString());
                    config[i].workTime = ushort.Parse(antennaWorkTimes[i].SelectedItem.ToString());
                    string GapTimes = antennaGapTimes[i].SelectedItem.ToString();
                    config[i].freeTime = ushort.Parse(GapTimes);
                }
                antennaChannel.config = config;
                int result = TM200.UpdateAntennaConfig(device, antennaChannel);
                if (result < 1)
                {
                    lblMessageHit.Text = rm.GetString("strMsgFailedSetAnt");
                    return;
                }
                lblMessageHit.Text = rm.GetString("strMsgSucceedSetAnt");
            }
            catch (Exception e)
            {
                lblMessageHit.Text = e.Message;
            }
        }

        private void updateSingleOrMultiTag()
        {
            try
            {
                int readingMode = 0;
                // 检查单卡多卡模式
                //if ((readingMode = cbbSingOrMulti.SelectedIndex) == -1)
                //{
                //    lblMessageHit.Text = rm.GetString("strMsgInvalidSingleOrMulti");
                //    return;
                //}
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                UIntPtr device = hashMap[key];
                int result = 0;
                if (result < 1)
                {
                    lblMessageHit.Text = rm.GetString("strMessageUpdateReadTagModeFailure");
                    return;
                }
                lblMessageHit.Text = rm.GetString("strMessageUpdateReadTagModeSuccessed");
            }
            catch (Exception e)
            {
                lblMessageHit.Text = e.Message;
            }
        }

        private void queryDeviceId()
        {
            try
            {
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                UIntPtr device = hashMap[key];
                ushort deviceid = 0;
                //int result = TM200.QueryDeviceIdNotEPROM(device, ref deviceid);
                int result = TM200.QueryDeviceId(device, ref deviceid);
                if (result < 1)
                {
                    lblMessageHit.Text = rm.GetString("strMsgQueryFailed");
                    return;
                }
                lblMessageHit.Text = rm.GetString("strMsgQuerySucceed");
                tbNewDevNo.Text = string.Format("{0:d}", deviceid);
            }
            catch (Exception e)
            {
                lblMessageHit.Text = e.Message;
            }
        }

        private void updateDeviceId()
        {
            try
            {
                int deviceNo = 0;
                //  检查设备号
                if (!int.TryParse(tbNewDevNo.Text, out deviceNo))
                {
                    lblMessageHit.Text = rm.GetString("strMsgInvalidDevNo");
                    return;
                }
                else
                {
                    if (deviceNo > 65535)
                    {
                        lblMessageHit.Text = rm.GetString("strMsgInvalidDevNo");
                        return;
                    }
                }
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                UIntPtr device = hashMap[key];
                int result = TM200.UpdateDeviceId(device, (ushort)deviceNo);
                //int result = TM200.UpdateDeviceIdNotEPROM(device, (ushort)(deviceNo));
                if (result < 1)
                {
                    lblMessageHit.Text = rm.GetString("strMessageUpdateDeviceNoFailure");
                    return;
                }
                lblMessageHit.Text = rm.GetString("strMessageUpdateDeviceNoSuccessed");
            }
            catch (Exception e)
            {
                lblMessageHit.Text = e.Message;
            }
        }
        /********************************************其化参数设置 2021-03-09 End**************************************************************/
        #endregion 其它操作

        #region 国际化
        private void languageGeneral()
        {
            tpGeneral.Text = rm.GetString("strTpGeneral");
            btnSerialPortConnect.Text = rm.GetString("strBtnConnect");
            btnSerialPortDisconnect.Text = rm.GetString("strBtnDisconnect");
            btnUpdateSerialPort.Text = rm.GetString("strBtnUpdate");
            lblSerialPort.Text = rm.GetString("strRbSerialPort");
            lblBaudRate.Text = rm.GetString("strDatas");
            gbConnectType.Text = rm.GetString("strGbCommMode");
            btnStartMonitor.Text = rm.GetString("btnStartMonitor");
            btnStopMonitor.Text = rm.GetString("btnStopMonitor");

            lblTCPClientPort.Text = rm.GetString("strLabCommPort");
            lblTCPServerPort.Text = rm.GetString("strLabCommPort");
            btnUpdateTCPClient.Text = rm.GetString("strBtnUpdate");
            btnUpdateTCPServer.Text = rm.GetString("btnLocalHost");

            btnTCPClientConnect.Text = rm.GetString("strBtnConnect");
            btnTCPClientDisconnect.Text = rm.GetString("strBtnDisconnect");

            btnStartReadData.Text = rm.GetString("strBtnStartReadData");
            btnStopReadData.Text = rm.GetString("strBtnStopReadData");
            btnClearListView.Text = rm.GetString("strBtnClearListView");
            btnReadOnce.Text = rm.GetString("strBtnReadOnce");

            gbVersionInfo.Text = rm.GetString("gbVersionInfo");
            btnReadVersion.Text = rm.GetString("btnReadVersionInfo");
            btnBrushVersion.Text = rm.GetString("btnBrushVersion");
            btnDefaultNetworkParams.Text = rm.GetString("btnDefaultNetworkParams");

        }

        private void languageTagAccess()
        {
            tpTagAccess.Text = rm.GetString("strTpTagAccess");

            btnReadFastTag.Text = rm.GetString("btnReadFastTag");
            btnKillTag.Text = rm.GetString("strBtnKillTag");
            btnModifyDev.Text = rm.GetString("strBtnModifyDev");
            btnLockTag.Text = rm.GetString("strBtnLock");
            //btnUnlockTag.Text = rm.GetString("strBtnUnlockTag");
            btnInitTag.Text = rm.GetString("strBtnInitTag");
            btnReadData.Text = rm.GetString("strBtnReadTagData");
            //gbTagInitialize.Text = rm.GetString("gbTagInitialize");
            gbKillTag.Text = rm.GetString("gbKillTag");
            gbTagLockAndUnlock.Text = rm.GetString("gbTagLockAndUnlock");

        }

        private void cbbLangSwitch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //锁卡操作类型
            cbbLockBank.Items.Clear();
            //cbbTrigSwitch.Items.Clear();
            //cbbSingOrMulti.Items.Clear();
            //cbbFreqMode.Items.Clear();
            //cbbFreqModeEU.Items.Clear();
            cbbBeepControl.Items.Clear();
            //cbbUsbFormat.Items.Clear();
            cbbFrequencyBand.Items.Clear();
            //cbbEPCDataFormat.Items.Clear();

            if (cbbLangSwitch.SelectedIndex == 0)
            {
                ChineseLanguage.language(
                            cbbLockBank, cbbLockType,
                            cbbFrequencyBand,
                            cbbBeepControl
                           );

            }
            else
            {
                EnglishLanguage.language(
                            cbbLockBank, cbbLockType,
                            cbbFrequencyBand,
                            cbbBeepControl);
                //cbbEPCDataFormat.SelectedIndex = 1;
            }
            rm = rmArray[cbbLangSwitch.SelectedIndex];
            // Tab标签页标题


            tpSetCommParam.Text = rm.GetString("strTpSetCommParam");
            tbSetReaderParam.Text = rm.GetString("strTpSetReaderParam");
            tpOtherOpreation.Text = rm.GetString("strTpOtherOpr");
            tpAntennaParams.Text = rm.GetString("strTpAntennaParam");

            languageGeneral();
            languageTagAccess();

            tpMaster.Text = rm.GetString("tpMaster");
            tpTiming.Text = rm.GetString("tpTiming");
            tpTrigger.Text = rm.GetString("tpTrigger");

            tpRS485.Text = rm.GetString("tpRS485_RJ45");
            tpWiegand.Text = rm.GetString("tpWiegand");
            tpRS232.Text = rm.GetString("tpSerialPorts");

            tabPageUnify.Text = rm.GetString("tabPageUnify");
            tabPageAlone.Text = rm.GetString("tabPageAlone");
            lblFrequencyArea.Text = rm.GetString("lblFrequencyArea");
            gbAdjacentDiscriminant.Text = rm.GetString("gbAdjacentDiscriminant");
            btnAdjacentDiscriminantRead2.Text = rm.GetString("btnAdjacentDiscriminantQuery");
            btnAdjacentDiscriminantSet2.Text = rm.GetString("btnAdjacentDiscriminantUpdate");

            //tpUSA.Text = rm.GetString("tpUSA_Band");
            //tpEU_Band.Text = rm.GetString("tpEU_Band");
            //tpKorea_Band.Text = rm.GetString("tpKorea_Band");

            // 表头更新
            BasicOperation.InitTableInfoColumns(rm, listView);

            lvZl.Columns[0].Text = rm.GetString("strZlHeadNo");
            lvZl.Columns[1].Text = rm.GetString("strZlHeadIP");
            lvZl.Columns[2].Text = rm.GetString("strZlHeadPort");
            lvZl.Columns[3].Text = rm.GetString("strZlHeadMAC");

            btnDefaultParams.Text = rm.GetString("strBtnDefaultParams");
            btnSearchDev.Text = rm.GetString("strBtnSearchDev");

            btnSetFreq.Text = rm.GetString("strBtnSetDevNo");
            btnSetWorkMode.Text = rm.GetString("strBtnSetNeighJudge");
            btnSetParams.Text = rm.GetString("strBtnSetParams");
            btnWriteData.Text = rm.GetString("strBtnWriteTagData");
            btnClearData.Text = rm.GetString("strBtnClearEditData");
            btnFastWrite.Text = rm.GetString("strBtnFastWrite");
            btnClearFWData.Text = rm.GetString("strBtnClearFWData");
            btnReadWorkMode.Text = rm.GetString("strBtnReadWorkMode");
            btnDefaultWorkMode.Text = rm.GetString("strBtnDefaultWorkMode");
            btnSetWorkMode.Text = rm.GetString("strBtnSetWorkMode");
            btnReadCommMode.Text = rm.GetString("strBtnReadCommMode");
            btnDefaultCommMode.Text = rm.GetString("strBtnDefaultCommMode");
            btnSetCommMode.Text = rm.GetString("strBtnSetCommMode");
            btnReadFreq.Text = rm.GetString("strBtnReadFreq");
            btnSetFreq.Text = rm.GetString("strBtnSetFreq");
            btnDefaultFreq.Text = rm.GetString("strBtnDefaultFreq");
            //btnClearFreq.Text = rm.GetString("strBtnClearFreq");
            btnTagAuthorize.Text = rm.GetString("strBtnTagAuth");
            btnModifyAuthorize.Text = rm.GetString("strBtnModAuthPwd");

            lblInfoShow.Text = rm.GetString("lblInfoShow");
            //btnReadEPCDataFormat.Text = rm.GetString("btnReadEPCDataFormat");
            //gbNotDoubleUSBDevice.Text = rm.GetString("gbNotDoubleUSBDevice");
            gbDataOutputFormat.Text = rm.GetString("gbDataOutputFormat");
            //btnSetEPCDataFormat.Text = rm.GetString("btnSetEPCDataFormat");
            tpInitiative.Text = rm.GetString("tpInitiative");
            tpPassivity.Text = rm.GetString("tpPassivity");
            btnReadDeviceId.Text = rm.GetString("btnReadDeviceId");
            btnSetDeviceId.Text = rm.GetString("btnSetDeviceId");
            lblLedLamp.Text = rm.GetString("lblLedLamp");

            //btnGetReadMode.Text = rm.GetString("btnGetReadMode");
            // btnSetReadMode.Text = rm.GetString("btnSetReadMode");


            btnSetBeep.Text = rm.GetString("strBtnSetBeep");
            //btnSetUsbFormat.Text = rm.GetString("strBtnSetUsbFormat");
            btnReadBeep.Text = rm.GetString("btnReadBeep");
            rbOpen1.Text = rm.GetString("rdoOpen1");
            rbClose1.Text = rm.GetString("rdoClose1");
            rbOpen2.Text = rm.GetString("rdoOpen2");
            rbClose2.Text = rm.GetString("rdoClose2");
            chkZD.Text = rm.GetString("chkZD");
            //lbl_ip.Text = rm.GetString("");
            btn_connRead.Text = rm.GetString("strBtnConnRead");
            tbWifiTCPConfig.Text = rm.GetString("tbWifiTCPConfig");
            btn_stoptimer.Text = rm.GetString("strStopRead");
            //btnWeigandConvert.Text = rm.GetString("strSwitch");
            //反键菜单
            tsmiSave.Text = rm.GetString("saveStr");
            //读写界面
            //chkDesignatedAntRead.Text = rm.GetString("strReadByAnt");
            //chkDesignatedAntWrite.Text = rm.GetString("strWriteByAnt");
            //rbAnt1.Text = rm.GetString("chkAnt1");
            //rbAnt2.Text = rm.GetString("chkAnt2");
            //rbAnt3.Text = rm.GetString("chkAnt3");
            //rbAnt4.Text = rm.GetString("chkAnt4");
            //rbAnt5.Text = rm.GetString("chkAnt5");
            //rbAnt6.Text = rm.GetString("chkAnt6");
            //rbAnt7.Text = rm.GetString("chkAnt7");
            //rbAnt8.Text = rm.GetString("chkAnt8");
            // RadioButton标示
            //rbReadSingleTag.Text = rm.GetString("strRbReadSingleTag");
            //rbReadMultiTag.Text = rm.GetString("strRbReadMultiTag");
            rbAsc.Text = rm.GetString("strRbAsc");
            rbDesc.Text = rm.GetString("strRbDesc");
            //label3.Text = rm.GetString("strWeigand");
            //rbWeigand26_1_2.Text = rm.GetString("strWeigand21");
            //rbWeigand26_3_0.Text = rm.GetString("strWeigand30");
            // CheckBox标示

            // GroupBox说明文字
            //gbReadMode.Text = rm.GetString("strGbReadMode");
            gbWorkMode.Text = rm.GetString("strGbDevParams");
            gbFastWrite.Text = rm.GetString("strGbFastWrite");
            gbNetParams.Text = rm.GetString("strGbNetParams");
            gbRWData.Text = rm.GetString("strGbRWData");
            gbSPParams.Text = rm.GetString("strGbSPParams");
            gbCommModeParam.Text = rm.GetString("strGbCommModeParam");
            gbFreq.Text = rm.GetString("strGbFreq");
            gbTagAuth.Text = rm.GetString("strGbTagAuth");
            gbBeepControl.Text = rm.GetString("strGbBeepControl");
            //gbUsbFormat.Text = rm.GetString("strGbUsbFormat");

            chkAjaDisc.Text = rm.GetString("strChkAjaDis");
            cbSaveFile.Text = rm.GetString("strChkSaveFile");
            //lblUserCustomDataLength.Text = rm.GetString("lblUserCustomDataLength");
            lblUserCustomData.Text = rm.GetString("lblUserCustomData");

            chkPrivateData.Text = rm.GetString("chkPrivateData");
            chkAlarmState.Text = rm.GetString("chkAlarmState");
            chkTagArea.Text = rm.GetString("chkTagArea");
            chkAntennaId.Text = rm.GetString("chkAntennaId");

            chkTagTime.Text = rm.GetString("chkTagTime");
            chkUseCustomeData.Text = rm.GetString("chkUseCustomeData");

            gbDevNo.Text = rm.GetString("strLabDevNo");

            //labDevNo.Text = rm.GetString("strLabDevNo");
            grpAntSet.Text = rm.GetString("grpAntSet");
            lblAntennaPower.Text = rm.GetString("lblAntennaPower");
            lblAntennaGapTime.Text = rm.GetString("lblAntennaGapTime");
            lblAntennaWorkTime.Text = rm.GetString("lblAntennaWorkTime");
            lblAntennaId.Text = rm.GetString("lblAntennaId");
            btnReadChannelCount.Text = rm.GetString("btnReadChannelCount");

            rbChannel1.Text = rm.GetString("rbChannel1");
            rbChannel2.Text = rm.GetString("rbChannel2");
            rbChannel4.Text = rm.GetString("rbChannel4");
            rbChannel8.Text = rm.GetString("rbChannel8");
            rbChannel16.Text = rm.GetString("rbChannel16");
            rbChannel32.Text = rm.GetString("rbChannel32");

            chkAnt1.Text = rm.GetString("chkAnt1");
            chkAnt2.Text = rm.GetString("chkAnt2");
            chkAnt3.Text = rm.GetString("chkAnt3");
            chkAnt4.Text = rm.GetString("chkAnt4");
            chkAnt5.Text = rm.GetString("chkAnt5");
            chkAnt6.Text = rm.GetString("chkAnt6");
            chkAnt7.Text = rm.GetString("chkAnt7");
            chkAnt8.Text = rm.GetString("chkAnt8");

            lblEndFrequ.Text = rm.GetString("lblEndFrequ");
            lblStartFrequ.Text = rm.GetString("lblStartFrequ");
            lblChannelSpacing.Text = rm.GetString("lblChannelSpacing");
            gbLinkModel.Text = rm.GetString("gbLinkModel");


            btnDefaultLinkModel.Text = rm.GetString("strBtnDefaultFreq");
            btnQueryLinkModel.Text = rm.GetString("strBtnReadFreq");
            btnUpdateLinkModel.Text = rm.GetString("strBtnSetFreq");


            btnQueryOutputformat.Text = rm.GetString("btnAntRead");
            btnUpdateOutputFormat.Text = rm.GetString("btnAntSet");

            btnQueryUserCustomData.Text = rm.GetString("btnAntRead");
            btnUpdateUserCustomData.Text = rm.GetString("btnAntSet");
            btnQueryRelay.Text = rm.GetString("btnAntRead");

            btnQueryTCPConfig.Text = rm.GetString("btnAntRead");
            btnUpdateTCPConfig.Text = rm.GetString("btnAntSet");
            lblTCPPort.Text = rm.GetString("lblTCPPort");
            gbTCPConfig.Text = rm.GetString("lblTCPPort");
            chkNetwork.Text = rm.GetString("chkNetwork");


            btnQueryHttpConfig.Text = rm.GetString("btnAntRead");
            btnUpdateHttpConfig.Text = rm.GetString("btnAntSet");

            lblCommunicationType.Text = rm.GetString("lblCommunicationType");
            lblGPSReportingInterval.Text = rm.GetString("lblGPSReportingInterval");


            lblTCPCommunicationType.Text = rm.GetString("lblCommunicationType");
            gbGSPConfig.Text = rm.GetString("gbGSPConfig");
            gbWifiConfig.Text = rm.GetString("gbWifiConfig");
            gbWifiConnectConfig.Text = rm.GetString("gbWifiConnectConfig");
            lblDestIP.Text = rm.GetString("lblDestIP");
            lblDestPort.Text = rm.GetString("lblDestPort");
            btnLocalHost.Text = rm.GetString("btnLocalHost");


            btnQueryGSPConfig.Text = rm.GetString("btnAntRead");
            btnUpdateGPSConfig.Text = rm.GetString("btnAntSet");



            btnQueryWifi.Text = rm.GetString("btnAntRead");
            btnUpdateWifi.Text = rm.GetString("btnAntSet");

            btnQueryWifiTCPConfig.Text = rm.GetString("btnAntRead");
            btnUpdateWifiTCPConfig.Text = rm.GetString("btnAntSet");


            btnFactorySetting.Text = rm.GetString("btnFactorySetting");
            btnDeviceReset.Text = rm.GetString("btnDeviceReset");
            gbLEDLamp.Text = rm.GetString("gbLEDLamp");
            lblHttpCommunicationType.Text = rm.GetString("lblCommunicationType");
            gbUserCustomData.Text = rm.GetString("gbUserCustomData");
            lblHttpPort.Text = rm.GetString("lblTCPPort");
            lblHttpReportingInterval.Text = rm.GetString("lblGPSReportingInterval");
            gbHttpConfig.Text = rm.GetString("gbHttpConfig");
            chkWifiPwd.Text = rm.GetString("chkWifiPwd");

            btnGetLamp.Text = rm.GetString("btnAntRead");
            btnSetLamp.Text = rm.GetString("btnAntSet");

            btnAntRead.Text = rm.GetString("btnAntRead");
            btnAntSet.Text = rm.GetString("btnAntSet");

            lblOperationType.Text = rm.GetString("lblOperationType");

            // Label标签
            labBaudRate.Text = rm.GetString("strLabBaudRate");
            labCheckBits.Text = rm.GetString("strLabCheckBits");
            labDataBits.Text = rm.GetString("strLabDataBits");
            labDestIP.Text = rm.GetString("strLabDestIP");
            labDestPort.Text = rm.GetString("strLabDestPort");
            labDestroyPwd.Text = rm.GetString("strLabDestrlyPwd");

            labGateway.Text = rm.GetString("strLabGateway");
            labIPAdd.Text = rm.GetString("strLabIPAdd");
            labIPMode.Text = rm.GetString("strLabIPMode");
            labLength.Text = rm.GetString("strLabLength");
            labLockAccessPwd.Text = rm.GetString("strLabLockAccessPwd");
            labLockBank.Text = rm.GetString("strLabLockBank");
            labMask.Text = rm.GetString("strLabMask");
            labNetMode.Text = rm.GetString("strLabNetMode");
            labPort.Text = rm.GetString("strLabPort");
            labPromotion.Text = rm.GetString("strLabPromotion");
            labOprBank.Text = rm.GetString("strLabRWBank");
            labData.Text = rm.GetString("strLabRWData");
            labStartAdd.Text = rm.GetString("strLabStartAdd");
            labReadCount.Text = rm.GetString("strLabCount");
            labTagCount.Text = rm.GetString("strLabTagCount");
            labFWData.Text = rm.GetString("strLabFWData");
            labFWPromo.Text = rm.GetString("strLabFWPromotion");



            //labWorkMode.Text = rm.GetString("strLabWorkMode");
            //labTimingParam.Text = rm.GetString("strLabTimingParam");
            //labTimingUnit.Text = rm.GetString("strLabTimingUnit");
            //labTrigSwitch.Text = rm.GetString("strLabTrigSwitch");
            labTrigParam.Text = rm.GetString("strLabTrigParam");
            labDelayUnit.Text = rm.GetString("strLabDelayUnit");
            // labCommMode.Text = rm.GetString("strLabCommMode");
            labPulseWidth.Text = rm.GetString("strLabPulseWidth");
            labPulseWidthUnit.Text = rm.GetString("strLabPulseWidthUnit");
            labPulseCycle.Text = rm.GetString("strLabPulseCycle");
            labPulseCycleUnit.Text = rm.GetString("strLabPulseCycleUnit");
            labWiegandProtocol.Text = rm.GetString("strLabWiegandProtocol");
            //gbSingleOrMulti.Text = rm.GetString("strLabReadMode");

            //labPower.Text = rm.GetString("strLabPower");
            //labSingleOrMulti.Text = rm.GetString("strLabReadMode");

            //labFreq.Text = rm.GetString("strLabFreqSet");
            //lblFreq.Text = rm.GetString("strLabFreqSet");
            labAuthPwd.Text = rm.GetString("strLabAuthPwd");
            labNewAuthPwd.Text = rm.GetString("strLabNewAuthPwd");
            lblWigginsTakePlaceValue.Text = rm.GetString("lblWigginsTakePlaceValue");
            lblReadVoice.Text = rm.GetString("lblReadVoice");

            //2017-2-21 ZW 新增波特率中英文
            lbl_rate.Text = rm.GetString("strLabBaudRate");

            lblRS485BaudRate.Text = rm.GetString("strLabBaudRate");
            // 语言切换后，清空左下角结果提示串
            lblMessageHit.Text = "";
            labelVersion.Text = "";
            labSetParam.Text = "";
            btnReadDataArea.Text = rm.GetString("strBtnReadTagData");
            //btnReadUsbFormat.Text = rm.GetString("strBtnReadTagData");
            //继电器控制
            GopRelayControl.Text = rm.GetString("GopRelayControl");
            //rdoOpenRelay.Text = rm.GetString("rdoOpenRelay");
            //rdoCloseRelay.Text = rm.GetString("rdoCloseRelay");
            lblCloseTime.Text = rm.GetString("lblCloseTime");
            btnSetRelay.Text = rm.GetString("btnSetRelayTime");
            //btnAdvancedAccess.Text = rm.GetString("advancedAccessStr");
            //btnAutoAuthorization.Text = rm.GetString("startAutoAuthorization");
            // btnAutoAuthorization.Text = rm.GetString("startAutoAuthorization");
            //label1.Text = rm.GetString("AuthorizationResult");
            //authorizationLb.Text = rm.GetString("NoneAuthorizationTag");
            label2.Text = rm.GetString("strLabRWBank");
            btnSetDataArea.Text = rm.GetString("strBtnSetAlive");
            //EpcFormatLB.Text = rm.GetString("strFormatEPC");

            btnQueryAuthorize.Text = rm.GetString("strGetAuthorizationCode");
            AuthorizationSuccess = rm.GetString("authorizationSuccess");
            NoneAuthorizationTag = rm.GetString("NoneAuthorizationTag");
            //if (bathReadWrite != null)
            //{
            //    bathReadWrite.ChangeLanguage(rm);
            //}

            gbNetworkParams.Text = rm.GetString("gbNetworkParams");
            lblNetworkPattern.Text = rm.GetString("lblNetworkPattern");
            lblIPModel.Text = rm.GetString("lblIPModel");
            lblDeviceIPAddress.Text = rm.GetString("lblDeviceIPAddress");
            lblDevicePort.Text = rm.GetString("lblDevicePort");
            lblSubnetMask.Text = rm.GetString("lblSubnetMask");
            lblGateway.Text = rm.GetString("lblSubnetMask");


            lblNetworkDestIP.Text = rm.GetString("lblDestIP");
            lblNetworkDestPort.Text = rm.GetString("lblDestPort");
            lblNetworkParamsClientConfig.Text = rm.GetString("lblNetworkParamsClientConfig");
            lblMacAddress.Text = rm.GetString("lblMacAddress");

            btnQueryNetworkParams.Text = rm.GetString("btnAntRead");
            btnUpdateNetworkParams.Text = rm.GetString("btnAntSet");

            gbTagType.Text = rm.GetString("gbTagType");
            lblTagType.Text = rm.GetString("lblTagType");
            btnTagTypeRead.Text = rm.GetString("btnTagTypeRead");
            btnTagTypeSet.Text = rm.GetString("btnTagTypeSet");
            gbSpecifiedAddressAndLength.Text = rm.GetString("gbSpecifiedAddressAndLength");
            lblTagArea.Text = rm.GetString("lblTagArea");
            labStartAdd2.Text = rm.GetString("strLabStartAdd");
            labLength2.Text = rm.GetString("strLabLength");
            chbEnable.Text = rm.GetString("chbEnable");
            btnSpecifiedAddressAndLengthRead.Text = rm.GetString("btnSpecifiedAddressAndLengthRead");
            btnSpecifiedAddressAndLengthSet.Text = rm.GetString("btnSpecifiedAddressAndLengthSet");


            cbbTagType.Items.Clear();
            cbbTagType.Items.Add(rm.GetString("cbbItemGeneralTag"));
            cbbTagType.Items.Add(rm.GetString("cbbItemEncryptionTag"));
            cbbTagType.Items.Add(rm.GetString("cbbItemYueHeLTU31"));
            cbbTagType.Items.Add(rm.GetString("cbbItemYueHeLTU32"));

            btnReadAdjaDiscri.Text = rm.GetString("btnReadAdjaDiscri");
            btnUpdateAdjaDiscri.Text = rm.GetString("btnUpdateAdjaDiscri");
        }

        private void InitCommParamControl()
        {
            try
            {
                comboBoxNetMode.Items.Add("TCP Server");
                comboBoxNetMode.Items.Add("TCP Client");
                comboBoxNetMode.Items.Add("UDP");
                comboBoxNetMode.Items.Add("UDP Group");

                comboBoxIPMode.Items.Add("Static");
                comboBoxIPMode.Items.Add("Dynamic");

                comboBoxBaudRate.Items.Add("1200");
                comboBoxBaudRate.Items.Add("2400");
                comboBoxBaudRate.Items.Add("4800");
                comboBoxBaudRate.Items.Add("7200");
                comboBoxBaudRate.Items.Add("9600");
                comboBoxBaudRate.Items.Add("14400");
                comboBoxBaudRate.Items.Add("19200");
                comboBoxBaudRate.Items.Add("28800");
                comboBoxBaudRate.Items.Add("38400");
                comboBoxBaudRate.Items.Add("57600");
                comboBoxBaudRate.Items.Add("76800");
                comboBoxBaudRate.Items.Add("115200");
                comboBoxBaudRate.Items.Add("230400");

                #region  2017-2-21 ZW 参数设置界面新增速率设置
                cbbBaud_Rate.Items.Add("2400");
                cbbBaud_Rate.Items.Add("4800");
                cbbBaud_Rate.Items.Add("9600");
                cbbBaud_Rate.Items.Add("19200");
                cbbBaud_Rate.Items.Add("38400");
                cbbBaud_Rate.Items.Add("57600");
                cbbBaud_Rate.Items.Add("115200");
                cbbBaud_Rate.SelectedIndex = 0;

                cbbRS485BaudRate.Items.Add("2400");
                cbbRS485BaudRate.Items.Add("4800");
                cbbRS485BaudRate.Items.Add("9600");
                cbbRS485BaudRate.Items.Add("19200");
                cbbRS485BaudRate.Items.Add("38400");
                cbbRS485BaudRate.Items.Add("57600");
                cbbRS485BaudRate.Items.Add("115200");

                cbbRS485BaudRate.SelectedIndex = 0;
                #endregion

                comboBoxDataBits.Items.Add("8");
                comboBoxDataBits.Items.Add("7");
                comboBoxDataBits.Items.Add("6");
                comboBoxDataBits.Items.Add("5");

                comboBoxCheckBits.Items.Add("None");
                comboBoxCheckBits.Items.Add("Odd");
                comboBoxCheckBits.Items.Add("Even");
                comboBoxCheckBits.Items.Add("Marked");
                comboBoxCheckBits.Items.Add("Space");
            }
            catch (Exception e)
            {
                lblMessageHit.Text = "InitCommParamControl " + e.Message;
            }
        }
        #endregion 国际化

        #region 频率选取

        /// <summary>
        ///  频率及其它参数设置
        ///  2015-11-9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetFreq_Click(object sender, EventArgs e)
        {
            try
            {
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                int band = cbbFrequencyBand.SelectedIndex;
                if (band == -1)
                {
                    lblMessageHit.Text = rm.GetString("strMsgInvalidFreqMode");
                    return;
                }
                byte national_standard = (byte)band;
                string channelSpacing = tbChannelSpacing.Text;

                if (band == 6 && !DataConvert.IsDecimalismCharacter(channelSpacing) && !DataConvert.IsDecimalismCharacter(cbbEndFrequ.Text))
                {
                    lblMessageHit.Text = rm.GetString("strMsgInvalidFreqMode");
                    return;
                }
                WorkFrequencyStruct frequency = new WorkFrequencyStruct();
                frequency.standard = (byte)band;
                switch (band)
                {
                    case 0:
                    case 1:
                    case 4:
                    case 5:
                        frequency.chanelNumber = (byte)(cbbEndFrequ.SelectedIndex + 1);
                        frequency.startFrequency = double.Parse(cbbStartFrequ.SelectedItem.ToString());
                        break;
                    case 2:
                    case 3:
                        break;
                    case 6:
                        frequency.channelSpacing = ushort.Parse(tbChannelSpacing.Text);
                        frequency.startFrequency = double.Parse(cbbStartFrequ.Text.ToString());
                        frequency.chanelNumber = byte.Parse(cbbEndFrequ.Text);
                        break;
                }
                int result = TM200.UpdateWorkFrequency(hashMap[key], frequency);
                if (0 == result)
                {
                    lblMessageHit.Text = rm.GetString("strMsgFailedSetFreq");
                    return;
                }
                lblMessageHit.Text = rm.GetString("strMsgSucceedSetFreq");
            }
            catch (Exception e2)
            {
                lblMessageHit.Text = e2.Message;
            }
        }

        /// <summary>
        /// 频率及其它参数读取
        /// 2015-11-9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadFreq_Click(object sender, EventArgs e)
        {
            try
            {
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                WorkFrequencyStruct frequency = new WorkFrequencyStruct();
                int result = TM200.QueryWorkFrequency(hashMap[key], ref frequency);
                if (result < 1)
                {
                    lblMessageHit.Text = rm.GetString("strMsgFailureGetFreq");
                    return;
                }
                cbbStartFrequ.Items.Clear();
                cbbEndFrequ.Items.Clear();
                double startFrequ = 920;
                cbbFrequencyBand.SelectedIndex = frequency.standard;
                intialChannelSpacing(false);
                switch (frequency.standard)
                {
                    case 0:  //CHINA-2
                        china2Standard(startFrequ, cbbStartFrequ);
                        china2Standard(startFrequ, cbbEndFrequ);
                        break;
                    case 1: //USA
                        USA_Standard(cbbStartFrequ);
                        USA_Standard(cbbEndFrequ);
                        break;
                    case 2: //JAPAN(暂不支持)
                    case 3: //MALAYSIA(暂不支持)
                        break;
                    case 4: //ETSI
                        ETSI_Standard(cbbStartFrequ);
                        ETSI_Standard(cbbEndFrequ);
                        break;
                    case 5: //CHINA-1(暂不支持)
                        startFrequ = 840;
                        china2Standard(startFrequ, cbbStartFrequ);
                        china2Standard(startFrequ, cbbEndFrequ);
                        break;
                    case 6: //Custom
                        tbChannelSpacing.Text = "600";
                        cbbStartFrequ.DropDownStyle = ComboBoxStyle.DropDown;
                        cbbEndFrequ.DropDownStyle = ComboBoxStyle.DropDown;
                        intialChannelSpacing(true);
                        break;
                    default:
                        break;
                }
                if (frequency.standard == 6)
                {
                    cbbStartFrequ.Text = frequency.startFrequency.ToString("0.000");
                    cbbEndFrequ.Text = frequency.chanelNumber.ToString();
                    tbChannelSpacing.Text = frequency.channelSpacing.ToString();
                }
                else
                {
                    cbbStartFrequ.Text = frequency.startFrequency.ToString("0.000");
                    cbbEndFrequ.SelectedIndex = frequency.chanelNumber - 1;
                    tbChannelSpacing.Text = frequency.channelSpacing.ToString();
                }

                lblMessageHit.Text = rm.GetString("strMsgSucceedGetFreq");
            }
            catch
            {
                lblMessageHit.Text = rm.GetString("strMsgFailureGetFreq");
            }
        }

        private void china2Standard(double startFreq, ComboBox frequ)
        {
            int index = 0;
            double[] freq = { 125, 375, 625, 875 };
            for (int i = 0; i < 20; i++)
            {
                if ((i != 0) && (i % 4 == 0))
                {
                    index = 0;
                    startFreq++;
                }
                double temp = startFreq + (freq[index] / 1000);
                frequ.Items.Add(temp);
                index++;
            }
        }

        private void USA_Standard(ComboBox frequ)
        {
            double value = 902;
            int index = 1;
            double[] freq = { 250, 750 };
            for (int i = 0; i < 50; i++)
            {
                double temp = value + (freq[index] / 1000);
                string result = String.Format("{0:N3}", temp);
                frequ.Items.Add(result);
                if (i % 2 == 0)
                {
                    index = 0;
                    value++;
                }
                else
                {
                    index++;
                }
            }
        }

        private void ETSI_Standard(ComboBox frequ)
        {
            frequ.Items.Add("865.700");
            frequ.Items.Add("866.300");
            frequ.Items.Add("866.900");
            frequ.Items.Add("867.500");
        }

        private void intialChannelSpacing(bool flag)
        {
            lblChannelSpacing.Visible = flag;
            lblChannelSpacingUnit.Visible = flag;
            tbChannelSpacing.Visible = flag;
        }

        private void cboBand_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbStartFrequ.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbEndFrequ.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbStartFrequ.Items.Clear();
            cbbEndFrequ.Items.Clear();
            int bandIndex = cbbFrequencyBand.SelectedIndex;
            intialChannelSpacing(false);
            double startFrequ = 920;
            switch (bandIndex)
            {
                case -1:
                    break;
                case 0:  //CHINA-2
                    china2Standard(startFrequ, cbbStartFrequ);
                    china2Standard(startFrequ, cbbEndFrequ);
                    cbbStartFrequ.SelectedIndex = 0;
                    cbbEndFrequ.SelectedIndex = cbbEndFrequ.Items.Count - 1;
                    lblEndFrequ.Text = "结束频率";
                    break;
                case 1: //USA
                    USA_Standard(cbbStartFrequ);
                    USA_Standard(cbbEndFrequ);
                    cbbStartFrequ.SelectedIndex = 0;
                    cbbEndFrequ.SelectedIndex = cbbEndFrequ.Items.Count - 1;
                    lblEndFrequ.Text = "结束频率";
                    break;
                case 2: //JAPAN(暂不支持)
                case 3: //MALAYSIA(暂不支持)
                    cbbStartFrequ.SelectedIndex = -1;
                    cbbEndFrequ.SelectedIndex = -1;
                    break;
                case 4: //ETSI
                    ETSI_Standard(cbbStartFrequ);
                    ETSI_Standard(cbbEndFrequ);
                    cbbStartFrequ.SelectedIndex = 0;
                    cbbEndFrequ.SelectedIndex = cbbEndFrequ.Items.Count - 1;
                    lblEndFrequ.Text = "结束频率";
                    break;
                case 5: //CHINA-1(暂不支持)
                    startFrequ = 840;
                    china2Standard(startFrequ, cbbStartFrequ);
                    china2Standard(startFrequ, cbbEndFrequ);
                    cbbStartFrequ.SelectedIndex = 0;
                    cbbEndFrequ.SelectedIndex = cbbEndFrequ.Items.Count - 1;
                    lblEndFrequ.Text = "结束频率";
                    break;
                case 6: //Custom
                    tbChannelSpacing.Text = "600";
                    intialChannelSpacing(true);
                    cbbStartFrequ.DropDownStyle = ComboBoxStyle.DropDown;
                    cbbEndFrequ.DropDownStyle = ComboBoxStyle.DropDown;
                    lblEndFrequ.Text = "信道个数";
                    break;
                default:
                    break;
            }

        }

        private void ShowFixUSPoint(ComboBox cbbFixFreq)
        {
            cbbFixFreq.Items.Clear();
            for (int i = 0; i < 50; ++i)
            {
                cbbFixFreq.Items.Add(string.Format("{0}-{1:F1}Mhz", i + 1, 902.5 + i * 0.5));
            }
        }

        private void ShowFreqKoreaFixPoint(ComboBox cbbFixFreq)
        {
            cbbFixFreq.Items.Clear();
            for (int i = 0; i < 32; ++i)
            {
                cbbFixFreq.Items.Add(string.Format("{0}-{1:F1}Mhz", i + 1, 917.1 + i * 0.2));
            }
        }

        private void ShowFreEU_FixPoint(ComboBox cbbFixFreq)
        {
            cbbFixFreq.Items.Clear();
            for (int i = 0; i < 5; ++i)
            {
                cbbFixFreq.Items.Add(string.Format("{0}-{1:F1}Mhz", i + 1, 865.5 + i * 0.5));
            }
        }

        /// <summary>
        ///  频率及其它参数默认参数
        ///  2015-11-9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDefaultFreq_Click(object sender, EventArgs e)
        {
            cbbFrequencyBand.SelectedIndex = 0;
            //tbNewDevNo.Text = "0";
            //cbbSingOrMulti.SelectedIndex = 0;
            //cbbFrequency_Mode.SelectedIndex = 0;
            //cbbFreqMode.SelectedIndex = 0;
            //cbbFixFreqUS.SelectedIndex = 0;
            //cbbEPCDataFormat.SelectedIndex = 0;

            hoppingFrequcyUSA_checkGroup1(false);
            hoppingFrequcyUSA_checkGroup2(false);
            hoppingFrequcyUSA_checkGroup3(false);
            hoppingFrequcyUSA_checkGroup4(false);
            hoppingFrequcyUSA_checkGroup5(false);
        }

        private void clearHoppingFrequency()
        {
            hoppingFrequcyUSA_checkGroup1(false);
            hoppingFrequcyUSA_checkGroup2(false);
            hoppingFrequcyUSA_checkGroup3(false);
            hoppingFrequcyUSA_checkGroup4(false);
            hoppingFrequcyUSA_checkGroup5(false);

            hoppingFrequcyEU_checkGroup1(false);
            hoppingFrequcyEU_checkGroup2(false);
        }

        /// <summary>
        ///  频率及其它参数清除频点
        ///  2015-11-9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearFreq_Click(object sender, EventArgs e)
        {
            clearHoppingFrequency();
        }

        private void tbHoppingFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbbFrequencyBand.SelectedIndex = tbHoppingFrequency.SelectedIndex;
        }

        private void cbbFrequency_Mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboBand_SelectedIndexChanged(null, null);
        }

        /*******************************************美标 Start************************************************/
        #region 美标

        private void hoppingFrequcyUSA_checkGroup1(bool check)
        {

        }

        private void hoppingFrequcyUSA_checkGroup2(bool check)
        {
        }

        private void hoppingFrequcyUSA_checkGroup3(bool check)
        {
        }

        private void hoppingFrequcyUSA_checkGroup4(bool check)
        {
        }

        private void hoppingFrequcyUSA_checkGroup5(bool check)
        {
        }

        private void hoppingFreqCheckGroup1(bool check)
        {

        }

        private void hoppingFreqCheckGroup2(bool check)
        {

        }

        private void hoppingFreqCheckGroup3(bool check)
        {

        }

        private void hoppingFreqCheckGroup4(bool check)
        {

        }

        private void hoppingFreqCheckGroup5(bool check)
        {

        }

        private void chkFreqUSAll1_CheckedChanged(object sender, EventArgs e)
        {
            //hoppingFreqCheckGroup1(chkFreqUSAll1.Checked);
        }

        private void chkFreqUSAll2_CheckedChanged(object sender, EventArgs e)
        {
            //hoppingFreqCheckGroup2(chkFreqUSAll2.Checked);
        }

        private void chkFreqUSAll3_CheckedChanged(object sender, EventArgs e)
        {
            //hoppingFreqCheckGroup3(chkFreqUSAll3.Checked);
        }

        private void chkFreqUSAll4_CheckedChanged(object sender, EventArgs e)
        {
            //hoppingFreqCheckGroup4(chkFreqUSAll4.Checked);
        }

        private void chkFreqUSAll5_CheckedChanged(object sender, EventArgs e)
        {
            //hoppingFreqCheckGroup5(chkFreqUSAll5.Checked);
        }

        private void cbFp1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbFp11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbFp21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbFp31_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbFp41_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion 美标
        /*******************************************美标 Start************************************************/

        /*******************************************欧标 Start************************************************/
        #region EU band

        private void hoppingFrequcyEU_checkGroup2(bool check)
        {

        }

        private void hoppingFrequcyEU_checkGroup1(bool check)
        {

        }

        private void hoppingFreqCheckEUGroup1(bool check)
        {

        }

        private void hoppingFreqCheckEUGroup2(bool check)
        {

        }

        private void chkFp7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkFreqEUAll1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkFreqEUAll2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkFp1_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion EU band
        /*******************************************欧标 End************************************************/

        /*******************************************韩标 Start************************************************/
        #region Korean band
        private void hoppingFreqCheckKoreanGroup(bool check)
        {

        }

        private void chkFreqKoreanAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkFreqKorean1_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion Korean band
        /*******************************************韩标 End************************************************/
        #endregion 频率选取

        #region 初始化控件
        private void InitalContrl()
        {
            try
            {
                BasicOperations();//基本操作
                TagOperations();//标签读写
                CommunicationParameterSetting();//通信参数设置
                ReaderParameterSetting();//读写器参数设置
                OtherOperation();

                initalChannelState();//天线通道初始化
                initalAntennaParams();//天线初始化
            }
            catch (Exception e)
            {
                lblMessageHit.Text = "InitalContrl" + e.Message;
            }
        }

        /// <summary>
        /// 基本操作
        /// </summary>
        private void BasicOperations()
        {
            try
            {
                tbTCPClientPort.Text = "20058";
                tbTCPServerPort.Text = "20058";
                cbbLangSwitch.Items.Clear();
                cbbLangSwitch.Items.Add("简体中文");
                cbbLangSwitch.Items.Add("English");
                cbbLangSwitch.SelectedIndex = 0; // 默认中文
                rbAsc.Checked = true;
                BasicOperation.InitalConnectType(cbbSerialPort, cbbBaudRate);
                BasicOperation.InitTableInfoColumns(rm, listView);
                tabControl.SelectedIndex = 0;
                cbbLangSwitch_SelectedIndexChanged(null, null);

            }
            catch (Exception e)
            {
                lblMessageHit.Text = "BasicOperations " + e.Message;
            }
        }

        /// <summary>
        ///  标签读写
        /// </summary>
        private void TagOperations()
        {
            try
            {
                cbbDataArea.SelectedIndex = 0;
                //cbbRWBank.SelectedIndex = 1;
                TagOperation.InitAccessTagControl(cbbRWBank, cbbLockBank);
            }
            catch (Exception e)
            {
                lblMessageHit.Text = "TagOperations " + e.Message;
            }
        }

        /// <summary>
        /// 通信参数设置
        /// </summary>
        private void CommunicationParameterSetting()
        {
            // 初始化各个页面控件
            InitCommParamControl();
        }

        /// <summary>
        /// 读写器参数设置
        /// </summary>
        private void ReaderParameterSetting()
        {
            try
            {
                //cbbFrequency_Mode.SelectedIndex = 0;
                // 韦根取位值
                cbbWiegandProtocol.Items.Clear();
                cbbWiegandProtocol.Items.Add("Wiegand26");
                cbbWiegandProtocol.Items.Add("Wiegand34");
                cbbWiegandProtocol.Items.Add("Wiegand32");
                cbbWiegandProtocol.Items.Add("Wiegand66");
                for (int i = 0; i < 62; i++)
                {
                    cbbWigginsTakePlaceValue.Items.Add(i);
                }
                tbWorkMode.SelectedIndex = 1;
                tbCommMode.SelectedIndex = 0;
                cbbFrequencyBand.SelectedIndex = 0;
                //cbbReadSpeed.SelectedIndex = 1;
                cbbDataArea.SelectedIndex = 1;
            }
            catch (Exception e)
            {
                lblMessageHit.Text = "ReaderParameterSetting " + e.Message;
            }
        }

        /// <summary>
        /// 其它操作
        /// </summary>
        private void OtherOperation()
        {
            try
            {
                cbbBeepControl.SelectedIndex = 0;
                //cbbUsbFormat.SelectedIndex = 4;
                //cbbSingOrMulti.SelectedIndex = 0;
            }
            catch (Exception e)
            {
                lblMessageHit.Text = "OtherOperation " + e.Message;
            }
        }
        #endregion 初始化控件

        private void cbSaveFile_CheckedChanged(object sender, EventArgs e)
        {
            lock (hashMap)
            {
                export(Tag_data);
            }
        }

        private void btnInital_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            int result = 0;
            if (0 < result)
            {
                lblMessageHit.Text = rm.GetString("strMsgSucceedInit");
            }
            else
            {
                lblMessageHit.Text = rm.GetString("strMsgFailedInit");
            }
        }

        private void labTagCount_Click(object sender, EventArgs e)
        {

        }

        private void btnReadAdjaDiscri_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            byte time = 0;
            int result = TM200.QueryAdjacentDiscriminantTime(hashMap[key], ref time);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMsgQueryFailed");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMsgQuerySucceed");
            tbNeighJudge.Text = time.ToString();
        }

        private void btnUpdateAdjaDiscri_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            string neigthJudge = tbNeighJudge.Text;
            if (!DataConvert.IsDecimalismCharacter(neigthJudge))
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }
            byte time = (byte)int.Parse(neigthJudge);
            int result = TM200.UpdateAdjacentDiscriminantTime(hashMap[key], time);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMsgUpdateSucceed");
        }

        private void initalChannelState()
        {
            tabPageUnify.Text = rm.GetString("tabPageUnify");
            tabPageAlone.Text = rm.GetString("tabPageAlone");
            lblFrequencyArea.Text = rm.GetString("lblFrequencyArea");
            gbAdjacentDiscriminant.Text = rm.GetString("gbAdjacentDiscriminant");
            btnAdjacentDiscriminantRead2.Text = rm.GetString("btnAdjacentDiscriminantQuery");
            btnAdjacentDiscriminantSet2.Text = rm.GetString("btnAdjacentDiscriminantUpdate");
            rbChannel1.Enabled = false;
            rbChannel2.Enabled = false;
            rbChannel4.Enabled = false;
            rbChannel4.Enabled = false;
            rbChannel8.Enabled = false;
            rbChannel16.Enabled = false;
            rbChannel32.Enabled = false;
        }

        private void queryChannelCount(byte count)
        {
            grpAntSet.Enabled = true;
            rbChannel1.Enabled = false;
            rbChannel2.Enabled = false;
            rbChannel4.Enabled = false;
            rbChannel8.Enabled = false;
            rbChannel32.Enabled = false;
            rbChannel16.Enabled = false;
            switch (count)
            {
                case 1:
                    rbChannel1.Checked = true;
                    rbChannel1.Enabled = true;
                    break;
                case 2:
                    rbChannel2.Checked = true;
                    rbChannel2.Enabled = true;
                    break;
                case 4:
                    rbChannel4.Checked = true;
                    rbChannel4.Enabled = true;
                    break;
                case 8:
                    rbChannel8.Checked = true;
                    rbChannel8.Enabled = true;
                    break;
                case 16:
                    rbChannel16.Checked = true;
                    rbChannel16.Enabled = true;
                    break;
                case 32:
                    rbChannel32.Checked = true;
                    rbChannel32.Enabled = true;
                    break;
            }
        }

        private CheckBox[] antennaIds = new CheckBox[64];
        private ComboBox[] antennaPowers = new ComboBox[64];
        private ComboBox[] antennaWorkTimes = new ComboBox[64];
        private ComboBox[] antennaGapTimes = new ComboBox[64];

        private void initalAntennaParams()
        {
            for (int i = 0; i < 64; i++)
            {
                antennaIds[i] = new CheckBox();
                antennaPowers[i] = new ComboBox();
                antennaWorkTimes[i] = new ComboBox();
                antennaGapTimes[i] = new ComboBox();
                AntennaUtil.InitalPower(antennaPowers[i]);
                AntennaUtil.InitalWorkTime(antennaWorkTimes[i]);
                AntennaUtil.InitalGapTime(antennaGapTimes[i]);
            }
            InitalAntennaData();
        }

        private void InitalAntennaData()
        {
            InitalAntennaIds();
            InitalAntennaPowers();
            InitalAntennaWorkTimes();
            InitalAntennaGapTimes();
        }

        #region 查询天线参数
        private void queryAntennaIds()
        {
            antennaIds[0].Checked = chkAnt1.Checked;
            antennaIds[1].Checked = chkAnt2.Checked;
            antennaIds[2].Checked = chkAnt3.Checked;
            antennaIds[3].Checked = chkAnt4.Checked;
            antennaIds[4].Checked = chkAnt5.Checked;
            antennaIds[5].Checked = chkAnt6.Checked;
            antennaIds[6].Checked = chkAnt7.Checked;
            antennaIds[7].Checked = chkAnt8.Checked;
            antennaIds[8].Checked = chkAnt9.Checked;
            antennaIds[9].Checked = chkAnt10.Checked;
            antennaIds[10].Checked = chkAnt11.Checked;
            antennaIds[11].Checked = chkAnt12.Checked;
            antennaIds[12].Checked = chkAnt13.Checked;
            antennaIds[13].Checked = chkAnt14.Checked;
            antennaIds[14].Checked = chkAnt15.Checked;
            antennaIds[15].Checked = chkAnt16.Checked;
        }

        private void queryAntennaPowers()
        {
            antennaPowers[0].SelectedValue = cbbPower1.SelectedValue;
            antennaPowers[1].SelectedValue = cbbPower2.SelectedValue;
            antennaPowers[2].SelectedValue = cbbPower3.SelectedValue;
            antennaPowers[3].SelectedValue = cbbPower4.SelectedValue;
            antennaPowers[4].SelectedValue = cbbPower5.SelectedValue;
            antennaPowers[5].SelectedValue = cbbPower6.SelectedValue;
            antennaPowers[6].SelectedValue = cbbPower7.SelectedValue;
            antennaPowers[7].SelectedValue = cbbPower8.SelectedValue;
            antennaPowers[8].SelectedValue = cbbPower9.SelectedValue;
            antennaPowers[9].SelectedValue = cbbPower10.SelectedValue;
            antennaPowers[10].SelectedValue = cbbPower11.SelectedValue;
            antennaPowers[11].SelectedValue = cbbPower12.SelectedValue;
            antennaPowers[12].SelectedValue = cbbPower13.SelectedValue;
            antennaPowers[13].SelectedValue = cbbPower14.SelectedValue;
            antennaPowers[14].SelectedValue = cbbPower15.SelectedValue;
            antennaPowers[15].SelectedValue = cbbPower16.SelectedValue;
        }

        private void queryAntennaWorkTimes()
        {
            antennaWorkTimes[0].SelectedValue = cbbWorkTime1.SelectedValue;
            antennaWorkTimes[1].SelectedValue = cbbWorkTime2.SelectedValue;
            antennaWorkTimes[2].SelectedValue = cbbWorkTime3.SelectedValue;
            antennaWorkTimes[3].SelectedValue = cbbWorkTime4.SelectedValue;
            antennaWorkTimes[4].SelectedValue = cbbWorkTime5.SelectedValue;
            antennaWorkTimes[5].SelectedValue = cbbWorkTime6.SelectedValue;
            antennaWorkTimes[6].SelectedValue = cbbWorkTime7.SelectedValue;
            antennaWorkTimes[7].SelectedValue = cbbWorkTime8.SelectedValue;
            antennaWorkTimes[8].SelectedValue = cbbWorkTime9.SelectedValue;
            antennaWorkTimes[9].SelectedValue = cbbWorkTime10.SelectedValue;
            antennaWorkTimes[10].SelectedValue = cbbWorkTime11.SelectedValue;
            antennaWorkTimes[11].SelectedValue = cbbWorkTime12.SelectedValue;
            antennaWorkTimes[12].SelectedValue = cbbWorkTime13.SelectedValue;
            antennaWorkTimes[13].SelectedValue = cbbWorkTime14.SelectedValue;
            antennaWorkTimes[14].SelectedValue = cbbWorkTime15.SelectedValue;
            antennaWorkTimes[15].SelectedValue = cbbWorkTime16.SelectedValue;
        }

        private void queryAntennaGapTimes()
        {
            antennaGapTimes[0].SelectedValue = cbbGapTime1.SelectedValue;
            antennaGapTimes[1].SelectedValue = cbbGapTime2.SelectedValue;
            antennaGapTimes[2].SelectedValue = cbbGapTime3.SelectedValue;
            antennaGapTimes[3].SelectedValue = cbbGapTime4.SelectedValue;
            antennaGapTimes[4].SelectedValue = cbbGapTime5.SelectedValue;
            antennaGapTimes[5].SelectedValue = cbbGapTime6.SelectedValue;
            antennaGapTimes[6].SelectedValue = cbbGapTime7.SelectedValue;
            antennaGapTimes[7].SelectedValue = cbbGapTime8.SelectedValue;
            antennaGapTimes[8].SelectedValue = cbbGapTime9.SelectedValue;
            antennaGapTimes[9].SelectedValue = cbbGapTime10.SelectedValue;
            antennaGapTimes[10].SelectedValue = cbbGapTime11.SelectedValue;
            antennaGapTimes[11].SelectedValue = cbbGapTime12.SelectedValue;
            antennaGapTimes[12].SelectedValue = cbbGapTime13.SelectedValue;
            antennaGapTimes[13].SelectedValue = cbbGapTime14.SelectedValue;
            antennaGapTimes[14].SelectedValue = cbbGapTime15.SelectedValue;
            antennaGapTimes[15].SelectedValue = cbbGapTime16.SelectedValue;
        }

        private void QueryAntennaData()
        {
            queryAntennaIds();
            queryAntennaWorkTimes();
            queryAntennaGapTimes();
        }

        #endregion


        #region 初始化天线参数
        private void InitalAntennaWorkTimes()
        {
              cbbWorkTime1.Items.AddRange(antennaWorkTimes[0].Items.Cast<Object>().ToArray());
              cbbWorkTime2.Items.AddRange(antennaWorkTimes[1].Items.Cast<Object>().ToArray());
              cbbWorkTime3.Items.AddRange(antennaWorkTimes[2].Items.Cast<Object>().ToArray());
              cbbWorkTime4.Items.AddRange(antennaWorkTimes[3].Items.Cast<Object>().ToArray());
              cbbWorkTime5.Items.AddRange(antennaWorkTimes[4].Items.Cast<Object>().ToArray());
              cbbWorkTime6.Items.AddRange(antennaWorkTimes[5].Items.Cast<Object>().ToArray());
              cbbWorkTime7.Items.AddRange(antennaWorkTimes[6].Items.Cast<Object>().ToArray());
              cbbWorkTime8.Items.AddRange(antennaWorkTimes[7].Items.Cast<Object>().ToArray());
              cbbWorkTime9.Items.AddRange(antennaWorkTimes[8].Items.Cast<Object>().ToArray());
              cbbWorkTime10.Items.AddRange(antennaWorkTimes[9].Items.Cast<Object>().ToArray());
              cbbWorkTime11.Items.AddRange(antennaWorkTimes[10].Items.Cast<Object>().ToArray());
              cbbWorkTime12.Items.AddRange(antennaWorkTimes[11].Items.Cast<Object>().ToArray());
              cbbWorkTime13.Items.AddRange(antennaWorkTimes[12].Items.Cast<Object>().ToArray());
              cbbWorkTime14.Items.AddRange(antennaWorkTimes[13].Items.Cast<Object>().ToArray());
              cbbWorkTime15.Items.AddRange(antennaWorkTimes[14].Items.Cast<Object>().ToArray());
              cbbWorkTime16.Items.AddRange(antennaWorkTimes[15].Items.Cast<Object>().ToArray());
        }

        private void InitalAntennaIds()
        {
            chkAnt1.Checked = antennaIds[0].Checked;
            chkAnt2.Checked = antennaIds[1].Checked;
            chkAnt3.Checked = antennaIds[2].Checked;
            chkAnt4.Checked = antennaIds[3].Checked;
            chkAnt5.Checked = antennaIds[4].Checked;
            chkAnt6.Checked = antennaIds[5].Checked;
            chkAnt7.Checked = antennaIds[6].Checked;
            chkAnt8.Checked = antennaIds[7].Checked;
            chkAnt9.Checked = antennaIds[8].Checked;
            chkAnt10.Checked = antennaIds[9].Checked;
            chkAnt11.Checked = antennaIds[10].Checked;
            chkAnt12.Checked = antennaIds[11].Checked;
            chkAnt13.Checked = antennaIds[12].Checked;
            chkAnt14.Checked = antennaIds[13].Checked;
            chkAnt15.Checked = antennaIds[14].Checked;
            chkAnt16.Checked = antennaIds[15].Checked;
        }

        private void InitalAntennaGapTimes()
        {
              cbbGapTime1.Items.AddRange(antennaGapTimes[0].Items.Cast<Object>().ToArray());
              cbbGapTime2.Items.AddRange(antennaGapTimes[1].Items.Cast<Object>().ToArray());
              cbbGapTime3.Items.AddRange(antennaGapTimes[2].Items.Cast<Object>().ToArray());
              cbbGapTime4.Items.AddRange(antennaGapTimes[3].Items.Cast<Object>().ToArray());
              cbbGapTime5.Items.AddRange(antennaGapTimes[4].Items.Cast<Object>().ToArray());
              cbbGapTime6.Items.AddRange(antennaGapTimes[5].Items.Cast<Object>().ToArray());
              cbbGapTime7.Items.AddRange(antennaGapTimes[6].Items.Cast<Object>().ToArray());
              cbbGapTime8.Items.AddRange(antennaGapTimes[7].Items.Cast<Object>().ToArray());
              cbbGapTime9.Items.AddRange(antennaGapTimes[8].Items.Cast<Object>().ToArray());
              cbbGapTime10.Items.AddRange(antennaGapTimes[9].Items.Cast<Object>().ToArray());
              cbbGapTime11.Items.AddRange(antennaGapTimes[10].Items.Cast<Object>().ToArray());
              cbbGapTime12.Items.AddRange(antennaGapTimes[11].Items.Cast<Object>().ToArray());
              cbbGapTime13.Items.AddRange(antennaGapTimes[12].Items.Cast<Object>().ToArray());
              cbbGapTime14.Items.AddRange(antennaGapTimes[13].Items.Cast<Object>().ToArray());
              cbbGapTime15.Items.AddRange(antennaGapTimes[14].Items.Cast<Object>().ToArray());
              cbbGapTime16.Items.AddRange(antennaGapTimes[15].Items.Cast<Object>().ToArray());
        }

        private void InitalAntennaPowers()
        {
              cbbPower1.Items.AddRange(antennaPowers[0].Items.Cast<Object>().ToArray());
              cbbPower2.Items.AddRange(antennaPowers[0].Items.Cast<Object>().ToArray());
              cbbPower3.Items.AddRange(antennaPowers[0].Items.Cast<Object>().ToArray());
              cbbPower4.Items.AddRange(antennaPowers[0].Items.Cast<Object>().ToArray());
              cbbPower5.Items.AddRange(antennaPowers[4].Items.Cast<Object>().ToArray());
              cbbPower6.Items.AddRange(antennaPowers[5].Items.Cast<Object>().ToArray());
              cbbPower7.Items.AddRange(antennaPowers[6].Items.Cast<Object>().ToArray());
              cbbPower8.Items.AddRange(antennaPowers[7].Items.Cast<Object>().ToArray());
              cbbPower9.Items.AddRange(antennaPowers[8].Items.Cast<Object>().ToArray());
              cbbPower10.Items.AddRange(antennaPowers[9].Items.Cast<Object>().ToArray());
              cbbPower11.Items.AddRange(antennaPowers[10].Items.Cast<Object>().ToArray());
              cbbPower12.Items.AddRange(antennaPowers[11].Items.Cast<Object>().ToArray());
              cbbPower13.Items.AddRange(antennaPowers[12].Items.Cast<Object>().ToArray());
              cbbPower14.Items.AddRange(antennaPowers[13].Items.Cast<Object>().ToArray());
              cbbPower15.Items.AddRange(antennaPowers[14].Items.Cast<Object>().ToArray());
              cbbPower16.Items.AddRange(antennaPowers[15].Items.Cast<Object>().ToArray());
        }

        #endregion

        private void btnReadChannelCount_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            byte channelCount = 0;
            int result = TM200.QueryChannelCount(hashMap[key], ref channelCount);
            if (0 < result)
            {
                queryChannelCount(channelCount);
                lblMessageHit.Text = rm.GetString("strMsgQuerySucceed");
            }
            else
            {
                lblMessageHit.Text = rm.GetString("strMsgQueryFailed");
            }
        }

        private void btnDefaultLinkModel_Click(object sender, EventArgs e)
        {
            cbbLinkModel.SelectedIndex = 1;
        }

        private void btnQueryLinkModel_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            byte mode = 0;
            int result = TM200.QueryLinkParameters(hashMap[key], ref mode);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMsgQueryFailed");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMsgQuerySucceed");
            cbbLinkModel.SelectedIndex = mode;
        }

        private void btnUpdateLinkModel_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            int mode = cbbLinkModel.SelectedIndex;
            if (mode == -1)
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
            }
            int result = TM200.UpdateLinkParameters(hashMap[key], (byte)mode);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMsgUpdateSucceed");
            cbbLinkModel.SelectedIndex = mode;
        }

        private void btnQueryOutputformat_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            int mode = cbbLinkModel.SelectedIndex;
            if (mode == -1)
            {
                lblMessageHit.Text = rm.GetString("strMsgQueryFailed");
            }
            DataOutputFormatStruct dataFormat = new DataOutputFormatStruct();
            int result = TM200.QueryDataOutputFormat(hashMap[key], ref dataFormat);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMsgQueryFailed");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMsgQuerySucceed");
            chkAntennaId.Checked = dataFormat.antenna == 1 ? true : false;
            chkRssi.Checked = dataFormat.RSSI == 1 ? true : false;
            chkAlarmState.Checked = dataFormat.alarm == 1 ? true : false;
            chkPcValue.Checked = dataFormat.pc_value == 1 ? true : false;
            chkTagArea.Checked = dataFormat.tag_area == 1 ? true : false;
            chkTagTime.Checked = dataFormat.tag_id_time == 1 ? true : false;
            chkUseCustomeData.Checked = dataFormat.user_data == 1 ? true : false;
            chkPrivateData.Checked = dataFormat.private_data == 1 ? true : false;
        }

        private void btnUpdateOutputFormat_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            int mode = cbbLinkModel.SelectedIndex;
            if (mode == -1)
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
            }
            DataOutputFormatStruct dataFormat = new DataOutputFormatStruct();
            dataFormat.antenna = (byte)(chkAntennaId.Checked ? 1 : 0);
            dataFormat.RSSI = (byte)(chkRssi.Checked ? 1 : 0);
            dataFormat.alarm = (byte)(chkAlarmState.Checked ? 1 : 0);
            dataFormat.pc_value = (byte)(chkPcValue.Checked ? 1 : 0);
            dataFormat.tag_area = (byte)(chkTagArea.Checked ? 1 : 0);
            dataFormat.tag_id_time = (byte)(chkTagTime.Checked ? 1 : 0);
            dataFormat.user_data = (byte)(chkUseCustomeData.Checked ? 1 : 0);
            dataFormat.private_data = (byte)(chkPrivateData.Checked ? 1 : 0);
            int result = TM200.UpdateDataOutputFormat(hashMap[key], dataFormat);

            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMsgUpdateSucceed");
            cbbLinkModel.SelectedIndex = mode;
        }

        private void btnQueryRelay_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            int mode = cbbLinkModel.SelectedIndex;
            if (mode == -1)
            {
                lblMessageHit.Text = rm.GetString("strMsgQueryFailed");
            }
            DevGPIO GPIO = new DevGPIO();
            int result = TM200.QueryGPIO(hashMap[key], ref GPIO);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMsgQueryFailed");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMsgQuerySucceed");
            tbRelayMode.SelectedIndex = GPIO.initiative_or_passivity;
            if (tbRelayMode.SelectedIndex == 0)
            {
                rbOpen1.Checked = GPIO.passivity_input1 == 1 ? true : false;
                rbOpen2.Checked = GPIO.passivity_input2 == 1 ? true : false;

                rbClose1.Checked = !rbOpen1.Checked;
                rbClose2.Checked = !rbOpen2.Checked;
            }
            else
            {
                cbbRelayTime.SelectedItem = GPIO.auto_delay_time.ToString();

            }
        }

        private void btnFactorySetting_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            int result = TM200.FactoryReset(hashMap[key]);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMsgUpdateSucceed");
        }

        private void btnDeviceReset_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            int result = TM200.ResetDev(hashMap[key]);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMsgUpdateSucceed");
        }

        private void btnGetLamp_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            byte state = 0;
            int result = TM200.QueryLEDLamp(hashMap[key], ref state);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMsgQueryFailed");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMsgQuerySucceed");
            cbbLamp.SelectedIndex = state;
        }

        private void btnSetLamp_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            if (cbbLamp.SelectedIndex == -1)
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }
            byte state = (byte)(cbbLamp.SelectedIndex);
            int result = TM200.UpdateLEDLamp(hashMap[key], state);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMsgUpdateSucceed");
            cbbLamp.SelectedIndex = state;
        }

        private void btnQueryWifi_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            byte[] ssid = new byte[100];
            byte ssid_len = 0;
            byte[] pwd = new byte[100];
            byte pwd_len = 0;
            int result = TM200.QueryWifiConfig(hashMap[key], ssid, ref ssid_len, pwd, ref pwd_len);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMsgQueryFailed");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMsgQuerySucceed");
            if (ssid_len > 0)
            {
                string _ssid = System.Text.Encoding.ASCII.GetString(ssid);
                cbbSSID.Text = _ssid;
            }
            string _pwd = System.Text.Encoding.ASCII.GetString(pwd);
            tbWifiConnectPwd.Text = _pwd;
        }

        private void chkWifiPwd_CheckedChanged(object sender, EventArgs e)
        {
            bool result = false;
            if (chkWifiPwd.Checked)
            {
                result = false;
                tbWifiConnectPwd.PasswordChar = '\0';
            }
            else
            {
                result = true;
                tbWifiConnectPwd.PasswordChar = '*';
            }
            tbWifiConnectPwd.UseSystemPasswordChar = result;
        }

        private void btnSetWifi_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            byte[] ssid = System.Text.Encoding.Default.GetBytes(cbbSSID.Text);
            byte ssid_len = (byte)ssid.Length;
            byte[] pwd = System.Text.Encoding.Default.GetBytes(tbWifiConnectPwd.Text);
            byte pwd_len = (byte)pwd.Length;
            int result = TM200.UpdateWifiConfig(hashMap[key], ssid, ssid_len, pwd, pwd_len);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMsgUpdateSucceed");
        }

        private void btnLocalHost_Click(object sender, EventArgs e)
        {
            QueryLocalHost(cbbTCPDestIP);
        }

        private void btnQueryWifiTCPConfig_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            byte[] destIP = new byte[100];
            byte destIP_len = 0;
            ushort destPort = 0;
            int result = TM200.QueryWifiTCPClient(hashMap[key], destIP, ref destIP_len, ref destPort);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMsgQueryFailed");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMsgQuerySucceed");
            string IP = System.Text.Encoding.ASCII.GetString(destIP);
            cbbTCPDestIP.Text = IP;
            tbTCPDestPort.Text = destPort.ToString();
        }

        private void btnQueryGSPConfig_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            byte channel = 0;
            byte time = 0;
            int result = TM200.QueryGPSInfoOutput(hashMap[key], ref channel, ref time);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMsgQueryFailed");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMsgQuerySucceed");
            cbbCommunicationType.SelectedIndex = channel;
            cbbGPSReportingInterval.Text = time.ToString();
        }

        private void btnSetWifiTCPConfig_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            if (!DataConvert.IsValidIP(cbbTCPDestIP.Text))
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }
            if (!DataConvert.IsDecNumber(tbTCPDestPort.Text))
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }
            string[] host = cbbTCPDestIP.Text.Split('.');
            byte[] destIP = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                destIP[i] = Byte.Parse(host[i]);
            }
            byte destIP_len = (byte)destIP.Length;

            ushort destPort = ushort.Parse(tbTCPDestPort.Text);
            int result = TM200.UpdateWifiTCPClient(hashMap[key], destIP, destIP_len, destPort);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMsgUpdateSucceed");
        }

        private void btnUpdateGPSConfig_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            if (!DataConvert.IsDecNumber(cbbGPSReportingInterval.Text))
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }
            byte channel = (byte)cbbCommunicationType.SelectedIndex;
            byte time = Byte.Parse(cbbGPSReportingInterval.Text);
            int result = TM200.UpdateGPSInfoOutput(hashMap[key], channel, time);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMsgUpdateSucceed");
        }

        private void btnQueryTCPConfig_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            byte[] IP_or_domain_name = new byte[100];
            byte data_len = 0;
            byte[] port = new byte[100];
            byte port_len = 0;
            byte network = 0;
            byte wifi = 0;
            byte _4G = 0;
            int result = TM200.QueryTCPDestination(hashMap[key], IP_or_domain_name, ref data_len, port, ref port_len, ref network, ref wifi, ref _4G);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMsgQueryFailed");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMsgQuerySucceed");
            tbURL.Text = System.Text.Encoding.ASCII.GetString(IP_or_domain_name);
            tbTCPPort.Text = System.Text.Encoding.ASCII.GetString(port);
            chk4G.Checked = _4G == 1;
            chkWifi.Checked = wifi == 1;
            chkNetwork.Checked = network == 1;
        }

        private void btnUpdateTCPConfig_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            if (!DataConvert.IsDecNumber(tbTCPPort.Text))
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }
            byte[] IP_or_domain_name = System.Text.Encoding.Default.GetBytes(tbURL.Text);
            byte data_len = (byte)IP_or_domain_name.Length;
            ushort port = ushort.Parse(tbTCPPort.Text);
            byte network = (byte)(chkNetwork.Checked ? 1 : 0);
            byte wifi = (byte)(chkWifi.Checked ? 1 : 0);
            byte _4G = (byte)(chk4G.Checked ? 1 : 0);
            int result = TM200.UpdateTCPDestination(hashMap[key], IP_or_domain_name, data_len, port, network, wifi, _4G);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMsgUpdateSucceed");
        }

        private void btnQueryHttpConfig_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            byte[] url = new byte[100];
            byte url_len = 0;
            byte[] port = new byte[100];
            byte port_len = 0;
            byte common_type = 0;
            byte send_cycle = 0;
            int result = TM200.QueryHttpParamConfig(hashMap[key], url, ref url_len, port, ref port_len, ref common_type, ref send_cycle);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMsgQueryFailed");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMsgQuerySucceed");
            cbbHttpCommunicationType.SelectedIndex = common_type;
            tbHttpURL.Text = System.Text.Encoding.ASCII.GetString(url);
            tbHttpPort.Text = System.Text.Encoding.ASCII.GetString(port);
            cbbHttpReportingInterval.Text = send_cycle.ToString();
        }

        private void btnUpdateHttpConfig_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            if (!DataConvert.IsDecNumber(tbHttpPort.Text))
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }
            if (!DataConvert.IsDecNumber(cbbHttpReportingInterval.Text))
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }
            byte[] url = System.Text.Encoding.Default.GetBytes(tbHttpURL.Text);
            byte url_len = (byte)url.Length;
            ushort port = ushort.Parse(tbHttpPort.Text);
            byte common_type = (byte)cbbHttpCommunicationType.SelectedIndex;
            byte send_cycle = Byte.Parse(cbbHttpReportingInterval.Text);
            int result = TM200.UpdateHttpParamConfig(hashMap[key], url, url_len, port, common_type, send_cycle);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMsgUpdateSucceed");
        }

        private void btnQueryNetworkParams_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            NetworkConfigStruct config = new NetworkConfigStruct();
            int result = TM200.QueryNetworkConfig(hashMap[key], ref config);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMsgQueryFailed");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMsgQuerySucceed");
            cbbNetworkPattern.SelectedIndex = config.connect_mode;
            cbbIPModel.SelectedIndex = config.IP_mode;
            tbIPAddress.Text = DataConvert.IPAddPoint(config.device_IP);
            tbSubnetMask.Text = DataConvert.IPAddPoint(config.subnet_mask);
            cbbNetworkDestIP.Text = DataConvert.IPAddPoint(config.dest_IP);
            tbDevicePort.Text = config.device_port.ToString();
            tbGateway.Text = DataConvert.IPAddPoint(config.gate_way);
            tbNetworkDestPort.Text = config.dest_port.ToString();
            tbDns.Text = DataConvert.IPAddPoint(config.dns);
            tbMacAddress.Text = DataConvert.BytesToHexStr(config.mac_address, config.mac_address_len);
        }

        private void btnUpdateNetworkParams_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            if (!DataConvert.IsValidIP(tbIPAddress.Text))
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }
            if (!DataConvert.IsValidIP(tbSubnetMask.Text))
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }
            if (!DataConvert.IsValidIP(cbbNetworkDestIP.Text))
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }
            if (!DataConvert.IsValidIP(tbGateway.Text))
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }

            if (!DataConvert.IsHexCharacter(tbMacAddress.Text) || tbMacAddress.Text.Replace(" ", "").Length != 12)
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }

            NetworkConfigStruct config = new NetworkConfigStruct();
            config.connect_mode = (byte)cbbNetworkPattern.SelectedIndex;
            config.IP_mode = (byte)cbbIPModel.SelectedIndex;
            config.device_IP = new byte[10];
            config.subnet_mask = new byte[10];
            config.dest_IP = new byte[10];
            config.gate_way = new byte[10];
            config.dns = new byte[10];
            config.mac_address = new byte[10];

            Array.Copy(DataConvert.IPCutPoint(tbIPAddress.Text), config.device_IP, 4);
            Array.Copy(DataConvert.IPCutPoint(tbSubnetMask.Text), config.subnet_mask, 4);
            Array.Copy(DataConvert.IPCutPoint(cbbNetworkDestIP.Text), config.dest_IP, 4);
            Array.Copy(DataConvert.IPCutPoint(tbGateway.Text), config.gate_way, 4);
            Array.Copy(DataConvert.IPCutPoint(tbDns.Text), config.dns, 4);
            Array.Copy(DataConvert.HexStrToBytes(tbMacAddress.Text), config.mac_address, 6);

            config.device_port = ushort.Parse(tbDevicePort.Text);
            config.dest_port = ushort.Parse(tbNetworkDestPort.Text);

            int result = TM200.UpdateNetworkConfig(hashMap[key], config);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMsgUpdateSucceed");
        }

        private void lblNetworkDestIP_Click(object sender, EventArgs e)
        {
            QueryLocalHost(cbbNetworkDestIP);
        }

        private void tbSetReaderParam_Click(object sender, EventArgs e)
        {

        }

        private void btnQueryUserCustomData_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            byte data_length = 0;
            byte[] data = new byte[20];
            int result = TM200.QueryUserCustomData(hashMap[key], ref data_length, data);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMsgQueryFailed");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMsgQuerySucceed");
            //cbbUserCustomData.SelectedIndex = data_length;
            tbUserCustomData.Text = System.Text.Encoding.Default.GetString(data); ;
        }

        private void btnUpdateUserCustomData_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            //byte data_length = (byte)cbbUserCustomData.SelectedIndex;
            byte[] data = System.Text.Encoding.Default.GetBytes(tbUserCustomData.Text);
            if (8 != data.Length)
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }
            int result = TM200.UpdateUserCustomData(hashMap[key], 8, data);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMsgUpdateSucceed");
        }

        private void btnDefaultNetworkParams_Click(object sender, EventArgs e)
        {
            cbbNetworkPattern.SelectedIndex = 0;
            cbbIPModel.SelectedIndex = 0;
            tbIPAddress.Text = "192.168.1.200";
            tbSubnetMask.Text = "255.255.255.0";
            tbDevicePort.Text = "20058";
            tbGateway.Text = "192.168.1.1";
            QueryLocalHost(cbbNetworkDestIP);
            tbNetworkDestPort.Text = "20058";
            tbDns.Text = "192.168.1.1";
            tbMacAddress.Text = "112233445566";
        }

        private void tpSerialPort_Click(object sender, EventArgs e)
        {

        }

        private void btnTagTypeRead_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            byte tagType = 0;
            int result = TM200.QueryTagType(hashMap[key], ref tagType);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("msgQueryTagTypeFailure");
                return;
            }
            cbbTagType.SelectedIndex = tagType;
            lblMessageHit.Text = rm.GetString("msgQueryTagTypeSuccess");
        }

        private void btnTagTypeSet_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            byte tagType = (byte)cbbTagType.SelectedIndex;
            if (cbbTagType.SelectedIndex == -1)
            {
                lblMessageHit.Text = rm.GetString("msgPleaseChooseTagType");
                return;
            }
            int result = TM200.UpdateTagType(hashMap[key], tagType);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("msgUpdateTagTypeFailure");
                return;
            }
            lblMessageHit.Text = rm.GetString("msgUpdateTagTypeSuccess"); ;
        }

        private void btnSpecifiedAddressAndLengthRead_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            byte area = (byte)cbbTagArea.SelectedIndex;
            if (cbbTagArea.SelectedIndex == -1)
            {
                return;
            }
            byte enable = 0;
            byte address = 0;
            byte length = 0;
            chbEnable.Checked = false;
            int result = TM200.QueryTagAreaSpecifiedAddressAndLength(hashMap[key], area, ref enable, ref address, ref length);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("msgQueryFailure");
                return;
            }
            cbbStartAddress2.Text = "";
            cbbLength2.Text = "";
            chbEnable.Checked = enable == 0 ? false : true;
            cbbStartAddress2.Text = address.ToString();
            cbbLength2.Text = length.ToString();
            lblMessageHit.Text = rm.GetString("msgQuerySuccess");
        }

        private void btnSpecifiedAddressAndLengthSet_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            byte area = (byte)cbbTagArea.SelectedIndex;
            if (cbbTagArea.SelectedIndex == -1)
            {
                return;
            }
            byte enable = (byte)(chbEnable.Checked ? 1 : 0);
            byte address = byte.Parse(cbbStartAddress2.Text);
            byte length = byte.Parse(cbbLength2.Text); ;
            int result = TM200.UpdateTagAreaSpecifiedAddressAndLength(hashMap[key], area, enable, address, length);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("msgUpdateFailure");
                return;
            }
            lblMessageHit.Text = rm.GetString("msgUpdateSuccess");
        }

        private void cbbTagArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTagArea.SelectedIndex == 0) // 保留区
            {
                addStart = 0;
                addEnd = 3;
            }
            else if (cbbTagArea.SelectedIndex == 1) // EPC区
            {
                addStart = 2;
                addEnd = 7;
            }
            else if (cbbTagArea.SelectedIndex == 2) // TID
            {
                addStart = 0;
                addEnd = 5;
            }
            else if (cbbTagArea.SelectedIndex == 3) // User
            {
                addStart = 0;
                addEnd = 31;
                //addEnd = 128;
            }
            cbbStartAddress2.Items.Clear();
            for (int i = addStart; i <= addEnd; ++i)
            {
                cbbStartAddress2.Items.Add(i.ToString());
            }
            cbbStartAddress2.SelectedIndex = 0;
        }

        private void cbbStartAddress2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nItem = cbbStartAddress2.SelectedIndex; // 取出起始地址索引值
            int maxLength = addEnd - addStart - nItem + 1;
            cbbLength2.Items.Clear();
            for (int i = 1; i <= maxLength; ++i)
            {
                cbbLength2.Items.Add(i.ToString());
            }
            cbbLength2.SelectedIndex = maxLength - 1;
        }

        private void btnQueryAuthorize_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            byte[] pwd = new byte[2];
            byte pwd_len = 0;
            int result = TM200.QueryAuthorizePwd(hashMap[key],pwd,ref pwd_len);
            if (result == 0)
            {
                lblMessageHit.Text = rm.GetString("strGetAuthorizationCodeFailure");
                return;
            }
            tbOldAuthorizePwd.Text = pwd[0].ToString("X2") + pwd[1].ToString("X2");
            lblMessageHit.Text = rm.GetString("strGetAuthorizationCodeSuccessed");
        }

        private void btnTagAuthorize_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            int result = TM200.TagAuthorize(hashMap[key]);
            if (result == 0)
            {
                lblMessageHit.Text = rm.GetString("strMsgSucceedAuth");
            }
            else
            {
                lblMessageHit.Text = rm.GetString("strMsgFailedAuth");
            }
        }

        private void btnModifyAuthorize_Click(object sender, EventArgs e)
        {
            try
            {
                string key = selecteDevice();
                if (null == key)
                {
                    return;
                }
                UIntPtr device = hashMap[key];
                string strAuthPwd = tbOldAuthorizePwd.Text.Replace(" ", "");
                string strNewAuthPwd = tbNewAuthorizePwd.Text.Replace(" ", "");
                if (tbOldAuthorizePwd.Text.Length != 4 || tbNewAuthorizePwd.Text.Length != 4)
                {
                    lblMessageHit.Text = rm.GetString("strMsgPwdMustFour");
                    return;
                }
                if (!Regex.IsMatch(tbOldAuthorizePwd.Text, "^[0-9A-Fa-f]+$") || !Regex.IsMatch(tbNewAuthorizePwd.Text, "^[0-9A-Fa-f]+$"))
                {
                    lblMessageHit.Text = rm.GetString("strMsgInvalidChar");
                    return;
                }

                byte[] oldPwd = new Byte[2];
                byte[] newPwd = new Byte[2];
                for (int i = 0; i < 2; i++)
                {
                    oldPwd[i] = Convert.ToByte(strAuthPwd.Substring(i * 2, 2), 16);
                    newPwd[i] = Convert.ToByte(strNewAuthPwd.Substring(i * 2, 2), 16);
                }
                int  result = TM200.UpdateAuthorizePwd(device,oldPwd, newPwd, (byte)2);
                if (0 < result)
                {
                    lblMessageHit.Text = rm.GetString("strMsgSuccedSetAuthPwd");
                }
                else
                {
                    lblMessageHit.Text = rm.GetString("strMsgFailedSetAuthPwd");
                }
            }
            catch (Exception e1)
            {
                lblMessageHit.Text = e1.Message;
            }
        }

        private void btnAdjacentDiscriminantSet2_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            string unifyTime = textBox5.Text;
            string[] antenndIds = new string[4];
            antenndIds[0] = tbAnt1.Text;
            antenndIds[1] = tbAnt2.Text;
            antenndIds[2] = tbAnt3.Text;
            antenndIds[3] = tbAnt4.Text;
            if (!DataConvert.IsDecimalismCharacter(unifyTime))
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }
            for (int i = 0; i < antenndIds.Length;i++ )
            {
                if (!DataConvert.IsDecimalismCharacter(antenndIds[i]))
                {
                    lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                    return;
                }
            }
            byte time = byte.Parse(unifyTime);
            AloneOrUnifyStruct aloneOrUnify = new AloneOrUnifyStruct();
            aloneOrUnify.mode = (byte)tabControlAdjacentDiscriminant.SelectedIndex;
            aloneOrUnify.time = time;
            aloneOrUnify.antennaId = new ushort[4];
            for (int i = 0; i < antenndIds.Length; i++) {
                aloneOrUnify.antennaId[i] = ushort.Parse(antenndIds[i]);
            }
            int result = TM200.UpdateAdjacentDiscriminantTimeAloneOrUnify(hashMap[key], aloneOrUnify);
            if (result < 1)
            {
                lblMessageHit.Text = rm.GetString("strMsgUpdateFailure");
                return;
            }
            lblMessageHit.Text = rm.GetString("strMsgUpdateSucceed");
        }

        private void btnAdjacentDiscriminantRead2_Click(object sender, EventArgs e)
        {
            string key = selecteDevice();
            if (null == key)
            {
                return;
            }
            AloneOrUnifyStruct aloneOrUnify = new AloneOrUnifyStruct();
            int result = TM200.QueryAdjacentDiscriminantTimeAloneOrUnify(hashMap[key],ref aloneOrUnify);
            if (result == 0)
            {
                lblMessageHit.Text = rm.GetString("msgQueryFailure");
            }
            else
            {
                tabControlAdjacentDiscriminant.SelectedIndex = aloneOrUnify.mode;
                textBox5.Text = aloneOrUnify.time.ToString();
                tbAnt1.Text = aloneOrUnify.antennaId[0].ToString();
                tbAnt2.Text = aloneOrUnify.antennaId[1].ToString();
                tbAnt3.Text = aloneOrUnify.antennaId[2].ToString();
                tbAnt4.Text = aloneOrUnify.antennaId[3].ToString();
                lblMessageHit.Text = rm.GetString("msgQuerySuccess");
            }
        }

       
    }

    // 解决插入数据表格闪烁的问题
    public class ListViewNF : System.Windows.Forms.ListView
    {
        public ListViewNF()
        {
            // 开启双缓冲
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

            // Enable the OnNotifyMessage event so we get a chance to filter out 
            // Windows messages before they get to the form's WndProc
            this.SetStyle(ControlStyles.EnableNotifyMessage, true);
        }

        protected override void OnNotifyMessage(Message m)
        {
            //Filter out the WM_ERASEBKGND message
            if (m.Msg != 0x14)
            {
                base.OnNotifyMessage(m);
            }
        }
    }
}

