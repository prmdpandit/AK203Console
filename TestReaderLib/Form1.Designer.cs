﻿namespace RFID_MoudleReader
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ComboBox comboBoxStockIn;
        private System.Windows.Forms.ComboBox comboBoxStockPackaging;
        private System.Windows.Forms.TextBox textBoxEquipmentRegNo;
        private System.Windows.Forms.TextBox textBoxEquipmentRFID;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelStockIn;
        private System.Windows.Forms.Label labelStockPackaging;
        private System.Windows.Forms.Label labelEquipmentRegNo;
        private System.Windows.Forms.Label labelEquipmentRFID;
        private System.Windows.Forms.Label labelDescription;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbx_conn = new System.Windows.Forms.GroupBox();
            this.cbxDeviceAddr = new System.Windows.Forms.ComboBox();
            this.label_DeviceAddr = new System.Windows.Forms.Label();
            this.Reset_FW = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPort = new System.Windows.Forms.ComboBox();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.btnConn = new System.Windows.Forms.Button();
            this.gbx_NewDevAddr = new System.Windows.Forms.GroupBox();
            this.cbxNewDeviceAddr = new System.Windows.Forms.ComboBox();
            this.btn_SetReaderDeviceAddr = new System.Windows.Forms.Button();
            this.btn_GetReaderDeviceAddr = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSetFhss = new System.Windows.Forms.Button();
            this.btnGetFhss = new System.Windows.Forms.Button();
            this.btnSetFreqHopPeriod = new System.Windows.Forms.Button();
            this.btnGetFreqHopPeriod = new System.Windows.Forms.Button();
            this.btnInvtBasic = new System.Windows.Forms.Button();
            this.txtRDMultiNum = new System.Windows.Forms.TextBox();
            this.cbx_MTR_Algorithm = new System.Windows.Forms.ComboBox();
            this.cbx_MTR_Qvalue = new System.Windows.Forms.ComboBox();
            this.btnStopRD = new System.Windows.Forms.Button();
            this.btnInvtMulti = new System.Windows.Forms.Button();
            this.btnSetCW = new System.Windows.Forms.Button();
            this.button_RF_Ant_Get = new System.Windows.Forms.Button();
            this.button_RF_Ant_Set = new System.Windows.Forms.Button();
            this.button_RF_Ant_GetCurrentAntPort = new System.Windows.Forms.Button();
            this.checkBox_RF_Ant_Enable8 = new System.Windows.Forms.CheckBox();
            this.checkBox_RF_Ant_Enable7 = new System.Windows.Forms.CheckBox();
            this.checkBox_RF_Ant_Enable6 = new System.Windows.Forms.CheckBox();
            this.checkBox_RF_Ant_Enable5 = new System.Windows.Forms.CheckBox();
            this.checkBox_RF_Ant_Enable4 = new System.Windows.Forms.CheckBox();
            this.checkBox_RF_Ant_Enable3 = new System.Windows.Forms.CheckBox();
            this.checkBox_RF_Ant_Enable2 = new System.Windows.Forms.CheckBox();
            this.checkBox_RF_Ant_Enable1 = new System.Windows.Forms.CheckBox();
            this.radioButton_AntPort7 = new System.Windows.Forms.RadioButton();
            this.radioButton_AntPort6 = new System.Windows.Forms.RadioButton();
            this.radioButton_AntPort5 = new System.Windows.Forms.RadioButton();
            this.radioButton_AntPort4 = new System.Windows.Forms.RadioButton();
            this.radioButton_AntPort3 = new System.Windows.Forms.RadioButton();
            this.radioButton_AntPort2 = new System.Windows.Forms.RadioButton();
            this.radioButton_AntPort1 = new System.Windows.Forms.RadioButton();
            this.radioButton_AntPort8 = new System.Windows.Forms.RadioButton();
            this.textBox_RF_AntPort_InvCnter8 = new System.Windows.Forms.TextBox();
            this.comboBoxRF_AntPort_Port8 = new System.Windows.Forms.ComboBox();
            this.textBox_RF_AntPort_InvCnter7 = new System.Windows.Forms.TextBox();
            this.comboBoxRF_AntPort_Port7 = new System.Windows.Forms.ComboBox();
            this.textBox_RF_AntPort_InvCnter6 = new System.Windows.Forms.TextBox();
            this.comboBoxRF_AntPort_Port6 = new System.Windows.Forms.ComboBox();
            this.textBox_RF_AntPort_InvCnter5 = new System.Windows.Forms.TextBox();
            this.comboBoxRF_AntPort_Port5 = new System.Windows.Forms.ComboBox();
            this.textBox_RF_AntPort_InvCnter4 = new System.Windows.Forms.TextBox();
            this.comboBoxRF_AntPort_Port4 = new System.Windows.Forms.ComboBox();
            this.textBox_RF_AntPort_InvCnter3 = new System.Windows.Forms.TextBox();
            this.comboBoxRF_AntPort_Port3 = new System.Windows.Forms.ComboBox();
            this.textBox_RF_AntPort_InvCnter2 = new System.Windows.Forms.TextBox();
            this.comboBoxRF_AntPort_Port2 = new System.Windows.Forms.ComboBox();
            this.textBox_RF_AntPort_InvCnter1 = new System.Windows.Forms.TextBox();
            this.comboBoxRF_AntPort_Port1 = new System.Windows.Forms.ComboBox();
            this.comboBox_RF_AntPort_Quantity = new System.Windows.Forms.ComboBox();
            this.checkBox_RF_AntPort_AutoPolling = new System.Windows.Forms.CheckBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.checkBox_InvtMulti_AutoClear = new System.Windows.Forms.CheckBox();
            this.btn_SetNewBaudRate = new System.Windows.Forms.Button();
            this.btn_GetNewBaudRate = new System.Windows.Forms.Button();
            this.button_GPIO_Set = new System.Windows.Forms.Button();
            this.button_GPIO_Get = new System.Windows.Forms.Button();
            this.btnSetIO = new System.Windows.Forms.Button();
            this.btnGetIO = new System.Windows.Forms.Button();
            this.btnGetRegion = new System.Windows.Forms.Button();
            this.btnSetRegion = new System.Windows.Forms.Button();
            this.cbx_SensorTag_SensorTagType = new System.Windows.Forms.ComboBox();
            this.btn_SensorTag_StopRead = new System.Windows.Forms.Button();
            this.btn_SensorTag_GetTmpAuto = new System.Windows.Forms.Button();
            this.cbx_SensorTag_ReadNumber = new System.Windows.Forms.ComboBox();
            this.btn_SensorTag_GetTmpOne = new System.Windows.Forms.Button();
            this.btn_SensorTag_InventoryOne = new System.Windows.Forms.Button();
            this.btn_SelectAllSensorTag = new System.Windows.Forms.Button();
            this.btnInsertRfCh_Get = new System.Windows.Forms.Button();
            this.txtChIndexBegin = new System.Windows.Forms.TextBox();
            this.txtChIndexEnd = new System.Windows.Forms.TextBox();
            this.btnInsertRfCh = new System.Windows.Forms.Button();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btn_clear_rx = new System.Windows.Forms.Button();
            this.btnClearCnt = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.timerAutoSend = new System.Windows.Forms.Timer(this.components);
            this.gbxRxData = new System.Windows.Forms.GroupBox();
            this.cbxRxVisable = new System.Windows.Forms.CheckBox();
            this.cbxAutoClear = new System.Windows.Forms.CheckBox();
            this.gbx_inventory = new System.Windows.Forms.GroupBox();
            this.cbxQBasic = new System.Windows.Forms.ComboBox();
            this.txtSendDelay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbx_MTR = new System.Windows.Forms.GroupBox();
            this.gbx_MTR_LoopNum = new System.Windows.Forms.GroupBox();
            this.lbl_MTR_Read_Number = new System.Windows.Forms.Label();
            this.lbl_MTR_Algorithm = new System.Windows.Forms.Label();
            this.lbl_MTR_Qvalue = new System.Windows.Forms.Label();
            this.dgvEpcBasic = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveAsCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxEpcTableBasic = new System.Windows.Forms.GroupBox();
            this.textBox_EPC_Tag_Total = new System.Windows.Forms.TextBox();
            this.label_EPC_Tag_Total = new System.Windows.Forms.Label();
            this.textBox_EPC_TagCounter = new System.Windows.Forms.TextBox();
            this.label_EPC_TagCounter = new System.Windows.Forms.Label();
            this.btn_clear_epc1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage_TagRead = new System.Windows.Forms.TabPage();
            this.pbx_Inv_Indicator = new System.Windows.Forms.PictureBox();
            this.tabPage_SysSetting = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbxNewBaudRate = new System.Windows.Forms.ComboBox();
            this.BtnTest = new System.Windows.Forms.Button();
            this.gbxStatus = new System.Windows.Forms.GroupBox();
            this.txtFirmwareVersion = new System.Windows.Forms.TextBox();
            this.txtHardwareVersion = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.labelHardwareVersion = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCOMRxCnt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCOMTxCnt = new System.Windows.Forms.TextBox();
            this.tabPageSysSetting = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox_GPIO = new System.Windows.Forms.GroupBox();
            this.groupBox_GPI = new System.Windows.Forms.GroupBox();
            this.checkBox_GPI4 = new System.Windows.Forms.CheckBox();
            this.checkBox_GPI1 = new System.Windows.Forms.CheckBox();
            this.checkBox_GPI3 = new System.Windows.Forms.CheckBox();
            this.checkBox_GPI2 = new System.Windows.Forms.CheckBox();
            this.groupBox_GPO = new System.Windows.Forms.GroupBox();
            this.checkBox_GPO4 = new System.Windows.Forms.CheckBox();
            this.checkBox_GPO3 = new System.Windows.Forms.CheckBox();
            this.checkBox_GPO2 = new System.Windows.Forms.CheckBox();
            this.checkBox_GPO1 = new System.Windows.Forms.CheckBox();
            this.gbxIoControl = new System.Windows.Forms.GroupBox();
            this.cbxIoDircetion = new System.Windows.Forms.ComboBox();
            this.cbxIoLevel = new System.Windows.Forms.ComboBox();
            this.btnSetIoDirection = new System.Windows.Forms.Button();
            this.cbxIO = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSetModuleSleep = new System.Windows.Forms.Button();
            this.bynSaveConfigToNv = new System.Windows.Forms.Button();
            this.cbxSaveNvConfig = new System.Windows.Forms.CheckBox();
            this.cbxMode = new System.Windows.Forms.ComboBox();
            this.btnSetMode = new System.Windows.Forms.Button();
            this.groupBox_RFSetting = new System.Windows.Forms.GroupBox();
            this.gbxRfPower = new System.Windows.Forms.GroupBox();
            this.btnGetPaPower = new System.Windows.Forms.Button();
            this.cbxPaPower = new System.Windows.Forms.ComboBox();
            this.btnSetPaPower = new System.Windows.Forms.Button();
            this.gbx_setfreq = new System.Windows.Forms.GroupBox();
            this.gbx_InsertRFCH = new System.Windows.Forms.GroupBox();
            this.btnInsertRfCh_Help = new System.Windows.Forms.Button();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.cbxFhssHopPeriod = new System.Windows.Forms.ComboBox();
            this.cbxFHSS = new System.Windows.Forms.ComboBox();
            this.btnGetChannel = new System.Windows.Forms.Button();
            this.cbxChannel = new System.Windows.Forms.ComboBox();
            this.cbxRegion = new System.Windows.Forms.ComboBox();
            this.btnSetFreq = new System.Windows.Forms.Button();
            this.groupBox_RF_Ant = new System.Windows.Forms.GroupBox();
            this.label_AntPort_Quantity = new System.Windows.Forms.Label();
            this.groupBox_RF_Ant_Port = new System.Windows.Forms.GroupBox();
            this.groupBox_RF_Ant_Enable = new System.Windows.Forms.GroupBox();
            this.groupBox_RF_Ant_SwitchAnt = new System.Windows.Forms.GroupBox();
            this.label_RF_AntPort_InvCnter = new System.Windows.Forms.Label();
            this.label_RF_AntPort_Power = new System.Windows.Forms.Label();
            this.tabPageAccessTag = new System.Windows.Forms.TabPage();
            this.label_Acess1 = new System.Windows.Forms.Label();
            this.gbxStatus2 = new System.Windows.Forms.GroupBox();
            this.rtbxStatus = new System.Windows.Forms.RichTextBox();
            this.txtOperateEpc = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.inv_mode = new System.Windows.Forms.CheckBox();
            this.gbxKill = new System.Windows.Forms.GroupBox();
            this.labelKillRFU = new System.Windows.Forms.Label();
            this.textBoxKillRFU = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.textBoxKillPwd = new System.Windows.Forms.TextBox();
            this.buttonKill = new System.Windows.Forms.Button();
            this.gBxLock = new System.Windows.Forms.GroupBox();
            this.cbxLockUserAction = new System.Windows.Forms.ComboBox();
            this.cbxLockTIDAction = new System.Windows.Forms.ComboBox();
            this.cbxLockEPCAction = new System.Windows.Forms.ComboBox();
            this.cbxLockAccessAction = new System.Windows.Forms.ComboBox();
            this.cbxLockKillAction = new System.Windows.Forms.ComboBox();
            this.checkBoxUser = new System.Windows.Forms.CheckBox();
            this.checkBoxTID = new System.Windows.Forms.CheckBox();
            this.checkBoxEPC = new System.Windows.Forms.CheckBox();
            this.checkBoxAccessPwd = new System.Windows.Forms.CheckBox();
            this.checkBoxKillPwd = new System.Windows.Forms.CheckBox();
            this.buttonLock = new System.Windows.Forms.Button();
            this.label42 = new System.Windows.Forms.Label();
            this.textBoxLockAccessPwd = new System.Windows.Forms.TextBox();
            this.gbxSelect = new System.Windows.Forms.GroupBox();
            this.label_Access3 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txtGetSelLength = new System.Windows.Forms.TextBox();
            this.txtGetSelMask = new System.Windows.Forms.TextBox();
            this.btnGetSelect = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.txtSelMask = new System.Windows.Forms.TextBox();
            this.ckxTruncated = new System.Windows.Forms.CheckBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txtSelLength = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtSelPrt0 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtSelPrt2 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtSelPrt1 = new System.Windows.Forms.TextBox();
            this.txtSelPrt3 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.cbxSelMemBank = new System.Windows.Forms.ComboBox();
            this.cbxAction = new System.Windows.Forms.ComboBox();
            this.cbxSelTarget = new System.Windows.Forms.ComboBox();
            this.btnSetSelect = new System.Windows.Forms.Button();
            this.gbx_comcnt_adv = new System.Windows.Forms.GroupBox();
            this.btnClearCntAdv = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCOMRxCnt_adv = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCOMTxCnt_adv = new System.Windows.Forms.TextBox();
            this.gbxAccess = new System.Windows.Forms.GroupBox();
            this.label_Access4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWordCnt0 = new System.Windows.Forms.TextBox();
            this.txtWordPtr0 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtRwAccPassWord = new System.Windows.Forms.TextBox();
            this.txtInvtRWData = new System.Windows.Forms.TextBox();
            this.btnInvtWrtie = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cbxMemBank = new System.Windows.Forms.ComboBox();
            this.txtWordCnt1 = new System.Windows.Forms.TextBox();
            this.txtWordPtr1 = new System.Windows.Forms.TextBox();
            this.btn_invtread = new System.Windows.Forms.Button();
            this.btnInvtAdv = new System.Windows.Forms.Button();
            this.gbxEpcTableAdv = new System.Windows.Forms.GroupBox();
            this.label_Access2 = new System.Windows.Forms.Label();
            this.btn_clear_epc2 = new System.Windows.Forms.Button();
            this.dgv_epc2 = new System.Windows.Forms.DataGridView();
            this.gbxSetQuery = new System.Windows.Forms.GroupBox();
            this.cbxM = new System.Windows.Forms.ComboBox();
            this.cbxQAdv = new System.Windows.Forms.ComboBox();
            this.btnGetQuery = new System.Windows.Forms.Button();
            this.btnSetQuery = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxTarget = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxSession = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxSel = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxTRext = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxDR = new System.Windows.Forms.ComboBox();
            this.tabPageSensorTag = new System.Windows.Forms.TabPage();
            this.label40 = new System.Windows.Forms.Label();
            this.btn_SensorTag_Test = new System.Windows.Forms.Button();
            this.btn_Zed_Clear = new System.Windows.Forms.Button();
            this.zg1 = new ZedGraph.ZedGraphControl();
            this.gbx_SensorTag_ReadTmp = new System.Windows.Forms.GroupBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.txt_SensorTag_AccPassWord = new System.Windows.Forms.TextBox();
            this.gbxSensorTag = new System.Windows.Forms.GroupBox();
            this.label50 = new System.Windows.Forms.Label();
            this.btn_Clear_SensorTag = new System.Windows.Forms.Button();
            this.dgv_SensorTag = new System.Windows.Forms.DataGridView();
            this.tabPageTMS = new System.Windows.Forms.TabPage();
            this.btnScanRssi = new System.Windows.Forms.Button();
            this.btnScanJammer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxCoupling = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.tbxAntennaGain = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxSignalThreshold = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnSetModemPara = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxMixerGain = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxIFAmpGain = new System.Windows.Forms.ComboBox();
            this.btnGetModemPara = new System.Windows.Forms.Button();
            this.tabPageImpinjTag = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tbxNxpCmdAccessPwd = new System.Windows.Forms.TextBox();
            this.cbxReadProtectReset = new System.Windows.Forms.CheckBox();
            this.btnChangeConfig = new System.Windows.Forms.Button();
            this.btnReadProtect = new System.Windows.Forms.Button();
            this.btnChangeEas = new System.Windows.Forms.Button();
            this.label48 = new System.Windows.Forms.Label();
            this.cbxSetEas = new System.Windows.Forms.CheckBox();
            this.txtConfigData = new System.Windows.Forms.TextBox();
            this.btnEasAlarm = new System.Windows.Forms.Button();
            this.groupBoxMonzaCmds = new System.Windows.Forms.GroupBox();
            this.label36 = new System.Windows.Forms.Label();
            this.btnMonzaQTWrite = new System.Windows.Forms.Button();
            this.tbxMonzaQTAccessPwd = new System.Windows.Forms.TextBox();
            this.btnMonzaQTRead = new System.Windows.Forms.Button();
            this.cbxMonzaQT_MEM = new System.Windows.Forms.CheckBox();
            this.cbxMonzaQT_SR = new System.Windows.Forms.CheckBox();
            this.gbxRdIntrgtMem = new System.Windows.Forms.GroupBox();
            this.timerCheckReader = new System.Windows.Forms.Timer(this.components);
            this.tmrCheckEpc = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStripInfor = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.label_dllversion = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnAddBox = new System.Windows.Forms.Button();
            this.comboBoxStockIn = new System.Windows.Forms.ComboBox();
            this.comboBoxStockPackaging = new System.Windows.Forms.ComboBox();
            this.textBoxEquipmentRegNo = new System.Windows.Forms.TextBox();
            this.textBoxEquipmentRFID = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.dataGridViewStockInItems = new System.Windows.Forms.DataGridView();
            this.Equipment_Reg_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipment_Rfid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelStockIn = new System.Windows.Forms.Label();
            this.labelStockPackaging = new System.Windows.Forms.Label();
            this.labelEquipmentRegNo = new System.Windows.Forms.Label();
            this.labelEquipmentRFID = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.gbx_conn.SuspendLayout();
            this.gbx_NewDevAddr.SuspendLayout();
            this.gbxRxData.SuspendLayout();
            this.gbx_inventory.SuspendLayout();
            this.gbx_MTR.SuspendLayout();
            this.gbx_MTR_LoopNum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEpcBasic)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gbxEpcTableBasic.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage_TagRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Inv_Indicator)).BeginInit();
            this.tabPage_SysSetting.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.gbxStatus.SuspendLayout();
            this.tabPageSysSetting.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox_GPIO.SuspendLayout();
            this.groupBox_GPI.SuspendLayout();
            this.groupBox_GPO.SuspendLayout();
            this.gbxIoControl.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox_RFSetting.SuspendLayout();
            this.gbxRfPower.SuspendLayout();
            this.gbx_setfreq.SuspendLayout();
            this.gbx_InsertRFCH.SuspendLayout();
            this.groupBox_RF_Ant.SuspendLayout();
            this.groupBox_RF_Ant_Port.SuspendLayout();
            this.groupBox_RF_Ant_Enable.SuspendLayout();
            this.groupBox_RF_Ant_SwitchAnt.SuspendLayout();
            this.tabPageAccessTag.SuspendLayout();
            this.gbxStatus2.SuspendLayout();
            this.gbxKill.SuspendLayout();
            this.gBxLock.SuspendLayout();
            this.gbxSelect.SuspendLayout();
            this.gbx_comcnt_adv.SuspendLayout();
            this.gbxAccess.SuspendLayout();
            this.gbxEpcTableAdv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_epc2)).BeginInit();
            this.gbxSetQuery.SuspendLayout();
            this.tabPageSensorTag.SuspendLayout();
            this.gbx_SensorTag_ReadTmp.SuspendLayout();
            this.gbxSensorTag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SensorTag)).BeginInit();
            this.tabPageTMS.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageImpinjTag.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBoxMonzaCmds.SuspendLayout();
            this.statusStripInfor.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockInItems)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_conn
            // 
            this.gbx_conn.Controls.Add(this.cbxDeviceAddr);
            this.gbx_conn.Controls.Add(this.label_DeviceAddr);
            this.gbx_conn.Controls.Add(this.Reset_FW);
            this.gbx_conn.Controls.Add(this.label2);
            this.gbx_conn.Controls.Add(this.label1);
            this.gbx_conn.Controls.Add(this.cbxPort);
            this.gbx_conn.Controls.Add(this.cbxBaudRate);
            this.gbx_conn.Controls.Add(this.btnConn);
            this.gbx_conn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_conn.Location = new System.Drawing.Point(755, 6);
            this.gbx_conn.Name = "gbx_conn";
            this.gbx_conn.Size = new System.Drawing.Size(305, 120);
            this.gbx_conn.TabIndex = 0;
            this.gbx_conn.TabStop = false;
            this.gbx_conn.Text = "SerialPort Connection";
            // 
            // cbxDeviceAddr
            // 
            this.cbxDeviceAddr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDeviceAddr.FormattingEnabled = true;
            this.cbxDeviceAddr.Location = new System.Drawing.Point(205, 85);
            this.cbxDeviceAddr.Name = "cbxDeviceAddr";
            this.cbxDeviceAddr.Size = new System.Drawing.Size(89, 23);
            this.cbxDeviceAddr.TabIndex = 23;
            this.cbxDeviceAddr.SelectedIndexChanged += new System.EventHandler(this.cbxDeviceAddr_SelectedIndexChanged);
            // 
            // label_DeviceAddr
            // 
            this.label_DeviceAddr.AutoSize = true;
            this.label_DeviceAddr.Location = new System.Drawing.Point(134, 89);
            this.label_DeviceAddr.Name = "label_DeviceAddr";
            this.label_DeviceAddr.Size = new System.Drawing.Size(75, 15);
            this.label_DeviceAddr.TabIndex = 24;
            this.label_DeviceAddr.Text = "Device Addr";
            // 
            // Reset_FW
            // 
            this.Reset_FW.BackColor = System.Drawing.SystemColors.Control;
            this.Reset_FW.Location = new System.Drawing.Point(8, 79);
            this.Reset_FW.Name = "Reset_FW";
            this.Reset_FW.Size = new System.Drawing.Size(122, 26);
            this.Reset_FW.TabIndex = 22;
            this.Reset_FW.Text = "Reset_FW";
            this.toolTip1.SetToolTip(this.Reset_FW, "Reset the Reader(USB should be replug after reset.)");
            this.Reset_FW.UseVisualStyleBackColor = true;
            this.Reset_FW.Click += new System.EventHandler(this.Reset_FW_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port No.";
            // 
            // cbxPort
            // 
            this.cbxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPort.FormattingEnabled = true;
            this.cbxPort.Location = new System.Drawing.Point(205, 17);
            this.cbxPort.Name = "cbxPort";
            this.cbxPort.Size = new System.Drawing.Size(89, 23);
            this.cbxPort.TabIndex = 2;
            this.cbxPort.DropDown += new System.EventHandler(this.cbxPort_DropDown);
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.cbxBaudRate.Location = new System.Drawing.Point(205, 50);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(89, 23);
            this.cbxBaudRate.TabIndex = 1;
            // 
            // btnConn
            // 
            this.btnConn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnConn.Enabled = false;
            this.btnConn.Location = new System.Drawing.Point(8, 22);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(122, 51);
            this.btnConn.TabIndex = 0;
            this.btnConn.Tag = "0";
            this.btnConn.Text = "Connect";
            this.toolTip1.SetToolTip(this.btnConn, "Connect or Close the reader by serial port or USB serial port.");
            this.btnConn.UseVisualStyleBackColor = false;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // gbx_NewDevAddr
            // 
            this.gbx_NewDevAddr.Controls.Add(this.cbxNewDeviceAddr);
            this.gbx_NewDevAddr.Controls.Add(this.btn_SetReaderDeviceAddr);
            this.gbx_NewDevAddr.Controls.Add(this.btn_GetReaderDeviceAddr);
            this.gbx_NewDevAddr.Location = new System.Drawing.Point(6, 6);
            this.gbx_NewDevAddr.Name = "gbx_NewDevAddr";
            this.gbx_NewDevAddr.Size = new System.Drawing.Size(284, 58);
            this.gbx_NewDevAddr.TabIndex = 27;
            this.gbx_NewDevAddr.TabStop = false;
            this.gbx_NewDevAddr.Text = "New Device Address";
            // 
            // cbxNewDeviceAddr
            // 
            this.cbxNewDeviceAddr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNewDeviceAddr.FormattingEnabled = true;
            this.cbxNewDeviceAddr.Location = new System.Drawing.Point(95, 23);
            this.cbxNewDeviceAddr.Name = "cbxNewDeviceAddr";
            this.cbxNewDeviceAddr.Size = new System.Drawing.Size(94, 23);
            this.cbxNewDeviceAddr.TabIndex = 26;
            // 
            // btn_SetReaderDeviceAddr
            // 
            this.btn_SetReaderDeviceAddr.Location = new System.Drawing.Point(207, 20);
            this.btn_SetReaderDeviceAddr.Name = "btn_SetReaderDeviceAddr";
            this.btn_SetReaderDeviceAddr.Size = new System.Drawing.Size(71, 26);
            this.btn_SetReaderDeviceAddr.TabIndex = 25;
            this.btn_SetReaderDeviceAddr.Text = "Set";
            this.toolTip1.SetToolTip(this.btn_SetReaderDeviceAddr, "Set the Reader\'s Device Addresss.");
            this.btn_SetReaderDeviceAddr.UseVisualStyleBackColor = true;
            this.btn_SetReaderDeviceAddr.Click += new System.EventHandler(this.btn_SetReaderDeviceAddr_Click);
            // 
            // btn_GetReaderDeviceAddr
            // 
            this.btn_GetReaderDeviceAddr.Location = new System.Drawing.Point(6, 20);
            this.btn_GetReaderDeviceAddr.Name = "btn_GetReaderDeviceAddr";
            this.btn_GetReaderDeviceAddr.Size = new System.Drawing.Size(71, 26);
            this.btn_GetReaderDeviceAddr.TabIndex = 26;
            this.btn_GetReaderDeviceAddr.Text = "Get";
            this.toolTip1.SetToolTip(this.btn_GetReaderDeviceAddr, "Get the Reader\'s Device Addresss.");
            this.btn_GetReaderDeviceAddr.UseVisualStyleBackColor = true;
            this.btn_GetReaderDeviceAddr.Click += new System.EventHandler(this.btn_GetReaderDeviceAddr_Click);
            // 
            // btnSetFhss
            // 
            this.btnSetFhss.Location = new System.Drawing.Point(6, 202);
            this.btnSetFhss.Name = "btnSetFhss";
            this.btnSetFhss.Size = new System.Drawing.Size(87, 29);
            this.btnSetFhss.TabIndex = 5;
            this.btnSetFhss.Text = "Set FHSS";
            this.toolTip1.SetToolTip(this.btnSetFhss, "Set Frequency Hopping (FHSS: Frequency-Hopping Spread Spectrum)");
            this.btnSetFhss.UseVisualStyleBackColor = true;
            this.btnSetFhss.Click += new System.EventHandler(this.btnSetFhss_Click);
            // 
            // btnGetFhss
            // 
            this.btnGetFhss.Location = new System.Drawing.Point(103, 202);
            this.btnGetFhss.Name = "btnGetFhss";
            this.btnGetFhss.Size = new System.Drawing.Size(87, 29);
            this.btnGetFhss.TabIndex = 17;
            this.btnGetFhss.Text = "Get FHSS";
            this.toolTip1.SetToolTip(this.btnGetFhss, "Get the status of Frequency Hopping");
            this.btnGetFhss.UseVisualStyleBackColor = true;
            this.btnGetFhss.Click += new System.EventHandler(this.btnGetFhss_Click);
            // 
            // btnSetFreqHopPeriod
            // 
            this.btnSetFreqHopPeriod.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetFreqHopPeriod.Location = new System.Drawing.Point(6, 242);
            this.btnSetFreqHopPeriod.Name = "btnSetFreqHopPeriod";
            this.btnSetFreqHopPeriod.Size = new System.Drawing.Size(87, 29);
            this.btnSetFreqHopPeriod.TabIndex = 21;
            this.btnSetFreqHopPeriod.Text = "Set Period";
            this.toolTip1.SetToolTip(this.btnSetFreqHopPeriod, "Set the Period of FHSS (R2000 inside only)");
            this.btnSetFreqHopPeriod.UseVisualStyleBackColor = true;
            this.btnSetFreqHopPeriod.Click += new System.EventHandler(this.btnSetFreqHopPeriod_Click);
            // 
            // btnGetFreqHopPeriod
            // 
            this.btnGetFreqHopPeriod.Location = new System.Drawing.Point(103, 242);
            this.btnGetFreqHopPeriod.Name = "btnGetFreqHopPeriod";
            this.btnGetFreqHopPeriod.Size = new System.Drawing.Size(87, 29);
            this.btnGetFreqHopPeriod.TabIndex = 22;
            this.btnGetFreqHopPeriod.Text = "Get Period";
            this.toolTip1.SetToolTip(this.btnGetFreqHopPeriod, "Get the Period of FHSS (R2000 inside only)");
            this.btnGetFreqHopPeriod.UseVisualStyleBackColor = true;
            this.btnGetFreqHopPeriod.Click += new System.EventHandler(this.btnGetFreqHopPeriod_Click);
            // 
            // btnInvtBasic
            // 
            this.btnInvtBasic.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvtBasic.Location = new System.Drawing.Point(13, 19);
            this.btnInvtBasic.Name = "btnInvtBasic";
            this.btnInvtBasic.Size = new System.Drawing.Size(147, 29);
            this.btnInvtBasic.TabIndex = 0;
            this.btnInvtBasic.Text = "Read Single";
            this.toolTip1.SetToolTip(this.btnInvtBasic, "Read the tags only once.");
            this.btnInvtBasic.UseVisualStyleBackColor = true;
            this.btnInvtBasic.Click += new System.EventHandler(this.btn_invt_Click);
            // 
            // txtRDMultiNum
            // 
            this.txtRDMultiNum.Location = new System.Drawing.Point(50, 20);
            this.txtRDMultiNum.Name = "txtRDMultiNum";
            this.txtRDMultiNum.Size = new System.Drawing.Size(91, 21);
            this.txtRDMultiNum.TabIndex = 12;
            this.txtRDMultiNum.Text = "188";
            this.txtRDMultiNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtRDMultiNum, "Auto stop inventory when Loop Number of Inventory Tag is ending.");
            // 
            // cbx_MTR_Algorithm
            // 
            this.cbx_MTR_Algorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_MTR_Algorithm.FormattingEnabled = true;
            this.cbx_MTR_Algorithm.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cbx_MTR_Algorithm.Location = new System.Drawing.Point(75, 52);
            this.cbx_MTR_Algorithm.Name = "cbx_MTR_Algorithm";
            this.cbx_MTR_Algorithm.Size = new System.Drawing.Size(42, 23);
            this.cbx_MTR_Algorithm.TabIndex = 18;
            this.toolTip1.SetToolTip(this.cbx_MTR_Algorithm, "Algorithm of Inventory Tag according to the application");
            // 
            // cbx_MTR_Qvalue
            // 
            this.cbx_MTR_Qvalue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_MTR_Qvalue.FormattingEnabled = true;
            this.cbx_MTR_Qvalue.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbx_MTR_Qvalue.Location = new System.Drawing.Point(75, 23);
            this.cbx_MTR_Qvalue.Name = "cbx_MTR_Qvalue";
            this.cbx_MTR_Qvalue.Size = new System.Drawing.Size(42, 23);
            this.cbx_MTR_Qvalue.TabIndex = 15;
            this.toolTip1.SetToolTip(this.cbx_MTR_Qvalue, "Q Value for Inventory Tag operaiton. (2**Q)");
            // 
            // btnStopRD
            // 
            this.btnStopRD.Location = new System.Drawing.Point(168, 109);
            this.btnStopRD.Name = "btnStopRD";
            this.btnStopRD.Size = new System.Drawing.Size(115, 45);
            this.btnStopRD.TabIndex = 13;
            this.btnStopRD.Text = "Stop Read";
            this.toolTip1.SetToolTip(this.btnStopRD, "Stop Multi-Tag Read operation.");
            this.btnStopRD.UseVisualStyleBackColor = true;
            this.btnStopRD.Click += new System.EventHandler(this.btn_stop_rd_Click);
            // 
            // btnInvtMulti
            // 
            this.btnInvtMulti.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvtMulti.Location = new System.Drawing.Point(13, 109);
            this.btnInvtMulti.Name = "btnInvtMulti";
            this.btnInvtMulti.Size = new System.Drawing.Size(149, 45);
            this.btnInvtMulti.TabIndex = 11;
            this.btnInvtMulti.Text = "Read Multi-Tag";
            this.toolTip1.SetToolTip(this.btnInvtMulti, "Start Multi-Tag Read operation.");
            this.btnInvtMulti.UseVisualStyleBackColor = true;
            this.btnInvtMulti.Click += new System.EventHandler(this.btn_invt_multi_Click);
            // 
            // btnSetCW
            // 
            this.btnSetCW.Location = new System.Drawing.Point(9, 62);
            this.btnSetCW.Name = "btnSetCW";
            this.btnSetCW.Size = new System.Drawing.Size(99, 29);
            this.btnSetCW.TabIndex = 4;
            this.btnSetCW.Text = "CW ON";
            this.toolTip1.SetToolTip(this.btnSetCW, "Continuous RF Wave On or Off (for test only after Set FHSS Off)");
            this.btnSetCW.UseVisualStyleBackColor = true;
            this.btnSetCW.Click += new System.EventHandler(this.btnSetCW_Click);
            // 
            // button_RF_Ant_Get
            // 
            this.button_RF_Ant_Get.Location = new System.Drawing.Point(57, 356);
            this.button_RF_Ant_Get.Name = "button_RF_Ant_Get";
            this.button_RF_Ant_Get.Size = new System.Drawing.Size(97, 40);
            this.button_RF_Ant_Get.TabIndex = 28;
            this.button_RF_Ant_Get.Text = "Get";
            this.toolTip1.SetToolTip(this.button_RF_Ant_Get, "Get the antenna setting.");
            this.button_RF_Ant_Get.UseVisualStyleBackColor = true;
            this.button_RF_Ant_Get.Click += new System.EventHandler(this.button_RF_Ant_Get_Click);
            // 
            // button_RF_Ant_Set
            // 
            this.button_RF_Ant_Set.Location = new System.Drawing.Point(248, 356);
            this.button_RF_Ant_Set.Name = "button_RF_Ant_Set";
            this.button_RF_Ant_Set.Size = new System.Drawing.Size(97, 40);
            this.button_RF_Ant_Set.TabIndex = 27;
            this.button_RF_Ant_Set.Text = "Set";
            this.toolTip1.SetToolTip(this.button_RF_Ant_Set, "Set the antenna setting.");
            this.button_RF_Ant_Set.UseVisualStyleBackColor = true;
            this.button_RF_Ant_Set.Click += new System.EventHandler(this.button_RF_Ant_Set_Click);
            // 
            // button_RF_Ant_GetCurrentAntPort
            // 
            this.button_RF_Ant_GetCurrentAntPort.Location = new System.Drawing.Point(94, 265);
            this.button_RF_Ant_GetCurrentAntPort.Name = "button_RF_Ant_GetCurrentAntPort";
            this.button_RF_Ant_GetCurrentAntPort.Size = new System.Drawing.Size(82, 29);
            this.button_RF_Ant_GetCurrentAntPort.TabIndex = 28;
            this.button_RF_Ant_GetCurrentAntPort.Text = "Get AntPort";
            this.toolTip1.SetToolTip(this.button_RF_Ant_GetCurrentAntPort, "Check current work antenna port of current reader.");
            this.button_RF_Ant_GetCurrentAntPort.UseVisualStyleBackColor = true;
            this.button_RF_Ant_GetCurrentAntPort.Click += new System.EventHandler(this.button_RF_Ant_GetCurrentAntPort_Click);
            // 
            // checkBox_RF_Ant_Enable8
            // 
            this.checkBox_RF_Ant_Enable8.AutoSize = true;
            this.checkBox_RF_Ant_Enable8.Enabled = false;
            this.checkBox_RF_Ant_Enable8.Location = new System.Drawing.Point(19, 209);
            this.checkBox_RF_Ant_Enable8.Name = "checkBox_RF_Ant_Enable8";
            this.checkBox_RF_Ant_Enable8.Size = new System.Drawing.Size(52, 19);
            this.checkBox_RF_Ant_Enable8.TabIndex = 34;
            this.checkBox_RF_Ant_Enable8.Text = "Ant8";
            this.toolTip1.SetToolTip(this.checkBox_RF_Ant_Enable8, "Enable the antenna port if this antenna is connected by an valid antenna. Otherwi" +
        "se disable it.");
            this.checkBox_RF_Ant_Enable8.UseVisualStyleBackColor = true;
            // 
            // checkBox_RF_Ant_Enable7
            // 
            this.checkBox_RF_Ant_Enable7.AutoSize = true;
            this.checkBox_RF_Ant_Enable7.Enabled = false;
            this.checkBox_RF_Ant_Enable7.Location = new System.Drawing.Point(19, 184);
            this.checkBox_RF_Ant_Enable7.Name = "checkBox_RF_Ant_Enable7";
            this.checkBox_RF_Ant_Enable7.Size = new System.Drawing.Size(52, 19);
            this.checkBox_RF_Ant_Enable7.TabIndex = 33;
            this.checkBox_RF_Ant_Enable7.Text = "Ant7";
            this.toolTip1.SetToolTip(this.checkBox_RF_Ant_Enable7, "Enable the antenna port if this antenna is connected by an valid antenna. Otherwi" +
        "se disable it.");
            this.checkBox_RF_Ant_Enable7.UseVisualStyleBackColor = true;
            // 
            // checkBox_RF_Ant_Enable6
            // 
            this.checkBox_RF_Ant_Enable6.AutoSize = true;
            this.checkBox_RF_Ant_Enable6.Enabled = false;
            this.checkBox_RF_Ant_Enable6.Location = new System.Drawing.Point(19, 157);
            this.checkBox_RF_Ant_Enable6.Name = "checkBox_RF_Ant_Enable6";
            this.checkBox_RF_Ant_Enable6.Size = new System.Drawing.Size(52, 19);
            this.checkBox_RF_Ant_Enable6.TabIndex = 32;
            this.checkBox_RF_Ant_Enable6.Text = "Ant6";
            this.toolTip1.SetToolTip(this.checkBox_RF_Ant_Enable6, "Enable the antenna port if this antenna is connected by an valid antenna. Otherwi" +
        "se disable it.");
            this.checkBox_RF_Ant_Enable6.UseVisualStyleBackColor = true;
            // 
            // checkBox_RF_Ant_Enable5
            // 
            this.checkBox_RF_Ant_Enable5.AutoSize = true;
            this.checkBox_RF_Ant_Enable5.Enabled = false;
            this.checkBox_RF_Ant_Enable5.Location = new System.Drawing.Point(19, 130);
            this.checkBox_RF_Ant_Enable5.Name = "checkBox_RF_Ant_Enable5";
            this.checkBox_RF_Ant_Enable5.Size = new System.Drawing.Size(52, 19);
            this.checkBox_RF_Ant_Enable5.TabIndex = 31;
            this.checkBox_RF_Ant_Enable5.Text = "Ant5";
            this.toolTip1.SetToolTip(this.checkBox_RF_Ant_Enable5, "Enable the antenna port if this antenna is connected by an valid antenna. Otherwi" +
        "se disable it.");
            this.checkBox_RF_Ant_Enable5.UseVisualStyleBackColor = true;
            // 
            // checkBox_RF_Ant_Enable4
            // 
            this.checkBox_RF_Ant_Enable4.AutoSize = true;
            this.checkBox_RF_Ant_Enable4.Enabled = false;
            this.checkBox_RF_Ant_Enable4.Location = new System.Drawing.Point(19, 103);
            this.checkBox_RF_Ant_Enable4.Name = "checkBox_RF_Ant_Enable4";
            this.checkBox_RF_Ant_Enable4.Size = new System.Drawing.Size(52, 19);
            this.checkBox_RF_Ant_Enable4.TabIndex = 30;
            this.checkBox_RF_Ant_Enable4.Text = "Ant4";
            this.toolTip1.SetToolTip(this.checkBox_RF_Ant_Enable4, "Enable the antenna port if this antenna is connected by an valid antenna. Otherwi" +
        "se disable it.");
            this.checkBox_RF_Ant_Enable4.UseVisualStyleBackColor = true;
            // 
            // checkBox_RF_Ant_Enable3
            // 
            this.checkBox_RF_Ant_Enable3.AutoSize = true;
            this.checkBox_RF_Ant_Enable3.Enabled = false;
            this.checkBox_RF_Ant_Enable3.Location = new System.Drawing.Point(19, 76);
            this.checkBox_RF_Ant_Enable3.Name = "checkBox_RF_Ant_Enable3";
            this.checkBox_RF_Ant_Enable3.Size = new System.Drawing.Size(52, 19);
            this.checkBox_RF_Ant_Enable3.TabIndex = 29;
            this.checkBox_RF_Ant_Enable3.Text = "Ant3";
            this.toolTip1.SetToolTip(this.checkBox_RF_Ant_Enable3, "Enable the antenna port if this antenna is connected by an valid antenna. Otherwi" +
        "se disable it.");
            this.checkBox_RF_Ant_Enable3.UseVisualStyleBackColor = true;
            // 
            // checkBox_RF_Ant_Enable2
            // 
            this.checkBox_RF_Ant_Enable2.AutoSize = true;
            this.checkBox_RF_Ant_Enable2.Enabled = false;
            this.checkBox_RF_Ant_Enable2.Location = new System.Drawing.Point(19, 49);
            this.checkBox_RF_Ant_Enable2.Name = "checkBox_RF_Ant_Enable2";
            this.checkBox_RF_Ant_Enable2.Size = new System.Drawing.Size(52, 19);
            this.checkBox_RF_Ant_Enable2.TabIndex = 28;
            this.checkBox_RF_Ant_Enable2.Text = "Ant2";
            this.toolTip1.SetToolTip(this.checkBox_RF_Ant_Enable2, "Enable the antenna port if this antenna is connected by an valid antenna. Otherwi" +
        "se disable it.");
            this.checkBox_RF_Ant_Enable2.UseVisualStyleBackColor = true;
            // 
            // checkBox_RF_Ant_Enable1
            // 
            this.checkBox_RF_Ant_Enable1.AutoSize = true;
            this.checkBox_RF_Ant_Enable1.Location = new System.Drawing.Point(19, 22);
            this.checkBox_RF_Ant_Enable1.Name = "checkBox_RF_Ant_Enable1";
            this.checkBox_RF_Ant_Enable1.Size = new System.Drawing.Size(52, 19);
            this.checkBox_RF_Ant_Enable1.TabIndex = 27;
            this.checkBox_RF_Ant_Enable1.Text = "Ant1";
            this.toolTip1.SetToolTip(this.checkBox_RF_Ant_Enable1, "Enable the antenna port if this antenna is connected by an valid antenna. Otherwi" +
        "se disable it.");
            this.checkBox_RF_Ant_Enable1.UseVisualStyleBackColor = true;
            // 
            // radioButton_AntPort7
            // 
            this.radioButton_AntPort7.AutoSize = true;
            this.radioButton_AntPort7.Enabled = false;
            this.radioButton_AntPort7.Location = new System.Drawing.Point(18, 184);
            this.radioButton_AntPort7.Name = "radioButton_AntPort7";
            this.radioButton_AntPort7.Size = new System.Drawing.Size(51, 19);
            this.radioButton_AntPort7.TabIndex = 6;
            this.radioButton_AntPort7.TabStop = true;
            this.radioButton_AntPort7.Text = "Ant7";
            this.toolTip1.SetToolTip(this.radioButton_AntPort7, "Switch the current work antenna to this Antenna port. (API encode: 06)");
            this.radioButton_AntPort7.UseVisualStyleBackColor = true;
            this.radioButton_AntPort7.Click += new System.EventHandler(this.radioButton_AntPort7_Click);
            // 
            // radioButton_AntPort6
            // 
            this.radioButton_AntPort6.AutoSize = true;
            this.radioButton_AntPort6.Enabled = false;
            this.radioButton_AntPort6.Location = new System.Drawing.Point(18, 157);
            this.radioButton_AntPort6.Name = "radioButton_AntPort6";
            this.radioButton_AntPort6.Size = new System.Drawing.Size(51, 19);
            this.radioButton_AntPort6.TabIndex = 5;
            this.radioButton_AntPort6.TabStop = true;
            this.radioButton_AntPort6.Text = "Ant6";
            this.toolTip1.SetToolTip(this.radioButton_AntPort6, "Switch the current work antenna to this Antenna port. (API encode: 05)");
            this.radioButton_AntPort6.UseVisualStyleBackColor = true;
            this.radioButton_AntPort6.Click += new System.EventHandler(this.radioButton_AntPort6_Click);
            // 
            // radioButton_AntPort5
            // 
            this.radioButton_AntPort5.AutoSize = true;
            this.radioButton_AntPort5.Enabled = false;
            this.radioButton_AntPort5.Location = new System.Drawing.Point(18, 130);
            this.radioButton_AntPort5.Name = "radioButton_AntPort5";
            this.radioButton_AntPort5.Size = new System.Drawing.Size(51, 19);
            this.radioButton_AntPort5.TabIndex = 4;
            this.radioButton_AntPort5.TabStop = true;
            this.radioButton_AntPort5.Text = "Ant5";
            this.toolTip1.SetToolTip(this.radioButton_AntPort5, "Switch the current work antenna to this Antenna port. (API encode: 04)");
            this.radioButton_AntPort5.UseVisualStyleBackColor = true;
            this.radioButton_AntPort5.Click += new System.EventHandler(this.radioButton_AntPort5_Click);
            // 
            // radioButton_AntPort4
            // 
            this.radioButton_AntPort4.AutoSize = true;
            this.radioButton_AntPort4.Enabled = false;
            this.radioButton_AntPort4.Location = new System.Drawing.Point(18, 103);
            this.radioButton_AntPort4.Name = "radioButton_AntPort4";
            this.radioButton_AntPort4.Size = new System.Drawing.Size(51, 19);
            this.radioButton_AntPort4.TabIndex = 3;
            this.radioButton_AntPort4.TabStop = true;
            this.radioButton_AntPort4.Text = "Ant4";
            this.toolTip1.SetToolTip(this.radioButton_AntPort4, "Switch the current work antenna to this Antenna port. (API encode: 03)");
            this.radioButton_AntPort4.UseVisualStyleBackColor = true;
            this.radioButton_AntPort4.Click += new System.EventHandler(this.radioButton_AntPort4_Click);
            // 
            // radioButton_AntPort3
            // 
            this.radioButton_AntPort3.AutoSize = true;
            this.radioButton_AntPort3.Enabled = false;
            this.radioButton_AntPort3.Location = new System.Drawing.Point(18, 76);
            this.radioButton_AntPort3.Name = "radioButton_AntPort3";
            this.radioButton_AntPort3.Size = new System.Drawing.Size(51, 19);
            this.radioButton_AntPort3.TabIndex = 2;
            this.radioButton_AntPort3.TabStop = true;
            this.radioButton_AntPort3.Text = "Ant3";
            this.toolTip1.SetToolTip(this.radioButton_AntPort3, "Switch the current work antenna to this Antenna port. (API encode: 02)");
            this.radioButton_AntPort3.UseVisualStyleBackColor = true;
            this.radioButton_AntPort3.Click += new System.EventHandler(this.radioButton_AntPort3_Click);
            // 
            // radioButton_AntPort2
            // 
            this.radioButton_AntPort2.AutoSize = true;
            this.radioButton_AntPort2.Enabled = false;
            this.radioButton_AntPort2.Location = new System.Drawing.Point(18, 49);
            this.radioButton_AntPort2.Name = "radioButton_AntPort2";
            this.radioButton_AntPort2.Size = new System.Drawing.Size(51, 19);
            this.radioButton_AntPort2.TabIndex = 1;
            this.radioButton_AntPort2.TabStop = true;
            this.radioButton_AntPort2.Text = "Ant2";
            this.toolTip1.SetToolTip(this.radioButton_AntPort2, "Switch the current work antenna to this Antenna port. (API encode: 01)");
            this.radioButton_AntPort2.UseVisualStyleBackColor = true;
            this.radioButton_AntPort2.Click += new System.EventHandler(this.radioButton_AntPort2_Click);
            // 
            // radioButton_AntPort1
            // 
            this.radioButton_AntPort1.AutoSize = true;
            this.radioButton_AntPort1.Location = new System.Drawing.Point(18, 22);
            this.radioButton_AntPort1.Name = "radioButton_AntPort1";
            this.radioButton_AntPort1.Size = new System.Drawing.Size(51, 19);
            this.radioButton_AntPort1.TabIndex = 0;
            this.radioButton_AntPort1.TabStop = true;
            this.radioButton_AntPort1.Text = "Ant1";
            this.toolTip1.SetToolTip(this.radioButton_AntPort1, "Switch the current work antenna to this Antenna port. (API encode: 00)");
            this.radioButton_AntPort1.UseVisualStyleBackColor = true;
            this.radioButton_AntPort1.Click += new System.EventHandler(this.radioButton_AntPort1_Click);
            // 
            // radioButton_AntPort8
            // 
            this.radioButton_AntPort8.AutoSize = true;
            this.radioButton_AntPort8.Enabled = false;
            this.radioButton_AntPort8.Location = new System.Drawing.Point(18, 209);
            this.radioButton_AntPort8.Name = "radioButton_AntPort8";
            this.radioButton_AntPort8.Size = new System.Drawing.Size(51, 19);
            this.radioButton_AntPort8.TabIndex = 7;
            this.radioButton_AntPort8.TabStop = true;
            this.radioButton_AntPort8.Text = "Ant8";
            this.toolTip1.SetToolTip(this.radioButton_AntPort8, "Switch the current work antenna to this Antenna port. (API encode: 07)");
            this.radioButton_AntPort8.UseVisualStyleBackColor = true;
            this.radioButton_AntPort8.Click += new System.EventHandler(this.radioButton_AntPort8_Click);
            // 
            // textBox_RF_AntPort_InvCnter8
            // 
            this.textBox_RF_AntPort_InvCnter8.Enabled = false;
            this.textBox_RF_AntPort_InvCnter8.Location = new System.Drawing.Point(289, 230);
            this.textBox_RF_AntPort_InvCnter8.Name = "textBox_RF_AntPort_InvCnter8";
            this.textBox_RF_AntPort_InvCnter8.Size = new System.Drawing.Size(71, 21);
            this.textBox_RF_AntPort_InvCnter8.TabIndex = 23;
            this.textBox_RF_AntPort_InvCnter8.Text = "5";
            this.toolTip1.SetToolTip(this.textBox_RF_AntPort_InvCnter8, "Dwell on this antenna port untill number of Inventory tag command has been sent w" +
        "hen \"Auto Polling\" is enabled.");
            // 
            // comboBoxRF_AntPort_Port8
            // 
            this.comboBoxRF_AntPort_Port8.Enabled = false;
            this.comboBoxRF_AntPort_Port8.FormattingEnabled = true;
            this.comboBoxRF_AntPort_Port8.Items.AddRange(new object[] {
            "30dBm",
            "29dBm",
            "28dBm",
            "27dBm",
            "26dBm",
            "25dBm",
            "24dBm",
            "23dBm",
            "22dBm",
            "21dBm",
            "20dBm",
            "19dBm",
            "18dBm",
            "17dBm",
            "16dBm",
            "15dBm",
            "14dBm",
            "13dBm",
            "12dBm",
            "11dBm",
            "10dBm",
            "09dBm",
            "08dBm",
            "07dBm",
            "06dBm",
            "05dBm",
            "04dBm",
            "03dBm",
            "02dBm",
            "01dBm",
            "00dBm"});
            this.comboBoxRF_AntPort_Port8.Location = new System.Drawing.Point(185, 230);
            this.comboBoxRF_AntPort_Port8.Name = "comboBoxRF_AntPort_Port8";
            this.comboBoxRF_AntPort_Port8.Size = new System.Drawing.Size(71, 23);
            this.comboBoxRF_AntPort_Port8.TabIndex = 22;
            this.toolTip1.SetToolTip(this.comboBoxRF_AntPort_Port8, "Independ RF Power for each antenna port when \"Auto Polling\" is enabled.");
            // 
            // textBox_RF_AntPort_InvCnter7
            // 
            this.textBox_RF_AntPort_InvCnter7.Enabled = false;
            this.textBox_RF_AntPort_InvCnter7.Location = new System.Drawing.Point(289, 201);
            this.textBox_RF_AntPort_InvCnter7.Name = "textBox_RF_AntPort_InvCnter7";
            this.textBox_RF_AntPort_InvCnter7.Size = new System.Drawing.Size(71, 21);
            this.textBox_RF_AntPort_InvCnter7.TabIndex = 21;
            this.textBox_RF_AntPort_InvCnter7.Text = "5";
            this.toolTip1.SetToolTip(this.textBox_RF_AntPort_InvCnter7, "Dwell on this antenna port untill number of Inventory tag command has been sent w" +
        "hen \"Auto Polling\" is enabled.");
            // 
            // comboBoxRF_AntPort_Port7
            // 
            this.comboBoxRF_AntPort_Port7.Enabled = false;
            this.comboBoxRF_AntPort_Port7.FormattingEnabled = true;
            this.comboBoxRF_AntPort_Port7.Items.AddRange(new object[] {
            "30dBm",
            "29dBm",
            "28dBm",
            "27dBm",
            "26dBm",
            "25dBm",
            "24dBm",
            "23dBm",
            "22dBm",
            "21dBm",
            "20dBm",
            "19dBm",
            "18dBm",
            "17dBm",
            "16dBm",
            "15dBm",
            "14dBm",
            "13dBm",
            "12dBm",
            "11dBm",
            "10dBm",
            "09dBm",
            "08dBm",
            "07dBm",
            "06dBm",
            "05dBm",
            "04dBm",
            "03dBm",
            "02dBm",
            "01dBm",
            "00dBm"});
            this.comboBoxRF_AntPort_Port7.Location = new System.Drawing.Point(185, 201);
            this.comboBoxRF_AntPort_Port7.Name = "comboBoxRF_AntPort_Port7";
            this.comboBoxRF_AntPort_Port7.Size = new System.Drawing.Size(71, 23);
            this.comboBoxRF_AntPort_Port7.TabIndex = 20;
            this.toolTip1.SetToolTip(this.comboBoxRF_AntPort_Port7, "Independ RF Power for each antenna port when \"Auto Polling\" is enabled.");
            // 
            // textBox_RF_AntPort_InvCnter6
            // 
            this.textBox_RF_AntPort_InvCnter6.Enabled = false;
            this.textBox_RF_AntPort_InvCnter6.Location = new System.Drawing.Point(289, 174);
            this.textBox_RF_AntPort_InvCnter6.Name = "textBox_RF_AntPort_InvCnter6";
            this.textBox_RF_AntPort_InvCnter6.Size = new System.Drawing.Size(71, 21);
            this.textBox_RF_AntPort_InvCnter6.TabIndex = 19;
            this.textBox_RF_AntPort_InvCnter6.Text = "5";
            this.toolTip1.SetToolTip(this.textBox_RF_AntPort_InvCnter6, "Dwell on this antenna port untill number of Inventory tag command has been sent w" +
        "hen \"Auto Polling\" is enabled.");
            // 
            // comboBoxRF_AntPort_Port6
            // 
            this.comboBoxRF_AntPort_Port6.Enabled = false;
            this.comboBoxRF_AntPort_Port6.FormattingEnabled = true;
            this.comboBoxRF_AntPort_Port6.Items.AddRange(new object[] {
            "30dBm",
            "29dBm",
            "28dBm",
            "27dBm",
            "26dBm",
            "25dBm",
            "24dBm",
            "23dBm",
            "22dBm",
            "21dBm",
            "20dBm",
            "19dBm",
            "18dBm",
            "17dBm",
            "16dBm",
            "15dBm",
            "14dBm",
            "13dBm",
            "12dBm",
            "11dBm",
            "10dBm",
            "09dBm",
            "08dBm",
            "07dBm",
            "06dBm",
            "05dBm",
            "04dBm",
            "03dBm",
            "02dBm",
            "01dBm",
            "00dBm"});
            this.comboBoxRF_AntPort_Port6.Location = new System.Drawing.Point(185, 174);
            this.comboBoxRF_AntPort_Port6.Name = "comboBoxRF_AntPort_Port6";
            this.comboBoxRF_AntPort_Port6.Size = new System.Drawing.Size(71, 23);
            this.comboBoxRF_AntPort_Port6.TabIndex = 18;
            this.toolTip1.SetToolTip(this.comboBoxRF_AntPort_Port6, "Independ RF Power for each antenna port when \"Auto Polling\" is enabled.");
            // 
            // textBox_RF_AntPort_InvCnter5
            // 
            this.textBox_RF_AntPort_InvCnter5.Enabled = false;
            this.textBox_RF_AntPort_InvCnter5.Location = new System.Drawing.Point(289, 147);
            this.textBox_RF_AntPort_InvCnter5.Name = "textBox_RF_AntPort_InvCnter5";
            this.textBox_RF_AntPort_InvCnter5.Size = new System.Drawing.Size(71, 21);
            this.textBox_RF_AntPort_InvCnter5.TabIndex = 17;
            this.textBox_RF_AntPort_InvCnter5.Text = "5";
            this.toolTip1.SetToolTip(this.textBox_RF_AntPort_InvCnter5, "Dwell on this antenna port untill number of Inventory tag command has been sent w" +
        "hen \"Auto Polling\" is enabled.");
            // 
            // comboBoxRF_AntPort_Port5
            // 
            this.comboBoxRF_AntPort_Port5.Enabled = false;
            this.comboBoxRF_AntPort_Port5.FormattingEnabled = true;
            this.comboBoxRF_AntPort_Port5.Items.AddRange(new object[] {
            "30dBm",
            "29dBm",
            "28dBm",
            "27dBm",
            "26dBm",
            "25dBm",
            "24dBm",
            "23dBm",
            "22dBm",
            "21dBm",
            "20dBm",
            "19dBm",
            "18dBm",
            "17dBm",
            "16dBm",
            "15dBm",
            "14dBm",
            "13dBm",
            "12dBm",
            "11dBm",
            "10dBm",
            "09dBm",
            "08dBm",
            "07dBm",
            "06dBm",
            "05dBm",
            "04dBm",
            "03dBm",
            "02dBm",
            "01dBm",
            "00dBm"});
            this.comboBoxRF_AntPort_Port5.Location = new System.Drawing.Point(185, 147);
            this.comboBoxRF_AntPort_Port5.Name = "comboBoxRF_AntPort_Port5";
            this.comboBoxRF_AntPort_Port5.Size = new System.Drawing.Size(71, 23);
            this.comboBoxRF_AntPort_Port5.TabIndex = 16;
            this.toolTip1.SetToolTip(this.comboBoxRF_AntPort_Port5, "Independ RF Power for each antenna port when \"Auto Polling\" is enabled.");
            // 
            // textBox_RF_AntPort_InvCnter4
            // 
            this.textBox_RF_AntPort_InvCnter4.Enabled = false;
            this.textBox_RF_AntPort_InvCnter4.Location = new System.Drawing.Point(289, 120);
            this.textBox_RF_AntPort_InvCnter4.Name = "textBox_RF_AntPort_InvCnter4";
            this.textBox_RF_AntPort_InvCnter4.Size = new System.Drawing.Size(71, 21);
            this.textBox_RF_AntPort_InvCnter4.TabIndex = 15;
            this.textBox_RF_AntPort_InvCnter4.Text = "5";
            this.toolTip1.SetToolTip(this.textBox_RF_AntPort_InvCnter4, "Dwell on this antenna port untill number of Inventory tag command has been sent w" +
        "hen \"Auto Polling\" is enabled.");
            // 
            // comboBoxRF_AntPort_Port4
            // 
            this.comboBoxRF_AntPort_Port4.Enabled = false;
            this.comboBoxRF_AntPort_Port4.FormattingEnabled = true;
            this.comboBoxRF_AntPort_Port4.Items.AddRange(new object[] {
            "30dBm",
            "29dBm",
            "28dBm",
            "27dBm",
            "26dBm",
            "25dBm",
            "24dBm",
            "23dBm",
            "22dBm",
            "21dBm",
            "20dBm",
            "19dBm",
            "18dBm",
            "17dBm",
            "16dBm",
            "15dBm",
            "14dBm",
            "13dBm",
            "12dBm",
            "11dBm",
            "10dBm",
            "09dBm",
            "08dBm",
            "07dBm",
            "06dBm",
            "05dBm",
            "04dBm",
            "03dBm",
            "02dBm",
            "01dBm",
            "00dBm"});
            this.comboBoxRF_AntPort_Port4.Location = new System.Drawing.Point(185, 120);
            this.comboBoxRF_AntPort_Port4.Name = "comboBoxRF_AntPort_Port4";
            this.comboBoxRF_AntPort_Port4.Size = new System.Drawing.Size(71, 23);
            this.comboBoxRF_AntPort_Port4.TabIndex = 14;
            this.toolTip1.SetToolTip(this.comboBoxRF_AntPort_Port4, "Independ RF Power for each antenna port when \"Auto Polling\" is enabled.");
            // 
            // textBox_RF_AntPort_InvCnter3
            // 
            this.textBox_RF_AntPort_InvCnter3.Enabled = false;
            this.textBox_RF_AntPort_InvCnter3.Location = new System.Drawing.Point(289, 93);
            this.textBox_RF_AntPort_InvCnter3.Name = "textBox_RF_AntPort_InvCnter3";
            this.textBox_RF_AntPort_InvCnter3.Size = new System.Drawing.Size(71, 21);
            this.textBox_RF_AntPort_InvCnter3.TabIndex = 13;
            this.textBox_RF_AntPort_InvCnter3.Text = "5";
            this.toolTip1.SetToolTip(this.textBox_RF_AntPort_InvCnter3, "Dwell on this antenna port untill number of Inventory tag command has been sent w" +
        "hen \"Auto Polling\" is enabled.");
            // 
            // comboBoxRF_AntPort_Port3
            // 
            this.comboBoxRF_AntPort_Port3.Enabled = false;
            this.comboBoxRF_AntPort_Port3.FormattingEnabled = true;
            this.comboBoxRF_AntPort_Port3.Items.AddRange(new object[] {
            "30dBm",
            "29dBm",
            "28dBm",
            "27dBm",
            "26dBm",
            "25dBm",
            "24dBm",
            "23dBm",
            "22dBm",
            "21dBm",
            "20dBm",
            "19dBm",
            "18dBm",
            "17dBm",
            "16dBm",
            "15dBm",
            "14dBm",
            "13dBm",
            "12dBm",
            "11dBm",
            "10dBm",
            "09dBm",
            "08dBm",
            "07dBm",
            "06dBm",
            "05dBm",
            "04dBm",
            "03dBm",
            "02dBm",
            "01dBm",
            "00dBm"});
            this.comboBoxRF_AntPort_Port3.Location = new System.Drawing.Point(185, 93);
            this.comboBoxRF_AntPort_Port3.Name = "comboBoxRF_AntPort_Port3";
            this.comboBoxRF_AntPort_Port3.Size = new System.Drawing.Size(71, 23);
            this.comboBoxRF_AntPort_Port3.TabIndex = 12;
            this.toolTip1.SetToolTip(this.comboBoxRF_AntPort_Port3, "Independ RF Power for each antenna port when \"Auto Polling\" is enabled.");
            // 
            // textBox_RF_AntPort_InvCnter2
            // 
            this.textBox_RF_AntPort_InvCnter2.Enabled = false;
            this.textBox_RF_AntPort_InvCnter2.Location = new System.Drawing.Point(289, 66);
            this.textBox_RF_AntPort_InvCnter2.Name = "textBox_RF_AntPort_InvCnter2";
            this.textBox_RF_AntPort_InvCnter2.Size = new System.Drawing.Size(71, 21);
            this.textBox_RF_AntPort_InvCnter2.TabIndex = 11;
            this.textBox_RF_AntPort_InvCnter2.Text = "5";
            this.toolTip1.SetToolTip(this.textBox_RF_AntPort_InvCnter2, "Dwell on this antenna port untill number of Inventory tag command has been sent w" +
        "hen \"Auto Polling\" is enabled.");
            // 
            // comboBoxRF_AntPort_Port2
            // 
            this.comboBoxRF_AntPort_Port2.Enabled = false;
            this.comboBoxRF_AntPort_Port2.FormattingEnabled = true;
            this.comboBoxRF_AntPort_Port2.Items.AddRange(new object[] {
            "30dBm",
            "29dBm",
            "28dBm",
            "27dBm",
            "26dBm",
            "25dBm",
            "24dBm",
            "23dBm",
            "22dBm",
            "21dBm",
            "20dBm",
            "19dBm",
            "18dBm",
            "17dBm",
            "16dBm",
            "15dBm",
            "14dBm",
            "13dBm",
            "12dBm",
            "11dBm",
            "10dBm",
            "09dBm",
            "08dBm",
            "07dBm",
            "06dBm",
            "05dBm",
            "04dBm",
            "03dBm",
            "02dBm",
            "01dBm",
            "00dBm"});
            this.comboBoxRF_AntPort_Port2.Location = new System.Drawing.Point(185, 66);
            this.comboBoxRF_AntPort_Port2.Name = "comboBoxRF_AntPort_Port2";
            this.comboBoxRF_AntPort_Port2.Size = new System.Drawing.Size(71, 23);
            this.comboBoxRF_AntPort_Port2.TabIndex = 10;
            this.toolTip1.SetToolTip(this.comboBoxRF_AntPort_Port2, "Independ RF Power for each antenna port when \"Auto Polling\" is enabled.");
            // 
            // textBox_RF_AntPort_InvCnter1
            // 
            this.textBox_RF_AntPort_InvCnter1.Location = new System.Drawing.Point(289, 39);
            this.textBox_RF_AntPort_InvCnter1.Name = "textBox_RF_AntPort_InvCnter1";
            this.textBox_RF_AntPort_InvCnter1.Size = new System.Drawing.Size(71, 21);
            this.textBox_RF_AntPort_InvCnter1.TabIndex = 9;
            this.textBox_RF_AntPort_InvCnter1.Text = "5";
            this.toolTip1.SetToolTip(this.textBox_RF_AntPort_InvCnter1, "Dwell on this antenna port untill number of Inventory tag command has been sent w" +
        "hen \"Auto Polling\" is enabled.");
            // 
            // comboBoxRF_AntPort_Port1
            // 
            this.comboBoxRF_AntPort_Port1.FormattingEnabled = true;
            this.comboBoxRF_AntPort_Port1.Items.AddRange(new object[] {
            "30dBm",
            "29dBm",
            "28dBm",
            "27dBm",
            "26dBm",
            "25dBm",
            "24dBm",
            "23dBm",
            "22dBm",
            "21dBm",
            "20dBm",
            "19dBm",
            "18dBm",
            "17dBm",
            "16dBm",
            "15dBm",
            "14dBm",
            "13dBm",
            "12dBm",
            "11dBm",
            "10dBm",
            "09dBm",
            "08dBm",
            "07dBm",
            "06dBm",
            "05dBm",
            "04dBm",
            "03dBm",
            "02dBm",
            "01dBm",
            "00dBm"});
            this.comboBoxRF_AntPort_Port1.Location = new System.Drawing.Point(185, 39);
            this.comboBoxRF_AntPort_Port1.Name = "comboBoxRF_AntPort_Port1";
            this.comboBoxRF_AntPort_Port1.Size = new System.Drawing.Size(71, 23);
            this.comboBoxRF_AntPort_Port1.TabIndex = 8;
            this.toolTip1.SetToolTip(this.comboBoxRF_AntPort_Port1, "Independ RF Power for each antenna port when \"Auto Polling\" is enabled.");
            // 
            // comboBox_RF_AntPort_Quantity
            // 
            this.comboBox_RF_AntPort_Quantity.FormattingEnabled = true;
            this.comboBox_RF_AntPort_Quantity.Items.AddRange(new object[] {
            "1",
            "4"});
            this.comboBox_RF_AntPort_Quantity.Location = new System.Drawing.Point(82, 20);
            this.comboBox_RF_AntPort_Quantity.Name = "comboBox_RF_AntPort_Quantity";
            this.comboBox_RF_AntPort_Quantity.Size = new System.Drawing.Size(71, 23);
            this.comboBox_RF_AntPort_Quantity.TabIndex = 9;
            this.toolTip1.SetToolTip(this.comboBox_RF_AntPort_Quantity, "Select this quantity of the antenna port according to the reader\'s antenna port.");
            this.comboBox_RF_AntPort_Quantity.SelectedIndexChanged += new System.EventHandler(this.comboBox_RF_AntPort_Quantity_SelectedIndexChanged);
            // 
            // checkBox_RF_AntPort_AutoPolling
            // 
            this.checkBox_RF_AntPort_AutoPolling.AutoSize = true;
            this.checkBox_RF_AntPort_AutoPolling.Location = new System.Drawing.Point(182, 20);
            this.checkBox_RF_AntPort_AutoPolling.Name = "checkBox_RF_AntPort_AutoPolling";
            this.checkBox_RF_AntPort_AutoPolling.Size = new System.Drawing.Size(93, 19);
            this.checkBox_RF_AntPort_AutoPolling.TabIndex = 26;
            this.checkBox_RF_AntPort_AutoPolling.Text = "Auto Polling";
            this.toolTip1.SetToolTip(this.checkBox_RF_AntPort_AutoPolling, "Auto polling each valid antenna port when the Mulit-Tag Command is sent.");
            this.checkBox_RF_AntPort_AutoPolling.UseVisualStyleBackColor = true;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(48, 59);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(93, 15);
            this.label39.TabIndex = 20;
            this.label39.Text = "0-Loop for ever";
            this.toolTip1.SetToolTip(this.label39, "Continue to Inventory until Stop command.");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(48, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 15);
            this.label15.TabIndex = 5;
            this.label15.Text = "1-65535 To Stop.";
            this.toolTip1.SetToolTip(this.label15, "Number of inventory to stop.");
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(13, 55);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(147, 29);
            this.btnContinue.TabIndex = 9;
            this.btnContinue.Text = "Continue";
            this.toolTip1.SetToolTip(this.btnContinue, "Read the tags only once at each interval defined by right edit box.");
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // checkBox_InvtMulti_AutoClear
            // 
            this.checkBox_InvtMulti_AutoClear.AutoSize = true;
            this.checkBox_InvtMulti_AutoClear.Location = new System.Drawing.Point(13, 89);
            this.checkBox_InvtMulti_AutoClear.Name = "checkBox_InvtMulti_AutoClear";
            this.checkBox_InvtMulti_AutoClear.Size = new System.Drawing.Size(85, 19);
            this.checkBox_InvtMulti_AutoClear.TabIndex = 22;
            this.checkBox_InvtMulti_AutoClear.Text = "Auto Clear";
            this.toolTip1.SetToolTip(this.checkBox_InvtMulti_AutoClear, "Clear the Tag list table on GUI before start Multi-tag Read.");
            this.checkBox_InvtMulti_AutoClear.UseVisualStyleBackColor = true;
            // 
            // btn_SetNewBaudRate
            // 
            this.btn_SetNewBaudRate.Location = new System.Drawing.Point(207, 20);
            this.btn_SetNewBaudRate.Name = "btn_SetNewBaudRate";
            this.btn_SetNewBaudRate.Size = new System.Drawing.Size(71, 26);
            this.btn_SetNewBaudRate.TabIndex = 25;
            this.btn_SetNewBaudRate.Text = "Set";
            this.toolTip1.SetToolTip(this.btn_SetNewBaudRate, "Set the new Baud Rate of Module Reader. (Take effect after reset the Module Reade" +
        "r)");
            this.btn_SetNewBaudRate.UseVisualStyleBackColor = true;
            this.btn_SetNewBaudRate.Click += new System.EventHandler(this.btn_SetNewBaudRate_Click);
            // 
            // btn_GetNewBaudRate
            // 
            this.btn_GetNewBaudRate.Location = new System.Drawing.Point(6, 20);
            this.btn_GetNewBaudRate.Name = "btn_GetNewBaudRate";
            this.btn_GetNewBaudRate.Size = new System.Drawing.Size(71, 26);
            this.btn_GetNewBaudRate.TabIndex = 26;
            this.btn_GetNewBaudRate.Text = "Get";
            this.toolTip1.SetToolTip(this.btn_GetNewBaudRate, "Get the Baud Rate of Module Reader");
            this.btn_GetNewBaudRate.UseVisualStyleBackColor = true;
            this.btn_GetNewBaudRate.Click += new System.EventHandler(this.btn_GetNewBaudRate_Click);
            // 
            // button_GPIO_Set
            // 
            this.button_GPIO_Set.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GPIO_Set.Location = new System.Drawing.Point(103, 146);
            this.button_GPIO_Set.Name = "button_GPIO_Set";
            this.button_GPIO_Set.Size = new System.Drawing.Size(87, 32);
            this.button_GPIO_Set.TabIndex = 3;
            this.button_GPIO_Set.Text = "Set";
            this.toolTip1.SetToolTip(this.button_GPIO_Set, "Set the GPO output of the fixed reader!");
            this.button_GPIO_Set.UseVisualStyleBackColor = true;
            this.button_GPIO_Set.Click += new System.EventHandler(this.button_GPIO_Set_Click);
            // 
            // button_GPIO_Get
            // 
            this.button_GPIO_Get.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GPIO_Get.Location = new System.Drawing.Point(10, 146);
            this.button_GPIO_Get.Name = "button_GPIO_Get";
            this.button_GPIO_Get.Size = new System.Drawing.Size(87, 32);
            this.button_GPIO_Get.TabIndex = 2;
            this.button_GPIO_Get.Text = "Get";
            this.toolTip1.SetToolTip(this.button_GPIO_Get, "Get the GPO Output and GPI Input status of the fixed reader!");
            this.button_GPIO_Get.UseVisualStyleBackColor = true;
            this.button_GPIO_Get.Click += new System.EventHandler(this.button_GPIO_Get_Click);
            // 
            // btnSetIO
            // 
            this.btnSetIO.Location = new System.Drawing.Point(82, 52);
            this.btnSetIO.Name = "btnSetIO";
            this.btnSetIO.Size = new System.Drawing.Size(94, 26);
            this.btnSetIO.TabIndex = 60;
            this.btnSetIO.Text = "Set";
            this.toolTip1.SetToolTip(this.btnSetIO, "Set the GPO stauts of Module Reader");
            this.btnSetIO.UseVisualStyleBackColor = true;
            this.btnSetIO.Click += new System.EventHandler(this.btnSetIO_Click);
            // 
            // btnGetIO
            // 
            this.btnGetIO.Location = new System.Drawing.Point(9, 52);
            this.btnGetIO.Name = "btnGetIO";
            this.btnGetIO.Size = new System.Drawing.Size(67, 27);
            this.btnGetIO.TabIndex = 59;
            this.btnGetIO.Text = "Get";
            this.toolTip1.SetToolTip(this.btnGetIO, "Get the GPI and GPO stauts of Module Reader");
            this.btnGetIO.UseVisualStyleBackColor = true;
            this.btnGetIO.Click += new System.EventHandler(this.btnGetIO_Click);
            // 
            // btnGetRegion
            // 
            this.btnGetRegion.Location = new System.Drawing.Point(105, 20);
            this.btnGetRegion.Name = "btnGetRegion";
            this.btnGetRegion.Size = new System.Drawing.Size(87, 29);
            this.btnGetRegion.TabIndex = 23;
            this.btnGetRegion.Text = "Get Region";
            this.toolTip1.SetToolTip(this.btnGetRegion, "Get Frequncy Rules for Country Region ");
            this.btnGetRegion.UseVisualStyleBackColor = true;
            this.btnGetRegion.Click += new System.EventHandler(this.btnGetRegion_Click);
            // 
            // btnSetRegion
            // 
            this.btnSetRegion.Location = new System.Drawing.Point(8, 20);
            this.btnSetRegion.Name = "btnSetRegion";
            this.btnSetRegion.Size = new System.Drawing.Size(87, 29);
            this.btnSetRegion.TabIndex = 6;
            this.btnSetRegion.Text = "Set Region";
            this.toolTip1.SetToolTip(this.btnSetRegion, "Set Frequncy Rules for Country Region");
            this.btnSetRegion.UseVisualStyleBackColor = true;
            this.btnSetRegion.Click += new System.EventHandler(this.btnSetRegion_Click);
            // 
            // cbx_SensorTag_SensorTagType
            // 
            this.cbx_SensorTag_SensorTagType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_SensorTag_SensorTagType.FormattingEnabled = true;
            this.cbx_SensorTag_SensorTagType.Items.AddRange(new object[] {
            "01-RFM Temperature",
            "02-RFM Mositure (not Work)",
            "03-YEH Temperature",
            "04-YEH Temperature(3G)",
            "05-YEH Temperature(3GSL)"});
            this.cbx_SensorTag_SensorTagType.Location = new System.Drawing.Point(77, 18);
            this.cbx_SensorTag_SensorTagType.Name = "cbx_SensorTag_SensorTagType";
            this.cbx_SensorTag_SensorTagType.Size = new System.Drawing.Size(159, 23);
            this.cbx_SensorTag_SensorTagType.TabIndex = 106;
            this.toolTip1.SetToolTip(this.cbx_SensorTag_SensorTagType, "Choose the Type of Sensor Tag");
            // 
            // btn_SensorTag_StopRead
            // 
            this.btn_SensorTag_StopRead.Location = new System.Drawing.Point(93, 175);
            this.btn_SensorTag_StopRead.Name = "btn_SensorTag_StopRead";
            this.btn_SensorTag_StopRead.Size = new System.Drawing.Size(146, 31);
            this.btn_SensorTag_StopRead.TabIndex = 105;
            this.btn_SensorTag_StopRead.Text = "Stop";
            this.toolTip1.SetToolTip(this.btn_SensorTag_StopRead, "Break While Reading Sensor Tag");
            this.btn_SensorTag_StopRead.UseVisualStyleBackColor = true;
            this.btn_SensorTag_StopRead.Click += new System.EventHandler(this.btn_SensorTag_StopRead_Click);
            // 
            // btn_SensorTag_GetTmpAuto
            // 
            this.btn_SensorTag_GetTmpAuto.Location = new System.Drawing.Point(93, 138);
            this.btn_SensorTag_GetTmpAuto.Name = "btn_SensorTag_GetTmpAuto";
            this.btn_SensorTag_GetTmpAuto.Size = new System.Drawing.Size(146, 31);
            this.btn_SensorTag_GetTmpAuto.TabIndex = 101;
            this.btn_SensorTag_GetTmpAuto.Text = "Get Temperature Auto";
            this.toolTip1.SetToolTip(this.btn_SensorTag_GetTmpAuto, "Auto to reading the Sensor value of Sensor Tag from step1 to step3");
            this.btn_SensorTag_GetTmpAuto.UseVisualStyleBackColor = true;
            this.btn_SensorTag_GetTmpAuto.Click += new System.EventHandler(this.btn_SensorTag_GetTmpAuto_Click);
            // 
            // cbx_SensorTag_ReadNumber
            // 
            this.cbx_SensorTag_ReadNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_SensorTag_ReadNumber.FormattingEnabled = true;
            this.cbx_SensorTag_ReadNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.cbx_SensorTag_ReadNumber.Location = new System.Drawing.Point(149, 47);
            this.cbx_SensorTag_ReadNumber.Name = "cbx_SensorTag_ReadNumber";
            this.cbx_SensorTag_ReadNumber.Size = new System.Drawing.Size(87, 23);
            this.cbx_SensorTag_ReadNumber.TabIndex = 100;
            this.toolTip1.SetToolTip(this.cbx_SensorTag_ReadNumber, "Choose the number while reading each Sensor Tag");
            // 
            // btn_SensorTag_GetTmpOne
            // 
            this.btn_SensorTag_GetTmpOne.Location = new System.Drawing.Point(93, 101);
            this.btn_SensorTag_GetTmpOne.Name = "btn_SensorTag_GetTmpOne";
            this.btn_SensorTag_GetTmpOne.Size = new System.Drawing.Size(146, 31);
            this.btn_SensorTag_GetTmpOne.TabIndex = 97;
            this.btn_SensorTag_GetTmpOne.Text = "Get Temperature One";
            this.toolTip1.SetToolTip(this.btn_SensorTag_GetTmpOne, "Get Sensor Temperature of Sensor Tag in Selected number.");
            this.btn_SensorTag_GetTmpOne.UseVisualStyleBackColor = true;
            this.btn_SensorTag_GetTmpOne.Click += new System.EventHandler(this.btn_SensorTag_GetTmpOne_Click);
            // 
            // btn_SensorTag_InventoryOne
            // 
            this.btn_SensorTag_InventoryOne.Location = new System.Drawing.Point(908, 12);
            this.btn_SensorTag_InventoryOne.Name = "btn_SensorTag_InventoryOne";
            this.btn_SensorTag_InventoryOne.Size = new System.Drawing.Size(146, 31);
            this.btn_SensorTag_InventoryOne.TabIndex = 96;
            this.btn_SensorTag_InventoryOne.Text = "Inventory Sensor EPC";
            this.toolTip1.SetToolTip(this.btn_SensorTag_InventoryOne, "Inventory EPC ID of Sensor Tag ");
            this.btn_SensorTag_InventoryOne.UseVisualStyleBackColor = true;
            this.btn_SensorTag_InventoryOne.Click += new System.EventHandler(this.btn_SensorTag_InventoryOne_Click);
            // 
            // btn_SelectAllSensorTag
            // 
            this.btn_SelectAllSensorTag.Location = new System.Drawing.Point(118, 11);
            this.btn_SelectAllSensorTag.Name = "btn_SelectAllSensorTag";
            this.btn_SelectAllSensorTag.Size = new System.Drawing.Size(95, 29);
            this.btn_SelectAllSensorTag.TabIndex = 22;
            this.btn_SelectAllSensorTag.Text = "Selected All";
            this.toolTip1.SetToolTip(this.btn_SelectAllSensorTag, "Select the Sensor Tag");
            this.btn_SelectAllSensorTag.UseVisualStyleBackColor = true;
            this.btn_SelectAllSensorTag.Click += new System.EventHandler(this.btn_SelectAllSensorTag_Click);
            // 
            // btnInsertRfCh_Get
            // 
            this.btnInsertRfCh_Get.Location = new System.Drawing.Point(11, 61);
            this.btnInsertRfCh_Get.Name = "btnInsertRfCh_Get";
            this.btnInsertRfCh_Get.Size = new System.Drawing.Size(87, 29);
            this.btnInsertRfCh_Get.TabIndex = 24;
            this.btnInsertRfCh_Get.Text = "Get RFCH";
            this.toolTip1.SetToolTip(this.btnInsertRfCh_Get, "Get the freqency hopping range for FHSS in current RF channel region");
            this.btnInsertRfCh_Get.UseVisualStyleBackColor = true;
            this.btnInsertRfCh_Get.Click += new System.EventHandler(this.btnInsertRfCh_Get_Click);
            // 
            // txtChIndexBegin
            // 
            this.txtChIndexBegin.Location = new System.Drawing.Point(145, 26);
            this.txtChIndexBegin.Name = "txtChIndexBegin";
            this.txtChIndexBegin.Size = new System.Drawing.Size(38, 21);
            this.txtChIndexBegin.TabIndex = 13;
            this.txtChIndexBegin.Text = "1";
            this.txtChIndexBegin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtChIndexBegin, "MIN.=0;");
            // 
            // txtChIndexEnd
            // 
            this.txtChIndexEnd.Location = new System.Drawing.Point(225, 26);
            this.txtChIndexEnd.Name = "txtChIndexEnd";
            this.txtChIndexEnd.Size = new System.Drawing.Size(38, 21);
            this.txtChIndexEnd.TabIndex = 14;
            this.txtChIndexEnd.Text = "5";
            this.txtChIndexEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtChIndexEnd, "MAX.=RF Region Max No.");
            // 
            // btnInsertRfCh
            // 
            this.btnInsertRfCh.Location = new System.Drawing.Point(11, 20);
            this.btnInsertRfCh.Name = "btnInsertRfCh";
            this.btnInsertRfCh.Size = new System.Drawing.Size(87, 29);
            this.btnInsertRfCh.TabIndex = 8;
            this.btnInsertRfCh.Text = "Insert RFCH";
            this.toolTip1.SetToolTip(this.btnInsertRfCh, "Inser a group of freqency range into current RF channel from current RF region. (" +
        "Insert a New RF Channel to work properly after \"Set Region\" to Clear Insert RF C" +
        "hannel.)");
            this.btnInsertRfCh.UseVisualStyleBackColor = true;
            this.btnInsertRfCh.Click += new System.EventHandler(this.btnInsertRfCh_Click);
            // 
            // txtReceive
            // 
            this.txtReceive.AllowDrop = true;
            this.txtReceive.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReceive.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceive.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtReceive.Location = new System.Drawing.Point(6, 52);
            this.txtReceive.MaxLength = 65536;
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.ReadOnly = true;
            this.txtReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceive.Size = new System.Drawing.Size(737, 113);
            this.txtReceive.TabIndex = 1;
            this.txtReceive.DoubleClick += new System.EventHandler(this.txtReceive_DoubleClick);
            // 
            // txtSend
            // 
            this.txtSend.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSend.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSend.Location = new System.Drawing.Point(102, 550);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(647, 21);
            this.txtSend.TabIndex = 2;
            this.txtSend.Visible = false;
            this.txtSend.DoubleClick += new System.EventHandler(this.txtSend_DoubleClick);
            // 
            // btn_clear_rx
            // 
            this.btn_clear_rx.Location = new System.Drawing.Point(340, 11);
            this.btn_clear_rx.Name = "btn_clear_rx";
            this.btn_clear_rx.Size = new System.Drawing.Size(75, 29);
            this.btn_clear_rx.TabIndex = 3;
            this.btn_clear_rx.Text = "Clear";
            this.btn_clear_rx.UseVisualStyleBackColor = true;
            this.btn_clear_rx.Click += new System.EventHandler(this.btn_clear_rx_Click);
            // 
            // btnClearCnt
            // 
            this.btnClearCnt.Location = new System.Drawing.Point(6, 5);
            this.btnClearCnt.Name = "btnClearCnt";
            this.btnClearCnt.Size = new System.Drawing.Size(87, 29);
            this.btnClearCnt.TabIndex = 5;
            this.btnClearCnt.Text = "Reset";
            this.btnClearCnt.UseVisualStyleBackColor = true;
            this.btnClearCnt.Click += new System.EventHandler(this.btn_clear_cnt_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(9, 546);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(87, 29);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Visible = false;
            this.btnSend.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // timerAutoSend
            // 
            this.timerAutoSend.Tick += new System.EventHandler(this.timerAutoSend_Tick);
            // 
            // gbxRxData
            // 
            this.gbxRxData.Controls.Add(this.cbxRxVisable);
            this.gbxRxData.Controls.Add(this.cbxAutoClear);
            this.gbxRxData.Controls.Add(this.btn_clear_rx);
            this.gbxRxData.Controls.Add(this.txtReceive);
            this.gbxRxData.Location = new System.Drawing.Point(0, 382);
            this.gbxRxData.Name = "gbxRxData";
            this.gbxRxData.Size = new System.Drawing.Size(749, 162);
            this.gbxRxData.TabIndex = 17;
            this.gbxRxData.TabStop = false;
            this.gbxRxData.Text = "Receive Data";
            this.gbxRxData.Visible = false;
            // 
            // cbxRxVisable
            // 
            this.cbxRxVisable.AutoSize = true;
            this.cbxRxVisable.Checked = true;
            this.cbxRxVisable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxRxVisable.Location = new System.Drawing.Point(522, 15);
            this.cbxRxVisable.Name = "cbxRxVisable";
            this.cbxRxVisable.Size = new System.Drawing.Size(68, 19);
            this.cbxRxVisable.TabIndex = 5;
            this.cbxRxVisable.Text = "Visable";
            this.cbxRxVisable.UseVisualStyleBackColor = true;
            // 
            // cbxAutoClear
            // 
            this.cbxAutoClear.AutoSize = true;
            this.cbxAutoClear.Checked = true;
            this.cbxAutoClear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAutoClear.Location = new System.Drawing.Point(438, 15);
            this.cbxAutoClear.Name = "cbxAutoClear";
            this.cbxAutoClear.Size = new System.Drawing.Size(81, 19);
            this.cbxAutoClear.TabIndex = 4;
            this.cbxAutoClear.Text = "Autoclear";
            this.cbxAutoClear.UseVisualStyleBackColor = true;
            // 
            // gbx_inventory
            // 
            this.gbx_inventory.Controls.Add(this.cbxQBasic);
            this.gbx_inventory.Controls.Add(this.txtSendDelay);
            this.gbx_inventory.Controls.Add(this.label3);
            this.gbx_inventory.Controls.Add(this.label4);
            this.gbx_inventory.Controls.Add(this.btnInvtBasic);
            this.gbx_inventory.Controls.Add(this.btnContinue);
            this.gbx_inventory.Location = new System.Drawing.Point(9, 6);
            this.gbx_inventory.Name = "gbx_inventory";
            this.gbx_inventory.Size = new System.Drawing.Size(281, 91);
            this.gbx_inventory.TabIndex = 18;
            this.gbx_inventory.TabStop = false;
            this.gbx_inventory.Text = "Inventory Single Tag";
            // 
            // cbxQBasic
            // 
            this.cbxQBasic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQBasic.FormattingEnabled = true;
            this.cbxQBasic.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbxQBasic.Location = new System.Drawing.Point(223, 20);
            this.cbxQBasic.Name = "cbxQBasic";
            this.cbxQBasic.Size = new System.Drawing.Size(42, 23);
            this.cbxQBasic.TabIndex = 2;
            this.cbxQBasic.SelectedIndexChanged += new System.EventHandler(this.cbx_q_basic_SelectedIndexChanged);
            // 
            // txtSendDelay
            // 
            this.txtSendDelay.Location = new System.Drawing.Point(189, 56);
            this.txtSendDelay.Name = "txtSendDelay";
            this.txtSendDelay.Size = new System.Drawing.Size(47, 21);
            this.txtSendDelay.TabIndex = 14;
            this.txtSendDelay.Text = "380";
            this.txtSendDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Q =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "ms";
            // 
            // gbx_MTR
            // 
            this.gbx_MTR.Controls.Add(this.checkBox_InvtMulti_AutoClear);
            this.gbx_MTR.Controls.Add(this.gbx_MTR_LoopNum);
            this.gbx_MTR.Controls.Add(this.lbl_MTR_Algorithm);
            this.gbx_MTR.Controls.Add(this.cbx_MTR_Algorithm);
            this.gbx_MTR.Controls.Add(this.lbl_MTR_Qvalue);
            this.gbx_MTR.Controls.Add(this.cbx_MTR_Qvalue);
            this.gbx_MTR.Controls.Add(this.btnStopRD);
            this.gbx_MTR.Controls.Add(this.btnInvtMulti);
            this.gbx_MTR.Location = new System.Drawing.Point(7, 101);
            this.gbx_MTR.Name = "gbx_MTR";
            this.gbx_MTR.Size = new System.Drawing.Size(291, 159);
            this.gbx_MTR.TabIndex = 16;
            this.gbx_MTR.TabStop = false;
            this.gbx_MTR.Text = "Inventory Mulit-Tag";
            this.gbx_MTR.Visible = false;
            // 
            // gbx_MTR_LoopNum
            // 
            this.gbx_MTR_LoopNum.Controls.Add(this.label39);
            this.gbx_MTR_LoopNum.Controls.Add(this.lbl_MTR_Read_Number);
            this.gbx_MTR_LoopNum.Controls.Add(this.label15);
            this.gbx_MTR_LoopNum.Controls.Add(this.txtRDMultiNum);
            this.gbx_MTR_LoopNum.Location = new System.Drawing.Point(126, 17);
            this.gbx_MTR_LoopNum.Name = "gbx_MTR_LoopNum";
            this.gbx_MTR_LoopNum.Size = new System.Drawing.Size(159, 85);
            this.gbx_MTR_LoopNum.TabIndex = 21;
            this.gbx_MTR_LoopNum.TabStop = false;
            this.gbx_MTR_LoopNum.Text = "Loop Number";
            // 
            // lbl_MTR_Read_Number
            // 
            this.lbl_MTR_Read_Number.AutoSize = true;
            this.lbl_MTR_Read_Number.Location = new System.Drawing.Point(8, 23);
            this.lbl_MTR_Read_Number.Name = "lbl_MTR_Read_Number";
            this.lbl_MTR_Read_Number.Size = new System.Drawing.Size(36, 15);
            this.lbl_MTR_Read_Number.TabIndex = 17;
            this.lbl_MTR_Read_Number.Text = "Num:";
            // 
            // lbl_MTR_Algorithm
            // 
            this.lbl_MTR_Algorithm.AutoSize = true;
            this.lbl_MTR_Algorithm.Location = new System.Drawing.Point(6, 55);
            this.lbl_MTR_Algorithm.Name = "lbl_MTR_Algorithm";
            this.lbl_MTR_Algorithm.Size = new System.Drawing.Size(62, 15);
            this.lbl_MTR_Algorithm.TabIndex = 19;
            this.lbl_MTR_Algorithm.Text = "Algorithm";
            // 
            // lbl_MTR_Qvalue
            // 
            this.lbl_MTR_Qvalue.AutoSize = true;
            this.lbl_MTR_Qvalue.Location = new System.Drawing.Point(10, 25);
            this.lbl_MTR_Qvalue.Name = "lbl_MTR_Qvalue";
            this.lbl_MTR_Qvalue.Size = new System.Drawing.Size(50, 15);
            this.lbl_MTR_Qvalue.TabIndex = 16;
            this.lbl_MTR_Qvalue.Text = "Q Value";
            // 
            // dgvEpcBasic
            // 
            this.dgvEpcBasic.AllowUserToAddRows = false;
            this.dgvEpcBasic.AllowUserToDeleteRows = false;
            this.dgvEpcBasic.AllowUserToResizeColumns = false;
            this.dgvEpcBasic.AllowUserToResizeRows = false;
            this.dgvEpcBasic.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEpcBasic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEpcBasic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEpcBasic.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvEpcBasic.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvEpcBasic.Location = new System.Drawing.Point(6, 126);
            this.dgvEpcBasic.Name = "dgvEpcBasic";
            this.dgvEpcBasic.ReadOnly = true;
            this.dgvEpcBasic.RowHeadersVisible = false;
            this.dgvEpcBasic.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEpcBasic.RowTemplate.Height = 18;
            this.dgvEpcBasic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEpcBasic.Size = new System.Drawing.Size(737, 232);
            this.dgvEpcBasic.TabIndex = 19;
            this.dgvEpcBasic.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsCsvToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 26);
            // 
            // saveAsCsvToolStripMenuItem
            // 
            this.saveAsCsvToolStripMenuItem.Name = "saveAsCsvToolStripMenuItem";
            this.saveAsCsvToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveAsCsvToolStripMenuItem.Text = "Save As csv File";
            this.saveAsCsvToolStripMenuItem.Click += new System.EventHandler(this.saveAsTxtToolStripMenuItem_Click);
            // 
            // gbxEpcTableBasic
            // 
            this.gbxEpcTableBasic.Controls.Add(this.textBox_EPC_Tag_Total);
            this.gbxEpcTableBasic.Controls.Add(this.label_EPC_Tag_Total);
            this.gbxEpcTableBasic.Controls.Add(this.textBox_EPC_TagCounter);
            this.gbxEpcTableBasic.Controls.Add(this.label_EPC_TagCounter);
            this.gbxEpcTableBasic.Controls.Add(this.btn_clear_epc1);
            this.gbxEpcTableBasic.Controls.Add(this.dgvEpcBasic);
            this.gbxEpcTableBasic.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEpcTableBasic.Location = new System.Drawing.Point(0, 6);
            this.gbxEpcTableBasic.Name = "gbxEpcTableBasic";
            this.gbxEpcTableBasic.Size = new System.Drawing.Size(749, 370);
            this.gbxEpcTableBasic.TabIndex = 20;
            this.gbxEpcTableBasic.TabStop = false;
            this.gbxEpcTableBasic.Text = "Registration";
            // 
            // textBox_EPC_Tag_Total
            // 
            this.textBox_EPC_Tag_Total.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EPC_Tag_Total.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox_EPC_Tag_Total.Location = new System.Drawing.Point(444, 11);
            this.textBox_EPC_Tag_Total.Name = "textBox_EPC_Tag_Total";
            this.textBox_EPC_Tag_Total.ReadOnly = true;
            this.textBox_EPC_Tag_Total.Size = new System.Drawing.Size(165, 29);
            this.textBox_EPC_Tag_Total.TabIndex = 24;
            this.textBox_EPC_Tag_Total.Text = "0";
            this.textBox_EPC_Tag_Total.Visible = false;
            // 
            // label_EPC_Tag_Total
            // 
            this.label_EPC_Tag_Total.AutoSize = true;
            this.label_EPC_Tag_Total.Location = new System.Drawing.Point(342, 20);
            this.label_EPC_Tag_Total.Name = "label_EPC_Tag_Total";
            this.label_EPC_Tag_Total.Size = new System.Drawing.Size(92, 15);
            this.label_EPC_Tag_Total.TabIndex = 23;
            this.label_EPC_Tag_Total.Text = "Weapon Type : ";
            // 
            // textBox_EPC_TagCounter
            // 
            this.textBox_EPC_TagCounter.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EPC_TagCounter.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox_EPC_TagCounter.Location = new System.Drawing.Point(133, 11);
            this.textBox_EPC_TagCounter.Name = "textBox_EPC_TagCounter";
            this.textBox_EPC_TagCounter.ReadOnly = true;
            this.textBox_EPC_TagCounter.Size = new System.Drawing.Size(165, 29);
            this.textBox_EPC_TagCounter.TabIndex = 22;
            this.textBox_EPC_TagCounter.Text = "0";
            this.textBox_EPC_TagCounter.Visible = false;
            // 
            // label_EPC_TagCounter
            // 
            this.label_EPC_TagCounter.AutoSize = true;
            this.label_EPC_TagCounter.Location = new System.Drawing.Point(43, 18);
            this.label_EPC_TagCounter.Name = "label_EPC_TagCounter";
            this.label_EPC_TagCounter.Size = new System.Drawing.Size(62, 15);
            this.label_EPC_TagCounter.TabIndex = 21;
            this.label_EPC_TagCounter.Text = "Location :";
            // 
            // btn_clear_epc1
            // 
            this.btn_clear_epc1.Location = new System.Drawing.Point(654, 13);
            this.btn_clear_epc1.Name = "btn_clear_epc1";
            this.btn_clear_epc1.Size = new System.Drawing.Size(75, 29);
            this.btn_clear_epc1.TabIndex = 20;
            this.btn_clear_epc1.Text = "Clear";
            this.btn_clear_epc1.UseVisualStyleBackColor = true;
            this.btn_clear_epc1.Visible = false;
            this.btn_clear_epc1.Click += new System.EventHandler(this.btn_clear_basictable_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMain);
            this.tabControl1.Controls.Add(this.tabPageSysSetting);
            this.tabControl1.Controls.Add(this.tabPageAccessTag);
            this.tabControl1.Controls.Add(this.tabPageSensorTag);
            this.tabControl1.Controls.Add(this.tabPageTMS);
            this.tabControl1.Controls.Add(this.tabPageImpinjTag);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1075, 647);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPageMain
            // 
            this.tabPageMain.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageMain.Controls.Add(this.tabControl2);
            this.tabPageMain.Controls.Add(this.BtnTest);
            this.tabPageMain.Controls.Add(this.gbxStatus);
            this.tabPageMain.Controls.Add(this.gbxEpcTableBasic);
            this.tabPageMain.Controls.Add(this.btnSend);
            this.tabPageMain.Controls.Add(this.txtSend);
            this.tabPageMain.Controls.Add(this.gbx_conn);
            this.tabPageMain.Controls.Add(this.gbxRxData);
            this.tabPageMain.Location = new System.Drawing.Point(4, 24);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(1067, 619);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Select & Set weapon for registration";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage_TagRead);
            this.tabControl2.Controls.Add(this.tabPage_SysSetting);
            this.tabControl2.Location = new System.Drawing.Point(755, 132);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(309, 483);
            this.tabControl2.TabIndex = 34;
            // 
            // tabPage_TagRead
            // 
            this.tabPage_TagRead.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tabPage_TagRead.Controls.Add(this.gbx_inventory);
            this.tabPage_TagRead.Controls.Add(this.gbx_MTR);
            this.tabPage_TagRead.Controls.Add(this.pbx_Inv_Indicator);
            this.tabPage_TagRead.Location = new System.Drawing.Point(4, 24);
            this.tabPage_TagRead.Name = "tabPage_TagRead";
            this.tabPage_TagRead.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_TagRead.Size = new System.Drawing.Size(301, 455);
            this.tabPage_TagRead.TabIndex = 0;
            this.tabPage_TagRead.Text = "Tag Read";
            // 
            // pbx_Inv_Indicator
            // 
            this.pbx_Inv_Indicator.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pbx_Inv_Indicator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbx_Inv_Indicator.BackgroundImage")));
            this.pbx_Inv_Indicator.Location = new System.Drawing.Point(33, 258);
            this.pbx_Inv_Indicator.Name = "pbx_Inv_Indicator";
            this.pbx_Inv_Indicator.Size = new System.Drawing.Size(241, 125);
            this.pbx_Inv_Indicator.TabIndex = 27;
            this.pbx_Inv_Indicator.TabStop = false;
            this.pbx_Inv_Indicator.Visible = false;
            // 
            // tabPage_SysSetting
            // 
            this.tabPage_SysSetting.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage_SysSetting.Controls.Add(this.groupBox6);
            this.tabPage_SysSetting.Controls.Add(this.gbx_NewDevAddr);
            this.tabPage_SysSetting.Location = new System.Drawing.Point(4, 24);
            this.tabPage_SysSetting.Name = "tabPage_SysSetting";
            this.tabPage_SysSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SysSetting.Size = new System.Drawing.Size(301, 455);
            this.tabPage_SysSetting.TabIndex = 1;
            this.tabPage_SysSetting.Text = "System Setting";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbxNewBaudRate);
            this.groupBox6.Controls.Add(this.btn_SetNewBaudRate);
            this.groupBox6.Controls.Add(this.btn_GetNewBaudRate);
            this.groupBox6.Location = new System.Drawing.Point(6, 70);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(284, 58);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "New Baud Rate (Module Reader Only)";
            // 
            // cbxNewBaudRate
            // 
            this.cbxNewBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNewBaudRate.FormattingEnabled = true;
            this.cbxNewBaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.cbxNewBaudRate.Location = new System.Drawing.Point(95, 23);
            this.cbxNewBaudRate.Name = "cbxNewBaudRate";
            this.cbxNewBaudRate.Size = new System.Drawing.Size(94, 23);
            this.cbxNewBaudRate.TabIndex = 26;
            // 
            // BtnTest
            // 
            this.BtnTest.Location = new System.Drawing.Point(709, 576);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(40, 37);
            this.BtnTest.TabIndex = 33;
            this.BtnTest.Text = "test";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // gbxStatus
            // 
            this.gbxStatus.Controls.Add(this.txtFirmwareVersion);
            this.gbxStatus.Controls.Add(this.txtHardwareVersion);
            this.gbxStatus.Controls.Add(this.label37);
            this.gbxStatus.Controls.Add(this.labelHardwareVersion);
            this.gbxStatus.Controls.Add(this.btnClearCnt);
            this.gbxStatus.Controls.Add(this.label17);
            this.gbxStatus.Controls.Add(this.txtCOMRxCnt);
            this.gbxStatus.Controls.Add(this.label16);
            this.gbxStatus.Controls.Add(this.txtCOMTxCnt);
            this.gbxStatus.Location = new System.Drawing.Point(3, 573);
            this.gbxStatus.Name = "gbxStatus";
            this.gbxStatus.Size = new System.Drawing.Size(697, 39);
            this.gbxStatus.TabIndex = 25;
            this.gbxStatus.TabStop = false;
            // 
            // txtFirmwareVersion
            // 
            this.txtFirmwareVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirmwareVersion.Location = new System.Drawing.Point(384, 17);
            this.txtFirmwareVersion.Name = "txtFirmwareVersion";
            this.txtFirmwareVersion.ReadOnly = true;
            this.txtFirmwareVersion.Size = new System.Drawing.Size(47, 14);
            this.txtFirmwareVersion.TabIndex = 26;
            // 
            // txtHardwareVersion
            // 
            this.txtHardwareVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHardwareVersion.Location = new System.Drawing.Point(551, 16);
            this.txtHardwareVersion.Name = "txtHardwareVersion";
            this.txtHardwareVersion.ReadOnly = true;
            this.txtHardwareVersion.Size = new System.Drawing.Size(126, 14);
            this.txtHardwareVersion.TabIndex = 26;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(271, 16);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(110, 15);
            this.label37.TabIndex = 25;
            this.label37.Text = "Firmware Version:";
            // 
            // labelHardwareVersion
            // 
            this.labelHardwareVersion.AutoSize = true;
            this.labelHardwareVersion.Location = new System.Drawing.Point(438, 15);
            this.labelHardwareVersion.Name = "labelHardwareVersion";
            this.labelHardwareVersion.Size = new System.Drawing.Size(112, 15);
            this.labelHardwareVersion.TabIndex = 25;
            this.labelHardwareVersion.Text = "Hardware Version:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(187, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 15);
            this.label17.TabIndex = 24;
            this.label17.Text = "TX:";
            // 
            // txtCOMRxCnt
            // 
            this.txtCOMRxCnt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCOMRxCnt.Location = new System.Drawing.Point(130, 15);
            this.txtCOMRxCnt.Name = "txtCOMRxCnt";
            this.txtCOMRxCnt.ReadOnly = true;
            this.txtCOMRxCnt.Size = new System.Drawing.Size(58, 14);
            this.txtCOMRxCnt.TabIndex = 21;
            this.txtCOMRxCnt.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(98, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 15);
            this.label16.TabIndex = 22;
            this.label16.Text = "RX:";
            // 
            // txtCOMTxCnt
            // 
            this.txtCOMTxCnt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCOMTxCnt.Location = new System.Drawing.Point(213, 16);
            this.txtCOMTxCnt.Name = "txtCOMTxCnt";
            this.txtCOMTxCnt.ReadOnly = true;
            this.txtCOMTxCnt.Size = new System.Drawing.Size(58, 14);
            this.txtCOMTxCnt.TabIndex = 23;
            this.txtCOMTxCnt.Text = "0";
            // 
            // tabPageSysSetting
            // 
            this.tabPageSysSetting.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSysSetting.Controls.Add(this.groupBox3);
            this.tabPageSysSetting.Controls.Add(this.groupBox_RFSetting);
            this.tabPageSysSetting.Location = new System.Drawing.Point(4, 24);
            this.tabPageSysSetting.Name = "tabPageSysSetting";
            this.tabPageSysSetting.Size = new System.Drawing.Size(1067, 619);
            this.tabPageSysSetting.TabIndex = 4;
            this.tabPageSysSetting.Text = "System Setting";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox_GPIO);
            this.groupBox3.Controls.Add(this.gbxIoControl);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(15, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 482);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "System";
            // 
            // groupBox_GPIO
            // 
            this.groupBox_GPIO.Controls.Add(this.button_GPIO_Set);
            this.groupBox_GPIO.Controls.Add(this.button_GPIO_Get);
            this.groupBox_GPIO.Controls.Add(this.groupBox_GPI);
            this.groupBox_GPIO.Controls.Add(this.groupBox_GPO);
            this.groupBox_GPIO.Location = new System.Drawing.Point(6, 277);
            this.groupBox_GPIO.Name = "groupBox_GPIO";
            this.groupBox_GPIO.Size = new System.Drawing.Size(253, 194);
            this.groupBox_GPIO.TabIndex = 115;
            this.groupBox_GPIO.TabStop = false;
            this.groupBox_GPIO.Text = "GPIO (Fixed Reader Only)";
            // 
            // groupBox_GPI
            // 
            this.groupBox_GPI.Controls.Add(this.checkBox_GPI4);
            this.groupBox_GPI.Controls.Add(this.checkBox_GPI1);
            this.groupBox_GPI.Controls.Add(this.checkBox_GPI3);
            this.groupBox_GPI.Controls.Add(this.checkBox_GPI2);
            this.groupBox_GPI.Location = new System.Drawing.Point(111, 20);
            this.groupBox_GPI.Name = "groupBox_GPI";
            this.groupBox_GPI.Size = new System.Drawing.Size(74, 113);
            this.groupBox_GPI.TabIndex = 1;
            this.groupBox_GPI.TabStop = false;
            this.groupBox_GPI.Text = "GPI";
            // 
            // checkBox_GPI4
            // 
            this.checkBox_GPI4.AutoSize = true;
            this.checkBox_GPI4.Location = new System.Drawing.Point(12, 86);
            this.checkBox_GPI4.Name = "checkBox_GPI4";
            this.checkBox_GPI4.Size = new System.Drawing.Size(52, 19);
            this.checkBox_GPI4.TabIndex = 7;
            this.checkBox_GPI4.Text = "GPI4";
            this.checkBox_GPI4.UseVisualStyleBackColor = true;
            // 
            // checkBox_GPI1
            // 
            this.checkBox_GPI1.AutoSize = true;
            this.checkBox_GPI1.Location = new System.Drawing.Point(12, 20);
            this.checkBox_GPI1.Name = "checkBox_GPI1";
            this.checkBox_GPI1.Size = new System.Drawing.Size(52, 19);
            this.checkBox_GPI1.TabIndex = 4;
            this.checkBox_GPI1.Text = "GPI1";
            this.checkBox_GPI1.UseVisualStyleBackColor = true;
            // 
            // checkBox_GPI3
            // 
            this.checkBox_GPI3.AutoSize = true;
            this.checkBox_GPI3.Location = new System.Drawing.Point(12, 64);
            this.checkBox_GPI3.Name = "checkBox_GPI3";
            this.checkBox_GPI3.Size = new System.Drawing.Size(52, 19);
            this.checkBox_GPI3.TabIndex = 6;
            this.checkBox_GPI3.Text = "GPI3";
            this.checkBox_GPI3.UseVisualStyleBackColor = true;
            // 
            // checkBox_GPI2
            // 
            this.checkBox_GPI2.AutoSize = true;
            this.checkBox_GPI2.Location = new System.Drawing.Point(12, 42);
            this.checkBox_GPI2.Name = "checkBox_GPI2";
            this.checkBox_GPI2.Size = new System.Drawing.Size(52, 19);
            this.checkBox_GPI2.TabIndex = 5;
            this.checkBox_GPI2.Text = "GPI2";
            this.checkBox_GPI2.UseVisualStyleBackColor = true;
            // 
            // groupBox_GPO
            // 
            this.groupBox_GPO.Controls.Add(this.checkBox_GPO4);
            this.groupBox_GPO.Controls.Add(this.checkBox_GPO3);
            this.groupBox_GPO.Controls.Add(this.checkBox_GPO2);
            this.groupBox_GPO.Controls.Add(this.checkBox_GPO1);
            this.groupBox_GPO.Location = new System.Drawing.Point(18, 20);
            this.groupBox_GPO.Name = "groupBox_GPO";
            this.groupBox_GPO.Size = new System.Drawing.Size(74, 113);
            this.groupBox_GPO.TabIndex = 0;
            this.groupBox_GPO.TabStop = false;
            this.groupBox_GPO.Text = "GPO";
            // 
            // checkBox_GPO4
            // 
            this.checkBox_GPO4.AutoSize = true;
            this.checkBox_GPO4.Location = new System.Drawing.Point(6, 87);
            this.checkBox_GPO4.Name = "checkBox_GPO4";
            this.checkBox_GPO4.Size = new System.Drawing.Size(58, 19);
            this.checkBox_GPO4.TabIndex = 3;
            this.checkBox_GPO4.Text = "GPO4";
            this.checkBox_GPO4.UseVisualStyleBackColor = true;
            // 
            // checkBox_GPO3
            // 
            this.checkBox_GPO3.AutoSize = true;
            this.checkBox_GPO3.Location = new System.Drawing.Point(6, 65);
            this.checkBox_GPO3.Name = "checkBox_GPO3";
            this.checkBox_GPO3.Size = new System.Drawing.Size(58, 19);
            this.checkBox_GPO3.TabIndex = 2;
            this.checkBox_GPO3.Text = "GPO3";
            this.checkBox_GPO3.UseVisualStyleBackColor = true;
            // 
            // checkBox_GPO2
            // 
            this.checkBox_GPO2.AutoSize = true;
            this.checkBox_GPO2.Location = new System.Drawing.Point(6, 43);
            this.checkBox_GPO2.Name = "checkBox_GPO2";
            this.checkBox_GPO2.Size = new System.Drawing.Size(58, 19);
            this.checkBox_GPO2.TabIndex = 1;
            this.checkBox_GPO2.Text = "GPO2";
            this.checkBox_GPO2.UseVisualStyleBackColor = true;
            // 
            // checkBox_GPO1
            // 
            this.checkBox_GPO1.AutoSize = true;
            this.checkBox_GPO1.Location = new System.Drawing.Point(6, 21);
            this.checkBox_GPO1.Name = "checkBox_GPO1";
            this.checkBox_GPO1.Size = new System.Drawing.Size(58, 19);
            this.checkBox_GPO1.TabIndex = 0;
            this.checkBox_GPO1.Text = "GPO1";
            this.checkBox_GPO1.UseVisualStyleBackColor = true;
            // 
            // gbxIoControl
            // 
            this.gbxIoControl.Controls.Add(this.cbxIoDircetion);
            this.gbxIoControl.Controls.Add(this.cbxIoLevel);
            this.gbxIoControl.Controls.Add(this.btnSetIoDirection);
            this.gbxIoControl.Controls.Add(this.btnSetIO);
            this.gbxIoControl.Controls.Add(this.btnGetIO);
            this.gbxIoControl.Controls.Add(this.cbxIO);
            this.gbxIoControl.Location = new System.Drawing.Point(6, 172);
            this.gbxIoControl.Name = "gbxIoControl";
            this.gbxIoControl.Size = new System.Drawing.Size(253, 85);
            this.gbxIoControl.TabIndex = 60;
            this.gbxIoControl.TabStop = false;
            this.gbxIoControl.Text = "IO Operation(Module Reader Only)";
            this.gbxIoControl.Visible = false;
            // 
            // cbxIoDircetion
            // 
            this.cbxIoDircetion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIoDircetion.FormattingEnabled = true;
            this.cbxIoDircetion.Items.AddRange(new object[] {
            "Input",
            "Output"});
            this.cbxIoDircetion.Location = new System.Drawing.Point(182, 22);
            this.cbxIoDircetion.Name = "cbxIoDircetion";
            this.cbxIoDircetion.Size = new System.Drawing.Size(60, 23);
            this.cbxIoDircetion.TabIndex = 65;
            // 
            // cbxIoLevel
            // 
            this.cbxIoLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIoLevel.FormattingEnabled = true;
            this.cbxIoLevel.Items.AddRange(new object[] {
            "Low",
            "High"});
            this.cbxIoLevel.Location = new System.Drawing.Point(182, 54);
            this.cbxIoLevel.Name = "cbxIoLevel";
            this.cbxIoLevel.Size = new System.Drawing.Size(60, 23);
            this.cbxIoLevel.TabIndex = 64;
            // 
            // btnSetIoDirection
            // 
            this.btnSetIoDirection.Location = new System.Drawing.Point(82, 20);
            this.btnSetIoDirection.Name = "btnSetIoDirection";
            this.btnSetIoDirection.Size = new System.Drawing.Size(94, 27);
            this.btnSetIoDirection.TabIndex = 62;
            this.btnSetIoDirection.Text = "Set Direction";
            this.btnSetIoDirection.UseVisualStyleBackColor = true;
            this.btnSetIoDirection.Click += new System.EventHandler(this.btnSetIoDirection_Click);
            // 
            // cbxIO
            // 
            this.cbxIO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIO.FormattingEnabled = true;
            this.cbxIO.Items.AddRange(new object[] {
            "IO1",
            "IO2",
            "IO3",
            "IO4"});
            this.cbxIO.Location = new System.Drawing.Point(9, 23);
            this.cbxIO.Name = "cbxIO";
            this.cbxIO.Size = new System.Drawing.Size(67, 23);
            this.cbxIO.TabIndex = 58;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSetModuleSleep);
            this.groupBox4.Controls.Add(this.bynSaveConfigToNv);
            this.groupBox4.Controls.Add(this.cbxSaveNvConfig);
            this.groupBox4.Controls.Add(this.cbxMode);
            this.groupBox4.Controls.Add(this.btnSetMode);
            this.groupBox4.Location = new System.Drawing.Point(6, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(253, 141);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "General Setting";
            // 
            // btnSetModuleSleep
            // 
            this.btnSetModuleSleep.Location = new System.Drawing.Point(10, 95);
            this.btnSetModuleSleep.Name = "btnSetModuleSleep";
            this.btnSetModuleSleep.Size = new System.Drawing.Size(95, 29);
            this.btnSetModuleSleep.TabIndex = 32;
            this.btnSetModuleSleep.Text = "Sleep";
            this.btnSetModuleSleep.UseVisualStyleBackColor = true;
            this.btnSetModuleSleep.Click += new System.EventHandler(this.btnSetModuleSleep_Click);
            // 
            // bynSaveConfigToNv
            // 
            this.bynSaveConfigToNv.Location = new System.Drawing.Point(9, 57);
            this.bynSaveConfigToNv.Name = "bynSaveConfigToNv";
            this.bynSaveConfigToNv.Size = new System.Drawing.Size(96, 29);
            this.bynSaveConfigToNv.TabIndex = 31;
            this.bynSaveConfigToNv.Text = "Save Config";
            this.bynSaveConfigToNv.UseVisualStyleBackColor = true;
            this.bynSaveConfigToNv.Click += new System.EventHandler(this.btnSaveConfigToNv_Click);
            // 
            // cbxSaveNvConfig
            // 
            this.cbxSaveNvConfig.AutoSize = true;
            this.cbxSaveNvConfig.Checked = true;
            this.cbxSaveNvConfig.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxSaveNvConfig.Location = new System.Drawing.Point(123, 64);
            this.cbxSaveNvConfig.Name = "cbxSaveNvConfig";
            this.cbxSaveNvConfig.Size = new System.Drawing.Size(103, 19);
            this.cbxSaveNvConfig.TabIndex = 30;
            this.cbxSaveNvConfig.Text = "Config Enable";
            this.cbxSaveNvConfig.UseVisualStyleBackColor = true;
            // 
            // cbxMode
            // 
            this.cbxMode.AutoCompleteCustomSource.AddRange(new string[] {
            "High Sensitivity",
            "Dense Reader"});
            this.cbxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMode.FormattingEnabled = true;
            this.cbxMode.Items.AddRange(new object[] {
            "High Sensitivity",
            "Dense Reader"});
            this.cbxMode.Location = new System.Drawing.Point(127, 24);
            this.cbxMode.Name = "cbxMode";
            this.cbxMode.Size = new System.Drawing.Size(112, 23);
            this.cbxMode.TabIndex = 29;
            // 
            // btnSetMode
            // 
            this.btnSetMode.Location = new System.Drawing.Point(10, 20);
            this.btnSetMode.Name = "btnSetMode";
            this.btnSetMode.Size = new System.Drawing.Size(95, 29);
            this.btnSetMode.TabIndex = 28;
            this.btnSetMode.Text = "Set Mode";
            this.btnSetMode.UseVisualStyleBackColor = true;
            this.btnSetMode.Click += new System.EventHandler(this.btnSetMode_Click);
            // 
            // groupBox_RFSetting
            // 
            this.groupBox_RFSetting.Controls.Add(this.gbxRfPower);
            this.groupBox_RFSetting.Controls.Add(this.gbx_setfreq);
            this.groupBox_RFSetting.Controls.Add(this.groupBox_RF_Ant);
            this.groupBox_RFSetting.Location = new System.Drawing.Point(286, 3);
            this.groupBox_RFSetting.Name = "groupBox_RFSetting";
            this.groupBox_RFSetting.Size = new System.Drawing.Size(717, 449);
            this.groupBox_RFSetting.TabIndex = 3;
            this.groupBox_RFSetting.TabStop = false;
            this.groupBox_RFSetting.Text = "RF Setting";
            // 
            // gbxRfPower
            // 
            this.gbxRfPower.Controls.Add(this.btnSetCW);
            this.gbxRfPower.Controls.Add(this.btnGetPaPower);
            this.gbxRfPower.Controls.Add(this.cbxPaPower);
            this.gbxRfPower.Controls.Add(this.btnSetPaPower);
            this.gbxRfPower.Location = new System.Drawing.Point(6, 319);
            this.gbxRfPower.Name = "gbxRfPower";
            this.gbxRfPower.Size = new System.Drawing.Size(303, 109);
            this.gbxRfPower.TabIndex = 27;
            this.gbxRfPower.TabStop = false;
            this.gbxRfPower.Text = "RF Power Setting";
            // 
            // btnGetPaPower
            // 
            this.btnGetPaPower.Location = new System.Drawing.Point(113, 20);
            this.btnGetPaPower.Name = "btnGetPaPower";
            this.btnGetPaPower.Size = new System.Drawing.Size(99, 29);
            this.btnGetPaPower.TabIndex = 2;
            this.btnGetPaPower.Text = "Get PA Power";
            this.btnGetPaPower.UseVisualStyleBackColor = true;
            this.btnGetPaPower.Click += new System.EventHandler(this.btnGetPaPower_Click);
            // 
            // cbxPaPower
            // 
            this.cbxPaPower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPaPower.FormattingEnabled = true;
            this.cbxPaPower.Items.AddRange(new object[] {
            "20dBm",
            "18.5dBm",
            "17dBm",
            "15.5dBm",
            "14dBm",
            "12.5dBm"});
            this.cbxPaPower.Location = new System.Drawing.Point(219, 23);
            this.cbxPaPower.Name = "cbxPaPower";
            this.cbxPaPower.Size = new System.Drawing.Size(74, 23);
            this.cbxPaPower.TabIndex = 1;
            // 
            // btnSetPaPower
            // 
            this.btnSetPaPower.Location = new System.Drawing.Point(8, 20);
            this.btnSetPaPower.Name = "btnSetPaPower";
            this.btnSetPaPower.Size = new System.Drawing.Size(99, 29);
            this.btnSetPaPower.TabIndex = 0;
            this.btnSetPaPower.Text = "Set PA Power";
            this.btnSetPaPower.UseVisualStyleBackColor = true;
            this.btnSetPaPower.Click += new System.EventHandler(this.btnSetPaPower_Click);
            // 
            // gbx_setfreq
            // 
            this.gbx_setfreq.Controls.Add(this.gbx_InsertRFCH);
            this.gbx_setfreq.Controls.Add(this.btnGetRegion);
            this.gbx_setfreq.Controls.Add(this.btnGetFreqHopPeriod);
            this.gbx_setfreq.Controls.Add(this.btnSetFreqHopPeriod);
            this.gbx_setfreq.Controls.Add(this.cbxFhssHopPeriod);
            this.gbx_setfreq.Controls.Add(this.cbxFHSS);
            this.gbx_setfreq.Controls.Add(this.btnGetFhss);
            this.gbx_setfreq.Controls.Add(this.btnSetRegion);
            this.gbx_setfreq.Controls.Add(this.btnGetChannel);
            this.gbx_setfreq.Controls.Add(this.btnSetFhss);
            this.gbx_setfreq.Controls.Add(this.cbxChannel);
            this.gbx_setfreq.Controls.Add(this.cbxRegion);
            this.gbx_setfreq.Controls.Add(this.btnSetFreq);
            this.gbx_setfreq.Location = new System.Drawing.Point(6, 21);
            this.gbx_setfreq.Name = "gbx_setfreq";
            this.gbx_setfreq.Size = new System.Drawing.Size(325, 278);
            this.gbx_setfreq.TabIndex = 17;
            this.gbx_setfreq.TabStop = false;
            this.gbx_setfreq.Text = "RF Channel Setting";
            // 
            // gbx_InsertRFCH
            // 
            this.gbx_InsertRFCH.Controls.Add(this.btnInsertRfCh_Help);
            this.gbx_InsertRFCH.Controls.Add(this.btnInsertRfCh_Get);
            this.gbx_InsertRFCH.Controls.Add(this.txtChIndexBegin);
            this.gbx_InsertRFCH.Controls.Add(this.label47);
            this.gbx_InsertRFCH.Controls.Add(this.label46);
            this.gbx_InsertRFCH.Controls.Add(this.txtChIndexEnd);
            this.gbx_InsertRFCH.Controls.Add(this.btnInsertRfCh);
            this.gbx_InsertRFCH.Location = new System.Drawing.Point(9, 95);
            this.gbx_InsertRFCH.Name = "gbx_InsertRFCH";
            this.gbx_InsertRFCH.Size = new System.Drawing.Size(283, 101);
            this.gbx_InsertRFCH.TabIndex = 25;
            this.gbx_InsertRFCH.TabStop = false;
            this.gbx_InsertRFCH.Text = "Insert RFCH";
            // 
            // btnInsertRfCh_Help
            // 
            this.btnInsertRfCh_Help.Location = new System.Drawing.Point(246, 61);
            this.btnInsertRfCh_Help.Name = "btnInsertRfCh_Help";
            this.btnInsertRfCh_Help.Size = new System.Drawing.Size(17, 23);
            this.btnInsertRfCh_Help.TabIndex = 25;
            this.btnInsertRfCh_Help.Text = "?";
            this.btnInsertRfCh_Help.UseVisualStyleBackColor = true;
            this.btnInsertRfCh_Help.Click += new System.EventHandler(this.btnInsertRfCh_Help_Click);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(186, 29);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(33, 15);
            this.label47.TabIndex = 16;
            this.label47.Text = "Stop";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(104, 30);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(35, 15);
            this.label46.TabIndex = 15;
            this.label46.Text = "Start";
            // 
            // cbxFhssHopPeriod
            // 
            this.cbxFhssHopPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFhssHopPeriod.FormattingEnabled = true;
            this.cbxFhssHopPeriod.Items.AddRange(new object[] {
            "100mS",
            "200mS",
            "300mS",
            "400mS",
            "500mS",
            "600mS",
            "700mS",
            "800mS",
            "900mS",
            "1000mS",
            "1100mS",
            "1200mS",
            "1300mS",
            "1400mS",
            "1500mS",
            "1600mS",
            "1700mS",
            "1800mS",
            "1900mS",
            "2000mS",
            "2100mS",
            "2200mS",
            "2300mS",
            "2400mS",
            "2500mS"});
            this.cbxFhssHopPeriod.Location = new System.Drawing.Point(196, 245);
            this.cbxFhssHopPeriod.Name = "cbxFhssHopPeriod";
            this.cbxFhssHopPeriod.Size = new System.Drawing.Size(95, 23);
            this.cbxFhssHopPeriod.TabIndex = 20;
            // 
            // cbxFHSS
            // 
            this.cbxFHSS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFHSS.FormattingEnabled = true;
            this.cbxFHSS.Items.AddRange(new object[] {
            "FHSS OFF",
            "FHSS ON"});
            this.cbxFHSS.Location = new System.Drawing.Point(196, 204);
            this.cbxFHSS.Name = "cbxFHSS";
            this.cbxFHSS.Size = new System.Drawing.Size(95, 23);
            this.cbxFHSS.TabIndex = 19;
            // 
            // btnGetChannel
            // 
            this.btnGetChannel.Location = new System.Drawing.Point(105, 60);
            this.btnGetChannel.Name = "btnGetChannel";
            this.btnGetChannel.Size = new System.Drawing.Size(87, 29);
            this.btnGetChannel.TabIndex = 7;
            this.btnGetChannel.Text = "Get RFCH";
            this.btnGetChannel.UseVisualStyleBackColor = true;
            this.btnGetChannel.Click += new System.EventHandler(this.btnGetChannel_Click);
            // 
            // cbxChannel
            // 
            this.cbxChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChannel.FormattingEnabled = true;
            this.cbxChannel.Items.AddRange(new object[] {
            "920.125MHz",
            "920.375MHz",
            "920.625MHz",
            "920.875MHz",
            "921.125MHz",
            "921.375MHz",
            "921.625MHz",
            "921.875MHz",
            "922.125MHz",
            "922.375MHz",
            "922.625MHz",
            "922.875MHz",
            "923.125MHz",
            "923.375MHz",
            "923.625MHz",
            "923.875MHz",
            "924.125MHz",
            "924.375MHz",
            "924.625MHz",
            "924.875MHz"});
            this.cbxChannel.Location = new System.Drawing.Point(198, 63);
            this.cbxChannel.Name = "cbxChannel";
            this.cbxChannel.Size = new System.Drawing.Size(121, 23);
            this.cbxChannel.TabIndex = 4;
            // 
            // cbxRegion
            // 
            this.cbxRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRegion.FormattingEnabled = true;
            this.cbxRegion.Items.AddRange(new object[] {
            "China2 (Code=1)",
            "China1 (Code=4)",
            "US       (Code=1)",
            "Europe (Code=3)",
            "Korea   (Code=6)"});
            this.cbxRegion.Location = new System.Drawing.Point(198, 23);
            this.cbxRegion.Name = "cbxRegion";
            this.cbxRegion.Size = new System.Drawing.Size(121, 23);
            this.cbxRegion.TabIndex = 3;
            this.cbxRegion.SelectedIndexChanged += new System.EventHandler(this.cbxRegion_SelectedIndexChanged);
            // 
            // btnSetFreq
            // 
            this.btnSetFreq.Location = new System.Drawing.Point(8, 60);
            this.btnSetFreq.Name = "btnSetFreq";
            this.btnSetFreq.Size = new System.Drawing.Size(87, 29);
            this.btnSetFreq.TabIndex = 0;
            this.btnSetFreq.Text = "Set RFCH";
            this.btnSetFreq.UseVisualStyleBackColor = true;
            this.btnSetFreq.Click += new System.EventHandler(this.btnSetFreq_Click);
            // 
            // groupBox_RF_Ant
            // 
            this.groupBox_RF_Ant.Controls.Add(this.button_RF_Ant_Get);
            this.groupBox_RF_Ant.Controls.Add(this.button_RF_Ant_Set);
            this.groupBox_RF_Ant.Controls.Add(this.label_AntPort_Quantity);
            this.groupBox_RF_Ant.Controls.Add(this.groupBox_RF_Ant_Port);
            this.groupBox_RF_Ant.Controls.Add(this.comboBox_RF_AntPort_Quantity);
            this.groupBox_RF_Ant.Controls.Add(this.checkBox_RF_AntPort_AutoPolling);
            this.groupBox_RF_Ant.Location = new System.Drawing.Point(337, 20);
            this.groupBox_RF_Ant.Name = "groupBox_RF_Ant";
            this.groupBox_RF_Ant.Size = new System.Drawing.Size(392, 408);
            this.groupBox_RF_Ant.TabIndex = 0;
            this.groupBox_RF_Ant.TabStop = false;
            this.groupBox_RF_Ant.Text = "Ant Setting";
            // 
            // label_AntPort_Quantity
            // 
            this.label_AntPort_Quantity.AutoSize = true;
            this.label_AntPort_Quantity.Location = new System.Drawing.Point(22, 21);
            this.label_AntPort_Quantity.Name = "label_AntPort_Quantity";
            this.label_AntPort_Quantity.Size = new System.Drawing.Size(54, 15);
            this.label_AntPort_Quantity.TabIndex = 25;
            this.label_AntPort_Quantity.Text = "Quantity";
            // 
            // groupBox_RF_Ant_Port
            // 
            this.groupBox_RF_Ant_Port.Controls.Add(this.button_RF_Ant_GetCurrentAntPort);
            this.groupBox_RF_Ant_Port.Controls.Add(this.groupBox_RF_Ant_Enable);
            this.groupBox_RF_Ant_Port.Controls.Add(this.groupBox_RF_Ant_SwitchAnt);
            this.groupBox_RF_Ant_Port.Controls.Add(this.label_RF_AntPort_InvCnter);
            this.groupBox_RF_Ant_Port.Controls.Add(this.label_RF_AntPort_Power);
            this.groupBox_RF_Ant_Port.Controls.Add(this.textBox_RF_AntPort_InvCnter8);
            this.groupBox_RF_Ant_Port.Controls.Add(this.comboBoxRF_AntPort_Port8);
            this.groupBox_RF_Ant_Port.Controls.Add(this.textBox_RF_AntPort_InvCnter7);
            this.groupBox_RF_Ant_Port.Controls.Add(this.comboBoxRF_AntPort_Port7);
            this.groupBox_RF_Ant_Port.Controls.Add(this.textBox_RF_AntPort_InvCnter6);
            this.groupBox_RF_Ant_Port.Controls.Add(this.comboBoxRF_AntPort_Port6);
            this.groupBox_RF_Ant_Port.Controls.Add(this.textBox_RF_AntPort_InvCnter5);
            this.groupBox_RF_Ant_Port.Controls.Add(this.comboBoxRF_AntPort_Port5);
            this.groupBox_RF_Ant_Port.Controls.Add(this.textBox_RF_AntPort_InvCnter4);
            this.groupBox_RF_Ant_Port.Controls.Add(this.comboBoxRF_AntPort_Port4);
            this.groupBox_RF_Ant_Port.Controls.Add(this.textBox_RF_AntPort_InvCnter3);
            this.groupBox_RF_Ant_Port.Controls.Add(this.comboBoxRF_AntPort_Port3);
            this.groupBox_RF_Ant_Port.Controls.Add(this.textBox_RF_AntPort_InvCnter2);
            this.groupBox_RF_Ant_Port.Controls.Add(this.comboBoxRF_AntPort_Port2);
            this.groupBox_RF_Ant_Port.Controls.Add(this.textBox_RF_AntPort_InvCnter1);
            this.groupBox_RF_Ant_Port.Controls.Add(this.comboBoxRF_AntPort_Port1);
            this.groupBox_RF_Ant_Port.Location = new System.Drawing.Point(6, 46);
            this.groupBox_RF_Ant_Port.Name = "groupBox_RF_Ant_Port";
            this.groupBox_RF_Ant_Port.Size = new System.Drawing.Size(376, 304);
            this.groupBox_RF_Ant_Port.TabIndex = 0;
            this.groupBox_RF_Ant_Port.TabStop = false;
            this.groupBox_RF_Ant_Port.Text = "Port";
            // 
            // groupBox_RF_Ant_Enable
            // 
            this.groupBox_RF_Ant_Enable.Controls.Add(this.checkBox_RF_Ant_Enable8);
            this.groupBox_RF_Ant_Enable.Controls.Add(this.checkBox_RF_Ant_Enable7);
            this.groupBox_RF_Ant_Enable.Controls.Add(this.checkBox_RF_Ant_Enable6);
            this.groupBox_RF_Ant_Enable.Controls.Add(this.checkBox_RF_Ant_Enable5);
            this.groupBox_RF_Ant_Enable.Controls.Add(this.checkBox_RF_Ant_Enable4);
            this.groupBox_RF_Ant_Enable.Controls.Add(this.checkBox_RF_Ant_Enable3);
            this.groupBox_RF_Ant_Enable.Controls.Add(this.checkBox_RF_Ant_Enable2);
            this.groupBox_RF_Ant_Enable.Controls.Add(this.checkBox_RF_Ant_Enable1);
            this.groupBox_RF_Ant_Enable.Location = new System.Drawing.Point(8, 21);
            this.groupBox_RF_Ant_Enable.Name = "groupBox_RF_Ant_Enable";
            this.groupBox_RF_Ant_Enable.Size = new System.Drawing.Size(80, 238);
            this.groupBox_RF_Ant_Enable.TabIndex = 27;
            this.groupBox_RF_Ant_Enable.TabStop = false;
            this.groupBox_RF_Ant_Enable.Text = "Enable";
            // 
            // groupBox_RF_Ant_SwitchAnt
            // 
            this.groupBox_RF_Ant_SwitchAnt.Controls.Add(this.radioButton_AntPort7);
            this.groupBox_RF_Ant_SwitchAnt.Controls.Add(this.radioButton_AntPort6);
            this.groupBox_RF_Ant_SwitchAnt.Controls.Add(this.radioButton_AntPort5);
            this.groupBox_RF_Ant_SwitchAnt.Controls.Add(this.radioButton_AntPort4);
            this.groupBox_RF_Ant_SwitchAnt.Controls.Add(this.radioButton_AntPort3);
            this.groupBox_RF_Ant_SwitchAnt.Controls.Add(this.radioButton_AntPort2);
            this.groupBox_RF_Ant_SwitchAnt.Controls.Add(this.radioButton_AntPort1);
            this.groupBox_RF_Ant_SwitchAnt.Controls.Add(this.radioButton_AntPort8);
            this.groupBox_RF_Ant_SwitchAnt.Location = new System.Drawing.Point(94, 21);
            this.groupBox_RF_Ant_SwitchAnt.Name = "groupBox_RF_Ant_SwitchAnt";
            this.groupBox_RF_Ant_SwitchAnt.Size = new System.Drawing.Size(85, 238);
            this.groupBox_RF_Ant_SwitchAnt.TabIndex = 26;
            this.groupBox_RF_Ant_SwitchAnt.TabStop = false;
            this.groupBox_RF_Ant_SwitchAnt.Text = "Switch";
            // 
            // label_RF_AntPort_InvCnter
            // 
            this.label_RF_AntPort_InvCnter.AutoSize = true;
            this.label_RF_AntPort_InvCnter.Location = new System.Drawing.Point(275, 21);
            this.label_RF_AntPort_InvCnter.Name = "label_RF_AntPort_InvCnter";
            this.label_RF_AntPort_InvCnter.Size = new System.Drawing.Size(95, 15);
            this.label_RF_AntPort_InvCnter.TabIndex = 25;
            this.label_RF_AntPort_InvCnter.Text = "Inventory Count";
            // 
            // label_RF_AntPort_Power
            // 
            this.label_RF_AntPort_Power.AutoSize = true;
            this.label_RF_AntPort_Power.Location = new System.Drawing.Point(194, 21);
            this.label_RF_AntPort_Power.Name = "label_RF_AntPort_Power";
            this.label_RF_AntPort_Power.Size = new System.Drawing.Size(44, 15);
            this.label_RF_AntPort_Power.TabIndex = 24;
            this.label_RF_AntPort_Power.Text = "Power";
            // 
            // tabPageAccessTag
            // 
            this.tabPageAccessTag.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAccessTag.Controls.Add(this.label_Acess1);
            this.tabPageAccessTag.Controls.Add(this.gbxStatus2);
            this.tabPageAccessTag.Controls.Add(this.inv_mode);
            this.tabPageAccessTag.Controls.Add(this.gbxKill);
            this.tabPageAccessTag.Controls.Add(this.gBxLock);
            this.tabPageAccessTag.Controls.Add(this.gbxSelect);
            this.tabPageAccessTag.Controls.Add(this.gbx_comcnt_adv);
            this.tabPageAccessTag.Controls.Add(this.gbxAccess);
            this.tabPageAccessTag.Controls.Add(this.btnInvtAdv);
            this.tabPageAccessTag.Controls.Add(this.gbxEpcTableAdv);
            this.tabPageAccessTag.Controls.Add(this.gbxSetQuery);
            this.tabPageAccessTag.Location = new System.Drawing.Point(4, 24);
            this.tabPageAccessTag.Name = "tabPageAccessTag";
            this.tabPageAccessTag.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAccessTag.Size = new System.Drawing.Size(1067, 619);
            this.tabPageAccessTag.TabIndex = 1;
            this.tabPageAccessTag.Text = "Access Tag Memory";
            // 
            // label_Acess1
            // 
            this.label_Acess1.AutoSize = true;
            this.label_Acess1.ForeColor = System.Drawing.Color.Red;
            this.label_Acess1.Location = new System.Drawing.Point(230, 553);
            this.label_Acess1.Name = "label_Acess1";
            this.label_Acess1.Size = new System.Drawing.Size(171, 15);
            this.label_Acess1.TabIndex = 80;
            this.label_Acess1.Text = "Step1: Search EPC ID of Tags";
            // 
            // gbxStatus2
            // 
            this.gbxStatus2.Controls.Add(this.rtbxStatus);
            this.gbxStatus2.Controls.Add(this.txtOperateEpc);
            this.gbxStatus2.Controls.Add(this.label27);
            this.gbxStatus2.Controls.Add(this.labelStatus);
            this.gbxStatus2.Location = new System.Drawing.Point(539, 549);
            this.gbxStatus2.Name = "gbxStatus2";
            this.gbxStatus2.Size = new System.Drawing.Size(520, 67);
            this.gbxStatus2.TabIndex = 79;
            this.gbxStatus2.TabStop = false;
            // 
            // rtbxStatus
            // 
            this.rtbxStatus.BackColor = System.Drawing.SystemColors.Control;
            this.rtbxStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbxStatus.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbxStatus.Location = new System.Drawing.Point(76, 44);
            this.rtbxStatus.Name = "rtbxStatus";
            this.rtbxStatus.Size = new System.Drawing.Size(433, 21);
            this.rtbxStatus.TabIndex = 79;
            this.rtbxStatus.Text = "";
            // 
            // txtOperateEpc
            // 
            this.txtOperateEpc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtOperateEpc.Location = new System.Drawing.Point(74, 16);
            this.txtOperateEpc.Name = "txtOperateEpc";
            this.txtOperateEpc.ReadOnly = true;
            this.txtOperateEpc.Size = new System.Drawing.Size(435, 21);
            this.txtOperateEpc.TabIndex = 78;
            this.txtOperateEpc.DoubleClick += new System.EventHandler(this.txtOperateEpc_DoubleClick);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(9, 20);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(56, 15);
            this.label27.TabIndex = 77;
            this.label27.Text = "PC+EPC:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(9, 46);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(47, 15);
            this.labelStatus.TabIndex = 77;
            this.labelStatus.Text = "Status:";
            // 
            // inv_mode
            // 
            this.inv_mode.AutoSize = true;
            this.inv_mode.Location = new System.Drawing.Point(432, 549);
            this.inv_mode.Name = "inv_mode";
            this.inv_mode.Size = new System.Drawing.Size(62, 19);
            this.inv_mode.TabIndex = 48;
            this.inv_mode.Text = "Select";
            this.inv_mode.UseVisualStyleBackColor = true;
            this.inv_mode.CheckedChanged += new System.EventHandler(this.inv_mode_CheckedChanged);
            // 
            // gbxKill
            // 
            this.gbxKill.Controls.Add(this.labelKillRFU);
            this.gbxKill.Controls.Add(this.textBoxKillRFU);
            this.gbxKill.Controls.Add(this.label44);
            this.gbxKill.Controls.Add(this.textBoxKillPwd);
            this.gbxKill.Controls.Add(this.buttonKill);
            this.gbxKill.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxKill.Location = new System.Drawing.Point(539, 504);
            this.gbxKill.Name = "gbxKill";
            this.gbxKill.Size = new System.Drawing.Size(518, 46);
            this.gbxKill.TabIndex = 69;
            this.gbxKill.TabStop = false;
            this.gbxKill.Text = "Kill";
            // 
            // labelKillRFU
            // 
            this.labelKillRFU.AutoSize = true;
            this.labelKillRFU.Location = new System.Drawing.Point(265, 19);
            this.labelKillRFU.Name = "labelKillRFU";
            this.labelKillRFU.Size = new System.Drawing.Size(68, 15);
            this.labelKillRFU.TabIndex = 62;
            this.labelKillRFU.Text = "RFU(3 bits)";
            // 
            // textBoxKillRFU
            // 
            this.textBoxKillRFU.Location = new System.Drawing.Point(343, 16);
            this.textBoxKillRFU.Name = "textBoxKillRFU";
            this.textBoxKillRFU.Size = new System.Drawing.Size(42, 21);
            this.textBoxKillRFU.TabIndex = 61;
            this.textBoxKillRFU.Text = "000";
            this.textBoxKillRFU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(13, 18);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(118, 15);
            this.label44.TabIndex = 60;
            this.label44.Text = "Kill Password (HEX)";
            // 
            // textBoxKillPwd
            // 
            this.textBoxKillPwd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxKillPwd.Font = new System.Drawing.Font("Arial", 9F);
            this.textBoxKillPwd.Location = new System.Drawing.Point(149, 16);
            this.textBoxKillPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKillPwd.Name = "textBoxKillPwd";
            this.textBoxKillPwd.Size = new System.Drawing.Size(81, 21);
            this.textBoxKillPwd.TabIndex = 59;
            this.textBoxKillPwd.Text = "00 00 00 00";
            this.textBoxKillPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonKill
            // 
            this.buttonKill.Location = new System.Drawing.Point(408, 11);
            this.buttonKill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonKill.Name = "buttonKill";
            this.buttonKill.Size = new System.Drawing.Size(101, 30);
            this.buttonKill.TabIndex = 52;
            this.buttonKill.Text = "Kill";
            this.buttonKill.UseVisualStyleBackColor = true;
            this.buttonKill.Click += new System.EventHandler(this.buttonKill_Click);
            // 
            // gBxLock
            // 
            this.gBxLock.Controls.Add(this.cbxLockUserAction);
            this.gBxLock.Controls.Add(this.cbxLockTIDAction);
            this.gBxLock.Controls.Add(this.cbxLockEPCAction);
            this.gBxLock.Controls.Add(this.cbxLockAccessAction);
            this.gBxLock.Controls.Add(this.cbxLockKillAction);
            this.gBxLock.Controls.Add(this.checkBoxUser);
            this.gBxLock.Controls.Add(this.checkBoxTID);
            this.gBxLock.Controls.Add(this.checkBoxEPC);
            this.gBxLock.Controls.Add(this.checkBoxAccessPwd);
            this.gBxLock.Controls.Add(this.checkBoxKillPwd);
            this.gBxLock.Controls.Add(this.buttonLock);
            this.gBxLock.Controls.Add(this.label42);
            this.gBxLock.Controls.Add(this.textBoxLockAccessPwd);
            this.gBxLock.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxLock.Location = new System.Drawing.Point(539, 389);
            this.gBxLock.Name = "gBxLock";
            this.gBxLock.Size = new System.Drawing.Size(521, 115);
            this.gBxLock.TabIndex = 68;
            this.gBxLock.TabStop = false;
            this.gBxLock.Text = "Lock";
            // 
            // cbxLockUserAction
            // 
            this.cbxLockUserAction.DisplayMember = "2";
            this.cbxLockUserAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLockUserAction.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLockUserAction.FormattingEnabled = true;
            this.cbxLockUserAction.Items.AddRange(new object[] {
            "Open",
            "PWD Lock",
            "Perma Open",
            "Perma Lock"});
            this.cbxLockUserAction.Location = new System.Drawing.Point(271, 83);
            this.cbxLockUserAction.Name = "cbxLockUserAction";
            this.cbxLockUserAction.Size = new System.Drawing.Size(99, 23);
            this.cbxLockUserAction.TabIndex = 36;
            this.cbxLockUserAction.Tag = "";
            // 
            // cbxLockTIDAction
            // 
            this.cbxLockTIDAction.DisplayMember = "2";
            this.cbxLockTIDAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLockTIDAction.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLockTIDAction.FormattingEnabled = true;
            this.cbxLockTIDAction.Items.AddRange(new object[] {
            "Open",
            "PWD Lock",
            "Perma Open",
            "Perma Lock"});
            this.cbxLockTIDAction.Location = new System.Drawing.Point(80, 85);
            this.cbxLockTIDAction.Name = "cbxLockTIDAction";
            this.cbxLockTIDAction.Size = new System.Drawing.Size(98, 23);
            this.cbxLockTIDAction.TabIndex = 36;
            this.cbxLockTIDAction.Tag = "";
            // 
            // cbxLockEPCAction
            // 
            this.cbxLockEPCAction.DisplayMember = "2";
            this.cbxLockEPCAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLockEPCAction.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLockEPCAction.FormattingEnabled = true;
            this.cbxLockEPCAction.Items.AddRange(new object[] {
            "Open",
            "PWD Lock",
            "Perma Open",
            "Perma Lock"});
            this.cbxLockEPCAction.Location = new System.Drawing.Point(423, 53);
            this.cbxLockEPCAction.Name = "cbxLockEPCAction";
            this.cbxLockEPCAction.Size = new System.Drawing.Size(91, 23);
            this.cbxLockEPCAction.TabIndex = 36;
            this.cbxLockEPCAction.Tag = "";
            // 
            // cbxLockAccessAction
            // 
            this.cbxLockAccessAction.DisplayMember = "2";
            this.cbxLockAccessAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLockAccessAction.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLockAccessAction.FormattingEnabled = true;
            this.cbxLockAccessAction.Items.AddRange(new object[] {
            "Open",
            "PWD R/W",
            "Perma Open",
            "Perma NOT R/W"});
            this.cbxLockAccessAction.Location = new System.Drawing.Point(272, 54);
            this.cbxLockAccessAction.Name = "cbxLockAccessAction";
            this.cbxLockAccessAction.Size = new System.Drawing.Size(98, 23);
            this.cbxLockAccessAction.TabIndex = 36;
            this.cbxLockAccessAction.Tag = "";
            // 
            // cbxLockKillAction
            // 
            this.cbxLockKillAction.DisplayMember = "2";
            this.cbxLockKillAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLockKillAction.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLockKillAction.FormattingEnabled = true;
            this.cbxLockKillAction.Items.AddRange(new object[] {
            "Open",
            "PWD R/W",
            "Perma Open",
            "Perma NOT R/W"});
            this.cbxLockKillAction.Location = new System.Drawing.Point(79, 53);
            this.cbxLockKillAction.Name = "cbxLockKillAction";
            this.cbxLockKillAction.Size = new System.Drawing.Size(99, 23);
            this.cbxLockKillAction.TabIndex = 36;
            this.cbxLockKillAction.Tag = "";
            // 
            // checkBoxUser
            // 
            this.checkBoxUser.AutoSize = true;
            this.checkBoxUser.Location = new System.Drawing.Point(183, 85);
            this.checkBoxUser.Name = "checkBoxUser";
            this.checkBoxUser.Size = new System.Drawing.Size(53, 19);
            this.checkBoxUser.TabIndex = 86;
            this.checkBoxUser.Text = "User";
            this.checkBoxUser.UseVisualStyleBackColor = true;
            // 
            // checkBoxTID
            // 
            this.checkBoxTID.AutoSize = true;
            this.checkBoxTID.Location = new System.Drawing.Point(11, 85);
            this.checkBoxTID.Name = "checkBoxTID";
            this.checkBoxTID.Size = new System.Drawing.Size(44, 19);
            this.checkBoxTID.TabIndex = 86;
            this.checkBoxTID.Text = "TID";
            this.checkBoxTID.UseVisualStyleBackColor = true;
            // 
            // checkBoxEPC
            // 
            this.checkBoxEPC.AutoSize = true;
            this.checkBoxEPC.Location = new System.Drawing.Point(376, 56);
            this.checkBoxEPC.Name = "checkBoxEPC";
            this.checkBoxEPC.Size = new System.Drawing.Size(49, 19);
            this.checkBoxEPC.TabIndex = 86;
            this.checkBoxEPC.Text = "EPC";
            this.checkBoxEPC.UseVisualStyleBackColor = true;
            // 
            // checkBoxAccessPwd
            // 
            this.checkBoxAccessPwd.AutoSize = true;
            this.checkBoxAccessPwd.Location = new System.Drawing.Point(183, 55);
            this.checkBoxAccessPwd.Name = "checkBoxAccessPwd";
            this.checkBoxAccessPwd.Size = new System.Drawing.Size(97, 19);
            this.checkBoxAccessPwd.TabIndex = 86;
            this.checkBoxAccessPwd.Text = "Access Pwd";
            this.checkBoxAccessPwd.UseVisualStyleBackColor = true;
            // 
            // checkBoxKillPwd
            // 
            this.checkBoxKillPwd.AutoSize = true;
            this.checkBoxKillPwd.Location = new System.Drawing.Point(11, 56);
            this.checkBoxKillPwd.Name = "checkBoxKillPwd";
            this.checkBoxKillPwd.Size = new System.Drawing.Size(71, 19);
            this.checkBoxKillPwd.TabIndex = 86;
            this.checkBoxKillPwd.Text = "Kill Pwd";
            this.checkBoxKillPwd.UseVisualStyleBackColor = true;
            // 
            // buttonLock
            // 
            this.buttonLock.Location = new System.Drawing.Point(272, 15);
            this.buttonLock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLock.Name = "buttonLock";
            this.buttonLock.Size = new System.Drawing.Size(101, 30);
            this.buttonLock.TabIndex = 51;
            this.buttonLock.Text = "Lock";
            this.buttonLock.UseVisualStyleBackColor = true;
            this.buttonLock.Click += new System.EventHandler(this.buttonLock_Click);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(7, 24);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(141, 15);
            this.label42.TabIndex = 58;
            this.label42.Text = "Access Password (HEX)";
            // 
            // textBoxLockAccessPwd
            // 
            this.textBoxLockAccessPwd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxLockAccessPwd.Font = new System.Drawing.Font("Arial", 9F);
            this.textBoxLockAccessPwd.Location = new System.Drawing.Point(153, 19);
            this.textBoxLockAccessPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLockAccessPwd.Name = "textBoxLockAccessPwd";
            this.textBoxLockAccessPwd.Size = new System.Drawing.Size(80, 21);
            this.textBoxLockAccessPwd.TabIndex = 57;
            this.textBoxLockAccessPwd.Text = "00 00 00 00";
            this.textBoxLockAccessPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbxSelect
            // 
            this.gbxSelect.BackColor = System.Drawing.SystemColors.Control;
            this.gbxSelect.Controls.Add(this.label_Access3);
            this.gbxSelect.Controls.Add(this.label34);
            this.gbxSelect.Controls.Add(this.label35);
            this.gbxSelect.Controls.Add(this.txtGetSelLength);
            this.gbxSelect.Controls.Add(this.txtGetSelMask);
            this.gbxSelect.Controls.Add(this.btnGetSelect);
            this.gbxSelect.Controls.Add(this.label33);
            this.gbxSelect.Controls.Add(this.txtSelMask);
            this.gbxSelect.Controls.Add(this.ckxTruncated);
            this.gbxSelect.Controls.Add(this.label32);
            this.gbxSelect.Controls.Add(this.txtSelLength);
            this.gbxSelect.Controls.Add(this.label31);
            this.gbxSelect.Controls.Add(this.txtSelPrt0);
            this.gbxSelect.Controls.Add(this.label30);
            this.gbxSelect.Controls.Add(this.txtSelPrt2);
            this.gbxSelect.Controls.Add(this.label29);
            this.gbxSelect.Controls.Add(this.txtSelPrt1);
            this.gbxSelect.Controls.Add(this.txtSelPrt3);
            this.gbxSelect.Controls.Add(this.label28);
            this.gbxSelect.Controls.Add(this.cbxSelMemBank);
            this.gbxSelect.Controls.Add(this.cbxAction);
            this.gbxSelect.Controls.Add(this.cbxSelTarget);
            this.gbxSelect.Controls.Add(this.btnSetSelect);
            this.gbxSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbxSelect.Location = new System.Drawing.Point(539, 92);
            this.gbxSelect.Name = "gbxSelect";
            this.gbxSelect.Size = new System.Drawing.Size(521, 158);
            this.gbxSelect.TabIndex = 27;
            this.gbxSelect.TabStop = false;
            this.gbxSelect.Text = "Select Parameter";
            // 
            // label_Access3
            // 
            this.label_Access3.AutoSize = true;
            this.label_Access3.ForeColor = System.Drawing.Color.Red;
            this.label_Access3.Location = new System.Drawing.Point(9, 64);
            this.label_Access3.Name = "label_Access3";
            this.label_Access3.Size = new System.Drawing.Size(105, 15);
            this.label_Access3.TabIndex = 82;
            this.label_Access3.Text = "Step3: Select Tag";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(263, 109);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(38, 15);
            this.label34.TabIndex = 47;
            this.label34.Text = "Mask";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(97, 109);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(46, 15);
            this.label35.TabIndex = 46;
            this.label35.Text = "Length";
            // 
            // txtGetSelLength
            // 
            this.txtGetSelLength.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGetSelLength.Location = new System.Drawing.Point(97, 127);
            this.txtGetSelLength.Name = "txtGetSelLength";
            this.txtGetSelLength.ReadOnly = true;
            this.txtGetSelLength.Size = new System.Drawing.Size(40, 21);
            this.txtGetSelLength.TabIndex = 45;
            this.txtGetSelLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGetSelMask
            // 
            this.txtGetSelMask.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGetSelMask.Location = new System.Drawing.Point(148, 127);
            this.txtGetSelMask.Name = "txtGetSelMask";
            this.txtGetSelMask.ReadOnly = true;
            this.txtGetSelMask.Size = new System.Drawing.Size(290, 21);
            this.txtGetSelMask.TabIndex = 35;
            this.txtGetSelMask.DoubleClick += new System.EventHandler(this.txtGetSelMask_DoubleClick);
            // 
            // btnGetSelect
            // 
            this.btnGetSelect.Location = new System.Drawing.Point(11, 123);
            this.btnGetSelect.Name = "btnGetSelect";
            this.btnGetSelect.Size = new System.Drawing.Size(75, 29);
            this.btnGetSelect.TabIndex = 44;
            this.btnGetSelect.Text = "Get Select";
            this.btnGetSelect.UseVisualStyleBackColor = true;
            this.btnGetSelect.Click += new System.EventHandler(this.btnGetSelect_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(265, 64);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(38, 15);
            this.label33.TabIndex = 43;
            this.label33.Text = "Mask";
            // 
            // txtSelMask
            // 
            this.txtSelMask.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSelMask.Location = new System.Drawing.Point(148, 82);
            this.txtSelMask.Name = "txtSelMask";
            this.txtSelMask.Size = new System.Drawing.Size(290, 21);
            this.txtSelMask.TabIndex = 35;
            this.txtSelMask.Text = "00 00 00 00 00 00 00 00 00 00 00 00";
            this.txtSelMask.DoubleClick += new System.EventHandler(this.txtSelMask_DoubleClick);
            // 
            // ckxTruncated
            // 
            this.ckxTruncated.AutoSize = true;
            this.ckxTruncated.Enabled = false;
            this.ckxTruncated.Location = new System.Drawing.Point(443, 83);
            this.ckxTruncated.Name = "ckxTruncated";
            this.ckxTruncated.Size = new System.Drawing.Size(76, 19);
            this.ckxTruncated.TabIndex = 42;
            this.ckxTruncated.Text = "Truncate";
            this.ckxTruncated.UseVisualStyleBackColor = true;
            this.ckxTruncated.Visible = false;
            this.ckxTruncated.CheckedChanged += new System.EventHandler(this.ckxTruncated_CheckedChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(94, 64);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(46, 15);
            this.label32.TabIndex = 41;
            this.label32.Text = "Length";
            // 
            // txtSelLength
            // 
            this.txtSelLength.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSelLength.Location = new System.Drawing.Point(97, 82);
            this.txtSelLength.Name = "txtSelLength";
            this.txtSelLength.Size = new System.Drawing.Size(40, 21);
            this.txtSelLength.TabIndex = 40;
            this.txtSelLength.Text = "60";
            this.txtSelLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(360, 17);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(48, 15);
            this.label31.TabIndex = 39;
            this.label31.Text = "Pointer";
            // 
            // txtSelPrt0
            // 
            this.txtSelPrt0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSelPrt0.Location = new System.Drawing.Point(432, 36);
            this.txtSelPrt0.Name = "txtSelPrt0";
            this.txtSelPrt0.Size = new System.Drawing.Size(40, 21);
            this.txtSelPrt0.TabIndex = 38;
            this.txtSelPrt0.Text = "20";
            this.txtSelPrt0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(109, 17);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(43, 15);
            this.label30.TabIndex = 38;
            this.label30.Text = "Target";
            // 
            // txtSelPrt2
            // 
            this.txtSelPrt2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSelPrt2.Location = new System.Drawing.Point(346, 36);
            this.txtSelPrt2.Name = "txtSelPrt2";
            this.txtSelPrt2.Size = new System.Drawing.Size(40, 21);
            this.txtSelPrt2.TabIndex = 37;
            this.txtSelPrt2.Text = "00";
            this.txtSelPrt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(177, 17);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(43, 15);
            this.label29.TabIndex = 37;
            this.label29.Text = "Action";
            // 
            // txtSelPrt1
            // 
            this.txtSelPrt1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSelPrt1.Location = new System.Drawing.Point(389, 36);
            this.txtSelPrt1.Name = "txtSelPrt1";
            this.txtSelPrt1.Size = new System.Drawing.Size(40, 21);
            this.txtSelPrt1.TabIndex = 36;
            this.txtSelPrt1.Text = "00";
            this.txtSelPrt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSelPrt3
            // 
            this.txtSelPrt3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSelPrt3.Location = new System.Drawing.Point(303, 36);
            this.txtSelPrt3.Name = "txtSelPrt3";
            this.txtSelPrt3.Size = new System.Drawing.Size(40, 21);
            this.txtSelPrt3.TabIndex = 35;
            this.txtSelPrt3.Text = "00";
            this.txtSelPrt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(226, 17);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(64, 15);
            this.label28.TabIndex = 35;
            this.label28.Text = "MemBank";
            // 
            // cbxSelMemBank
            // 
            this.cbxSelMemBank.DisplayMember = "2";
            this.cbxSelMemBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelMemBank.FormattingEnabled = true;
            this.cbxSelMemBank.Items.AddRange(new object[] {
            "RFU",
            "EPC",
            "TID",
            "User"});
            this.cbxSelMemBank.Location = new System.Drawing.Point(229, 35);
            this.cbxSelMemBank.Name = "cbxSelMemBank";
            this.cbxSelMemBank.Size = new System.Drawing.Size(59, 23);
            this.cbxSelMemBank.TabIndex = 35;
            this.cbxSelMemBank.Tag = "";
            // 
            // cbxAction
            // 
            this.cbxAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAction.FormattingEnabled = true;
            this.cbxAction.Items.AddRange(new object[] {
            "000",
            "001",
            "010",
            "011",
            "100",
            "101",
            "110",
            "111"});
            this.cbxAction.Location = new System.Drawing.Point(173, 35);
            this.cbxAction.Name = "cbxAction";
            this.cbxAction.Size = new System.Drawing.Size(48, 23);
            this.cbxAction.TabIndex = 36;
            // 
            // cbxSelTarget
            // 
            this.cbxSelTarget.DisplayMember = "2";
            this.cbxSelTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelTarget.FormattingEnabled = true;
            this.cbxSelTarget.Items.AddRange(new object[] {
            "S0(000)",
            "S1(001)",
            "S2(010)",
            "S3(011)",
            "SL(100)",
            "RFU(101)",
            "RFU(110)",
            "RFU(111)"});
            this.cbxSelTarget.Location = new System.Drawing.Point(96, 35);
            this.cbxSelTarget.Name = "cbxSelTarget";
            this.cbxSelTarget.Size = new System.Drawing.Size(69, 23);
            this.cbxSelTarget.TabIndex = 35;
            this.cbxSelTarget.Tag = "";
            // 
            // btnSetSelect
            // 
            this.btnSetSelect.Location = new System.Drawing.Point(11, 31);
            this.btnSetSelect.Name = "btnSetSelect";
            this.btnSetSelect.Size = new System.Drawing.Size(75, 29);
            this.btnSetSelect.TabIndex = 35;
            this.btnSetSelect.Text = "Set Select";
            this.btnSetSelect.UseVisualStyleBackColor = true;
            this.btnSetSelect.Click += new System.EventHandler(this.btnSetSelect_Click);
            // 
            // gbx_comcnt_adv
            // 
            this.gbx_comcnt_adv.Controls.Add(this.btnClearCntAdv);
            this.gbx_comcnt_adv.Controls.Add(this.label18);
            this.gbx_comcnt_adv.Controls.Add(this.txtCOMRxCnt_adv);
            this.gbx_comcnt_adv.Controls.Add(this.label19);
            this.gbx_comcnt_adv.Controls.Add(this.txtCOMTxCnt_adv);
            this.gbx_comcnt_adv.Location = new System.Drawing.Point(3, 576);
            this.gbx_comcnt_adv.Name = "gbx_comcnt_adv";
            this.gbx_comcnt_adv.Size = new System.Drawing.Size(530, 39);
            this.gbx_comcnt_adv.TabIndex = 26;
            this.gbx_comcnt_adv.TabStop = false;
            // 
            // btnClearCntAdv
            // 
            this.btnClearCntAdv.Location = new System.Drawing.Point(6, 8);
            this.btnClearCntAdv.Name = "btnClearCntAdv";
            this.btnClearCntAdv.Size = new System.Drawing.Size(87, 29);
            this.btnClearCntAdv.TabIndex = 5;
            this.btnClearCntAdv.Text = "Reset";
            this.btnClearCntAdv.UseVisualStyleBackColor = true;
            this.btnClearCntAdv.Click += new System.EventHandler(this.btn_clear_cnt_adv_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(227, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 15);
            this.label18.TabIndex = 24;
            this.label18.Text = "TX:";
            // 
            // txtCOMRxCnt_adv
            // 
            this.txtCOMRxCnt_adv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCOMRxCnt_adv.Location = new System.Drawing.Point(133, 15);
            this.txtCOMRxCnt_adv.Name = "txtCOMRxCnt_adv";
            this.txtCOMRxCnt_adv.ReadOnly = true;
            this.txtCOMRxCnt_adv.Size = new System.Drawing.Size(88, 14);
            this.txtCOMRxCnt_adv.TabIndex = 21;
            this.txtCOMRxCnt_adv.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(101, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 15);
            this.label19.TabIndex = 22;
            this.label19.Text = "RX:";
            // 
            // txtCOMTxCnt_adv
            // 
            this.txtCOMTxCnt_adv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCOMTxCnt_adv.Location = new System.Drawing.Point(257, 16);
            this.txtCOMTxCnt_adv.Name = "txtCOMTxCnt_adv";
            this.txtCOMTxCnt_adv.ReadOnly = true;
            this.txtCOMTxCnt_adv.Size = new System.Drawing.Size(88, 14);
            this.txtCOMTxCnt_adv.TabIndex = 23;
            this.txtCOMTxCnt_adv.Text = "0";
            // 
            // gbxAccess
            // 
            this.gbxAccess.Controls.Add(this.label_Access4);
            this.gbxAccess.Controls.Add(this.label5);
            this.gbxAccess.Controls.Add(this.txtWordCnt0);
            this.gbxAccess.Controls.Add(this.txtWordPtr0);
            this.gbxAccess.Controls.Add(this.label26);
            this.gbxAccess.Controls.Add(this.label25);
            this.gbxAccess.Controls.Add(this.txtRwAccPassWord);
            this.gbxAccess.Controls.Add(this.txtInvtRWData);
            this.gbxAccess.Controls.Add(this.btnInvtWrtie);
            this.gbxAccess.Controls.Add(this.label22);
            this.gbxAccess.Controls.Add(this.label21);
            this.gbxAccess.Controls.Add(this.label20);
            this.gbxAccess.Controls.Add(this.cbxMemBank);
            this.gbxAccess.Controls.Add(this.txtWordCnt1);
            this.gbxAccess.Controls.Add(this.txtWordPtr1);
            this.gbxAccess.Controls.Add(this.btn_invtread);
            this.gbxAccess.Location = new System.Drawing.Point(539, 253);
            this.gbxAccess.Name = "gbxAccess";
            this.gbxAccess.Size = new System.Drawing.Size(521, 132);
            this.gbxAccess.TabIndex = 23;
            this.gbxAccess.TabStop = false;
            this.gbxAccess.Text = "Read / Write Tag Memory";
            // 
            // label_Access4
            // 
            this.label_Access4.AutoSize = true;
            this.label_Access4.ForeColor = System.Drawing.Color.Red;
            this.label_Access4.Location = new System.Drawing.Point(191, 118);
            this.label_Access4.Name = "label_Access4";
            this.label_Access4.Size = new System.Drawing.Size(237, 15);
            this.label_Access4.TabIndex = 83;
            this.label_Access4.Text = "Step4: Access Tag (Read/Write/Lock/Kill)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "(Max Length is 32 Words)";
            // 
            // txtWordCnt0
            // 
            this.txtWordCnt0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtWordCnt0.Location = new System.Drawing.Point(229, 40);
            this.txtWordCnt0.Name = "txtWordCnt0";
            this.txtWordCnt0.Size = new System.Drawing.Size(40, 21);
            this.txtWordCnt0.TabIndex = 34;
            this.txtWordCnt0.Text = "08";
            this.txtWordCnt0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWordPtr0
            // 
            this.txtWordPtr0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtWordPtr0.Location = new System.Drawing.Point(138, 40);
            this.txtWordPtr0.Name = "txtWordPtr0";
            this.txtWordPtr0.Size = new System.Drawing.Size(40, 21);
            this.txtWordPtr0.TabIndex = 33;
            this.txtWordPtr0.Text = "00";
            this.txtWordPtr0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(289, 22);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(111, 15);
            this.label26.TabIndex = 28;
            this.label26.Text = "Access Password";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(49, 69);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(36, 15);
            this.label25.TabIndex = 12;
            this.label25.Text = "Data:";
            // 
            // txtRwAccPassWord
            // 
            this.txtRwAccPassWord.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRwAccPassWord.Location = new System.Drawing.Point(292, 40);
            this.txtRwAccPassWord.Name = "txtRwAccPassWord";
            this.txtRwAccPassWord.Size = new System.Drawing.Size(97, 21);
            this.txtRwAccPassWord.TabIndex = 27;
            this.txtRwAccPassWord.Text = "00 00 00 00";
            this.txtRwAccPassWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInvtRWData
            // 
            this.txtInvtRWData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInvtRWData.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvtRWData.Location = new System.Drawing.Point(96, 69);
            this.txtInvtRWData.Name = "txtInvtRWData";
            this.txtInvtRWData.Size = new System.Drawing.Size(415, 19);
            this.txtInvtRWData.TabIndex = 10;
            this.txtInvtRWData.DoubleClick += new System.EventHandler(this.txtInvtReadData_DoubleClick);
            // 
            // btnInvtWrtie
            // 
            this.btnInvtWrtie.Location = new System.Drawing.Point(107, 95);
            this.btnInvtWrtie.Name = "btnInvtWrtie";
            this.btnInvtWrtie.Size = new System.Drawing.Size(75, 29);
            this.btnInvtWrtie.TabIndex = 7;
            this.btnInvtWrtie.Text = "Write";
            this.btnInvtWrtie.UseVisualStyleBackColor = true;
            this.btnInvtWrtie.Click += new System.EventHandler(this.btnInvtWrtie_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(21, 22);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 15);
            this.label22.TabIndex = 6;
            this.label22.Text = "MemBank";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(185, 22);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 15);
            this.label21.TabIndex = 5;
            this.label21.Text = "Word Counter";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(97, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 15);
            this.label20.TabIndex = 4;
            this.label20.Text = "Word Pointer";
            // 
            // cbxMemBank
            // 
            this.cbxMemBank.DisplayMember = "2";
            this.cbxMemBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMemBank.FormattingEnabled = true;
            this.cbxMemBank.Items.AddRange(new object[] {
            "RFU",
            "EPC",
            "TID",
            "User"});
            this.cbxMemBank.Location = new System.Drawing.Point(23, 39);
            this.cbxMemBank.Name = "cbxMemBank";
            this.cbxMemBank.Size = new System.Drawing.Size(59, 23);
            this.cbxMemBank.TabIndex = 3;
            this.cbxMemBank.Tag = "";
            this.cbxMemBank.SelectedIndexChanged += new System.EventHandler(this.cbxMemBank_SelectedIndexChanged);
            // 
            // txtWordCnt1
            // 
            this.txtWordCnt1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtWordCnt1.Location = new System.Drawing.Point(185, 40);
            this.txtWordCnt1.Name = "txtWordCnt1";
            this.txtWordCnt1.Size = new System.Drawing.Size(40, 21);
            this.txtWordCnt1.TabIndex = 2;
            this.txtWordCnt1.Text = "00";
            this.txtWordCnt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWordPtr1
            // 
            this.txtWordPtr1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtWordPtr1.Location = new System.Drawing.Point(96, 40);
            this.txtWordPtr1.Name = "txtWordPtr1";
            this.txtWordPtr1.Size = new System.Drawing.Size(40, 21);
            this.txtWordPtr1.TabIndex = 1;
            this.txtWordPtr1.Text = "00";
            this.txtWordPtr1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_invtread
            // 
            this.btn_invtread.Location = new System.Drawing.Point(24, 95);
            this.btn_invtread.Name = "btn_invtread";
            this.btn_invtread.Size = new System.Drawing.Size(75, 29);
            this.btn_invtread.TabIndex = 0;
            this.btn_invtread.Text = "Read";
            this.btn_invtread.UseVisualStyleBackColor = true;
            this.btn_invtread.Click += new System.EventHandler(this.btn_invtread_Click);
            // 
            // btnInvtAdv
            // 
            this.btnInvtAdv.Location = new System.Drawing.Point(9, 540);
            this.btnInvtAdv.Name = "btnInvtAdv";
            this.btnInvtAdv.Size = new System.Drawing.Size(215, 38);
            this.btnInvtAdv.TabIndex = 2;
            this.btnInvtAdv.Text = "Read Single";
            this.btnInvtAdv.UseVisualStyleBackColor = true;
            this.btnInvtAdv.Click += new System.EventHandler(this.btn_invt2_Click);
            // 
            // gbxEpcTableAdv
            // 
            this.gbxEpcTableAdv.Controls.Add(this.label_Access2);
            this.gbxEpcTableAdv.Controls.Add(this.btn_clear_epc2);
            this.gbxEpcTableAdv.Controls.Add(this.dgv_epc2);
            this.gbxEpcTableAdv.Location = new System.Drawing.Point(0, 6);
            this.gbxEpcTableAdv.Name = "gbxEpcTableAdv";
            this.gbxEpcTableAdv.Size = new System.Drawing.Size(533, 528);
            this.gbxEpcTableAdv.TabIndex = 0;
            this.gbxEpcTableAdv.TabStop = false;
            this.gbxEpcTableAdv.Text = "EPC Table";
            // 
            // label_Access2
            // 
            this.label_Access2.AutoSize = true;
            this.label_Access2.ForeColor = System.Drawing.Color.Red;
            this.label_Access2.Location = new System.Drawing.Point(115, 17);
            this.label_Access2.Name = "label_Access2";
            this.label_Access2.Size = new System.Drawing.Size(291, 15);
            this.label_Access2.TabIndex = 81;
            this.label_Access2.Text = "Step2: Click One of EPC Tag which to be Accessed";
            // 
            // btn_clear_epc2
            // 
            this.btn_clear_epc2.Location = new System.Drawing.Point(452, 12);
            this.btn_clear_epc2.Name = "btn_clear_epc2";
            this.btn_clear_epc2.Size = new System.Drawing.Size(75, 29);
            this.btn_clear_epc2.TabIndex = 21;
            this.btn_clear_epc2.Text = "Clear";
            this.btn_clear_epc2.UseVisualStyleBackColor = true;
            this.btn_clear_epc2.Click += new System.EventHandler(this.btn_clear_epc2_Click);
            // 
            // dgv_epc2
            // 
            this.dgv_epc2.AllowUserToAddRows = false;
            this.dgv_epc2.AllowUserToDeleteRows = false;
            this.dgv_epc2.AllowUserToResizeColumns = false;
            this.dgv_epc2.AllowUserToResizeRows = false;
            this.dgv_epc2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_epc2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_epc2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_epc2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgv_epc2.Location = new System.Drawing.Point(6, 43);
            this.dgv_epc2.Name = "dgv_epc2";
            this.dgv_epc2.ReadOnly = true;
            this.dgv_epc2.RowHeadersVisible = false;
            this.dgv_epc2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_epc2.RowTemplate.Height = 18;
            this.dgv_epc2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_epc2.Size = new System.Drawing.Size(521, 465);
            this.dgv_epc2.TabIndex = 20;
            this.dgv_epc2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGrid_MouseUp);
            // 
            // gbxSetQuery
            // 
            this.gbxSetQuery.Controls.Add(this.cbxM);
            this.gbxSetQuery.Controls.Add(this.cbxQAdv);
            this.gbxSetQuery.Controls.Add(this.btnGetQuery);
            this.gbxSetQuery.Controls.Add(this.btnSetQuery);
            this.gbxSetQuery.Controls.Add(this.label14);
            this.gbxSetQuery.Controls.Add(this.cbxTarget);
            this.gbxSetQuery.Controls.Add(this.label13);
            this.gbxSetQuery.Controls.Add(this.cbxSession);
            this.gbxSetQuery.Controls.Add(this.label12);
            this.gbxSetQuery.Controls.Add(this.cbxSel);
            this.gbxSetQuery.Controls.Add(this.label11);
            this.gbxSetQuery.Controls.Add(this.cbxTRext);
            this.gbxSetQuery.Controls.Add(this.label10);
            this.gbxSetQuery.Controls.Add(this.label9);
            this.gbxSetQuery.Controls.Add(this.label8);
            this.gbxSetQuery.Controls.Add(this.cbxDR);
            this.gbxSetQuery.Location = new System.Drawing.Point(539, 6);
            this.gbxSetQuery.Name = "gbxSetQuery";
            this.gbxSetQuery.Size = new System.Drawing.Size(521, 85);
            this.gbxSetQuery.TabIndex = 21;
            this.gbxSetQuery.TabStop = false;
            this.gbxSetQuery.Text = "Query Parameter";
            // 
            // cbxM
            // 
            this.cbxM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxM.Enabled = false;
            this.cbxM.FormattingEnabled = true;
            this.cbxM.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8"});
            this.cbxM.Location = new System.Drawing.Point(130, 19);
            this.cbxM.Name = "cbxM";
            this.cbxM.Size = new System.Drawing.Size(48, 23);
            this.cbxM.TabIndex = 2;
            this.cbxM.SelectedIndexChanged += new System.EventHandler(this.cbx_m_SelectedIndexChanged);
            // 
            // cbxQAdv
            // 
            this.cbxQAdv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQAdv.FormattingEnabled = true;
            this.cbxQAdv.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbxQAdv.Location = new System.Drawing.Point(130, 52);
            this.cbxQAdv.Name = "cbxQAdv";
            this.cbxQAdv.Size = new System.Drawing.Size(48, 23);
            this.cbxQAdv.TabIndex = 17;
            // 
            // btnGetQuery
            // 
            this.btnGetQuery.Location = new System.Drawing.Point(227, 48);
            this.btnGetQuery.Name = "btnGetQuery";
            this.btnGetQuery.Size = new System.Drawing.Size(75, 30);
            this.btnGetQuery.TabIndex = 16;
            this.btnGetQuery.Text = "Get Query";
            this.btnGetQuery.UseVisualStyleBackColor = true;
            this.btnGetQuery.Click += new System.EventHandler(this.btn_getquery_Click);
            // 
            // btnSetQuery
            // 
            this.btnSetQuery.Location = new System.Drawing.Point(337, 48);
            this.btnSetQuery.Name = "btnSetQuery";
            this.btnSetQuery.Size = new System.Drawing.Size(75, 30);
            this.btnSetQuery.TabIndex = 14;
            this.btnSetQuery.Text = "Set Query";
            this.btnSetQuery.UseVisualStyleBackColor = true;
            this.btnSetQuery.Click += new System.EventHandler(this.btn_setquery_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(104, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "Q =";
            // 
            // cbxTarget
            // 
            this.cbxTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTarget.FormattingEnabled = true;
            this.cbxTarget.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cbxTarget.Location = new System.Drawing.Point(52, 52);
            this.cbxTarget.Name = "cbxTarget";
            this.cbxTarget.Size = new System.Drawing.Size(48, 23);
            this.cbxTarget.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 15);
            this.label13.TabIndex = 10;
            this.label13.Text = "Target =";
            // 
            // cbxSession
            // 
            this.cbxSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSession.FormattingEnabled = true;
            this.cbxSession.Items.AddRange(new object[] {
            "S0",
            "S1",
            "S2",
            "S3"});
            this.cbxSession.Location = new System.Drawing.Point(468, 19);
            this.cbxSession.Name = "cbxSession";
            this.cbxSession.Size = new System.Drawing.Size(48, 23);
            this.cbxSession.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(405, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "Session =";
            // 
            // cbxSel
            // 
            this.cbxSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSel.FormattingEnabled = true;
            this.cbxSel.Items.AddRange(new object[] {
            "ALL(00)",
            "ALL(01)",
            "~SL(10)",
            "SL(11)"});
            this.cbxSel.Location = new System.Drawing.Point(338, 19);
            this.cbxSel.Name = "cbxSel";
            this.cbxSel.Size = new System.Drawing.Size(67, 23);
            this.cbxSel.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(301, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Sel =";
            // 
            // cbxTRext
            // 
            this.cbxTRext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTRext.Enabled = false;
            this.cbxTRext.FormattingEnabled = true;
            this.cbxTRext.Items.AddRange(new object[] {
            "NoPilot",
            "UsePilot"});
            this.cbxTRext.Location = new System.Drawing.Point(228, 19);
            this.cbxTRext.Name = "cbxTRext";
            this.cbxTRext.Size = new System.Drawing.Size(72, 23);
            this.cbxTRext.TabIndex = 5;
            this.cbxTRext.SelectedIndexChanged += new System.EventHandler(this.cbx_trext_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(180, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "TRext =";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(104, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "M =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "DR =";
            // 
            // cbxDR
            // 
            this.cbxDR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDR.Enabled = false;
            this.cbxDR.FormattingEnabled = true;
            this.cbxDR.Items.AddRange(new object[] {
            "8",
            "64/3"});
            this.cbxDR.Location = new System.Drawing.Point(52, 19);
            this.cbxDR.Name = "cbxDR";
            this.cbxDR.Size = new System.Drawing.Size(48, 23);
            this.cbxDR.TabIndex = 0;
            this.cbxDR.SelectedIndexChanged += new System.EventHandler(this.cbx_dr_SelectedIndexChanged);
            // 
            // tabPageSensorTag
            // 
            this.tabPageSensorTag.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSensorTag.Controls.Add(this.label40);
            this.tabPageSensorTag.Controls.Add(this.btn_SensorTag_Test);
            this.tabPageSensorTag.Controls.Add(this.btn_Zed_Clear);
            this.tabPageSensorTag.Controls.Add(this.zg1);
            this.tabPageSensorTag.Controls.Add(this.gbx_SensorTag_ReadTmp);
            this.tabPageSensorTag.Controls.Add(this.btn_SensorTag_InventoryOne);
            this.tabPageSensorTag.Controls.Add(this.gbxSensorTag);
            this.tabPageSensorTag.Location = new System.Drawing.Point(4, 24);
            this.tabPageSensorTag.Name = "tabPageSensorTag";
            this.tabPageSensorTag.Size = new System.Drawing.Size(1067, 619);
            this.tabPageSensorTag.TabIndex = 3;
            this.tabPageSensorTag.Text = "Sensor Tag";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.ForeColor = System.Drawing.Color.Red;
            this.label40.Location = new System.Drawing.Point(827, 21);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(43, 15);
            this.label40.TabIndex = 102;
            this.label40.Text = "Step1:";
            // 
            // btn_SensorTag_Test
            // 
            this.btn_SensorTag_Test.Location = new System.Drawing.Point(873, 263);
            this.btn_SensorTag_Test.Name = "btn_SensorTag_Test";
            this.btn_SensorTag_Test.Size = new System.Drawing.Size(132, 21);
            this.btn_SensorTag_Test.TabIndex = 101;
            this.btn_SensorTag_Test.Text = "Sensor Test";
            this.btn_SensorTag_Test.UseVisualStyleBackColor = true;
            this.btn_SensorTag_Test.Click += new System.EventHandler(this.btn_SensorTag_Test_Click);
            // 
            // btn_Zed_Clear
            // 
            this.btn_Zed_Clear.Location = new System.Drawing.Point(864, 300);
            this.btn_Zed_Clear.Name = "btn_Zed_Clear";
            this.btn_Zed_Clear.Size = new System.Drawing.Size(80, 28);
            this.btn_Zed_Clear.TabIndex = 100;
            this.btn_Zed_Clear.Text = "Clear";
            this.btn_Zed_Clear.UseVisualStyleBackColor = true;
            this.btn_Zed_Clear.Click += new System.EventHandler(this.btn_Zed_Clear_Click);
            // 
            // zg1
            // 
            this.zg1.Location = new System.Drawing.Point(8, 291);
            this.zg1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zg1.Name = "zg1";
            this.zg1.ScrollGrace = 0D;
            this.zg1.ScrollMaxX = 0D;
            this.zg1.ScrollMaxY = 0D;
            this.zg1.ScrollMaxY2 = 0D;
            this.zg1.ScrollMinX = 0D;
            this.zg1.ScrollMinY = 0D;
            this.zg1.ScrollMinY2 = 0D;
            this.zg1.Size = new System.Drawing.Size(1052, 324);
            this.zg1.TabIndex = 99;
            // 
            // gbx_SensorTag_ReadTmp
            // 
            this.gbx_SensorTag_ReadTmp.Controls.Add(this.label52);
            this.gbx_SensorTag_ReadTmp.Controls.Add(this.label51);
            this.gbx_SensorTag_ReadTmp.Controls.Add(this.cbx_SensorTag_SensorTagType);
            this.gbx_SensorTag_ReadTmp.Controls.Add(this.btn_SensorTag_StopRead);
            this.gbx_SensorTag_ReadTmp.Controls.Add(this.label49);
            this.gbx_SensorTag_ReadTmp.Controls.Add(this.label41);
            this.gbx_SensorTag_ReadTmp.Controls.Add(this.btn_SensorTag_GetTmpAuto);
            this.gbx_SensorTag_ReadTmp.Controls.Add(this.cbx_SensorTag_ReadNumber);
            this.gbx_SensorTag_ReadTmp.Controls.Add(this.label38);
            this.gbx_SensorTag_ReadTmp.Controls.Add(this.txt_SensorTag_AccPassWord);
            this.gbx_SensorTag_ReadTmp.Controls.Add(this.btn_SensorTag_GetTmpOne);
            this.gbx_SensorTag_ReadTmp.Location = new System.Drawing.Point(815, 46);
            this.gbx_SensorTag_ReadTmp.Name = "gbx_SensorTag_ReadTmp";
            this.gbx_SensorTag_ReadTmp.Size = new System.Drawing.Size(245, 211);
            this.gbx_SensorTag_ReadTmp.TabIndex = 98;
            this.gbx_SensorTag_ReadTmp.TabStop = false;
            this.gbx_SensorTag_ReadTmp.Text = "Temperature(°C)";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(12, 50);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(101, 15);
            this.label52.TabIndex = 108;
            this.label52.Text = "Access Counter:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(12, 21);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(59, 15);
            this.label51.TabIndex = 107;
            this.label51.Text = "Tag Type:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.ForeColor = System.Drawing.Color.Blue;
            this.label49.Location = new System.Drawing.Point(16, 146);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(71, 15);
            this.label49.TabIndex = 104;
            this.label49.Text = "Step1+2+3:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.ForeColor = System.Drawing.Color.Red;
            this.label41.Location = new System.Drawing.Point(12, 109);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(43, 15);
            this.label41.TabIndex = 103;
            this.label41.Text = "Step3:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(12, 77);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(111, 15);
            this.label38.TabIndex = 99;
            this.label38.Text = "Access Password";
            // 
            // txt_SensorTag_AccPassWord
            // 
            this.txt_SensorTag_AccPassWord.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_SensorTag_AccPassWord.Location = new System.Drawing.Point(149, 74);
            this.txt_SensorTag_AccPassWord.Name = "txt_SensorTag_AccPassWord";
            this.txt_SensorTag_AccPassWord.Size = new System.Drawing.Size(87, 21);
            this.txt_SensorTag_AccPassWord.TabIndex = 98;
            this.txt_SensorTag_AccPassWord.Text = "00 00 00 00";
            this.txt_SensorTag_AccPassWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbxSensorTag
            // 
            this.gbxSensorTag.Controls.Add(this.label50);
            this.gbxSensorTag.Controls.Add(this.btn_SelectAllSensorTag);
            this.gbxSensorTag.Controls.Add(this.btn_Clear_SensorTag);
            this.gbxSensorTag.Controls.Add(this.dgv_SensorTag);
            this.gbxSensorTag.Location = new System.Drawing.Point(8, 3);
            this.gbxSensorTag.Name = "gbxSensorTag";
            this.gbxSensorTag.Size = new System.Drawing.Size(801, 281);
            this.gbxSensorTag.TabIndex = 95;
            this.gbxSensorTag.TabStop = false;
            this.gbxSensorTag.Text = "Sensor EPC Table";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.ForeColor = System.Drawing.Color.Red;
            this.label50.Location = new System.Drawing.Point(69, 17);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(43, 15);
            this.label50.TabIndex = 103;
            this.label50.Text = "Step2:";
            // 
            // btn_Clear_SensorTag
            // 
            this.btn_Clear_SensorTag.Location = new System.Drawing.Point(347, 11);
            this.btn_Clear_SensorTag.Name = "btn_Clear_SensorTag";
            this.btn_Clear_SensorTag.Size = new System.Drawing.Size(75, 29);
            this.btn_Clear_SensorTag.TabIndex = 21;
            this.btn_Clear_SensorTag.Text = "Clear";
            this.btn_Clear_SensorTag.UseVisualStyleBackColor = true;
            this.btn_Clear_SensorTag.Click += new System.EventHandler(this.btn_Clear_SensorTag_Click);
            // 
            // dgv_SensorTag
            // 
            this.dgv_SensorTag.AllowUserToAddRows = false;
            this.dgv_SensorTag.AllowUserToDeleteRows = false;
            this.dgv_SensorTag.AllowUserToResizeColumns = false;
            this.dgv_SensorTag.AllowUserToResizeRows = false;
            this.dgv_SensorTag.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_SensorTag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_SensorTag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SensorTag.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgv_SensorTag.Location = new System.Drawing.Point(6, 43);
            this.dgv_SensorTag.Name = "dgv_SensorTag";
            this.dgv_SensorTag.ReadOnly = true;
            this.dgv_SensorTag.RowHeadersVisible = false;
            this.dgv_SensorTag.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_SensorTag.RowTemplate.Height = 18;
            this.dgv_SensorTag.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SensorTag.Size = new System.Drawing.Size(789, 227);
            this.dgv_SensorTag.TabIndex = 20;
            this.dgv_SensorTag.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SensorTag_ContentClick);
            this.dgv_SensorTag.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SensorTag_dgv_MouseUp);
            // 
            // tabPageTMS
            // 
            this.tabPageTMS.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageTMS.Controls.Add(this.btnScanRssi);
            this.tabPageTMS.Controls.Add(this.btnScanJammer);
            this.tabPageTMS.Controls.Add(this.groupBox2);
            this.tabPageTMS.Controls.Add(this.groupBox1);
            this.tabPageTMS.Location = new System.Drawing.Point(4, 24);
            this.tabPageTMS.Name = "tabPageTMS";
            this.tabPageTMS.Size = new System.Drawing.Size(1067, 619);
            this.tabPageTMS.TabIndex = 2;
            this.tabPageTMS.Text = "Test & Modem Setting ";
            // 
            // btnScanRssi
            // 
            this.btnScanRssi.Location = new System.Drawing.Point(559, 562);
            this.btnScanRssi.Name = "btnScanRssi";
            this.btnScanRssi.Size = new System.Drawing.Size(101, 31);
            this.btnScanRssi.TabIndex = 57;
            this.btnScanRssi.Text = "Scan RSSI";
            this.btnScanRssi.UseVisualStyleBackColor = true;
            this.btnScanRssi.Click += new System.EventHandler(this.btnScanRssi_Click);
            // 
            // btnScanJammer
            // 
            this.btnScanJammer.Location = new System.Drawing.Point(559, 263);
            this.btnScanJammer.Name = "btnScanJammer";
            this.btnScanJammer.Size = new System.Drawing.Size(101, 31);
            this.btnScanJammer.TabIndex = 47;
            this.btnScanJammer.Text = "Scan Jammer";
            this.btnScanJammer.UseVisualStyleBackColor = true;
            this.btnScanJammer.Click += new System.EventHandler(this.btnScanJammer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxCoupling);
            this.groupBox2.Controls.Add(this.label45);
            this.groupBox2.Controls.Add(this.tbxAntennaGain);
            this.groupBox2.Controls.Add(this.label43);
            this.groupBox2.Location = new System.Drawing.Point(721, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 77);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RSSI Parameter";
            // 
            // tbxCoupling
            // 
            this.tbxCoupling.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxCoupling.Location = new System.Drawing.Point(174, 46);
            this.tbxCoupling.Name = "tbxCoupling";
            this.tbxCoupling.Size = new System.Drawing.Size(51, 21);
            this.tbxCoupling.TabIndex = 46;
            this.tbxCoupling.Text = "-27";
            this.tbxCoupling.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(143, 28);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(120, 15);
            this.label45.TabIndex = 47;
            this.label45.Text = "Coupling of Coupler ";
            // 
            // tbxAntennaGain
            // 
            this.tbxAntennaGain.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxAntennaGain.Location = new System.Drawing.Point(33, 46);
            this.tbxAntennaGain.Name = "tbxAntennaGain";
            this.tbxAntennaGain.Size = new System.Drawing.Size(54, 21);
            this.tbxAntennaGain.TabIndex = 44;
            this.tbxAntennaGain.Text = "1";
            this.tbxAntennaGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(17, 28);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(82, 15);
            this.label43.TabIndex = 45;
            this.label43.Text = "Antenna Gain";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxSignalThreshold);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.btnSetModemPara);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbxMixerGain);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbxIFAmpGain);
            this.groupBox1.Controls.Add(this.btnGetModemPara);
            this.groupBox1.Location = new System.Drawing.Point(721, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 115);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modem Settings";
            // 
            // tbxSignalThreshold
            // 
            this.tbxSignalThreshold.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxSignalThreshold.Location = new System.Drawing.Point(196, 39);
            this.tbxSignalThreshold.Name = "tbxSignalThreshold";
            this.tbxSignalThreshold.Size = new System.Drawing.Size(46, 21);
            this.tbxSignalThreshold.TabIndex = 39;
            this.tbxSignalThreshold.Text = "01B0";
            this.tbxSignalThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(189, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 15);
            this.label23.TabIndex = 43;
            this.label23.Text = "Threshold";
            // 
            // btnSetModemPara
            // 
            this.btnSetModemPara.Location = new System.Drawing.Point(20, 76);
            this.btnSetModemPara.Name = "btnSetModemPara";
            this.btnSetModemPara.Size = new System.Drawing.Size(87, 29);
            this.btnSetModemPara.TabIndex = 36;
            this.btnSetModemPara.Text = "Set Modem";
            this.btnSetModemPara.UseVisualStyleBackColor = true;
            this.btnSetModemPara.Click += new System.EventHandler(this.btnSetModemPara_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 42;
            this.label7.Text = "IF Amp Gain";
            // 
            // cbxMixerGain
            // 
            this.cbxMixerGain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMixerGain.FormattingEnabled = true;
            this.cbxMixerGain.Items.AddRange(new object[] {
            "0dB",
            "3dB",
            "6dB",
            "9dB",
            "12dB",
            "15dB",
            "16dB"});
            this.cbxMixerGain.Location = new System.Drawing.Point(17, 36);
            this.cbxMixerGain.Name = "cbxMixerGain";
            this.cbxMixerGain.Size = new System.Drawing.Size(65, 23);
            this.cbxMixerGain.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 41;
            this.label6.Text = "Mixer Gain";
            // 
            // cbxIFAmpGain
            // 
            this.cbxIFAmpGain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIFAmpGain.FormattingEnabled = true;
            this.cbxIFAmpGain.Items.AddRange(new object[] {
            "12dB",
            "18dB",
            "21dB",
            "24dB",
            "27dB",
            "30dB",
            "36dB",
            "40dB"});
            this.cbxIFAmpGain.Location = new System.Drawing.Point(114, 36);
            this.cbxIFAmpGain.Name = "cbxIFAmpGain";
            this.cbxIFAmpGain.Size = new System.Drawing.Size(59, 23);
            this.cbxIFAmpGain.TabIndex = 38;
            // 
            // btnGetModemPara
            // 
            this.btnGetModemPara.Location = new System.Drawing.Point(166, 76);
            this.btnGetModemPara.Name = "btnGetModemPara";
            this.btnGetModemPara.Size = new System.Drawing.Size(86, 29);
            this.btnGetModemPara.TabIndex = 40;
            this.btnGetModemPara.Text = "Get Modem";
            this.btnGetModemPara.UseVisualStyleBackColor = true;
            this.btnGetModemPara.Click += new System.EventHandler(this.btnGetModemPara_Click);
            // 
            // tabPageImpinjTag
            // 
            this.tabPageImpinjTag.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageImpinjTag.Controls.Add(this.groupBox5);
            this.tabPageImpinjTag.Controls.Add(this.groupBoxMonzaCmds);
            this.tabPageImpinjTag.Location = new System.Drawing.Point(4, 24);
            this.tabPageImpinjTag.Name = "tabPageImpinjTag";
            this.tabPageImpinjTag.Size = new System.Drawing.Size(1067, 619);
            this.tabPageImpinjTag.TabIndex = 5;
            this.tabPageImpinjTag.Text = "ImpinjTag(Not Work)";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.tbxNxpCmdAccessPwd);
            this.groupBox5.Controls.Add(this.cbxReadProtectReset);
            this.groupBox5.Controls.Add(this.btnChangeConfig);
            this.groupBox5.Controls.Add(this.btnReadProtect);
            this.groupBox5.Controls.Add(this.btnChangeEas);
            this.groupBox5.Controls.Add(this.label48);
            this.groupBox5.Controls.Add(this.cbxSetEas);
            this.groupBox5.Controls.Add(this.txtConfigData);
            this.groupBox5.Controls.Add(this.btnEasAlarm);
            this.groupBox5.Location = new System.Drawing.Point(8, 75);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(471, 100);
            this.groupBox5.TabIndex = 82;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "NXP Tag Commands";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(4, 31);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(111, 15);
            this.label24.TabIndex = 77;
            this.label24.Text = "Access Password";
            // 
            // tbxNxpCmdAccessPwd
            // 
            this.tbxNxpCmdAccessPwd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxNxpCmdAccessPwd.Font = new System.Drawing.Font("Arial", 9F);
            this.tbxNxpCmdAccessPwd.Location = new System.Drawing.Point(14, 59);
            this.tbxNxpCmdAccessPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxNxpCmdAccessPwd.Name = "tbxNxpCmdAccessPwd";
            this.tbxNxpCmdAccessPwd.Size = new System.Drawing.Size(80, 21);
            this.tbxNxpCmdAccessPwd.TabIndex = 76;
            this.tbxNxpCmdAccessPwd.Text = "00 00 00 00";
            this.tbxNxpCmdAccessPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxReadProtectReset
            // 
            this.cbxReadProtectReset.AutoSize = true;
            this.cbxReadProtectReset.Enabled = false;
            this.cbxReadProtectReset.Location = new System.Drawing.Point(229, 71);
            this.cbxReadProtectReset.Name = "cbxReadProtectReset";
            this.cbxReadProtectReset.Size = new System.Drawing.Size(59, 19);
            this.cbxReadProtectReset.TabIndex = 75;
            this.cbxReadProtectReset.Text = "Reset";
            this.cbxReadProtectReset.UseVisualStyleBackColor = true;
            // 
            // btnChangeConfig
            // 
            this.btnChangeConfig.Enabled = false;
            this.btnChangeConfig.Location = new System.Drawing.Point(115, 26);
            this.btnChangeConfig.Name = "btnChangeConfig";
            this.btnChangeConfig.Size = new System.Drawing.Size(102, 29);
            this.btnChangeConfig.TabIndex = 70;
            this.btnChangeConfig.Text = "Change Config";
            this.btnChangeConfig.UseVisualStyleBackColor = true;
            this.btnChangeConfig.Click += new System.EventHandler(this.btnChangeConfig_Click);
            // 
            // btnReadProtect
            // 
            this.btnReadProtect.Enabled = false;
            this.btnReadProtect.Location = new System.Drawing.Point(115, 65);
            this.btnReadProtect.Name = "btnReadProtect";
            this.btnReadProtect.Size = new System.Drawing.Size(102, 29);
            this.btnReadProtect.TabIndex = 74;
            this.btnReadProtect.Text = "ReadProtect";
            this.btnReadProtect.UseVisualStyleBackColor = true;
            this.btnReadProtect.Click += new System.EventHandler(this.btnReadProtect_Click);
            // 
            // btnChangeEas
            // 
            this.btnChangeEas.Enabled = false;
            this.btnChangeEas.Location = new System.Drawing.Point(293, 26);
            this.btnChangeEas.Name = "btnChangeEas";
            this.btnChangeEas.Size = new System.Drawing.Size(95, 29);
            this.btnChangeEas.TabIndex = 70;
            this.btnChangeEas.Text = "Change EAS";
            this.btnChangeEas.UseVisualStyleBackColor = true;
            this.btnChangeEas.Click += new System.EventHandler(this.btnChangeEas_Click);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(223, 11);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(78, 15);
            this.label48.TabIndex = 73;
            this.label48.Text = "Config-Word";
            // 
            // cbxSetEas
            // 
            this.cbxSetEas.AutoSize = true;
            this.cbxSetEas.Enabled = false;
            this.cbxSetEas.Location = new System.Drawing.Point(396, 31);
            this.cbxSetEas.Name = "cbxSetEas";
            this.cbxSetEas.Size = new System.Drawing.Size(71, 19);
            this.cbxSetEas.TabIndex = 71;
            this.cbxSetEas.Text = "Set EAS";
            this.cbxSetEas.UseVisualStyleBackColor = true;
            // 
            // txtConfigData
            // 
            this.txtConfigData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConfigData.Location = new System.Drawing.Point(232, 31);
            this.txtConfigData.Name = "txtConfigData";
            this.txtConfigData.Size = new System.Drawing.Size(52, 21);
            this.txtConfigData.TabIndex = 36;
            this.txtConfigData.Text = "00 00";
            this.txtConfigData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEasAlarm
            // 
            this.btnEasAlarm.Enabled = false;
            this.btnEasAlarm.Location = new System.Drawing.Point(293, 65);
            this.btnEasAlarm.Name = "btnEasAlarm";
            this.btnEasAlarm.Size = new System.Drawing.Size(95, 29);
            this.btnEasAlarm.TabIndex = 72;
            this.btnEasAlarm.Text = "EAS Alarm";
            this.btnEasAlarm.UseVisualStyleBackColor = true;
            this.btnEasAlarm.Click += new System.EventHandler(this.btnEasAlarm_Click);
            // 
            // groupBoxMonzaCmds
            // 
            this.groupBoxMonzaCmds.Controls.Add(this.label36);
            this.groupBoxMonzaCmds.Controls.Add(this.btnMonzaQTWrite);
            this.groupBoxMonzaCmds.Controls.Add(this.tbxMonzaQTAccessPwd);
            this.groupBoxMonzaCmds.Controls.Add(this.btnMonzaQTRead);
            this.groupBoxMonzaCmds.Controls.Add(this.cbxMonzaQT_MEM);
            this.groupBoxMonzaCmds.Controls.Add(this.cbxMonzaQT_SR);
            this.groupBoxMonzaCmds.Location = new System.Drawing.Point(8, 23);
            this.groupBoxMonzaCmds.Name = "groupBoxMonzaCmds";
            this.groupBoxMonzaCmds.Size = new System.Drawing.Size(471, 46);
            this.groupBoxMonzaCmds.TabIndex = 81;
            this.groupBoxMonzaCmds.TabStop = false;
            this.groupBoxMonzaCmds.Text = "Impinj Monza Tag Commands";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(6, 20);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(111, 15);
            this.label36.TabIndex = 77;
            this.label36.Text = "Access Password";
            // 
            // btnMonzaQTWrite
            // 
            this.btnMonzaQTWrite.Enabled = false;
            this.btnMonzaQTWrite.Location = new System.Drawing.Point(294, 12);
            this.btnMonzaQTWrite.Name = "btnMonzaQTWrite";
            this.btnMonzaQTWrite.Size = new System.Drawing.Size(75, 29);
            this.btnMonzaQTWrite.TabIndex = 0;
            this.btnMonzaQTWrite.Text = "QT Write";
            this.btnMonzaQTWrite.UseVisualStyleBackColor = true;
            this.btnMonzaQTWrite.Click += new System.EventHandler(this.btnMonzaQTWrite_Click);
            // 
            // tbxMonzaQTAccessPwd
            // 
            this.tbxMonzaQTAccessPwd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxMonzaQTAccessPwd.Font = new System.Drawing.Font("Arial", 9F);
            this.tbxMonzaQTAccessPwd.Location = new System.Drawing.Point(115, 17);
            this.tbxMonzaQTAccessPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxMonzaQTAccessPwd.Name = "tbxMonzaQTAccessPwd";
            this.tbxMonzaQTAccessPwd.Size = new System.Drawing.Size(80, 21);
            this.tbxMonzaQTAccessPwd.TabIndex = 76;
            this.tbxMonzaQTAccessPwd.Text = "00 00 00 00";
            this.tbxMonzaQTAccessPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMonzaQTRead
            // 
            this.btnMonzaQTRead.Enabled = false;
            this.btnMonzaQTRead.Location = new System.Drawing.Point(203, 12);
            this.btnMonzaQTRead.Name = "btnMonzaQTRead";
            this.btnMonzaQTRead.Size = new System.Drawing.Size(78, 29);
            this.btnMonzaQTRead.TabIndex = 0;
            this.btnMonzaQTRead.Text = "QT Read";
            this.btnMonzaQTRead.UseVisualStyleBackColor = true;
            this.btnMonzaQTRead.Click += new System.EventHandler(this.btnMonzaQTRead_Click);
            // 
            // cbxMonzaQT_MEM
            // 
            this.cbxMonzaQT_MEM.AutoSize = true;
            this.cbxMonzaQT_MEM.Enabled = false;
            this.cbxMonzaQT_MEM.Location = new System.Drawing.Point(385, 25);
            this.cbxMonzaQT_MEM.Name = "cbxMonzaQT_MEM";
            this.cbxMonzaQT_MEM.Size = new System.Drawing.Size(76, 19);
            this.cbxMonzaQT_MEM.TabIndex = 71;
            this.cbxMonzaQT_MEM.Text = "QT_MEM";
            this.cbxMonzaQT_MEM.UseVisualStyleBackColor = true;
            // 
            // cbxMonzaQT_SR
            // 
            this.cbxMonzaQT_SR.AutoSize = true;
            this.cbxMonzaQT_SR.Enabled = false;
            this.cbxMonzaQT_SR.Location = new System.Drawing.Point(385, 10);
            this.cbxMonzaQT_SR.Name = "cbxMonzaQT_SR";
            this.cbxMonzaQT_SR.Size = new System.Drawing.Size(65, 19);
            this.cbxMonzaQT_SR.TabIndex = 71;
            this.cbxMonzaQT_SR.Text = "QT_SR";
            this.cbxMonzaQT_SR.UseVisualStyleBackColor = true;
            // 
            // gbxRdIntrgtMem
            // 
            this.gbxRdIntrgtMem.Location = new System.Drawing.Point(0, 0);
            this.gbxRdIntrgtMem.Name = "gbxRdIntrgtMem";
            this.gbxRdIntrgtMem.Size = new System.Drawing.Size(200, 100);
            this.gbxRdIntrgtMem.TabIndex = 0;
            this.gbxRdIntrgtMem.TabStop = false;
            // 
            // timerCheckReader
            // 
            this.timerCheckReader.Interval = 1000;
            this.timerCheckReader.Tick += new System.EventHandler(this.timerCheckReader_Tick);
            // 
            // tmrCheckEpc
            // 
            this.tmrCheckEpc.Interval = 300;
            this.tmrCheckEpc.Tick += new System.EventHandler(this.tmrCheckEpc_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStripInfor
            // 
            this.statusStripInfor.AutoSize = false;
            this.statusStripInfor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripProgressBar1});
            this.statusStripInfor.Location = new System.Drawing.Point(0, 571);
            this.statusStripInfor.Name = "statusStripInfor";
            this.statusStripInfor.Size = new System.Drawing.Size(1076, 33);
            this.statusStripInfor.TabIndex = 89;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(550, 28);
            this.toolStripStatusLabel1.Text = "UHF RFID Reader DEMO ";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabel1.Visible = false;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(350, 28);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(150, 28);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(120, 27);
            // 
            // label_dllversion
            // 
            this.label_dllversion.AutoSize = true;
            this.label_dllversion.Location = new System.Drawing.Point(864, 0);
            this.label_dllversion.Name = "label_dllversion";
            this.label_dllversion.Size = new System.Drawing.Size(117, 15);
            this.label_dllversion.TabIndex = 90;
            this.label_dllversion.Text = "DLL Ver: 0x92.02.0B";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.btnAddBox);
            this.panelMain.Controls.Add(this.comboBoxStockIn);
            this.panelMain.Controls.Add(this.comboBoxStockPackaging);
            this.panelMain.Controls.Add(this.textBoxEquipmentRegNo);
            this.panelMain.Controls.Add(this.textBoxEquipmentRFID);
            this.panelMain.Controls.Add(this.textBoxDescription);
            this.panelMain.Controls.Add(this.buttonAdd);
            this.panelMain.Controls.Add(this.buttonUpdate);
            this.panelMain.Controls.Add(this.buttonDelete);
            this.panelMain.Controls.Add(this.buttonClear);
            this.panelMain.Controls.Add(this.dataGridViewStockInItems);
            this.panelMain.Controls.Add(this.labelStockIn);
            this.panelMain.Controls.Add(this.labelStockPackaging);
            this.panelMain.Controls.Add(this.labelEquipmentRegNo);
            this.panelMain.Controls.Add(this.labelEquipmentRFID);
            this.panelMain.Controls.Add(this.labelDescription);
            this.panelMain.Location = new System.Drawing.Point(10, 50);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(743, 500);
            this.panelMain.TabIndex = 0;
            // 
            // btnAddBox
            // 
            this.btnAddBox.Location = new System.Drawing.Point(150, 89);
            this.btnAddBox.Name = "btnAddBox";
            this.btnAddBox.Size = new System.Drawing.Size(80, 23);
            this.btnAddBox.TabIndex = 15;
            this.btnAddBox.Text = "Add Box";
            this.btnAddBox.UseVisualStyleBackColor = true;
            this.btnAddBox.Click += new System.EventHandler(this.btnAddBox_Click);
            // 
            // comboBoxStockIn
            // 
            this.comboBoxStockIn.FormattingEnabled = true;
            this.comboBoxStockIn.Location = new System.Drawing.Point(150, 30);
            this.comboBoxStockIn.Name = "comboBoxStockIn";
            this.comboBoxStockIn.Size = new System.Drawing.Size(200, 23);
            this.comboBoxStockIn.TabIndex = 0;
            this.comboBoxStockIn.SelectedIndexChanged += new System.EventHandler(this.comboBoxStockIn_SelectedIndexChanged);
            // 
            // comboBoxStockPackaging
            // 
            this.comboBoxStockPackaging.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxStockPackaging.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxStockPackaging.FormattingEnabled = true;
            this.comboBoxStockPackaging.Location = new System.Drawing.Point(150, 60);
            this.comboBoxStockPackaging.Name = "comboBoxStockPackaging";
            this.comboBoxStockPackaging.Size = new System.Drawing.Size(200, 23);
            this.comboBoxStockPackaging.TabIndex = 1;
            this.comboBoxStockPackaging.SelectedIndexChanged += new System.EventHandler(this.comboBoxStockPackaging_SelectedIndexChanged);
            // 
            // textBoxEquipmentRegNo
            // 
            this.textBoxEquipmentRegNo.Location = new System.Drawing.Point(487, 28);
            this.textBoxEquipmentRegNo.Name = "textBoxEquipmentRegNo";
            this.textBoxEquipmentRegNo.Size = new System.Drawing.Size(250, 21);
            this.textBoxEquipmentRegNo.TabIndex = 2;
            // 
            // textBoxEquipmentRFID
            // 
            this.textBoxEquipmentRFID.Enabled = false;
            this.textBoxEquipmentRFID.Location = new System.Drawing.Point(487, 62);
            this.textBoxEquipmentRFID.Name = "textBoxEquipmentRFID";
            this.textBoxEquipmentRFID.Size = new System.Drawing.Size(250, 21);
            this.textBoxEquipmentRFID.TabIndex = 3;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(487, 94);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(200, 60);
            this.textBoxDescription.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(20, 150);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(275, 150);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(200, 150);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(110, 150);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // dataGridViewStockInItems
            // 
            this.dataGridViewStockInItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStockInItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Equipment_Reg_No,
            this.Equipment_Rfid});
            this.dataGridViewStockInItems.Location = new System.Drawing.Point(20, 190);
            this.dataGridViewStockInItems.MultiSelect = false;
            this.dataGridViewStockInItems.Name = "dataGridViewStockInItems";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewStockInItems.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewStockInItems.Size = new System.Drawing.Size(690, 307);
            this.dataGridViewStockInItems.TabIndex = 9;
            this.dataGridViewStockInItems.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewStockInItems_RowPostPaint);
            // 
            // Equipment_Reg_No
            // 
            this.Equipment_Reg_No.DataPropertyName = "Equipment_Reg_No";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equipment_Reg_No.DefaultCellStyle = dataGridViewCellStyle1;
            this.Equipment_Reg_No.HeaderText = "Equipment_Reg_No";
            this.Equipment_Reg_No.Name = "Equipment_Reg_No";
            this.Equipment_Reg_No.Width = 300;
            // 
            // Equipment_Rfid
            // 
            this.Equipment_Rfid.DataPropertyName = "Equipment_Rfid";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equipment_Rfid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Equipment_Rfid.HeaderText = "Equipment_Rfid";
            this.Equipment_Rfid.Name = "Equipment_Rfid";
            this.Equipment_Rfid.Width = 300;
            // 
            // labelStockIn
            // 
            this.labelStockIn.AutoSize = true;
            this.labelStockIn.Location = new System.Drawing.Point(20, 33);
            this.labelStockIn.Name = "labelStockIn";
            this.labelStockIn.Size = new System.Drawing.Size(70, 15);
            this.labelStockIn.TabIndex = 10;
            this.labelStockIn.Text = "Invoice No.:";
            // 
            // labelStockPackaging
            // 
            this.labelStockPackaging.AutoSize = true;
            this.labelStockPackaging.Location = new System.Drawing.Point(20, 63);
            this.labelStockPackaging.Name = "labelStockPackaging";
            this.labelStockPackaging.Size = new System.Drawing.Size(124, 15);
            this.labelStockPackaging.TabIndex = 11;
            this.labelStockPackaging.Text = "Stock Packaging Box:";
            // 
            // labelEquipmentRegNo
            // 
            this.labelEquipmentRegNo.AutoSize = true;
            this.labelEquipmentRegNo.Location = new System.Drawing.Point(360, 30);
            this.labelEquipmentRegNo.Name = "labelEquipmentRegNo";
            this.labelEquipmentRegNo.Size = new System.Drawing.Size(121, 15);
            this.labelEquipmentRegNo.TabIndex = 12;
            this.labelEquipmentRegNo.Text = "Equipment Reg. No.:";
            // 
            // labelEquipmentRFID
            // 
            this.labelEquipmentRFID.AutoSize = true;
            this.labelEquipmentRFID.Location = new System.Drawing.Point(360, 68);
            this.labelEquipmentRFID.Name = "labelEquipmentRFID";
            this.labelEquipmentRFID.Size = new System.Drawing.Size(101, 15);
            this.labelEquipmentRFID.TabIndex = 13;
            this.labelEquipmentRFID.Text = "Equipment RFID:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(360, 97);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(73, 15);
            this.labelDescription.TabIndex = 14;
            this.labelDescription.Text = "Description:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1076, 604);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.label_dllversion);
            this.Controls.Add(this.statusStripInfor);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Weapon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbx_conn.ResumeLayout(false);
            this.gbx_conn.PerformLayout();
            this.gbx_NewDevAddr.ResumeLayout(false);
            this.gbxRxData.ResumeLayout(false);
            this.gbxRxData.PerformLayout();
            this.gbx_inventory.ResumeLayout(false);
            this.gbx_inventory.PerformLayout();
            this.gbx_MTR.ResumeLayout(false);
            this.gbx_MTR.PerformLayout();
            this.gbx_MTR_LoopNum.ResumeLayout(false);
            this.gbx_MTR_LoopNum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEpcBasic)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbxEpcTableBasic.ResumeLayout(false);
            this.gbxEpcTableBasic.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage_TagRead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Inv_Indicator)).EndInit();
            this.tabPage_SysSetting.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.gbxStatus.ResumeLayout(false);
            this.gbxStatus.PerformLayout();
            this.tabPageSysSetting.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox_GPIO.ResumeLayout(false);
            this.groupBox_GPI.ResumeLayout(false);
            this.groupBox_GPI.PerformLayout();
            this.groupBox_GPO.ResumeLayout(false);
            this.groupBox_GPO.PerformLayout();
            this.gbxIoControl.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox_RFSetting.ResumeLayout(false);
            this.gbxRfPower.ResumeLayout(false);
            this.gbx_setfreq.ResumeLayout(false);
            this.gbx_InsertRFCH.ResumeLayout(false);
            this.gbx_InsertRFCH.PerformLayout();
            this.groupBox_RF_Ant.ResumeLayout(false);
            this.groupBox_RF_Ant.PerformLayout();
            this.groupBox_RF_Ant_Port.ResumeLayout(false);
            this.groupBox_RF_Ant_Port.PerformLayout();
            this.groupBox_RF_Ant_Enable.ResumeLayout(false);
            this.groupBox_RF_Ant_Enable.PerformLayout();
            this.groupBox_RF_Ant_SwitchAnt.ResumeLayout(false);
            this.groupBox_RF_Ant_SwitchAnt.PerformLayout();
            this.tabPageAccessTag.ResumeLayout(false);
            this.tabPageAccessTag.PerformLayout();
            this.gbxStatus2.ResumeLayout(false);
            this.gbxStatus2.PerformLayout();
            this.gbxKill.ResumeLayout(false);
            this.gbxKill.PerformLayout();
            this.gBxLock.ResumeLayout(false);
            this.gBxLock.PerformLayout();
            this.gbxSelect.ResumeLayout(false);
            this.gbxSelect.PerformLayout();
            this.gbx_comcnt_adv.ResumeLayout(false);
            this.gbx_comcnt_adv.PerformLayout();
            this.gbxAccess.ResumeLayout(false);
            this.gbxAccess.PerformLayout();
            this.gbxEpcTableAdv.ResumeLayout(false);
            this.gbxEpcTableAdv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_epc2)).EndInit();
            this.gbxSetQuery.ResumeLayout(false);
            this.gbxSetQuery.PerformLayout();
            this.tabPageSensorTag.ResumeLayout(false);
            this.tabPageSensorTag.PerformLayout();
            this.gbx_SensorTag_ReadTmp.ResumeLayout(false);
            this.gbx_SensorTag_ReadTmp.PerformLayout();
            this.gbxSensorTag.ResumeLayout(false);
            this.gbxSensorTag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SensorTag)).EndInit();
            this.tabPageTMS.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageImpinjTag.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBoxMonzaCmds.ResumeLayout(false);
            this.groupBoxMonzaCmds.PerformLayout();
            this.statusStripInfor.ResumeLayout(false);
            this.statusStripInfor.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockInItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_conn;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.ComboBox cbxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btn_clear_rx;
        private System.Windows.Forms.Button btnClearCnt;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Timer timerAutoSend;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.GroupBox gbxRxData;
        private System.Windows.Forms.GroupBox gbx_inventory;
        private System.Windows.Forms.Button btnInvtBasic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxQBasic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvEpcBasic;
        private System.Windows.Forms.GroupBox gbxEpcTableBasic;
        private System.Windows.Forms.Button btn_clear_epc1;
        private System.Windows.Forms.CheckBox cbxAutoClear;
        private System.Windows.Forms.CheckBox cbxRxVisable;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageAccessTag;
        private System.Windows.Forms.GroupBox gbxEpcTableAdv;
        private System.Windows.Forms.DataGridView dgv_epc2;
        private System.Windows.Forms.Button btn_clear_epc2;
        private System.Windows.Forms.Button btnInvtAdv;
        private System.Windows.Forms.GroupBox gbxSetQuery;
        private System.Windows.Forms.ComboBox cbxDR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxTRext;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxSel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxSession;
        private System.Windows.Forms.GroupBox gbxRdIntrgtMem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxTarget;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSetQuery;
        private System.Windows.Forms.Button btnGetQuery;
        private System.Windows.Forms.ComboBox cbxQAdv;
        private System.Windows.Forms.Button btnInvtMulti;
        private System.Windows.Forms.TextBox txtRDMultiNum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnStopRD;
        private System.Windows.Forms.TextBox txtCOMRxCnt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCOMTxCnt;
        private System.Windows.Forms.GroupBox gbxStatus;
        private System.Windows.Forms.GroupBox gbxAccess;
        private System.Windows.Forms.GroupBox gbx_comcnt_adv;
        private System.Windows.Forms.Button btnClearCntAdv;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCOMRxCnt_adv;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCOMTxCnt_adv;
        private System.Windows.Forms.Button btn_invtread;
        private System.Windows.Forms.TextBox txtWordPtr1;
        private System.Windows.Forms.TextBox txtWordCnt1;
        private System.Windows.Forms.ComboBox cbxMemBank;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnInvtWrtie;
        private System.Windows.Forms.TextBox txtInvtRWData;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtRwAccPassWord;
        private System.Windows.Forms.TextBox txtWordPtr0;
        private System.Windows.Forms.TextBox txtWordCnt0;
        private System.Windows.Forms.GroupBox gbxSelect;
        private System.Windows.Forms.Button btnSetSelect;
        private System.Windows.Forms.ComboBox cbxSelTarget;
        private System.Windows.Forms.ComboBox cbxAction;
        private System.Windows.Forms.ComboBox cbxSelMemBank;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtSelPrt0;
        private System.Windows.Forms.TextBox txtSelPrt2;
        private System.Windows.Forms.TextBox txtSelPrt1;
        private System.Windows.Forms.TextBox txtSelPrt3;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtSelLength;
        private System.Windows.Forms.CheckBox ckxTruncated;
        private System.Windows.Forms.TextBox txtSelMask;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button btnGetSelect;
        private System.Windows.Forms.TextBox txtGetSelLength;
        private System.Windows.Forms.TextBox txtGetSelMask;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.GroupBox gbxKill;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox textBoxKillPwd;
        private System.Windows.Forms.Button buttonKill;
        private System.Windows.Forms.GroupBox gBxLock;
        private System.Windows.Forms.Button buttonLock;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox textBoxLockAccessPwd;
        private System.Windows.Forms.Label labelKillRFU;
        private System.Windows.Forms.TextBox textBoxKillRFU;
        private System.Windows.Forms.CheckBox inv_mode;
        private System.Windows.Forms.TextBox txtSendDelay;
        private System.Windows.Forms.PictureBox pbx_Inv_Indicator;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPageTMS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxSignalThreshold;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnSetModemPara;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxMixerGain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxIFAmpGain;
        private System.Windows.Forms.Button btnGetModemPara;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxCoupling;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox tbxAntennaGain;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Button btnScanJammer;
        private BarChart.HBarChart hBarChartJammer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveAsCsvToolStripMenuItem;
        private BarChart.HBarChart hBarChartRssi;
        private System.Windows.Forms.Timer timerCheckReader;
        private System.Windows.Forms.Button Reset_FW;
        private System.Windows.Forms.Button btnScanRssi;
        private System.Windows.Forms.Timer tmrCheckEpc;
        private System.Windows.Forms.TextBox txtHardwareVersion;
        private System.Windows.Forms.Label labelHardwareVersion;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox txtOperateEpc;
        private System.Windows.Forms.GroupBox gbxStatus2;
        private System.Windows.Forms.RichTextBox rtbxStatus;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cbxLockKillAction;
        private System.Windows.Forms.CheckBox checkBoxUser;
        private System.Windows.Forms.CheckBox checkBoxTID;
        private System.Windows.Forms.CheckBox checkBoxEPC;
        private System.Windows.Forms.CheckBox checkBoxAccessPwd;
        private System.Windows.Forms.CheckBox checkBoxKillPwd;
        private System.Windows.Forms.ComboBox cbxLockUserAction;
        private System.Windows.Forms.ComboBox cbxLockTIDAction;
        private System.Windows.Forms.ComboBox cbxLockEPCAction;
        private System.Windows.Forms.ComboBox cbxLockAccessAction;
        private System.Windows.Forms.TextBox txtFirmwareVersion;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TabPage tabPageSensorTag;
        private System.Windows.Forms.Label label_DeviceAddr;
        private System.Windows.Forms.ComboBox cbxDeviceAddr;
        private System.Windows.Forms.Button btn_SetReaderDeviceAddr;
        private System.Windows.Forms.Button btn_GetReaderDeviceAddr;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStripInfor;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.GroupBox gbxSensorTag;
        //private System.Windows.Forms.Button btn_ClearSensorTag;
        private System.Windows.Forms.DataGridView dgv_SensorTag;
        private System.Windows.Forms.Button btn_SensorTag_InventoryOne;
        private System.Windows.Forms.Button btn_Clear_SensorTag;
        private System.Windows.Forms.Button btn_SensorTag_GetTmpOne;
        private System.Windows.Forms.GroupBox gbx_SensorTag_ReadTmp;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txt_SensorTag_AccPassWord;
        private System.Windows.Forms.ComboBox cbx_SensorTag_ReadNumber;
        private ZedGraph.ZedGraphControl zg1;
        private System.Windows.Forms.Button btn_SensorTag_GetTmpAuto;
        private System.Windows.Forms.Button btn_Zed_Clear;
        private System.Windows.Forms.GroupBox gbx_NewDevAddr;
        private System.Windows.Forms.ComboBox cbxNewDeviceAddr;
        private System.Windows.Forms.Button btn_SensorTag_Test;
        private System.Windows.Forms.TabPage tabPageSysSetting;
        private System.Windows.Forms.GroupBox groupBox_RF_Ant;
        private System.Windows.Forms.GroupBox groupBox_RFSetting;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox_RF_Ant_Port;
        private System.Windows.Forms.RadioButton radioButton_AntPort8;
        private System.Windows.Forms.RadioButton radioButton_AntPort7;
        private System.Windows.Forms.RadioButton radioButton_AntPort6;
        private System.Windows.Forms.RadioButton radioButton_AntPort5;
        private System.Windows.Forms.RadioButton radioButton_AntPort4;
        private System.Windows.Forms.RadioButton radioButton_AntPort3;
        private System.Windows.Forms.RadioButton radioButton_AntPort2;
        private System.Windows.Forms.RadioButton radioButton_AntPort1;
        private System.Windows.Forms.CheckBox checkBox_RF_AntPort_AutoPolling;
        private System.Windows.Forms.Label label_RF_AntPort_InvCnter;
        private System.Windows.Forms.Label label_RF_AntPort_Power;
        private System.Windows.Forms.TextBox textBox_RF_AntPort_InvCnter8;
        private System.Windows.Forms.ComboBox comboBoxRF_AntPort_Port8;
        private System.Windows.Forms.TextBox textBox_RF_AntPort_InvCnter7;
        private System.Windows.Forms.ComboBox comboBoxRF_AntPort_Port7;
        private System.Windows.Forms.TextBox textBox_RF_AntPort_InvCnter6;
        private System.Windows.Forms.ComboBox comboBoxRF_AntPort_Port6;
        private System.Windows.Forms.TextBox textBox_RF_AntPort_InvCnter5;
        private System.Windows.Forms.ComboBox comboBoxRF_AntPort_Port5;
        private System.Windows.Forms.TextBox textBox_RF_AntPort_InvCnter4;
        private System.Windows.Forms.ComboBox comboBoxRF_AntPort_Port4;
        private System.Windows.Forms.TextBox textBox_RF_AntPort_InvCnter3;
        private System.Windows.Forms.ComboBox comboBoxRF_AntPort_Port3;
        private System.Windows.Forms.TextBox textBox_RF_AntPort_InvCnter2;
        private System.Windows.Forms.ComboBox comboBoxRF_AntPort_Port2;
        private System.Windows.Forms.TextBox textBox_RF_AntPort_InvCnter1;
        private System.Windows.Forms.ComboBox comboBoxRF_AntPort_Port1;
        private System.Windows.Forms.ComboBox comboBox_RF_AntPort_Quantity;
        private System.Windows.Forms.Label label_AntPort_Quantity;
        private System.Windows.Forms.Button button_RF_Ant_Get;
        private System.Windows.Forms.Button button_RF_Ant_Set;
        private System.Windows.Forms.GroupBox groupBox_RF_Ant_Enable;
        private System.Windows.Forms.GroupBox groupBox_RF_Ant_SwitchAnt;
        private System.Windows.Forms.CheckBox checkBox_RF_Ant_Enable8;
        private System.Windows.Forms.CheckBox checkBox_RF_Ant_Enable7;
        private System.Windows.Forms.CheckBox checkBox_RF_Ant_Enable6;
        private System.Windows.Forms.CheckBox checkBox_RF_Ant_Enable5;
        private System.Windows.Forms.CheckBox checkBox_RF_Ant_Enable4;
        private System.Windows.Forms.CheckBox checkBox_RF_Ant_Enable3;
        private System.Windows.Forms.CheckBox checkBox_RF_Ant_Enable2;
        private System.Windows.Forms.CheckBox checkBox_RF_Ant_Enable1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSetModuleSleep;
        private System.Windows.Forms.Button bynSaveConfigToNv;
        private System.Windows.Forms.CheckBox cbxSaveNvConfig;
        private System.Windows.Forms.ComboBox cbxMode;
        private System.Windows.Forms.Button btnSetMode;
        private System.Windows.Forms.GroupBox gbx_setfreq;
        private System.Windows.Forms.TextBox txtChIndexBegin;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox txtChIndexEnd;
        private System.Windows.Forms.Button btnInsertRfCh;
        private System.Windows.Forms.Button btnGetChannel;
        private System.Windows.Forms.Button btnSetRegion;
        private System.Windows.Forms.Button btnSetFhss;
        private System.Windows.Forms.ComboBox cbxChannel;
        private System.Windows.Forms.ComboBox cbxRegion;
        private System.Windows.Forms.Button btnSetFreq;
        private System.Windows.Forms.GroupBox gbxRfPower;
        private System.Windows.Forms.Button btnGetPaPower;
        private System.Windows.Forms.ComboBox cbxPaPower;
        private System.Windows.Forms.Button btnSetPaPower;
        private System.Windows.Forms.Button btnSetCW;
        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.TabPage tabPageImpinjTag;
        private System.Windows.Forms.GroupBox groupBoxMonzaCmds;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button btnMonzaQTWrite;
        private System.Windows.Forms.TextBox tbxMonzaQTAccessPwd;
        private System.Windows.Forms.Button btnMonzaQTRead;
        private System.Windows.Forms.CheckBox cbxMonzaQT_MEM;
        private System.Windows.Forms.CheckBox cbxMonzaQT_SR;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tbxNxpCmdAccessPwd;
        private System.Windows.Forms.CheckBox cbxReadProtectReset;
        private System.Windows.Forms.Button btnChangeConfig;
        private System.Windows.Forms.Button btnReadProtect;
        private System.Windows.Forms.Button btnChangeEas;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.CheckBox cbxSetEas;
        private System.Windows.Forms.TextBox txtConfigData;
        private System.Windows.Forms.Button btnEasAlarm;
        private System.Windows.Forms.Button button_RF_Ant_GetCurrentAntPort;
        private System.Windows.Forms.GroupBox gbx_MTR;
        private System.Windows.Forms.Label lbl_MTR_Qvalue;
        private System.Windows.Forms.ComboBox cbx_MTR_Qvalue;
        private System.Windows.Forms.Label lbl_MTR_Read_Number;
        private System.Windows.Forms.Label lbl_MTR_Algorithm;
        private System.Windows.Forms.ComboBox cbx_MTR_Algorithm;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.GroupBox gbx_MTR_LoopNum;
        private System.Windows.Forms.GroupBox gbxIoControl;
        private System.Windows.Forms.ComboBox cbxIoDircetion;
        private System.Windows.Forms.ComboBox cbxIoLevel;
        private System.Windows.Forms.Button btnSetIoDirection;
        private System.Windows.Forms.Button btnSetIO;
        private System.Windows.Forms.Button btnGetIO;
        private System.Windows.Forms.ComboBox cbxIO;
        private System.Windows.Forms.TextBox textBox_EPC_TagCounter;
        private System.Windows.Forms.TextBox textBox_EPC_Tag_Total;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Button btn_SelectAllSensorTag;
        private System.Windows.Forms.Button btn_SensorTag_StopRead;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.ComboBox cbx_SensorTag_SensorTagType;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label51;
		private System.Windows.Forms.CheckBox checkBox_InvtMulti_AutoClear;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage_TagRead;
        private System.Windows.Forms.TabPage tabPage_SysSetting;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cbxNewBaudRate;
        private System.Windows.Forms.Button btn_SetNewBaudRate;
        private System.Windows.Forms.Button btn_GetNewBaudRate;
        private System.Windows.Forms.Button btnGetFhss;
        private System.Windows.Forms.ComboBox cbxFHSS;
        private System.Windows.Forms.Button btnSetFreqHopPeriod;
        private System.Windows.Forms.ComboBox cbxFhssHopPeriod;
        private System.Windows.Forms.Button btnGetFreqHopPeriod;
		private System.Windows.Forms.GroupBox groupBox_GPIO;
		private System.Windows.Forms.Button button_GPIO_Set;
		private System.Windows.Forms.Button button_GPIO_Get;
		private System.Windows.Forms.GroupBox groupBox_GPI;
		private System.Windows.Forms.CheckBox checkBox_GPI4;
		private System.Windows.Forms.CheckBox checkBox_GPI1;
		private System.Windows.Forms.CheckBox checkBox_GPI3;
		private System.Windows.Forms.CheckBox checkBox_GPI2;
		private System.Windows.Forms.GroupBox groupBox_GPO;
		private System.Windows.Forms.CheckBox checkBox_GPO4;
		private System.Windows.Forms.CheckBox checkBox_GPO3;
		private System.Windows.Forms.CheckBox checkBox_GPO2;
		private System.Windows.Forms.CheckBox checkBox_GPO1;
		private System.Windows.Forms.Button btnGetRegion;
        private System.Windows.Forms.Label label_dllversion;
		private System.Windows.Forms.Button btnInsertRfCh_Get;
        private System.Windows.Forms.GroupBox gbx_InsertRFCH;
        private System.Windows.Forms.Button btnInsertRfCh_Help;
        private System.Windows.Forms.Label label_Acess1;
        private System.Windows.Forms.Label label_Access2;
        private System.Windows.Forms.Label label_Access3;
        private System.Windows.Forms.Label label_Access4;
        private System.Windows.Forms.Label label_EPC_Tag_Total;
        private System.Windows.Forms.Label label_EPC_TagCounter;
        private System.Windows.Forms.DataGridView dataGridViewStockInItems;
        private System.Windows.Forms.Button btnAddBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipment_Reg_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipment_Rfid;
        //private System.IO.Ports.SerialPort ComDevice;
    }
}

