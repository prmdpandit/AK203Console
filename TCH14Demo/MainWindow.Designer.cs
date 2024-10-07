using TM200Demo;
namespace TM200Demo
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Serial Port");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("TCP Client");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("TCP Server");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("On Line", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.cbbLangSwitch = new System.Windows.Forms.ComboBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TagTID = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.gbVersionInfo = new System.Windows.Forms.GroupBox();
            this.btnBrushVersion = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnReadVersion = new System.Windows.Forms.Button();
            this.gbConnectType = new System.Windows.Forms.GroupBox();
            this.tbConnect = new System.Windows.Forms.TabControl();
            this.tpSerialPort = new System.Windows.Forms.TabPage();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.cbbBaudRate = new System.Windows.Forms.ComboBox();
            this.lblSerialPort = new System.Windows.Forms.Label();
            this.cbbSerialPort = new System.Windows.Forms.ComboBox();
            this.btnUpdateSerialPort = new System.Windows.Forms.Button();
            this.btnSerialPortDisconnect = new System.Windows.Forms.Button();
            this.btnSerialPortConnect = new System.Windows.Forms.Button();
            this.tpTCPClient = new System.Windows.Forms.TabPage();
            this.btnUpdateTCPClient = new System.Windows.Forms.Button();
            this.tbTCPClientPort = new System.Windows.Forms.TextBox();
            this.lblTCPClientPort = new System.Windows.Forms.Label();
            this.lblTCPClientIP = new System.Windows.Forms.Label();
            this.cbbTCPClientIP = new System.Windows.Forms.ComboBox();
            this.btnTCPClientDisconnect = new System.Windows.Forms.Button();
            this.btnTCPClientConnect = new System.Windows.Forms.Button();
            this.tpTCPServer = new System.Windows.Forms.TabPage();
            this.tbTCPServerPort = new System.Windows.Forms.TextBox();
            this.lblTCPServerPort = new System.Windows.Forms.Label();
            this.lblTCPServerIP = new System.Windows.Forms.Label();
            this.btnUpdateTCPServer = new System.Windows.Forms.Button();
            this.cbbTCPServerIP = new System.Windows.Forms.ComboBox();
            this.btnStopMonitor = new System.Windows.Forms.Button();
            this.btnStartMonitor = new System.Windows.Forms.Button();
            this.tvConnectList = new System.Windows.Forms.TreeView();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMessageHit = new System.Windows.Forms.Label();
            this.lblInfoShow = new System.Windows.Forms.Label();
            this.timerConnRead = new System.Windows.Forms.Timer(this.components);
            this.tpOtherOpreation = new System.Windows.Forms.TabPage();
            this.gbTCPConfig = new System.Windows.Forms.GroupBox();
            this.chk4G = new System.Windows.Forms.CheckBox();
            this.chkWifi = new System.Windows.Forms.CheckBox();
            this.chkNetwork = new System.Windows.Forms.CheckBox();
            this.btnQueryTCPConfig = new System.Windows.Forms.Button();
            this.lblURL = new System.Windows.Forms.Label();
            this.btnUpdateTCPConfig = new System.Windows.Forms.Button();
            this.lblTCPPort = new System.Windows.Forms.Label();
            this.lblTCPCommunicationType = new System.Windows.Forms.Label();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.tbTCPPort = new System.Windows.Forms.TextBox();
            this.gbHttpConfig = new System.Windows.Forms.GroupBox();
            this.btnQueryHttpConfig = new System.Windows.Forms.Button();
            this.lblHttpUrl = new System.Windows.Forms.Label();
            this.btnUpdateHttpConfig = new System.Windows.Forms.Button();
            this.lblHttpPort = new System.Windows.Forms.Label();
            this.lblHttpReportingInterval = new System.Windows.Forms.Label();
            this.lblHttpCommunicationType = new System.Windows.Forms.Label();
            this.cbbHttpCommunicationType = new System.Windows.Forms.ComboBox();
            this.cbbHttpReportingInterval = new System.Windows.Forms.ComboBox();
            this.tbHttpURL = new System.Windows.Forms.TextBox();
            this.tbHttpPort = new System.Windows.Forms.TextBox();
            this.gbGSPConfig = new System.Windows.Forms.GroupBox();
            this.btnQueryGSPConfig = new System.Windows.Forms.Button();
            this.btnUpdateGPSConfig = new System.Windows.Forms.Button();
            this.cbbCommunicationType = new System.Windows.Forms.ComboBox();
            this.cbbGPSReportingInterval = new System.Windows.Forms.ComboBox();
            this.lblGPSReportingInterval = new System.Windows.Forms.Label();
            this.lblCommunicationType = new System.Windows.Forms.Label();
            this.gbNetworkParams = new System.Windows.Forms.GroupBox();
            this.btnDefaultNetworkParams = new System.Windows.Forms.Button();
            this.btnQueryNetworkParams = new System.Windows.Forms.Button();
            this.btnUpdateNetworkParams = new System.Windows.Forms.Button();
            this.cbbIPModel = new System.Windows.Forms.ComboBox();
            this.lblNetworkParamsClientConfig = new System.Windows.Forms.Label();
            this.lblGateway = new System.Windows.Forms.Label();
            this.lblDevicePort = new System.Windows.Forms.Label();
            this.lblMacAddress = new System.Windows.Forms.Label();
            this.lblSubnetMask = new System.Windows.Forms.Label();
            this.lblDns = new System.Windows.Forms.Label();
            this.lblDeviceIPAddress = new System.Windows.Forms.Label();
            this.lblNetworkDestPort = new System.Windows.Forms.Label();
            this.lblIPModel = new System.Windows.Forms.Label();
            this.cbbNetworkDestIP = new System.Windows.Forms.ComboBox();
            this.cbbNetworkPattern = new System.Windows.Forms.ComboBox();
            this.lblNetworkDestIP = new System.Windows.Forms.Label();
            this.lblNetworkPattern = new System.Windows.Forms.Label();
            this.tbGateway = new System.Windows.Forms.TextBox();
            this.tbDevicePort = new System.Windows.Forms.TextBox();
            this.tbMacAddress = new System.Windows.Forms.TextBox();
            this.tbNetworkDestPort = new System.Windows.Forms.TextBox();
            this.tbDns = new System.Windows.Forms.TextBox();
            this.tbSubnetMask = new System.Windows.Forms.TextBox();
            this.tbIPAddress = new System.Windows.Forms.TextBox();
            this.gbWifiConfig = new System.Windows.Forms.GroupBox();
            this.tbWifiTCPConfig = new System.Windows.Forms.GroupBox();
            this.btnQueryWifiTCPConfig = new System.Windows.Forms.Button();
            this.btnUpdateWifiTCPConfig = new System.Windows.Forms.Button();
            this.btnLocalHost = new System.Windows.Forms.Button();
            this.tbTCPDestPort = new System.Windows.Forms.TextBox();
            this.cbbTCPDestIP = new System.Windows.Forms.ComboBox();
            this.lblDestPort = new System.Windows.Forms.Label();
            this.lblDestIP = new System.Windows.Forms.Label();
            this.gbWifiConnectConfig = new System.Windows.Forms.GroupBox();
            this.btnQueryWifi = new System.Windows.Forms.Button();
            this.btnUpdateWifi = new System.Windows.Forms.Button();
            this.tbWifiConnectPwd = new System.Windows.Forms.TextBox();
            this.cbbSSID = new System.Windows.Forms.ComboBox();
            this.chkWifiPwd = new System.Windows.Forms.CheckBox();
            this.lblSSID = new System.Windows.Forms.Label();
            this.tbSetReaderParam = new System.Windows.Forms.TabPage();
            this.gbUserCustomData = new System.Windows.Forms.GroupBox();
            this.lblUserCustomData = new System.Windows.Forms.Label();
            this.btnQueryUserCustomData = new System.Windows.Forms.Button();
            this.tbUserCustomData = new System.Windows.Forms.TextBox();
            this.btnUpdateUserCustomData = new System.Windows.Forms.Button();
            this.btnDeviceReset = new System.Windows.Forms.Button();
            this.btnFactorySetting = new System.Windows.Forms.Button();
            this.gbLEDLamp = new System.Windows.Forms.GroupBox();
            this.btnSetLamp = new System.Windows.Forms.Button();
            this.btnReadBeep = new System.Windows.Forms.Button();
            this.lblLedLamp = new System.Windows.Forms.Label();
            this.lblReadVoice = new System.Windows.Forms.Label();
            this.btnSetBeep = new System.Windows.Forms.Button();
            this.btnGetLamp = new System.Windows.Forms.Button();
            this.cbbLamp = new System.Windows.Forms.ComboBox();
            this.cbbBeepControl = new System.Windows.Forms.ComboBox();
            this.gbDevNo = new System.Windows.Forms.GroupBox();
            this.btnSetDeviceId = new System.Windows.Forms.Button();
            this.btnReadDeviceId = new System.Windows.Forms.Button();
            this.tbNewDevNo = new System.Windows.Forms.TextBox();
            this.gbLinkModel = new System.Windows.Forms.GroupBox();
            this.btnUpdateLinkModel = new System.Windows.Forms.Button();
            this.btnDefaultLinkModel = new System.Windows.Forms.Button();
            this.btnQueryLinkModel = new System.Windows.Forms.Button();
            this.cbbLinkModel = new System.Windows.Forms.ComboBox();
            this.gbFreq = new System.Windows.Forms.GroupBox();
            this.tbChannelSpacing = new System.Windows.Forms.TextBox();
            this.lblChannelSpacingUnit = new System.Windows.Forms.Label();
            this.lblStartFrequUnit = new System.Windows.Forms.Label();
            this.cbbEndFrequ = new System.Windows.Forms.ComboBox();
            this.lblEndFrequ = new System.Windows.Forms.Label();
            this.cbbStartFrequ = new System.Windows.Forms.ComboBox();
            this.lblChannelSpacing = new System.Windows.Forms.Label();
            this.lblStartFrequ = new System.Windows.Forms.Label();
            this.lblFrequencyArea = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDefaultFreq = new System.Windows.Forms.Button();
            this.btnReadFreq = new System.Windows.Forms.Button();
            this.cbbFrequencyBand = new System.Windows.Forms.ComboBox();
            this.labSetParam = new System.Windows.Forms.Label();
            this.btnSetFreq = new System.Windows.Forms.Button();
            this.gbDataOutputFormat = new System.Windows.Forms.GroupBox();
            this.btnQueryOutputformat = new System.Windows.Forms.Button();
            this.btnUpdateOutputFormat = new System.Windows.Forms.Button();
            this.chkUseCustomeData = new System.Windows.Forms.CheckBox();
            this.chkTagArea = new System.Windows.Forms.CheckBox();
            this.chkTagTime = new System.Windows.Forms.CheckBox();
            this.chkPcValue = new System.Windows.Forms.CheckBox();
            this.chkPrivateData = new System.Windows.Forms.CheckBox();
            this.chkRssi = new System.Windows.Forms.CheckBox();
            this.chkAlarmState = new System.Windows.Forms.CheckBox();
            this.chkAntennaId = new System.Windows.Forms.CheckBox();
            this.gbCommModeParam = new System.Windows.Forms.GroupBox();
            this.tbCommMode = new System.Windows.Forms.TabControl();
            this.tpRS232 = new System.Windows.Forms.TabPage();
            this.cbbBaud_Rate = new System.Windows.Forms.ComboBox();
            this.lbl_rate = new System.Windows.Forms.Label();
            this.tpRS485 = new System.Windows.Forms.TabPage();
            this.cbbRS485BaudRate = new System.Windows.Forms.ComboBox();
            this.lblRS485BaudRate = new System.Windows.Forms.Label();
            this.tpWiegand = new System.Windows.Forms.TabPage();
            this.labPulseWidthUnit = new System.Windows.Forms.Label();
            this.labPulseWidth = new System.Windows.Forms.Label();
            this.labPulseCycleUnit = new System.Windows.Forms.Label();
            this.lblWigginsTakePlaceValue = new System.Windows.Forms.Label();
            this.tbPulseWidth = new System.Windows.Forms.TextBox();
            this.cbbWigginsTakePlaceValue = new System.Windows.Forms.ComboBox();
            this.labWiegandProtocol = new System.Windows.Forms.Label();
            this.tbPulseCycle = new System.Windows.Forms.TextBox();
            this.labPulseCycle = new System.Windows.Forms.Label();
            this.cbbWiegandProtocol = new System.Windows.Forms.ComboBox();
            this.tpRJ45 = new System.Windows.Forms.TabPage();
            this.tpWifi = new System.Windows.Forms.TabPage();
            this.tp3G_4G = new System.Windows.Forms.TabPage();
            this.btnDefaultCommMode = new System.Windows.Forms.Button();
            this.btnReadCommMode = new System.Windows.Forms.Button();
            this.btnSetCommMode = new System.Windows.Forms.Button();
            this.GopRelayControl = new System.Windows.Forms.GroupBox();
            this.tbRelayMode = new System.Windows.Forms.TabControl();
            this.tpPassivity = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbOpen2 = new System.Windows.Forms.RadioButton();
            this.rbClose2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbClose1 = new System.Windows.Forms.RadioButton();
            this.rbOpen1 = new System.Windows.Forms.RadioButton();
            this.tpInitiative = new System.Windows.Forms.TabPage();
            this.lblCloseTime = new System.Windows.Forms.Label();
            this.cbbRelayTime = new System.Windows.Forms.ComboBox();
            this.btnSetRelay = new System.Windows.Forms.Button();
            this.btnQueryRelay = new System.Windows.Forms.Button();
            this.gbWorkMode = new System.Windows.Forms.GroupBox();
            this.btnUpdateAdjaDiscri = new System.Windows.Forms.Button();
            this.btnReadAdjaDiscri = new System.Windows.Forms.Button();
            this.tbWorkMode = new System.Windows.Forms.TabControl();
            this.tpMaster = new System.Windows.Forms.TabPage();
            this.tpTiming = new System.Windows.Forms.TabPage();
            this.tpTrigger = new System.Windows.Forms.TabPage();
            this.labDelayUnit = new System.Windows.Forms.Label();
            this.labTrigParam = new System.Windows.Forms.Label();
            this.tbDelay = new System.Windows.Forms.TextBox();
            this.chkAjaDisc = new System.Windows.Forms.Label();
            this.btnDefaultWorkMode = new System.Windows.Forms.Button();
            this.btnReadWorkMode = new System.Windows.Forms.Button();
            this.btnSetWorkMode = new System.Windows.Forms.Button();
            this.tbNeighJudge = new System.Windows.Forms.TextBox();
            this.tpSetCommParam = new System.Windows.Forms.TabPage();
            this.gbSPParams = new System.Windows.Forms.GroupBox();
            this.labDataBits = new System.Windows.Forms.Label();
            this.labCheckBits = new System.Windows.Forms.Label();
            this.labBaudRate = new System.Windows.Forms.Label();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxCheckBits = new System.Windows.Forms.ComboBox();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.gbNetParams = new System.Windows.Forms.GroupBox();
            this.cbbDestIP = new System.Windows.Forms.ComboBox();
            this.labPromotion = new System.Windows.Forms.Label();
            this.labDestPort = new System.Windows.Forms.Label();
            this.labDestIP = new System.Windows.Forms.Label();
            this.labGateway = new System.Windows.Forms.Label();
            this.labPort = new System.Windows.Forms.Label();
            this.labMask = new System.Windows.Forms.Label();
            this.labIPAdd = new System.Windows.Forms.Label();
            this.labIPMode = new System.Windows.Forms.Label();
            this.labNetMode = new System.Windows.Forms.Label();
            this.textBoxDestPort = new System.Windows.Forms.TextBox();
            this.tbDestIP = new System.Windows.Forms.TextBox();
            this.textBoxGateway = new System.Windows.Forms.TextBox();
            this.textBoxPortNo = new System.Windows.Forms.TextBox();
            this.textBoxNetMask = new System.Windows.Forms.TextBox();
            this.textBoxIPAdd = new System.Windows.Forms.TextBox();
            this.comboBoxIPMode = new System.Windows.Forms.ComboBox();
            this.comboBoxNetMode = new System.Windows.Forms.ComboBox();
            this.btnSetParams = new System.Windows.Forms.Button();
            this.btnDefaultParams = new System.Windows.Forms.Button();
            this.btnModifyDev = new System.Windows.Forms.Button();
            this.btnSearchDev = new System.Windows.Forms.Button();
            this.lvZl = new System.Windows.Forms.ListView();
            this.columnHeaderNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIPAdd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMAC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpTagAccess = new System.Windows.Forms.TabPage();
            this.gbTagAuth = new System.Windows.Forms.GroupBox();
            this.btnQueryAuthorize = new System.Windows.Forms.Button();
            this.btnModifyAuthorize = new System.Windows.Forms.Button();
            this.btnTagAuthorize = new System.Windows.Forms.Button();
            this.tbNewAuthorizePwd = new System.Windows.Forms.TextBox();
            this.tbOldAuthorizePwd = new System.Windows.Forms.TextBox();
            this.labNewAuthPwd = new System.Windows.Forms.Label();
            this.labAuthPwd = new System.Windows.Forms.Label();
            this.gbTagType = new System.Windows.Forms.GroupBox();
            this.lblTagType = new System.Windows.Forms.Label();
            this.btnTagTypeSet = new System.Windows.Forms.Button();
            this.btnTagTypeRead = new System.Windows.Forms.Button();
            this.cbbTagType = new System.Windows.Forms.ComboBox();
            this.gbSpecifiedAddressAndLength = new System.Windows.Forms.GroupBox();
            this.chbEnable = new System.Windows.Forms.CheckBox();
            this.btnSpecifiedAddressAndLengthSet = new System.Windows.Forms.Button();
            this.btnSpecifiedAddressAndLengthRead = new System.Windows.Forms.Button();
            this.lblTagArea = new System.Windows.Forms.Label();
            this.cbbTagArea = new System.Windows.Forms.ComboBox();
            this.labLength2 = new System.Windows.Forms.Label();
            this.labStartAdd2 = new System.Windows.Forms.Label();
            this.cbbStartAddress2 = new System.Windows.Forms.ComboBox();
            this.cbbLength2 = new System.Windows.Forms.ComboBox();
            this.gbKillTag = new System.Windows.Forms.GroupBox();
            this.tbKillKillPwd = new System.Windows.Forms.TextBox();
            this.btnKillTag = new System.Windows.Forms.Button();
            this.labDestroyPwd = new System.Windows.Forms.Label();
            this.gbTagLockAndUnlock = new System.Windows.Forms.GroupBox();
            this.lblOperationType = new System.Windows.Forms.Label();
            this.cbbLockType = new System.Windows.Forms.ComboBox();
            this.labLockBank = new System.Windows.Forms.Label();
            this.cbbLockBank = new System.Windows.Forms.ComboBox();
            this.btnLockTag = new System.Windows.Forms.Button();
            this.labLockAccessPwd = new System.Windows.Forms.Label();
            this.tbLockAccessPwd = new System.Windows.Forms.TextBox();
            this.gbFastWrite = new System.Windows.Forms.GroupBox();
            this.btnReadFastTag = new System.Windows.Forms.Button();
            this.chkZD = new System.Windows.Forms.CheckBox();
            this.labFWPromo = new System.Windows.Forms.Label();
            this.btnClearFWData = new System.Windows.Forms.Button();
            this.btnFastWrite = new System.Windows.Forms.Button();
            this.labFWData = new System.Windows.Forms.Label();
            this.tbFWData = new System.Windows.Forms.TextBox();
            this.gbRWData = new System.Windows.Forms.GroupBox();
            this.lblMatchData = new System.Windows.Forms.Label();
            this.tbMatchData = new System.Windows.Forms.TextBox();
            this.lblMatchMode = new System.Windows.Forms.Label();
            this.cbbMatchMode = new System.Windows.Forms.ComboBox();
            this.chkMatchParameter = new System.Windows.Forms.CheckBox();
            this.btnInitTag = new System.Windows.Forms.Button();
            this.btn_stoptimer = new System.Windows.Forms.Button();
            this.btn_connRead = new System.Windows.Forms.Button();
            this.labData = new System.Windows.Forms.Label();
            this.labLength = new System.Windows.Forms.Label();
            this.labStartAdd = new System.Windows.Forms.Label();
            this.labOprBank = new System.Windows.Forms.Label();
            this.btnWriteData = new System.Windows.Forms.Button();
            this.btnClearData = new System.Windows.Forms.Button();
            this.btnReadData = new System.Windows.Forms.Button();
            this.tbRWData = new System.Windows.Forms.TextBox();
            this.cbbLength = new System.Windows.Forms.ComboBox();
            this.cbbStartAdd = new System.Windows.Forms.ComboBox();
            this.cbbRWBank = new System.Windows.Forms.ComboBox();
            this.gbBeepControl = new System.Windows.Forms.GroupBox();
            this.btnReadDataArea = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSetDataArea = new System.Windows.Forms.Button();
            this.cbbDataArea = new System.Windows.Forms.ComboBox();
            this.tpAntennaParams = new System.Windows.Forms.TabPage();
            this.gbAdjacentDiscriminant = new System.Windows.Forms.GroupBox();
            this.tabControlAdjacentDiscriminant = new System.Windows.Forms.TabControl();
            this.tabPageUnify = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPageAlone = new System.Windows.Forms.TabPage();
            this.tbAnt4 = new System.Windows.Forms.TextBox();
            this.lblAnt4 = new System.Windows.Forms.Label();
            this.tbAnt1 = new System.Windows.Forms.TextBox();
            this.lblAnt3 = new System.Windows.Forms.Label();
            this.tbAnt2 = new System.Windows.Forms.TextBox();
            this.lblAnt2 = new System.Windows.Forms.Label();
            this.tbAnt3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAnt1 = new System.Windows.Forms.Label();
            this.btnAdjacentDiscriminantRead2 = new System.Windows.Forms.Button();
            this.btnAdjacentDiscriminantSet2 = new System.Windows.Forms.Button();
            this.grpAntSet = new System.Windows.Forms.GroupBox();
            this.rbChannel32 = new System.Windows.Forms.RadioButton();
            this.rbChannel16 = new System.Windows.Forms.RadioButton();
            this.cbbGapTime16 = new System.Windows.Forms.ComboBox();
            this.rbChannel1 = new System.Windows.Forms.RadioButton();
            this.cbbGapTime8 = new System.Windows.Forms.ComboBox();
            this.rbChannel8 = new System.Windows.Forms.RadioButton();
            this.lblAntennaGapTime = new System.Windows.Forms.Label();
            this.cbbGapTime15 = new System.Windows.Forms.ComboBox();
            this.lblAntennaWorkTime = new System.Windows.Forms.Label();
            this.rbChannel2 = new System.Windows.Forms.RadioButton();
            this.cbbGapTime7 = new System.Windows.Forms.ComboBox();
            this.cbbGapTime14 = new System.Windows.Forms.ComboBox();
            this.lblAntennaPower = new System.Windows.Forms.Label();
            this.rbChannel4 = new System.Windows.Forms.RadioButton();
            this.lblAntennaId = new System.Windows.Forms.Label();
            this.cbbGapTime6 = new System.Windows.Forms.ComboBox();
            this.cbbGapTime13 = new System.Windows.Forms.ComboBox();
            this.cbbGapTime5 = new System.Windows.Forms.ComboBox();
            this.cbbGapTime12 = new System.Windows.Forms.ComboBox();
            this.cbbGapTime4 = new System.Windows.Forms.ComboBox();
            this.cbbGapTime11 = new System.Windows.Forms.ComboBox();
            this.cbbGapTime3 = new System.Windows.Forms.ComboBox();
            this.cbbGapTime10 = new System.Windows.Forms.ComboBox();
            this.cbbGapTime2 = new System.Windows.Forms.ComboBox();
            this.cbbGapTime9 = new System.Windows.Forms.ComboBox();
            this.cbbGapTime1 = new System.Windows.Forms.ComboBox();
            this.cbbWorkTime16 = new System.Windows.Forms.ComboBox();
            this.cbbWorkTime8 = new System.Windows.Forms.ComboBox();
            this.cbbWorkTime15 = new System.Windows.Forms.ComboBox();
            this.cbbWorkTime7 = new System.Windows.Forms.ComboBox();
            this.cbbWorkTime14 = new System.Windows.Forms.ComboBox();
            this.cbbWorkTime6 = new System.Windows.Forms.ComboBox();
            this.cbbWorkTime13 = new System.Windows.Forms.ComboBox();
            this.cbbWorkTime5 = new System.Windows.Forms.ComboBox();
            this.cbbWorkTime12 = new System.Windows.Forms.ComboBox();
            this.cbbWorkTime4 = new System.Windows.Forms.ComboBox();
            this.cbbWorkTime11 = new System.Windows.Forms.ComboBox();
            this.cbbWorkTime3 = new System.Windows.Forms.ComboBox();
            this.cbbWorkTime10 = new System.Windows.Forms.ComboBox();
            this.cbbWorkTime2 = new System.Windows.Forms.ComboBox();
            this.cbbWorkTime9 = new System.Windows.Forms.ComboBox();
            this.cbbWorkTime1 = new System.Windows.Forms.ComboBox();
            this.cbbPower16 = new System.Windows.Forms.ComboBox();
            this.cbbPower8 = new System.Windows.Forms.ComboBox();
            this.cbbPower15 = new System.Windows.Forms.ComboBox();
            this.cbbPower7 = new System.Windows.Forms.ComboBox();
            this.cbbPower14 = new System.Windows.Forms.ComboBox();
            this.cbbPower6 = new System.Windows.Forms.ComboBox();
            this.cbbPower13 = new System.Windows.Forms.ComboBox();
            this.cbbPower5 = new System.Windows.Forms.ComboBox();
            this.cbbPower12 = new System.Windows.Forms.ComboBox();
            this.cbbPower4 = new System.Windows.Forms.ComboBox();
            this.cbbPower11 = new System.Windows.Forms.ComboBox();
            this.cbbPower3 = new System.Windows.Forms.ComboBox();
            this.cbbPower10 = new System.Windows.Forms.ComboBox();
            this.cbbPower2 = new System.Windows.Forms.ComboBox();
            this.cbbPower9 = new System.Windows.Forms.ComboBox();
            this.cbbPower1 = new System.Windows.Forms.ComboBox();
            this.chkAnt16 = new System.Windows.Forms.CheckBox();
            this.chkAnt15 = new System.Windows.Forms.CheckBox();
            this.chkAnt14 = new System.Windows.Forms.CheckBox();
            this.chkAnt13 = new System.Windows.Forms.CheckBox();
            this.chkAnt12 = new System.Windows.Forms.CheckBox();
            this.chkAnt11 = new System.Windows.Forms.CheckBox();
            this.chkAnt10 = new System.Windows.Forms.CheckBox();
            this.chkAnt9 = new System.Windows.Forms.CheckBox();
            this.chkAnt8 = new System.Windows.Forms.CheckBox();
            this.chkAnt7 = new System.Windows.Forms.CheckBox();
            this.chkAnt6 = new System.Windows.Forms.CheckBox();
            this.chkAnt5 = new System.Windows.Forms.CheckBox();
            this.chkAnt4 = new System.Windows.Forms.CheckBox();
            this.chkAnt3 = new System.Windows.Forms.CheckBox();
            this.chkAnt2 = new System.Windows.Forms.CheckBox();
            this.chkAnt1 = new System.Windows.Forms.CheckBox();
            this.btnAntSet = new System.Windows.Forms.Button();
            this.btnReadChannelCount = new System.Windows.Forms.Button();
            this.btnAntRead = new System.Windows.Forms.Button();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtTotalQty = new System.Windows.Forms.TextBox();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.txtArmyNo = new System.Windows.Forms.TextBox();
            this.lblArmyNo = new System.Windows.Forms.Label();
            this.dateTimePickerIssueDate = new System.Windows.Forms.DateTimePicker();
            this.labelIssueDate = new System.Windows.Forms.Label();
            this.dateTimePickerChallanDate = new System.Windows.Forms.DateTimePicker();
            this.labelChallanDate = new System.Windows.Forms.Label();
            this.cmbSelectChalan = new System.Windows.Forms.ComboBox();
            this.lblSelectChalan = new System.Windows.Forms.Label();
            this.btnReadOnce = new System.Windows.Forms.Button();
            this.btnStartReadData = new System.Windows.Forms.Button();
            this.btnStopReadData = new System.Windows.Forms.Button();
            this.cbSaveFile = new System.Windows.Forms.CheckBox();
            this.btnClearListView = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblTagCount = new System.Windows.Forms.Label();
            this.labReadCount = new System.Windows.Forms.Label();
            this.labTagCount = new System.Windows.Forms.Label();
            this.rbDesc = new System.Windows.Forms.RadioButton();
            this.rbAsc = new System.Windows.Forms.RadioButton();
            this.labelVersion = new System.Windows.Forms.Label();
            this.listView = new ListViewContrl.DoubleBufferListView();
            this.list_serial_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_EPC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_antenna_no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_device_no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_Uart_IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_current_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_rssi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_alarm_status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_private_data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_temperature = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_user_custome_data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_EPC_data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_TID_data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_User_data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.cmsMenu.SuspendLayout();
            this.gbVersionInfo.SuspendLayout();
            this.gbConnectType.SuspendLayout();
            this.tbConnect.SuspendLayout();
            this.tpSerialPort.SuspendLayout();
            this.tpTCPClient.SuspendLayout();
            this.tpTCPServer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpOtherOpreation.SuspendLayout();
            this.gbTCPConfig.SuspendLayout();
            this.gbHttpConfig.SuspendLayout();
            this.gbGSPConfig.SuspendLayout();
            this.gbNetworkParams.SuspendLayout();
            this.gbWifiConfig.SuspendLayout();
            this.tbWifiTCPConfig.SuspendLayout();
            this.gbWifiConnectConfig.SuspendLayout();
            this.tbSetReaderParam.SuspendLayout();
            this.gbUserCustomData.SuspendLayout();
            this.gbLEDLamp.SuspendLayout();
            this.gbDevNo.SuspendLayout();
            this.gbLinkModel.SuspendLayout();
            this.gbFreq.SuspendLayout();
            this.gbDataOutputFormat.SuspendLayout();
            this.gbCommModeParam.SuspendLayout();
            this.tbCommMode.SuspendLayout();
            this.tpRS232.SuspendLayout();
            this.tpRS485.SuspendLayout();
            this.tpWiegand.SuspendLayout();
            this.GopRelayControl.SuspendLayout();
            this.tbRelayMode.SuspendLayout();
            this.tpPassivity.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpInitiative.SuspendLayout();
            this.gbWorkMode.SuspendLayout();
            this.tbWorkMode.SuspendLayout();
            this.tpTrigger.SuspendLayout();
            this.tpSetCommParam.SuspendLayout();
            this.gbSPParams.SuspendLayout();
            this.gbNetParams.SuspendLayout();
            this.tpTagAccess.SuspendLayout();
            this.gbTagAuth.SuspendLayout();
            this.gbTagType.SuspendLayout();
            this.gbSpecifiedAddressAndLength.SuspendLayout();
            this.gbKillTag.SuspendLayout();
            this.gbTagLockAndUnlock.SuspendLayout();
            this.gbFastWrite.SuspendLayout();
            this.gbRWData.SuspendLayout();
            this.gbBeepControl.SuspendLayout();
            this.tpAntennaParams.SuspendLayout();
            this.gbAdjacentDiscriminant.SuspendLayout();
            this.tabControlAdjacentDiscriminant.SuspendLayout();
            this.tabPageUnify.SuspendLayout();
            this.tabPageAlone.SuspendLayout();
            this.grpAntSet.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSave});
            this.cmsMenu.Name = "contextMenuStrip1";
            this.cmsMenu.Size = new System.Drawing.Size(101, 26);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(100, 22);
            this.tsmiSave.Text = "保存";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // cbbLangSwitch
            // 
            this.cbbLangSwitch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLangSwitch.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbLangSwitch.FormattingEnabled = true;
            this.cbbLangSwitch.Items.AddRange(new object[] {
            "简体中文",
            "English"});
            this.cbbLangSwitch.Location = new System.Drawing.Point(168, 12);
            this.cbbLangSwitch.Name = "cbbLangSwitch";
            this.cbbLangSwitch.Size = new System.Drawing.Size(105, 24);
            this.cbbLangSwitch.TabIndex = 1;
            this.cbbLangSwitch.SelectedIndexChanged += new System.EventHandler(this.cbbLangSwitch_SelectedIndexChanged);
            // 
            // panel15
            // 
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(4, 86);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(78, 34);
            this.panel15.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 34);
            this.label14.TabIndex = 2;
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(78, 34);
            this.panel5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 34);
            this.label4.TabIndex = 0;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(89, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(330, 34);
            this.panel6.TabIndex = 1;
            // 
            // TagTID
            // 
            this.TagTID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TagTID.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TagTID.Location = new System.Drawing.Point(0, 0);
            this.TagTID.Name = "TagTID";
            this.TagTID.Size = new System.Drawing.Size(330, 34);
            this.TagTID.TabIndex = 1;
            this.TagTID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(4, 45);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(78, 34);
            this.panel7.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 34);
            this.label7.TabIndex = 1;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(89, 45);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(330, 34);
            this.panel8.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(330, 34);
            this.label6.TabIndex = 1;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(4, 127);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(78, 271);
            this.panel9.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 271);
            this.label9.TabIndex = 1;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(89, 127);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(330, 271);
            this.panel10.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(330, 271);
            this.label10.TabIndex = 1;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel13
            // 
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(4, 405);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(78, 34);
            this.panel13.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 34);
            this.label13.TabIndex = 1;
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel14
            // 
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(89, 405);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(330, 34);
            this.panel14.TabIndex = 9;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(124, 1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 30);
            this.button6.TabIndex = 0;
            this.button6.Text = "查询";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel16
            // 
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(89, 86);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(330, 34);
            this.panel16.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(330, 34);
            this.label15.TabIndex = 2;
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbVersionInfo
            // 
            this.gbVersionInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbVersionInfo.Controls.Add(this.btnBrushVersion);
            this.gbVersionInfo.Controls.Add(this.lblVersion);
            this.gbVersionInfo.Controls.Add(this.btnReadVersion);
            this.gbVersionInfo.Location = new System.Drawing.Point(7, 711);
            this.gbVersionInfo.Name = "gbVersionInfo";
            this.gbVersionInfo.Size = new System.Drawing.Size(288, 56);
            this.gbVersionInfo.TabIndex = 41;
            this.gbVersionInfo.TabStop = false;
            this.gbVersionInfo.Text = "版本信息";
            // 
            // btnBrushVersion
            // 
            this.btnBrushVersion.Location = new System.Drawing.Point(221, 17);
            this.btnBrushVersion.Name = "btnBrushVersion";
            this.btnBrushVersion.Size = new System.Drawing.Size(60, 32);
            this.btnBrushVersion.TabIndex = 40;
            this.btnBrushVersion.Text = "刷新";
            this.btnBrushVersion.UseVisualStyleBackColor = true;
            this.btnBrushVersion.Click += new System.EventHandler(this.btnBrushVersion_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblVersion.ForeColor = System.Drawing.Color.Blue;
            this.lblVersion.Location = new System.Drawing.Point(6, 17);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(149, 32);
            this.lblVersion.TabIndex = 39;
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReadVersion
            // 
            this.btnReadVersion.Location = new System.Drawing.Point(157, 17);
            this.btnReadVersion.Name = "btnReadVersion";
            this.btnReadVersion.Size = new System.Drawing.Size(60, 32);
            this.btnReadVersion.TabIndex = 38;
            this.btnReadVersion.Text = "读取";
            this.btnReadVersion.UseVisualStyleBackColor = true;
            this.btnReadVersion.Click += new System.EventHandler(this.btnReadVersion_Click);
            // 
            // gbConnectType
            // 
            this.gbConnectType.Controls.Add(this.tbConnect);
            this.gbConnectType.Location = new System.Drawing.Point(7, 43);
            this.gbConnectType.Name = "gbConnectType";
            this.gbConnectType.Size = new System.Drawing.Size(288, 172);
            this.gbConnectType.TabIndex = 42;
            this.gbConnectType.TabStop = false;
            this.gbConnectType.Text = "连接方式";
            // 
            // tbConnect
            // 
            this.tbConnect.Controls.Add(this.tpSerialPort);
            this.tbConnect.Controls.Add(this.tpTCPClient);
            this.tbConnect.Controls.Add(this.tpTCPServer);
            this.tbConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbConnect.Location = new System.Drawing.Point(3, 16);
            this.tbConnect.Name = "tbConnect";
            this.tbConnect.SelectedIndex = 0;
            this.tbConnect.Size = new System.Drawing.Size(282, 153);
            this.tbConnect.TabIndex = 0;
            this.tbConnect.SelectedIndexChanged += new System.EventHandler(this.tbConnect_SelectedIndexChanged);
            // 
            // tpSerialPort
            // 
            this.tpSerialPort.Controls.Add(this.lblBaudRate);
            this.tpSerialPort.Controls.Add(this.cbbBaudRate);
            this.tpSerialPort.Controls.Add(this.lblSerialPort);
            this.tpSerialPort.Controls.Add(this.cbbSerialPort);
            this.tpSerialPort.Controls.Add(this.btnUpdateSerialPort);
            this.tpSerialPort.Controls.Add(this.btnSerialPortDisconnect);
            this.tpSerialPort.Controls.Add(this.btnSerialPortConnect);
            this.tpSerialPort.Location = new System.Drawing.Point(4, 22);
            this.tpSerialPort.Name = "tpSerialPort";
            this.tpSerialPort.Padding = new System.Windows.Forms.Padding(3);
            this.tpSerialPort.Size = new System.Drawing.Size(274, 127);
            this.tpSerialPort.TabIndex = 0;
            this.tpSerialPort.Text = "Serial Port";
            this.tpSerialPort.UseVisualStyleBackColor = true;
            this.tpSerialPort.Click += new System.EventHandler(this.tpSerialPort_Click);
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.Location = new System.Drawing.Point(6, 44);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(71, 26);
            this.lblBaudRate.TabIndex = 39;
            this.lblBaudRate.Text = "Baud Rate";
            this.lblBaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbBaudRate
            // 
            this.cbbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBaudRate.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbBaudRate.FormattingEnabled = true;
            this.cbbBaudRate.Location = new System.Drawing.Point(90, 44);
            this.cbbBaudRate.Name = "cbbBaudRate";
            this.cbbBaudRate.Size = new System.Drawing.Size(112, 24);
            this.cbbBaudRate.TabIndex = 40;
            // 
            // lblSerialPort
            // 
            this.lblSerialPort.Location = new System.Drawing.Point(6, 11);
            this.lblSerialPort.Name = "lblSerialPort";
            this.lblSerialPort.Size = new System.Drawing.Size(71, 26);
            this.lblSerialPort.TabIndex = 34;
            this.lblSerialPort.Text = "Serial Port";
            this.lblSerialPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbSerialPort
            // 
            this.cbbSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSerialPort.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbSerialPort.IntegralHeight = false;
            this.cbbSerialPort.Items.AddRange(new object[] {
            "192.168.100.100"});
            this.cbbSerialPort.Location = new System.Drawing.Point(90, 11);
            this.cbbSerialPort.Name = "cbbSerialPort";
            this.cbbSerialPort.Size = new System.Drawing.Size(112, 24);
            this.cbbSerialPort.TabIndex = 37;
            // 
            // btnUpdateSerialPort
            // 
            this.btnUpdateSerialPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateSerialPort.Location = new System.Drawing.Point(208, 8);
            this.btnUpdateSerialPort.Name = "btnUpdateSerialPort";
            this.btnUpdateSerialPort.Size = new System.Drawing.Size(60, 32);
            this.btnUpdateSerialPort.TabIndex = 38;
            this.btnUpdateSerialPort.Text = "刷新";
            this.btnUpdateSerialPort.UseVisualStyleBackColor = true;
            this.btnUpdateSerialPort.Click += new System.EventHandler(this.btnUpdateSerialPort_Click);
            // 
            // btnSerialPortDisconnect
            // 
            this.btnSerialPortDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerialPortDisconnect.Location = new System.Drawing.Point(168, 82);
            this.btnSerialPortDisconnect.Name = "btnSerialPortDisconnect";
            this.btnSerialPortDisconnect.Size = new System.Drawing.Size(100, 32);
            this.btnSerialPortDisconnect.TabIndex = 36;
            this.btnSerialPortDisconnect.Text = "断开";
            this.btnSerialPortDisconnect.UseVisualStyleBackColor = true;
            this.btnSerialPortDisconnect.Click += new System.EventHandler(this.btnSerialPortDisconnect_Click);
            // 
            // btnSerialPortConnect
            // 
            this.btnSerialPortConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSerialPortConnect.Location = new System.Drawing.Point(6, 82);
            this.btnSerialPortConnect.Name = "btnSerialPortConnect";
            this.btnSerialPortConnect.Size = new System.Drawing.Size(100, 32);
            this.btnSerialPortConnect.TabIndex = 35;
            this.btnSerialPortConnect.Text = "连接";
            this.btnSerialPortConnect.UseVisualStyleBackColor = true;
            this.btnSerialPortConnect.Click += new System.EventHandler(this.btnSerialPortConnect_Click);
            // 
            // tpTCPClient
            // 
            this.tpTCPClient.Controls.Add(this.btnUpdateTCPClient);
            this.tpTCPClient.Controls.Add(this.tbTCPClientPort);
            this.tpTCPClient.Controls.Add(this.lblTCPClientPort);
            this.tpTCPClient.Controls.Add(this.lblTCPClientIP);
            this.tpTCPClient.Controls.Add(this.cbbTCPClientIP);
            this.tpTCPClient.Controls.Add(this.btnTCPClientDisconnect);
            this.tpTCPClient.Controls.Add(this.btnTCPClientConnect);
            this.tpTCPClient.Location = new System.Drawing.Point(4, 22);
            this.tpTCPClient.Name = "tpTCPClient";
            this.tpTCPClient.Padding = new System.Windows.Forms.Padding(3);
            this.tpTCPClient.Size = new System.Drawing.Size(274, 127);
            this.tpTCPClient.TabIndex = 1;
            this.tpTCPClient.Text = "TCP Client";
            this.tpTCPClient.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTCPClient
            // 
            this.btnUpdateTCPClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateTCPClient.Location = new System.Drawing.Point(168, 41);
            this.btnUpdateTCPClient.Name = "btnUpdateTCPClient";
            this.btnUpdateTCPClient.Size = new System.Drawing.Size(100, 32);
            this.btnUpdateTCPClient.TabIndex = 46;
            this.btnUpdateTCPClient.Text = "刷新";
            this.btnUpdateTCPClient.UseVisualStyleBackColor = true;
            this.btnUpdateTCPClient.Click += new System.EventHandler(this.btnUpdateTCPClient_Click);
            // 
            // tbTCPClientPort
            // 
            this.tbTCPClientPort.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbTCPClientPort.Location = new System.Drawing.Point(52, 43);
            this.tbTCPClientPort.Name = "tbTCPClientPort";
            this.tbTCPClientPort.Size = new System.Drawing.Size(74, 26);
            this.tbTCPClientPort.TabIndex = 40;
            this.tbTCPClientPort.Text = "20058";
            // 
            // lblTCPClientPort
            // 
            this.lblTCPClientPort.Location = new System.Drawing.Point(6, 44);
            this.lblTCPClientPort.Name = "lblTCPClientPort";
            this.lblTCPClientPort.Size = new System.Drawing.Size(40, 26);
            this.lblTCPClientPort.TabIndex = 39;
            this.lblTCPClientPort.Text = "Port";
            this.lblTCPClientPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTCPClientIP
            // 
            this.lblTCPClientIP.Location = new System.Drawing.Point(6, 11);
            this.lblTCPClientIP.Name = "lblTCPClientIP";
            this.lblTCPClientIP.Size = new System.Drawing.Size(40, 26);
            this.lblTCPClientIP.TabIndex = 34;
            this.lblTCPClientIP.Text = "IP";
            this.lblTCPClientIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbTCPClientIP
            // 
            this.cbbTCPClientIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbTCPClientIP.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbTCPClientIP.FormattingEnabled = true;
            this.cbbTCPClientIP.Location = new System.Drawing.Point(52, 11);
            this.cbbTCPClientIP.Name = "cbbTCPClientIP";
            this.cbbTCPClientIP.Size = new System.Drawing.Size(216, 24);
            this.cbbTCPClientIP.TabIndex = 5;
            // 
            // btnTCPClientDisconnect
            // 
            this.btnTCPClientDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTCPClientDisconnect.Location = new System.Drawing.Point(168, 81);
            this.btnTCPClientDisconnect.Name = "btnTCPClientDisconnect";
            this.btnTCPClientDisconnect.Size = new System.Drawing.Size(100, 32);
            this.btnTCPClientDisconnect.TabIndex = 36;
            this.btnTCPClientDisconnect.Text = "断开";
            this.btnTCPClientDisconnect.UseVisualStyleBackColor = true;
            this.btnTCPClientDisconnect.Click += new System.EventHandler(this.btnTCPClientDisconnect_Click);
            // 
            // btnTCPClientConnect
            // 
            this.btnTCPClientConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTCPClientConnect.Location = new System.Drawing.Point(6, 81);
            this.btnTCPClientConnect.Name = "btnTCPClientConnect";
            this.btnTCPClientConnect.Size = new System.Drawing.Size(100, 32);
            this.btnTCPClientConnect.TabIndex = 35;
            this.btnTCPClientConnect.Text = "连接";
            this.btnTCPClientConnect.UseVisualStyleBackColor = true;
            this.btnTCPClientConnect.Click += new System.EventHandler(this.btnTCPClientConnect_Click);
            // 
            // tpTCPServer
            // 
            this.tpTCPServer.Controls.Add(this.tbTCPServerPort);
            this.tpTCPServer.Controls.Add(this.lblTCPServerPort);
            this.tpTCPServer.Controls.Add(this.lblTCPServerIP);
            this.tpTCPServer.Controls.Add(this.btnUpdateTCPServer);
            this.tpTCPServer.Controls.Add(this.cbbTCPServerIP);
            this.tpTCPServer.Controls.Add(this.btnStopMonitor);
            this.tpTCPServer.Controls.Add(this.btnStartMonitor);
            this.tpTCPServer.Location = new System.Drawing.Point(4, 22);
            this.tpTCPServer.Name = "tpTCPServer";
            this.tpTCPServer.Padding = new System.Windows.Forms.Padding(3);
            this.tpTCPServer.Size = new System.Drawing.Size(274, 127);
            this.tpTCPServer.TabIndex = 2;
            this.tpTCPServer.Text = "TCP Server";
            this.tpTCPServer.UseVisualStyleBackColor = true;
            // 
            // tbTCPServerPort
            // 
            this.tbTCPServerPort.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbTCPServerPort.Location = new System.Drawing.Point(52, 43);
            this.tbTCPServerPort.Name = "tbTCPServerPort";
            this.tbTCPServerPort.Size = new System.Drawing.Size(74, 26);
            this.tbTCPServerPort.TabIndex = 47;
            this.tbTCPServerPort.Text = "20058";
            // 
            // lblTCPServerPort
            // 
            this.lblTCPServerPort.Location = new System.Drawing.Point(6, 44);
            this.lblTCPServerPort.Name = "lblTCPServerPort";
            this.lblTCPServerPort.Size = new System.Drawing.Size(40, 26);
            this.lblTCPServerPort.TabIndex = 46;
            this.lblTCPServerPort.Text = "Port";
            this.lblTCPServerPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTCPServerIP
            // 
            this.lblTCPServerIP.Location = new System.Drawing.Point(6, 11);
            this.lblTCPServerIP.Name = "lblTCPServerIP";
            this.lblTCPServerIP.Size = new System.Drawing.Size(40, 26);
            this.lblTCPServerIP.TabIndex = 42;
            this.lblTCPServerIP.Text = "IP";
            this.lblTCPServerIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnUpdateTCPServer
            // 
            this.btnUpdateTCPServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateTCPServer.Location = new System.Drawing.Point(168, 41);
            this.btnUpdateTCPServer.Name = "btnUpdateTCPServer";
            this.btnUpdateTCPServer.Size = new System.Drawing.Size(100, 32);
            this.btnUpdateTCPServer.TabIndex = 45;
            this.btnUpdateTCPServer.Text = "本机 IP";
            this.btnUpdateTCPServer.UseVisualStyleBackColor = true;
            this.btnUpdateTCPServer.Click += new System.EventHandler(this.btnUpdateTCPServer_Click);
            // 
            // cbbTCPServerIP
            // 
            this.cbbTCPServerIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbTCPServerIP.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbTCPServerIP.FormattingEnabled = true;
            this.cbbTCPServerIP.Location = new System.Drawing.Point(52, 11);
            this.cbbTCPServerIP.Name = "cbbTCPServerIP";
            this.cbbTCPServerIP.Size = new System.Drawing.Size(216, 24);
            this.cbbTCPServerIP.TabIndex = 41;
            // 
            // btnStopMonitor
            // 
            this.btnStopMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopMonitor.Location = new System.Drawing.Point(168, 81);
            this.btnStopMonitor.Name = "btnStopMonitor";
            this.btnStopMonitor.Size = new System.Drawing.Size(100, 32);
            this.btnStopMonitor.TabIndex = 44;
            this.btnStopMonitor.Text = "停止监听";
            this.btnStopMonitor.UseVisualStyleBackColor = true;
            this.btnStopMonitor.Click += new System.EventHandler(this.btnStopMonitor_Click);
            // 
            // btnStartMonitor
            // 
            this.btnStartMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartMonitor.Location = new System.Drawing.Point(6, 81);
            this.btnStartMonitor.Name = "btnStartMonitor";
            this.btnStartMonitor.Size = new System.Drawing.Size(100, 32);
            this.btnStartMonitor.TabIndex = 43;
            this.btnStartMonitor.Text = "启动监听";
            this.btnStartMonitor.UseVisualStyleBackColor = true;
            this.btnStartMonitor.Click += new System.EventHandler(this.btnStartMonitor_Click);
            // 
            // tvConnectList
            // 
            this.tvConnectList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvConnectList.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tvConnectList.Location = new System.Drawing.Point(10, 222);
            this.tvConnectList.Name = "tvConnectList";
            treeNode1.Name = "tdSerialPort";
            treeNode1.Text = "Serial Port";
            treeNode2.Name = "tnTCPClient";
            treeNode2.Text = "TCP Client";
            treeNode3.Name = "tnTCPServer";
            treeNode3.Text = "TCP Server";
            treeNode4.Name = "tnOnLine";
            treeNode4.Text = "On Line";
            this.tvConnectList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.tvConnectList.Size = new System.Drawing.Size(285, 482);
            this.tvConnectList.TabIndex = 43;
            this.tvConnectList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvConnectList_AfterSelect);
            // 
            // lblLanguage
            // 
            this.lblLanguage.Location = new System.Drawing.Point(7, 11);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(155, 30);
            this.lblLanguage.TabIndex = 44;
            this.lblLanguage.Text = "Language(语言设置)";
            this.lblLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblMessageHit);
            this.groupBox1.Controls.Add(this.lblInfoShow);
            this.groupBox1.Location = new System.Drawing.Point(299, 711);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 56);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // lblMessageHit
            // 
            this.lblMessageHit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessageHit.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMessageHit.ForeColor = System.Drawing.Color.Navy;
            this.lblMessageHit.Location = new System.Drawing.Point(146, 18);
            this.lblMessageHit.Name = "lblMessageHit";
            this.lblMessageHit.Size = new System.Drawing.Size(714, 32);
            this.lblMessageHit.TabIndex = 40;
            this.lblMessageHit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfoShow
            // 
            this.lblInfoShow.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInfoShow.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblInfoShow.Location = new System.Drawing.Point(6, 17);
            this.lblInfoShow.Name = "lblInfoShow";
            this.lblInfoShow.Size = new System.Drawing.Size(134, 32);
            this.lblInfoShow.TabIndex = 39;
            this.lblInfoShow.Text = "信息提示:";
            this.lblInfoShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerConnRead
            // 
            this.timerConnRead.Tick += new System.EventHandler(this.btn_connRead_Click);
            // 
            // tpOtherOpreation
            // 
            this.tpOtherOpreation.Controls.Add(this.gbTCPConfig);
            this.tpOtherOpreation.Controls.Add(this.gbHttpConfig);
            this.tpOtherOpreation.Controls.Add(this.gbGSPConfig);
            this.tpOtherOpreation.Controls.Add(this.gbNetworkParams);
            this.tpOtherOpreation.Controls.Add(this.gbWifiConfig);
            this.tpOtherOpreation.Location = new System.Drawing.Point(4, 22);
            this.tpOtherOpreation.Name = "tpOtherOpreation";
            this.tpOtherOpreation.Padding = new System.Windows.Forms.Padding(3);
            this.tpOtherOpreation.Size = new System.Drawing.Size(864, 680);
            this.tpOtherOpreation.TabIndex = 4;
            this.tpOtherOpreation.Text = "其它操作";
            this.tpOtherOpreation.UseVisualStyleBackColor = true;
            this.tpOtherOpreation.Enter += new System.EventHandler(this.OtherOpreation_Enter_Fun);
            // 
            // gbTCPConfig
            // 
            this.gbTCPConfig.Controls.Add(this.chk4G);
            this.gbTCPConfig.Controls.Add(this.chkWifi);
            this.gbTCPConfig.Controls.Add(this.chkNetwork);
            this.gbTCPConfig.Controls.Add(this.btnQueryTCPConfig);
            this.gbTCPConfig.Controls.Add(this.lblURL);
            this.gbTCPConfig.Controls.Add(this.btnUpdateTCPConfig);
            this.gbTCPConfig.Controls.Add(this.lblTCPPort);
            this.gbTCPConfig.Controls.Add(this.lblTCPCommunicationType);
            this.gbTCPConfig.Controls.Add(this.tbURL);
            this.gbTCPConfig.Controls.Add(this.tbTCPPort);
            this.gbTCPConfig.Location = new System.Drawing.Point(364, 6);
            this.gbTCPConfig.Name = "gbTCPConfig";
            this.gbTCPConfig.Size = new System.Drawing.Size(476, 185);
            this.gbTCPConfig.TabIndex = 2;
            this.gbTCPConfig.TabStop = false;
            this.gbTCPConfig.Text = "TCP 参数配置";
            // 
            // chk4G
            // 
            this.chk4G.AutoSize = true;
            this.chk4G.Location = new System.Drawing.Point(418, 29);
            this.chk4G.Name = "chk4G";
            this.chk4G.Size = new System.Drawing.Size(40, 17);
            this.chk4G.TabIndex = 6;
            this.chk4G.Text = "4G";
            this.chk4G.UseVisualStyleBackColor = true;
            // 
            // chkWifi
            // 
            this.chkWifi.AutoSize = true;
            this.chkWifi.Location = new System.Drawing.Point(285, 29);
            this.chkWifi.Name = "chkWifi";
            this.chkWifi.Size = new System.Drawing.Size(49, 17);
            this.chkWifi.TabIndex = 6;
            this.chkWifi.Text = "WIFI";
            this.chkWifi.UseVisualStyleBackColor = true;
            // 
            // chkNetwork
            // 
            this.chkNetwork.AutoSize = true;
            this.chkNetwork.Location = new System.Drawing.Point(152, 29);
            this.chkNetwork.Name = "chkNetwork";
            this.chkNetwork.Size = new System.Drawing.Size(50, 17);
            this.chkNetwork.TabIndex = 6;
            this.chkNetwork.Text = "网口";
            this.chkNetwork.UseVisualStyleBackColor = true;
            // 
            // btnQueryTCPConfig
            // 
            this.btnQueryTCPConfig.Location = new System.Drawing.Point(300, 145);
            this.btnQueryTCPConfig.Name = "btnQueryTCPConfig";
            this.btnQueryTCPConfig.Size = new System.Drawing.Size(75, 32);
            this.btnQueryTCPConfig.TabIndex = 5;
            this.btnQueryTCPConfig.Text = "读取";
            this.btnQueryTCPConfig.UseVisualStyleBackColor = true;
            this.btnQueryTCPConfig.Click += new System.EventHandler(this.btnQueryTCPConfig_Click);
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(9, 114);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(29, 13);
            this.lblURL.TabIndex = 0;
            this.lblURL.Text = "URL";
            // 
            // btnUpdateTCPConfig
            // 
            this.btnUpdateTCPConfig.Location = new System.Drawing.Point(395, 145);
            this.btnUpdateTCPConfig.Name = "btnUpdateTCPConfig";
            this.btnUpdateTCPConfig.Size = new System.Drawing.Size(75, 32);
            this.btnUpdateTCPConfig.TabIndex = 5;
            this.btnUpdateTCPConfig.Text = "设置";
            this.btnUpdateTCPConfig.UseVisualStyleBackColor = true;
            this.btnUpdateTCPConfig.Click += new System.EventHandler(this.btnUpdateTCPConfig_Click);
            // 
            // lblTCPPort
            // 
            this.lblTCPPort.AutoSize = true;
            this.lblTCPPort.Location = new System.Drawing.Point(9, 67);
            this.lblTCPPort.Name = "lblTCPPort";
            this.lblTCPPort.Size = new System.Drawing.Size(73, 13);
            this.lblTCPPort.TabIndex = 0;
            this.lblTCPPort.Text = "端口(默认80)";
            // 
            // lblTCPCommunicationType
            // 
            this.lblTCPCommunicationType.AutoSize = true;
            this.lblTCPCommunicationType.Location = new System.Drawing.Point(9, 29);
            this.lblTCPCommunicationType.Name = "lblTCPCommunicationType";
            this.lblTCPCommunicationType.Size = new System.Drawing.Size(52, 13);
            this.lblTCPCommunicationType.TabIndex = 0;
            this.lblTCPCommunicationType.Text = "通讯类型";
            // 
            // tbURL
            // 
            this.tbURL.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbURL.Location = new System.Drawing.Point(101, 106);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(369, 26);
            this.tbURL.TabIndex = 3;
            // 
            // tbTCPPort
            // 
            this.tbTCPPort.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbTCPPort.Location = new System.Drawing.Point(154, 60);
            this.tbTCPPort.Name = "tbTCPPort";
            this.tbTCPPort.Size = new System.Drawing.Size(121, 26);
            this.tbTCPPort.TabIndex = 3;
            // 
            // gbHttpConfig
            // 
            this.gbHttpConfig.Controls.Add(this.btnQueryHttpConfig);
            this.gbHttpConfig.Controls.Add(this.lblHttpUrl);
            this.gbHttpConfig.Controls.Add(this.btnUpdateHttpConfig);
            this.gbHttpConfig.Controls.Add(this.lblHttpPort);
            this.gbHttpConfig.Controls.Add(this.lblHttpReportingInterval);
            this.gbHttpConfig.Controls.Add(this.lblHttpCommunicationType);
            this.gbHttpConfig.Controls.Add(this.cbbHttpCommunicationType);
            this.gbHttpConfig.Controls.Add(this.cbbHttpReportingInterval);
            this.gbHttpConfig.Controls.Add(this.tbHttpURL);
            this.gbHttpConfig.Controls.Add(this.tbHttpPort);
            this.gbHttpConfig.Location = new System.Drawing.Point(364, 198);
            this.gbHttpConfig.Name = "gbHttpConfig";
            this.gbHttpConfig.Size = new System.Drawing.Size(476, 185);
            this.gbHttpConfig.TabIndex = 2;
            this.gbHttpConfig.TabStop = false;
            this.gbHttpConfig.Text = "Http 参数配置";
            // 
            // btnQueryHttpConfig
            // 
            this.btnQueryHttpConfig.Location = new System.Drawing.Point(295, 141);
            this.btnQueryHttpConfig.Name = "btnQueryHttpConfig";
            this.btnQueryHttpConfig.Size = new System.Drawing.Size(75, 32);
            this.btnQueryHttpConfig.TabIndex = 5;
            this.btnQueryHttpConfig.Text = "读取";
            this.btnQueryHttpConfig.UseVisualStyleBackColor = true;
            this.btnQueryHttpConfig.Click += new System.EventHandler(this.btnQueryHttpConfig_Click);
            // 
            // lblHttpUrl
            // 
            this.lblHttpUrl.AutoSize = true;
            this.lblHttpUrl.Location = new System.Drawing.Point(9, 114);
            this.lblHttpUrl.Name = "lblHttpUrl";
            this.lblHttpUrl.Size = new System.Drawing.Size(29, 13);
            this.lblHttpUrl.TabIndex = 0;
            this.lblHttpUrl.Text = "URL";
            // 
            // btnUpdateHttpConfig
            // 
            this.btnUpdateHttpConfig.Location = new System.Drawing.Point(390, 141);
            this.btnUpdateHttpConfig.Name = "btnUpdateHttpConfig";
            this.btnUpdateHttpConfig.Size = new System.Drawing.Size(75, 32);
            this.btnUpdateHttpConfig.TabIndex = 5;
            this.btnUpdateHttpConfig.Text = "设置";
            this.btnUpdateHttpConfig.UseVisualStyleBackColor = true;
            this.btnUpdateHttpConfig.Click += new System.EventHandler(this.btnUpdateHttpConfig_Click);
            // 
            // lblHttpPort
            // 
            this.lblHttpPort.AutoSize = true;
            this.lblHttpPort.Location = new System.Drawing.Point(9, 67);
            this.lblHttpPort.Name = "lblHttpPort";
            this.lblHttpPort.Size = new System.Drawing.Size(73, 13);
            this.lblHttpPort.TabIndex = 0;
            this.lblHttpPort.Text = "端口(默认80)";
            // 
            // lblHttpReportingInterval
            // 
            this.lblHttpReportingInterval.AutoSize = true;
            this.lblHttpReportingInterval.Location = new System.Drawing.Point(228, 67);
            this.lblHttpReportingInterval.Name = "lblHttpReportingInterval";
            this.lblHttpReportingInterval.Size = new System.Drawing.Size(66, 13);
            this.lblHttpReportingInterval.TabIndex = 0;
            this.lblHttpReportingInterval.Text = "上报间隔(s)";
            // 
            // lblHttpCommunicationType
            // 
            this.lblHttpCommunicationType.AutoSize = true;
            this.lblHttpCommunicationType.Location = new System.Drawing.Point(9, 29);
            this.lblHttpCommunicationType.Name = "lblHttpCommunicationType";
            this.lblHttpCommunicationType.Size = new System.Drawing.Size(52, 13);
            this.lblHttpCommunicationType.TabIndex = 0;
            this.lblHttpCommunicationType.Text = "通讯类型";
            // 
            // cbbHttpCommunicationType
            // 
            this.cbbHttpCommunicationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHttpCommunicationType.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbHttpCommunicationType.FormattingEnabled = true;
            this.cbbHttpCommunicationType.Items.AddRange(new object[] {
            "Ethernet port",
            "Wifi",
            "4G"});
            this.cbbHttpCommunicationType.Location = new System.Drawing.Point(141, 22);
            this.cbbHttpCommunicationType.Name = "cbbHttpCommunicationType";
            this.cbbHttpCommunicationType.Size = new System.Drawing.Size(324, 24);
            this.cbbHttpCommunicationType.TabIndex = 2;
            // 
            // cbbHttpReportingInterval
            // 
            this.cbbHttpReportingInterval.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbHttpReportingInterval.FormattingEnabled = true;
            this.cbbHttpReportingInterval.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.cbbHttpReportingInterval.Location = new System.Drawing.Point(362, 60);
            this.cbbHttpReportingInterval.Name = "cbbHttpReportingInterval";
            this.cbbHttpReportingInterval.Size = new System.Drawing.Size(103, 24);
            this.cbbHttpReportingInterval.TabIndex = 2;
            // 
            // tbHttpURL
            // 
            this.tbHttpURL.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbHttpURL.Location = new System.Drawing.Point(38, 106);
            this.tbHttpURL.Name = "tbHttpURL";
            this.tbHttpURL.Size = new System.Drawing.Size(427, 26);
            this.tbHttpURL.TabIndex = 3;
            // 
            // tbHttpPort
            // 
            this.tbHttpPort.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbHttpPort.Location = new System.Drawing.Point(141, 60);
            this.tbHttpPort.Name = "tbHttpPort";
            this.tbHttpPort.Size = new System.Drawing.Size(81, 26);
            this.tbHttpPort.TabIndex = 3;
            // 
            // gbGSPConfig
            // 
            this.gbGSPConfig.Controls.Add(this.btnQueryGSPConfig);
            this.gbGSPConfig.Controls.Add(this.btnUpdateGPSConfig);
            this.gbGSPConfig.Controls.Add(this.cbbCommunicationType);
            this.gbGSPConfig.Controls.Add(this.cbbGPSReportingInterval);
            this.gbGSPConfig.Controls.Add(this.lblGPSReportingInterval);
            this.gbGSPConfig.Controls.Add(this.lblCommunicationType);
            this.gbGSPConfig.Location = new System.Drawing.Point(6, 6);
            this.gbGSPConfig.Name = "gbGSPConfig";
            this.gbGSPConfig.Size = new System.Drawing.Size(352, 142);
            this.gbGSPConfig.TabIndex = 0;
            this.gbGSPConfig.TabStop = false;
            this.gbGSPConfig.Text = "GPS 参数配置";
            // 
            // btnQueryGSPConfig
            // 
            this.btnQueryGSPConfig.Location = new System.Drawing.Point(164, 101);
            this.btnQueryGSPConfig.Name = "btnQueryGSPConfig";
            this.btnQueryGSPConfig.Size = new System.Drawing.Size(75, 32);
            this.btnQueryGSPConfig.TabIndex = 5;
            this.btnQueryGSPConfig.Text = "读取";
            this.btnQueryGSPConfig.UseVisualStyleBackColor = true;
            this.btnQueryGSPConfig.Click += new System.EventHandler(this.btnQueryGSPConfig_Click);
            // 
            // btnUpdateGPSConfig
            // 
            this.btnUpdateGPSConfig.Location = new System.Drawing.Point(259, 101);
            this.btnUpdateGPSConfig.Name = "btnUpdateGPSConfig";
            this.btnUpdateGPSConfig.Size = new System.Drawing.Size(75, 32);
            this.btnUpdateGPSConfig.TabIndex = 5;
            this.btnUpdateGPSConfig.Text = "设置";
            this.btnUpdateGPSConfig.UseVisualStyleBackColor = true;
            this.btnUpdateGPSConfig.Click += new System.EventHandler(this.btnUpdateGPSConfig_Click);
            // 
            // cbbCommunicationType
            // 
            this.cbbCommunicationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCommunicationType.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbCommunicationType.FormattingEnabled = true;
            this.cbbCommunicationType.Items.AddRange(new object[] {
            "RS232",
            "RS485",
            "Ethernet port",
            "Wifi",
            "4G"});
            this.cbbCommunicationType.Location = new System.Drawing.Point(140, 29);
            this.cbbCommunicationType.Name = "cbbCommunicationType";
            this.cbbCommunicationType.Size = new System.Drawing.Size(194, 24);
            this.cbbCommunicationType.TabIndex = 2;
            // 
            // cbbGPSReportingInterval
            // 
            this.cbbGPSReportingInterval.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbGPSReportingInterval.FormattingEnabled = true;
            this.cbbGPSReportingInterval.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.cbbGPSReportingInterval.Location = new System.Drawing.Point(140, 62);
            this.cbbGPSReportingInterval.Name = "cbbGPSReportingInterval";
            this.cbbGPSReportingInterval.Size = new System.Drawing.Size(194, 24);
            this.cbbGPSReportingInterval.TabIndex = 2;
            // 
            // lblGPSReportingInterval
            // 
            this.lblGPSReportingInterval.AutoSize = true;
            this.lblGPSReportingInterval.Location = new System.Drawing.Point(23, 69);
            this.lblGPSReportingInterval.Name = "lblGPSReportingInterval";
            this.lblGPSReportingInterval.Size = new System.Drawing.Size(66, 13);
            this.lblGPSReportingInterval.TabIndex = 0;
            this.lblGPSReportingInterval.Text = "上报间隔(s)";
            // 
            // lblCommunicationType
            // 
            this.lblCommunicationType.AutoSize = true;
            this.lblCommunicationType.Location = new System.Drawing.Point(23, 37);
            this.lblCommunicationType.Name = "lblCommunicationType";
            this.lblCommunicationType.Size = new System.Drawing.Size(52, 13);
            this.lblCommunicationType.TabIndex = 0;
            this.lblCommunicationType.Text = "通讯类型";
            // 
            // gbNetworkParams
            // 
            this.gbNetworkParams.Controls.Add(this.btnDefaultNetworkParams);
            this.gbNetworkParams.Controls.Add(this.btnQueryNetworkParams);
            this.gbNetworkParams.Controls.Add(this.btnUpdateNetworkParams);
            this.gbNetworkParams.Controls.Add(this.cbbIPModel);
            this.gbNetworkParams.Controls.Add(this.lblNetworkParamsClientConfig);
            this.gbNetworkParams.Controls.Add(this.lblGateway);
            this.gbNetworkParams.Controls.Add(this.lblDevicePort);
            this.gbNetworkParams.Controls.Add(this.lblMacAddress);
            this.gbNetworkParams.Controls.Add(this.lblSubnetMask);
            this.gbNetworkParams.Controls.Add(this.lblDns);
            this.gbNetworkParams.Controls.Add(this.lblDeviceIPAddress);
            this.gbNetworkParams.Controls.Add(this.lblNetworkDestPort);
            this.gbNetworkParams.Controls.Add(this.lblIPModel);
            this.gbNetworkParams.Controls.Add(this.cbbNetworkDestIP);
            this.gbNetworkParams.Controls.Add(this.cbbNetworkPattern);
            this.gbNetworkParams.Controls.Add(this.lblNetworkDestIP);
            this.gbNetworkParams.Controls.Add(this.lblNetworkPattern);
            this.gbNetworkParams.Controls.Add(this.tbGateway);
            this.gbNetworkParams.Controls.Add(this.tbDevicePort);
            this.gbNetworkParams.Controls.Add(this.tbMacAddress);
            this.gbNetworkParams.Controls.Add(this.tbNetworkDestPort);
            this.gbNetworkParams.Controls.Add(this.tbDns);
            this.gbNetworkParams.Controls.Add(this.tbSubnetMask);
            this.gbNetworkParams.Controls.Add(this.tbIPAddress);
            this.gbNetworkParams.Location = new System.Drawing.Point(8, 155);
            this.gbNetworkParams.Name = "gbNetworkParams";
            this.gbNetworkParams.Size = new System.Drawing.Size(350, 516);
            this.gbNetworkParams.TabIndex = 0;
            this.gbNetworkParams.TabStop = false;
            this.gbNetworkParams.Text = "网络参数";
            // 
            // btnDefaultNetworkParams
            // 
            this.btnDefaultNetworkParams.Location = new System.Drawing.Point(95, 477);
            this.btnDefaultNetworkParams.Name = "btnDefaultNetworkParams";
            this.btnDefaultNetworkParams.Size = new System.Drawing.Size(75, 32);
            this.btnDefaultNetworkParams.TabIndex = 5;
            this.btnDefaultNetworkParams.Text = "默认";
            this.btnDefaultNetworkParams.UseVisualStyleBackColor = true;
            this.btnDefaultNetworkParams.Click += new System.EventHandler(this.btnDefaultNetworkParams_Click);
            // 
            // btnQueryNetworkParams
            // 
            this.btnQueryNetworkParams.Location = new System.Drawing.Point(176, 477);
            this.btnQueryNetworkParams.Name = "btnQueryNetworkParams";
            this.btnQueryNetworkParams.Size = new System.Drawing.Size(75, 32);
            this.btnQueryNetworkParams.TabIndex = 5;
            this.btnQueryNetworkParams.Text = "读取";
            this.btnQueryNetworkParams.UseVisualStyleBackColor = true;
            this.btnQueryNetworkParams.Click += new System.EventHandler(this.btnQueryNetworkParams_Click);
            // 
            // btnUpdateNetworkParams
            // 
            this.btnUpdateNetworkParams.Location = new System.Drawing.Point(257, 477);
            this.btnUpdateNetworkParams.Name = "btnUpdateNetworkParams";
            this.btnUpdateNetworkParams.Size = new System.Drawing.Size(75, 32);
            this.btnUpdateNetworkParams.TabIndex = 5;
            this.btnUpdateNetworkParams.Text = "设置";
            this.btnUpdateNetworkParams.UseVisualStyleBackColor = true;
            this.btnUpdateNetworkParams.Click += new System.EventHandler(this.btnUpdateNetworkParams_Click);
            // 
            // cbbIPModel
            // 
            this.cbbIPModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbIPModel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbIPModel.FormattingEnabled = true;
            this.cbbIPModel.Items.AddRange(new object[] {
            "Static",
            "Dynamic"});
            this.cbbIPModel.Location = new System.Drawing.Point(127, 74);
            this.cbbIPModel.Name = "cbbIPModel";
            this.cbbIPModel.Size = new System.Drawing.Size(190, 24);
            this.cbbIPModel.TabIndex = 2;
            // 
            // lblNetworkParamsClientConfig
            // 
            this.lblNetworkParamsClientConfig.AutoSize = true;
            this.lblNetworkParamsClientConfig.Location = new System.Drawing.Point(7, 286);
            this.lblNetworkParamsClientConfig.Name = "lblNetworkParamsClientConfig";
            this.lblNetworkParamsClientConfig.Size = new System.Drawing.Size(184, 13);
            this.lblNetworkParamsClientConfig.TabIndex = 0;
            this.lblNetworkParamsClientConfig.Text = "以下设置仅适用于TCP客户端模式";
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.Location = new System.Drawing.Point(13, 252);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(31, 13);
            this.lblGateway.TabIndex = 0;
            this.lblGateway.Text = "网关";
            // 
            // lblDevicePort
            // 
            this.lblDevicePort.AutoSize = true;
            this.lblDevicePort.Location = new System.Drawing.Point(13, 209);
            this.lblDevicePort.Name = "lblDevicePort";
            this.lblDevicePort.Size = new System.Drawing.Size(31, 13);
            this.lblDevicePort.TabIndex = 0;
            this.lblDevicePort.Text = "端口";
            // 
            // lblMacAddress
            // 
            this.lblMacAddress.AutoSize = true;
            this.lblMacAddress.Location = new System.Drawing.Point(13, 445);
            this.lblMacAddress.Name = "lblMacAddress";
            this.lblMacAddress.Size = new System.Drawing.Size(52, 13);
            this.lblMacAddress.TabIndex = 0;
            this.lblMacAddress.Text = "Mac地址";
            // 
            // lblSubnetMask
            // 
            this.lblSubnetMask.AutoSize = true;
            this.lblSubnetMask.Location = new System.Drawing.Point(13, 166);
            this.lblSubnetMask.Name = "lblSubnetMask";
            this.lblSubnetMask.Size = new System.Drawing.Size(55, 13);
            this.lblSubnetMask.TabIndex = 0;
            this.lblSubnetMask.Text = "子网掩码";
            // 
            // lblDns
            // 
            this.lblDns.AutoSize = true;
            this.lblDns.Location = new System.Drawing.Point(13, 402);
            this.lblDns.Name = "lblDns";
            this.lblDns.Size = new System.Drawing.Size(30, 13);
            this.lblDns.TabIndex = 0;
            this.lblDns.Text = "DNS";
            // 
            // lblDeviceIPAddress
            // 
            this.lblDeviceIPAddress.AutoSize = true;
            this.lblDeviceIPAddress.Location = new System.Drawing.Point(13, 122);
            this.lblDeviceIPAddress.Name = "lblDeviceIPAddress";
            this.lblDeviceIPAddress.Size = new System.Drawing.Size(44, 13);
            this.lblDeviceIPAddress.TabIndex = 0;
            this.lblDeviceIPAddress.Text = "IP 地址";
            // 
            // lblNetworkDestPort
            // 
            this.lblNetworkDestPort.AutoSize = true;
            this.lblNetworkDestPort.Location = new System.Drawing.Point(13, 359);
            this.lblNetworkDestPort.Name = "lblNetworkDestPort";
            this.lblNetworkDestPort.Size = new System.Drawing.Size(55, 13);
            this.lblNetworkDestPort.TabIndex = 0;
            this.lblNetworkDestPort.Text = "目的端口";
            // 
            // lblIPModel
            // 
            this.lblIPModel.AutoSize = true;
            this.lblIPModel.Location = new System.Drawing.Point(13, 80);
            this.lblIPModel.Name = "lblIPModel";
            this.lblIPModel.Size = new System.Drawing.Size(44, 13);
            this.lblIPModel.TabIndex = 0;
            this.lblIPModel.Text = "IP 模式";
            // 
            // cbbNetworkDestIP
            // 
            this.cbbNetworkDestIP.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbNetworkDestIP.FormattingEnabled = true;
            this.cbbNetworkDestIP.Location = new System.Drawing.Point(127, 310);
            this.cbbNetworkDestIP.Name = "cbbNetworkDestIP";
            this.cbbNetworkDestIP.Size = new System.Drawing.Size(190, 24);
            this.cbbNetworkDestIP.TabIndex = 2;
            // 
            // cbbNetworkPattern
            // 
            this.cbbNetworkPattern.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNetworkPattern.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbNetworkPattern.FormattingEnabled = true;
            this.cbbNetworkPattern.Items.AddRange(new object[] {
            "TCP Server",
            "TCP Client",
            "UDP",
            "UDP Group"});
            this.cbbNetworkPattern.Location = new System.Drawing.Point(127, 35);
            this.cbbNetworkPattern.Name = "cbbNetworkPattern";
            this.cbbNetworkPattern.Size = new System.Drawing.Size(190, 24);
            this.cbbNetworkPattern.TabIndex = 2;
            // 
            // lblNetworkDestIP
            // 
            this.lblNetworkDestIP.AutoSize = true;
            this.lblNetworkDestIP.Location = new System.Drawing.Point(13, 316);
            this.lblNetworkDestIP.Name = "lblNetworkDestIP";
            this.lblNetworkDestIP.Size = new System.Drawing.Size(41, 13);
            this.lblNetworkDestIP.TabIndex = 0;
            this.lblNetworkDestIP.Text = "目的IP";
            this.lblNetworkDestIP.Click += new System.EventHandler(this.lblNetworkDestIP_Click);
            // 
            // lblNetworkPattern
            // 
            this.lblNetworkPattern.AutoSize = true;
            this.lblNetworkPattern.Location = new System.Drawing.Point(13, 41);
            this.lblNetworkPattern.Name = "lblNetworkPattern";
            this.lblNetworkPattern.Size = new System.Drawing.Size(55, 13);
            this.lblNetworkPattern.TabIndex = 0;
            this.lblNetworkPattern.Text = "网络模式";
            // 
            // tbGateway
            // 
            this.tbGateway.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbGateway.Location = new System.Drawing.Point(127, 245);
            this.tbGateway.Name = "tbGateway";
            this.tbGateway.Size = new System.Drawing.Size(190, 26);
            this.tbGateway.TabIndex = 3;
            // 
            // tbDevicePort
            // 
            this.tbDevicePort.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbDevicePort.Location = new System.Drawing.Point(127, 202);
            this.tbDevicePort.Name = "tbDevicePort";
            this.tbDevicePort.Size = new System.Drawing.Size(190, 26);
            this.tbDevicePort.TabIndex = 3;
            // 
            // tbMacAddress
            // 
            this.tbMacAddress.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMacAddress.Location = new System.Drawing.Point(127, 438);
            this.tbMacAddress.Name = "tbMacAddress";
            this.tbMacAddress.Size = new System.Drawing.Size(190, 26);
            this.tbMacAddress.TabIndex = 3;
            // 
            // tbNetworkDestPort
            // 
            this.tbNetworkDestPort.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbNetworkDestPort.Location = new System.Drawing.Point(127, 351);
            this.tbNetworkDestPort.Name = "tbNetworkDestPort";
            this.tbNetworkDestPort.Size = new System.Drawing.Size(190, 26);
            this.tbNetworkDestPort.TabIndex = 3;
            // 
            // tbDns
            // 
            this.tbDns.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbDns.Location = new System.Drawing.Point(127, 394);
            this.tbDns.Name = "tbDns";
            this.tbDns.Size = new System.Drawing.Size(190, 26);
            this.tbDns.TabIndex = 3;
            // 
            // tbSubnetMask
            // 
            this.tbSubnetMask.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSubnetMask.Location = new System.Drawing.Point(127, 158);
            this.tbSubnetMask.Name = "tbSubnetMask";
            this.tbSubnetMask.Size = new System.Drawing.Size(190, 26);
            this.tbSubnetMask.TabIndex = 3;
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbIPAddress.Location = new System.Drawing.Point(127, 115);
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.Size = new System.Drawing.Size(190, 26);
            this.tbIPAddress.TabIndex = 3;
            // 
            // gbWifiConfig
            // 
            this.gbWifiConfig.Controls.Add(this.tbWifiTCPConfig);
            this.gbWifiConfig.Controls.Add(this.gbWifiConnectConfig);
            this.gbWifiConfig.Location = new System.Drawing.Point(364, 390);
            this.gbWifiConfig.Name = "gbWifiConfig";
            this.gbWifiConfig.Size = new System.Drawing.Size(476, 282);
            this.gbWifiConfig.TabIndex = 1;
            this.gbWifiConfig.TabStop = false;
            this.gbWifiConfig.Text = "WIFI连接配置";
            // 
            // tbWifiTCPConfig
            // 
            this.tbWifiTCPConfig.Controls.Add(this.btnQueryWifiTCPConfig);
            this.tbWifiTCPConfig.Controls.Add(this.btnUpdateWifiTCPConfig);
            this.tbWifiTCPConfig.Controls.Add(this.btnLocalHost);
            this.tbWifiTCPConfig.Controls.Add(this.tbTCPDestPort);
            this.tbWifiTCPConfig.Controls.Add(this.cbbTCPDestIP);
            this.tbWifiTCPConfig.Controls.Add(this.lblDestPort);
            this.tbWifiTCPConfig.Controls.Add(this.lblDestIP);
            this.tbWifiTCPConfig.Location = new System.Drawing.Point(7, 143);
            this.tbWifiTCPConfig.Name = "tbWifiTCPConfig";
            this.tbWifiTCPConfig.Size = new System.Drawing.Size(458, 118);
            this.tbWifiTCPConfig.TabIndex = 0;
            this.tbWifiTCPConfig.TabStop = false;
            this.tbWifiTCPConfig.Text = "TCP Client配置";
            // 
            // btnQueryWifiTCPConfig
            // 
            this.btnQueryWifiTCPConfig.Location = new System.Drawing.Point(288, 72);
            this.btnQueryWifiTCPConfig.Name = "btnQueryWifiTCPConfig";
            this.btnQueryWifiTCPConfig.Size = new System.Drawing.Size(75, 32);
            this.btnQueryWifiTCPConfig.TabIndex = 5;
            this.btnQueryWifiTCPConfig.Text = "读取";
            this.btnQueryWifiTCPConfig.UseVisualStyleBackColor = true;
            this.btnQueryWifiTCPConfig.Click += new System.EventHandler(this.btnQueryWifiTCPConfig_Click);
            // 
            // btnUpdateWifiTCPConfig
            // 
            this.btnUpdateWifiTCPConfig.Location = new System.Drawing.Point(372, 72);
            this.btnUpdateWifiTCPConfig.Name = "btnUpdateWifiTCPConfig";
            this.btnUpdateWifiTCPConfig.Size = new System.Drawing.Size(75, 32);
            this.btnUpdateWifiTCPConfig.TabIndex = 5;
            this.btnUpdateWifiTCPConfig.Text = "设置";
            this.btnUpdateWifiTCPConfig.UseVisualStyleBackColor = true;
            this.btnUpdateWifiTCPConfig.Click += new System.EventHandler(this.btnSetWifiTCPConfig_Click);
            // 
            // btnLocalHost
            // 
            this.btnLocalHost.Location = new System.Drawing.Point(288, 26);
            this.btnLocalHost.Name = "btnLocalHost";
            this.btnLocalHost.Size = new System.Drawing.Size(75, 32);
            this.btnLocalHost.TabIndex = 4;
            this.btnLocalHost.Text = "本机 IP ";
            this.btnLocalHost.UseVisualStyleBackColor = true;
            this.btnLocalHost.Click += new System.EventHandler(this.btnLocalHost_Click);
            // 
            // tbTCPDestPort
            // 
            this.tbTCPDestPort.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbTCPDestPort.Location = new System.Drawing.Point(110, 74);
            this.tbTCPDestPort.Name = "tbTCPDestPort";
            this.tbTCPDestPort.Size = new System.Drawing.Size(167, 26);
            this.tbTCPDestPort.TabIndex = 3;
            // 
            // cbbTCPDestIP
            // 
            this.cbbTCPDestIP.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbTCPDestIP.FormattingEnabled = true;
            this.cbbTCPDestIP.Location = new System.Drawing.Point(110, 29);
            this.cbbTCPDestIP.Name = "cbbTCPDestIP";
            this.cbbTCPDestIP.Size = new System.Drawing.Size(167, 24);
            this.cbbTCPDestIP.TabIndex = 2;
            // 
            // lblDestPort
            // 
            this.lblDestPort.AutoSize = true;
            this.lblDestPort.Location = new System.Drawing.Point(23, 81);
            this.lblDestPort.Name = "lblDestPort";
            this.lblDestPort.Size = new System.Drawing.Size(55, 13);
            this.lblDestPort.TabIndex = 0;
            this.lblDestPort.Text = "目的端口";
            // 
            // lblDestIP
            // 
            this.lblDestIP.AutoSize = true;
            this.lblDestIP.Location = new System.Drawing.Point(23, 36);
            this.lblDestIP.Name = "lblDestIP";
            this.lblDestIP.Size = new System.Drawing.Size(44, 13);
            this.lblDestIP.TabIndex = 0;
            this.lblDestIP.Text = "目的 IP";
            // 
            // gbWifiConnectConfig
            // 
            this.gbWifiConnectConfig.Controls.Add(this.btnQueryWifi);
            this.gbWifiConnectConfig.Controls.Add(this.btnUpdateWifi);
            this.gbWifiConnectConfig.Controls.Add(this.tbWifiConnectPwd);
            this.gbWifiConnectConfig.Controls.Add(this.cbbSSID);
            this.gbWifiConnectConfig.Controls.Add(this.chkWifiPwd);
            this.gbWifiConnectConfig.Controls.Add(this.lblSSID);
            this.gbWifiConnectConfig.Location = new System.Drawing.Point(7, 23);
            this.gbWifiConnectConfig.Name = "gbWifiConnectConfig";
            this.gbWifiConnectConfig.Size = new System.Drawing.Size(458, 114);
            this.gbWifiConnectConfig.TabIndex = 0;
            this.gbWifiConnectConfig.TabStop = false;
            this.gbWifiConnectConfig.Text = "连接配置";
            // 
            // btnQueryWifi
            // 
            this.btnQueryWifi.Location = new System.Drawing.Point(372, 26);
            this.btnQueryWifi.Name = "btnQueryWifi";
            this.btnQueryWifi.Size = new System.Drawing.Size(75, 32);
            this.btnQueryWifi.TabIndex = 5;
            this.btnQueryWifi.Text = "读取";
            this.btnQueryWifi.UseVisualStyleBackColor = true;
            this.btnQueryWifi.Click += new System.EventHandler(this.btnQueryWifi_Click);
            // 
            // btnUpdateWifi
            // 
            this.btnUpdateWifi.Location = new System.Drawing.Point(372, 66);
            this.btnUpdateWifi.Name = "btnUpdateWifi";
            this.btnUpdateWifi.Size = new System.Drawing.Size(75, 32);
            this.btnUpdateWifi.TabIndex = 5;
            this.btnUpdateWifi.Text = "设置";
            this.btnUpdateWifi.UseVisualStyleBackColor = true;
            this.btnUpdateWifi.Click += new System.EventHandler(this.btnSetWifi_Click);
            // 
            // tbWifiConnectPwd
            // 
            this.tbWifiConnectPwd.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbWifiConnectPwd.Location = new System.Drawing.Point(110, 68);
            this.tbWifiConnectPwd.Name = "tbWifiConnectPwd";
            this.tbWifiConnectPwd.PasswordChar = '*';
            this.tbWifiConnectPwd.Size = new System.Drawing.Size(253, 26);
            this.tbWifiConnectPwd.TabIndex = 3;
            // 
            // cbbSSID
            // 
            this.cbbSSID.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbSSID.FormattingEnabled = true;
            this.cbbSSID.Location = new System.Drawing.Point(110, 29);
            this.cbbSSID.Name = "cbbSSID";
            this.cbbSSID.Size = new System.Drawing.Size(253, 24);
            this.cbbSSID.TabIndex = 2;
            // 
            // chkWifiPwd
            // 
            this.chkWifiPwd.AutoSize = true;
            this.chkWifiPwd.Location = new System.Drawing.Point(25, 74);
            this.chkWifiPwd.Name = "chkWifiPwd";
            this.chkWifiPwd.Size = new System.Drawing.Size(50, 17);
            this.chkWifiPwd.TabIndex = 1;
            this.chkWifiPwd.Text = "密码";
            this.chkWifiPwd.UseVisualStyleBackColor = true;
            this.chkWifiPwd.CheckedChanged += new System.EventHandler(this.chkWifiPwd_CheckedChanged);
            // 
            // lblSSID
            // 
            this.lblSSID.AutoSize = true;
            this.lblSSID.Location = new System.Drawing.Point(23, 36);
            this.lblSSID.Name = "lblSSID";
            this.lblSSID.Size = new System.Drawing.Size(32, 13);
            this.lblSSID.TabIndex = 0;
            this.lblSSID.Text = "SSID";
            // 
            // tbSetReaderParam
            // 
            this.tbSetReaderParam.Controls.Add(this.gbUserCustomData);
            this.tbSetReaderParam.Controls.Add(this.btnDeviceReset);
            this.tbSetReaderParam.Controls.Add(this.btnFactorySetting);
            this.tbSetReaderParam.Controls.Add(this.gbLEDLamp);
            this.tbSetReaderParam.Controls.Add(this.gbDevNo);
            this.tbSetReaderParam.Controls.Add(this.gbLinkModel);
            this.tbSetReaderParam.Controls.Add(this.gbFreq);
            this.tbSetReaderParam.Controls.Add(this.gbDataOutputFormat);
            this.tbSetReaderParam.Controls.Add(this.gbCommModeParam);
            this.tbSetReaderParam.Controls.Add(this.GopRelayControl);
            this.tbSetReaderParam.Controls.Add(this.gbWorkMode);
            this.tbSetReaderParam.Location = new System.Drawing.Point(4, 22);
            this.tbSetReaderParam.Name = "tbSetReaderParam";
            this.tbSetReaderParam.Padding = new System.Windows.Forms.Padding(3);
            this.tbSetReaderParam.Size = new System.Drawing.Size(864, 680);
            this.tbSetReaderParam.TabIndex = 3;
            this.tbSetReaderParam.Text = "读写器参数";
            this.tbSetReaderParam.UseVisualStyleBackColor = true;
            this.tbSetReaderParam.Click += new System.EventHandler(this.tbSetReaderParam_Click);
            this.tbSetReaderParam.Enter += new System.EventHandler(this.SetReaderParam_Enter);
            // 
            // gbUserCustomData
            // 
            this.gbUserCustomData.Controls.Add(this.lblUserCustomData);
            this.gbUserCustomData.Controls.Add(this.btnQueryUserCustomData);
            this.gbUserCustomData.Controls.Add(this.tbUserCustomData);
            this.gbUserCustomData.Controls.Add(this.btnUpdateUserCustomData);
            this.gbUserCustomData.Location = new System.Drawing.Point(691, 339);
            this.gbUserCustomData.Name = "gbUserCustomData";
            this.gbUserCustomData.Size = new System.Drawing.Size(158, 118);
            this.gbUserCustomData.TabIndex = 101;
            this.gbUserCustomData.TabStop = false;
            this.gbUserCustomData.Text = "用户自定义数据";
            // 
            // lblUserCustomData
            // 
            this.lblUserCustomData.AutoSize = true;
            this.lblUserCustomData.Location = new System.Drawing.Point(6, 20);
            this.lblUserCustomData.Name = "lblUserCustomData";
            this.lblUserCustomData.Size = new System.Drawing.Size(31, 13);
            this.lblUserCustomData.TabIndex = 103;
            this.lblUserCustomData.Tag = "4";
            this.lblUserCustomData.Text = "数据";
            // 
            // btnQueryUserCustomData
            // 
            this.btnQueryUserCustomData.Location = new System.Drawing.Point(6, 73);
            this.btnQueryUserCustomData.Name = "btnQueryUserCustomData";
            this.btnQueryUserCustomData.Size = new System.Drawing.Size(73, 35);
            this.btnQueryUserCustomData.TabIndex = 16;
            this.btnQueryUserCustomData.Text = "读取";
            this.btnQueryUserCustomData.UseVisualStyleBackColor = true;
            this.btnQueryUserCustomData.Click += new System.EventHandler(this.btnQueryUserCustomData_Click);
            // 
            // tbUserCustomData
            // 
            this.tbUserCustomData.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbUserCustomData.Location = new System.Drawing.Point(6, 40);
            this.tbUserCustomData.Name = "tbUserCustomData";
            this.tbUserCustomData.Size = new System.Drawing.Size(142, 23);
            this.tbUserCustomData.TabIndex = 102;
            // 
            // btnUpdateUserCustomData
            // 
            this.btnUpdateUserCustomData.Location = new System.Drawing.Point(83, 73);
            this.btnUpdateUserCustomData.Name = "btnUpdateUserCustomData";
            this.btnUpdateUserCustomData.Size = new System.Drawing.Size(73, 35);
            this.btnUpdateUserCustomData.TabIndex = 16;
            this.btnUpdateUserCustomData.Text = "设置";
            this.btnUpdateUserCustomData.UseVisualStyleBackColor = true;
            this.btnUpdateUserCustomData.Click += new System.EventHandler(this.btnUpdateUserCustomData_Click);
            // 
            // btnDeviceReset
            // 
            this.btnDeviceReset.Location = new System.Drawing.Point(699, 507);
            this.btnDeviceReset.Name = "btnDeviceReset";
            this.btnDeviceReset.Size = new System.Drawing.Size(144, 32);
            this.btnDeviceReset.TabIndex = 40;
            this.btnDeviceReset.Text = "设备复位";
            this.btnDeviceReset.UseVisualStyleBackColor = true;
            this.btnDeviceReset.Click += new System.EventHandler(this.btnDeviceReset_Click);
            // 
            // btnFactorySetting
            // 
            this.btnFactorySetting.Location = new System.Drawing.Point(699, 464);
            this.btnFactorySetting.Name = "btnFactorySetting";
            this.btnFactorySetting.Size = new System.Drawing.Size(144, 32);
            this.btnFactorySetting.TabIndex = 40;
            this.btnFactorySetting.Text = "出厂设置";
            this.btnFactorySetting.UseVisualStyleBackColor = true;
            this.btnFactorySetting.Click += new System.EventHandler(this.btnFactorySetting_Click);
            // 
            // gbLEDLamp
            // 
            this.gbLEDLamp.Controls.Add(this.btnSetLamp);
            this.gbLEDLamp.Controls.Add(this.btnReadBeep);
            this.gbLEDLamp.Controls.Add(this.lblLedLamp);
            this.gbLEDLamp.Controls.Add(this.lblReadVoice);
            this.gbLEDLamp.Controls.Add(this.btnSetBeep);
            this.gbLEDLamp.Controls.Add(this.btnGetLamp);
            this.gbLEDLamp.Controls.Add(this.cbbLamp);
            this.gbLEDLamp.Controls.Add(this.cbbBeepControl);
            this.gbLEDLamp.Location = new System.Drawing.Point(406, 546);
            this.gbLEDLamp.Name = "gbLEDLamp";
            this.gbLEDLamp.Size = new System.Drawing.Size(441, 126);
            this.gbLEDLamp.TabIndex = 100;
            this.gbLEDLamp.TabStop = false;
            this.gbLEDLamp.Text = "LED 灯";
            // 
            // btnSetLamp
            // 
            this.btnSetLamp.Location = new System.Drawing.Point(352, 72);
            this.btnSetLamp.Name = "btnSetLamp";
            this.btnSetLamp.Size = new System.Drawing.Size(80, 32);
            this.btnSetLamp.TabIndex = 40;
            this.btnSetLamp.Text = "设置";
            this.btnSetLamp.UseVisualStyleBackColor = true;
            this.btnSetLamp.Click += new System.EventHandler(this.btnSetLamp_Click);
            // 
            // btnReadBeep
            // 
            this.btnReadBeep.Location = new System.Drawing.Point(266, 22);
            this.btnReadBeep.Name = "btnReadBeep";
            this.btnReadBeep.Size = new System.Drawing.Size(80, 32);
            this.btnReadBeep.TabIndex = 9;
            this.btnReadBeep.Text = "读取";
            this.btnReadBeep.UseVisualStyleBackColor = true;
            this.btnReadBeep.Click += new System.EventHandler(this.btnReadBeep_Click);
            // 
            // lblLedLamp
            // 
            this.lblLedLamp.Location = new System.Drawing.Point(6, 74);
            this.lblLedLamp.Name = "lblLedLamp";
            this.lblLedLamp.Size = new System.Drawing.Size(73, 29);
            this.lblLedLamp.TabIndex = 12;
            this.lblLedLamp.Text = "LED 灯";
            this.lblLedLamp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReadVoice
            // 
            this.lblReadVoice.Location = new System.Drawing.Point(5, 24);
            this.lblReadVoice.Name = "lblReadVoice";
            this.lblReadVoice.Size = new System.Drawing.Size(80, 29);
            this.lblReadVoice.TabIndex = 12;
            this.lblReadVoice.Text = "蜂鸣器声音";
            this.lblReadVoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSetBeep
            // 
            this.btnSetBeep.Location = new System.Drawing.Point(352, 22);
            this.btnSetBeep.Name = "btnSetBeep";
            this.btnSetBeep.Size = new System.Drawing.Size(80, 32);
            this.btnSetBeep.TabIndex = 9;
            this.btnSetBeep.Text = "设置";
            this.btnSetBeep.UseVisualStyleBackColor = true;
            this.btnSetBeep.Click += new System.EventHandler(this.btnSetBeep_Click);
            // 
            // btnGetLamp
            // 
            this.btnGetLamp.Location = new System.Drawing.Point(266, 72);
            this.btnGetLamp.Name = "btnGetLamp";
            this.btnGetLamp.Size = new System.Drawing.Size(80, 32);
            this.btnGetLamp.TabIndex = 38;
            this.btnGetLamp.Text = "读取";
            this.btnGetLamp.UseVisualStyleBackColor = true;
            this.btnGetLamp.Click += new System.EventHandler(this.btnGetLamp_Click);
            // 
            // cbbLamp
            // 
            this.cbbLamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLamp.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbLamp.IntegralHeight = false;
            this.cbbLamp.Items.AddRange(new object[] {
            "Close",
            "Open"});
            this.cbbLamp.Location = new System.Drawing.Point(91, 75);
            this.cbbLamp.Name = "cbbLamp";
            this.cbbLamp.Size = new System.Drawing.Size(150, 24);
            this.cbbLamp.TabIndex = 100;
            // 
            // cbbBeepControl
            // 
            this.cbbBeepControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBeepControl.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbBeepControl.FormattingEnabled = true;
            this.cbbBeepControl.Location = new System.Drawing.Point(91, 25);
            this.cbbBeepControl.Name = "cbbBeepControl";
            this.cbbBeepControl.Size = new System.Drawing.Size(150, 24);
            this.cbbBeepControl.TabIndex = 2;
            // 
            // gbDevNo
            // 
            this.gbDevNo.Controls.Add(this.btnSetDeviceId);
            this.gbDevNo.Controls.Add(this.btnReadDeviceId);
            this.gbDevNo.Controls.Add(this.tbNewDevNo);
            this.gbDevNo.Location = new System.Drawing.Point(691, 232);
            this.gbDevNo.Name = "gbDevNo";
            this.gbDevNo.Size = new System.Drawing.Size(158, 101);
            this.gbDevNo.TabIndex = 100;
            this.gbDevNo.TabStop = false;
            this.gbDevNo.Text = "设备号";
            // 
            // btnSetDeviceId
            // 
            this.btnSetDeviceId.Location = new System.Drawing.Point(85, 61);
            this.btnSetDeviceId.Name = "btnSetDeviceId";
            this.btnSetDeviceId.Size = new System.Drawing.Size(60, 32);
            this.btnSetDeviceId.TabIndex = 40;
            this.btnSetDeviceId.Text = "设置";
            this.btnSetDeviceId.UseVisualStyleBackColor = true;
            this.btnSetDeviceId.Click += new System.EventHandler(this.btnSetDeviceId_Click);
            // 
            // btnReadDeviceId
            // 
            this.btnReadDeviceId.Location = new System.Drawing.Point(21, 61);
            this.btnReadDeviceId.Name = "btnReadDeviceId";
            this.btnReadDeviceId.Size = new System.Drawing.Size(60, 32);
            this.btnReadDeviceId.TabIndex = 38;
            this.btnReadDeviceId.Text = "读取";
            this.btnReadDeviceId.UseVisualStyleBackColor = true;
            this.btnReadDeviceId.Click += new System.EventHandler(this.btnReadDeviceId_Click);
            // 
            // tbNewDevNo
            // 
            this.tbNewDevNo.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbNewDevNo.Location = new System.Drawing.Point(8, 22);
            this.tbNewDevNo.Name = "tbNewDevNo";
            this.tbNewDevNo.Size = new System.Drawing.Size(137, 30);
            this.tbNewDevNo.TabIndex = 0;
            // 
            // gbLinkModel
            // 
            this.gbLinkModel.Controls.Add(this.btnUpdateLinkModel);
            this.gbLinkModel.Controls.Add(this.btnDefaultLinkModel);
            this.gbLinkModel.Controls.Add(this.btnQueryLinkModel);
            this.gbLinkModel.Controls.Add(this.cbbLinkModel);
            this.gbLinkModel.Location = new System.Drawing.Point(406, 232);
            this.gbLinkModel.Name = "gbLinkModel";
            this.gbLinkModel.Size = new System.Drawing.Size(279, 117);
            this.gbLinkModel.TabIndex = 93;
            this.gbLinkModel.TabStop = false;
            this.gbLinkModel.Text = "链路模式";
            // 
            // btnUpdateLinkModel
            // 
            this.btnUpdateLinkModel.Location = new System.Drawing.Point(182, 78);
            this.btnUpdateLinkModel.Name = "btnUpdateLinkModel";
            this.btnUpdateLinkModel.Size = new System.Drawing.Size(82, 32);
            this.btnUpdateLinkModel.TabIndex = 25;
            this.btnUpdateLinkModel.Text = "设置";
            this.btnUpdateLinkModel.UseVisualStyleBackColor = true;
            this.btnUpdateLinkModel.Click += new System.EventHandler(this.btnUpdateLinkModel_Click);
            // 
            // btnDefaultLinkModel
            // 
            this.btnDefaultLinkModel.Location = new System.Drawing.Point(6, 78);
            this.btnDefaultLinkModel.Name = "btnDefaultLinkModel";
            this.btnDefaultLinkModel.Size = new System.Drawing.Size(82, 32);
            this.btnDefaultLinkModel.TabIndex = 26;
            this.btnDefaultLinkModel.Text = "默认参数";
            this.btnDefaultLinkModel.UseVisualStyleBackColor = true;
            this.btnDefaultLinkModel.Click += new System.EventHandler(this.btnDefaultLinkModel_Click);
            // 
            // btnQueryLinkModel
            // 
            this.btnQueryLinkModel.Location = new System.Drawing.Point(94, 78);
            this.btnQueryLinkModel.Name = "btnQueryLinkModel";
            this.btnQueryLinkModel.Size = new System.Drawing.Size(82, 32);
            this.btnQueryLinkModel.TabIndex = 27;
            this.btnQueryLinkModel.Text = "读取";
            this.btnQueryLinkModel.UseVisualStyleBackColor = true;
            this.btnQueryLinkModel.Click += new System.EventHandler(this.btnQueryLinkModel_Click);
            // 
            // cbbLinkModel
            // 
            this.cbbLinkModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLinkModel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbLinkModel.FormattingEnabled = true;
            this.cbbLinkModel.Items.AddRange(new object[] {
            "160KHz FMO Tari 12.5us",
            "160KHz Miller8 Tari 12.5us",
            "250KHz FMO Tari 12.5us",
            "320KHz Miller4 Tari 6.25us"});
            this.cbbLinkModel.Location = new System.Drawing.Point(6, 28);
            this.cbbLinkModel.Name = "cbbLinkModel";
            this.cbbLinkModel.Size = new System.Drawing.Size(256, 24);
            this.cbbLinkModel.TabIndex = 35;
            this.cbbLinkModel.SelectedIndexChanged += new System.EventHandler(this.cboBand_SelectedIndexChanged);
            // 
            // gbFreq
            // 
            this.gbFreq.Controls.Add(this.tbChannelSpacing);
            this.gbFreq.Controls.Add(this.lblChannelSpacingUnit);
            this.gbFreq.Controls.Add(this.lblStartFrequUnit);
            this.gbFreq.Controls.Add(this.cbbEndFrequ);
            this.gbFreq.Controls.Add(this.lblEndFrequ);
            this.gbFreq.Controls.Add(this.cbbStartFrequ);
            this.gbFreq.Controls.Add(this.lblChannelSpacing);
            this.gbFreq.Controls.Add(this.lblStartFrequ);
            this.gbFreq.Controls.Add(this.lblFrequencyArea);
            this.gbFreq.Controls.Add(this.label8);
            this.gbFreq.Controls.Add(this.btnDefaultFreq);
            this.gbFreq.Controls.Add(this.btnReadFreq);
            this.gbFreq.Controls.Add(this.cbbFrequencyBand);
            this.gbFreq.Controls.Add(this.labSetParam);
            this.gbFreq.Controls.Add(this.btnSetFreq);
            this.gbFreq.Location = new System.Drawing.Point(14, 232);
            this.gbFreq.Name = "gbFreq";
            this.gbFreq.Size = new System.Drawing.Size(386, 219);
            this.gbFreq.TabIndex = 92;
            this.gbFreq.TabStop = false;
            this.gbFreq.Text = "频率及其它参数";
            // 
            // tbChannelSpacing
            // 
            this.tbChannelSpacing.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbChannelSpacing.Location = new System.Drawing.Point(124, 87);
            this.tbChannelSpacing.Name = "tbChannelSpacing";
            this.tbChannelSpacing.Size = new System.Drawing.Size(112, 23);
            this.tbChannelSpacing.TabIndex = 102;
            // 
            // lblChannelSpacingUnit
            // 
            this.lblChannelSpacingUnit.Location = new System.Drawing.Point(242, 88);
            this.lblChannelSpacingUnit.Name = "lblChannelSpacingUnit";
            this.lblChannelSpacingUnit.Size = new System.Drawing.Size(30, 24);
            this.lblChannelSpacingUnit.TabIndex = 101;
            this.lblChannelSpacingUnit.Text = "MHz";
            this.lblChannelSpacingUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStartFrequUnit
            // 
            this.lblStartFrequUnit.Location = new System.Drawing.Point(242, 56);
            this.lblStartFrequUnit.Name = "lblStartFrequUnit";
            this.lblStartFrequUnit.Size = new System.Drawing.Size(30, 24);
            this.lblStartFrequUnit.TabIndex = 101;
            this.lblStartFrequUnit.Text = "MHz";
            this.lblStartFrequUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbEndFrequ
            // 
            this.cbbEndFrequ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEndFrequ.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbEndFrequ.IntegralHeight = false;
            this.cbbEndFrequ.Items.AddRange(new object[] {
            "192.168.100.100"});
            this.cbbEndFrequ.Location = new System.Drawing.Point(124, 118);
            this.cbbEndFrequ.Name = "cbbEndFrequ";
            this.cbbEndFrequ.Size = new System.Drawing.Size(112, 24);
            this.cbbEndFrequ.TabIndex = 100;
            // 
            // lblEndFrequ
            // 
            this.lblEndFrequ.Location = new System.Drawing.Point(8, 120);
            this.lblEndFrequ.Name = "lblEndFrequ";
            this.lblEndFrequ.Size = new System.Drawing.Size(100, 24);
            this.lblEndFrequ.TabIndex = 99;
            this.lblEndFrequ.Text = "结束频率";
            this.lblEndFrequ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbStartFrequ
            // 
            this.cbbStartFrequ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStartFrequ.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbStartFrequ.IntegralHeight = false;
            this.cbbStartFrequ.Location = new System.Drawing.Point(124, 54);
            this.cbbStartFrequ.Name = "cbbStartFrequ";
            this.cbbStartFrequ.Size = new System.Drawing.Size(112, 24);
            this.cbbStartFrequ.TabIndex = 100;
            // 
            // lblChannelSpacing
            // 
            this.lblChannelSpacing.Location = new System.Drawing.Point(8, 88);
            this.lblChannelSpacing.Name = "lblChannelSpacing";
            this.lblChannelSpacing.Size = new System.Drawing.Size(100, 24);
            this.lblChannelSpacing.TabIndex = 99;
            this.lblChannelSpacing.Text = "信道间隔";
            this.lblChannelSpacing.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStartFrequ
            // 
            this.lblStartFrequ.Location = new System.Drawing.Point(8, 56);
            this.lblStartFrequ.Name = "lblStartFrequ";
            this.lblStartFrequ.Size = new System.Drawing.Size(100, 24);
            this.lblStartFrequ.TabIndex = 99;
            this.lblStartFrequ.Text = "起始频率";
            this.lblStartFrequ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFrequencyArea
            // 
            this.lblFrequencyArea.Location = new System.Drawing.Point(8, 22);
            this.lblFrequencyArea.Name = "lblFrequencyArea";
            this.lblFrequencyArea.Size = new System.Drawing.Size(100, 24);
            this.lblFrequencyArea.TabIndex = 98;
            this.lblFrequencyArea.Text = "频率区域";
            this.lblFrequencyArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 81;
            // 
            // btnDefaultFreq
            // 
            this.btnDefaultFreq.Location = new System.Drawing.Point(116, 169);
            this.btnDefaultFreq.Name = "btnDefaultFreq";
            this.btnDefaultFreq.Size = new System.Drawing.Size(82, 32);
            this.btnDefaultFreq.TabIndex = 59;
            this.btnDefaultFreq.Text = "默认参数";
            this.btnDefaultFreq.UseVisualStyleBackColor = true;
            this.btnDefaultFreq.Click += new System.EventHandler(this.btnDefaultFreq_Click);
            // 
            // btnReadFreq
            // 
            this.btnReadFreq.Location = new System.Drawing.Point(204, 169);
            this.btnReadFreq.Name = "btnReadFreq";
            this.btnReadFreq.Size = new System.Drawing.Size(82, 32);
            this.btnReadFreq.TabIndex = 58;
            this.btnReadFreq.Text = "读取";
            this.btnReadFreq.UseVisualStyleBackColor = true;
            this.btnReadFreq.Click += new System.EventHandler(this.btnReadFreq_Click);
            // 
            // cbbFrequencyBand
            // 
            this.cbbFrequencyBand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFrequencyBand.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbFrequencyBand.FormattingEnabled = true;
            this.cbbFrequencyBand.Location = new System.Drawing.Point(124, 22);
            this.cbbFrequencyBand.Name = "cbbFrequencyBand";
            this.cbbFrequencyBand.Size = new System.Drawing.Size(250, 24);
            this.cbbFrequencyBand.TabIndex = 35;
            this.cbbFrequencyBand.SelectedIndexChanged += new System.EventHandler(this.cboBand_SelectedIndexChanged);
            // 
            // labSetParam
            // 
            this.labSetParam.AutoSize = true;
            this.labSetParam.Location = new System.Drawing.Point(34, 188);
            this.labSetParam.Name = "labSetParam";
            this.labSetParam.Size = new System.Drawing.Size(0, 13);
            this.labSetParam.TabIndex = 14;
            // 
            // btnSetFreq
            // 
            this.btnSetFreq.Location = new System.Drawing.Point(292, 169);
            this.btnSetFreq.Name = "btnSetFreq";
            this.btnSetFreq.Size = new System.Drawing.Size(82, 32);
            this.btnSetFreq.TabIndex = 8;
            this.btnSetFreq.Text = "设置";
            this.btnSetFreq.UseVisualStyleBackColor = true;
            this.btnSetFreq.Click += new System.EventHandler(this.btnSetFreq_Click);
            // 
            // gbDataOutputFormat
            // 
            this.gbDataOutputFormat.Controls.Add(this.btnQueryOutputformat);
            this.gbDataOutputFormat.Controls.Add(this.btnUpdateOutputFormat);
            this.gbDataOutputFormat.Controls.Add(this.chkUseCustomeData);
            this.gbDataOutputFormat.Controls.Add(this.chkTagArea);
            this.gbDataOutputFormat.Controls.Add(this.chkTagTime);
            this.gbDataOutputFormat.Controls.Add(this.chkPcValue);
            this.gbDataOutputFormat.Controls.Add(this.chkPrivateData);
            this.gbDataOutputFormat.Controls.Add(this.chkRssi);
            this.gbDataOutputFormat.Controls.Add(this.chkAlarmState);
            this.gbDataOutputFormat.Controls.Add(this.chkAntennaId);
            this.gbDataOutputFormat.Location = new System.Drawing.Point(14, 457);
            this.gbDataOutputFormat.Name = "gbDataOutputFormat";
            this.gbDataOutputFormat.Size = new System.Drawing.Size(217, 215);
            this.gbDataOutputFormat.TabIndex = 97;
            this.gbDataOutputFormat.TabStop = false;
            this.gbDataOutputFormat.Text = "输出格式";
            // 
            // btnQueryOutputformat
            // 
            this.btnQueryOutputformat.Location = new System.Drawing.Point(26, 172);
            this.btnQueryOutputformat.Name = "btnQueryOutputformat";
            this.btnQueryOutputformat.Size = new System.Drawing.Size(88, 35);
            this.btnQueryOutputformat.TabIndex = 16;
            this.btnQueryOutputformat.Text = "读取";
            this.btnQueryOutputformat.UseVisualStyleBackColor = true;
            this.btnQueryOutputformat.Click += new System.EventHandler(this.btnQueryOutputformat_Click);
            // 
            // btnUpdateOutputFormat
            // 
            this.btnUpdateOutputFormat.Location = new System.Drawing.Point(120, 172);
            this.btnUpdateOutputFormat.Name = "btnUpdateOutputFormat";
            this.btnUpdateOutputFormat.Size = new System.Drawing.Size(88, 35);
            this.btnUpdateOutputFormat.TabIndex = 16;
            this.btnUpdateOutputFormat.Text = "设置";
            this.btnUpdateOutputFormat.UseVisualStyleBackColor = true;
            this.btnUpdateOutputFormat.Click += new System.EventHandler(this.btnUpdateOutputFormat_Click);
            // 
            // chkUseCustomeData
            // 
            this.chkUseCustomeData.AutoSize = true;
            this.chkUseCustomeData.Location = new System.Drawing.Point(100, 130);
            this.chkUseCustomeData.Name = "chkUseCustomeData";
            this.chkUseCustomeData.Size = new System.Drawing.Size(110, 17);
            this.chkUseCustomeData.TabIndex = 0;
            this.chkUseCustomeData.Text = "用户自定义数据";
            this.chkUseCustomeData.UseVisualStyleBackColor = true;
            // 
            // chkTagArea
            // 
            this.chkTagArea.AutoSize = true;
            this.chkTagArea.Location = new System.Drawing.Point(10, 130);
            this.chkTagArea.Name = "chkTagArea";
            this.chkTagArea.Size = new System.Drawing.Size(74, 17);
            this.chkTagArea.TabIndex = 0;
            this.chkTagArea.Text = "标签区域";
            this.chkTagArea.UseVisualStyleBackColor = true;
            // 
            // chkTagTime
            // 
            this.chkTagTime.AutoSize = true;
            this.chkTagTime.Location = new System.Drawing.Point(100, 99);
            this.chkTagTime.Name = "chkTagTime";
            this.chkTagTime.Size = new System.Drawing.Size(74, 17);
            this.chkTagTime.TabIndex = 0;
            this.chkTagTime.Text = "标签时间";
            this.chkTagTime.UseVisualStyleBackColor = true;
            // 
            // chkPcValue
            // 
            this.chkPcValue.AutoSize = true;
            this.chkPcValue.Location = new System.Drawing.Point(10, 99);
            this.chkPcValue.Name = "chkPcValue";
            this.chkPcValue.Size = new System.Drawing.Size(70, 17);
            this.chkPcValue.TabIndex = 0;
            this.chkPcValue.Text = "PC Value";
            this.chkPcValue.UseVisualStyleBackColor = true;
            // 
            // chkPrivateData
            // 
            this.chkPrivateData.AutoSize = true;
            this.chkPrivateData.Location = new System.Drawing.Point(100, 67);
            this.chkPrivateData.Name = "chkPrivateData";
            this.chkPrivateData.Size = new System.Drawing.Size(74, 17);
            this.chkPrivateData.TabIndex = 0;
            this.chkPrivateData.Text = "私有数据";
            this.chkPrivateData.UseVisualStyleBackColor = true;
            // 
            // chkRssi
            // 
            this.chkRssi.AutoSize = true;
            this.chkRssi.Location = new System.Drawing.Point(10, 67);
            this.chkRssi.Name = "chkRssi";
            this.chkRssi.Size = new System.Drawing.Size(51, 17);
            this.chkRssi.TabIndex = 0;
            this.chkRssi.Text = "RSSI";
            this.chkRssi.UseVisualStyleBackColor = true;
            // 
            // chkAlarmState
            // 
            this.chkAlarmState.AutoSize = true;
            this.chkAlarmState.Location = new System.Drawing.Point(100, 36);
            this.chkAlarmState.Name = "chkAlarmState";
            this.chkAlarmState.Size = new System.Drawing.Size(74, 17);
            this.chkAlarmState.TabIndex = 0;
            this.chkAlarmState.Text = "报警状态";
            this.chkAlarmState.UseVisualStyleBackColor = true;
            // 
            // chkAntennaId
            // 
            this.chkAntennaId.AutoSize = true;
            this.chkAntennaId.Location = new System.Drawing.Point(10, 36);
            this.chkAntennaId.Name = "chkAntennaId";
            this.chkAntennaId.Size = new System.Drawing.Size(62, 17);
            this.chkAntennaId.TabIndex = 0;
            this.chkAntennaId.Text = "天线号";
            this.chkAntennaId.UseVisualStyleBackColor = true;
            // 
            // gbCommModeParam
            // 
            this.gbCommModeParam.Controls.Add(this.tbCommMode);
            this.gbCommModeParam.Controls.Add(this.btnDefaultCommMode);
            this.gbCommModeParam.Controls.Add(this.btnReadCommMode);
            this.gbCommModeParam.Controls.Add(this.btnSetCommMode);
            this.gbCommModeParam.Location = new System.Drawing.Point(406, 6);
            this.gbCommModeParam.Name = "gbCommModeParam";
            this.gbCommModeParam.Size = new System.Drawing.Size(443, 219);
            this.gbCommModeParam.TabIndex = 15;
            this.gbCommModeParam.TabStop = false;
            this.gbCommModeParam.Text = "通信方式";
            // 
            // tbCommMode
            // 
            this.tbCommMode.Controls.Add(this.tpRS232);
            this.tbCommMode.Controls.Add(this.tpRS485);
            this.tbCommMode.Controls.Add(this.tpWiegand);
            this.tbCommMode.Controls.Add(this.tpRJ45);
            this.tbCommMode.Controls.Add(this.tpWifi);
            this.tbCommMode.Controls.Add(this.tp3G_4G);
            this.tbCommMode.Location = new System.Drawing.Point(10, 17);
            this.tbCommMode.Name = "tbCommMode";
            this.tbCommMode.SelectedIndex = 0;
            this.tbCommMode.Size = new System.Drawing.Size(427, 152);
            this.tbCommMode.TabIndex = 97;
            // 
            // tpRS232
            // 
            this.tpRS232.Controls.Add(this.cbbBaud_Rate);
            this.tpRS232.Controls.Add(this.lbl_rate);
            this.tpRS232.Location = new System.Drawing.Point(4, 22);
            this.tpRS232.Name = "tpRS232";
            this.tpRS232.Padding = new System.Windows.Forms.Padding(3);
            this.tpRS232.Size = new System.Drawing.Size(419, 126);
            this.tpRS232.TabIndex = 2;
            this.tpRS232.Text = "串口";
            this.tpRS232.UseVisualStyleBackColor = true;
            // 
            // cbbBaud_Rate
            // 
            this.cbbBaud_Rate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBaud_Rate.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbBaud_Rate.FormattingEnabled = true;
            this.cbbBaud_Rate.Location = new System.Drawing.Point(93, 34);
            this.cbbBaud_Rate.Name = "cbbBaud_Rate";
            this.cbbBaud_Rate.Size = new System.Drawing.Size(95, 24);
            this.cbbBaud_Rate.TabIndex = 36;
            // 
            // lbl_rate
            // 
            this.lbl_rate.Location = new System.Drawing.Point(1, 32);
            this.lbl_rate.Name = "lbl_rate";
            this.lbl_rate.Size = new System.Drawing.Size(86, 29);
            this.lbl_rate.TabIndex = 37;
            this.lbl_rate.Text = "波特率";
            this.lbl_rate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tpRS485
            // 
            this.tpRS485.Controls.Add(this.cbbRS485BaudRate);
            this.tpRS485.Controls.Add(this.lblRS485BaudRate);
            this.tpRS485.Location = new System.Drawing.Point(4, 22);
            this.tpRS485.Name = "tpRS485";
            this.tpRS485.Padding = new System.Windows.Forms.Padding(3);
            this.tpRS485.Size = new System.Drawing.Size(419, 126);
            this.tpRS485.TabIndex = 0;
            this.tpRS485.Text = "RS485";
            this.tpRS485.UseVisualStyleBackColor = true;
            // 
            // cbbRS485BaudRate
            // 
            this.cbbRS485BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRS485BaudRate.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbRS485BaudRate.FormattingEnabled = true;
            this.cbbRS485BaudRate.Location = new System.Drawing.Point(93, 34);
            this.cbbRS485BaudRate.Name = "cbbRS485BaudRate";
            this.cbbRS485BaudRate.Size = new System.Drawing.Size(95, 24);
            this.cbbRS485BaudRate.TabIndex = 38;
            // 
            // lblRS485BaudRate
            // 
            this.lblRS485BaudRate.Location = new System.Drawing.Point(1, 32);
            this.lblRS485BaudRate.Name = "lblRS485BaudRate";
            this.lblRS485BaudRate.Size = new System.Drawing.Size(86, 29);
            this.lblRS485BaudRate.TabIndex = 39;
            this.lblRS485BaudRate.Text = "波特率";
            this.lblRS485BaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tpWiegand
            // 
            this.tpWiegand.Controls.Add(this.labPulseWidthUnit);
            this.tpWiegand.Controls.Add(this.labPulseWidth);
            this.tpWiegand.Controls.Add(this.labPulseCycleUnit);
            this.tpWiegand.Controls.Add(this.lblWigginsTakePlaceValue);
            this.tpWiegand.Controls.Add(this.tbPulseWidth);
            this.tpWiegand.Controls.Add(this.cbbWigginsTakePlaceValue);
            this.tpWiegand.Controls.Add(this.labWiegandProtocol);
            this.tpWiegand.Controls.Add(this.tbPulseCycle);
            this.tpWiegand.Controls.Add(this.labPulseCycle);
            this.tpWiegand.Controls.Add(this.cbbWiegandProtocol);
            this.tpWiegand.Location = new System.Drawing.Point(4, 22);
            this.tpWiegand.Name = "tpWiegand";
            this.tpWiegand.Padding = new System.Windows.Forms.Padding(3);
            this.tpWiegand.Size = new System.Drawing.Size(419, 126);
            this.tpWiegand.TabIndex = 1;
            this.tpWiegand.Text = "韦根";
            this.tpWiegand.UseVisualStyleBackColor = true;
            // 
            // labPulseWidthUnit
            // 
            this.labPulseWidthUnit.AutoEllipsis = true;
            this.labPulseWidthUnit.Location = new System.Drawing.Point(219, 9);
            this.labPulseWidthUnit.Name = "labPulseWidthUnit";
            this.labPulseWidthUnit.Size = new System.Drawing.Size(80, 29);
            this.labPulseWidthUnit.TabIndex = 25;
            this.labPulseWidthUnit.Text = "*10微秒";
            this.labPulseWidthUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labPulseWidth
            // 
            this.labPulseWidth.AutoEllipsis = true;
            this.labPulseWidth.Location = new System.Drawing.Point(9, 9);
            this.labPulseWidth.Name = "labPulseWidth";
            this.labPulseWidth.Size = new System.Drawing.Size(102, 29);
            this.labPulseWidth.TabIndex = 26;
            this.labPulseWidth.Text = "脉冲宽度";
            this.labPulseWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labPulseCycleUnit
            // 
            this.labPulseCycleUnit.AutoEllipsis = true;
            this.labPulseCycleUnit.Location = new System.Drawing.Point(221, 43);
            this.labPulseCycleUnit.Name = "labPulseCycleUnit";
            this.labPulseCycleUnit.Size = new System.Drawing.Size(78, 29);
            this.labPulseCycleUnit.TabIndex = 33;
            this.labPulseCycleUnit.Text = "*100微秒";
            this.labPulseCycleUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWigginsTakePlaceValue
            // 
            this.lblWigginsTakePlaceValue.AutoEllipsis = true;
            this.lblWigginsTakePlaceValue.Location = new System.Drawing.Point(219, 77);
            this.lblWigginsTakePlaceValue.Name = "lblWigginsTakePlaceValue";
            this.lblWigginsTakePlaceValue.Size = new System.Drawing.Size(95, 29);
            this.lblWigginsTakePlaceValue.TabIndex = 31;
            this.lblWigginsTakePlaceValue.Text = "韦根取位值";
            this.lblWigginsTakePlaceValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPulseWidth
            // 
            this.tbPulseWidth.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPulseWidth.Location = new System.Drawing.Point(115, 11);
            this.tbPulseWidth.Name = "tbPulseWidth";
            this.tbPulseWidth.Size = new System.Drawing.Size(98, 23);
            this.tbPulseWidth.TabIndex = 25;
            // 
            // cbbWigginsTakePlaceValue
            // 
            this.cbbWigginsTakePlaceValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbWigginsTakePlaceValue.Enabled = false;
            this.cbbWigginsTakePlaceValue.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbWigginsTakePlaceValue.FormattingEnabled = true;
            this.cbbWigginsTakePlaceValue.Location = new System.Drawing.Point(318, 78);
            this.cbbWigginsTakePlaceValue.Name = "cbbWigginsTakePlaceValue";
            this.cbbWigginsTakePlaceValue.Size = new System.Drawing.Size(98, 24);
            this.cbbWigginsTakePlaceValue.TabIndex = 30;
            // 
            // labWiegandProtocol
            // 
            this.labWiegandProtocol.AutoEllipsis = true;
            this.labWiegandProtocol.Location = new System.Drawing.Point(9, 75);
            this.labWiegandProtocol.Name = "labWiegandProtocol";
            this.labWiegandProtocol.Size = new System.Drawing.Size(102, 32);
            this.labWiegandProtocol.TabIndex = 31;
            this.labWiegandProtocol.Text = "韦根协议";
            this.labWiegandProtocol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPulseCycle
            // 
            this.tbPulseCycle.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPulseCycle.Location = new System.Drawing.Point(115, 46);
            this.tbPulseCycle.Name = "tbPulseCycle";
            this.tbPulseCycle.Size = new System.Drawing.Size(98, 23);
            this.tbPulseCycle.TabIndex = 32;
            // 
            // labPulseCycle
            // 
            this.labPulseCycle.AutoEllipsis = true;
            this.labPulseCycle.Location = new System.Drawing.Point(9, 43);
            this.labPulseCycle.Name = "labPulseCycle";
            this.labPulseCycle.Size = new System.Drawing.Size(102, 29);
            this.labPulseCycle.TabIndex = 29;
            this.labPulseCycle.Text = "脉冲周期";
            this.labPulseCycle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbWiegandProtocol
            // 
            this.cbbWiegandProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbWiegandProtocol.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbWiegandProtocol.FormattingEnabled = true;
            this.cbbWiegandProtocol.Location = new System.Drawing.Point(115, 78);
            this.cbbWiegandProtocol.Name = "cbbWiegandProtocol";
            this.cbbWiegandProtocol.Size = new System.Drawing.Size(98, 24);
            this.cbbWiegandProtocol.TabIndex = 30;
            // 
            // tpRJ45
            // 
            this.tpRJ45.Location = new System.Drawing.Point(4, 22);
            this.tpRJ45.Name = "tpRJ45";
            this.tpRJ45.Padding = new System.Windows.Forms.Padding(3);
            this.tpRJ45.Size = new System.Drawing.Size(419, 126);
            this.tpRJ45.TabIndex = 5;
            this.tpRJ45.Text = "RJ45";
            this.tpRJ45.UseVisualStyleBackColor = true;
            // 
            // tpWifi
            // 
            this.tpWifi.Location = new System.Drawing.Point(4, 22);
            this.tpWifi.Name = "tpWifi";
            this.tpWifi.Size = new System.Drawing.Size(419, 126);
            this.tpWifi.TabIndex = 6;
            this.tpWifi.Text = "WIFI";
            this.tpWifi.UseVisualStyleBackColor = true;
            // 
            // tp3G_4G
            // 
            this.tp3G_4G.Location = new System.Drawing.Point(4, 22);
            this.tp3G_4G.Name = "tp3G_4G";
            this.tp3G_4G.Size = new System.Drawing.Size(419, 126);
            this.tp3G_4G.TabIndex = 7;
            this.tp3G_4G.Text = "3G/4G";
            this.tp3G_4G.UseVisualStyleBackColor = true;
            // 
            // btnDefaultCommMode
            // 
            this.btnDefaultCommMode.Location = new System.Drawing.Point(179, 176);
            this.btnDefaultCommMode.Name = "btnDefaultCommMode";
            this.btnDefaultCommMode.Size = new System.Drawing.Size(82, 32);
            this.btnDefaultCommMode.TabIndex = 26;
            this.btnDefaultCommMode.Text = "默认参数";
            this.btnDefaultCommMode.UseVisualStyleBackColor = true;
            this.btnDefaultCommMode.Click += new System.EventHandler(this.btnDefaultCommMode_Click);
            // 
            // btnReadCommMode
            // 
            this.btnReadCommMode.Location = new System.Drawing.Point(267, 176);
            this.btnReadCommMode.Name = "btnReadCommMode";
            this.btnReadCommMode.Size = new System.Drawing.Size(82, 32);
            this.btnReadCommMode.TabIndex = 27;
            this.btnReadCommMode.Text = "读取";
            this.btnReadCommMode.UseVisualStyleBackColor = true;
            this.btnReadCommMode.Click += new System.EventHandler(this.btnReadCommMode_Click);
            // 
            // btnSetCommMode
            // 
            this.btnSetCommMode.Location = new System.Drawing.Point(355, 176);
            this.btnSetCommMode.Name = "btnSetCommMode";
            this.btnSetCommMode.Size = new System.Drawing.Size(82, 32);
            this.btnSetCommMode.TabIndex = 25;
            this.btnSetCommMode.Text = "设置";
            this.btnSetCommMode.UseVisualStyleBackColor = true;
            this.btnSetCommMode.Click += new System.EventHandler(this.btnSetCommMode_Click);
            // 
            // GopRelayControl
            // 
            this.GopRelayControl.Controls.Add(this.tbRelayMode);
            this.GopRelayControl.Controls.Add(this.btnSetRelay);
            this.GopRelayControl.Controls.Add(this.btnQueryRelay);
            this.GopRelayControl.Location = new System.Drawing.Point(406, 355);
            this.GopRelayControl.Name = "GopRelayControl";
            this.GopRelayControl.Size = new System.Drawing.Size(279, 184);
            this.GopRelayControl.TabIndex = 33;
            this.GopRelayControl.TabStop = false;
            this.GopRelayControl.Text = "继电器自动闭合使能";
            // 
            // tbRelayMode
            // 
            this.tbRelayMode.Controls.Add(this.tpPassivity);
            this.tbRelayMode.Controls.Add(this.tpInitiative);
            this.tbRelayMode.Location = new System.Drawing.Point(6, 22);
            this.tbRelayMode.Name = "tbRelayMode";
            this.tbRelayMode.SelectedIndex = 0;
            this.tbRelayMode.Size = new System.Drawing.Size(260, 119);
            this.tbRelayMode.TabIndex = 0;
            // 
            // tpPassivity
            // 
            this.tpPassivity.Controls.Add(this.panel2);
            this.tpPassivity.Controls.Add(this.panel1);
            this.tpPassivity.Location = new System.Drawing.Point(4, 22);
            this.tpPassivity.Name = "tpPassivity";
            this.tpPassivity.Padding = new System.Windows.Forms.Padding(3);
            this.tpPassivity.Size = new System.Drawing.Size(252, 93);
            this.tpPassivity.TabIndex = 1;
            this.tpPassivity.Text = "被动";
            this.tpPassivity.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbOpen2);
            this.panel2.Controls.Add(this.rbClose2);
            this.panel2.Location = new System.Drawing.Point(122, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 84);
            this.panel2.TabIndex = 101;
            // 
            // rbOpen2
            // 
            this.rbOpen2.AccessibleName = "rdo2";
            this.rbOpen2.AutoSize = true;
            this.rbOpen2.Location = new System.Drawing.Point(10, 16);
            this.rbOpen2.Name = "rbOpen2";
            this.rbOpen2.Size = new System.Drawing.Size(58, 17);
            this.rbOpen2.TabIndex = 0;
            this.rbOpen2.Text = "打开 2";
            this.rbOpen2.UseVisualStyleBackColor = true;
            // 
            // rbClose2
            // 
            this.rbClose2.AccessibleName = "rdo2";
            this.rbClose2.AutoSize = true;
            this.rbClose2.Checked = true;
            this.rbClose2.Location = new System.Drawing.Point(10, 54);
            this.rbClose2.Name = "rbClose2";
            this.rbClose2.Size = new System.Drawing.Size(58, 17);
            this.rbClose2.TabIndex = 1;
            this.rbClose2.TabStop = true;
            this.rbClose2.Text = "闭合 2";
            this.rbClose2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbClose1);
            this.panel1.Controls.Add(this.rbOpen1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 84);
            this.panel1.TabIndex = 101;
            // 
            // rbClose1
            // 
            this.rbClose1.AccessibleName = "rdo1";
            this.rbClose1.AutoSize = true;
            this.rbClose1.Checked = true;
            this.rbClose1.Location = new System.Drawing.Point(18, 54);
            this.rbClose1.Name = "rbClose1";
            this.rbClose1.Size = new System.Drawing.Size(58, 17);
            this.rbClose1.TabIndex = 1;
            this.rbClose1.TabStop = true;
            this.rbClose1.Text = "闭合 1";
            this.rbClose1.UseVisualStyleBackColor = true;
            // 
            // rbOpen1
            // 
            this.rbOpen1.AccessibleName = "rdo1";
            this.rbOpen1.AutoSize = true;
            this.rbOpen1.Location = new System.Drawing.Point(18, 16);
            this.rbOpen1.Name = "rbOpen1";
            this.rbOpen1.Size = new System.Drawing.Size(58, 17);
            this.rbOpen1.TabIndex = 0;
            this.rbOpen1.Text = "打开 1";
            this.rbOpen1.UseVisualStyleBackColor = true;
            // 
            // tpInitiative
            // 
            this.tpInitiative.Controls.Add(this.lblCloseTime);
            this.tpInitiative.Controls.Add(this.cbbRelayTime);
            this.tpInitiative.Location = new System.Drawing.Point(4, 22);
            this.tpInitiative.Name = "tpInitiative";
            this.tpInitiative.Padding = new System.Windows.Forms.Padding(3);
            this.tpInitiative.Size = new System.Drawing.Size(252, 93);
            this.tpInitiative.TabIndex = 0;
            this.tpInitiative.Text = "主动";
            this.tpInitiative.UseVisualStyleBackColor = true;
            // 
            // lblCloseTime
            // 
            this.lblCloseTime.Location = new System.Drawing.Point(3, 30);
            this.lblCloseTime.Name = "lblCloseTime";
            this.lblCloseTime.Size = new System.Drawing.Size(123, 29);
            this.lblCloseTime.TabIndex = 3;
            this.lblCloseTime.Text = "闭合时间";
            this.lblCloseTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbRelayTime
            // 
            this.cbbRelayTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRelayTime.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbRelayTime.FormattingEnabled = true;
            this.cbbRelayTime.Items.AddRange(new object[] {
            "1",
            "5",
            "10"});
            this.cbbRelayTime.Location = new System.Drawing.Point(132, 30);
            this.cbbRelayTime.Name = "cbbRelayTime";
            this.cbbRelayTime.Size = new System.Drawing.Size(114, 28);
            this.cbbRelayTime.TabIndex = 2;
            // 
            // btnSetRelay
            // 
            this.btnSetRelay.Location = new System.Drawing.Point(178, 143);
            this.btnSetRelay.Name = "btnSetRelay";
            this.btnSetRelay.Size = new System.Drawing.Size(88, 32);
            this.btnSetRelay.TabIndex = 11;
            this.btnSetRelay.Text = "设置";
            this.btnSetRelay.UseVisualStyleBackColor = true;
            this.btnSetRelay.Click += new System.EventHandler(this.btnSetRelayTime_Click);
            // 
            // btnQueryRelay
            // 
            this.btnQueryRelay.Location = new System.Drawing.Point(92, 143);
            this.btnQueryRelay.Name = "btnQueryRelay";
            this.btnQueryRelay.Size = new System.Drawing.Size(80, 32);
            this.btnQueryRelay.TabIndex = 9;
            this.btnQueryRelay.Text = "读取";
            this.btnQueryRelay.UseVisualStyleBackColor = true;
            this.btnQueryRelay.Click += new System.EventHandler(this.btnQueryRelay_Click);
            // 
            // gbWorkMode
            // 
            this.gbWorkMode.Controls.Add(this.btnUpdateAdjaDiscri);
            this.gbWorkMode.Controls.Add(this.btnReadAdjaDiscri);
            this.gbWorkMode.Controls.Add(this.tbWorkMode);
            this.gbWorkMode.Controls.Add(this.chkAjaDisc);
            this.gbWorkMode.Controls.Add(this.btnDefaultWorkMode);
            this.gbWorkMode.Controls.Add(this.btnReadWorkMode);
            this.gbWorkMode.Controls.Add(this.btnSetWorkMode);
            this.gbWorkMode.Controls.Add(this.tbNeighJudge);
            this.gbWorkMode.Location = new System.Drawing.Point(14, 6);
            this.gbWorkMode.Name = "gbWorkMode";
            this.gbWorkMode.Size = new System.Drawing.Size(386, 219);
            this.gbWorkMode.TabIndex = 13;
            this.gbWorkMode.TabStop = false;
            this.gbWorkMode.Text = "工作模式";
            // 
            // btnUpdateAdjaDiscri
            // 
            this.btnUpdateAdjaDiscri.Location = new System.Drawing.Point(292, 16);
            this.btnUpdateAdjaDiscri.Name = "btnUpdateAdjaDiscri";
            this.btnUpdateAdjaDiscri.Size = new System.Drawing.Size(82, 32);
            this.btnUpdateAdjaDiscri.TabIndex = 99;
            this.btnUpdateAdjaDiscri.Text = "Set";
            this.btnUpdateAdjaDiscri.UseVisualStyleBackColor = true;
            this.btnUpdateAdjaDiscri.Click += new System.EventHandler(this.btnUpdateAdjaDiscri_Click);
            // 
            // btnReadAdjaDiscri
            // 
            this.btnReadAdjaDiscri.Location = new System.Drawing.Point(204, 16);
            this.btnReadAdjaDiscri.Name = "btnReadAdjaDiscri";
            this.btnReadAdjaDiscri.Size = new System.Drawing.Size(82, 32);
            this.btnReadAdjaDiscri.TabIndex = 98;
            this.btnReadAdjaDiscri.Text = "Read";
            this.btnReadAdjaDiscri.UseVisualStyleBackColor = true;
            this.btnReadAdjaDiscri.Click += new System.EventHandler(this.btnReadAdjaDiscri_Click);
            // 
            // tbWorkMode
            // 
            this.tbWorkMode.Controls.Add(this.tpMaster);
            this.tbWorkMode.Controls.Add(this.tpTiming);
            this.tbWorkMode.Controls.Add(this.tpTrigger);
            this.tbWorkMode.Location = new System.Drawing.Point(22, 51);
            this.tbWorkMode.Name = "tbWorkMode";
            this.tbWorkMode.SelectedIndex = 0;
            this.tbWorkMode.Size = new System.Drawing.Size(352, 118);
            this.tbWorkMode.TabIndex = 97;
            this.tbWorkMode.SelectedIndexChanged += new System.EventHandler(this.tbWorkMode_SelectedIndexChanged);
            // 
            // tpMaster
            // 
            this.tpMaster.Location = new System.Drawing.Point(4, 22);
            this.tpMaster.Name = "tpMaster";
            this.tpMaster.Padding = new System.Windows.Forms.Padding(3);
            this.tpMaster.Size = new System.Drawing.Size(344, 92);
            this.tpMaster.TabIndex = 0;
            this.tpMaster.Text = "主从模式";
            this.tpMaster.UseVisualStyleBackColor = true;
            // 
            // tpTiming
            // 
            this.tpTiming.Location = new System.Drawing.Point(4, 22);
            this.tpTiming.Name = "tpTiming";
            this.tpTiming.Padding = new System.Windows.Forms.Padding(3);
            this.tpTiming.Size = new System.Drawing.Size(344, 92);
            this.tpTiming.TabIndex = 1;
            this.tpTiming.Text = "定时模式";
            this.tpTiming.UseVisualStyleBackColor = true;
            // 
            // tpTrigger
            // 
            this.tpTrigger.Controls.Add(this.labDelayUnit);
            this.tpTrigger.Controls.Add(this.labTrigParam);
            this.tpTrigger.Controls.Add(this.tbDelay);
            this.tpTrigger.Location = new System.Drawing.Point(4, 22);
            this.tpTrigger.Name = "tpTrigger";
            this.tpTrigger.Padding = new System.Windows.Forms.Padding(3);
            this.tpTrigger.Size = new System.Drawing.Size(344, 92);
            this.tpTrigger.TabIndex = 2;
            this.tpTrigger.Text = "触发模式";
            this.tpTrigger.UseVisualStyleBackColor = true;
            // 
            // labDelayUnit
            // 
            this.labDelayUnit.Location = new System.Drawing.Point(267, 24);
            this.labDelayUnit.Name = "labDelayUnit";
            this.labDelayUnit.Size = new System.Drawing.Size(45, 29);
            this.labDelayUnit.TabIndex = 22;
            this.labDelayUnit.Text = "秒";
            this.labDelayUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labTrigParam
            // 
            this.labTrigParam.AutoEllipsis = true;
            this.labTrigParam.Location = new System.Drawing.Point(55, 24);
            this.labTrigParam.Name = "labTrigParam";
            this.labTrigParam.Size = new System.Drawing.Size(78, 29);
            this.labTrigParam.TabIndex = 16;
            this.labTrigParam.Text = "触发延时";
            this.labTrigParam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbDelay
            // 
            this.tbDelay.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbDelay.Location = new System.Drawing.Point(139, 24);
            this.tbDelay.Name = "tbDelay";
            this.tbDelay.Size = new System.Drawing.Size(121, 26);
            this.tbDelay.TabIndex = 20;
            // 
            // chkAjaDisc
            // 
            this.chkAjaDisc.Location = new System.Drawing.Point(6, 21);
            this.chkAjaDisc.Name = "chkAjaDisc";
            this.chkAjaDisc.Size = new System.Drawing.Size(106, 24);
            this.chkAjaDisc.TabIndex = 24;
            this.chkAjaDisc.Text = "相邻判定(0-255s)";
            this.chkAjaDisc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDefaultWorkMode
            // 
            this.btnDefaultWorkMode.Location = new System.Drawing.Point(104, 176);
            this.btnDefaultWorkMode.Name = "btnDefaultWorkMode";
            this.btnDefaultWorkMode.Size = new System.Drawing.Size(82, 32);
            this.btnDefaultWorkMode.TabIndex = 15;
            this.btnDefaultWorkMode.Text = "默认参数";
            this.btnDefaultWorkMode.UseVisualStyleBackColor = true;
            this.btnDefaultWorkMode.Click += new System.EventHandler(this.btnDefaultWorkMode_Click);
            // 
            // btnReadWorkMode
            // 
            this.btnReadWorkMode.Location = new System.Drawing.Point(198, 176);
            this.btnReadWorkMode.Name = "btnReadWorkMode";
            this.btnReadWorkMode.Size = new System.Drawing.Size(82, 32);
            this.btnReadWorkMode.TabIndex = 23;
            this.btnReadWorkMode.Text = "读取";
            this.btnReadWorkMode.UseVisualStyleBackColor = true;
            this.btnReadWorkMode.Click += new System.EventHandler(this.btnReadWorkMode_Click);
            // 
            // btnSetWorkMode
            // 
            this.btnSetWorkMode.Location = new System.Drawing.Point(292, 176);
            this.btnSetWorkMode.Name = "btnSetWorkMode";
            this.btnSetWorkMode.Size = new System.Drawing.Size(82, 32);
            this.btnSetWorkMode.TabIndex = 12;
            this.btnSetWorkMode.Text = "设置";
            this.btnSetWorkMode.UseVisualStyleBackColor = true;
            this.btnSetWorkMode.Click += new System.EventHandler(this.btnSetWorkMode_Click);
            // 
            // tbNeighJudge
            // 
            this.tbNeighJudge.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbNeighJudge.Location = new System.Drawing.Point(124, 21);
            this.tbNeighJudge.Name = "tbNeighJudge";
            this.tbNeighJudge.Size = new System.Drawing.Size(74, 23);
            this.tbNeighJudge.TabIndex = 1;
            // 
            // tpSetCommParam
            // 
            this.tpSetCommParam.Controls.Add(this.gbSPParams);
            this.tpSetCommParam.Controls.Add(this.gbNetParams);
            this.tpSetCommParam.Controls.Add(this.btnSetParams);
            this.tpSetCommParam.Controls.Add(this.btnDefaultParams);
            this.tpSetCommParam.Controls.Add(this.btnModifyDev);
            this.tpSetCommParam.Controls.Add(this.btnSearchDev);
            this.tpSetCommParam.Controls.Add(this.lvZl);
            this.tpSetCommParam.Location = new System.Drawing.Point(4, 22);
            this.tpSetCommParam.Name = "tpSetCommParam";
            this.tpSetCommParam.Padding = new System.Windows.Forms.Padding(3);
            this.tpSetCommParam.Size = new System.Drawing.Size(864, 680);
            this.tpSetCommParam.TabIndex = 2;
            this.tpSetCommParam.Text = "设置通信参数";
            this.tpSetCommParam.UseVisualStyleBackColor = true;
            // 
            // gbSPParams
            // 
            this.gbSPParams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSPParams.Controls.Add(this.labDataBits);
            this.gbSPParams.Controls.Add(this.labCheckBits);
            this.gbSPParams.Controls.Add(this.labBaudRate);
            this.gbSPParams.Controls.Add(this.comboBoxBaudRate);
            this.gbSPParams.Controls.Add(this.comboBoxCheckBits);
            this.gbSPParams.Controls.Add(this.comboBoxDataBits);
            this.gbSPParams.Location = new System.Drawing.Point(520, 470);
            this.gbSPParams.Name = "gbSPParams";
            this.gbSPParams.Size = new System.Drawing.Size(320, 112);
            this.gbSPParams.TabIndex = 28;
            this.gbSPParams.TabStop = false;
            this.gbSPParams.Text = "串口参数";
            // 
            // labDataBits
            // 
            this.labDataBits.AutoSize = true;
            this.labDataBits.Location = new System.Drawing.Point(17, 76);
            this.labDataBits.Name = "labDataBits";
            this.labDataBits.Size = new System.Drawing.Size(43, 13);
            this.labDataBits.TabIndex = 27;
            this.labDataBits.Text = "数据位";
            // 
            // labCheckBits
            // 
            this.labCheckBits.AutoSize = true;
            this.labCheckBits.Location = new System.Drawing.Point(171, 28);
            this.labCheckBits.Name = "labCheckBits";
            this.labCheckBits.Size = new System.Drawing.Size(43, 13);
            this.labCheckBits.TabIndex = 26;
            this.labCheckBits.Text = "校验位";
            // 
            // labBaudRate
            // 
            this.labBaudRate.AutoSize = true;
            this.labBaudRate.Location = new System.Drawing.Point(14, 28);
            this.labBaudRate.Name = "labBaudRate";
            this.labBaudRate.Size = new System.Drawing.Size(43, 13);
            this.labBaudRate.TabIndex = 25;
            this.labBaudRate.Text = "波特率";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaudRate.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(85, 22);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(80, 21);
            this.comboBoxBaudRate.TabIndex = 7;
            // 
            // comboBoxCheckBits
            // 
            this.comboBoxCheckBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCheckBits.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxCheckBits.FormattingEnabled = true;
            this.comboBoxCheckBits.Location = new System.Drawing.Point(234, 22);
            this.comboBoxCheckBits.Name = "comboBoxCheckBits";
            this.comboBoxCheckBits.Size = new System.Drawing.Size(80, 21);
            this.comboBoxCheckBits.TabIndex = 6;
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataBits.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Location = new System.Drawing.Point(85, 68);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(80, 24);
            this.comboBoxDataBits.TabIndex = 5;
            // 
            // gbNetParams
            // 
            this.gbNetParams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNetParams.Controls.Add(this.cbbDestIP);
            this.gbNetParams.Controls.Add(this.labPromotion);
            this.gbNetParams.Controls.Add(this.labDestPort);
            this.gbNetParams.Controls.Add(this.labDestIP);
            this.gbNetParams.Controls.Add(this.labGateway);
            this.gbNetParams.Controls.Add(this.labPort);
            this.gbNetParams.Controls.Add(this.labMask);
            this.gbNetParams.Controls.Add(this.labIPAdd);
            this.gbNetParams.Controls.Add(this.labIPMode);
            this.gbNetParams.Controls.Add(this.labNetMode);
            this.gbNetParams.Controls.Add(this.textBoxDestPort);
            this.gbNetParams.Controls.Add(this.tbDestIP);
            this.gbNetParams.Controls.Add(this.textBoxGateway);
            this.gbNetParams.Controls.Add(this.textBoxPortNo);
            this.gbNetParams.Controls.Add(this.textBoxNetMask);
            this.gbNetParams.Controls.Add(this.textBoxIPAdd);
            this.gbNetParams.Controls.Add(this.comboBoxIPMode);
            this.gbNetParams.Controls.Add(this.comboBoxNetMode);
            this.gbNetParams.Location = new System.Drawing.Point(520, 16);
            this.gbNetParams.Name = "gbNetParams";
            this.gbNetParams.Size = new System.Drawing.Size(320, 405);
            this.gbNetParams.TabIndex = 25;
            this.gbNetParams.TabStop = false;
            this.gbNetParams.Text = "网络参数";
            // 
            // cbbDestIP
            // 
            this.cbbDestIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbDestIP.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbDestIP.FormattingEnabled = true;
            this.cbbDestIP.Location = new System.Drawing.Point(162, 312);
            this.cbbDestIP.Name = "cbbDestIP";
            this.cbbDestIP.Size = new System.Drawing.Size(142, 24);
            this.cbbDestIP.TabIndex = 42;
            // 
            // labPromotion
            // 
            this.labPromotion.AutoSize = true;
            this.labPromotion.Location = new System.Drawing.Point(46, 281);
            this.labPromotion.Name = "labPromotion";
            this.labPromotion.Size = new System.Drawing.Size(177, 13);
            this.labPromotion.TabIndex = 24;
            this.labPromotion.Text = "以下设置仅适用于TCP Client模式";
            // 
            // labDestPort
            // 
            this.labDestPort.AutoSize = true;
            this.labDestPort.Location = new System.Drawing.Point(48, 358);
            this.labDestPort.Name = "labDestPort";
            this.labDestPort.Size = new System.Drawing.Size(55, 13);
            this.labDestPort.TabIndex = 23;
            this.labDestPort.Text = "目的端口";
            // 
            // labDestIP
            // 
            this.labDestIP.Location = new System.Drawing.Point(16, 311);
            this.labDestIP.Name = "labDestIP";
            this.labDestIP.Size = new System.Drawing.Size(140, 29);
            this.labDestIP.TabIndex = 22;
            this.labDestIP.Text = "目的IP(单击获本机IP)";
            this.labDestIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labDestIP.Click += new System.EventHandler(this.labDestIP_Click);
            // 
            // labGateway
            // 
            this.labGateway.AutoSize = true;
            this.labGateway.Location = new System.Drawing.Point(48, 237);
            this.labGateway.Name = "labGateway";
            this.labGateway.Size = new System.Drawing.Size(31, 13);
            this.labGateway.TabIndex = 21;
            this.labGateway.Text = "网关";
            // 
            // labPort
            // 
            this.labPort.AutoSize = true;
            this.labPort.Location = new System.Drawing.Point(48, 193);
            this.labPort.Name = "labPort";
            this.labPort.Size = new System.Drawing.Size(43, 13);
            this.labPort.TabIndex = 20;
            this.labPort.Text = "端口号";
            // 
            // labMask
            // 
            this.labMask.AutoSize = true;
            this.labMask.Location = new System.Drawing.Point(48, 154);
            this.labMask.Name = "labMask";
            this.labMask.Size = new System.Drawing.Size(55, 13);
            this.labMask.TabIndex = 19;
            this.labMask.Text = "子网掩码";
            // 
            // labIPAdd
            // 
            this.labIPAdd.AutoSize = true;
            this.labIPAdd.Location = new System.Drawing.Point(48, 109);
            this.labIPAdd.Name = "labIPAdd";
            this.labIPAdd.Size = new System.Drawing.Size(41, 13);
            this.labIPAdd.TabIndex = 18;
            this.labIPAdd.Text = "IP地址";
            // 
            // labIPMode
            // 
            this.labIPMode.AutoSize = true;
            this.labIPMode.Location = new System.Drawing.Point(48, 72);
            this.labIPMode.Name = "labIPMode";
            this.labIPMode.Size = new System.Drawing.Size(41, 13);
            this.labIPMode.TabIndex = 17;
            this.labIPMode.Text = "IP模式";
            // 
            // labNetMode
            // 
            this.labNetMode.AutoSize = true;
            this.labNetMode.Location = new System.Drawing.Point(48, 34);
            this.labNetMode.Name = "labNetMode";
            this.labNetMode.Size = new System.Drawing.Size(55, 13);
            this.labNetMode.TabIndex = 16;
            this.labNetMode.Text = "工作模式";
            // 
            // textBoxDestPort
            // 
            this.textBoxDestPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDestPort.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxDestPort.Location = new System.Drawing.Point(162, 354);
            this.textBoxDestPort.Name = "textBoxDestPort";
            this.textBoxDestPort.Size = new System.Drawing.Size(142, 26);
            this.textBoxDestPort.TabIndex = 13;
            // 
            // tbDestIP
            // 
            this.tbDestIP.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbDestIP.Location = new System.Drawing.Point(162, 312);
            this.tbDestIP.Name = "tbDestIP";
            this.tbDestIP.Size = new System.Drawing.Size(142, 26);
            this.tbDestIP.TabIndex = 12;
            this.tbDestIP.Visible = false;
            // 
            // textBoxGateway
            // 
            this.textBoxGateway.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGateway.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxGateway.Location = new System.Drawing.Point(162, 233);
            this.textBoxGateway.Name = "textBoxGateway";
            this.textBoxGateway.Size = new System.Drawing.Size(142, 26);
            this.textBoxGateway.TabIndex = 11;
            // 
            // textBoxPortNo
            // 
            this.textBoxPortNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPortNo.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPortNo.Location = new System.Drawing.Point(162, 190);
            this.textBoxPortNo.Name = "textBoxPortNo";
            this.textBoxPortNo.Size = new System.Drawing.Size(142, 26);
            this.textBoxPortNo.TabIndex = 10;
            // 
            // textBoxNetMask
            // 
            this.textBoxNetMask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNetMask.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxNetMask.Location = new System.Drawing.Point(162, 150);
            this.textBoxNetMask.Name = "textBoxNetMask";
            this.textBoxNetMask.Size = new System.Drawing.Size(142, 26);
            this.textBoxNetMask.TabIndex = 9;
            // 
            // textBoxIPAdd
            // 
            this.textBoxIPAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIPAdd.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxIPAdd.Location = new System.Drawing.Point(162, 106);
            this.textBoxIPAdd.Name = "textBoxIPAdd";
            this.textBoxIPAdd.Size = new System.Drawing.Size(142, 26);
            this.textBoxIPAdd.TabIndex = 8;
            // 
            // comboBoxIPMode
            // 
            this.comboBoxIPMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxIPMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIPMode.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxIPMode.FormattingEnabled = true;
            this.comboBoxIPMode.Location = new System.Drawing.Point(163, 68);
            this.comboBoxIPMode.Name = "comboBoxIPMode";
            this.comboBoxIPMode.Size = new System.Drawing.Size(142, 24);
            this.comboBoxIPMode.TabIndex = 4;
            // 
            // comboBoxNetMode
            // 
            this.comboBoxNetMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxNetMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNetMode.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxNetMode.FormattingEnabled = true;
            this.comboBoxNetMode.Location = new System.Drawing.Point(162, 30);
            this.comboBoxNetMode.Name = "comboBoxNetMode";
            this.comboBoxNetMode.Size = new System.Drawing.Size(142, 24);
            this.comboBoxNetMode.TabIndex = 3;
            // 
            // btnSetParams
            // 
            this.btnSetParams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetParams.Location = new System.Drawing.Point(724, 429);
            this.btnSetParams.Name = "btnSetParams";
            this.btnSetParams.Size = new System.Drawing.Size(100, 38);
            this.btnSetParams.TabIndex = 15;
            this.btnSetParams.Text = "设置参数";
            this.btnSetParams.UseVisualStyleBackColor = true;
            this.btnSetParams.Click += new System.EventHandler(this.btnSetParams_Click);
            // 
            // btnDefaultParams
            // 
            this.btnDefaultParams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefaultParams.Location = new System.Drawing.Point(570, 430);
            this.btnDefaultParams.Name = "btnDefaultParams";
            this.btnDefaultParams.Size = new System.Drawing.Size(100, 38);
            this.btnDefaultParams.TabIndex = 14;
            this.btnDefaultParams.Text = "默认参数";
            this.btnDefaultParams.UseVisualStyleBackColor = true;
            this.btnDefaultParams.Click += new System.EventHandler(this.btnDefaultParams_Click);
            // 
            // btnModifyDev
            // 
            this.btnModifyDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifyDev.Location = new System.Drawing.Point(289, 601);
            this.btnModifyDev.Name = "btnModifyDev";
            this.btnModifyDev.Size = new System.Drawing.Size(100, 38);
            this.btnModifyDev.TabIndex = 2;
            this.btnModifyDev.Text = "编辑设备";
            this.btnModifyDev.UseVisualStyleBackColor = true;
            this.btnModifyDev.Visible = false;
            this.btnModifyDev.Click += new System.EventHandler(this.btnModifyDev_Click);
            // 
            // btnSearchDev
            // 
            this.btnSearchDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchDev.Location = new System.Drawing.Point(395, 600);
            this.btnSearchDev.Name = "btnSearchDev";
            this.btnSearchDev.Size = new System.Drawing.Size(100, 38);
            this.btnSearchDev.TabIndex = 1;
            this.btnSearchDev.Text = "搜索设备";
            this.btnSearchDev.UseVisualStyleBackColor = true;
            this.btnSearchDev.Click += new System.EventHandler(this.btnSearchDev_Click);
            // 
            // lvZl
            // 
            this.lvZl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvZl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNo,
            this.columnHeaderIPAdd,
            this.columnHeaderPort,
            this.columnHeaderMAC});
            this.lvZl.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvZl.FullRowSelect = true;
            this.lvZl.GridLines = true;
            this.lvZl.HideSelection = false;
            this.lvZl.Location = new System.Drawing.Point(6, 28);
            this.lvZl.Name = "lvZl";
            this.lvZl.Size = new System.Drawing.Size(508, 559);
            this.lvZl.TabIndex = 0;
            this.lvZl.UseCompatibleStateImageBehavior = false;
            this.lvZl.View = System.Windows.Forms.View.Details;
            this.lvZl.ItemActivate += new System.EventHandler(this.listViewDev_ItemActivate);
            this.lvZl.SelectedIndexChanged += new System.EventHandler(this.lvZl_SelectedIndexChanged);
            // 
            // columnHeaderNo
            // 
            this.columnHeaderNo.Text = "序号";
            this.columnHeaderNo.Width = 50;
            // 
            // columnHeaderIPAdd
            // 
            this.columnHeaderIPAdd.Text = "IP地址";
            this.columnHeaderIPAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderIPAdd.Width = 136;
            // 
            // columnHeaderPort
            // 
            this.columnHeaderPort.Text = "端口";
            this.columnHeaderPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeaderMAC
            // 
            this.columnHeaderMAC.Text = "MAC地址";
            this.columnHeaderMAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderMAC.Width = 130;
            // 
            // tpTagAccess
            // 
            this.tpTagAccess.Controls.Add(this.gbTagAuth);
            this.tpTagAccess.Controls.Add(this.gbTagType);
            this.tpTagAccess.Controls.Add(this.gbSpecifiedAddressAndLength);
            this.tpTagAccess.Controls.Add(this.gbKillTag);
            this.tpTagAccess.Controls.Add(this.gbTagLockAndUnlock);
            this.tpTagAccess.Controls.Add(this.gbFastWrite);
            this.tpTagAccess.Controls.Add(this.gbRWData);
            this.tpTagAccess.Controls.Add(this.gbBeepControl);
            this.tpTagAccess.Location = new System.Drawing.Point(4, 22);
            this.tpTagAccess.Name = "tpTagAccess";
            this.tpTagAccess.Padding = new System.Windows.Forms.Padding(3);
            this.tpTagAccess.Size = new System.Drawing.Size(864, 680);
            this.tpTagAccess.TabIndex = 1;
            this.tpTagAccess.Text = "标签访问";
            this.tpTagAccess.UseVisualStyleBackColor = true;
            // 
            // gbTagAuth
            // 
            this.gbTagAuth.Controls.Add(this.btnQueryAuthorize);
            this.gbTagAuth.Controls.Add(this.btnModifyAuthorize);
            this.gbTagAuth.Controls.Add(this.btnTagAuthorize);
            this.gbTagAuth.Controls.Add(this.tbNewAuthorizePwd);
            this.gbTagAuth.Controls.Add(this.tbOldAuthorizePwd);
            this.gbTagAuth.Controls.Add(this.labNewAuthPwd);
            this.gbTagAuth.Controls.Add(this.labAuthPwd);
            this.gbTagAuth.Location = new System.Drawing.Point(675, 157);
            this.gbTagAuth.Name = "gbTagAuth";
            this.gbTagAuth.Size = new System.Drawing.Size(174, 260);
            this.gbTagAuth.TabIndex = 47;
            this.gbTagAuth.TabStop = false;
            this.gbTagAuth.Text = "标签授权";
            // 
            // btnQueryAuthorize
            // 
            this.btnQueryAuthorize.Location = new System.Drawing.Point(8, 138);
            this.btnQueryAuthorize.Name = "btnQueryAuthorize";
            this.btnQueryAuthorize.Size = new System.Drawing.Size(160, 32);
            this.btnQueryAuthorize.TabIndex = 3;
            this.btnQueryAuthorize.Text = "查询授权";
            this.btnQueryAuthorize.UseVisualStyleBackColor = true;
            this.btnQueryAuthorize.Click += new System.EventHandler(this.btnQueryAuthorize_Click);
            // 
            // btnModifyAuthorize
            // 
            this.btnModifyAuthorize.Location = new System.Drawing.Point(8, 179);
            this.btnModifyAuthorize.Name = "btnModifyAuthorize";
            this.btnModifyAuthorize.Size = new System.Drawing.Size(160, 32);
            this.btnModifyAuthorize.TabIndex = 3;
            this.btnModifyAuthorize.Text = "修改授权";
            this.btnModifyAuthorize.UseVisualStyleBackColor = true;
            this.btnModifyAuthorize.Click += new System.EventHandler(this.btnModifyAuthorize_Click);
            // 
            // btnTagAuthorize
            // 
            this.btnTagAuthorize.Location = new System.Drawing.Point(8, 218);
            this.btnTagAuthorize.Name = "btnTagAuthorize";
            this.btnTagAuthorize.Size = new System.Drawing.Size(160, 32);
            this.btnTagAuthorize.TabIndex = 3;
            this.btnTagAuthorize.Text = "标签授权";
            this.btnTagAuthorize.UseVisualStyleBackColor = true;
            this.btnTagAuthorize.Click += new System.EventHandler(this.btnTagAuthorize_Click);
            // 
            // tbNewAuthorizePwd
            // 
            this.tbNewAuthorizePwd.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbNewAuthorizePwd.Location = new System.Drawing.Point(8, 101);
            this.tbNewAuthorizePwd.Name = "tbNewAuthorizePwd";
            this.tbNewAuthorizePwd.Size = new System.Drawing.Size(160, 30);
            this.tbNewAuthorizePwd.TabIndex = 2;
            // 
            // tbOldAuthorizePwd
            // 
            this.tbOldAuthorizePwd.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbOldAuthorizePwd.Location = new System.Drawing.Point(8, 43);
            this.tbOldAuthorizePwd.Name = "tbOldAuthorizePwd";
            this.tbOldAuthorizePwd.Size = new System.Drawing.Size(160, 30);
            this.tbOldAuthorizePwd.TabIndex = 2;
            // 
            // labNewAuthPwd
            // 
            this.labNewAuthPwd.AutoSize = true;
            this.labNewAuthPwd.Location = new System.Drawing.Point(6, 82);
            this.labNewAuthPwd.Name = "labNewAuthPwd";
            this.labNewAuthPwd.Size = new System.Drawing.Size(52, 13);
            this.labNewAuthPwd.TabIndex = 1;
            this.labNewAuthPwd.Text = "新授权码";
            // 
            // labAuthPwd
            // 
            this.labAuthPwd.AutoSize = true;
            this.labAuthPwd.Location = new System.Drawing.Point(6, 23);
            this.labAuthPwd.Name = "labAuthPwd";
            this.labAuthPwd.Size = new System.Drawing.Size(52, 13);
            this.labAuthPwd.TabIndex = 0;
            this.labAuthPwd.Text = "原授权码";
            // 
            // gbTagType
            // 
            this.gbTagType.Controls.Add(this.lblTagType);
            this.gbTagType.Controls.Add(this.btnTagTypeSet);
            this.gbTagType.Controls.Add(this.btnTagTypeRead);
            this.gbTagType.Controls.Add(this.cbbTagType);
            this.gbTagType.Location = new System.Drawing.Point(553, 424);
            this.gbTagType.Name = "gbTagType";
            this.gbTagType.Size = new System.Drawing.Size(299, 126);
            this.gbTagType.TabIndex = 46;
            this.gbTagType.TabStop = false;
            this.gbTagType.Text = "标签类型";
            // 
            // lblTagType
            // 
            this.lblTagType.AutoEllipsis = true;
            this.lblTagType.Location = new System.Drawing.Point(3, 27);
            this.lblTagType.Name = "lblTagType";
            this.lblTagType.Size = new System.Drawing.Size(97, 29);
            this.lblTagType.TabIndex = 27;
            this.lblTagType.Text = "标签类型";
            this.lblTagType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnTagTypeSet
            // 
            this.btnTagTypeSet.Location = new System.Drawing.Point(196, 76);
            this.btnTagTypeSet.Name = "btnTagTypeSet";
            this.btnTagTypeSet.Size = new System.Drawing.Size(83, 32);
            this.btnTagTypeSet.TabIndex = 21;
            this.btnTagTypeSet.Text = "设置";
            this.btnTagTypeSet.UseVisualStyleBackColor = true;
            this.btnTagTypeSet.Click += new System.EventHandler(this.btnTagTypeSet_Click);
            // 
            // btnTagTypeRead
            // 
            this.btnTagTypeRead.Location = new System.Drawing.Point(111, 76);
            this.btnTagTypeRead.Name = "btnTagTypeRead";
            this.btnTagTypeRead.Size = new System.Drawing.Size(83, 32);
            this.btnTagTypeRead.TabIndex = 21;
            this.btnTagTypeRead.Text = "读取";
            this.btnTagTypeRead.UseVisualStyleBackColor = true;
            this.btnTagTypeRead.Click += new System.EventHandler(this.btnTagTypeRead_Click);
            // 
            // cbbTagType
            // 
            this.cbbTagType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTagType.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbTagType.FormattingEnabled = true;
            this.cbbTagType.Items.AddRange(new object[] {
            "常规标签",
            "加密标签",
            "悦和LTU31测温标签",
            "悦和LTU32测温标签"});
            this.cbbTagType.Location = new System.Drawing.Point(111, 26);
            this.cbbTagType.Name = "cbbTagType";
            this.cbbTagType.Size = new System.Drawing.Size(179, 28);
            this.cbbTagType.TabIndex = 3;
            // 
            // gbSpecifiedAddressAndLength
            // 
            this.gbSpecifiedAddressAndLength.Controls.Add(this.chbEnable);
            this.gbSpecifiedAddressAndLength.Controls.Add(this.btnSpecifiedAddressAndLengthSet);
            this.gbSpecifiedAddressAndLength.Controls.Add(this.btnSpecifiedAddressAndLengthRead);
            this.gbSpecifiedAddressAndLength.Controls.Add(this.lblTagArea);
            this.gbSpecifiedAddressAndLength.Controls.Add(this.cbbTagArea);
            this.gbSpecifiedAddressAndLength.Controls.Add(this.labLength2);
            this.gbSpecifiedAddressAndLength.Controls.Add(this.labStartAdd2);
            this.gbSpecifiedAddressAndLength.Controls.Add(this.cbbStartAddress2);
            this.gbSpecifiedAddressAndLength.Controls.Add(this.cbbLength2);
            this.gbSpecifiedAddressAndLength.Location = new System.Drawing.Point(330, 556);
            this.gbSpecifiedAddressAndLength.Name = "gbSpecifiedAddressAndLength";
            this.gbSpecifiedAddressAndLength.Size = new System.Drawing.Size(522, 116);
            this.gbSpecifiedAddressAndLength.TabIndex = 45;
            this.gbSpecifiedAddressAndLength.TabStop = false;
            this.gbSpecifiedAddressAndLength.Text = "指定标签区域起始地址和长度";
            // 
            // chbEnable
            // 
            this.chbEnable.AutoSize = true;
            this.chbEnable.Location = new System.Drawing.Point(26, 69);
            this.chbEnable.Name = "chbEnable";
            this.chbEnable.Size = new System.Drawing.Size(74, 17);
            this.chbEnable.TabIndex = 25;
            this.chbEnable.Text = "是否启用";
            this.chbEnable.UseVisualStyleBackColor = true;
            // 
            // btnSpecifiedAddressAndLengthSet
            // 
            this.btnSpecifiedAddressAndLengthSet.Location = new System.Drawing.Point(419, 69);
            this.btnSpecifiedAddressAndLengthSet.Name = "btnSpecifiedAddressAndLengthSet";
            this.btnSpecifiedAddressAndLengthSet.Size = new System.Drawing.Size(83, 32);
            this.btnSpecifiedAddressAndLengthSet.TabIndex = 21;
            this.btnSpecifiedAddressAndLengthSet.Text = "设置";
            this.btnSpecifiedAddressAndLengthSet.UseVisualStyleBackColor = true;
            this.btnSpecifiedAddressAndLengthSet.Click += new System.EventHandler(this.btnSpecifiedAddressAndLengthSet_Click);
            // 
            // btnSpecifiedAddressAndLengthRead
            // 
            this.btnSpecifiedAddressAndLengthRead.Location = new System.Drawing.Point(314, 69);
            this.btnSpecifiedAddressAndLengthRead.Name = "btnSpecifiedAddressAndLengthRead";
            this.btnSpecifiedAddressAndLengthRead.Size = new System.Drawing.Size(83, 32);
            this.btnSpecifiedAddressAndLengthRead.TabIndex = 21;
            this.btnSpecifiedAddressAndLengthRead.Text = "读取";
            this.btnSpecifiedAddressAndLengthRead.UseVisualStyleBackColor = true;
            this.btnSpecifiedAddressAndLengthRead.Click += new System.EventHandler(this.btnSpecifiedAddressAndLengthRead_Click);
            // 
            // lblTagArea
            // 
            this.lblTagArea.AutoEllipsis = true;
            this.lblTagArea.Location = new System.Drawing.Point(6, 22);
            this.lblTagArea.Name = "lblTagArea";
            this.lblTagArea.Size = new System.Drawing.Size(88, 29);
            this.lblTagArea.TabIndex = 24;
            this.lblTagArea.Text = "标签区域";
            this.lblTagArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbTagArea
            // 
            this.cbbTagArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTagArea.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbTagArea.FormattingEnabled = true;
            this.cbbTagArea.Items.AddRange(new object[] {
            "RFU",
            "EPC",
            "TID",
            "USER"});
            this.cbbTagArea.Location = new System.Drawing.Point(100, 21);
            this.cbbTagArea.Name = "cbbTagArea";
            this.cbbTagArea.Size = new System.Drawing.Size(88, 28);
            this.cbbTagArea.TabIndex = 3;
            this.cbbTagArea.SelectedIndexChanged += new System.EventHandler(this.cbbTagArea_SelectedIndexChanged);
            // 
            // labLength2
            // 
            this.labLength2.AutoEllipsis = true;
            this.labLength2.Location = new System.Drawing.Point(370, 22);
            this.labLength2.Name = "labLength2";
            this.labLength2.Size = new System.Drawing.Size(49, 29);
            this.labLength2.TabIndex = 12;
            this.labLength2.Text = "长度";
            this.labLength2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labStartAdd2
            // 
            this.labStartAdd2.AutoEllipsis = true;
            this.labStartAdd2.Location = new System.Drawing.Point(189, 22);
            this.labStartAdd2.Name = "labStartAdd2";
            this.labStartAdd2.Size = new System.Drawing.Size(85, 29);
            this.labStartAdd2.TabIndex = 11;
            this.labStartAdd2.Text = "起始地址";
            this.labStartAdd2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbStartAddress2
            // 
            this.cbbStartAddress2.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbStartAddress2.FormattingEnabled = true;
            this.cbbStartAddress2.Location = new System.Drawing.Point(276, 21);
            this.cbbStartAddress2.Name = "cbbStartAddress2";
            this.cbbStartAddress2.Size = new System.Drawing.Size(88, 28);
            this.cbbStartAddress2.TabIndex = 1;
            this.cbbStartAddress2.SelectedIndexChanged += new System.EventHandler(this.cbbStartAddress2_SelectedIndexChanged);
            // 
            // cbbLength2
            // 
            this.cbbLength2.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbLength2.FormattingEnabled = true;
            this.cbbLength2.Location = new System.Drawing.Point(425, 21);
            this.cbbLength2.Name = "cbbLength2";
            this.cbbLength2.Size = new System.Drawing.Size(88, 28);
            this.cbbLength2.TabIndex = 2;
            // 
            // gbKillTag
            // 
            this.gbKillTag.Controls.Add(this.tbKillKillPwd);
            this.gbKillTag.Controls.Add(this.btnKillTag);
            this.gbKillTag.Controls.Add(this.labDestroyPwd);
            this.gbKillTag.Location = new System.Drawing.Point(675, 20);
            this.gbKillTag.Name = "gbKillTag";
            this.gbKillTag.Size = new System.Drawing.Size(174, 131);
            this.gbKillTag.TabIndex = 44;
            this.gbKillTag.TabStop = false;
            this.gbKillTag.Text = "销毁标签";
            // 
            // tbKillKillPwd
            // 
            this.tbKillKillPwd.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbKillKillPwd.Location = new System.Drawing.Point(6, 54);
            this.tbKillKillPwd.Name = "tbKillKillPwd";
            this.tbKillKillPwd.Size = new System.Drawing.Size(162, 30);
            this.tbKillKillPwd.TabIndex = 23;
            // 
            // btnKillTag
            // 
            this.btnKillTag.Location = new System.Drawing.Point(85, 92);
            this.btnKillTag.Name = "btnKillTag";
            this.btnKillTag.Size = new System.Drawing.Size(83, 32);
            this.btnKillTag.TabIndex = 21;
            this.btnKillTag.Text = "销毁";
            this.btnKillTag.UseVisualStyleBackColor = true;
            this.btnKillTag.Click += new System.EventHandler(this.btnKillTag_Click);
            // 
            // labDestroyPwd
            // 
            this.labDestroyPwd.AutoEllipsis = true;
            this.labDestroyPwd.Location = new System.Drawing.Point(31, 18);
            this.labDestroyPwd.Name = "labDestroyPwd";
            this.labDestroyPwd.Size = new System.Drawing.Size(123, 29);
            this.labDestroyPwd.TabIndex = 24;
            this.labDestroyPwd.Text = "注销密码";
            this.labDestroyPwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbTagLockAndUnlock
            // 
            this.gbTagLockAndUnlock.Controls.Add(this.lblOperationType);
            this.gbTagLockAndUnlock.Controls.Add(this.cbbLockType);
            this.gbTagLockAndUnlock.Controls.Add(this.labLockBank);
            this.gbTagLockAndUnlock.Controls.Add(this.cbbLockBank);
            this.gbTagLockAndUnlock.Controls.Add(this.btnLockTag);
            this.gbTagLockAndUnlock.Controls.Add(this.labLockAccessPwd);
            this.gbTagLockAndUnlock.Controls.Add(this.tbLockAccessPwd);
            this.gbTagLockAndUnlock.Location = new System.Drawing.Point(24, 424);
            this.gbTagLockAndUnlock.Name = "gbTagLockAndUnlock";
            this.gbTagLockAndUnlock.Size = new System.Drawing.Size(523, 126);
            this.gbTagLockAndUnlock.TabIndex = 42;
            this.gbTagLockAndUnlock.TabStop = false;
            this.gbTagLockAndUnlock.Text = "标签锁定和解锁";
            // 
            // lblOperationType
            // 
            this.lblOperationType.AutoEllipsis = true;
            this.lblOperationType.Location = new System.Drawing.Point(266, 27);
            this.lblOperationType.Name = "lblOperationType";
            this.lblOperationType.Size = new System.Drawing.Size(97, 29);
            this.lblOperationType.TabIndex = 27;
            this.lblOperationType.Text = "操作类型";
            this.lblOperationType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbLockType
            // 
            this.cbbLockType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLockType.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbLockType.FormattingEnabled = true;
            this.cbbLockType.Location = new System.Drawing.Point(369, 26);
            this.cbbLockType.Name = "cbbLockType";
            this.cbbLockType.Size = new System.Drawing.Size(142, 28);
            this.cbbLockType.TabIndex = 26;
            // 
            // labLockBank
            // 
            this.labLockBank.AutoEllipsis = true;
            this.labLockBank.Location = new System.Drawing.Point(15, 27);
            this.labLockBank.Name = "labLockBank";
            this.labLockBank.Size = new System.Drawing.Size(97, 29);
            this.labLockBank.TabIndex = 17;
            this.labLockBank.Text = "操作区域";
            this.labLockBank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbLockBank
            // 
            this.cbbLockBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLockBank.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbLockBank.FormattingEnabled = true;
            this.cbbLockBank.Location = new System.Drawing.Point(118, 26);
            this.cbbLockBank.Name = "cbbLockBank";
            this.cbbLockBank.Size = new System.Drawing.Size(142, 28);
            this.cbbLockBank.TabIndex = 3;
            // 
            // btnLockTag
            // 
            this.btnLockTag.Location = new System.Drawing.Point(428, 77);
            this.btnLockTag.Name = "btnLockTag";
            this.btnLockTag.Size = new System.Drawing.Size(83, 32);
            this.btnLockTag.TabIndex = 20;
            this.btnLockTag.Text = "锁定";
            this.btnLockTag.UseVisualStyleBackColor = true;
            this.btnLockTag.Click += new System.EventHandler(this.btnLockTag_Click);
            // 
            // labLockAccessPwd
            // 
            this.labLockAccessPwd.AutoEllipsis = true;
            this.labLockAccessPwd.Location = new System.Drawing.Point(17, 78);
            this.labLockAccessPwd.Name = "labLockAccessPwd";
            this.labLockAccessPwd.Size = new System.Drawing.Size(95, 29);
            this.labLockAccessPwd.TabIndex = 16;
            this.labLockAccessPwd.Text = "访问密码";
            this.labLockAccessPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLockAccessPwd
            // 
            this.tbLockAccessPwd.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbLockAccessPwd.Location = new System.Drawing.Point(118, 76);
            this.tbLockAccessPwd.Name = "tbLockAccessPwd";
            this.tbLockAccessPwd.Size = new System.Drawing.Size(142, 30);
            this.tbLockAccessPwd.TabIndex = 15;
            // 
            // gbFastWrite
            // 
            this.gbFastWrite.Controls.Add(this.btnReadFastTag);
            this.gbFastWrite.Controls.Add(this.chkZD);
            this.gbFastWrite.Controls.Add(this.labFWPromo);
            this.gbFastWrite.Controls.Add(this.btnClearFWData);
            this.gbFastWrite.Controls.Add(this.btnFastWrite);
            this.gbFastWrite.Controls.Add(this.labFWData);
            this.gbFastWrite.Controls.Add(this.tbFWData);
            this.gbFastWrite.Location = new System.Drawing.Point(24, 20);
            this.gbFastWrite.Name = "gbFastWrite";
            this.gbFastWrite.Size = new System.Drawing.Size(645, 131);
            this.gbFastWrite.TabIndex = 27;
            this.gbFastWrite.TabStop = false;
            this.gbFastWrite.Text = "快写";
            // 
            // btnReadFastTag
            // 
            this.btnReadFastTag.Location = new System.Drawing.Point(347, 87);
            this.btnReadFastTag.Name = "btnReadFastTag";
            this.btnReadFastTag.Size = new System.Drawing.Size(83, 32);
            this.btnReadFastTag.TabIndex = 6;
            this.btnReadFastTag.Text = "读取";
            this.btnReadFastTag.UseVisualStyleBackColor = true;
            this.btnReadFastTag.Click += new System.EventHandler(this.btnReadFastTag_Click);
            // 
            // chkZD
            // 
            this.chkZD.Location = new System.Drawing.Point(99, 90);
            this.chkZD.Name = "chkZD";
            this.chkZD.Size = new System.Drawing.Size(130, 29);
            this.chkZD.TabIndex = 5;
            this.chkZD.Text = "自动增1";
            this.chkZD.UseVisualStyleBackColor = true;
            // 
            // labFWPromo
            // 
            this.labFWPromo.Location = new System.Drawing.Point(6, 22);
            this.labFWPromo.Name = "labFWPromo";
            this.labFWPromo.Size = new System.Drawing.Size(633, 29);
            this.labFWPromo.TabIndex = 4;
            this.labFWPromo.Text = "数据有效提示";
            this.labFWPromo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClearFWData
            // 
            this.btnClearFWData.Location = new System.Drawing.Point(537, 87);
            this.btnClearFWData.Name = "btnClearFWData";
            this.btnClearFWData.Size = new System.Drawing.Size(83, 32);
            this.btnClearFWData.TabIndex = 3;
            this.btnClearFWData.Text = "清空";
            this.btnClearFWData.UseVisualStyleBackColor = true;
            this.btnClearFWData.Click += new System.EventHandler(this.btnClearFWData_Click);
            // 
            // btnFastWrite
            // 
            this.btnFastWrite.Location = new System.Drawing.Point(443, 87);
            this.btnFastWrite.Name = "btnFastWrite";
            this.btnFastWrite.Size = new System.Drawing.Size(83, 32);
            this.btnFastWrite.TabIndex = 2;
            this.btnFastWrite.Text = "快写";
            this.btnFastWrite.UseVisualStyleBackColor = true;
            this.btnFastWrite.Click += new System.EventHandler(this.btnFastWrite_Click);
            // 
            // labFWData
            // 
            this.labFWData.Location = new System.Drawing.Point(6, 57);
            this.labFWData.Name = "labFWData";
            this.labFWData.Size = new System.Drawing.Size(88, 29);
            this.labFWData.TabIndex = 1;
            this.labFWData.Text = "数据";
            this.labFWData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbFWData
            // 
            this.tbFWData.Location = new System.Drawing.Point(99, 54);
            this.tbFWData.Multiline = true;
            this.tbFWData.Name = "tbFWData";
            this.tbFWData.Size = new System.Drawing.Size(520, 29);
            this.tbFWData.TabIndex = 0;
            // 
            // gbRWData
            // 
            this.gbRWData.Controls.Add(this.lblMatchData);
            this.gbRWData.Controls.Add(this.tbMatchData);
            this.gbRWData.Controls.Add(this.lblMatchMode);
            this.gbRWData.Controls.Add(this.cbbMatchMode);
            this.gbRWData.Controls.Add(this.chkMatchParameter);
            this.gbRWData.Controls.Add(this.btnInitTag);
            this.gbRWData.Controls.Add(this.btn_stoptimer);
            this.gbRWData.Controls.Add(this.btn_connRead);
            this.gbRWData.Controls.Add(this.labData);
            this.gbRWData.Controls.Add(this.labLength);
            this.gbRWData.Controls.Add(this.labStartAdd);
            this.gbRWData.Controls.Add(this.labOprBank);
            this.gbRWData.Controls.Add(this.btnWriteData);
            this.gbRWData.Controls.Add(this.btnClearData);
            this.gbRWData.Controls.Add(this.btnReadData);
            this.gbRWData.Controls.Add(this.tbRWData);
            this.gbRWData.Controls.Add(this.cbbLength);
            this.gbRWData.Controls.Add(this.cbbStartAdd);
            this.gbRWData.Controls.Add(this.cbbRWBank);
            this.gbRWData.Location = new System.Drawing.Point(24, 157);
            this.gbRWData.Name = "gbRWData";
            this.gbRWData.Size = new System.Drawing.Size(645, 260);
            this.gbRWData.TabIndex = 21;
            this.gbRWData.TabStop = false;
            this.gbRWData.Text = "标签读写";
            // 
            // lblMatchData
            // 
            this.lblMatchData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMatchData.AutoEllipsis = true;
            this.lblMatchData.Location = new System.Drawing.Point(5, 59);
            this.lblMatchData.Name = "lblMatchData";
            this.lblMatchData.Size = new System.Drawing.Size(90, 29);
            this.lblMatchData.TabIndex = 33;
            this.lblMatchData.Text = "匹配数据";
            this.lblMatchData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbMatchData
            // 
            this.tbMatchData.Location = new System.Drawing.Point(99, 59);
            this.tbMatchData.Multiline = true;
            this.tbMatchData.Name = "tbMatchData";
            this.tbMatchData.Size = new System.Drawing.Size(424, 29);
            this.tbMatchData.TabIndex = 32;
            // 
            // lblMatchMode
            // 
            this.lblMatchMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMatchMode.AutoEllipsis = true;
            this.lblMatchMode.Location = new System.Drawing.Point(8, 23);
            this.lblMatchMode.Name = "lblMatchMode";
            this.lblMatchMode.Size = new System.Drawing.Size(85, 29);
            this.lblMatchMode.TabIndex = 31;
            this.lblMatchMode.Text = "匹配模式";
            this.lblMatchMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbMatchMode
            // 
            this.cbbMatchMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMatchMode.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbMatchMode.FormattingEnabled = true;
            this.cbbMatchMode.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbbMatchMode.Location = new System.Drawing.Point(99, 23);
            this.cbbMatchMode.Name = "cbbMatchMode";
            this.cbbMatchMode.Size = new System.Drawing.Size(88, 28);
            this.cbbMatchMode.TabIndex = 28;
            // 
            // chkMatchParameter
            // 
            this.chkMatchParameter.Location = new System.Drawing.Point(99, 217);
            this.chkMatchParameter.Name = "chkMatchParameter";
            this.chkMatchParameter.Size = new System.Drawing.Size(90, 29);
            this.chkMatchParameter.TabIndex = 27;
            this.chkMatchParameter.Text = "匹配参数";
            this.chkMatchParameter.UseVisualStyleBackColor = true;
            // 
            // btnInitTag
            // 
            this.btnInitTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInitTag.Location = new System.Drawing.Point(537, 217);
            this.btnInitTag.Name = "btnInitTag";
            this.btnInitTag.Size = new System.Drawing.Size(83, 32);
            this.btnInitTag.TabIndex = 26;
            this.btnInitTag.Text = "初始化";
            this.btnInitTag.UseVisualStyleBackColor = true;
            this.btnInitTag.Click += new System.EventHandler(this.btnInitTag_Click);
            // 
            // btn_stoptimer
            // 
            this.btn_stoptimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_stoptimer.Location = new System.Drawing.Point(424, 217);
            this.btn_stoptimer.Name = "btn_stoptimer";
            this.btn_stoptimer.Size = new System.Drawing.Size(100, 32);
            this.btn_stoptimer.TabIndex = 15;
            this.btn_stoptimer.Text = "停止";
            this.btn_stoptimer.UseVisualStyleBackColor = true;
            this.btn_stoptimer.Click += new System.EventHandler(this.btn_stoptimer_Click);
            // 
            // btn_connRead
            // 
            this.btn_connRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_connRead.Location = new System.Drawing.Point(318, 217);
            this.btn_connRead.Name = "btn_connRead";
            this.btn_connRead.Size = new System.Drawing.Size(100, 32);
            this.btn_connRead.TabIndex = 14;
            this.btn_connRead.Text = "连续读取";
            this.btn_connRead.UseVisualStyleBackColor = true;
            this.btn_connRead.Click += new System.EventHandler(this.btn_connRead_Click);
            // 
            // labData
            // 
            this.labData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labData.Location = new System.Drawing.Point(5, 133);
            this.labData.Name = "labData";
            this.labData.Size = new System.Drawing.Size(90, 29);
            this.labData.TabIndex = 13;
            this.labData.Text = "数据";
            this.labData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labLength
            // 
            this.labLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labLength.AutoEllipsis = true;
            this.labLength.Location = new System.Drawing.Point(385, 96);
            this.labLength.Name = "labLength";
            this.labLength.Size = new System.Drawing.Size(49, 29);
            this.labLength.TabIndex = 12;
            this.labLength.Text = "长度";
            this.labLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labStartAdd
            // 
            this.labStartAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labStartAdd.AutoEllipsis = true;
            this.labStartAdd.Location = new System.Drawing.Point(192, 96);
            this.labStartAdd.Name = "labStartAdd";
            this.labStartAdd.Size = new System.Drawing.Size(85, 29);
            this.labStartAdd.TabIndex = 11;
            this.labStartAdd.Text = "起始地址";
            this.labStartAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labOprBank
            // 
            this.labOprBank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labOprBank.AutoEllipsis = true;
            this.labOprBank.Location = new System.Drawing.Point(5, 98);
            this.labOprBank.Name = "labOprBank";
            this.labOprBank.Size = new System.Drawing.Size(90, 29);
            this.labOprBank.TabIndex = 10;
            this.labOprBank.Text = "操作区域";
            this.labOprBank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnWriteData
            // 
            this.btnWriteData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnWriteData.Location = new System.Drawing.Point(536, 172);
            this.btnWriteData.Name = "btnWriteData";
            this.btnWriteData.Size = new System.Drawing.Size(83, 32);
            this.btnWriteData.TabIndex = 8;
            this.btnWriteData.Text = "写入";
            this.btnWriteData.UseVisualStyleBackColor = true;
            this.btnWriteData.Click += new System.EventHandler(this.btnWriteData_Click);
            // 
            // btnClearData
            // 
            this.btnClearData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearData.Location = new System.Drawing.Point(536, 133);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(83, 32);
            this.btnClearData.TabIndex = 7;
            this.btnClearData.Text = "清空";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // btnReadData
            // 
            this.btnReadData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReadData.Location = new System.Drawing.Point(536, 94);
            this.btnReadData.Name = "btnReadData";
            this.btnReadData.Size = new System.Drawing.Size(83, 32);
            this.btnReadData.TabIndex = 6;
            this.btnReadData.Text = "读取";
            this.btnReadData.UseVisualStyleBackColor = true;
            this.btnReadData.Click += new System.EventHandler(this.btnReadData_Click);
            // 
            // tbRWData
            // 
            this.tbRWData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbRWData.Location = new System.Drawing.Point(99, 133);
            this.tbRWData.Multiline = true;
            this.tbRWData.Name = "tbRWData";
            this.tbRWData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRWData.Size = new System.Drawing.Size(424, 77);
            this.tbRWData.TabIndex = 5;
            // 
            // cbbLength
            // 
            this.cbbLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbLength.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbLength.FormattingEnabled = true;
            this.cbbLength.Location = new System.Drawing.Point(440, 95);
            this.cbbLength.Name = "cbbLength";
            this.cbbLength.Size = new System.Drawing.Size(88, 28);
            this.cbbLength.TabIndex = 2;
            // 
            // cbbStartAdd
            // 
            this.cbbStartAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbStartAdd.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbStartAdd.FormattingEnabled = true;
            this.cbbStartAdd.Location = new System.Drawing.Point(279, 95);
            this.cbbStartAdd.Name = "cbbStartAdd";
            this.cbbStartAdd.Size = new System.Drawing.Size(88, 28);
            this.cbbStartAdd.TabIndex = 1;
            this.cbbStartAdd.SelectedIndexChanged += new System.EventHandler(this.cbbStartAdd_SelectedIndexChanged);
            // 
            // cbbRWBank
            // 
            this.cbbRWBank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbRWBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRWBank.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbRWBank.FormattingEnabled = true;
            this.cbbRWBank.Location = new System.Drawing.Point(99, 96);
            this.cbbRWBank.Name = "cbbRWBank";
            this.cbbRWBank.Size = new System.Drawing.Size(88, 28);
            this.cbbRWBank.TabIndex = 0;
            this.cbbRWBank.SelectedIndexChanged += new System.EventHandler(this.cbbRWBank_SelectedIndexChanged);
            // 
            // gbBeepControl
            // 
            this.gbBeepControl.Controls.Add(this.btnReadDataArea);
            this.gbBeepControl.Controls.Add(this.label2);
            this.gbBeepControl.Controls.Add(this.btnSetDataArea);
            this.gbBeepControl.Controls.Add(this.cbbDataArea);
            this.gbBeepControl.Location = new System.Drawing.Point(24, 556);
            this.gbBeepControl.Name = "gbBeepControl";
            this.gbBeepControl.Size = new System.Drawing.Size(290, 116);
            this.gbBeepControl.TabIndex = 4;
            this.gbBeepControl.TabStop = false;
            this.gbBeepControl.Text = "读卡控制";
            // 
            // btnReadDataArea
            // 
            this.btnReadDataArea.Location = new System.Drawing.Point(96, 69);
            this.btnReadDataArea.Name = "btnReadDataArea";
            this.btnReadDataArea.Size = new System.Drawing.Size(80, 32);
            this.btnReadDataArea.TabIndex = 16;
            this.btnReadDataArea.Text = "读取";
            this.btnReadDataArea.UseVisualStyleBackColor = true;
            this.btnReadDataArea.Click += new System.EventHandler(this.btnReadDataArea_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "读卡数据区域";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSetDataArea
            // 
            this.btnSetDataArea.Location = new System.Drawing.Point(194, 69);
            this.btnSetDataArea.Name = "btnSetDataArea";
            this.btnSetDataArea.Size = new System.Drawing.Size(80, 32);
            this.btnSetDataArea.TabIndex = 14;
            this.btnSetDataArea.Text = "设置";
            this.btnSetDataArea.UseVisualStyleBackColor = true;
            this.btnSetDataArea.Click += new System.EventHandler(this.btnSetDataArea_Click);
            // 
            // cbbDataArea
            // 
            this.cbbDataArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDataArea.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbDataArea.FormattingEnabled = true;
            this.cbbDataArea.Items.AddRange(new object[] {
            "RFU",
            "EPC",
            "TID",
            "USER",
            "EPC + TID",
            "EPC + USER"});
            this.cbbDataArea.Location = new System.Drawing.Point(118, 24);
            this.cbbDataArea.Name = "cbbDataArea";
            this.cbbDataArea.Size = new System.Drawing.Size(142, 24);
            this.cbbDataArea.TabIndex = 13;
            // 
            // tpAntennaParams
            // 
            this.tpAntennaParams.Controls.Add(this.gbAdjacentDiscriminant);
            this.tpAntennaParams.Controls.Add(this.grpAntSet);
            this.tpAntennaParams.Controls.Add(this.btnAntSet);
            this.tpAntennaParams.Controls.Add(this.btnReadChannelCount);
            this.tpAntennaParams.Controls.Add(this.btnAntRead);
            this.tpAntennaParams.Location = new System.Drawing.Point(4, 22);
            this.tpAntennaParams.Name = "tpAntennaParams";
            this.tpAntennaParams.Padding = new System.Windows.Forms.Padding(3);
            this.tpAntennaParams.Size = new System.Drawing.Size(864, 680);
            this.tpAntennaParams.TabIndex = 5;
            this.tpAntennaParams.Text = "天线参数";
            this.tpAntennaParams.UseVisualStyleBackColor = true;
            // 
            // gbAdjacentDiscriminant
            // 
            this.gbAdjacentDiscriminant.Controls.Add(this.tabControlAdjacentDiscriminant);
            this.gbAdjacentDiscriminant.Controls.Add(this.btnAdjacentDiscriminantRead2);
            this.gbAdjacentDiscriminant.Controls.Add(this.btnAdjacentDiscriminantSet2);
            this.gbAdjacentDiscriminant.Location = new System.Drawing.Point(14, 385);
            this.gbAdjacentDiscriminant.Name = "gbAdjacentDiscriminant";
            this.gbAdjacentDiscriminant.Size = new System.Drawing.Size(287, 287);
            this.gbAdjacentDiscriminant.TabIndex = 101;
            this.gbAdjacentDiscriminant.TabStop = false;
            this.gbAdjacentDiscriminant.Text = "相邻判别";
            // 
            // tabControlAdjacentDiscriminant
            // 
            this.tabControlAdjacentDiscriminant.Controls.Add(this.tabPageUnify);
            this.tabControlAdjacentDiscriminant.Controls.Add(this.tabPageAlone);
            this.tabControlAdjacentDiscriminant.Location = new System.Drawing.Point(6, 22);
            this.tabControlAdjacentDiscriminant.Name = "tabControlAdjacentDiscriminant";
            this.tabControlAdjacentDiscriminant.SelectedIndex = 0;
            this.tabControlAdjacentDiscriminant.Size = new System.Drawing.Size(275, 210);
            this.tabControlAdjacentDiscriminant.TabIndex = 104;
            // 
            // tabPageUnify
            // 
            this.tabPageUnify.Controls.Add(this.textBox5);
            this.tabPageUnify.Controls.Add(this.label16);
            this.tabPageUnify.Location = new System.Drawing.Point(4, 22);
            this.tabPageUnify.Name = "tabPageUnify";
            this.tabPageUnify.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUnify.Size = new System.Drawing.Size(267, 184);
            this.tabPageUnify.TabIndex = 0;
            this.tabPageUnify.Text = "共用";
            this.tabPageUnify.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox5.Location = new System.Drawing.Point(87, 21);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(99, 23);
            this.textBox5.TabIndex = 104;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(192, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 105;
            this.label16.Tag = "4";
            this.label16.Text = "(0~254s)";
            // 
            // tabPageAlone
            // 
            this.tabPageAlone.Controls.Add(this.tbAnt4);
            this.tabPageAlone.Controls.Add(this.lblAnt4);
            this.tabPageAlone.Controls.Add(this.tbAnt1);
            this.tabPageAlone.Controls.Add(this.lblAnt3);
            this.tabPageAlone.Controls.Add(this.tbAnt2);
            this.tabPageAlone.Controls.Add(this.lblAnt2);
            this.tabPageAlone.Controls.Add(this.tbAnt3);
            this.tabPageAlone.Controls.Add(this.label5);
            this.tabPageAlone.Controls.Add(this.label3);
            this.tabPageAlone.Controls.Add(this.label1);
            this.tabPageAlone.Controls.Add(this.label12);
            this.tabPageAlone.Controls.Add(this.lblAnt1);
            this.tabPageAlone.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlone.Name = "tabPageAlone";
            this.tabPageAlone.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlone.Size = new System.Drawing.Size(267, 184);
            this.tabPageAlone.TabIndex = 1;
            this.tabPageAlone.Text = "单独";
            this.tabPageAlone.UseVisualStyleBackColor = true;
            // 
            // tbAnt4
            // 
            this.tbAnt4.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbAnt4.Location = new System.Drawing.Point(87, 136);
            this.tbAnt4.Name = "tbAnt4";
            this.tbAnt4.Size = new System.Drawing.Size(99, 23);
            this.tbAnt4.TabIndex = 102;
            // 
            // lblAnt4
            // 
            this.lblAnt4.AutoSize = true;
            this.lblAnt4.Location = new System.Drawing.Point(38, 142);
            this.lblAnt4.Name = "lblAnt4";
            this.lblAnt4.Size = new System.Drawing.Size(32, 13);
            this.lblAnt4.TabIndex = 103;
            this.lblAnt4.Tag = "4";
            this.lblAnt4.Text = "Ant 4";
            // 
            // tbAnt1
            // 
            this.tbAnt1.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbAnt1.Location = new System.Drawing.Point(87, 21);
            this.tbAnt1.Name = "tbAnt1";
            this.tbAnt1.Size = new System.Drawing.Size(99, 23);
            this.tbAnt1.TabIndex = 102;
            // 
            // lblAnt3
            // 
            this.lblAnt3.AutoSize = true;
            this.lblAnt3.Location = new System.Drawing.Point(38, 102);
            this.lblAnt3.Name = "lblAnt3";
            this.lblAnt3.Size = new System.Drawing.Size(32, 13);
            this.lblAnt3.TabIndex = 103;
            this.lblAnt3.Tag = "4";
            this.lblAnt3.Text = "Ant 3";
            // 
            // tbAnt2
            // 
            this.tbAnt2.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbAnt2.Location = new System.Drawing.Point(87, 57);
            this.tbAnt2.Name = "tbAnt2";
            this.tbAnt2.Size = new System.Drawing.Size(99, 23);
            this.tbAnt2.TabIndex = 102;
            // 
            // lblAnt2
            // 
            this.lblAnt2.AutoSize = true;
            this.lblAnt2.Location = new System.Drawing.Point(38, 63);
            this.lblAnt2.Name = "lblAnt2";
            this.lblAnt2.Size = new System.Drawing.Size(32, 13);
            this.lblAnt2.TabIndex = 103;
            this.lblAnt2.Tag = "4";
            this.lblAnt2.Text = "Ant 2";
            // 
            // tbAnt3
            // 
            this.tbAnt3.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbAnt3.Location = new System.Drawing.Point(87, 96);
            this.tbAnt3.Name = "tbAnt3";
            this.tbAnt3.Size = new System.Drawing.Size(99, 23);
            this.tbAnt3.TabIndex = 102;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 103;
            this.label5.Tag = "4";
            this.label5.Text = "(0~65535s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 103;
            this.label3.Tag = "4";
            this.label3.Text = "(0~65535s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 103;
            this.label1.Tag = "4";
            this.label1.Text = "(0~65535s)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(192, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 103;
            this.label12.Tag = "4";
            this.label12.Text = "(0~65535s)";
            // 
            // lblAnt1
            // 
            this.lblAnt1.AutoSize = true;
            this.lblAnt1.Location = new System.Drawing.Point(38, 26);
            this.lblAnt1.Name = "lblAnt1";
            this.lblAnt1.Size = new System.Drawing.Size(32, 13);
            this.lblAnt1.TabIndex = 103;
            this.lblAnt1.Tag = "4";
            this.lblAnt1.Text = "Ant 1";
            // 
            // btnAdjacentDiscriminantRead2
            // 
            this.btnAdjacentDiscriminantRead2.Location = new System.Drawing.Point(127, 238);
            this.btnAdjacentDiscriminantRead2.Name = "btnAdjacentDiscriminantRead2";
            this.btnAdjacentDiscriminantRead2.Size = new System.Drawing.Size(73, 35);
            this.btnAdjacentDiscriminantRead2.TabIndex = 16;
            this.btnAdjacentDiscriminantRead2.Text = "读取";
            this.btnAdjacentDiscriminantRead2.UseVisualStyleBackColor = true;
            this.btnAdjacentDiscriminantRead2.Click += new System.EventHandler(this.btnAdjacentDiscriminantRead2_Click);
            // 
            // btnAdjacentDiscriminantSet2
            // 
            this.btnAdjacentDiscriminantSet2.Location = new System.Drawing.Point(204, 238);
            this.btnAdjacentDiscriminantSet2.Name = "btnAdjacentDiscriminantSet2";
            this.btnAdjacentDiscriminantSet2.Size = new System.Drawing.Size(73, 35);
            this.btnAdjacentDiscriminantSet2.TabIndex = 16;
            this.btnAdjacentDiscriminantSet2.Text = "设置";
            this.btnAdjacentDiscriminantSet2.UseVisualStyleBackColor = true;
            this.btnAdjacentDiscriminantSet2.Click += new System.EventHandler(this.btnAdjacentDiscriminantSet2_Click);
            // 
            // grpAntSet
            // 
            this.grpAntSet.BackColor = System.Drawing.Color.White;
            this.grpAntSet.Controls.Add(this.rbChannel32);
            this.grpAntSet.Controls.Add(this.rbChannel16);
            this.grpAntSet.Controls.Add(this.cbbGapTime16);
            this.grpAntSet.Controls.Add(this.rbChannel1);
            this.grpAntSet.Controls.Add(this.cbbGapTime8);
            this.grpAntSet.Controls.Add(this.rbChannel8);
            this.grpAntSet.Controls.Add(this.lblAntennaGapTime);
            this.grpAntSet.Controls.Add(this.cbbGapTime15);
            this.grpAntSet.Controls.Add(this.lblAntennaWorkTime);
            this.grpAntSet.Controls.Add(this.rbChannel2);
            this.grpAntSet.Controls.Add(this.cbbGapTime7);
            this.grpAntSet.Controls.Add(this.cbbGapTime14);
            this.grpAntSet.Controls.Add(this.lblAntennaPower);
            this.grpAntSet.Controls.Add(this.rbChannel4);
            this.grpAntSet.Controls.Add(this.lblAntennaId);
            this.grpAntSet.Controls.Add(this.cbbGapTime6);
            this.grpAntSet.Controls.Add(this.cbbGapTime13);
            this.grpAntSet.Controls.Add(this.cbbGapTime5);
            this.grpAntSet.Controls.Add(this.cbbGapTime12);
            this.grpAntSet.Controls.Add(this.cbbGapTime4);
            this.grpAntSet.Controls.Add(this.cbbGapTime11);
            this.grpAntSet.Controls.Add(this.cbbGapTime3);
            this.grpAntSet.Controls.Add(this.cbbGapTime10);
            this.grpAntSet.Controls.Add(this.cbbGapTime2);
            this.grpAntSet.Controls.Add(this.cbbGapTime9);
            this.grpAntSet.Controls.Add(this.cbbGapTime1);
            this.grpAntSet.Controls.Add(this.cbbWorkTime16);
            this.grpAntSet.Controls.Add(this.cbbWorkTime8);
            this.grpAntSet.Controls.Add(this.cbbWorkTime15);
            this.grpAntSet.Controls.Add(this.cbbWorkTime7);
            this.grpAntSet.Controls.Add(this.cbbWorkTime14);
            this.grpAntSet.Controls.Add(this.cbbWorkTime6);
            this.grpAntSet.Controls.Add(this.cbbWorkTime13);
            this.grpAntSet.Controls.Add(this.cbbWorkTime5);
            this.grpAntSet.Controls.Add(this.cbbWorkTime12);
            this.grpAntSet.Controls.Add(this.cbbWorkTime4);
            this.grpAntSet.Controls.Add(this.cbbWorkTime11);
            this.grpAntSet.Controls.Add(this.cbbWorkTime3);
            this.grpAntSet.Controls.Add(this.cbbWorkTime10);
            this.grpAntSet.Controls.Add(this.cbbWorkTime2);
            this.grpAntSet.Controls.Add(this.cbbWorkTime9);
            this.grpAntSet.Controls.Add(this.cbbWorkTime1);
            this.grpAntSet.Controls.Add(this.cbbPower16);
            this.grpAntSet.Controls.Add(this.cbbPower8);
            this.grpAntSet.Controls.Add(this.cbbPower15);
            this.grpAntSet.Controls.Add(this.cbbPower7);
            this.grpAntSet.Controls.Add(this.cbbPower14);
            this.grpAntSet.Controls.Add(this.cbbPower6);
            this.grpAntSet.Controls.Add(this.cbbPower13);
            this.grpAntSet.Controls.Add(this.cbbPower5);
            this.grpAntSet.Controls.Add(this.cbbPower12);
            this.grpAntSet.Controls.Add(this.cbbPower4);
            this.grpAntSet.Controls.Add(this.cbbPower11);
            this.grpAntSet.Controls.Add(this.cbbPower3);
            this.grpAntSet.Controls.Add(this.cbbPower10);
            this.grpAntSet.Controls.Add(this.cbbPower2);
            this.grpAntSet.Controls.Add(this.cbbPower9);
            this.grpAntSet.Controls.Add(this.cbbPower1);
            this.grpAntSet.Controls.Add(this.chkAnt16);
            this.grpAntSet.Controls.Add(this.chkAnt15);
            this.grpAntSet.Controls.Add(this.chkAnt14);
            this.grpAntSet.Controls.Add(this.chkAnt13);
            this.grpAntSet.Controls.Add(this.chkAnt12);
            this.grpAntSet.Controls.Add(this.chkAnt11);
            this.grpAntSet.Controls.Add(this.chkAnt10);
            this.grpAntSet.Controls.Add(this.chkAnt9);
            this.grpAntSet.Controls.Add(this.chkAnt8);
            this.grpAntSet.Controls.Add(this.chkAnt7);
            this.grpAntSet.Controls.Add(this.chkAnt6);
            this.grpAntSet.Controls.Add(this.chkAnt5);
            this.grpAntSet.Controls.Add(this.chkAnt4);
            this.grpAntSet.Controls.Add(this.chkAnt3);
            this.grpAntSet.Controls.Add(this.chkAnt2);
            this.grpAntSet.Controls.Add(this.chkAnt1);
            this.grpAntSet.Enabled = false;
            this.grpAntSet.Location = new System.Drawing.Point(14, 20);
            this.grpAntSet.Name = "grpAntSet";
            this.grpAntSet.Size = new System.Drawing.Size(835, 316);
            this.grpAntSet.TabIndex = 93;
            this.grpAntSet.TabStop = false;
            this.grpAntSet.Text = "天线设置";
            // 
            // rbChannel32
            // 
            this.rbChannel32.AutoSize = true;
            this.rbChannel32.Location = new System.Drawing.Point(627, 0);
            this.rbChannel32.Name = "rbChannel32";
            this.rbChannel32.Size = new System.Drawing.Size(61, 17);
            this.rbChannel32.TabIndex = 94;
            this.rbChannel32.TabStop = true;
            this.rbChannel32.Text = "32通道";
            this.rbChannel32.UseVisualStyleBackColor = true;
            // 
            // rbChannel16
            // 
            this.rbChannel16.AutoSize = true;
            this.rbChannel16.Location = new System.Drawing.Point(530, 0);
            this.rbChannel16.Name = "rbChannel16";
            this.rbChannel16.Size = new System.Drawing.Size(61, 17);
            this.rbChannel16.TabIndex = 94;
            this.rbChannel16.TabStop = true;
            this.rbChannel16.Text = "16通道";
            this.rbChannel16.UseVisualStyleBackColor = true;
            // 
            // cbbGapTime16
            // 
            this.cbbGapTime16.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbGapTime16.FormattingEnabled = true;
            this.cbbGapTime16.Location = new System.Drawing.Point(692, 284);
            this.cbbGapTime16.Name = "cbbGapTime16";
            this.cbbGapTime16.Size = new System.Drawing.Size(95, 24);
            this.cbbGapTime16.TabIndex = 77;
            // 
            // rbChannel1
            // 
            this.rbChannel1.AutoSize = true;
            this.rbChannel1.Location = new System.Drawing.Point(166, 0);
            this.rbChannel1.Name = "rbChannel1";
            this.rbChannel1.Size = new System.Drawing.Size(55, 17);
            this.rbChannel1.TabIndex = 94;
            this.rbChannel1.TabStop = true;
            this.rbChannel1.Text = "1通道";
            this.rbChannel1.UseVisualStyleBackColor = true;
            // 
            // cbbGapTime8
            // 
            this.cbbGapTime8.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbGapTime8.FormattingEnabled = true;
            this.cbbGapTime8.Location = new System.Drawing.Point(293, 284);
            this.cbbGapTime8.Name = "cbbGapTime8";
            this.cbbGapTime8.Size = new System.Drawing.Size(95, 24);
            this.cbbGapTime8.TabIndex = 77;
            // 
            // rbChannel8
            // 
            this.rbChannel8.AutoSize = true;
            this.rbChannel8.Location = new System.Drawing.Point(439, 0);
            this.rbChannel8.Name = "rbChannel8";
            this.rbChannel8.Size = new System.Drawing.Size(55, 17);
            this.rbChannel8.TabIndex = 94;
            this.rbChannel8.TabStop = true;
            this.rbChannel8.Text = "8通道";
            this.rbChannel8.UseVisualStyleBackColor = true;
            // 
            // lblAntennaGapTime
            // 
            this.lblAntennaGapTime.AutoSize = true;
            this.lblAntennaGapTime.Location = new System.Drawing.Point(312, 30);
            this.lblAntennaGapTime.Name = "lblAntennaGapTime";
            this.lblAntennaGapTime.Size = new System.Drawing.Size(55, 13);
            this.lblAntennaGapTime.TabIndex = 94;
            this.lblAntennaGapTime.Text = "间隔时间";
            // 
            // cbbGapTime15
            // 
            this.cbbGapTime15.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbGapTime15.FormattingEnabled = true;
            this.cbbGapTime15.Location = new System.Drawing.Point(692, 251);
            this.cbbGapTime15.Name = "cbbGapTime15";
            this.cbbGapTime15.Size = new System.Drawing.Size(95, 24);
            this.cbbGapTime15.TabIndex = 77;
            // 
            // lblAntennaWorkTime
            // 
            this.lblAntennaWorkTime.AutoSize = true;
            this.lblAntennaWorkTime.Location = new System.Drawing.Point(207, 30);
            this.lblAntennaWorkTime.Name = "lblAntennaWorkTime";
            this.lblAntennaWorkTime.Size = new System.Drawing.Size(55, 13);
            this.lblAntennaWorkTime.TabIndex = 94;
            this.lblAntennaWorkTime.Text = "工作时间";
            // 
            // rbChannel2
            // 
            this.rbChannel2.AutoSize = true;
            this.rbChannel2.Location = new System.Drawing.Point(257, 0);
            this.rbChannel2.Name = "rbChannel2";
            this.rbChannel2.Size = new System.Drawing.Size(55, 17);
            this.rbChannel2.TabIndex = 94;
            this.rbChannel2.TabStop = true;
            this.rbChannel2.Text = "2通道";
            this.rbChannel2.UseVisualStyleBackColor = true;
            // 
            // cbbGapTime7
            // 
            this.cbbGapTime7.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbGapTime7.FormattingEnabled = true;
            this.cbbGapTime7.Location = new System.Drawing.Point(293, 251);
            this.cbbGapTime7.Name = "cbbGapTime7";
            this.cbbGapTime7.Size = new System.Drawing.Size(95, 24);
            this.cbbGapTime7.TabIndex = 77;
            // 
            // cbbGapTime14
            // 
            this.cbbGapTime14.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbGapTime14.FormattingEnabled = true;
            this.cbbGapTime14.Location = new System.Drawing.Point(692, 219);
            this.cbbGapTime14.Name = "cbbGapTime14";
            this.cbbGapTime14.Size = new System.Drawing.Size(95, 24);
            this.cbbGapTime14.TabIndex = 77;
            // 
            // lblAntennaPower
            // 
            this.lblAntennaPower.AutoSize = true;
            this.lblAntennaPower.Location = new System.Drawing.Point(122, 30);
            this.lblAntennaPower.Name = "lblAntennaPower";
            this.lblAntennaPower.Size = new System.Drawing.Size(31, 13);
            this.lblAntennaPower.TabIndex = 94;
            this.lblAntennaPower.Text = "功率";
            // 
            // rbChannel4
            // 
            this.rbChannel4.AutoSize = true;
            this.rbChannel4.Location = new System.Drawing.Point(348, 0);
            this.rbChannel4.Name = "rbChannel4";
            this.rbChannel4.Size = new System.Drawing.Size(55, 17);
            this.rbChannel4.TabIndex = 94;
            this.rbChannel4.TabStop = true;
            this.rbChannel4.Text = "4通道";
            this.rbChannel4.UseVisualStyleBackColor = true;
            // 
            // lblAntennaId
            // 
            this.lblAntennaId.AutoSize = true;
            this.lblAntennaId.Location = new System.Drawing.Point(24, 30);
            this.lblAntennaId.Name = "lblAntennaId";
            this.lblAntennaId.Size = new System.Drawing.Size(43, 13);
            this.lblAntennaId.TabIndex = 94;
            this.lblAntennaId.Text = "天线号";
            // 
            // cbbGapTime6
            // 
            this.cbbGapTime6.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbGapTime6.FormattingEnabled = true;
            this.cbbGapTime6.Location = new System.Drawing.Point(293, 219);
            this.cbbGapTime6.Name = "cbbGapTime6";
            this.cbbGapTime6.Size = new System.Drawing.Size(95, 24);
            this.cbbGapTime6.TabIndex = 77;
            // 
            // cbbGapTime13
            // 
            this.cbbGapTime13.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbGapTime13.FormattingEnabled = true;
            this.cbbGapTime13.Location = new System.Drawing.Point(692, 186);
            this.cbbGapTime13.Name = "cbbGapTime13";
            this.cbbGapTime13.Size = new System.Drawing.Size(95, 24);
            this.cbbGapTime13.TabIndex = 77;
            // 
            // cbbGapTime5
            // 
            this.cbbGapTime5.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbGapTime5.FormattingEnabled = true;
            this.cbbGapTime5.Location = new System.Drawing.Point(293, 186);
            this.cbbGapTime5.Name = "cbbGapTime5";
            this.cbbGapTime5.Size = new System.Drawing.Size(95, 24);
            this.cbbGapTime5.TabIndex = 77;
            // 
            // cbbGapTime12
            // 
            this.cbbGapTime12.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbGapTime12.FormattingEnabled = true;
            this.cbbGapTime12.Location = new System.Drawing.Point(692, 154);
            this.cbbGapTime12.Name = "cbbGapTime12";
            this.cbbGapTime12.Size = new System.Drawing.Size(95, 24);
            this.cbbGapTime12.TabIndex = 77;
            // 
            // cbbGapTime4
            // 
            this.cbbGapTime4.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbGapTime4.FormattingEnabled = true;
            this.cbbGapTime4.Location = new System.Drawing.Point(293, 154);
            this.cbbGapTime4.Name = "cbbGapTime4";
            this.cbbGapTime4.Size = new System.Drawing.Size(95, 24);
            this.cbbGapTime4.TabIndex = 77;
            // 
            // cbbGapTime11
            // 
            this.cbbGapTime11.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbGapTime11.FormattingEnabled = true;
            this.cbbGapTime11.Location = new System.Drawing.Point(692, 121);
            this.cbbGapTime11.Name = "cbbGapTime11";
            this.cbbGapTime11.Size = new System.Drawing.Size(95, 24);
            this.cbbGapTime11.TabIndex = 77;
            // 
            // cbbGapTime3
            // 
            this.cbbGapTime3.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbGapTime3.FormattingEnabled = true;
            this.cbbGapTime3.Location = new System.Drawing.Point(293, 121);
            this.cbbGapTime3.Name = "cbbGapTime3";
            this.cbbGapTime3.Size = new System.Drawing.Size(95, 24);
            this.cbbGapTime3.TabIndex = 77;
            // 
            // cbbGapTime10
            // 
            this.cbbGapTime10.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbGapTime10.FormattingEnabled = true;
            this.cbbGapTime10.Location = new System.Drawing.Point(692, 89);
            this.cbbGapTime10.Name = "cbbGapTime10";
            this.cbbGapTime10.Size = new System.Drawing.Size(95, 24);
            this.cbbGapTime10.TabIndex = 77;
            // 
            // cbbGapTime2
            // 
            this.cbbGapTime2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbGapTime2.FormattingEnabled = true;
            this.cbbGapTime2.Location = new System.Drawing.Point(293, 89);
            this.cbbGapTime2.Name = "cbbGapTime2";
            this.cbbGapTime2.Size = new System.Drawing.Size(95, 24);
            this.cbbGapTime2.TabIndex = 77;
            // 
            // cbbGapTime9
            // 
            this.cbbGapTime9.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbGapTime9.FormattingEnabled = true;
            this.cbbGapTime9.Location = new System.Drawing.Point(692, 56);
            this.cbbGapTime9.Name = "cbbGapTime9";
            this.cbbGapTime9.Size = new System.Drawing.Size(95, 24);
            this.cbbGapTime9.TabIndex = 77;
            // 
            // cbbGapTime1
            // 
            this.cbbGapTime1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbGapTime1.FormattingEnabled = true;
            this.cbbGapTime1.Location = new System.Drawing.Point(293, 56);
            this.cbbGapTime1.Name = "cbbGapTime1";
            this.cbbGapTime1.Size = new System.Drawing.Size(95, 24);
            this.cbbGapTime1.TabIndex = 77;
            // 
            // cbbWorkTime16
            // 
            this.cbbWorkTime16.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbWorkTime16.FormattingEnabled = true;
            this.cbbWorkTime16.Location = new System.Drawing.Point(591, 284);
            this.cbbWorkTime16.Name = "cbbWorkTime16";
            this.cbbWorkTime16.Size = new System.Drawing.Size(95, 24);
            this.cbbWorkTime16.TabIndex = 76;
            // 
            // cbbWorkTime8
            // 
            this.cbbWorkTime8.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbWorkTime8.FormattingEnabled = true;
            this.cbbWorkTime8.Location = new System.Drawing.Point(192, 284);
            this.cbbWorkTime8.Name = "cbbWorkTime8";
            this.cbbWorkTime8.Size = new System.Drawing.Size(95, 24);
            this.cbbWorkTime8.TabIndex = 76;
            // 
            // cbbWorkTime15
            // 
            this.cbbWorkTime15.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbWorkTime15.FormattingEnabled = true;
            this.cbbWorkTime15.Location = new System.Drawing.Point(591, 251);
            this.cbbWorkTime15.Name = "cbbWorkTime15";
            this.cbbWorkTime15.Size = new System.Drawing.Size(95, 24);
            this.cbbWorkTime15.TabIndex = 76;
            // 
            // cbbWorkTime7
            // 
            this.cbbWorkTime7.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbWorkTime7.FormattingEnabled = true;
            this.cbbWorkTime7.Location = new System.Drawing.Point(192, 251);
            this.cbbWorkTime7.Name = "cbbWorkTime7";
            this.cbbWorkTime7.Size = new System.Drawing.Size(95, 24);
            this.cbbWorkTime7.TabIndex = 76;
            // 
            // cbbWorkTime14
            // 
            this.cbbWorkTime14.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbWorkTime14.FormattingEnabled = true;
            this.cbbWorkTime14.Location = new System.Drawing.Point(591, 219);
            this.cbbWorkTime14.Name = "cbbWorkTime14";
            this.cbbWorkTime14.Size = new System.Drawing.Size(95, 24);
            this.cbbWorkTime14.TabIndex = 76;
            // 
            // cbbWorkTime6
            // 
            this.cbbWorkTime6.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbWorkTime6.FormattingEnabled = true;
            this.cbbWorkTime6.Location = new System.Drawing.Point(192, 219);
            this.cbbWorkTime6.Name = "cbbWorkTime6";
            this.cbbWorkTime6.Size = new System.Drawing.Size(95, 24);
            this.cbbWorkTime6.TabIndex = 76;
            // 
            // cbbWorkTime13
            // 
            this.cbbWorkTime13.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbWorkTime13.FormattingEnabled = true;
            this.cbbWorkTime13.Location = new System.Drawing.Point(591, 186);
            this.cbbWorkTime13.Name = "cbbWorkTime13";
            this.cbbWorkTime13.Size = new System.Drawing.Size(95, 24);
            this.cbbWorkTime13.TabIndex = 76;
            // 
            // cbbWorkTime5
            // 
            this.cbbWorkTime5.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbWorkTime5.FormattingEnabled = true;
            this.cbbWorkTime5.Location = new System.Drawing.Point(192, 186);
            this.cbbWorkTime5.Name = "cbbWorkTime5";
            this.cbbWorkTime5.Size = new System.Drawing.Size(95, 24);
            this.cbbWorkTime5.TabIndex = 76;
            // 
            // cbbWorkTime12
            // 
            this.cbbWorkTime12.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbWorkTime12.FormattingEnabled = true;
            this.cbbWorkTime12.Location = new System.Drawing.Point(591, 154);
            this.cbbWorkTime12.Name = "cbbWorkTime12";
            this.cbbWorkTime12.Size = new System.Drawing.Size(95, 24);
            this.cbbWorkTime12.TabIndex = 76;
            // 
            // cbbWorkTime4
            // 
            this.cbbWorkTime4.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbWorkTime4.FormattingEnabled = true;
            this.cbbWorkTime4.Location = new System.Drawing.Point(192, 154);
            this.cbbWorkTime4.Name = "cbbWorkTime4";
            this.cbbWorkTime4.Size = new System.Drawing.Size(95, 24);
            this.cbbWorkTime4.TabIndex = 76;
            // 
            // cbbWorkTime11
            // 
            this.cbbWorkTime11.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbWorkTime11.FormattingEnabled = true;
            this.cbbWorkTime11.Location = new System.Drawing.Point(591, 121);
            this.cbbWorkTime11.Name = "cbbWorkTime11";
            this.cbbWorkTime11.Size = new System.Drawing.Size(95, 24);
            this.cbbWorkTime11.TabIndex = 76;
            // 
            // cbbWorkTime3
            // 
            this.cbbWorkTime3.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbWorkTime3.FormattingEnabled = true;
            this.cbbWorkTime3.Location = new System.Drawing.Point(192, 121);
            this.cbbWorkTime3.Name = "cbbWorkTime3";
            this.cbbWorkTime3.Size = new System.Drawing.Size(95, 24);
            this.cbbWorkTime3.TabIndex = 76;
            // 
            // cbbWorkTime10
            // 
            this.cbbWorkTime10.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbWorkTime10.FormattingEnabled = true;
            this.cbbWorkTime10.Location = new System.Drawing.Point(591, 89);
            this.cbbWorkTime10.Name = "cbbWorkTime10";
            this.cbbWorkTime10.Size = new System.Drawing.Size(95, 24);
            this.cbbWorkTime10.TabIndex = 76;
            // 
            // cbbWorkTime2
            // 
            this.cbbWorkTime2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbWorkTime2.FormattingEnabled = true;
            this.cbbWorkTime2.Location = new System.Drawing.Point(192, 89);
            this.cbbWorkTime2.Name = "cbbWorkTime2";
            this.cbbWorkTime2.Size = new System.Drawing.Size(95, 24);
            this.cbbWorkTime2.TabIndex = 76;
            // 
            // cbbWorkTime9
            // 
            this.cbbWorkTime9.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbWorkTime9.FormattingEnabled = true;
            this.cbbWorkTime9.Location = new System.Drawing.Point(591, 56);
            this.cbbWorkTime9.Name = "cbbWorkTime9";
            this.cbbWorkTime9.Size = new System.Drawing.Size(95, 24);
            this.cbbWorkTime9.TabIndex = 76;
            // 
            // cbbWorkTime1
            // 
            this.cbbWorkTime1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbWorkTime1.FormattingEnabled = true;
            this.cbbWorkTime1.Location = new System.Drawing.Point(192, 56);
            this.cbbWorkTime1.Name = "cbbWorkTime1";
            this.cbbWorkTime1.Size = new System.Drawing.Size(95, 24);
            this.cbbWorkTime1.TabIndex = 76;
            // 
            // cbbPower16
            // 
            this.cbbPower16.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbPower16.FormattingEnabled = true;
            this.cbbPower16.Location = new System.Drawing.Point(490, 284);
            this.cbbPower16.Name = "cbbPower16";
            this.cbbPower16.Size = new System.Drawing.Size(95, 24);
            this.cbbPower16.TabIndex = 75;
            // 
            // cbbPower8
            // 
            this.cbbPower8.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbPower8.FormattingEnabled = true;
            this.cbbPower8.Location = new System.Drawing.Point(91, 284);
            this.cbbPower8.Name = "cbbPower8";
            this.cbbPower8.Size = new System.Drawing.Size(95, 24);
            this.cbbPower8.TabIndex = 75;
            // 
            // cbbPower15
            // 
            this.cbbPower15.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbPower15.FormattingEnabled = true;
            this.cbbPower15.Location = new System.Drawing.Point(490, 251);
            this.cbbPower15.Name = "cbbPower15";
            this.cbbPower15.Size = new System.Drawing.Size(95, 24);
            this.cbbPower15.TabIndex = 75;
            // 
            // cbbPower7
            // 
            this.cbbPower7.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbPower7.FormattingEnabled = true;
            this.cbbPower7.Location = new System.Drawing.Point(91, 251);
            this.cbbPower7.Name = "cbbPower7";
            this.cbbPower7.Size = new System.Drawing.Size(95, 24);
            this.cbbPower7.TabIndex = 75;
            // 
            // cbbPower14
            // 
            this.cbbPower14.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbPower14.FormattingEnabled = true;
            this.cbbPower14.Location = new System.Drawing.Point(490, 219);
            this.cbbPower14.Name = "cbbPower14";
            this.cbbPower14.Size = new System.Drawing.Size(95, 24);
            this.cbbPower14.TabIndex = 75;
            // 
            // cbbPower6
            // 
            this.cbbPower6.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbPower6.FormattingEnabled = true;
            this.cbbPower6.Location = new System.Drawing.Point(91, 219);
            this.cbbPower6.Name = "cbbPower6";
            this.cbbPower6.Size = new System.Drawing.Size(95, 24);
            this.cbbPower6.TabIndex = 75;
            // 
            // cbbPower13
            // 
            this.cbbPower13.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbPower13.FormattingEnabled = true;
            this.cbbPower13.Location = new System.Drawing.Point(490, 186);
            this.cbbPower13.Name = "cbbPower13";
            this.cbbPower13.Size = new System.Drawing.Size(95, 24);
            this.cbbPower13.TabIndex = 75;
            // 
            // cbbPower5
            // 
            this.cbbPower5.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbPower5.FormattingEnabled = true;
            this.cbbPower5.Location = new System.Drawing.Point(91, 186);
            this.cbbPower5.Name = "cbbPower5";
            this.cbbPower5.Size = new System.Drawing.Size(95, 24);
            this.cbbPower5.TabIndex = 75;
            // 
            // cbbPower12
            // 
            this.cbbPower12.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbPower12.FormattingEnabled = true;
            this.cbbPower12.Location = new System.Drawing.Point(490, 154);
            this.cbbPower12.Name = "cbbPower12";
            this.cbbPower12.Size = new System.Drawing.Size(95, 24);
            this.cbbPower12.TabIndex = 75;
            // 
            // cbbPower4
            // 
            this.cbbPower4.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbPower4.FormattingEnabled = true;
            this.cbbPower4.Location = new System.Drawing.Point(91, 154);
            this.cbbPower4.Name = "cbbPower4";
            this.cbbPower4.Size = new System.Drawing.Size(95, 24);
            this.cbbPower4.TabIndex = 75;
            // 
            // cbbPower11
            // 
            this.cbbPower11.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbPower11.FormattingEnabled = true;
            this.cbbPower11.Location = new System.Drawing.Point(490, 121);
            this.cbbPower11.Name = "cbbPower11";
            this.cbbPower11.Size = new System.Drawing.Size(95, 24);
            this.cbbPower11.TabIndex = 75;
            // 
            // cbbPower3
            // 
            this.cbbPower3.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbPower3.FormattingEnabled = true;
            this.cbbPower3.Location = new System.Drawing.Point(91, 121);
            this.cbbPower3.Name = "cbbPower3";
            this.cbbPower3.Size = new System.Drawing.Size(95, 24);
            this.cbbPower3.TabIndex = 75;
            // 
            // cbbPower10
            // 
            this.cbbPower10.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbPower10.FormattingEnabled = true;
            this.cbbPower10.Location = new System.Drawing.Point(490, 89);
            this.cbbPower10.Name = "cbbPower10";
            this.cbbPower10.Size = new System.Drawing.Size(95, 24);
            this.cbbPower10.TabIndex = 75;
            // 
            // cbbPower2
            // 
            this.cbbPower2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbPower2.FormattingEnabled = true;
            this.cbbPower2.Location = new System.Drawing.Point(91, 89);
            this.cbbPower2.Name = "cbbPower2";
            this.cbbPower2.Size = new System.Drawing.Size(95, 24);
            this.cbbPower2.TabIndex = 75;
            // 
            // cbbPower9
            // 
            this.cbbPower9.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbPower9.FormattingEnabled = true;
            this.cbbPower9.Location = new System.Drawing.Point(490, 56);
            this.cbbPower9.Name = "cbbPower9";
            this.cbbPower9.Size = new System.Drawing.Size(95, 24);
            this.cbbPower9.TabIndex = 75;
            // 
            // cbbPower1
            // 
            this.cbbPower1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbPower1.FormattingEnabled = true;
            this.cbbPower1.Location = new System.Drawing.Point(91, 56);
            this.cbbPower1.Name = "cbbPower1";
            this.cbbPower1.Size = new System.Drawing.Size(95, 24);
            this.cbbPower1.TabIndex = 75;
            // 
            // chkAnt16
            // 
            this.chkAnt16.AutoSize = true;
            this.chkAnt16.Location = new System.Drawing.Point(420, 290);
            this.chkAnt16.Name = "chkAnt16";
            this.chkAnt16.Size = new System.Drawing.Size(57, 17);
            this.chkAnt16.TabIndex = 74;
            this.chkAnt16.Text = "Ant 16";
            this.chkAnt16.UseVisualStyleBackColor = true;
            // 
            // chkAnt15
            // 
            this.chkAnt15.AutoSize = true;
            this.chkAnt15.Location = new System.Drawing.Point(420, 258);
            this.chkAnt15.Name = "chkAnt15";
            this.chkAnt15.Size = new System.Drawing.Size(57, 17);
            this.chkAnt15.TabIndex = 73;
            this.chkAnt15.Text = "Ant 15";
            this.chkAnt15.UseVisualStyleBackColor = true;
            // 
            // chkAnt14
            // 
            this.chkAnt14.AutoSize = true;
            this.chkAnt14.Location = new System.Drawing.Point(420, 225);
            this.chkAnt14.Name = "chkAnt14";
            this.chkAnt14.Size = new System.Drawing.Size(57, 17);
            this.chkAnt14.TabIndex = 72;
            this.chkAnt14.Text = "Ant 14";
            this.chkAnt14.UseVisualStyleBackColor = true;
            // 
            // chkAnt13
            // 
            this.chkAnt13.AutoSize = true;
            this.chkAnt13.Location = new System.Drawing.Point(420, 193);
            this.chkAnt13.Name = "chkAnt13";
            this.chkAnt13.Size = new System.Drawing.Size(57, 17);
            this.chkAnt13.TabIndex = 71;
            this.chkAnt13.Text = "Ant 13";
            this.chkAnt13.UseVisualStyleBackColor = true;
            // 
            // chkAnt12
            // 
            this.chkAnt12.AutoSize = true;
            this.chkAnt12.Location = new System.Drawing.Point(420, 160);
            this.chkAnt12.Name = "chkAnt12";
            this.chkAnt12.Size = new System.Drawing.Size(57, 17);
            this.chkAnt12.TabIndex = 70;
            this.chkAnt12.Text = "Ant 12";
            this.chkAnt12.UseVisualStyleBackColor = true;
            // 
            // chkAnt11
            // 
            this.chkAnt11.AutoSize = true;
            this.chkAnt11.Location = new System.Drawing.Point(420, 128);
            this.chkAnt11.Name = "chkAnt11";
            this.chkAnt11.Size = new System.Drawing.Size(57, 17);
            this.chkAnt11.TabIndex = 69;
            this.chkAnt11.Text = "Ant 11";
            this.chkAnt11.UseVisualStyleBackColor = true;
            // 
            // chkAnt10
            // 
            this.chkAnt10.AutoSize = true;
            this.chkAnt10.Location = new System.Drawing.Point(420, 95);
            this.chkAnt10.Name = "chkAnt10";
            this.chkAnt10.Size = new System.Drawing.Size(57, 17);
            this.chkAnt10.TabIndex = 68;
            this.chkAnt10.Text = "Ant 10";
            this.chkAnt10.UseVisualStyleBackColor = true;
            // 
            // chkAnt9
            // 
            this.chkAnt9.AutoSize = true;
            this.chkAnt9.Location = new System.Drawing.Point(420, 63);
            this.chkAnt9.Name = "chkAnt9";
            this.chkAnt9.Size = new System.Drawing.Size(51, 17);
            this.chkAnt9.TabIndex = 67;
            this.chkAnt9.Text = "Ant 9";
            this.chkAnt9.UseVisualStyleBackColor = true;
            // 
            // chkAnt8
            // 
            this.chkAnt8.AutoSize = true;
            this.chkAnt8.Location = new System.Drawing.Point(24, 290);
            this.chkAnt8.Name = "chkAnt8";
            this.chkAnt8.Size = new System.Drawing.Size(51, 17);
            this.chkAnt8.TabIndex = 66;
            this.chkAnt8.Text = "Ant 8";
            this.chkAnt8.UseVisualStyleBackColor = true;
            // 
            // chkAnt7
            // 
            this.chkAnt7.AutoSize = true;
            this.chkAnt7.Location = new System.Drawing.Point(24, 258);
            this.chkAnt7.Name = "chkAnt7";
            this.chkAnt7.Size = new System.Drawing.Size(51, 17);
            this.chkAnt7.TabIndex = 65;
            this.chkAnt7.Text = "Ant 7";
            this.chkAnt7.UseVisualStyleBackColor = true;
            // 
            // chkAnt6
            // 
            this.chkAnt6.AutoSize = true;
            this.chkAnt6.Location = new System.Drawing.Point(24, 225);
            this.chkAnt6.Name = "chkAnt6";
            this.chkAnt6.Size = new System.Drawing.Size(51, 17);
            this.chkAnt6.TabIndex = 64;
            this.chkAnt6.Text = "Ant 6";
            this.chkAnt6.UseVisualStyleBackColor = true;
            // 
            // chkAnt5
            // 
            this.chkAnt5.AutoSize = true;
            this.chkAnt5.Location = new System.Drawing.Point(24, 193);
            this.chkAnt5.Name = "chkAnt5";
            this.chkAnt5.Size = new System.Drawing.Size(51, 17);
            this.chkAnt5.TabIndex = 63;
            this.chkAnt5.Text = "Ant 5";
            this.chkAnt5.UseVisualStyleBackColor = true;
            // 
            // chkAnt4
            // 
            this.chkAnt4.AutoSize = true;
            this.chkAnt4.Location = new System.Drawing.Point(24, 160);
            this.chkAnt4.Name = "chkAnt4";
            this.chkAnt4.Size = new System.Drawing.Size(51, 17);
            this.chkAnt4.TabIndex = 62;
            this.chkAnt4.Text = "Ant 4";
            this.chkAnt4.UseVisualStyleBackColor = true;
            // 
            // chkAnt3
            // 
            this.chkAnt3.AutoSize = true;
            this.chkAnt3.Location = new System.Drawing.Point(24, 128);
            this.chkAnt3.Name = "chkAnt3";
            this.chkAnt3.Size = new System.Drawing.Size(51, 17);
            this.chkAnt3.TabIndex = 61;
            this.chkAnt3.Text = "Ant 3";
            this.chkAnt3.UseVisualStyleBackColor = true;
            // 
            // chkAnt2
            // 
            this.chkAnt2.AutoSize = true;
            this.chkAnt2.Location = new System.Drawing.Point(24, 95);
            this.chkAnt2.Name = "chkAnt2";
            this.chkAnt2.Size = new System.Drawing.Size(51, 17);
            this.chkAnt2.TabIndex = 60;
            this.chkAnt2.Text = "Ant 2";
            this.chkAnt2.UseVisualStyleBackColor = true;
            // 
            // chkAnt1
            // 
            this.chkAnt1.AutoSize = true;
            this.chkAnt1.Location = new System.Drawing.Point(24, 63);
            this.chkAnt1.Name = "chkAnt1";
            this.chkAnt1.Size = new System.Drawing.Size(51, 17);
            this.chkAnt1.TabIndex = 59;
            this.chkAnt1.Text = "Ant 1";
            this.chkAnt1.UseVisualStyleBackColor = true;
            // 
            // btnAntSet
            // 
            this.btnAntSet.Location = new System.Drawing.Point(706, 340);
            this.btnAntSet.Name = "btnAntSet";
            this.btnAntSet.Size = new System.Drawing.Size(95, 32);
            this.btnAntSet.TabIndex = 58;
            this.btnAntSet.Text = "设置";
            this.btnAntSet.UseVisualStyleBackColor = true;
            this.btnAntSet.Click += new System.EventHandler(this.btnAntSet_Click);
            // 
            // btnReadChannelCount
            // 
            this.btnReadChannelCount.Location = new System.Drawing.Point(509, 340);
            this.btnReadChannelCount.Name = "btnReadChannelCount";
            this.btnReadChannelCount.Size = new System.Drawing.Size(94, 32);
            this.btnReadChannelCount.TabIndex = 58;
            this.btnReadChannelCount.Text = "查询通道";
            this.btnReadChannelCount.UseVisualStyleBackColor = true;
            this.btnReadChannelCount.Click += new System.EventHandler(this.btnReadChannelCount_Click);
            // 
            // btnAntRead
            // 
            this.btnAntRead.Location = new System.Drawing.Point(606, 340);
            this.btnAntRead.Name = "btnAntRead";
            this.btnAntRead.Size = new System.Drawing.Size(94, 32);
            this.btnAntRead.TabIndex = 58;
            this.btnAntRead.Text = "读取";
            this.btnAntRead.UseVisualStyleBackColor = true;
            this.btnAntRead.Click += new System.EventHandler(this.btnAntRead_Click);
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.btnSubmit);
            this.tpGeneral.Controls.Add(this.txtTotalQty);
            this.tpGeneral.Controls.Add(this.lblTotalQty);
            this.tpGeneral.Controls.Add(this.txtArmyNo);
            this.tpGeneral.Controls.Add(this.lblArmyNo);
            this.tpGeneral.Controls.Add(this.dateTimePickerIssueDate);
            this.tpGeneral.Controls.Add(this.labelIssueDate);
            this.tpGeneral.Controls.Add(this.dateTimePickerChallanDate);
            this.tpGeneral.Controls.Add(this.labelChallanDate);
            this.tpGeneral.Controls.Add(this.cmbSelectChalan);
            this.tpGeneral.Controls.Add(this.lblSelectChalan);
            this.tpGeneral.Controls.Add(this.btnReadOnce);
            this.tpGeneral.Controls.Add(this.btnStartReadData);
            this.tpGeneral.Controls.Add(this.btnStopReadData);
            this.tpGeneral.Controls.Add(this.cbSaveFile);
            this.tpGeneral.Controls.Add(this.btnClearListView);
            this.tpGeneral.Controls.Add(this.lblCount);
            this.tpGeneral.Controls.Add(this.lblTagCount);
            this.tpGeneral.Controls.Add(this.labReadCount);
            this.tpGeneral.Controls.Add(this.labTagCount);
            this.tpGeneral.Controls.Add(this.rbDesc);
            this.tpGeneral.Controls.Add(this.rbAsc);
            this.tpGeneral.Controls.Add(this.labelVersion);
            this.tpGeneral.Controls.Add(this.listView);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Margin = new System.Windows.Forms.Padding(1);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(1);
            this.tpGeneral.Size = new System.Drawing.Size(864, 680);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "Zone Reader";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(155, 608);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(276, 41);
            this.btnSubmit.TabIndex = 52;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.Enabled = false;
            this.txtTotalQty.Location = new System.Drawing.Point(151, 134);
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.Size = new System.Drawing.Size(100, 20);
            this.txtTotalQty.TabIndex = 51;
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.AutoSize = true;
            this.lblTotalQty.Location = new System.Drawing.Point(17, 141);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(50, 13);
            this.lblTotalQty.TabIndex = 50;
            this.lblTotalQty.Text = "Total Qty";
            // 
            // txtArmyNo
            // 
            this.txtArmyNo.Location = new System.Drawing.Point(151, 106);
            this.txtArmyNo.Name = "txtArmyNo";
            this.txtArmyNo.Size = new System.Drawing.Size(200, 20);
            this.txtArmyNo.TabIndex = 49;
            // 
            // lblArmyNo
            // 
            this.lblArmyNo.AutoSize = true;
            this.lblArmyNo.Location = new System.Drawing.Point(17, 103);
            this.lblArmyNo.Name = "lblArmyNo";
            this.lblArmyNo.Size = new System.Drawing.Size(50, 13);
            this.lblArmyNo.TabIndex = 48;
            this.lblArmyNo.Text = "Army No.";
            // 
            // dateTimePickerIssueDate
            // 
            this.dateTimePickerIssueDate.Location = new System.Drawing.Point(151, 31);
            this.dateTimePickerIssueDate.Name = "dateTimePickerIssueDate";
            this.dateTimePickerIssueDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerIssueDate.TabIndex = 47;
            // 
            // labelIssueDate
            // 
            this.labelIssueDate.AutoSize = true;
            this.labelIssueDate.Location = new System.Drawing.Point(17, 38);
            this.labelIssueDate.Name = "labelIssueDate";
            this.labelIssueDate.Size = new System.Drawing.Size(56, 13);
            this.labelIssueDate.TabIndex = 46;
            this.labelIssueDate.Text = "Issue date";
            // 
            // dateTimePickerChallanDate
            // 
            this.dateTimePickerChallanDate.Location = new System.Drawing.Point(151, 71);
            this.dateTimePickerChallanDate.Name = "dateTimePickerChallanDate";
            this.dateTimePickerChallanDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerChallanDate.TabIndex = 45;
            // 
            // labelChallanDate
            // 
            this.labelChallanDate.AutoSize = true;
            this.labelChallanDate.Location = new System.Drawing.Point(17, 76);
            this.labelChallanDate.Name = "labelChallanDate";
            this.labelChallanDate.Size = new System.Drawing.Size(63, 13);
            this.labelChallanDate.TabIndex = 44;
            this.labelChallanDate.Text = "Challandate";
            // 
            // cmbSelectChalan
            // 
            this.cmbSelectChalan.FormattingEnabled = true;
            this.cmbSelectChalan.Location = new System.Drawing.Point(151, 4);
            this.cmbSelectChalan.Name = "cmbSelectChalan";
            this.cmbSelectChalan.Size = new System.Drawing.Size(254, 21);
            this.cmbSelectChalan.TabIndex = 43;
            this.cmbSelectChalan.SelectedIndexChanged += new System.EventHandler(this.cmbSelectChalan_SelectedIndexChanged);
            // 
            // lblSelectChalan
            // 
            this.lblSelectChalan.AutoSize = true;
            this.lblSelectChalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectChalan.Location = new System.Drawing.Point(11, 9);
            this.lblSelectChalan.Name = "lblSelectChalan";
            this.lblSelectChalan.Size = new System.Drawing.Size(90, 16);
            this.lblSelectChalan.TabIndex = 42;
            this.lblSelectChalan.Text = "Select Chalan";
            // 
            // btnReadOnce
            // 
            this.btnReadOnce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReadOnce.Location = new System.Drawing.Point(14, 544);
            this.btnReadOnce.Name = "btnReadOnce";
            this.btnReadOnce.Size = new System.Drawing.Size(93, 41);
            this.btnReadOnce.TabIndex = 1;
            this.btnReadOnce.Text = "寻卡一次";
            this.btnReadOnce.UseVisualStyleBackColor = true;
            this.btnReadOnce.Click += new System.EventHandler(this.btnReadOnce_Click);
            // 
            // btnStartReadData
            // 
            this.btnStartReadData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartReadData.Location = new System.Drawing.Point(119, 544);
            this.btnStartReadData.Name = "btnStartReadData";
            this.btnStartReadData.Size = new System.Drawing.Size(93, 41);
            this.btnStartReadData.TabIndex = 2;
            this.btnStartReadData.Text = "开始连续寻卡";
            this.btnStartReadData.UseVisualStyleBackColor = true;
            this.btnStartReadData.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStopReadData
            // 
            this.btnStopReadData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStopReadData.Location = new System.Drawing.Point(348, 544);
            this.btnStopReadData.Name = "btnStopReadData";
            this.btnStopReadData.Size = new System.Drawing.Size(93, 41);
            this.btnStopReadData.TabIndex = 3;
            this.btnStopReadData.Text = "停止连续寻卡";
            this.btnStopReadData.UseVisualStyleBackColor = true;
            this.btnStopReadData.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // cbSaveFile
            // 
            this.cbSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSaveFile.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSaveFile.Location = new System.Drawing.Point(14, 608);
            this.cbSaveFile.Name = "cbSaveFile";
            this.cbSaveFile.Size = new System.Drawing.Size(134, 41);
            this.cbSaveFile.TabIndex = 41;
            this.cbSaveFile.Text = "自动保存为文件";
            this.cbSaveFile.UseVisualStyleBackColor = true;
            this.cbSaveFile.CheckedChanged += new System.EventHandler(this.cbSaveFile_CheckedChanged);
            // 
            // btnClearListView
            // 
            this.btnClearListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearListView.Location = new System.Drawing.Point(229, 544);
            this.btnClearListView.Name = "btnClearListView";
            this.btnClearListView.Size = new System.Drawing.Size(93, 41);
            this.btnClearListView.TabIndex = 4;
            this.btnClearListView.Text = "清空";
            this.btnClearListView.UseVisualStyleBackColor = true;
            this.btnClearListView.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCount
            // 
            this.lblCount.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCount.Location = new System.Drawing.Point(321, 15);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(110, 32);
            this.lblCount.TabIndex = 37;
            this.lblCount.Text = "0";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCount.Visible = false;
            // 
            // lblTagCount
            // 
            this.lblTagCount.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTagCount.ForeColor = System.Drawing.Color.Red;
            this.lblTagCount.Location = new System.Drawing.Point(110, 15);
            this.lblTagCount.Name = "lblTagCount";
            this.lblTagCount.Size = new System.Drawing.Size(80, 32);
            this.lblTagCount.TabIndex = 36;
            this.lblTagCount.Text = "0";
            this.lblTagCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTagCount.Visible = false;
            // 
            // labReadCount
            // 
            this.labReadCount.AutoEllipsis = true;
            this.labReadCount.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labReadCount.Location = new System.Drawing.Point(196, 16);
            this.labReadCount.Name = "labReadCount";
            this.labReadCount.Size = new System.Drawing.Size(100, 32);
            this.labReadCount.TabIndex = 35;
            this.labReadCount.Text = "读取次数:";
            this.labReadCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labReadCount.Visible = false;
            // 
            // labTagCount
            // 
            this.labTagCount.AutoEllipsis = true;
            this.labTagCount.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTagCount.Location = new System.Drawing.Point(4, 16);
            this.labTagCount.Name = "labTagCount";
            this.labTagCount.Size = new System.Drawing.Size(100, 32);
            this.labTagCount.TabIndex = 34;
            this.labTagCount.Text = "标签数:";
            this.labTagCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labTagCount.Visible = false;
            this.labTagCount.Click += new System.EventHandler(this.labTagCount_Click);
            // 
            // rbDesc
            // 
            this.rbDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbDesc.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbDesc.Location = new System.Drawing.Point(764, 11);
            this.rbDesc.Name = "rbDesc";
            this.rbDesc.Size = new System.Drawing.Size(90, 32);
            this.rbDesc.TabIndex = 32;
            this.rbDesc.TabStop = true;
            this.rbDesc.Text = "降序";
            this.rbDesc.UseVisualStyleBackColor = true;
            this.rbDesc.CheckedChanged += new System.EventHandler(this.rbDesc_CheckedChanged);
            // 
            // rbAsc
            // 
            this.rbAsc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbAsc.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbAsc.Location = new System.Drawing.Point(695, 11);
            this.rbAsc.Name = "rbAsc";
            this.rbAsc.Size = new System.Drawing.Size(63, 32);
            this.rbAsc.TabIndex = 31;
            this.rbAsc.TabStop = true;
            this.rbAsc.Text = "升序";
            this.rbAsc.UseVisualStyleBackColor = true;
            this.rbAsc.CheckedChanged += new System.EventHandler(this.rbAsc_CheckedChanged);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(40, 441);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(0, 13);
            this.labelVersion.TabIndex = 30;
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_serial_number,
            this.list_EPC,
            this.list_count,
            this.list_antenna_no,
            this.list_device_no,
            this.list_Uart_IP,
            this.list_current_time,
            this.list_rssi,
            this.list_alarm_status,
            this.list_private_data,
            this.list_temperature,
            this.list_user_custome_data,
            this.list_EPC_data,
            this.list_TID_data,
            this.list_User_data});
            this.listView.ContextMenuStrip = this.cmsMenu;
            this.listView.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(484, 44);
            this.listView.Name = "listView";
            this.listView.ReadOnly = false;
            this.listView.Size = new System.Drawing.Size(372, 632);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // list_serial_number
            // 
            this.list_serial_number.Text = "序号";
            this.list_serial_number.Width = 45;
            // 
            // list_EPC
            // 
            this.list_EPC.Text = "EPC";
            this.list_EPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_EPC.Width = 300;
            // 
            // list_count
            // 
            this.list_count.Text = "次数";
            this.list_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // list_antenna_no
            // 
            this.list_antenna_no.Text = "天线号";
            this.list_antenna_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // list_device_no
            // 
            this.list_device_no.Text = "设备号";
            this.list_device_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // list_Uart_IP
            // 
            this.list_Uart_IP.Text = "Uart/IP";
            this.list_Uart_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_Uart_IP.Width = 150;
            // 
            // list_current_time
            // 
            this.list_current_time.Text = "当前时间";
            this.list_current_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_current_time.Width = 150;
            // 
            // list_rssi
            // 
            this.list_rssi.Text = "RSSI";
            // 
            // list_alarm_status
            // 
            this.list_alarm_status.Text = "Alarm Status";
            this.list_alarm_status.Width = 114;
            // 
            // list_private_data
            // 
            this.list_private_data.Text = "Private Data";
            this.list_private_data.Width = 110;
            // 
            // list_temperature
            // 
            this.list_temperature.Text = "Temperature";
            // 
            // list_user_custome_data
            // 
            this.list_user_custome_data.Text = "User Data";
            // 
            // list_EPC_data
            // 
            this.list_EPC_data.Text = "EPC";
            // 
            // list_TID_data
            // 
            this.list_TID_data.Text = "TID";
            // 
            // list_User_data
            // 
            this.list_User_data.Text = "User";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tpGeneral);
            this.tabControl.Controls.Add(this.tpAntennaParams);
            this.tabControl.Controls.Add(this.tpTagAccess);
            this.tabControl.Controls.Add(this.tpSetCommParam);
            this.tabControl.Controls.Add(this.tbSetReaderParam);
            this.tabControl.Controls.Add(this.tpOtherOpreation);
            this.tabControl.Location = new System.Drawing.Point(299, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(872, 706);
            this.tabControl.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1171, 749);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.tvConnectList);
            this.Controls.Add(this.gbConnectType);
            this.Controls.Add(this.gbVersionInfo);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.cbbLangSwitch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TM200_Demo_V3.02";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.cmsMenu.ResumeLayout(false);
            this.gbVersionInfo.ResumeLayout(false);
            this.gbConnectType.ResumeLayout(false);
            this.tbConnect.ResumeLayout(false);
            this.tpSerialPort.ResumeLayout(false);
            this.tpTCPClient.ResumeLayout(false);
            this.tpTCPClient.PerformLayout();
            this.tpTCPServer.ResumeLayout(false);
            this.tpTCPServer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tpOtherOpreation.ResumeLayout(false);
            this.gbTCPConfig.ResumeLayout(false);
            this.gbTCPConfig.PerformLayout();
            this.gbHttpConfig.ResumeLayout(false);
            this.gbHttpConfig.PerformLayout();
            this.gbGSPConfig.ResumeLayout(false);
            this.gbGSPConfig.PerformLayout();
            this.gbNetworkParams.ResumeLayout(false);
            this.gbNetworkParams.PerformLayout();
            this.gbWifiConfig.ResumeLayout(false);
            this.tbWifiTCPConfig.ResumeLayout(false);
            this.tbWifiTCPConfig.PerformLayout();
            this.gbWifiConnectConfig.ResumeLayout(false);
            this.gbWifiConnectConfig.PerformLayout();
            this.tbSetReaderParam.ResumeLayout(false);
            this.gbUserCustomData.ResumeLayout(false);
            this.gbUserCustomData.PerformLayout();
            this.gbLEDLamp.ResumeLayout(false);
            this.gbDevNo.ResumeLayout(false);
            this.gbDevNo.PerformLayout();
            this.gbLinkModel.ResumeLayout(false);
            this.gbFreq.ResumeLayout(false);
            this.gbFreq.PerformLayout();
            this.gbDataOutputFormat.ResumeLayout(false);
            this.gbDataOutputFormat.PerformLayout();
            this.gbCommModeParam.ResumeLayout(false);
            this.tbCommMode.ResumeLayout(false);
            this.tpRS232.ResumeLayout(false);
            this.tpRS485.ResumeLayout(false);
            this.tpWiegand.ResumeLayout(false);
            this.tpWiegand.PerformLayout();
            this.GopRelayControl.ResumeLayout(false);
            this.tbRelayMode.ResumeLayout(false);
            this.tpPassivity.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpInitiative.ResumeLayout(false);
            this.gbWorkMode.ResumeLayout(false);
            this.gbWorkMode.PerformLayout();
            this.tbWorkMode.ResumeLayout(false);
            this.tpTrigger.ResumeLayout(false);
            this.tpTrigger.PerformLayout();
            this.tpSetCommParam.ResumeLayout(false);
            this.gbSPParams.ResumeLayout(false);
            this.gbSPParams.PerformLayout();
            this.gbNetParams.ResumeLayout(false);
            this.gbNetParams.PerformLayout();
            this.tpTagAccess.ResumeLayout(false);
            this.gbTagAuth.ResumeLayout(false);
            this.gbTagAuth.PerformLayout();
            this.gbTagType.ResumeLayout(false);
            this.gbSpecifiedAddressAndLength.ResumeLayout(false);
            this.gbSpecifiedAddressAndLength.PerformLayout();
            this.gbKillTag.ResumeLayout(false);
            this.gbKillTag.PerformLayout();
            this.gbTagLockAndUnlock.ResumeLayout(false);
            this.gbTagLockAndUnlock.PerformLayout();
            this.gbFastWrite.ResumeLayout(false);
            this.gbFastWrite.PerformLayout();
            this.gbRWData.ResumeLayout(false);
            this.gbRWData.PerformLayout();
            this.gbBeepControl.ResumeLayout(false);
            this.tpAntennaParams.ResumeLayout(false);
            this.gbAdjacentDiscriminant.ResumeLayout(false);
            this.tabControlAdjacentDiscriminant.ResumeLayout(false);
            this.tabPageUnify.ResumeLayout(false);
            this.tabPageUnify.PerformLayout();
            this.tabPageAlone.ResumeLayout(false);
            this.tabPageAlone.PerformLayout();
            this.grpAntSet.ResumeLayout(false);
            this.grpAntSet.PerformLayout();
            this.tpGeneral.ResumeLayout(false);
            this.tpGeneral.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbLangSwitch;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label TagTID;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label15;


        //private System.Windows.Forms.CheckBox chkAnt8;
        //private System.Windows.Forms.CheckBox chkAnt4;
        //private System.Windows.Forms.CheckBox chkAnt7;
        //private System.Windows.Forms.CheckBox chkAnt6;
        //private System.Windows.Forms.CheckBox chkAnt3;
        //private System.Windows.Forms.CheckBox chkAnt5;
        //private System.Windows.Forms.CheckBox chkAnt2;
        //private System.Windows.Forms.CheckBox chkAnt1;     //2021-03-06
        //private System.Windows.Forms.ListView listView;        //2021-03-06
        private System.Windows.Forms.GroupBox gbVersionInfo;
        private System.Windows.Forms.GroupBox gbConnectType;
        private System.Windows.Forms.Button btnReadVersion;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TabControl tbConnect;
        private System.Windows.Forms.TabPage tpSerialPort;
        private System.Windows.Forms.TabPage tpTCPClient;
        private System.Windows.Forms.TabPage tpTCPServer;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.ComboBox cbbBaudRate;
        private System.Windows.Forms.Label lblSerialPort;
        private System.Windows.Forms.ComboBox cbbSerialPort;
        private System.Windows.Forms.Button btnUpdateSerialPort;
        private System.Windows.Forms.Button btnSerialPortDisconnect;
        private System.Windows.Forms.Button btnSerialPortConnect;
        private System.Windows.Forms.TextBox tbTCPClientPort;
        private System.Windows.Forms.Label lblTCPClientPort;
        private System.Windows.Forms.Label lblTCPClientIP;
        private System.Windows.Forms.ComboBox cbbTCPClientIP;
        private System.Windows.Forms.Button btnTCPClientDisconnect;
        private System.Windows.Forms.Button btnTCPClientConnect;
        private System.Windows.Forms.TextBox tbTCPServerPort;
        private System.Windows.Forms.Label lblTCPServerPort;
        private System.Windows.Forms.Label lblTCPServerIP;
        private System.Windows.Forms.Button btnUpdateTCPServer;
        private System.Windows.Forms.ComboBox cbbTCPServerIP;
        private System.Windows.Forms.Button btnStopMonitor;
        private System.Windows.Forms.Button btnStartMonitor;
        private System.Windows.Forms.TreeView tvConnectList;
        private System.Windows.Forms.Button btnBrushVersion;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Button btnUpdateTCPClient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblInfoShow;
        private System.Windows.Forms.Label lblMessageHit;
        private System.Windows.Forms.Timer timerConnRead;
        private System.Windows.Forms.TabPage tpOtherOpreation;
        private System.Windows.Forms.GroupBox gbTCPConfig;
        private System.Windows.Forms.CheckBox chk4G;
        private System.Windows.Forms.CheckBox chkWifi;
        private System.Windows.Forms.CheckBox chkNetwork;
        private System.Windows.Forms.Button btnQueryTCPConfig;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Button btnUpdateTCPConfig;
        private System.Windows.Forms.Label lblTCPPort;
        private System.Windows.Forms.Label lblTCPCommunicationType;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.TextBox tbTCPPort;
        private System.Windows.Forms.GroupBox gbHttpConfig;
        private System.Windows.Forms.Button btnQueryHttpConfig;
        private System.Windows.Forms.Label lblHttpUrl;
        private System.Windows.Forms.Button btnUpdateHttpConfig;
        private System.Windows.Forms.Label lblHttpPort;
        private System.Windows.Forms.Label lblHttpReportingInterval;
        private System.Windows.Forms.Label lblHttpCommunicationType;
        private System.Windows.Forms.ComboBox cbbHttpCommunicationType;
        private System.Windows.Forms.ComboBox cbbHttpReportingInterval;
        private System.Windows.Forms.TextBox tbHttpURL;
        private System.Windows.Forms.TextBox tbHttpPort;
        private System.Windows.Forms.GroupBox gbGSPConfig;
        private System.Windows.Forms.Button btnQueryGSPConfig;
        private System.Windows.Forms.Button btnUpdateGPSConfig;
        private System.Windows.Forms.ComboBox cbbCommunicationType;
        private System.Windows.Forms.ComboBox cbbGPSReportingInterval;
        private System.Windows.Forms.Label lblGPSReportingInterval;
        private System.Windows.Forms.Label lblCommunicationType;
        private System.Windows.Forms.GroupBox gbNetworkParams;
        private System.Windows.Forms.Button btnDefaultNetworkParams;
        private System.Windows.Forms.Button btnQueryNetworkParams;
        private System.Windows.Forms.Button btnUpdateNetworkParams;
        private System.Windows.Forms.ComboBox cbbIPModel;
        private System.Windows.Forms.Label lblNetworkParamsClientConfig;
        private System.Windows.Forms.Label lblGateway;
        private System.Windows.Forms.Label lblDevicePort;
        private System.Windows.Forms.Label lblMacAddress;
        private System.Windows.Forms.Label lblSubnetMask;
        private System.Windows.Forms.Label lblDns;
        private System.Windows.Forms.Label lblDeviceIPAddress;
        private System.Windows.Forms.Label lblNetworkDestPort;
        private System.Windows.Forms.Label lblIPModel;
        private System.Windows.Forms.ComboBox cbbNetworkDestIP;
        private System.Windows.Forms.ComboBox cbbNetworkPattern;
        private System.Windows.Forms.Label lblNetworkDestIP;
        private System.Windows.Forms.Label lblNetworkPattern;
        private System.Windows.Forms.TextBox tbGateway;
        private System.Windows.Forms.TextBox tbDevicePort;
        private System.Windows.Forms.TextBox tbMacAddress;
        private System.Windows.Forms.TextBox tbNetworkDestPort;
        private System.Windows.Forms.TextBox tbDns;
        private System.Windows.Forms.TextBox tbSubnetMask;
        private System.Windows.Forms.TextBox tbIPAddress;
        private System.Windows.Forms.GroupBox gbWifiConfig;
        private System.Windows.Forms.GroupBox tbWifiTCPConfig;
        private System.Windows.Forms.Button btnQueryWifiTCPConfig;
        private System.Windows.Forms.Button btnUpdateWifiTCPConfig;
        private System.Windows.Forms.Button btnLocalHost;
        private System.Windows.Forms.TextBox tbTCPDestPort;
        private System.Windows.Forms.ComboBox cbbTCPDestIP;
        private System.Windows.Forms.Label lblDestPort;
        private System.Windows.Forms.Label lblDestIP;
        private System.Windows.Forms.GroupBox gbWifiConnectConfig;
        private System.Windows.Forms.Button btnQueryWifi;
        private System.Windows.Forms.Button btnUpdateWifi;
        private System.Windows.Forms.TextBox tbWifiConnectPwd;
        private System.Windows.Forms.ComboBox cbbSSID;
        private System.Windows.Forms.CheckBox chkWifiPwd;
        private System.Windows.Forms.Label lblSSID;
        private System.Windows.Forms.TabPage tbSetReaderParam;
        private System.Windows.Forms.GroupBox gbUserCustomData;
        private System.Windows.Forms.Label lblUserCustomData;
        private System.Windows.Forms.Button btnQueryUserCustomData;
        private System.Windows.Forms.TextBox tbUserCustomData;
        private System.Windows.Forms.Button btnUpdateUserCustomData;
        private System.Windows.Forms.Button btnDeviceReset;
        private System.Windows.Forms.Button btnFactorySetting;
        private System.Windows.Forms.GroupBox gbLEDLamp;
        private System.Windows.Forms.Button btnSetLamp;
        private System.Windows.Forms.Button btnReadBeep;
        private System.Windows.Forms.Label lblLedLamp;
        private System.Windows.Forms.Label lblReadVoice;
        private System.Windows.Forms.Button btnSetBeep;
        private System.Windows.Forms.Button btnGetLamp;
        private System.Windows.Forms.ComboBox cbbLamp;
        private System.Windows.Forms.ComboBox cbbBeepControl;
        private System.Windows.Forms.GroupBox gbDevNo;
        private System.Windows.Forms.Button btnSetDeviceId;
        private System.Windows.Forms.Button btnReadDeviceId;
        private System.Windows.Forms.TextBox tbNewDevNo;
        private System.Windows.Forms.GroupBox gbLinkModel;
        private System.Windows.Forms.Button btnUpdateLinkModel;
        private System.Windows.Forms.Button btnDefaultLinkModel;
        private System.Windows.Forms.Button btnQueryLinkModel;
        private System.Windows.Forms.ComboBox cbbLinkModel;
        private System.Windows.Forms.GroupBox gbFreq;
        private System.Windows.Forms.TextBox tbChannelSpacing;
        private System.Windows.Forms.Label lblChannelSpacingUnit;
        private System.Windows.Forms.Label lblStartFrequUnit;
        private System.Windows.Forms.ComboBox cbbEndFrequ;
        private System.Windows.Forms.Label lblEndFrequ;
        private System.Windows.Forms.ComboBox cbbStartFrequ;
        private System.Windows.Forms.Label lblChannelSpacing;
        private System.Windows.Forms.Label lblStartFrequ;
        private System.Windows.Forms.Label lblFrequencyArea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDefaultFreq;
        private System.Windows.Forms.Button btnReadFreq;
        private System.Windows.Forms.ComboBox cbbFrequencyBand;
        private System.Windows.Forms.Label labSetParam;
        private System.Windows.Forms.Button btnSetFreq;
        private System.Windows.Forms.GroupBox gbDataOutputFormat;
        private System.Windows.Forms.Button btnQueryOutputformat;
        private System.Windows.Forms.Button btnUpdateOutputFormat;
        private System.Windows.Forms.CheckBox chkUseCustomeData;
        private System.Windows.Forms.CheckBox chkTagArea;
        private System.Windows.Forms.CheckBox chkTagTime;
        private System.Windows.Forms.CheckBox chkPcValue;
        private System.Windows.Forms.CheckBox chkPrivateData;
        private System.Windows.Forms.CheckBox chkRssi;
        private System.Windows.Forms.CheckBox chkAlarmState;
        private System.Windows.Forms.CheckBox chkAntennaId;
        private System.Windows.Forms.GroupBox gbCommModeParam;
        private System.Windows.Forms.TabControl tbCommMode;
        private System.Windows.Forms.TabPage tpRS232;
        private System.Windows.Forms.ComboBox cbbBaud_Rate;
        private System.Windows.Forms.Label lbl_rate;
        private System.Windows.Forms.TabPage tpRS485;
        private System.Windows.Forms.ComboBox cbbRS485BaudRate;
        private System.Windows.Forms.Label lblRS485BaudRate;
        private System.Windows.Forms.TabPage tpWiegand;
        private System.Windows.Forms.Label labPulseWidthUnit;
        private System.Windows.Forms.Label labPulseWidth;
        private System.Windows.Forms.Label labPulseCycleUnit;
        private System.Windows.Forms.Label lblWigginsTakePlaceValue;
        private System.Windows.Forms.TextBox tbPulseWidth;
        private System.Windows.Forms.ComboBox cbbWigginsTakePlaceValue;
        private System.Windows.Forms.Label labWiegandProtocol;
        private System.Windows.Forms.TextBox tbPulseCycle;
        private System.Windows.Forms.Label labPulseCycle;
        private System.Windows.Forms.ComboBox cbbWiegandProtocol;
        private System.Windows.Forms.TabPage tpRJ45;
        private System.Windows.Forms.TabPage tpWifi;
        private System.Windows.Forms.TabPage tp3G_4G;
        private System.Windows.Forms.Button btnDefaultCommMode;
        private System.Windows.Forms.Button btnReadCommMode;
        private System.Windows.Forms.Button btnSetCommMode;
        private System.Windows.Forms.GroupBox GopRelayControl;
        private System.Windows.Forms.TabControl tbRelayMode;
        private System.Windows.Forms.TabPage tpPassivity;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbOpen2;
        private System.Windows.Forms.RadioButton rbClose2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbClose1;
        private System.Windows.Forms.RadioButton rbOpen1;
        private System.Windows.Forms.TabPage tpInitiative;
        private System.Windows.Forms.Label lblCloseTime;
        private System.Windows.Forms.ComboBox cbbRelayTime;
        private System.Windows.Forms.Button btnSetRelay;
        private System.Windows.Forms.Button btnQueryRelay;
        private System.Windows.Forms.GroupBox gbWorkMode;
        private System.Windows.Forms.Button btnUpdateAdjaDiscri;
        private System.Windows.Forms.Button btnReadAdjaDiscri;
        private System.Windows.Forms.TabControl tbWorkMode;
        private System.Windows.Forms.TabPage tpMaster;
        private System.Windows.Forms.TabPage tpTiming;
        private System.Windows.Forms.TabPage tpTrigger;
        private System.Windows.Forms.Label labDelayUnit;
        private System.Windows.Forms.Label labTrigParam;
        private System.Windows.Forms.TextBox tbDelay;
        private System.Windows.Forms.Label chkAjaDisc;
        private System.Windows.Forms.Button btnDefaultWorkMode;
        private System.Windows.Forms.Button btnReadWorkMode;
        private System.Windows.Forms.Button btnSetWorkMode;
        private System.Windows.Forms.TextBox tbNeighJudge;
        private System.Windows.Forms.TabPage tpSetCommParam;
        private System.Windows.Forms.GroupBox gbSPParams;
        private System.Windows.Forms.Label labDataBits;
        private System.Windows.Forms.Label labCheckBits;
        private System.Windows.Forms.Label labBaudRate;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ComboBox comboBoxCheckBits;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.GroupBox gbNetParams;
        private System.Windows.Forms.ComboBox cbbDestIP;
        private System.Windows.Forms.Label labPromotion;
        private System.Windows.Forms.Label labDestPort;
        private System.Windows.Forms.Label labDestIP;
        private System.Windows.Forms.Label labGateway;
        private System.Windows.Forms.Label labPort;
        private System.Windows.Forms.Label labMask;
        private System.Windows.Forms.Label labIPAdd;
        private System.Windows.Forms.Label labIPMode;
        private System.Windows.Forms.Label labNetMode;
        private System.Windows.Forms.TextBox textBoxDestPort;
        private System.Windows.Forms.TextBox tbDestIP;
        private System.Windows.Forms.TextBox textBoxGateway;
        private System.Windows.Forms.TextBox textBoxPortNo;
        private System.Windows.Forms.TextBox textBoxNetMask;
        private System.Windows.Forms.TextBox textBoxIPAdd;
        private System.Windows.Forms.ComboBox comboBoxIPMode;
        private System.Windows.Forms.ComboBox comboBoxNetMode;
        private System.Windows.Forms.Button btnSetParams;
        private System.Windows.Forms.Button btnDefaultParams;
        private System.Windows.Forms.Button btnModifyDev;
        private System.Windows.Forms.Button btnSearchDev;
        private System.Windows.Forms.ListView lvZl;
        private System.Windows.Forms.ColumnHeader columnHeaderNo;
        private System.Windows.Forms.ColumnHeader columnHeaderIPAdd;
        private System.Windows.Forms.ColumnHeader columnHeaderPort;
        private System.Windows.Forms.ColumnHeader columnHeaderMAC;
        protected internal System.Windows.Forms.TabPage tpTagAccess;
        private System.Windows.Forms.GroupBox gbTagAuth;
        private System.Windows.Forms.Button btnQueryAuthorize;
        private System.Windows.Forms.Button btnModifyAuthorize;
        private System.Windows.Forms.Button btnTagAuthorize;
        private System.Windows.Forms.TextBox tbNewAuthorizePwd;
        private System.Windows.Forms.TextBox tbOldAuthorizePwd;
        private System.Windows.Forms.Label labNewAuthPwd;
        private System.Windows.Forms.Label labAuthPwd;
        private System.Windows.Forms.GroupBox gbTagType;
        private System.Windows.Forms.Label lblTagType;
        private System.Windows.Forms.Button btnTagTypeSet;
        private System.Windows.Forms.Button btnTagTypeRead;
        private System.Windows.Forms.ComboBox cbbTagType;
        private System.Windows.Forms.GroupBox gbSpecifiedAddressAndLength;
        private System.Windows.Forms.CheckBox chbEnable;
        private System.Windows.Forms.Button btnSpecifiedAddressAndLengthSet;
        private System.Windows.Forms.Button btnSpecifiedAddressAndLengthRead;
        private System.Windows.Forms.Label lblTagArea;
        private System.Windows.Forms.ComboBox cbbTagArea;
        private System.Windows.Forms.Label labLength2;
        private System.Windows.Forms.Label labStartAdd2;
        private System.Windows.Forms.ComboBox cbbStartAddress2;
        private System.Windows.Forms.ComboBox cbbLength2;
        private System.Windows.Forms.GroupBox gbKillTag;
        private System.Windows.Forms.TextBox tbKillKillPwd;
        private System.Windows.Forms.Button btnKillTag;
        private System.Windows.Forms.Label labDestroyPwd;
        private System.Windows.Forms.GroupBox gbTagLockAndUnlock;
        private System.Windows.Forms.Label lblOperationType;
        private System.Windows.Forms.ComboBox cbbLockType;
        private System.Windows.Forms.Label labLockBank;
        private System.Windows.Forms.ComboBox cbbLockBank;
        private System.Windows.Forms.Button btnLockTag;
        private System.Windows.Forms.Label labLockAccessPwd;
        private System.Windows.Forms.TextBox tbLockAccessPwd;
        private System.Windows.Forms.GroupBox gbFastWrite;
        private System.Windows.Forms.Button btnReadFastTag;
        private System.Windows.Forms.CheckBox chkZD;
        private System.Windows.Forms.Label labFWPromo;
        private System.Windows.Forms.Button btnClearFWData;
        private System.Windows.Forms.Button btnFastWrite;
        private System.Windows.Forms.Label labFWData;
        private System.Windows.Forms.TextBox tbFWData;
        private System.Windows.Forms.GroupBox gbRWData;
        private System.Windows.Forms.Button btnInitTag;
        private System.Windows.Forms.Button btn_stoptimer;
        private System.Windows.Forms.Button btn_connRead;
        private System.Windows.Forms.Label labData;
        private System.Windows.Forms.Label labLength;
        private System.Windows.Forms.Label labStartAdd;
        private System.Windows.Forms.Label labOprBank;
        private System.Windows.Forms.Button btnWriteData;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.Button btnReadData;
        private System.Windows.Forms.TextBox tbRWData;
        private System.Windows.Forms.ComboBox cbbLength;
        private System.Windows.Forms.ComboBox cbbStartAdd;
        private System.Windows.Forms.ComboBox cbbRWBank;
        private System.Windows.Forms.GroupBox gbBeepControl;
        private System.Windows.Forms.Button btnReadDataArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSetDataArea;
        private System.Windows.Forms.ComboBox cbbDataArea;
        private System.Windows.Forms.TabPage tpAntennaParams;
        private System.Windows.Forms.GroupBox gbAdjacentDiscriminant;
        private System.Windows.Forms.TabControl tabControlAdjacentDiscriminant;
        private System.Windows.Forms.TabPage tabPageUnify;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPageAlone;
        private System.Windows.Forms.TextBox tbAnt4;
        private System.Windows.Forms.Label lblAnt4;
        private System.Windows.Forms.TextBox tbAnt1;
        private System.Windows.Forms.Label lblAnt3;
        private System.Windows.Forms.TextBox tbAnt2;
        private System.Windows.Forms.Label lblAnt2;
        private System.Windows.Forms.TextBox tbAnt3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAnt1;
        private System.Windows.Forms.Button btnAdjacentDiscriminantRead2;
        private System.Windows.Forms.Button btnAdjacentDiscriminantSet2;
        private System.Windows.Forms.GroupBox grpAntSet;
        private System.Windows.Forms.RadioButton rbChannel32;
        private System.Windows.Forms.RadioButton rbChannel16;
        private System.Windows.Forms.ComboBox cbbGapTime16;
        private System.Windows.Forms.RadioButton rbChannel1;
        private System.Windows.Forms.ComboBox cbbGapTime8;
        private System.Windows.Forms.RadioButton rbChannel8;
        private System.Windows.Forms.Label lblAntennaGapTime;
        private System.Windows.Forms.ComboBox cbbGapTime15;
        private System.Windows.Forms.Label lblAntennaWorkTime;
        private System.Windows.Forms.RadioButton rbChannel2;
        private System.Windows.Forms.ComboBox cbbGapTime7;
        private System.Windows.Forms.ComboBox cbbGapTime14;
        private System.Windows.Forms.Label lblAntennaPower;
        private System.Windows.Forms.RadioButton rbChannel4;
        private System.Windows.Forms.Label lblAntennaId;
        private System.Windows.Forms.ComboBox cbbGapTime6;
        private System.Windows.Forms.ComboBox cbbGapTime13;
        private System.Windows.Forms.ComboBox cbbGapTime5;
        private System.Windows.Forms.ComboBox cbbGapTime12;
        private System.Windows.Forms.ComboBox cbbGapTime4;
        private System.Windows.Forms.ComboBox cbbGapTime11;
        private System.Windows.Forms.ComboBox cbbGapTime3;
        private System.Windows.Forms.ComboBox cbbGapTime10;
        private System.Windows.Forms.ComboBox cbbGapTime2;
        private System.Windows.Forms.ComboBox cbbGapTime9;
        private System.Windows.Forms.ComboBox cbbGapTime1;
        private System.Windows.Forms.ComboBox cbbWorkTime16;
        private System.Windows.Forms.ComboBox cbbWorkTime8;
        private System.Windows.Forms.ComboBox cbbWorkTime15;
        private System.Windows.Forms.ComboBox cbbWorkTime7;
        private System.Windows.Forms.ComboBox cbbWorkTime14;
        private System.Windows.Forms.ComboBox cbbWorkTime6;
        private System.Windows.Forms.ComboBox cbbWorkTime13;
        private System.Windows.Forms.ComboBox cbbWorkTime5;
        private System.Windows.Forms.ComboBox cbbWorkTime12;
        private System.Windows.Forms.ComboBox cbbWorkTime4;
        private System.Windows.Forms.ComboBox cbbWorkTime11;
        private System.Windows.Forms.ComboBox cbbWorkTime3;
        private System.Windows.Forms.ComboBox cbbWorkTime10;
        private System.Windows.Forms.ComboBox cbbWorkTime2;
        private System.Windows.Forms.ComboBox cbbWorkTime9;
        private System.Windows.Forms.ComboBox cbbWorkTime1;
        private System.Windows.Forms.ComboBox cbbPower16;
        private System.Windows.Forms.ComboBox cbbPower8;
        private System.Windows.Forms.ComboBox cbbPower15;
        private System.Windows.Forms.ComboBox cbbPower7;
        private System.Windows.Forms.ComboBox cbbPower14;
        private System.Windows.Forms.ComboBox cbbPower6;
        private System.Windows.Forms.ComboBox cbbPower13;
        private System.Windows.Forms.ComboBox cbbPower5;
        private System.Windows.Forms.ComboBox cbbPower12;
        private System.Windows.Forms.ComboBox cbbPower4;
        private System.Windows.Forms.ComboBox cbbPower11;
        private System.Windows.Forms.ComboBox cbbPower3;
        private System.Windows.Forms.ComboBox cbbPower10;
        private System.Windows.Forms.ComboBox cbbPower2;
        private System.Windows.Forms.ComboBox cbbPower9;
        private System.Windows.Forms.ComboBox cbbPower1;
        private System.Windows.Forms.CheckBox chkAnt16;
        private System.Windows.Forms.CheckBox chkAnt15;
        private System.Windows.Forms.CheckBox chkAnt14;
        private System.Windows.Forms.CheckBox chkAnt13;
        private System.Windows.Forms.CheckBox chkAnt12;
        private System.Windows.Forms.CheckBox chkAnt11;
        private System.Windows.Forms.CheckBox chkAnt10;
        private System.Windows.Forms.CheckBox chkAnt9;
        private System.Windows.Forms.CheckBox chkAnt8;
        private System.Windows.Forms.CheckBox chkAnt7;
        private System.Windows.Forms.CheckBox chkAnt6;
        private System.Windows.Forms.CheckBox chkAnt5;
        private System.Windows.Forms.CheckBox chkAnt4;
        private System.Windows.Forms.CheckBox chkAnt3;
        private System.Windows.Forms.CheckBox chkAnt2;
        private System.Windows.Forms.CheckBox chkAnt1;
        private System.Windows.Forms.Button btnAntSet;
        private System.Windows.Forms.Button btnReadChannelCount;
        private System.Windows.Forms.Button btnAntRead;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.Button btnReadOnce;
        private System.Windows.Forms.Button btnStartReadData;
        private System.Windows.Forms.Button btnStopReadData;
        private System.Windows.Forms.CheckBox cbSaveFile;
        private System.Windows.Forms.Button btnClearListView;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblTagCount;
        private System.Windows.Forms.Label labReadCount;
        private System.Windows.Forms.Label labTagCount;
        private System.Windows.Forms.RadioButton rbDesc;
        private System.Windows.Forms.RadioButton rbAsc;
        private System.Windows.Forms.Label labelVersion;
        private ListViewContrl.DoubleBufferListView listView;
        private System.Windows.Forms.ColumnHeader list_serial_number;
        private System.Windows.Forms.ColumnHeader list_EPC;
        private System.Windows.Forms.ColumnHeader list_count;
        private System.Windows.Forms.ColumnHeader list_antenna_no;
        private System.Windows.Forms.ColumnHeader list_device_no;
        private System.Windows.Forms.ColumnHeader list_Uart_IP;
        private System.Windows.Forms.ColumnHeader list_current_time;
        private System.Windows.Forms.ColumnHeader list_rssi;
        private System.Windows.Forms.ColumnHeader list_alarm_status;
        private System.Windows.Forms.ColumnHeader list_private_data;
        private System.Windows.Forms.ColumnHeader list_temperature;
        private System.Windows.Forms.ColumnHeader list_user_custome_data;
        private System.Windows.Forms.ColumnHeader list_EPC_data;
        private System.Windows.Forms.ColumnHeader list_TID_data;
        private System.Windows.Forms.ColumnHeader list_User_data;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.CheckBox chkMatchParameter;
        private System.Windows.Forms.ComboBox cbbMatchMode;
        private System.Windows.Forms.Label lblMatchMode;
        private System.Windows.Forms.TextBox tbMatchData;
        private System.Windows.Forms.Label lblMatchData;
        private System.Windows.Forms.TextBox txtTotalQty;
        private System.Windows.Forms.Label lblTotalQty;
        private System.Windows.Forms.TextBox txtArmyNo;
        private System.Windows.Forms.Label lblArmyNo;
        private System.Windows.Forms.DateTimePicker dateTimePickerIssueDate;
        private System.Windows.Forms.Label labelIssueDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerChallanDate;
        private System.Windows.Forms.Label labelChallanDate;
        private System.Windows.Forms.ComboBox cmbSelectChalan;
        private System.Windows.Forms.Label lblSelectChalan;
        private System.Windows.Forms.Button btnSubmit;

        public System.EventHandler OtherOpreation_Enter { get; set; }
    }
}

