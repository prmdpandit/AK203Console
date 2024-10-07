﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Threading;
using RFID_Reader_Cmds;
using RFID_Reader_Com;
using BarChart;
using System.Globalization;
using ZedGraph;
using AK203.Repository;
using System.Threading.Tasks;
using System.Linq;
using ModuleReader;


namespace RFID_MoudleReader
{

    public partial class Form1 : Form
    {
        private bool bAutoSend = false;

        private int LoopNum_cnt = 0;
        private bool change_q_1st = true;
        private bool change_q_message = true;

        public ReceiveParser rp;

		DataTable basic_table = new DataTable();
		DataTable advanced_table = new DataTable();
		
        DataSet ds_basic = null;
        DataSet ds_advanced = null;

        string pc = string.Empty;
        string epc = string.Empty;
        string crc = string.Empty;
        string rssi = string.Empty;
		string antno = string.Empty;

        int FailEPCNum = 0;
        int SucessEPCNum = 0;
        double errnum = 0;
        double db_errEPCNum = 0;
        double db_LoopNum_cnt = 0;
        string per = "0.000";

        private String timeFormat = "yyyy/MM/dd HH:mm:ss.ff";
        //private String timeFormat = System.Globalization.DateTimeFormatInfo.CurrentInfo.ShortDatePattern.ToString() + " HH:mm:ss.ff";

        static string[] strBuff = new String[4096];

        int rowIndex = 0;
        int initDataTableLen = 1;  //Inital the line number of Datatable

        private static int[] mixerGainTable = {0, 3, 6, 9, 12, 15, 16};

        private static int[] IFAmpGainTable = { 12, 18, 21, 24, 27, 30, 36, 40 };

		private static byte ReaderDeviceAddress =ConstCode.READER_DEVICEADDR_BROADCAST;//0xFF;
        private bool appEnableFlag= false;

        // New added work start
        private readonly IUnitOfWork unitOfWork;
        //private UnitOfWork unitOfWork;
        //List<Item_Register> items = new List<Item_Register>();
        //List<Slots> Slots = new List<Slots>();
        // end fo new work

        public Form1(IUnitOfWork _unitOfWork)
        {
            InitializeComponent();
            setTip();
            unitOfWork = _unitOfWork;
            dataGridViewStockInItems.AutoGenerateColumns = false;
            this.cbxFHSS.SelectedIndex = 0;
			this.cbxFhssHopPeriod.SelectedIndex = 1;
            this.cbxRegion.SelectedIndex = 0;
            this.cbxChannel.SelectedIndex = 0;
            this.cbxBaudRate.SelectedIndex = 5;
            this.cbxDR.SelectedIndex = 0;
            this.cbxM.SelectedIndex = 0;
            this.cbxTRext.SelectedIndex = 1;
            this.cbxSel.SelectedIndex = 0;
            this.cbxSession.SelectedIndex = 0;
            this.cbxTarget.SelectedIndex = 0;
            this.cbxQBasic.SelectedIndex = 1;
            this.cbxQAdv.SelectedIndex = 4;
            this.cbxMemBank.SelectedIndex = 3;
            this.cbxSelTarget.SelectedIndex = 0;
            this.cbxAction.SelectedIndex = 0;
            this.cbxSelMemBank.SelectedIndex = 1;
            this.cbxPaPower.SelectedIndex = 0;
            this.cbxMixerGain.SelectedIndex = 3;
            this.cbxIFAmpGain.SelectedIndex = 6;
            this.cbxMode.SelectedIndex = 0;
            this.cbxIO.SelectedIndex = 0;
            this.cbxIoLevel.SelectedIndex = 0;
            this.cbxIoDircetion.SelectedIndex = 0;
            this.cbxLockKillAction.SelectedIndex = 0;
            this.cbxLockAccessAction.SelectedIndex = 0;
            this.cbxLockEPCAction.SelectedIndex = 0;
            this.cbxLockTIDAction.SelectedIndex = 0;
            this.cbxLockUserAction.SelectedIndex = 0;
            tabControl1.TabPages.Remove(tabPageSysSetting);
            tabControl1.TabPages.Remove(tabPageAccessTag);
            tabControl1.TabPages.Remove(tabPageSensorTag);
            tabControl1.TabPages.Remove(tabPageTMS);
            tabControl1.TabPages.Remove(tabPageImpinjTag);

            Ant_Inital();
        }
        // start new code logic function
        //private void LoadLocations()
        //{
        //    try
        //    {
        //        var locations = unitOfWork.LocationRepository.Get().ToList();
        //        cmbLocation.DataSource = locations;
        //        cmbLocation.DisplayMember = "Location_Name"; // This is the property to display in the ComboBox
        //        cmbLocation.ValueMember = "Id"; // This is the property that will be used as the value
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred while loading locations: " + ex.Message);
        //    }
        //}

        //private void LoadWeaponType()
        //{
        //    try
        //    {
        //        var weaponType = unitOfWork.GunCategoryRepository.Get().ToList();
        //        cmbWeaponType.DataSource = weaponType ;
        //        cmbWeaponType.DisplayMember = "Category_Name"; // This is the property to display in the ComboBox
        //        cmbWeaponType.ValueMember = "Id"; // This is the property that will be used as the value
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred while loading weapon: " + ex.Message);
        //    }
        //}

        //private void LoadSlot()
        //{
        //    try
        //    {
        //        var slots = unitOfWork.SlotRepository.Get().ToList();
        //        cmbSlotLocation.DataSource = slots;
        //        cmbSlotLocation.DisplayMember = "Slot_No"; // This is the property to display in the ComboBox
        //        cmbSlotLocation.ValueMember = "Id"; // This is the property that will be used as the value
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred while loading slot: " + ex.Message);
        //    }
        //}

        //private void LoadGun()
        //{
        //    try
        //    {
        //        var gunName = unitOfWork.ItemRepository.Get().ToList();
        //        cmbGunName.DataSource = gunName;
        //        cmbGunName.DisplayMember = "gun_name"; // This is the property to display in the ComboBox
        //        cmbGunName.ValueMember = "Id"; // This is the property that will be used as the value
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred while loading Gun: " + ex.Message);
        //    }
        //}

        //private void LoadRegisterGun()
        //{
        //    try
        //    {
        //        items = unitOfWork.ItemRegisterRepository.Get().ToList();
                
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred while loading item: " + ex.Message);
        //    }
        //}

        //private void LoadSlotNo()
        //{
        //    try
        //    {
        //        Slots = unitOfWork.SlotRepository.Get().ToList();

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred while loading item: " + ex.Message);
        //    }
        //}

        //private void AddItemRegister()
        //{
        //    var itemRegister = new Item_Register
        //    {
        //        Reg_No = txtRegNo.Text,
        //        Rfid = epc,
        //        Item_Id = 1,
        //        Slot_Id = Convert.ToInt32(cmbSlotLocation.SelectedValue.ToString()),
        //        Location_Id = Convert.ToInt32(cmbLocation.SelectedValue.ToString())

        //    };
        //    if (!items.Any(item => item.Rfid == itemRegister.Rfid || item.Reg_No == itemRegister.Reg_No||item.Slot_Id==itemRegister.Slot_Id))
        //    {
        //        unitOfWork.ItemRegisterRepository.Insert(itemRegister);
        //        if (itemRegister.Rfid != string.Empty)
        //        {
        //            unitOfWork.Save();
        //            MessageBox.Show("Succefuly add gun");
        //            txtepctagid.Clear();
        //            LoadRegisterGun();
        //        }
        //        else
        //            MessageBox.Show("Please enter rfid");
               
        //    }
        //    else
        //    {
        //        MessageBox.Show("Already exist rfid regno and slot");
        //    }
           
        //}
        //end new code logic


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStockInComboBox();
         
            //LoadLocations();
            //LoadWeaponType();
            //LoadSlot();
            //LoadGun();
            //LoadRegisterGun();
            //LoadSlot();

            //lblVersion.Text += AssemblyLib.AssemblyVersion;
            //get all available serial port list
            string[] ports = Sp.GetInstance().GetPortNames();
            foreach (string port in ports)
            {
                cbxPort.Items.Add(port);
            }
            if (cbxPort.Items.Count > 0)
            {
                cbxPort.SelectedIndex = 0;
                btnConn.Enabled = true;
            }
            cbxBaudRate.SelectedIndex = 5;//2018-11-08
            cbxNewBaudRate.SelectedIndex = cbxBaudRate.SelectedIndex;//2018-11-08

			int i;
			for(i=0;i<255;i++)
			{
				cbxDeviceAddr.Items.Add(i.ToString("D03"));
                cbxNewDeviceAddr.Items.Add(i.ToString("D03"));
			}
			i=255;
			cbxDeviceAddr.Items.Add(i.ToString("D03")+" Broadcast");
			cbxDeviceAddr.SelectedIndex=255;//Default to use Broadcast Address to conncect the Reader, if we do not know the Reader's device address.
            cbxNewDeviceAddr.SelectedIndex = 0;
			ReaderDeviceAddress = (byte)cbxDeviceAddr.SelectedIndex;
			Commands.ReaderDeviceAddr = ReaderDeviceAddress;
			
            //ComDevice.DataReceived += new SerialDataReceivedEventHandler(ComDevice_DataReceived);
            rp = new ReceiveParser();
            Sp.GetInstance().ComDevice.DataReceived += new SerialDataReceivedEventHandler(rp.DataReceived);
            rp.PacketReceived +=new EventHandler<StrArrEventArgs>(rp_PaketReceived);
            Sp.GetInstance().DataSent += new EventHandler<byteArrEventArgs>(ComDataSent);
			
			//-----------------------------------------			
            this.dgvEpcBasic.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dgvEpcBasic_DataBindingComplete);
            this.dgv_epc2.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dgv_epc2_DataBindingComplete);
            //ComDevice.NewLine = "/r/n";
            change_q_1st = false;

            //DataGridView
            ds_basic = new DataSet();
            ds_advanced = new DataSet();
            //dt = new DataTable();

            basic_table = BasicGetEPCHead();
            advanced_table = AdvancedGetEPCHead();
            ds_basic.Tables.Add(basic_table);
            ds_advanced.Tables.Add(advanced_table);

            DataView BasicDataViewEpc = ds_basic.Tables[0].DefaultView;
            DataView AdvancedDataViewEpc = ds_advanced.Tables[0].DefaultView;
            this.dgvEpcBasic.DataSource = BasicDataViewEpc;
            this.dgv_epc2.DataSource = AdvancedDataViewEpc;
            Basic_DGV_ColumnsWidth(this.dgvEpcBasic);
            Advanced_DGV_ColumnsWidth(this.dgv_epc2);
            btnInvtBasic.Focus();

            adjustUIcomponents("M100");

			SensorTag_Inital();//
			Zed_Inital();

            ReadTagInital();

            byte MainVer=0,MtypeVer=0, MinorVer=0;
            Commands.GetDllVersion(ref MainVer, ref MtypeVer, ref MinorVer);
            string strDllVer = MainVer.ToString("X02") + "." + MtypeVer.ToString("X02") + "." + MinorVer.ToString("X02");
            setToolStripStatusMessage1("UHF RFID Reader Demo. DLL Version: "+strDllVer, Color.Red);
        }

		//-----------------------------------------------------
        private delegate void SetTextBoxDelegate(object sender, string strtext);
         private void setTextBoxInvoke(object sender,string strtext)
         {
             if (this.txtSend.InvokeRequired)
             {
                 SetTextBoxDelegate md = new SetTextBoxDelegate(this.setTextBoxInvoke);
                 this.Invoke(md, new object[] {sender, strtext });
             }
             else
                ( (TextBox)sender).Text = strtext;
         }
		 //----------------------------------------------------
        private void ComDataSent(object sender, byteArrEventArgs e)
        {
            //txtCOMTxCnt.Text = (Convert.ToInt32(txtCOMTxCnt.Text) + e.Data.Length).ToString();
            //txtCOMTxCnt_adv.Text = txtCOMTxCnt.Text;
			string strCnt = (Convert.ToInt32(txtCOMTxCnt.Text) + e.Data.Length).ToString();
            setTextBoxInvoke(txtCOMTxCnt, strCnt);
			setTextBoxInvoke(txtCOMTxCnt_adv, strCnt);
        }
		
		#region show received packet
		private void rp_PacketFail(string FailCode,string rxstrLen, string [] strParam)
		{
			int failType = Convert.ToInt32(FailCode, 16);
			int rxlen = Convert.ToInt32(rxstrLen, 16);
			if (rxlen > 7) // has PC+EPC field
			{
				txtOperateEpc.Text = "";
				int pcEpcLen = Convert.ToInt32(strParam[0], 16);

				for (int i = 0; i < pcEpcLen; i++)
				{
                    txtOperateEpc.Text += strParam[i + 1] + " ";
				}
			}
			else
			{
				txtOperateEpc.Text = "";
			}
			
			if (FailCode == ConstCode.FAIL_INVENTORY_TAG_TIMEOUT)
			{
				FailEPCNum = FailEPCNum + 1;
				db_errEPCNum = FailEPCNum;
				db_LoopNum_cnt = db_LoopNum_cnt + 1;
				errnum = (db_errEPCNum / db_LoopNum_cnt) * 100;
				per = string.Format("{0:0.000}", errnum);
				//GetEPC(pc, epc, crc, rssi_i, rssi_q, per);
				pbx_Inv_Indicator.Visible = false;
			}
			else if (FailCode == ConstCode.FAIL_FHSS_FAIL)
			{
				//MessageBox.Show("FHSS Failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				setStatus("FHSS Failed", Color.Red);
			}
            else if (FailCode == ConstCode.FAIL_ANT_NOT_AVAILABLE)
            {
                //MessageBox.Show("FHSS Failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                setStatus("Switch Antenna Port Failed! Please check the Antenna Setting.", Color.Red);
            }
			else if (FailCode == ConstCode.FAIL_ACCESS_PWD_ERROR)
			{
				//MessageBox.Show("Access Failed, Please Check the Access Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				setStatus("Access Failed, Please Check the Access Password", Color.Red);
			}
			else if (FailCode == ConstCode.FAIL_READ_MEMORY_NO_TAG)
			{
				setStatus("No Tag Response, Fail to Read Tag Memory", Color.Red);
			}
			else if (FailCode.Substring(0,1) == ConstCode.FAIL_READ_ERROR_CODE_BASE.Substring(0,1))
			{
				//MessageBox.Show("Read Failed. Error Code: " + ParseErrCode(failType), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				setStatus("Read Failed. Error Code: " + ParseErrCode(failType), Color.Red);
			}
			else if (FailCode == ConstCode.FAIL_WRITE_MEMORY_NO_TAG)
			{
				//MessageBox.Show("No Tag Response, Fail to Write Tag Memory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				setStatus("No Tag Response, Fail to Write Tag Memory", Color.Red);
			}
			else if (FailCode.Substring(0, 1) == ConstCode.FAIL_WRITE_ERROR_CODE_BASE.Substring(0, 1))
			{
				//MessageBox.Show("Write Failed. Error Code: " + ParseErrCode(failType), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				setStatus("Write Failed. Error Code: " + ParseErrCode(failType), Color.Red);
			}
			else if (FailCode == ConstCode.FAIL_LOCK_NO_TAG)
			{
				//MessageBox.Show("No Tag Response, Lock Operation Failed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				setStatus("No Tag Response, Lock Operation Failed", Color.Red);
			}
			else if (FailCode.Substring(0, 1) == ConstCode.FAIL_LOCK_ERROR_CODE_BASE.Substring(0, 1))
			{
				//MessageBox.Show("Lock Failed. Error Code: " + ParseErrCode(failType), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				setStatus("Lock Failed. Error Code: " + ParseErrCode(failType), Color.Red);
			}
			else if (FailCode == ConstCode.FAIL_KILL_NO_TAG)
			{
				//MessageBox.Show("No Tag Response, Kill Operation Failed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				setStatus("No Tag Response, Kill Operation Failed", Color.Red);
			}
			else if (FailCode.Substring(0, 1) == ConstCode.FAIL_KILL_ERROR_CODE_BASE.Substring(0, 1))
			{
				//MessageBox.Show("Kill Failed. Error Code: " + ParseErrCode(failType), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				setStatus("Kill Failed. Error Code: " + ParseErrCode(failType), Color.Red);
			}
			else if (FailCode == ConstCode.FAIL_NXP_CHANGE_CONFIG_NO_TAG)
			{
				//MessageBox.Show("No Tag Response, NXP Change Config Failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				setStatus("No Tag Response, NXP Change Config Failed", Color.Red);
			}
			else if (FailCode == ConstCode.FAIL_NXP_CHANGE_EAS_NO_TAG)
			{
				//MessageBox.Show("No Tag Response, NXP Change EAS Failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				setStatus("No Tag Response, NXP Change EAS Failed", Color.Red);
			}
			else if (FailCode == ConstCode.FAIL_NXP_CHANGE_EAS_NOT_SECURE)
			{
				//MessageBox.Show("Tag is not in Secure State, NXP Change EAS Failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				setStatus("Tag is not in Secure State, NXP Change EAS Failed", Color.Red);
			}
			else if (FailCode == ConstCode.FAIL_NXP_EAS_ALARM_NO_TAG)
			{
				//MessageBox.Show("No Tag Response, NXP EAS Alarm Operation Failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtOperateEpc.Text = "";
				setStatus("No Tag Response, NXP EAS Alarm Operation Failed", Color.Red);
			}
			else if (FailCode == ConstCode.FAIL_NXP_READPROTECT_NO_TAG)
			{
				//MessageBox.Show("No Tag Response, NXP ReadProtect Failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				setStatus("No Tag Response, NXP ReadProtect Failed", Color.Red);
			}
			else if (FailCode == ConstCode.FAIL_NXP_RESET_READPROTECT_NO_TAG)
			{
				//MessageBox.Show("No Tag Response, NXP Reset ReadProtect Failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				setStatus("No Tag Response, NXP Reset ReadProtect Failed", Color.Red);
			}
			else if (FailCode == "2E") // QT Read/Write Failed
			{
				setStatus("No Tag Response, QT Command Failed", Color.Red);
			}
			else if (FailCode.Substring(0, 1) == ConstCode.FAIL_CUSTOM_CMD_BASE.Substring(0, 1))
			{
				//MessageBox.Show("Command Executed Failed. Error Code: " + ParseErrCode(failType), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				setStatus("Command Executed Failed. Error Code: " + ParseErrCode(failType), Color.Red);
			}
			else if (FailCode == ConstCode.FAIL_INVALID_PARA)
			{
				MessageBox.Show("Invalid Parameters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (FailCode == ConstCode.FAIL_INVALID_CMD)
			{
				MessageBox.Show("Invalid Command!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (FailCode == ConstCode.FAIL_SUBCMD_UNDEF)
			{
				MessageBox.Show("Invalid Sub Command!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (FailCode == ConstCode.FAIL_MAINCMD_UNDEF)
			{
				MessageBox.Show("Invalid Main Command!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
            else if (FailCode == ConstCode.FAIL_COMMAND_CRC)//2019-05-10
            {
                setStatus("API command Crc is Error!", Color.Red);
            }
            else if (FailCode == ConstCode.FAIL_PARAMETER_FAIL)//2019-05-10
            {
                setStatus("Set or Get Reader Parameter is failed!", Color.Red);
            }
            else if (FailCode == ConstCode.FAIL_READER_FAIL)//2019-05-10
            {
                setStatus("Set Reader operation is failed1", Color.Red);
            }
            else if (FailCode == ConstCode.FAIL_TAG_FAIL)//2019-05-10
            {
                setStatus("Access Tag operation is failed!", Color.Red);
            }
			
		}
		private void rp_PaketOK(Commands.ReaderResponseFrameString rxStrPkts)
		{
			setStatus("", Color.MediumSeaGreen);
            setToolStripStatusMessage1("", Color.Purple);
			if (rxStrPkts.strCmdH== ConstCode.CMD_EXE_FAILED)
			{
                        
			}
            else if (rxStrPkts.strCmdH == ConstCode.CMD_SET_QUERY_PARA)            //SetQuery
			{
				MessageBox.Show("Query Parameters has set up", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
            else if (rxStrPkts.strCmdH == ConstCode.CMD_GET_QUERY_PARA)            //GetQuery
			{
				string infoGetQuery = string.Empty;
				string[] strMSB = String16toString2(rxStrPkts.strParameters[0]);
				string[] strLSB = String16toString2(rxStrPkts.strParameters[1]);
				int intQ = Convert.ToInt32(strLSB[6]) * 8 + Convert.ToInt32(strLSB[5]) * 4
                            + Convert.ToInt32(strLSB[4]) * 2 + Convert.ToInt32(strLSB[3]);
				string strM = string.Empty;
				if ((strMSB[6] + strMSB[5]) == "00")
				{
					strM = "1";
				}
				else if ((strMSB[6] + strMSB[5]) == "01")
				{
					strM = "2";
				}
				else if ((strMSB[6] + strMSB[5]) == "10")
				{
					strM = "4";
				}
				else if ((strMSB[6] + strMSB[5]) == "11")
				{
					strM = "8";
				}
				string strTRext = string.Empty;
				if (strMSB[4] == "0")
				{
					strTRext = "NoPilot";
				}
				else
				{
					strTRext = "UsePilot";
				}
				string strTarget = string.Empty;
				if (strLSB[7] == "0")
				{
					strTarget = "A";
				}
				else
				{
					strTarget = "B";
				}
				infoGetQuery = "DR=" + strMSB[7] + ", ";
				infoGetQuery = infoGetQuery + "M=" + strM + ", ";
				infoGetQuery = infoGetQuery + "TRext=" + strTRext + ", ";
				infoGetQuery = infoGetQuery + "Sel=" + strMSB[3] + strMSB[2] + ", ";
				infoGetQuery = infoGetQuery + "Session=" + strMSB[1] + strMSB[0] + ", ";
				infoGetQuery = infoGetQuery + "Target=" + strTarget + ", ";
				infoGetQuery = infoGetQuery + "Q=" + intQ;
				MessageBox.Show(infoGetQuery, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
            else if (rxStrPkts.strCmdH == ConstCode.CMD_INVENTORY || rxStrPkts.strCmdH == ConstCode.CMD_MULTI_ID)         //Succeed to Read EPC    
			{
				//Console.Beep();
				SucessEPCNum = SucessEPCNum + 1;
				db_errEPCNum = FailEPCNum;
				db_LoopNum_cnt = db_LoopNum_cnt + 1;
				errnum = (db_errEPCNum / db_LoopNum_cnt) * 100;
				per = string.Format("{0:0.000}", errnum);

				int rssidBm = Convert.ToInt16(rxStrPkts.strParameters[0], 16); // rssidBm is negative && in bytes
				if (rssidBm > 127)
				{
					rssidBm = -((-rssidBm)&0xFF);
				}
				rssidBm -= Convert.ToInt32(tbxCoupling.Text, 10);
				rssidBm -= Convert.ToInt32(tbxAntennaGain.Text, 10);
				rssi = rssidBm.ToString();

				int PCEPCLength = ((Convert.ToInt32((rxStrPkts.strParameters[1]), 16)) / 8 + 1) * 2;
				pc = rxStrPkts.strParameters[1] + " " + rxStrPkts.strParameters[2];
				epc = string.Empty;
				for (int i = 0; i < PCEPCLength - 2; i++)
				{
					epc = epc + rxStrPkts.strParameters[3 + i];
				}
				epc = Commands.AutoAddSpace(epc);
				crc = rxStrPkts.strParameters[1 + PCEPCLength] + " " + rxStrPkts.strParameters[2 + PCEPCLength];

				antno = rxStrPkts.strParameters[3 + PCEPCLength];

                if (bSensorTag_InventoryFlag == false)
                {
                    
                    textBoxEquipmentRFID.Text = epc;

                    //GetEPC(pc, epc, crc, rssi, antno, per);
                }
                else
                    SensorTag_GetEPC(pc, epc, crc, rssi, per);
                //txtRegRFID.Text = txtepctagid.Text + " " + txtRegNo.Text;
            }//
            else if (rxStrPkts.strCmdH == ConstCode.CMD_STOP_MULTI)         //
			{
				string strStatus=rxStrPkts.strParameters[0]+rxStrPkts.strParameters[1]+rxStrPkts.strParameters[2]+rxStrPkts.strParameters[3];
				string strStatus1 = DataConvert.HexToDec(strStatus);

				int ReadTagNumber= Convert.ToInt32(strStatus1);

                this.btnInvtMulti.UseVisualStyleBackColor = true;//2019-04-18
                setStatus("Stop Read Multi-Tag!", Color.MediumSeaGreen);
                setToolStripStatusMessage2("Tag Counter:" + ReadTagNumber.ToString(), Color.MediumBlue);
            }
			else if (rxStrPkts.strCmdH == ConstCode.CMD_READ_DATA)         //Read Tag Memory
			{
				string strInvtReadData = "";
				txtInvtRWData.Text = "";
				txtOperateEpc.Text = "";
				int dataLen = Convert.ToInt32(rxStrPkts.strLength, 16);
				int pcEpcLen = Convert.ToInt32(rxStrPkts.strParameters[0], 16);

				for (int i = 0; i < pcEpcLen; i++)
				{
					txtOperateEpc.Text += rxStrPkts.strParameters[i + 1] + " ";
				}

				//for (int i = 0; i < dataLen - pcEpcLen - 1; i++)
				dataLen = dataLen -6;
                dataLen = dataLen - pcEpcLen;
                dataLen = dataLen - 2;// -1;
				for (int i = 0; i < dataLen; i++)
				{
					strInvtReadData = strInvtReadData + rxStrPkts.strParameters[i + pcEpcLen + 1];
				}
				txtInvtRWData.Text = Commands.AutoAddSpace(strInvtReadData);
                setStatus("Read Memory Success:" + txtInvtRWData.Text, Color.MediumSeaGreen);
			}
			else if (rxStrPkts.strCmdH == ConstCode.CMD_RFM_TAG)         //Read RFM Tag Memory    SureLion
			{
				
				setStatus("Read RFM Memory Success", Color.MediumSeaGreen);
			}
			else if(rxStrPkts.strCmdH == ConstCode.CMD_SENSORTAG_READ)   // Read Sensor Tag     //SureLion
			{
				SensorTag_MessageProcessOK(rxStrPkts);
				//setToolStripStatusMessage1("Readed a Sensor Tag! ", Color.MediumSeaGreen);
			}
			else if (rxStrPkts.strCmdH == ConstCode.CMD_WRITE_DATA)
			{
				//MessageBox.Show("Write Memory Success!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
				getSuccessTagEpc(rxStrPkts.strParameters);
                setStatus("Write Memory Success:" + txtInvtRWData.Text, Color.MediumSeaGreen);
			}
			else if (rxStrPkts.strCmdH == ConstCode.CMD_LOCK_UNLOCK)
			{
				//MessageBox.Show("Lock Success!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
				getSuccessTagEpc(rxStrPkts.strParameters);
				setStatus("Lock Success", Color.MediumSeaGreen);
			}
			else if (rxStrPkts.strCmdH == ConstCode.CMD_KILL)
			{
				//MessageBox.Show("Kill Success!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
				getSuccessTagEpc(rxStrPkts.strParameters);
				setStatus("Kill Success", Color.MediumSeaGreen);
			}
			else if (rxStrPkts.strCmdH == ConstCode.CMD_NXP_CHANGE_CONFIG)
			{
				int pcEpcLen = getSuccessTagEpc(rxStrPkts.strParameters);
				string configWord = rxStrPkts.strParameters[pcEpcLen + 1] + rxStrPkts.strParameters[pcEpcLen + 2];
				setStatus("NXP Tag Change Config Success, Config Word: 0x" + configWord, Color.MediumSeaGreen);
			}
			else if (rxStrPkts.strCmdH == ConstCode.CMD_NXP_CHANGE_EAS)
			{
				getSuccessTagEpc(rxStrPkts.strParameters);
				setStatus("NXP Tag Change EAS Success", Color.MediumSeaGreen);
			}
			else if (rxStrPkts.strCmdH == ConstCode.CMD_NXP_READPROTECT)
			{
				getSuccessTagEpc(rxStrPkts.strParameters);
				setStatus("NXP Tag ReadProtect Success", Color.MediumSeaGreen);
			}
			else if (rxStrPkts.strCmdH == ConstCode.CMD_NXP_RESET_READPROTECT)
			{
				getSuccessTagEpc(rxStrPkts.strParameters);
				setStatus("NXP Tag Reset ReadProtect Success", Color.MediumSeaGreen);
			}
			else if (rxStrPkts.strCmdH == ConstCode.CMD_NXP_EAS_ALARM)
			{
				setStatus("NXP Tag EAS Alarm Success", Color.MediumSeaGreen);
			}
			else if (rxStrPkts.strCmdH == ConstCode.CMD_IPJ_MONZA_QT_READ) // Monza tag QT Read command response
			{
				int pcEpcLen = getSuccessTagEpc(rxStrPkts.strParameters);
				string QTcontrol = rxStrPkts.strParameters[pcEpcLen + 1] + rxStrPkts.strParameters[pcEpcLen + 2];
				int controlWord = Convert.ToUInt16(QTcontrol, 16);
				string QT_SR = ((controlWord & 0x8000) == 0) ? "0" : "1";
				string QT_MEM = ((controlWord & 0x4000) == 0) ? "0" : "1";
				setStatus("QT Read Success, QT Control Word: 0x" + QTcontrol + ", QT_SR=" + QT_SR + ", QT_MEM=" + QT_MEM, Color.MediumSeaGreen);
			}
			else if (rxStrPkts.strCmdH == ConstCode.CMD_IPJ_MONZA_QT_WRITE) // Monza tag QT Write command response
			{
				getSuccessTagEpc(rxStrPkts.strParameters);
				setStatus("QT Write Success", Color.MediumSeaGreen);
			}
			else if (rxStrPkts.strCmdH == ConstCode.CMD_GET_SELECT_PARA)            //GetQuery
			{
				string infoGetSelParam = string.Empty;
				string[] strSelCombParam = String16toString2(rxStrPkts.strParameters[0]);
				string strSelTarget = strSelCombParam[7] + strSelCombParam[6] + strSelCombParam[5];
				string strSelAction = strSelCombParam[4] + strSelCombParam[3] + strSelCombParam[2];
				string strSelMemBank = strSelCombParam[1] + strSelCombParam[0];

				string strSelTargetInfo = null;
				if (strSelTarget == "000")
				{
					strSelTargetInfo = "S0";
				}
				else if (strSelTarget == "001")
				{
					strSelTargetInfo = "S1";
				}
				else if (strSelTarget == "010")
				{
					strSelTargetInfo = "S2";
				}
				else if (strSelTarget == "011")
				{
					strSelTargetInfo = "S3";
				}
				else if (strSelTarget == "100")
				{
					strSelTargetInfo = "SL";
				}
				else
				{
					strSelTargetInfo = "RFU";
				}

				string strSelMemBankInfo = null;
				if (strSelMemBank == "00")
				{
					strSelMemBankInfo = "RFU";
				}
				else if (strSelMemBank == "01")
				{
					strSelMemBankInfo = "EPC";
				}
				else if (strSelMemBank == "10")
				{
					strSelMemBankInfo = "TID";
				}
				else
				{
					strSelMemBankInfo = "User";
				}
				infoGetSelParam = "Target=" + strSelTargetInfo + ", Action=" + strSelAction + ", Memory Bank=" + strSelMemBankInfo;
				infoGetSelParam = infoGetSelParam + ", Pointer=0x" + rxStrPkts.strParameters[1] + rxStrPkts.strParameters[2] + rxStrPkts.strParameters[3] + rxStrPkts.strParameters[4];
				infoGetSelParam = infoGetSelParam + ", Length=0x" + rxStrPkts.strParameters[5];
				string strTruncate = null;
				if (rxStrPkts.strParameters[6] == "00")
				{
					strTruncate = "Disable Truncation";
				}
				else
				{
					strTruncate = "Enable Truncation";
				}
				infoGetSelParam = infoGetSelParam + ", " + strTruncate;

				this.txtGetSelLength.Text = rxStrPkts.strParameters[5];

				string strGetSelMask = null;
				int intGetSelMaskByte = Convert.ToInt32(rxStrPkts.strParameters[5], 16) / 8;
				int intGetSelMaskBit = Convert.ToInt32(rxStrPkts.strParameters[5], 16) - intGetSelMaskByte * 8;
				if (intGetSelMaskBit == 0)
				{
					for (int i = 0; i < intGetSelMaskByte; i++)
					{
						strGetSelMask = strGetSelMask + rxStrPkts.strParameters[7 + i];
					}
				}
				else
				{
					for (int i = 0; i < intGetSelMaskByte + 1; i++)
					{
						strGetSelMask = strGetSelMask + rxStrPkts.strParameters[7 + i];
					}
				}

				this.txtGetSelMask.Text = Commands.AutoAddSpace(strGetSelMask);
				MessageBox.Show(infoGetSelParam, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
            else if (rxStrPkts.strCmdH == ConstCode.CMD_SET_REGION)
            {
				curRegion = GetRegionValueFromUI(cbxRegion.SelectedIndex);
				ChangedRFchannelTableFromFreqRegion(cbxRegion.SelectedIndex);
                setToolStripStatusMessage1("Set RF Region Successed!", Color.Purple);
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_GET_REGION)
            {//2019-04-18
                string strRegion="";
                int iRFregionIndex = Convert.ToInt32(rxStrPkts.strParameters[0], 16);
                //curRegion = GetRegionValueFromUI(iRFregionIndex);  BUG!!!!
                curRegion = rxStrPkts.strParameters[0];
                switch (iRFregionIndex)
                {
                    case 1:	 // China 2
                        cbxRegion.SelectedIndex = 0;
                        strRegion = "China2";
                        break;
                    case 4:	 // China 1
                        cbxRegion.SelectedIndex = 1; //2019-04-18
                        strRegion = "China1";
                        break;
                    case 2:	// US
                        cbxRegion.SelectedIndex = 2;
                        strRegion = "US";
                        break;
                    case 3:	 // Europe
                        cbxRegion.SelectedIndex = 3;
                        strRegion = "Europe";
                        break;
                    case 6:	 // Korea
                        cbxRegion.SelectedIndex = 4;
                        strRegion = "Korea";
                        break;
                    default:
                        cbxRegion.SelectedIndex = 0;
                        strRegion = "Unknow";
                        break;
                }
                //OR
                switch (rxStrPkts.strParameters[0])
                {
                    case ConstCode.REGION_CODE_CHN2:	 // China 2
                        cbxRegion.SelectedIndex = 0;
                        strRegion = "China2";
                        break;
                    case ConstCode.REGION_CODE_CHN1:	 // China 1
                        cbxRegion.SelectedIndex = 1;  //2019-04-18
                        strRegion = "China1";
                        break;
                    case ConstCode.REGION_CODE_US:	// US
                        cbxRegion.SelectedIndex = 2;
                        strRegion = "US";
                        break;
                    case ConstCode.REGION_CODE_EUR:	 // Europe
                        cbxRegion.SelectedIndex = 3;
                        strRegion = "Europe";
                        break;
                    case ConstCode.REGION_CODE_KOREA:	 // Korea
                        cbxRegion.SelectedIndex = 4;
                        strRegion = "Korea";
                        break;
                    default:
                        cbxRegion.SelectedIndex = 0;
                        strRegion = "Unknow";
                        break;
                }
				
				
				ChangedRFchannelTableFromFreqRegion(cbxRegion.SelectedIndex);
                setToolStripStatusMessage1("Get RF Region Successed! {Index=" + rxStrPkts.strParameters[0]+"-"+strRegion+"}", Color.Purple);
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_SET_RF_CHANNEL)
            {
                setToolStripStatusMessage1("Set RF Channel Successed!", Color.Purple);
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_GET_RF_CHANNEL)
            {
				double curRfChIndex = Convert.ToInt32(rxStrPkts.strParameters[0], 16);
				double curRfCh;
                switch (curRegion)
                {
                    case ConstCode.REGION_CODE_CHN2: // China 2
						curRfCh = 920.125 + curRfChIndex * 0.25;
                        break;
                    case ConstCode.REGION_CODE_CHN1: // China 1
						curRfCh = 840.125 + curRfChIndex * 0.25;
                        break;
                    case ConstCode.REGION_CODE_US: // US
						curRfCh = 902.25 + curRfChIndex * 0.5;
                        break;
                    case ConstCode.REGION_CODE_EUR: // Europe
						curRfCh = 865.1 + curRfChIndex * 0.2;
                        break;
                    case ConstCode.REGION_CODE_KOREA:  // Korea
						curRfCh = 917.1 + curRfChIndex * 0.2;
                        break;
                    default:
						curRfCh = 0.0;
                        break;
                }
				cbxChannel.SelectedIndex = (int)curRfChIndex;
                //MessageBox.Show("Current RF Channel is " + curRfCh + " MHz", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				setToolStripStatusMessage1("Current RF Channel is " + curRfCh + " MHz", Color.Purple);
            }
			else if (rxStrPkts.strCmdH == ConstCode.CMD_SET_FHSS)
			{ //2019-01-26
				string strFh;
				if (rxStrPkts.strCmdL == "00")
				{
					if (rxStrPkts.strParameters[0] == ConstCode.SET_OFF)
						setToolStripStatusMessage1("Set RF FHSS On/Off Successed! (FHSS Off)", Color.Purple);
					else
						setToolStripStatusMessage1("Set RF FHSS On/Off Successed! (FHSS On)", Color.Purple);
				}
				else if (rxStrPkts.strCmdL == "01")
				{
					if (rxStrPkts.strParameters[0] == ConstCode.SET_OFF)
					{
						setToolStripStatusMessage1("Get RF FHSS On/Off Successed! (FHSS Off)", Color.Purple);
						cbxFHSS.SelectedIndex = 0;
					}
					else
					{
						setToolStripStatusMessage1("Get RF FHSS On/Off Successed! (FHSS On)", Color.Purple);
						cbxFHSS.SelectedIndex = 1;
					}
				}
				else if (rxStrPkts.strCmdL == "02")
				{ //Set Freqency Hopping Period
					strFh = rxStrPkts.strParameters[0] + rxStrPkts.strParameters[1];
					uint nFh = Convert.ToUInt16(strFh, 16);
					cbxFhssHopPeriod.SelectedIndex =(int)( nFh / 100)-1; //100mS

					strFh = string.Format("{0:D}mS", nFh);
					setToolStripStatusMessage1("Set RF FHSS Period Successed! " + strFh, Color.Purple);					
				}
				else if (rxStrPkts.strCmdL == "03")
				{  //Get Freqency Hopping Period
					strFh = rxStrPkts.strParameters[0] + rxStrPkts.strParameters[1];
					uint nFh = Convert.ToUInt16(strFh, 16);
					cbxFhssHopPeriod.SelectedIndex = (int)(nFh / 100)-1; //100mS

					strFh = string.Format("{0:D}mS", nFh);
					setToolStripStatusMessage1("Get RF FHSS Period Successed! " + strFh, Color.Purple);
				}
			}
            else if (rxStrPkts.strCmdH == ConstCode.CMD_INSERT_FHSS_CHANNEL)
			{
                //setToolStripStatusMessage1("Set Current RF Power is OK!", Color.Purple);
                if (rxStrPkts.strCmdL == "00")
                {
                    setToolStripStatusMessage1("Insert RF channel in the current range of RF region  is OK! ", Color.Purple);
                }
                else if (rxStrPkts.strCmdL == "01")
                {
                    uint RFchnlInrNum = Convert.ToUInt16(rxStrPkts.strParameters[0], 16);
                    uint RFchnlBegin = Convert.ToUInt16(rxStrPkts.strParameters[1], 16);
                    uint RFchnlEnd = RFchnlBegin + RFchnlInrNum - 1;
                    txtChIndexBegin.Text = RFchnlBegin.ToString();
                    txtChIndexEnd.Text = RFchnlEnd.ToString();

                    string strInformation = "Get Insert RF Channel frome: " + txtChIndexBegin.Text + " To " + txtChIndexEnd.Text +" !";
                    //strInformation = strInformation + " (Set 'RF Region' will cancel this funciton!)";
                    setToolStripStatusMessage1(strInformation, Color.Purple);                    
                }
			}
			else if (rxStrPkts.strCmdH == ConstCode.CMD_SET_POWER)
			{
                setToolStripStatusMessage1("Set Current RF Power is OK!", Color.Purple);
			}
            else if (rxStrPkts.strCmdH == ConstCode.CMD_GET_POWER)
            {
                int rfpwrSel;
                string curPower = rxStrPkts.strParameters[0] + rxStrPkts.strParameters[1];
                //MessageBox.Show("Current Power is " + (Convert.ToInt16(curPower, 16) / 100.0) + "dBm", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rfpwrSel = (int)(Convert.ToInt16(curPower, 16) / 100.0);
                cbxPaPower.SelectedIndex = 30-rfpwrSel;
                setToolStripStatusMessage1("Current Power is " + (Convert.ToInt16(curPower, 16) / 100.0) + "dBm!", Color.Purple);
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_SET_CW)
            {
                string curPower = rxStrPkts.strParameters[0] + rxStrPkts.strParameters[1];
                if(rxStrPkts.strParameters[0]=="00")
                    setToolStripStatusMessage1("CW RF Power is Off! ", Color.Purple);
                else
                    setToolStripStatusMessage1("CW RF Power is On! ", Color.Purple);
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_ANT)
            {
                AntResponseMessageProcess(rxStrPkts);
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_READ_MODEM_PARA)
            {
                int mixerGain = mixerGainTable[Convert.ToInt32(rxStrPkts.strParameters[0], 16)];
                int IFAmpGain = IFAmpGainTable[Convert.ToInt32(rxStrPkts.strParameters[1], 16)];
                string signalTh = rxStrPkts.strParameters[2] + rxStrPkts.strParameters[3];
                MessageBox.Show("Mixer Gain is " + mixerGain + "dB, IF AMP Gain is " + IFAmpGain + "dB, Decode Threshold is 0x" + signalTh + ".", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_SCAN_JAMMER)
            {
                int startChannel = Convert.ToInt16(rxStrPkts.strParameters[0], 16);
                int stopChannel = Convert.ToInt16(rxStrPkts.strParameters[1], 16);

                hBarChartJammer.Items.Maximum = 40;
                hBarChartJammer.Items.Minimum = 0;

                hBarChartJammer.Items.Clear();

                int[] allJammer = new int[(stopChannel - startChannel + 1)];
                int maxJammer = -100;
                int minJammer = 20;
                for (int i = 0; i < (stopChannel - startChannel + 1); i++)
                {
                    int jammer = Convert.ToInt16(rxStrPkts.strParameters[2 + i], 16);
                    if (jammer > 127)
                    {
                        jammer = -((-jammer) & 0xFF);
                    }
                    allJammer[i] = jammer;
                    if (jammer >= maxJammer)
                    {
                        maxJammer = jammer;
                    }
                    if (jammer <= minJammer)
                    {
                        minJammer = jammer;
                    }
                }
                int offset = -minJammer + 3;
                for (int i = 0; i < (stopChannel - startChannel + 1); i++)
                {
                    allJammer[i] = allJammer[i] + offset;
                    hBarChartJammer.Items.Add(new HBarItem((double)(allJammer[i]), (double)offset, (i + startChannel).ToString(), Color.FromArgb(255, 190, 200, 255)));
                }
                hBarChartJammer.RedrawChart();
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_SCAN_RSSI)
            {
                int startChannel = Convert.ToInt16(rxStrPkts.strParameters[0], 16);
                int stopChannel = Convert.ToInt16(rxStrPkts.strParameters[1], 16);

                hBarChartRssi.Items.Maximum = 73;
                hBarChartRssi.Items.Minimum = 0;

                hBarChartRssi.Items.Clear();

                int[] allRssi = new int[(stopChannel - startChannel + 1)];
                int maxRssi = -100;
                int minRssi = 20;
                for (int i = 0; i < (stopChannel - startChannel + 1); i++)
                {
                    int rssi = Convert.ToInt16(rxStrPkts.strParameters[2 + i], 16);
                    if (rssi > 127)
                    {
                        rssi = -((-rssi) & 0xFF);
                    }
                    allRssi[i] = rssi;
                    if (rssi >= maxRssi)
                    {
                        maxRssi = rssi;
                    }
                    if (rssi <= minRssi)
                    {
                        minRssi = rssi;
                    }
                }
                int offset = -minRssi + 3;
                for (int i = 0; i < (stopChannel - startChannel + 1); i++)
                {
                    allRssi[i] = allRssi[i] + offset;
                    hBarChartRssi.Items.Add(new HBarItem((double)(allRssi[i]), (double)offset, (i + startChannel).ToString(), Color.FromArgb(255, 190, 200, 255)));
                }
                hBarChartRssi.RedrawChart();
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_GET_MODULE_INFO)
            {
                if (checkingReaderAvailable)
                {
                    if (rxStrPkts.strParameters[0] == ConstCode.MODULE_HARDWARE_VERSION_FIELD)
                    {
                        hardwareVersion = String.Empty;
                        try
                        {
                            for (int i = 0; i < Convert.ToInt32(rxStrPkts.strLength, 16) - 1; i++)
                            {
                                hardwareVersion += (char)Convert.ToInt32(rxStrPkts.strParameters[1 + i], 16);
                            }
                            txtHardwareVersion.Text = hardwareVersion;
                            adjustUIcomponents(hardwareVersion);
                            getFirmwareVersion();
                        }
                        catch (System.Exception ex)
                        {
                            hardwareVersion = rxStrPkts.strParameters[1].Substring(1, 1) + "." + rxStrPkts.strParameters[2];
                            txtHardwareVersion.Text = hardwareVersion;
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else if (rxStrPkts.strParameters[0] == ConstCode.MODULE_SOFTWARE_VERSION_FIELD)
                    {
                        String firmwareVersion = string.Empty;
                        try
                        {
                            for (int i = 0; i < Convert.ToInt32(rxStrPkts.strLength, 16) - 1; i++)
                            {
                                firmwareVersion += (char)Convert.ToInt32(rxStrPkts.strParameters[1 + i], 16);
                            }
                            txtFirmwareVersion.Text = firmwareVersion;
                        }
                        catch (System.Exception ex)
                        {
                            txtFirmwareVersion.Text = "";
                            Console.WriteLine(ex.Message);
                        }
                    }
                }

                if (rxStrPkts.strCmdL == ConstCode.MODULE_FIRMWARE_VERSION_SUBCMD)
                {
                    string HWMajorVer, HWMinorVer, SWMajorVer, SWMinorVer;
                    HWMajorVer = rxStrPkts.strParameters[0];
                    HWMinorVer = rxStrPkts.strParameters[1];
                    SWMajorVer = rxStrPkts.strParameters[2];
                    SWMinorVer = rxStrPkts.strParameters[3];
                    //setToolStripStatusMessage2("Main Firmware Version: " + HWMajorVer + "." + HWMinorVer + "." + SWMajorVer + "." + SWMinorVer + "!", Color.Purple);
                    setToolStripStatusMessage2("Moudule Reader Main Firmware Version: " + HWMajorVer + "." + HWMinorVer + "." + SWMajorVer + "." + SWMinorVer + "!", Color.Purple);
                }
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_IO_CONTROL)//"1A")
            {
                if (rxStrPkts.strParameters[0] == "02")
                {
                    MessageBox.Show("IO" + rxStrPkts.strParameters[1].Substring(1) + " is " + (rxStrPkts.strParameters[2] == "00" ? "Low" : "High"), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_READ_ADDR) //SureLion
            {
                string str10devAddr = DataConvert.HexToDec(rxStrPkts.strParameters[0]);
                int devAddr = Convert.ToInt32(str10devAddr);

                string strdevAddr = devAddr.ToString("D03");
                if (rxStrPkts.strCmdL == ConstCode.READER_OPERATION_SET)
                {
                    cbxDeviceAddr.SelectedIndex = devAddr;
                    ReaderDeviceAddress = (byte)devAddr;// Set to the Reader's Device   ？？？
                    MessageBox.Show("Set Reader to new Device Address: " + strdevAddr, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setToolStripStatusMessage1("Set new Reader's Device Address: " + strdevAddr, Color.MediumSeaGreen);
                }
                else if (rxStrPkts.strCmdL == ConstCode.READER_OPERATION_GET)
                {
                    cbxDeviceAddr.SelectedIndex = devAddr;
                    ReaderDeviceAddress = (byte)devAddr;// Set to the Reader's Device

                    //ReaderDeviceAddress = (byte)cbxDeviceAddr.SelectedIndex;
                    Commands.ReaderDeviceAddr = ReaderDeviceAddress;
                    //MessageBox.Show("Get Reader's Device Address: " + strdevAddr, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);					
                    setToolStripStatusMessage1("Get Reader's Device Address: " + strdevAddr, Color.MediumSeaGreen);
                }
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_SET_UART_BAUDRATE)//2018-11-09
            {
                if (rxStrPkts.strCmdL == ConstCode.READER_OPERATION_SET)
                {
                    setToolStripStatusMessage1("Set Reader's Baud Rate: " + cbxNewBaudRate.Text, Color.MediumSeaGreen);
                    MessageBox.Show("Take effect after reset the Reader!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (rxStrPkts.strCmdL == ConstCode.READER_OPERATION_GET)
                {
                    cbxNewBaudRate.SelectedIndex = Convert.ToInt32(rxStrPkts.strParameters[0]);
                    setToolStripStatusMessage1("Get Reader's Baud Rate: " + cbxNewBaudRate.Text, Color.MediumSeaGreen);
                }
            }
	}
	private void rp_PaketReceived(object sender, StrArrEventArgs e)
	{
		string[] packetRx = e.Data;
		string strPacket = string.Empty;
		for (int i = 0; i < packetRx.Length; i++)
		{
			strPacket += packetRx[i] + " ";
		}
		this.Invoke((EventHandler)(delegate
		{
			txtCOMRxCnt.Text = (Convert.ToInt32(txtCOMRxCnt.Text) + packetRx.Length).ToString();
			txtCOMRxCnt_adv.Text = txtCOMRxCnt.Text;

			//auto clear received data region
			int txtReceive_len = txtReceive.Lines.Length; //txtReceive.GetLineFromCharIndex(txtReceive.Text.Length + 1);
			if (cbxAutoClear.Checked)
			{
				if (txtReceive_len > 9)
				{
					txtReceive.Text = string.Empty;
				}
			}
			//--------------------------------------------------
			int dis;
			//int packetRxLen = Marshal.SizeOf(Commands.ReaderRespFramePacket);//Convert.ToInt16(packetRx[3],10);
			byte[] packetRxHex = new byte[256];//packetRxLen];
			packetRxHex = DataConvert.GetHexBytes(strPacket, out dis);

			Commands.ReaderResponseFrameString rxStrPkts = new Commands.ReaderResponseFrameString(true);
			rxStrPkts=Commands.GetReaderResponsFrameStringStructFromHexBuffer(packetRxHex);
			//Commands.ReaderResponseFrame RdRecv = (Commands.ReaderResponseFrame)RFID_Reader_Cmds.DataConvert.BytesToStruct(packetRxHex, Commands.ReaderRespFramePacket.GetType());
			//---------------------------------------------------- 
			if(rxStrPkts.strStatus==ConstCode.FAIL_OK)
			{
				rp_PaketOK(rxStrPkts);
			}
			else
			{// rxStrPkts.strStatus
				rp_PacketFail(rxStrPkts.strStatus, rxStrPkts.strLength,rxStrPkts.strParameters);

				if(rxStrPkts.strCmdH == ConstCode.CMD_SENSORTAG_READ)
				{
					SensorTag_MessageProcessFailed(rxStrPkts);
				}
			}

			if (cbxRxVisable.Checked == true)
			{
				this.txtReceive.Text = this.txtReceive.Text + strPacket + "\r\n";
			}
				
#if TRACE
            //Console.WriteLine("a packet received!");
#endif
            }));
	}
		#endregion

        private int getSuccessTagEpc(string[] packetRx)
        {
            /*txtOperateEpc.Text = "";
			if (packetRx.Length < 9)
			{
				return 0;
			}
			int pcEpcLen = Convert.ToInt32(packetRx[5], 16);
			for (int i = 0; i < pcEpcLen; i++)
			{
				txtOperateEpc.Text += packetRx[i + 6] + " ";
			}
			return pcEpcLen;
			*/
            txtOperateEpc.Text = "";
			if (packetRx.Length < 9)
			{
				return 0;
			}
			int pcEpcLen = Convert.ToInt32(packetRx[0], 16);
			for (int i = 0; i < pcEpcLen; i++)
			{
				txtOperateEpc.Text += packetRx[i + 1] + " ";
			}
			return pcEpcLen;
        }

        private void setStatus(string msg, Color color)
        {
            rtbxStatus.Text = msg;
            rtbxStatus.ForeColor = color;

            setToolStripStatusMessage1(msg, color);
        }

		private void setToolStripStatusMessage1(string msg, Color color)
		{
			toolStripStatusLabel1.Text = msg;
			toolStripStatusLabel1.ForeColor = color;            
		}
		private void setToolStripStatusMessage2(string msg, Color color)
        {
            toolStripStatusLabel2.Text = msg;
            toolStripStatusLabel2.ForeColor = color;            
          
        }
		private void setToolStripStatusMessage3(string msg, Color color)
        {
            toolStripStatusLabel3.Text = msg;
            toolStripStatusLabel3.ForeColor = color;            
          
        }
        private void adjustUIcomponents(string hardwareVersion)
        {
            this.cbxPaPower.Items.Clear();
            for (int i = 30; i >= 0; i--)
            {
                this.cbxPaPower.Items.Add(i.ToString() + "dBm");
            }
            this.cbxPaPower.SelectedIndex = 0;
            this.cbxMixerGain.SelectedIndex = 4;
            this.cbxIFAmpGain.SelectedIndex = 6;
            this.tbxSignalThreshold.Text = "0120";
            this.tbxAntennaGain.Text = "3";
            this.tbxCoupling.Text = "-10";
            this.cbxQBasic.SelectedIndexChanged -= new System.EventHandler(this.cbx_q_basic_SelectedIndexChanged);
            this.cbxQBasic.SelectedIndex = 1;
            this.cbxQBasic.SelectedIndexChanged += new System.EventHandler(this.cbx_q_basic_SelectedIndexChanged);
            this.cbxQAdv.SelectedIndex = 5;
            this.gbxIoControl.Visible = true;
        }
        private void setTip()
        {
            toolTip1.SetToolTip(this.label1, "Available COM Port");
            toolTip1.SetToolTip(this.txtReceive, "Double Click To Select ALL");
        }

        #region Serial Port connection and download Firmware
        private void btnConn_Click(object sender, EventArgs e)
        {
            if (bAutoSend == false)
            {
                if (btnConn.Tag.ToString() == "0")
                {
                    Sp.GetInstance().Config(cbxPort.SelectedItem.ToString(), Convert.ToInt32(cbxBaudRate.SelectedItem.ToString())
                        , Parity.None, 8, StopBits.One);
                    if (!Sp.GetInstance().Open())
                    {
                        MessageBox.Show("Open Serial Port Fail!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }                        
                    btnConn.Text = "Disconnect";
                    btnConn.Tag = "1";
                    this.btnConn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                    checkReaderAvailable();
                    //picComStatus.BackgroundImage = Properties.Resources.greenlight;
                }
                else
                {
                    if (!Sp.GetInstance().Close())
                    {
                        MessageBox.Show("Serial Port Close Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    btnConn.Text = "Connect";
                    btnConn.Tag = "0";
                    this.btnConn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                    //picComStatus.BackgroundImage = Properties.Resources.redlight;
                }
            }
            else
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

         public void checkReaderAvailable()
        {
            if (Sp.GetInstance().IsOpen())
            {
            	//GetReaderDeviceAddr();
				
                hardwareVersion = "";
                checkingReaderAvailable = true;
                readerConnected = false;
				
                //Sp.GetInstance().Send(Commands.RFID_Q_GetModuleInfo(ReaderDeviceAddress,ConstCode.MODULE_HARDWARE_VERSION_FIELD));
                txtSend.Text = Commands.RFID_Q_GetModuleInfo(ReaderDeviceAddress, ConstCode.MODULE_HARDWARE_VERSION_FIELD);
               
                Sp.GetInstance().Send(txtSend.Text);
				
                //Sp.GetInstance().Send(Commands.RFID_Q_GetModuleInfo(ConstCode.READER_DEVICEADDR_BROADCAST, ConstCode.MODULE_HARDWARE_VERSION_FIELD));
                timerCheckReader.Enabled = true;//if executed System.Timers.Timer.Elapsed  Event
            }
        }

        #endregion

		private void cbxDeviceAddr_SelectedIndexChanged(object sender, EventArgs e)
        {
			ReaderDeviceAddress = (byte)cbxDeviceAddr.SelectedIndex;
			Commands.ReaderDeviceAddr = ReaderDeviceAddress;
        }
        private void cbx_dr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbxDR.SelectedIndex == 1)
            {
                MessageBox.Show("Does Not Support DR = 64/3 In this Version", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cbxDR.SelectedIndex = 0;
            }
        }

        private void cbx_m_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbxM.SelectedIndex == 1 || this.cbxM.SelectedIndex == 2 || this.cbxM.SelectedIndex == 3)
            {
                MessageBox.Show("Does Not Support M = 2/4/8 In this Version", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cbxM.SelectedIndex = 0;
            }
        }

        private void cbx_trext_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbxTRext.SelectedIndex == 0)
            {
                MessageBox.Show("Does Not Support No Pilot Tone In this Version", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cbxTRext.SelectedIndex = 1;
            }
        }

        #region send data
        private void btn_Send_Click(object sender, EventArgs e)
        {
            Sp.GetInstance().Send(txtSend.Text);
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (Sp.GetInstance().IsOpen() == true)
            {
                bAutoSend = !bAutoSend;
                if (bAutoSend)
                {
                    bSensorTag_InventoryFlag = false;
                    timerAutoSend.Interval = Convert.ToInt32(txtSendDelay.Text);
                    timerAutoSend.Enabled = true;
                    txtSend.Text = Commands.RFID_Q_ReadSingle(ReaderDeviceAddress);
                    btnContinue.Text = "Stop";
                    tmrCheckEpc.Enabled = true;
                    bInventoryGoing = true;
                }
                else
                {
                    timerAutoSend.Interval = Convert.ToInt32(txtSendDelay.Text);
                    timerAutoSend.Enabled = false;
                    btnContinue.Text = "Continue";
                    tmrCheckEpc.Enabled = false;
                    bInventoryGoing = false;
                }
            }
            else
            {
                MessageBox.Show("Please Connect Serial Port！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void timerAutoSend_Tick(object sender, EventArgs e)
        {
            LoopNum_cnt = LoopNum_cnt + 1;
            try
            {
                if (Sp.GetInstance().Send(txtSend.Text) == 0)
                {
                    bAutoSend = false;
                    timerAutoSend.Enabled = false;
                    btnContinue.Text = "Continue";
                }
            }
            catch (System.Exception ex)
            {
                bAutoSend = false;
                timerAutoSend.Enabled = false;
                btnContinue.Text = "Continue";
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //clear send text region
        private void btnClearS_Click(object sender, EventArgs e)
        {
            txtSend.Text = "";
        }

        private void btnSetFreq_Click(object sender, EventArgs e)
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //txtSend.Text = Commands.RFID_Q_SetRfChannel(ReaderDeviceAddresscbxChannel.SelectedIndex.ToString("X2"));
			txtSend.Text = Commands.RFID_Q_SetRfChannel(ReaderDeviceAddress,cbxChannel.SelectedIndex.ToString("X2"));
            Sp.GetInstance().Send(txtSend.Text);
        }

        private void btn_invt_Click(object sender, EventArgs e)
        {
            bSensorTag_InventoryFlag = false;

            LoopNum_cnt = LoopNum_cnt + 1;
            //txtSend.Text = Commands.RFID_Q_ReadSingle(ReaderDeviceAddress);
			txtSend.Text = Commands.RFID_Q_ReadSingle(ReaderDeviceAddress);
            Sp.GetInstance().Send(txtSend.Text);
        }

        private void cbx_q_basic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (change_q_1st == false)
            {
                if (bAutoSend == true)
                {
                    if (change_q_message == true)
                    {
                        MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        change_q_message = false;
                        this.cbxQBasic.SelectedIndex = this.cbxQAdv.SelectedIndex;
                    }
                    else
                    {
                        change_q_message = true;
                    }
                }
                else
                {
                    int intDR = this.cbxDR.SelectedIndex;
                    int intM = this.cbxM.SelectedIndex;
                    int intTRext = this.cbxTRext.SelectedIndex;
                    int intSel = this.cbxSel.SelectedIndex;
                    int intSession = this.cbxSession.SelectedIndex;

                    int intTarget = this.cbxTarget.SelectedIndex;
                    int intQ = this.cbxQBasic.SelectedIndex;

                    //txtSend.Text = Commands.RFID_Q_SetQuery(ReaderDeviceAddressintDR, intM, intTRext, intSel, intSession, intTarget, intQ);
					txtSend.Text = Commands.RFID_Q_SetQuery(ReaderDeviceAddress,intDR, intM, intTRext, intSel, intSession, intTarget, intQ);
                    Sp.GetInstance().Send(txtSend.Text);
                    this.cbxQAdv.SelectedIndex = intQ;
                }
            }
        }

        private void btnSetCW_Click(object sender, EventArgs e)
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (btnSetCW.Text == "CW ON")
            {
                //txtSend.Text = Commands.RFID_Q_SetCW(ReaderDeviceAddressConstCode.SET_ON);
				txtSend.Text = Commands.RFID_Q_SetCW(ReaderDeviceAddress,ConstCode.SET_ON);
            }
            else
            {
                //txtSend.Text = Commands.RFID_Q_SetCW(ReaderDeviceAddressConstCode.SET_OFF);
				txtSend.Text = Commands.RFID_Q_SetCW(ReaderDeviceAddress,ConstCode.SET_OFF);
            }
            Sp.GetInstance().Send(txtSend.Text);

            if (btnSetCW.Text == "CW ON")
            {
                btnSetCW.Text = "CW OFF";
            }
            else
            {
                btnSetCW.Text = "CW ON";
            }
        }

        #endregion

        private void btn_clear_rx_Click(object sender, EventArgs e)
        {
            txtReceive.Text = "";
        }
        //clear EPC Table
        private void btn_clear_basictable_Click(object sender, EventArgs e)
        {
            basic_table.Clear();
            advanced_table.Clear();
            LoopNum_cnt = 0;
            FailEPCNum = 0;
            SucessEPCNum = 0;
            db_LoopNum_cnt = 0;
            for (int i = 0; i <= initDataTableLen - 1; i++)
            {
                basic_table.Rows.Add(new object[] { null });
            }
            basic_table.AcceptChanges();
            for (int i = 0; i <= initDataTableLen - 1; i++)
            {
                advanced_table.Rows.Add(new object[] { null });
            }
            advanced_table.AcceptChanges();
            rowIndex = 0;
            textBox_EPC_TagCounter.Text = "0";
            textBox_EPC_Tag_Total.Text = "0";
        }

        #region DataGridView
        private void GetEPC(string pc, string epc, string crc, string rssi , string antno,string per)
        {
            this.dgv_epc2.ClearSelection();
            bool isFoundEpc = false;
            string newEpcItemCnt;
            int indexEpc = 0;

            int EpcItemCnt;

            uint EpcTagCounter = Convert.ToUInt32(textBox_EPC_TagCounter.Text);
            EpcTagCounter++;
            textBox_EPC_TagCounter.Text = EpcTagCounter.ToString();

            if (rowIndex <= initDataTableLen)
            {
                EpcItemCnt = rowIndex;
            }
            else
            {
                EpcItemCnt = basic_table.Rows.Count;
                EpcItemCnt = advanced_table.Rows.Count;
            }

            for (int j = 0; j < EpcItemCnt; j++)
            {
                if (basic_table.Rows[j][2].ToString() == epc && basic_table.Rows[j][1].ToString() == pc)
                {
                    indexEpc = j;
                    isFoundEpc = true;
                    break;
                }
            }

            if (EpcItemCnt < initDataTableLen) //basic_table.Rows[EpcItemCnt][0].ToString() == ""
            {
                if (!isFoundEpc || EpcItemCnt == 0)
                {
                    if (EpcItemCnt + 1 < 10)
                    {
                        newEpcItemCnt = "0" + Convert.ToString(EpcItemCnt + 1);
                    }
                    else
                    {
                        newEpcItemCnt = Convert.ToString(EpcItemCnt + 1);
                    }
                    try
                    {
                    basic_table.Rows[EpcItemCnt][_BASIC_TABLE_INDEX_NO_] = newEpcItemCnt; // EpcItemCnt + 1;
                    basic_table.Rows[EpcItemCnt][_BASIC_TABLE_INDEX_PC_] = pc;
                    basic_table.Rows[EpcItemCnt][_BASIC_TABLE_INDEX_EPC_] = epc;
                    basic_table.Rows[EpcItemCnt][_BASIC_TABLE_INDEX_CRC_] = crc;
                    basic_table.Rows[EpcItemCnt][_BASIC_TABLE_INDEX_RSSI_] = rssi;
                    basic_table.Rows[EpcItemCnt][_BASIC_TABLE_INDEX_CNT_] = 1;
                    basic_table.Rows[EpcItemCnt][_BASIC_TABLE_INDEX_PER_] = "0.000";
                    basic_table.Rows[EpcItemCnt][_BASIC_TABLE_INDEX_ANT_] = 0;//System.DateTime.Now.ToString(timeFormat);

                    advanced_table.Rows[EpcItemCnt][_ADV_TABLE_INDEX_NO_] = newEpcItemCnt; // EpcItemCnt + 1;
                    advanced_table.Rows[EpcItemCnt][_ADV_TABLE_INDEX_PC_] = pc;
                    advanced_table.Rows[EpcItemCnt][_ADV_TABLE_INDEX_EPC_] = epc;
                    advanced_table.Rows[EpcItemCnt][_ADV_TABLE_INDEX_CRC_] = crc;
                    advanced_table.Rows[EpcItemCnt][_ADV_TABLE_INDEX_CNT_] = 1;
                    advanced_table.Rows[EpcItemCnt][_ADV_TABLE_INDEX_ANT_] = 0;

                    rowIndex++;
					}
					catch (System.Exception ex)
                    {                         
                         Console.WriteLine(ex.Message);
                    }

                    textBox_EPC_Tag_Total.Text = newEpcItemCnt;
                }
                else
                {
                    if (indexEpc + 1 < 10)
                    {
                        newEpcItemCnt = "0" + Convert.ToString(indexEpc + 1);
                    }
                    else
                    {
                        newEpcItemCnt = Convert.ToString(indexEpc + 1);
                    }
					try
					{
                    basic_table.Rows[indexEpc][_BASIC_TABLE_INDEX_NO_] = newEpcItemCnt; // indexEpc + 1;
                    basic_table.Rows[indexEpc][_BASIC_TABLE_INDEX_RSSI_] = rssi;
                    basic_table.Rows[indexEpc][_BASIC_TABLE_INDEX_CNT_] = Convert.ToInt32(basic_table.Rows[indexEpc][_BASIC_TABLE_INDEX_CNT_].ToString()) + 1;
                    basic_table.Rows[indexEpc][_BASIC_TABLE_INDEX_PER_] = per;
                    basic_table.Rows[indexEpc][_BASIC_TABLE_INDEX_ANT_] = antno;//System.DateTime.Now.ToString(timeFormat);

                    advanced_table.Rows[indexEpc][_ADV_TABLE_INDEX_NO_] = newEpcItemCnt; // indexEpc + 1;
                    advanced_table.Rows[indexEpc][_ADV_TABLE_INDEX_CNT_] = Convert.ToInt32(advanced_table.Rows[indexEpc][_ADV_TABLE_INDEX_CNT_].ToString()) + 1;
					advanced_table.Rows[indexEpc][_ADV_TABLE_INDEX_ANT_] = antno;//Convert.ToInt32(advanced_table.Rows[indexEpc][_ADV_TABLE_INDEX_ANT_].ToString()) + 1;
					}
					catch (System.Exception ex)
                    {                         
                         Console.WriteLine(ex.Message);
                    }
                }
            }
            else
            {
                if (!isFoundEpc || EpcItemCnt == 0)
                {
                    if (EpcItemCnt + 1 < 10)
                    {
                        newEpcItemCnt = "0" + Convert.ToString(EpcItemCnt + 1);
                    }
                    else
                    {
                        newEpcItemCnt = Convert.ToString(EpcItemCnt + 1);
                    }
                    basic_table.Rows.Add(new object[] { newEpcItemCnt, pc, epc, crc, rssi, "1", "0.000", antno });
                    advanced_table.Rows.Add(new object[] { newEpcItemCnt, pc, epc, crc, "1",antno });
                    rowIndex++;

                    textBox_EPC_Tag_Total.Text = newEpcItemCnt;
                }
                else
                {
                    if (indexEpc + 1 < 10)
                    {
                        newEpcItemCnt = "0" + Convert.ToString(indexEpc + 1);
                    }
                    else
                    {
                        newEpcItemCnt = Convert.ToString(indexEpc + 1);
                    }
					try
					{					
                    basic_table.Rows[indexEpc][_BASIC_TABLE_INDEX_NO_] = newEpcItemCnt; // indexEpc + 1;
                    basic_table.Rows[indexEpc][_BASIC_TABLE_INDEX_RSSI_] = rssi;
                    basic_table.Rows[indexEpc][_BASIC_TABLE_INDEX_CNT_] = Convert.ToInt32(basic_table.Rows[indexEpc][_BASIC_TABLE_INDEX_CNT_].ToString()) + 1;
                    basic_table.Rows[indexEpc][_BASIC_TABLE_INDEX_PER_] = per;
                    basic_table.Rows[indexEpc][_BASIC_TABLE_INDEX_ANT_] = antno;//System.DateTime.Now.ToString(timeFormat);

                    advanced_table.Rows[indexEpc][_ADV_TABLE_INDEX_NO_] = newEpcItemCnt; // indexEpc + 1;
                    advanced_table.Rows[indexEpc][_ADV_TABLE_INDEX_CNT_] = Convert.ToInt32(advanced_table.Rows[indexEpc][_ADV_TABLE_INDEX_CNT_].ToString()) + 1;
                    advanced_table.Rows[indexEpc][_ADV_TABLE_INDEX_ANT_] = antno; //Convert.ToInt32(advanced_table.Rows[indexEpc][_ADV_TABLE_INDEX_ANT_].ToString()) + 1;
					}
					catch (System.Exception ex)
                    {                         
                         Console.WriteLine(ex.Message);
                    }
                }
            }
        }
        private void dgvEpcBasic_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvEpcBasic.ClearSelection();
            //double totalCnt = 0;
            //if (e.ListChangedType == ListChangedType.ItemChanged || e.ListChangedType == ListChangedType.ItemMoved)
            {
                //for (int i = 0; i < this.dgvEpcBasic.Rows.Count; i++)
                //{
                //    string cnt = this.dgvEpcBasic.Rows[i].Cells[5].Value.ToString();
                //    if (null != cnt && !"".Equals(cnt))
                //    {
                //        totalCnt += Convert.ToInt32(cnt);
                //    }
                //}
                //for (int i = 0; i < this.dgvEpcBasic.Rows.Count; i++)
                //{
                //    string cnt = this.dgvEpcBasic.Rows[i].Cells[5].Value.ToString();
                //    if (null != cnt && !"".Equals(cnt))
                //    {
                //        int sigleCnt = Convert.ToInt32(cnt);
                //        int r = 0xFF & (int)(sigleCnt / totalCnt * 255);
                //        this.dgvEpcBasic.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(0xff,255 - r,255 - r);
                //    }
                //}
                pbx_Inv_Indicator.Visible = true;
            }
        }
        private void dgv_epc2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //if (e.ListChangedType == ListChangedType.ItemChanged || e.ListChangedType == ListChangedType.ItemAdded)
            {
                for (int i = 0; i < this.dgv_epc2.Rows.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        this.dgv_epc2.Rows[i].DefaultCellStyle.BackColor = Color.AliceBlue;
                    }
                }
            }
        }

		private const int _BASIC_TABLE_INDEX_NO_ = 0;
		private const int _BASIC_TABLE_INDEX_PC_ = 1;
		private const int _BASIC_TABLE_INDEX_EPC_ = 2;
		private const int _BASIC_TABLE_INDEX_CRC_ = 3;
		private const int _BASIC_TABLE_INDEX_RSSI_ = 4;
		private const int _BASIC_TABLE_INDEX_CNT_ = 5;
		private const int _BASIC_TABLE_INDEX_PER_ = 6;
		private const int _BASIC_TABLE_INDEX_ANT_ = 7;
        private DataTable BasicGetEPCHead()
        {
            basic_table.TableName = "EPC";
            basic_table.Columns.Add("No.", typeof(string)); // 0
            basic_table.Columns.Add("PC", typeof(string)); // 1
            basic_table.Columns.Add("EPC", typeof(string)); // 2
            basic_table.Columns.Add("CRC", typeof(string)); // 3
            basic_table.Columns.Add("RSSI(dB)", typeof(string)); // 4
            basic_table.Columns.Add("CNT", typeof(string)); // 5
            basic_table.Columns.Add("PER(%)", typeof(string)); // 6
            basic_table.Columns.Add("ANT", typeof(string)); // 7

            for (int i = 0; i <= initDataTableLen - 1; i++)
            {
                basic_table.Rows.Add(new object[] { null });
            }
            basic_table.AcceptChanges();

            return basic_table;
        }
        private const int _ADV_TABLE_INDEX_NO_ = 0;
        private const int _ADV_TABLE_INDEX_PC_ = 1;
        private const int _ADV_TABLE_INDEX_EPC_ = 2;
        private const int _ADV_TABLE_INDEX_CRC_ = 3;
        private const int _ADV_TABLE_INDEX_CNT_ = 4;
        private const int _ADV_TABLE_INDEX_ANT_ = 5;
        private DataTable AdvancedGetEPCHead()
        {
            advanced_table.TableName = "EPC";
            advanced_table.Columns.Add("No.", typeof(string)); //0
            advanced_table.Columns.Add("PC", typeof(string)); //1
            advanced_table.Columns.Add("EPC", typeof(string)); //2
            advanced_table.Columns.Add("CRC", typeof(string)); //3
            advanced_table.Columns.Add("CNT", typeof(string)); //4
            advanced_table.Columns.Add("ANT", typeof(string)); //5
            for (int i = 0; i <= initDataTableLen - 1; i++)
            {
                advanced_table.Rows.Add(new object[] { null });
            }
            advanced_table.AcceptChanges();

            return advanced_table;
        }
        private void Basic_DGV_ColumnsWidth(DataGridView dataGridView1)
        {
            //dataGridView1.Columns[6].SortMode = DataGridViewColumnSortMode.Programmatic;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersHeight = 40;
            //dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_BASIC_TABLE_INDEX_NO_].Width = 40;
            //dataGridView1.Columns[0].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_BASIC_TABLE_INDEX_NO_].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[_BASIC_TABLE_INDEX_NO_].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			
            dataGridView1.Columns[_BASIC_TABLE_INDEX_PC_].Width = 60;
            //dataGridView1.Columns[1].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_BASIC_TABLE_INDEX_PC_].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[_BASIC_TABLE_INDEX_PC_].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			
            dataGridView1.Columns[_BASIC_TABLE_INDEX_EPC_].Width = 290;
            //dataGridView1.Columns[_BASIC_TABLE_INDEX_EPC_].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_BASIC_TABLE_INDEX_EPC_].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[_BASIC_TABLE_INDEX_EPC_].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			
            dataGridView1.Columns[_BASIC_TABLE_INDEX_CRC_].Width = 60;
            //dataGridView1.Columns[_BASIC_TABLE_INDEX_CRC_].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_BASIC_TABLE_INDEX_CRC_].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[_BASIC_TABLE_INDEX_CRC_].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			
            dataGridView1.Columns[_BASIC_TABLE_INDEX_RSSI_].Width = 75;
            //dataGridView1.Columns[_BASIC_TABLE_INDEX_RSSI_].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_BASIC_TABLE_INDEX_RSSI_].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[_BASIC_TABLE_INDEX_RSSI_].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			
            //dataGridView1.Columns[5].Width = 70;
            ////dataGridView1.Columns[5].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            //dataGridView1.Columns[5].Resizable = DataGridViewTriState.False;
            //dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            dataGridView1.Columns[_BASIC_TABLE_INDEX_CNT_].Width = 70;
            //dataGridView1.Columns[_BASIC_TABLE_INDEX_CNT_].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_BASIC_TABLE_INDEX_CNT_].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[_BASIC_TABLE_INDEX_CNT_].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			
            dataGridView1.Columns[_BASIC_TABLE_INDEX_PER_].Width = 72;
            //dataGridView1.Columns[_BASIC_TABLE_INDEX_PER_].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_BASIC_TABLE_INDEX_PER_].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[_BASIC_TABLE_INDEX_PER_].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			//dataGridView1.Columns[_BASIC_TABLE_INDEX_ANT_].Visible = false;
            dataGridView1.Columns[_BASIC_TABLE_INDEX_ANT_].Width = 50;
            //dataGridView1.Columns[_BASIC_TABLE_INDEX_ANT_].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_BASIC_TABLE_INDEX_ANT_].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[_BASIC_TABLE_INDEX_ANT_].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        //private const int _ADV_TABLE_INDEX_NO_ = 0;
        //private const int _ADV_TABLE_INDEX_PC_ = 1;
        //private const int _ADV_TABLE_INDEX_EPC_ = 2;
        //private const int _ADV_TABLE_INDEX_CRC_ = 3;
        //private const int _ADV_TABLE_INDEX_CNT_ = 4;
        //private const int _ADV_TABLE_INDEX_ANT_ = 5;
        private void Advanced_DGV_ColumnsWidth(DataGridView dataGridView1)
        {
            if (appEnableFlag)
            { 
                //dataGridView1.Columns[6].SortMode = DataGridViewColumnSortMode.Programmatic;
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersHeight = 40;
            //dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_ADV_TABLE_INDEX_NO_].Width = 40;
            //dataGridView1.Columns[_ADV_TABLE_INDEX_NO_].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_ADV_TABLE_INDEX_NO_].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[_ADV_TABLE_INDEX_NO_].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[_ADV_TABLE_INDEX_PC_].Width = 60;
            //dataGridView1.Columns[_ADV_TABLE_INDEX_PC_].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_ADV_TABLE_INDEX_PC_].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[_ADV_TABLE_INDEX_PC_].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[_ADV_TABLE_INDEX_EPC_].Width = 240;
            //dataGridView1.Columns[_ADV_TABLE_INDEX_EPC_].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_ADV_TABLE_INDEX_EPC_].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[_ADV_TABLE_INDEX_EPC_].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[_ADV_TABLE_INDEX_CRC_].Width = 60;
            //dataGridView1.Columns[_ADV_TABLE_INDEX_CRC_].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_ADV_TABLE_INDEX_CRC_].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[_ADV_TABLE_INDEX_CRC_].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[_ADV_TABLE_INDEX_CNT_].Width = 52;
            //dataGridView1.Columns[_ADV_TABLE_INDEX_CNT_].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_ADV_TABLE_INDEX_CNT_].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[_ADV_TABLE_INDEX_CNT_].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[_ADV_TABLE_INDEX_ANT_].Width = 40;
            //dataGridView1.Columns[_ADV_TABLE_INDEX_ANT_].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_ADV_TABLE_INDEX_ANT_].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[_ADV_TABLE_INDEX_ANT_].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        #endregion

        #region others
        private void btn_clear_cnt_Click(object sender, EventArgs e)
        {
            txtCOMRxCnt.Text = "0";
            txtCOMTxCnt.Text = "0";
            txtCOMRxCnt_adv.Text = "0";
            txtCOMTxCnt_adv.Text = "0";
        }

        private void btn_clear_cnt_adv_Click(object sender, EventArgs e)
        {
            txtCOMRxCnt.Text = "0";
            txtCOMTxCnt.Text = "0";
            txtCOMRxCnt_adv.Text = "0";
            txtCOMTxCnt_adv.Text = "0";
        }

        private string[] String16toString2(string S)
        {
            string[] S_array = new string[8];
            int intS = Convert.ToInt32(S, 16);
            for (int i = 7; i >= 0; i--)
            {
                S_array[i] = "0";
                if (intS >= System.Math.Pow(2, i)) S_array[i] = "1";
                intS = intS - Convert.ToInt32(S_array[i]) * Convert.ToInt32(System.Math.Pow(2, i));
            }
            return S_array;
        }

        private string StringToString(string S)
        {
            string Str = null;

            int S_num = Convert.ToInt32(S, 16);
            if (S_num < 16)
            {
                Str = "0" + S;
            }
            else
            {
                Str = S;
            }
            return Str;
        }

        private string[] StringArrayToStringArray(string[] S)
        {
            string[] Str = new string[S.Length];
            for (int i = 0; i < S.Length; i++)
            {
                int S_num = Convert.ToInt32(S[i], 16);
                if (S_num < 16)
                {
                    Str[i] = "0" + S[i];
                }
                else
                {
                    Str[i] = S[i];
                }
            }
            return Str;
        }

        private byte[] StringsToBytes(string[] B)
        {
            byte[] BToInt32 = new byte[B.Length];
            for (int i = 0; i < B.Length; i++)
            {
                BToInt32[i] = StringToByte(B[i]);
            }
            return BToInt32;
        }

        private byte StringToByte(string Str)
        {
            for (int i = Str.Length; i < 2; i++)
            {
                Str += "0";
            }
            return (byte)(Convert.ToInt32(Str, 16));
        }

        private string AutoAddSpace(string Str)
        {
            String StrDone = string.Empty;
            int i;
            for (i = 0; i < (Str.Length - 2); i = i + 2)
            {
                StrDone = StrDone + Str[i] + Str[i + 1] + " ";
            }
            if (Str.Length % 2 == 0 && Str.Length != 0)
            {
                if (Str.Length == i + 1)
                {
                    StrDone = StrDone + Str[i];
                }
                else
                {
                    StrDone = StrDone + Str[i] + Str[i + 1];
                }
            }
            else
            {
                StrDone = StrDone + StringToString(Str[i].ToString());
            }
            return StrDone;
        }

        private void txtReceive_DoubleClick(object sender, EventArgs e)
        {
            txtReceive.SelectAll();
        }

        private void txtSelMask_DoubleClick(object sender, EventArgs e)
        {
            txtSelMask.SelectAll();
        }

        private void txtSend_DoubleClick(object sender, EventArgs e)
        {
            txtSend.SelectAll();
        }


        private void txtInvtReadData_DoubleClick(object sender, EventArgs e)
        {
            txtInvtRWData.SelectAll();
        }

        private void txtGetSelMask_DoubleClick(object sender, EventArgs e)
        {
            txtGetSelMask.SelectAll();
        }
        #endregion

        #region Advanced Tab received data display
        private void btn_clear_epc2_Click(object sender, EventArgs e)
        {
            txtReceive.Text = "";
            basic_table.Clear();
            advanced_table.Clear();
            LoopNum_cnt = 0;
            FailEPCNum = 0;
            SucessEPCNum = 0;
            db_LoopNum_cnt = 0;
            for (int i = 0; i <= initDataTableLen - 1; i++)
            {
                basic_table.Rows.Add(new object[] { null });
            }
            basic_table.AcceptChanges();
            for (int i = 0; i <= initDataTableLen - 1; i++)
            {
                advanced_table.Rows.Add(new object[] { null });
            }
            advanced_table.AcceptChanges();
            rowIndex = 0;

        }

        public void dataGrid_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            int rowIndex = dgv_epc2.CurrentRow.Index;
            if (dgv_epc2.Rows[rowIndex].Cells[2].Value.ToString() != null)
            {
                txtSelMask.Text = dgv_epc2.Rows[rowIndex].Cells[2].Value.ToString();
            }
            txtSelLength.Text = (txtSelMask.Text.Replace(" ", "").Length * 4).ToString("X2");
        }

        private void btn_invt2_Click(object sender, EventArgs e)
        {
            bSensorTag_InventoryFlag = false;

            LoopNum_cnt = LoopNum_cnt + 1;
            txtSend.Text = Commands.RFID_Q_ReadSingle(ReaderDeviceAddress);
            Sp.GetInstance().Send(txtSend.Text);
        }
        #endregion

        #region Advanced Tab send data region

        private void btn_setquery_Click(object sender, EventArgs e)
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int intDR = this.cbxDR.SelectedIndex;
            int intM = this.cbxM.SelectedIndex;
            int intTRext = this.cbxTRext.SelectedIndex;
            int intSel = this.cbxSel.SelectedIndex;
            int intSession = this.cbxSession.SelectedIndex;

            int intTarget = this.cbxTarget.SelectedIndex;
            int intQ = this.cbxQAdv.SelectedIndex;

			txtSend.Text = Commands.RFID_Q_SetQuery(ReaderDeviceAddress,intDR, intM, intTRext, intSel, intSession, intTarget, intQ);
            Sp.GetInstance().Send(txtSend.Text);
        }

        private void btn_getquery_Click(object sender, EventArgs e)
        {
            txtSend.Text = Commands.RFID_Q_GetQuery(ReaderDeviceAddress);
            Sp.GetInstance().Send(txtSend.Text);
        }
        #endregion

        private void ReadTagInital()
        {
            this.cbx_MTR_Algorithm.SelectedIndex = 2;
            this.cbx_MTR_Qvalue.SelectedIndex = 5;
            this.txtRDMultiNum.Text = "188";//"65535";
        }
        private bool bInventoryGoing = false;// doing the inventory multi-tag...
        private void btn_invt_multi_Click(object sender, EventArgs e)
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
			if (checkBox_InvtMulti_AutoClear.Checked == true)
			{
				btn_clear_basictable_Click(null, null);
				btn_clear_rx_Click(null, null);
			}
            bSensorTag_InventoryFlag = false;
            int loopCnt = Convert.ToInt32(txtRDMultiNum.Text);
            txtSend.Text = Commands.RFID_Q_ReadMulti(ReaderDeviceAddress, (byte)cbx_MTR_Algorithm.SelectedIndex, (byte)cbx_MTR_Qvalue.SelectedIndex, loopCnt);
            Sp.GetInstance().Send(txtSend.Text);
            tmrCheckEpc.Enabled = true;
            bInventoryGoing = true;

            this.btnInvtMulti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));//2019-04-18
        }

        private void btn_stop_rd_Click(object sender, EventArgs e)
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
			txtSend.Text = Commands.RFID_Q_StopRead(ReaderDeviceAddress);
            Sp.GetInstance().Send(txtSend.Text);
            Thread.Sleep(200);
            txtSend.Text = Commands.RFID_Q_StopRead(ReaderDeviceAddress);
            Sp.GetInstance().Send(txtSend.Text);

            tmrCheckEpc.Enabled = false;
            bInventoryGoing = false;
            //this.btnInvtMulti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            //this.btnInvtMulti.BackColor=SystemColors.Control;
            this.btnInvtMulti.UseVisualStyleBackColor = true; //2019-04-18
        }

        private void select()
        {
            if (Sp.GetInstance().IsOpen() == false)
            {
                return;
            }
            int intSelTarget = this.cbxSelTarget.SelectedIndex;
            int intAction = this.cbxAction.SelectedIndex;
            int intSelMemBank = this.cbxSelMemBank.SelectedIndex;

            int intSelPointer = Convert.ToInt32((txtSelPrt3.Text + txtSelPrt2.Text + txtSelPrt1.Text + txtSelPrt0.Text), 16);
            int intMaskLen = Convert.ToInt32(txtSelLength.Text, 16);
            int intSelDataMSB = intSelMemBank + intAction * 4 + intSelTarget * 32;
            int intTruncate = 0;

            Sp.GetInstance().Send(Commands.RFID_Q_SetSelect(ReaderDeviceAddress,intSelTarget, intAction, intSelMemBank, intSelPointer, intMaskLen, intTruncate, txtSelMask.Text));
            Thread.Sleep(20);
        }

        private void btn_invtread_Click(object sender, EventArgs e)
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string strAccessPasswd = txtRwAccPassWord.Text.Replace(" ", "");
            if (strAccessPasswd.Length != 8)
            {
                MessageBox.Show("Access password should be two words!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int wordPtr = Convert.ToInt32((txtWordPtr1.Text.Replace(" ","") + txtWordPtr0.Text.Replace(" ","")),16);
            int wordCnt =Convert.ToInt32((txtWordCnt1.Text.Replace(" ","") + txtWordCnt0.Text.Replace(" ","")),16);

            int intMemBank = cbxMemBank.SelectedIndex;

            select();

            txtSend.Text = Commands.RFID_Q_ReadData(ReaderDeviceAddress,strAccessPasswd, intMemBank, wordPtr, wordCnt);
            Sp.GetInstance().Send(txtSend.Text);

        }

        private String int2HexString(int a)
        {
            byte byte_a = Convert.ToByte(a);
            string str = byte_a.ToString("x").ToUpper();
            str = StringToString(str);
            return str;
        }
        private void btnSetSelect_Click(object sender, EventArgs e)
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int intSelTarget = this.cbxSelTarget.SelectedIndex;
            int intAction = this.cbxAction.SelectedIndex;
            int intSelMemBank = this.cbxSelMemBank.SelectedIndex;

            int intSelPointer = Convert.ToInt32((txtSelPrt3.Text + txtSelPrt2.Text + txtSelPrt1.Text + txtSelPrt0.Text),16);
            int intMaskLen = Convert.ToInt32(txtSelLength.Text, 16);
            int intSelDataMSB = intSelMemBank + intAction * 4 + intSelTarget * 32;
            int intTruncate = 0;
            if (this.ckxTruncated.Checked == true)
            {
                intTruncate = 0x80;
            }

			txtSend.Text = Commands.RFID_Q_SetSelect(ReaderDeviceAddress,intSelTarget, intAction, intSelMemBank, intSelPointer, intMaskLen, intTruncate, txtSelMask.Text);
            Sp.GetInstance().Send(txtSend.Text);
            //inv_mode.Checked = true;
        }

        private void btnGetSelect_Click(object sender, EventArgs e)
        {
			txtSend.Text = Commands.RFID_Q_GetSelect(ReaderDeviceAddress);
            Sp.GetInstance().Send(txtSend.Text);
        }

        private void btnInvtWrtie_Click(object sender, EventArgs e)
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string strAccessPasswd = txtRwAccPassWord.Text.Replace(" ", "");
            if (strAccessPasswd.Length != 8)
            {
                MessageBox.Show("Access password should be two words!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string strDate4Write = txtInvtRWData.Text.Replace(" ", "");

            int intMemBank = cbxMemBank.SelectedIndex;
            int wordPtr = Convert.ToInt32((txtWordPtr1.Text.Replace(" ","") + txtWordPtr0.Text.Replace(" ","")),16);
            int wordCnt = strDate4Write.Length / 4; // in word!

            if (strDate4Write.Length % 4 != 0)
            {
                MessageBox.Show("The Write Data's Length Should Be Integer Multiples Words", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //if (strDate4Write.Length > 16 * 4)
            //{
            //    MessageBox.Show("Write Data Length Limit is 16 Words", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            select();
            txtSend.Text = Commands.RFID_Q_WriteData(ReaderDeviceAddress,strAccessPasswd, intMemBank, wordPtr, wordCnt, strDate4Write);
            Sp.GetInstance().Send(txtSend.Text);

        }

        private void buttonLock_Click(object sender, EventArgs e)
        {
            if (textBoxLockAccessPwd.Text.Length == 0) return;
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            select();

            int lockPayload = buildLockPayload();
            txtSend.Text = Commands.RFID_Q_Lock(ReaderDeviceAddress,textBoxLockAccessPwd.Text, lockPayload);
            Sp.GetInstance().Send(txtSend.Text);
        }

        private int buildLockPayload()
        {
            int ld = 0;
            Commands.lock_payload_type payload;
            if (checkBoxKillPwd.Checked)
            {
                payload = Commands.genLockPayload((byte)cbxLockKillAction.SelectedIndex, 0x00);
                ld |= (payload.byte0 << 16) | (payload.byte1 << 8) | (payload.byte2);
            }
            if (checkBoxAccessPwd.Checked)
            {
                payload = Commands.genLockPayload((byte)cbxLockAccessAction.SelectedIndex, 0x01);
                ld |= (payload.byte0 << 16) | (payload.byte1 << 8) | (payload.byte2);
            }
            if (checkBoxEPC.Checked)
            {
                payload = Commands.genLockPayload((byte)cbxLockEPCAction.SelectedIndex, 0x02);
                ld |= (payload.byte0 << 16) | (payload.byte1 << 8) | (payload.byte2);
            }
            if (checkBoxTID.Checked)
            {
                payload = Commands.genLockPayload((byte)cbxLockTIDAction.SelectedIndex, 0x03);
                ld |= (payload.byte0 << 16) | (payload.byte1 << 8) | (payload.byte2);
            }
            if (checkBoxUser.Checked)
            {
                payload = Commands.genLockPayload((byte)cbxLockUserAction.SelectedIndex, 0x04);
                ld |= (payload.byte0 << 16) | (payload.byte1 << 8) | (payload.byte2);
            }
            return ld;
        }

        private void buttonKill_Click(object sender, EventArgs e)
        {
            if (textBoxKillPwd.Text.Length == 0) return;

            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string strKillPasswd = textBoxKillPwd.Text.Replace(" ", "");
            if (strKillPasswd.Length != 8)
            {
                MessageBox.Show("Kill password should be two words!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int killRfu = 0;
            string strKillRfu = textBoxKillRFU.Text.Replace(" ", "");
            if (strKillRfu.Length == 0)
            {
                killRfu = 0;
            }
            else if (strKillRfu.Length != 3)
            {
                MessageBox.Show("Kill RFU/Recom should be 3 bits!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    killRfu = Convert.ToInt32(strKillRfu, 2);
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine("Convert Kill RFU fail." + ex.Message);
                    MessageBox.Show("Kill RFU/Recom should be 3 bits!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            select();

            txtSend.Text = Commands.RFID_Q_Kill(ReaderDeviceAddress,strKillPasswd, killRfu);
            Sp.GetInstance().Send(txtSend.Text);
        }

        private void inv_mode_CheckedChanged(object sender, EventArgs e)
        {
            if (inv_mode.Checked)
            {
                txtSend.Text = Commands.RFID_Q_SetInventoryMode(ReaderDeviceAddress,ConstCode.INVENTORY_MODE0);  //INVENTORY_MODE0
            }
            else
            {
                txtSend.Text = Commands.RFID_Q_SetInventoryMode(ReaderDeviceAddress,ConstCode.INVENTORY_MODE1);  //INVENTORY_MODE1
            }
            Sp.GetInstance().Send(txtSend.Text);
        }

        private void ckxTruncated_CheckedChanged(object sender, EventArgs e)
        {
            if (ckxTruncated.Checked)
            {
                int intSelTarget = this.cbxSelTarget.SelectedIndex;
                int intSelMemBank = this.cbxSelMemBank.SelectedIndex;
                if (intSelTarget != 4 || intSelMemBank != 1)
                {
                    MessageBox.Show("Select Target should be 100 and MemBank should be EPC", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ckxTruncated.Checked = false;
                }
            }
        }

        private void btnSetFhss_Click(object sender, EventArgs e)
        {
            /*if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (btnSetFhss.Text == "FHSS ON")
            {
                txtSend.Text = Commands.RFID_Q_SetFhss(ReaderDeviceAddress,ConstCode.SET_ON);
            }
            else
            {
                txtSend.Text = Commands.RFID_Q_SetFhss(ReaderDeviceAddress,ConstCode.SET_OFF);
            }
            Sp.GetInstance().Send(txtSend.Text);

            if (btnSetFhss.Text == "FHSS ON")
            {
                btnSetFhss.Text = "FHSS OFF";
            }
            else
            {
                btnSetFhss.Text = "FHSS ON";
            }
             * */

            if (cbxFHSS.SelectedIndex!=0)
            {
                txtSend.Text = Commands.RFID_Q_SetFhss(ReaderDeviceAddress, ConstCode.SET_ON);
            }
            else
            {
                txtSend.Text = Commands.RFID_Q_SetFhss(ReaderDeviceAddress, ConstCode.SET_OFF);
            }
            Sp.GetInstance().Send(txtSend.Text);

        }

        private void btnGetFhss_Click(object sender, EventArgs e)
        { //2019-01-26
            txtSend.Text = Commands.RFID_Q_GetFhss(ReaderDeviceAddress);
            Sp.GetInstance().Send(txtSend.Text);
        }

		private void btnSetFreqHopPeriod_Click(object sender, EventArgs e)
		{
			ushort FhssPeriod= (ushort)((cbxFhssHopPeriod.SelectedIndex+1)*100);
			txtSend.Text = Commands.RFID_Q_SetFhssPeriod(ReaderDeviceAddress, FhssPeriod);
			Sp.GetInstance().Send(txtSend.Text);
		}

		private void btnGetFreqHopPeriod_Click(object sender, EventArgs e)
		{
			txtSend.Text = Commands.RFID_Q_GetFhssPeriod(ReaderDeviceAddress);
			Sp.GetInstance().Send(txtSend.Text);
		}

        private string curRegion = ConstCode.REGION_CODE_CHN2;
        private string hardwareVersion;
        private bool checkingReaderAvailable=false;
        private bool readerConnected;
		private string GetRegionValueFromUI(int IndexRegeion)
		{
			string strRegion;
			switch (IndexRegeion)
			{
				case 0:	 // China 2
					strRegion = ConstCode.REGION_CODE_CHN2;
					break;
				case 1:	 // China 1
					strRegion = ConstCode.REGION_CODE_CHN1;
					break;
				case 2:	// US
					strRegion = ConstCode.REGION_CODE_US;
					break;
				case 3:	 // Europe
					strRegion = ConstCode.REGION_CODE_EUR;
					break;
				case 4:	 // Korea
					strRegion = ConstCode.REGION_CODE_KOREA;
					break;
				default:
					strRegion = ConstCode.REGION_CODE_CHN2;
					break;
			}
			return strRegion;
		}
        private void btnSetRegion_Click(object sender, EventArgs e)
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
			/*string frame = string.Empty;
			if (cbxRegion.SelectedIndex == 0) // China 2
			{
				frame = Commands.RFID_Q_SetRegion(ReaderDeviceAddress,ConstCode.REGION_CODE_CHN2);
				curRegion = ConstCode.REGION_CODE_CHN2;
			}
			else if (cbxRegion.SelectedIndex == 1) // China 1
			{
				frame = Commands.RFID_Q_SetRegion(ReaderDeviceAddress,ConstCode.REGION_CODE_CHN1);
				curRegion = ConstCode.REGION_CODE_CHN1;
			}
			else if (cbxRegion.SelectedIndex == 2) // US
			{
				frame = Commands.RFID_Q_SetRegion(ReaderDeviceAddress,ConstCode.REGION_CODE_US);
				curRegion = ConstCode.REGION_CODE_US;
			}
			else if (cbxRegion.SelectedIndex == 3) // Europe
			{
				frame = Commands.RFID_Q_SetRegion(ReaderDeviceAddress,ConstCode.REGION_CODE_EUR);
				curRegion = ConstCode.REGION_CODE_EUR;
			}
			else if (cbxRegion.SelectedIndex == 4) // Korea
			{
				frame = Commands.RFID_Q_SetRegion(ReaderDeviceAddress,ConstCode.REGION_CODE_KOREA);
				curRegion = ConstCode.REGION_CODE_KOREA;
			}			
            txtSend.Text = frame;
            Sp.GetInstance().Send(frame); */

			curRegion = GetRegionValueFromUI(cbxRegion.SelectedIndex);
			txtSend.Text = Commands.RFID_Q_SetRegion(ReaderDeviceAddress, curRegion);
			Sp.GetInstance().Send(txtSend.Text);
            cbxChannel.SelectedIndex = 0;
        }

		private void btnGetRegion_Click(object sender, EventArgs e)
		{
			txtSend.Text = Commands.RFID_Q_GetRegion(ReaderDeviceAddress);
			Sp.GetInstance().Send(txtSend.Text);
		}
		private void ChangedRFchannelTableFromFreqRegion(int IndexFreqRegion)
		{//2019-01-26
			string strIndex;
			cbxChannel.Items.Clear();
			switch (IndexFreqRegion)
			{
				case 0: // China 2
					for (int i = 0; i < 20; i++)
					{
						strIndex = i.ToString("D2") + "-";
						this.cbxChannel.Items.Add(strIndex + (920.125 + i * 0.25).ToString() + "MHz");
					}
					break;
				case 1: // China 1
					for (int i = 0; i < 20; i++)
					{
						strIndex = i.ToString("D2") + "-";
						this.cbxChannel.Items.Add(strIndex + (840.125 + i * 0.25).ToString() + "MHz");
					}
					break;
				case 2: // US
					for (int i = 0; i < 52; i++)
					{
						strIndex = i.ToString("D2") + "-";
						this.cbxChannel.Items.Add(strIndex + (902.25 + i * 0.5).ToString() + "MHz");
					}
					break;
				case 3: // Europe
					for (int i = 0; i < 15; i++)
					{
						strIndex = i.ToString("D2") + "-";
						this.cbxChannel.Items.Add(strIndex + (865.1 + i * 0.2).ToString() + "MHz");
					}
					break;
				case 4:  // Korea
					for (int i = 0; i < 32; i++)
					{
						strIndex = i.ToString("D2") + "-";
						this.cbxChannel.Items.Add(strIndex + (917.1 + i * 0.2).ToString() + "MHz");
					}
					break;
				default:
					break;
			}
			cbxChannel.SelectedIndex = 0;
		}
        private void cbxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*cbxChannel.Items.Clear(); 
            switch (cbxRegion.SelectedIndex)
            {
                case 0 : // China 2
                    for (int i = 0; i < 20; i++)
                    {
                        this.cbxChannel.Items.Add((920.125 + i * 0.25).ToString() + "MHz");
                    }
            	    break;
                case 1: // China 1
                    for (int i = 0; i < 20; i++)
                    {
                        this.cbxChannel.Items.Add((840.125 + i * 0.25).ToString() + "MHz");
                    }
                    break;
                case 2: // US
                    for (int i = 0; i < 52; i++)
                    {
                        this.cbxChannel.Items.Add((902.25 + i * 0.5).ToString() + "MHz");
                    }
                    break;
                case 3: // Europe
                    for (int i = 0; i < 15; i++)
                    {
                        this.cbxChannel.Items.Add((865.1 + i * 0.2).ToString() + "MHz");
                    }
                        break;
                case 4:  // Korea
                        for (int i = 0; i < 32; i++)
                        {
                            this.cbxChannel.Items.Add((917.1 + i * 0.2).ToString() + "MHz");
                        }
                        break;
                default :
                        break;
            }  */
			ChangedRFchannelTableFromFreqRegion(cbxRegion.SelectedIndex);
            cbxChannel.SelectedIndex = 0;
        }

        private void btnGetChannel_Click(object sender, EventArgs e)
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            btnGetRegion_Click(null, null);// Get Region firstly;
            Thread.Sleep(10);

            txtSend.Text = Commands.RFID_Q_GetRfChannel(ReaderDeviceAddress);
            Sp.GetInstance().Send(txtSend.Text);
        }

        private void btnSetPaPower_Click(object sender, EventArgs e)
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int powerDBm = 0;
            float powerFloat = 0;
            try
            {
                powerFloat = float.Parse(cbxPaPower.SelectedItem.ToString().Replace("dBm", ""));
                powerDBm = (int)(powerFloat * 100);
            }
            catch (Exception formatException)
            {
                Console.WriteLine(formatException.ToString());
                switch (cbxPaPower.SelectedIndex)
                {
                    case 5:
                        powerDBm = 1250;
                        break;
                    case 4:
                        powerDBm = 1400;
                        break;
                    case 3:
                        powerDBm = 1550;
                        break;
                    case 2:
                        powerDBm = 1700;
                        break;
                    case 1:
                        powerDBm = 1850;
                        break;
                    case 0:
                        powerDBm = 2000;
                        break;
                    default:
                        powerDBm = 2000;
                        break;
                }
            }
            txtSend.Text = Commands.RFID_Q_SetPaPower(ReaderDeviceAddress,(Int16)powerDBm);
            Sp.GetInstance().Send(txtSend.Text);
        }

        private void btnGetPaPower_Click(object sender, EventArgs e)
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtSend.Text = Commands.RFID_Q_GetPaPower(ReaderDeviceAddress);
            Sp.GetInstance().Send(txtSend.Text);
        }

        private void btnSetModemPara_Click(object sender, EventArgs e)
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            int mixerGain = cbxMixerGain.SelectedIndex;
            int IFAmpGain = cbxIFAmpGain.SelectedIndex;
            int signalTh = Convert.ToInt32(tbxSignalThreshold.Text,16);
            txtSend.Text = Commands.RFID_Q_SetModemPara(ReaderDeviceAddress,mixerGain, IFAmpGain, signalTh);
            Sp.GetInstance().Send(txtSend.Text);
        }

        private void btnGetModemPara_Click(object sender, EventArgs e)
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtSend.Text = Commands.RFID_Q_ReadModemPara(ReaderDeviceAddress);
            Sp.GetInstance().Send(txtSend.Text);
        }

        private string ParseErrCode(int errorCode)
        {
            switch (errorCode & 0x0F)
            {
                case ConstCode.ERROR_CODE_OTHER_ERROR :
                    return "Other Error";
                case ConstCode.ERROR_CODE_MEM_OVERRUN:
                    return "Memory Overrun";
                case ConstCode.ERROR_CODE_MEM_LOCKED:
                    return "Memory Locked";
                case ConstCode.ERROR_CODE_INSUFFICIENT_POWER:
                    return "Insufficient Power";
                case ConstCode.ERROR_CODE_NON_SPEC_ERROR:
                    return "Non-specific Error";
                default :
                    return "Non-specific Error";
            }
        }

        private void btnScanJammer_Click(object sender, EventArgs e)
        {
            txtSend.Text = Commands.RFID_Q_ScanJammer(ReaderDeviceAddress);
            Sp.GetInstance().Send(txtSend.Text);
        }

        private void saveAsTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            //File type filter
            save.Filter = "*.csv|*.CSV|*.*|(*.*)";

            if (save.ShowDialog() == DialogResult.OK)
            {
                string name = save.FileName;
                FileInfo info = new FileInfo(name);
                //info.Delete();
                StreamWriter writer = null;
                try
                {
                    writer = info.CreateText();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    writer.Write("No.,PC,EPC,CRC,RSSI(dBm),CNT,PER(%),");
                    writer.WriteLine();
                    for (int i = 0; i < basic_table.Rows.Count; i++)
                    {
                        for(int j = 0; j < basic_table.Columns.Count; j++)
                        {
                            writer.Write(basic_table.Rows[i][j].ToString()+",");
                        }
                        writer.WriteLine();
                        //writer.Write(richTextBox1.Text);
                    }
                    writer.Close();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnScanRssi_Click(object sender, EventArgs e)
        {
            txtSend.Text = Commands.RFID_Q_ScanRssi(ReaderDeviceAddress);
            Sp.GetInstance().Send(txtSend.Text);
        }

        private void timerCheckReader_Tick(object sender, EventArgs e)
        {
            timerCheckReader.Enabled = false;
            if (hardwareVersion == "")
            {
                MessageBox.Show("Connect Reader Failed, Please Check if the Com port and the power is OK!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                readerConnected = false;
            }
            else
            {
                //MessageBox.Show("Connect Success! Hardware version: " + hardwareVersion, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                readerConnected = true;
            }
        }

        private void Reset_FW_Click(object sender, EventArgs e)
        {//CMD_TEST_RESET
			txtSend.Text = Commands.RFID_Q_ResetReader(ReaderDeviceAddress);
            Sp.GetInstance().Send(txtSend.Text);

            Thread.Sleep(100);
            if (!Sp.GetInstance().Close())
            {
                MessageBox.Show("Serial Port Close Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnConn.Text = "Connect";
            btnConn.Tag = "0";
            this.btnConn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
        }

        int lastRecCnt = 0;
        private void tmrCheckEpc_Tick(object sender, EventArgs e)
        {
            if (lastRecCnt == Convert.ToInt32(txtCOMRxCnt.Text)) // no data received during last Tick, it may mean the Read Continue stoped
            {
                tmrCheckEpc.Enabled = false;
                return;
            }
            lastRecCnt = Convert.ToInt32(txtCOMRxCnt.Text);
            DateTime now = System.DateTime.Now;
            DateTime dt;
            DateTimeFormatInfo dtFormat = new System.Globalization.DateTimeFormatInfo();

            dtFormat.LongDatePattern = timeFormat;

            int timeout = (10 * tmrCheckEpc.Interval);
            for (int i = 0; i < this.dgvEpcBasic.Rows.Count; i++)
            {
                string time = this.dgvEpcBasic.Rows[i].Cells[7].Value.ToString();
                if (null != time && !"".Equals(time))
                {
                    //dt = Convert.ToDateTime(time, dtFormat);
                    //dt = DateTime.ParseExact(time, timeFormat, CultureInfo.InvariantCulture);
                    if (DateTime.TryParse(time,out dt))
                    {
                        TimeSpan sub = now.Subtract(dt);
                        if (sub.TotalMilliseconds > timeout)
                        {
                            this.dgvEpcBasic.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        }
                        //else if ((sub.TotalMilliseconds > (tmrCheckEpc.Interval + 100)))
                        //{
                        //    this.dgvEpcBasic.Rows[i].DefaultCellStyle.BackColor = Color.Pink;
                        //}
                        else
                        {
                            int r = 0xFF & (int)(sub.TotalMilliseconds / timeout * 255);
                            //this.dgvEpcBasic.Rows[i].DefaultCellStyle.BackColor = Color.White;
                            this.dgvEpcBasic.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(0xff,255 - r ,255 - r);

                        }
                    }

                }
            }

        }
        //-----------------------------------------------------------------Module Reader
        private void btnSetIO_Click(object sender, EventArgs e)
        {
            byte para0 = 0x01;
            byte para1 = (byte)(cbxIO.SelectedIndex + 1);
            byte para2 = (byte)cbxIoLevel.SelectedIndex;
            txtSend.Text = Commands.RFID_Q_IoControl(ReaderDeviceAddress,para0, para1, para2);
            Sp.GetInstance().Send(txtSend.Text);
        }

        private void btnSetIoDirection_Click(object sender, EventArgs e)
        {
            byte para0 = 0x00;
            byte para1 = (byte)(cbxIO.SelectedIndex + 1);
            byte para2 = (byte)cbxIoDircetion.SelectedIndex;
            txtSend.Text = Commands.RFID_Q_IoControl(ReaderDeviceAddress,para0, para1, para2);
            Sp.GetInstance().Send(txtSend.Text);
        }

        private void btnGetIO_Click(object sender, EventArgs e)
        {
            byte para0 = 0x02;
            byte para1 = (byte)(cbxIO.SelectedIndex + 1);
            byte para2 = 0x00;
            txtSend.Text = Commands.RFID_Q_IoControl(ReaderDeviceAddress,para0, para1, para2);
            Sp.GetInstance().Send(txtSend.Text);
        }
        //-----------------------------------------------------------------// for Fixed Reader Only
        private void button_GPIO_Get_Click(object sender, EventArgs e)
        {

        }

        private void button_GPIO_Set_Click(object sender, EventArgs e)
        {

        }
        //-----------------------------------------------------------------
        private void btnSetMode_Click(object sender, EventArgs e)
        {
            txtSend.Text = Commands.RFID_Q_SetReaderEnvMode(ReaderDeviceAddress,(byte)cbxMode.SelectedIndex);
            Sp.GetInstance().Send(txtSend.Text);
        }

        private void btnSaveConfigToNv_Click(object sender, EventArgs e)
        {
            byte NV_enable = cbxSaveNvConfig.Checked ? (byte)0x01 : (byte)0x00;
            txtSend.Text = Commands.RFID_Q_SaveConfigToNv(ReaderDeviceAddress,NV_enable);
            Sp.GetInstance().Send(txtSend.Text);
        }

        private void btnSetModuleSleep_Click(object sender, EventArgs e)
        {
            txtSend.Text = Commands.RFID_Q_SetModuleSleep(ReaderDeviceAddress);
            Sp.GetInstance().Send(txtSend.Text);
        }

        private void btnInsertRfCh_Click(object sender, EventArgs e)
        {
            byte[] channelList;
            int chIndexBegin = Convert.ToInt32(txtChIndexBegin.Text);
            int chIndexEnd = Convert.ToInt32(txtChIndexEnd.Text);
            byte channelNum = (byte)(chIndexEnd - chIndexBegin + 1);
            if (chIndexBegin > chIndexEnd)
            {
                MessageBox.Show("Insert parameter is invalid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            channelList = new byte[channelNum];
            for (int i = chIndexBegin; i <= chIndexEnd; i++)
            {
                channelList[i - chIndexBegin] = (byte)i;
            }
            txtSend.Text = Commands.RFID_Q_InsertRfCh(ReaderDeviceAddress,channelNum, channelList);
            Sp.GetInstance().Send(txtSend.Text);
        }

		private void btnInsertRfCh_Get_Click(object sender, EventArgs e)
		{
            txtSend.Text = Commands.RFID_Q_GetInrRfCh(ReaderDeviceAddress);
            Sp.GetInstance().Send(txtSend.Text);
		}

        private void btnInsertRfCh_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. \"Set Region\" to Cancel the  Insert RF Channel!\r\n2. FHSS=\"ON\"!", 
                "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnChangeConfig_Click(object sender, EventArgs e)
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string strAccessPasswd = tbxNxpCmdAccessPwd.Text.Replace(" ", "");
            if (strAccessPasswd.Length != 8)
            {
                MessageBox.Show("Access password should be two words!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            select();

            txtSend.Text = Commands.RFID_Q_NXPChangeConfig(ReaderDeviceAddress, strAccessPasswd, Convert.ToInt32(txtConfigData.Text.Replace(" ",""), 16));
            Sp.GetInstance().Send(txtSend.Text);
        }

        private void btnChangeEas_Click(object sender, EventArgs e)
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string strAccessPasswd = tbxNxpCmdAccessPwd.Text.Replace(" ", "");
            if (strAccessPasswd.Length != 8)
            {
                MessageBox.Show("Access password should be two words!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            select();

            txtSend.Text = Commands.RFID_Q_NXPChangeEas(ReaderDeviceAddress,strAccessPasswd, cbxSetEas.Checked);
            Sp.GetInstance().Send(txtSend.Text);
        }

        private void btnEasAlarm_Click(object sender, EventArgs e)
        {
            txtSend.Text = Commands.RFID_Q_NXPEasAlarm(ReaderDeviceAddress);
            Sp.GetInstance().Send(txtSend.Text);
        }

        private void btnReadProtect_Click(object sender, EventArgs e)
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string strAccessPasswd = tbxNxpCmdAccessPwd.Text.Replace(" ", "");
            if (strAccessPasswd.Length != 8)
            {
                MessageBox.Show("Access password should be two words!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            select();

            txtSend.Text = Commands.RFID_Q_NXPReadProtect(ReaderDeviceAddress, strAccessPasswd, cbxReadProtectReset.Checked);
            Sp.GetInstance().Send(txtSend.Text);
        }

        
        private void txtOperateEpc_DoubleClick(object sender, EventArgs e)
        {
            txtOperateEpc.SelectAll();
        }

        #region MONZA_TAG_NO_WORKING
        private void btnMonzaQTRead_Click(object sender, EventArgs e)
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string strAccessPasswd = tbxMonzaQTAccessPwd.Text.Replace(" ", "");
            if (strAccessPasswd.Length != 8)
            {
                MessageBox.Show("Access password should be two words!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            select();

            txtSend.Text = Commands.RFID_Q_MonzaQT(ReaderDeviceAddress,strAccessPasswd, false, cbxMonzaQT_SR.Checked, cbxMonzaQT_MEM.Checked);
            Sp.GetInstance().Send(txtSend.Text);
        }

        private void btnMonzaQTWrite_Click(object sender, EventArgs e)
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string strAccessPasswd = tbxMonzaQTAccessPwd.Text.Replace(" ", "");
            if (strAccessPasswd.Length != 8)
            {
                MessageBox.Show("Access password should be two words!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            select();

            txtSend.Text = Commands.RFID_Q_MonzaQT(ReaderDeviceAddress,strAccessPasswd, true, cbxMonzaQT_SR.Checked, cbxMonzaQT_MEM.Checked);
            Sp.GetInstance().Send(txtSend.Text);
        }
        #endregion

        private void getFirmwareVersion()
        {
            //string sendApiString = Commands.RFID_Q_GetModuleInfo(ConstCode.READER_DEVICEADDR_BROADCAST,ConstCode.MODULE_SOFTWARE_VERSION_FIELD);
            txtSend.Text = Commands.RFID_Q_GetModuleInfo(ReaderDeviceAddress, ConstCode.MODULE_SOFTWARE_VERSION_FIELD);
            Sp.GetInstance().Send(txtSend.Text);

            txtSend.Text = Commands.RFID_Q_GetModuleFirmWare(ReaderDeviceAddress);
            Sp.GetInstance().Send(txtSend.Text);
        }

        private void button_Test_Click(object sender, EventArgs e)
        {
            
        }

        //----------------------------------------------------------------------------------
        private void GetReaderDeviceAddr()
        {// If we do not know the current Reader's Device Address, we can use the Broadcast Device Address to get it.
            txtSend.Text = Commands.RFID_Q_ReaderDeviceAddr(ConstCode.READER_DEVICEADDR_BROADCAST, ConstCode.READER_OPERATION_GET, 0);
            Sp.GetInstance().Send(txtSend.Text);
        }
        private void btn_SetReaderDeviceAddr_Click(object sender, EventArgs e)
        {
            //txtSend.Text = Commands.RFID_Q_ReaderDeviceAddr(ConstCode.READER_DEVICEADDR_BROADCAST, ConstCode.READER_OPERATION_SET, cbxDeviceAddr.SelectedIndex);
            txtSend.Text = Commands.RFID_Q_ReaderDeviceAddr(ReaderDeviceAddress, ConstCode.READER_OPERATION_SET, cbxNewDeviceAddr.SelectedIndex);
            Sp.GetInstance().Send(txtSend.Text);
        }

        private void btn_GetReaderDeviceAddr_Click(object sender, EventArgs e)
        {
            //txtSend.Text = Commands.RFID_Q_ReaderDeviceAddr(ConstCode.READER_DEVICEADDR_BROADCAST, ConstCode.READER_OPERATION_GET, cbxDeviceAddr.SelectedIndex);
            txtSend.Text = Commands.RFID_Q_ReaderDeviceAddr(ReaderDeviceAddress, ConstCode.READER_OPERATION_GET, cbxDeviceAddr.SelectedIndex);
            Sp.GetInstance().Send(txtSend.Text);
        }

        private void btn_SetNewBaudRate_Click(object sender, EventArgs e) //2018-11-09
        {
            /*Actually Baud Rate Data is:
	        0=9600     
	        1=19200  
	        2=28800  
	        3=38400  
	        4=57600   
	        5=115200 
	        */
            int BaudRate = cbxNewBaudRate.SelectedIndex;
            txtSend.Text = Commands.RFID_Q_SetUartBaudRateX(ReaderDeviceAddress, BaudRate);
            Sp.GetInstance().Send(txtSend.Text);
        }
        private void btn_GetNewBaudRate_Click(object sender, EventArgs e)
        {
            txtSend.Text = Commands.RFID_Q_GetUartBaudRate(ReaderDeviceAddress);
            Sp.GetInstance().Send(txtSend.Text);
        }
        //===================================================================================
        private void BtnTest_Click(object sender, EventArgs e)
        {
            short stv = -17;
            ushort utv = (ushort)stv;
            short vst = (short)utv;
            string sst = stv.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }


        #region Sensor Tag Process

		DataTable SensorTag_table = new DataTable();
		DataSet ds_SensorTag = null;
		string SensorTag_Temperature = string.Empty;
		string SensorTag_SensorRssi = string.Empty;

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct SensorTag_MessageParam
		{
			public SensorTag_MessageParam(bool init)
			{
				UL=string.Empty;
				Pc=string.Empty;
				Epc=string.Empty;
				AntNo=string.Empty;
				Temperture=string.Empty;
                SensorRssi = string.Empty;
                TemprAverage = string.Empty;
            }	
			public string UL;
			public string Pc;			
			public string Epc;	
			public string AntNo; //Pc+Epc Length;			
			public string Temperture;
			public string SensorRssi;
			public string TemprAverage;
		}
		private SensorTag_MessageParam SensorTagMsg = new SensorTag_MessageParam(true);
        private void SensorTag_Inital()
        {
            //---------------------------------------------------
			this.dgv_SensorTag.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dgv_SensorTag_DataBindingComplete);
			ds_SensorTag = new DataSet();			
			SensorTag_table = SensorTag_GetEPCHead();
			ds_SensorTag.Tables.Add(SensorTag_table);
			DataView SensorTagDataViewEpc = ds_SensorTag.Tables[0].DefaultView;
			this.dgv_SensorTag.DataSource = SensorTagDataViewEpc;			
			SensorTag_DGV_ColumnsWidth(this.dgv_SensorTag);

			this.cbx_SensorTag_ReadNumber.SelectedIndex =9;
            this.cbx_SensorTag_SensorTagType.SelectedIndex = 0;// 2;
        }

		private DataTable SensorTag_GetEPCHead()
		{
			SensorTag_table.TableName = "SensorEPC";//2018-02-01
			SensorTag_table.Columns.Add("No.", typeof(string)); //0
			SensorTag_table.Columns.Add("PC", typeof(string)); //1
			SensorTag_table.Columns.Add("EPC", typeof(string)); //2
			SensorTag_table.Columns.Add("CRC", typeof(string)); //3
			SensorTag_table.Columns.Add("CNT", typeof(string));

			SensorTag_table.Columns.Add("Ant", typeof(string));
			SensorTag_table.Columns.Add("Tempr(°C)", typeof(string)); //4
			SensorTag_table.Columns.Add("SerRssi", typeof(string)); //4//4
			SensorTag_table.Columns.Add("Average(°C)", typeof(string)); 

            for (int i = 0; i <= initDataTableLen - 1; i++)
            {
                SensorTag_table.Rows.Add(new object[] { null });
            }
            SensorTag_table.AcceptChanges();

            return SensorTag_table;
        }

		private const int _SensorTag_DGV_ColumnsIndex_No =0;
		private const int _SensorTag_DGV_ColumnsIndex_PC =1;
		private const int _SensorTag_DGV_ColumnsIndex_Epc =2;
		private const int _SensorTag_DGV_ColumnsIndex_Crc =3;
		private const int _SensorTag_DGV_ColumnsIndex_Cnt =4;
		private const int _SensorTag_DGV_ColumnsIndex_Ant =5;
		private const int _SensorTag_DGV_ColumnsIndex_Temperature =6;
		private const int _SensorTag_DGV_ColumnsIndex_SensorRssi =7;
		private const int _SensorTag_DGV_ColumnsIndex_TemperAverage =8;
		
		private void SensorTag_DGV_ColumnsWidth(DataGridView dataGridView1)
		{
            if (appEnableFlag)
            {
                //dataGridView1.Columns[6].SortMode = DataGridViewColumnSortMode.Programmatic;
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.ColumnHeadersHeight = 40;
                //dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Lucida Console", 10);
                dataGridView1.Columns[_SensorTag_DGV_ColumnsIndex_No].Width = 40;
                //dataGridView1.Columns[0].DefaultCellStyle.Font = new Font("Lucida Console", 10);
                dataGridView1.Columns[_SensorTag_DGV_ColumnsIndex_No].Resizable = DataGridViewTriState.False;
                dataGridView1.Columns[_SensorTag_DGV_ColumnsIndex_No].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns[_SensorTag_DGV_ColumnsIndex_PC].Width = 60;
                //dataGridView1.Columns[1].DefaultCellStyle.Font = new Font("Lucida Console", 10);
                dataGridView1.Columns[_SensorTag_DGV_ColumnsIndex_PC].Resizable = DataGridViewTriState.False;
                dataGridView1.Columns[_SensorTag_DGV_ColumnsIndex_PC].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns[_SensorTag_DGV_ColumnsIndex_Epc].Width = 230;
                //dataGridView1.Columns[2].DefaultCellStyle.Font = new Font("Lucida Console", 10);
                dataGridView1.Columns[_SensorTag_DGV_ColumnsIndex_Epc].Resizable = DataGridViewTriState.False;
                dataGridView1.Columns[_SensorTag_DGV_ColumnsIndex_Epc].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns[_SensorTag_DGV_ColumnsIndex_Crc].Width = 60;
                //dataGridView1.Columns[3].DefaultCellStyle.Font = new Font("Lucida Console", 10);
                dataGridView1.Columns[_SensorTag_DGV_ColumnsIndex_Crc].Resizable = DataGridViewTriState.False;
                dataGridView1.Columns[_SensorTag_DGV_ColumnsIndex_Crc].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns[_SensorTag_DGV_ColumnsIndex_Cnt].Width = 70;
                //dataGridView1.Columns[6].DefaultCellStyle.Font = new Font("Lucida Console", 10);
                dataGridView1.Columns[_SensorTag_DGV_ColumnsIndex_Cnt].Resizable = DataGridViewTriState.False;
                dataGridView1.Columns[_SensorTag_DGV_ColumnsIndex_Cnt].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns[_SensorTag_DGV_ColumnsIndex_Ant].Width = 35;
                //dataGridView1.Columns[6].DefaultCellStyle.Font = new Font("Lucida Console", 10);
                dataGridView1.Columns[_SensorTag_DGV_ColumnsIndex_Ant].Resizable = DataGridViewTriState.False;
                dataGridView1.Columns[_SensorTag_DGV_ColumnsIndex_Ant].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns[_SensorTag_DGV_ColumnsIndex_Temperature].Width = 70;
                //dataGridView1.Columns[6].DefaultCellStyle.Font = new Font("Lucida Console", 10);
                dataGridView1.Columns[_SensorTag_DGV_ColumnsIndex_Temperature].Resizable = DataGridViewTriState.False;
                dataGridView1.Columns[_SensorTag_DGV_ColumnsIndex_Temperature].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns[_SensorTag_DGV_ColumnsIndex_SensorRssi].Width = 65;
                //dataGridView1.Columns[6].DefaultCellStyle.Font = new Font("Lucida Console", 10);
                dataGridView1.Columns[_SensorTag_DGV_ColumnsIndex_SensorRssi].Resizable = DataGridViewTriState.False;
                dataGridView1.Columns[_SensorTag_DGV_ColumnsIndex_SensorRssi].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns[_SensorTag_DGV_ColumnsIndex_TemperAverage].Width = 100;
                //dataGridView1.Columns[6].DefaultCellStyle.Font = new Font("Lucida Console", 10);
                dataGridView1.Columns[_SensorTag_DGV_ColumnsIndex_TemperAverage].Resizable = DataGridViewTriState.False;
                dataGridView1.Columns[_SensorTag_DGV_ColumnsIndex_TemperAverage].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//   .;MiddleLeft

                //Some Error , No Work!
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.Name = "SelectAll";
                checkBoxColumn.HeaderText = "Select";
                checkBoxColumn.Width = 45;
                dataGridView1.Columns.Insert(0, checkBoxColumn);
                //dataGridView1.Columns.Add(checkBoxColumn); //2018-02-01 
            }
			
		}
		private void dgv_SensorTag_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			//if (e.ListChangedType == ListChangedType.ItemChanged || e.ListChangedType == ListChangedType.ItemAdded)
			{
				for (int i = 0; i < this.dgv_SensorTag.Rows.Count; i++)
				{
					if (i % 2 == 0)
					{
						this.dgv_SensorTag.Rows[i].DefaultCellStyle.BackColor = Color.AliceBlue;
					}
				}
			}
        }

		private void dgv_SensorTag_ContentClick(object sender, DataGridViewCellEventArgs e)
        {//dgv_SensorTag CheckBox Setting....
			if (e.RowIndex >= 0 && e.ColumnIndex == 0)
			{
				//if (this.dgv_SensorTag.Rows[e.RowIndex].Cells["SelectAll"].Value.ToString() == "1")
				if ((bool)this.dgv_SensorTag.Rows[e.RowIndex].Cells[0].EditedFormattedValue==true)
				{// if Checked, unselect.
					//this.dgv_SensorTag.Rows[e.RowIndex].Cells["SelectAll"].Value = 0;
					this.dgv_SensorTag.Rows[e.RowIndex].Cells[0].Value = 0;
				}
				else
                {// if no Checked, selected.
					//this.dgv_SensorTag.Rows[e.RowIndex].Cells["SelectAll"].Value = 1;
					this.dgv_SensorTag.Rows[e.RowIndex].Cells[0].Value = 1;
				}
			}
        }

		private void btn_SelectAllSensorTag_Click(object sender, EventArgs e)
        {
			dgv_SensorTag.EndEdit();

			for (int i = 0; i < dgv_SensorTag.Rows.Count; i++)
			{
				//this.dgv_SensorTag.Rows[i].Cells["SelectAll"].Value = 1;
				this.dgv_SensorTag.Rows[i].Cells[0].Value = 1;
			}
        }

		private int iTemperatureValueErrCounter=0;
		private decimal dTemperaturePrev=0;
		private int TmpPrevIndex=0;
		private decimal[] dgTemperaturePrev=new decimal[100];
		private void SensorTag_MessageProcessOK(Commands.ReaderResponseFrameString rxStrPkts)   //  °C
		{ //rxStrPkts.strCmdH == ConstCode.CMD_SENSORTAG_READ

			SensorTagMsg.UL = rxStrPkts.strParameters[0];
			int PCEPCLength = ((Convert.ToInt32((rxStrPkts.strParameters[1]), 16)) / 8 + 1) * 2;
			SensorTagMsg.Pc= rxStrPkts.strParameters[1] + " " + rxStrPkts.strParameters[2];
			SensorTagMsg.Epc= string.Empty;

			int i;
			for (i = 0; i < PCEPCLength - 2; i++)
			{
				SensorTagMsg.Epc = SensorTagMsg.Epc + rxStrPkts.strParameters[3 + i];
			}
			SensorTagMsg.Epc = Commands.AutoAddSpace(SensorTagMsg.Epc);
			//crc = rxStrPkts.strParameters[1 + PCEPCLength] + " " + rxStrPkts.strParameters[2 + PCEPCLength];
			i = i + 3;
			SensorTagMsg.AntNo = rxStrPkts.strParameters[i++];

			//Get Temperature
			SensorTagMsg.Temperture = rxStrPkts.strParameters[i]+rxStrPkts.strParameters[i+1];
			short rTemperature = Convert.ToInt16(SensorTagMsg.Temperture, 16);
			decimal dTemperature = (decimal)rTemperature;
			dTemperature = dTemperature / 10;

			dgTemperaturePrev[TmpPrevIndex++]=dTemperature;
			TmpPrevIndex = TmpPrevIndex % 100;

			if (dTemperature > (decimal)120.0 || dTemperaturePrev < (decimal)(-60.0))
			{
				iTemperatureValueErrCounter++;
				setToolStripStatusMessage2(iTemperatureValueErrCounter.ToString(), Color.Red);
				return;//Temperature Is Error. 
			}

			//Get Sensor Rssi
			SensorTagMsg.Temperture = dTemperature.ToString("F1");
			i=i+2;
			SensorTagMsg.SensorRssi =DataConvert.HexToDec(rxStrPkts.strParameters[i]);						 
			
			SensorTag_GetEPCx(ref SensorTagMsg);

			Zed_AddTagTmprRssiInfor((double)dTemperature, Convert.ToDouble( SensorTagMsg.SensorRssi));
			Zedgraph_ScrollToRightSide();

			SensorTag_ReadTemprCounter++;
			if(SensorTag_ReadTemprCounter>=SensorTag_ReadTemprMaxNum)
			{
				SensorTag_ReadTemprCounter=0;
				this.SensorTag_ReadTemprEveWaitHandle.Set();// Release the Block 
			}

			string strShowMessage=string.Empty;
			strShowMessage = "Sensor Tag: " + SensorTagMsg.Epc + " [ " + SensorTagMsg.Temperture + "°C ]-{" + SensorTagMsg.SensorRssi + "}";
			setToolStripStatusMessage1(strShowMessage, Color.MediumSeaGreen);
		}
		private void SensorTag_MessageProcessFailed(Commands.ReaderResponseFrameString rxStrPkts)
		{//2019-04-28
            int PCEPCLength = ((Convert.ToInt32((rxStrPkts.strParameters[1]), 16)) / 8 + 1) * 2;
            pc = rxStrPkts.strParameters[1] + " " + rxStrPkts.strParameters[2];
            epc = string.Empty;
            for (int i = 0; i < PCEPCLength - 2; i++)
            {
                epc = epc + rxStrPkts.strParameters[3 + i];
            }
            epc = Commands.AutoAddSpace(epc);

            SensorTagMsg.Epc = epc;
			
			SensorTag_ReadTemprCounter++;
			if(SensorTag_ReadTemprCounter>=SensorTag_ReadTemprMaxNum)
			{
				SensorTag_ReadTemprCounter=0;
				this.SensorTag_ReadTemprEveWaitHandle.Set();// Release the Block 
			}
			string strShowMessage=string.Empty;
			strShowMessage = "Sensor Tag: " + SensorTagMsg.Epc + "- No Sensor Tag Found!" + SensorTag_ReadTemprCounter.ToString();
			setToolStripStatusMessage1(strShowMessage, Color.Red);
		}
        private void SensorTag_GetEPCx(ref SensorTag_MessageParam StagMsg)
        {
            this.dgv_SensorTag.ClearSelection();
            bool isFoundEpc = false;
            string newEpcItemCnt;
            int indexEpc = 0;

            int EpcItemCnt;
            if (rowIndex <= initDataTableLen)
            {
                EpcItemCnt = rowIndex;
            }
            else
            {
                EpcItemCnt = SensorTag_table.Rows.Count;
            }

            for (int j = 0; j < EpcItemCnt; j++)
            {
                if (SensorTag_table.Rows[j][_SensorTag_DGV_ColumnsIndex_Epc].ToString() == StagMsg.Epc
					&& SensorTag_table.Rows[j][_SensorTag_DGV_ColumnsIndex_PC].ToString() == StagMsg.Pc)
                {
                    indexEpc = j;
                    isFoundEpc = true;
                    break;
                }
            }

            if (EpcItemCnt < initDataTableLen) //basic_table.Rows[EpcItemCnt][0].ToString() == ""
            {
                if (!isFoundEpc || EpcItemCnt == 0)
                {
                    if (EpcItemCnt + 1 < 10)
                    {
                        newEpcItemCnt = "0" + Convert.ToString(EpcItemCnt + 1);
                    }
                    else
                    {
                        newEpcItemCnt = Convert.ToString(EpcItemCnt + 1);
                    }

                    SensorTag_table.Rows[EpcItemCnt][_SensorTag_DGV_ColumnsIndex_No] = newEpcItemCnt; // EpcItemCnt + 1;
                    SensorTag_table.Rows[EpcItemCnt][_SensorTag_DGV_ColumnsIndex_PC] = StagMsg.Pc;
                    SensorTag_table.Rows[EpcItemCnt][_SensorTag_DGV_ColumnsIndex_Epc] = StagMsg.Epc;
                    //SensorTag_table.Rows[EpcItemCnt][_SensorTag_DGV_ColumnsIndex_Crc] = crc;
                    SensorTag_table.Rows[EpcItemCnt][_SensorTag_DGV_ColumnsIndex_Cnt] = 1;
					SensorTag_table.Rows[EpcItemCnt][_SensorTag_DGV_ColumnsIndex_Ant] = StagMsg.AntNo;
					SensorTag_table.Rows[EpcItemCnt][_SensorTag_DGV_ColumnsIndex_Temperature] = StagMsg.Temperture;
					SensorTag_table.Rows[EpcItemCnt][_SensorTag_DGV_ColumnsIndex_SensorRssi] = StagMsg.SensorRssi;
					SensorTag_table.Rows[EpcItemCnt][_SensorTag_DGV_ColumnsIndex_TemperAverage] = StagMsg.TemprAverage;
                    rowIndex++;
                }
                else
                {
                    if (indexEpc + 1 < 10)
                    {
                        newEpcItemCnt = "0" + Convert.ToString(indexEpc + 1);
                    }
                    else
                    {
                        newEpcItemCnt = Convert.ToString(indexEpc + 1);
                    }

                    SensorTag_table.Rows[indexEpc][_SensorTag_DGV_ColumnsIndex_No] = newEpcItemCnt; // indexEpc + 1;
                    SensorTag_table.Rows[indexEpc][_SensorTag_DGV_ColumnsIndex_Cnt] = Convert.ToInt32(SensorTag_table.Rows[indexEpc][_SensorTag_DGV_ColumnsIndex_Cnt].ToString()) + 1;
					SensorTag_table.Rows[indexEpc][_SensorTag_DGV_ColumnsIndex_Ant] = StagMsg.AntNo;
					SensorTag_table.Rows[indexEpc][_SensorTag_DGV_ColumnsIndex_Temperature] = StagMsg.Temperture;
					SensorTag_table.Rows[indexEpc][_SensorTag_DGV_ColumnsIndex_SensorRssi] = StagMsg.SensorRssi;
					SensorTag_table.Rows[indexEpc][_SensorTag_DGV_ColumnsIndex_TemperAverage] = StagMsg.TemprAverage;
                }
            }
            else
            {
                if (!isFoundEpc || EpcItemCnt == 0)
                {
                    if (EpcItemCnt + 1 < 10)
                    {
                        newEpcItemCnt = "0" + Convert.ToString(EpcItemCnt + 1);
                    }
                    else
                    {
                        newEpcItemCnt = Convert.ToString(EpcItemCnt + 1);
                    }
                    SensorTag_table.Rows.Add(new object[] { newEpcItemCnt, StagMsg.Pc, StagMsg.Epc, crc, "1", StagMsg.AntNo,StagMsg.Temperture,StagMsg.SensorRssi});
                    rowIndex++;
                }
                else
                {
                    if (indexEpc + 1 < 10)
                    {
                        newEpcItemCnt = "0" + Convert.ToString(indexEpc + 1);
                    }
                    else
                    {
                        newEpcItemCnt = Convert.ToString(indexEpc + 1);
                    }
                    SensorTag_table.Rows[indexEpc][_SensorTag_DGV_ColumnsIndex_No] = newEpcItemCnt; // indexEpc + 1;
                    SensorTag_table.Rows[indexEpc][_SensorTag_DGV_ColumnsIndex_Cnt] = Convert.ToInt32(SensorTag_table.Rows[indexEpc][_SensorTag_DGV_ColumnsIndex_Cnt].ToString()) + 1;
					SensorTag_table.Rows[indexEpc][_SensorTag_DGV_ColumnsIndex_Ant] = StagMsg.AntNo;
					SensorTag_table.Rows[indexEpc][_SensorTag_DGV_ColumnsIndex_Temperature] = StagMsg.Temperture;
					SensorTag_table.Rows[indexEpc][_SensorTag_DGV_ColumnsIndex_SensorRssi] = StagMsg.SensorRssi;
					SensorTag_table.Rows[indexEpc][_SensorTag_DGV_ColumnsIndex_TemperAverage] = StagMsg.TemprAverage;
                }
            }
        }
		
        private void SensorTag_GetEPC(string pc, string epc, string crc, string rssi , string per)
        {
            this.dgv_epc2.ClearSelection();
            bool isFoundEpc = false;
            string newEpcItemCnt;
            int indexEpc = 0;

            int EpcItemCnt;
            if (rowIndex <= initDataTableLen)
            {
                EpcItemCnt = rowIndex;
            }
            else
            {
                EpcItemCnt = SensorTag_table.Rows.Count;
            }

            for (int j = 0; j < EpcItemCnt; j++)
            {
                if (SensorTag_table.Rows[j][_SensorTag_DGV_ColumnsIndex_Epc].ToString() == epc && SensorTag_table.Rows[j][_SensorTag_DGV_ColumnsIndex_PC].ToString() == pc)
                {
                    indexEpc = j;
                    isFoundEpc = true;
                    break;
                }
            }

            if (EpcItemCnt < initDataTableLen) //SensorTag_table.Rows[EpcItemCnt][0].ToString() == ""
            {
                if (!isFoundEpc || EpcItemCnt == 0)
                {
                    if (EpcItemCnt + 1 < 10)
                    {
                        newEpcItemCnt = "0" + Convert.ToString(EpcItemCnt + 1);
                    }
                    else
                    {
                        newEpcItemCnt = Convert.ToString(EpcItemCnt + 1);
                    }

                    SensorTag_table.Rows[EpcItemCnt][_SensorTag_DGV_ColumnsIndex_No] = newEpcItemCnt; // EpcItemCnt + 1;
                    SensorTag_table.Rows[EpcItemCnt][_SensorTag_DGV_ColumnsIndex_PC] = pc;
                    SensorTag_table.Rows[EpcItemCnt][_SensorTag_DGV_ColumnsIndex_Epc] = epc;
                    SensorTag_table.Rows[EpcItemCnt][_SensorTag_DGV_ColumnsIndex_Crc] = crc;
                    SensorTag_table.Rows[EpcItemCnt][_SensorTag_DGV_ColumnsIndex_Cnt] = 1;

                    rowIndex++;
                }
                else
                {
                    if (indexEpc + 1 < 10)
                    {
                        newEpcItemCnt = "0" + Convert.ToString(indexEpc + 1);
                    }
                    else
                    {
                        newEpcItemCnt = Convert.ToString(indexEpc + 1);
                    }

                    SensorTag_table.Rows[indexEpc][_SensorTag_DGV_ColumnsIndex_No] = newEpcItemCnt; // indexEpc + 1;
                    SensorTag_table.Rows[indexEpc][_SensorTag_DGV_ColumnsIndex_Cnt] = Convert.ToInt32(SensorTag_table.Rows[indexEpc][_SensorTag_DGV_ColumnsIndex_Cnt].ToString()) + 1;
                }
            }
            else
            {
                if (!isFoundEpc || EpcItemCnt == 0)
                {
                    if (EpcItemCnt + 1 < 10)
                    {
                        newEpcItemCnt = "0" + Convert.ToString(EpcItemCnt + 1);
                    }
                    else
                    {
                        newEpcItemCnt = Convert.ToString(EpcItemCnt + 1);
                    }
                    SensorTag_table.Rows.Add(new object[] { newEpcItemCnt, pc, epc, crc, "1" });
                    rowIndex++;
                }
                else
                {
                    if (indexEpc + 1 < 10)
                    {
                        newEpcItemCnt = "0" + Convert.ToString(indexEpc + 1);
                    }
                    else
                    {
                        newEpcItemCnt = Convert.ToString(indexEpc + 1);
                    }

                    SensorTag_table.Rows[indexEpc][_SensorTag_DGV_ColumnsIndex_No] = newEpcItemCnt; // indexEpc + 1;
                    SensorTag_table.Rows[indexEpc][_SensorTag_DGV_ColumnsIndex_Cnt] = Convert.ToInt32(SensorTag_table.Rows[indexEpc][4].ToString()) + 1;
                }
            }
        }

        private void btn_Clear_SensorTag_Click(object sender, EventArgs e)
        {
            txtReceive.Text = "";

            SensorTag_table.Clear();
            LoopNum_cnt = 0;
            FailEPCNum = 0;
            SucessEPCNum = 0;
            db_LoopNum_cnt = 0;
            for (int i = 0; i <= initDataTableLen - 1; i++)
            {
                SensorTag_table.Rows.Add(new object[] { null });
            }
            SensorTag_table.AcceptChanges();
            rowIndex = 0;
        }

        private bool bSensorTag_InventoryFlag = false;
        private void btn_SensorTag_InventoryOne_Click(object sender, EventArgs e)
        {
            if (bInventoryGoing == true)
            {
                MessageBox.Show("Please Stop Inventory Multi-tag before read sensor tag!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
			bSensorTag_InventoryFlag = true;
			//LoopNum_cnt = LoopNum_cnt + 1;
			string strCmdFrame = Commands.RFID_Q_ReadSingle(ReaderDeviceAddress);
			setTextBoxInvoke(txtSend, strCmdFrame);
			Sp.GetInstance().Send(strCmdFrame);
        }


		private string[] strSelMaskBuffer  = new string[256];
		private int iSelMaskBufCounter=0;

		private int SensorTag_ReadTemprCounter=0;// Count the read tempr times.
		private byte SensorTag_SensorTagType = (byte)ConstCode.SensorTagAccessFlag._SensorTagAccessFlag_YEH_Temperature;
		private int SensorTag_ReadTemprMaxNum=1;// Count the read tempr times.
		Commands.TagSensorAccessParamStruct ReadParam = new Commands.TagSensorAccessParamStruct(true);
		private void SensorTag_GetAllTagEpcInfor()
		{
			ReadParam.ReadMaxNumber = (byte)SensorTag_ReadTemprMaxNum;			
			string strAccessPasswd = txt_SensorTag_AccPassWord.Text.Replace(" ", "");
			ReadParam.AccessPswd[0] = Convert.ToByte(strAccessPasswd.Substring(0, 2), 16);
			ReadParam.AccessPswd[1] = Convert.ToByte(strAccessPasswd.Substring(2, 2), 16);
			ReadParam.AccessPswd[2] = Convert.ToByte(strAccessPasswd.Substring(4, 2), 16);
			ReadParam.AccessPswd[3] = Convert.ToByte(strAccessPasswd.Substring(6, 2), 16);

			string strSelMask;//=txtSelMask.Text.Replace(" ", "");
			iSelMaskBufCounter=0;
			for (int k = 0; k < this.dgv_SensorTag.Rows.Count; k++)
			{
				//strSelMask = dgv_SensorTag.Rows[k].Cells[_SensorTag_DGV_ColumnsIndex_Epc].Value.ToString();
				strSelMask = SensorTag_table.Rows[k][_SensorTag_DGV_ColumnsIndex_Epc].ToString();
				strSelMask = strSelMask.Replace(" ", "");
				strSelMaskBuffer[k] = string.Empty;
				strSelMaskBuffer[k] = strSelMask;
				iSelMaskBufCounter++;
			}
		}
		private void btn_SensorTag_GetTmpOne_Click(object sender, EventArgs e)
		{
			btn_Zed_Clear_Click(null,null);
			//SensorTag_GetAllTagEpcInfor();
			SensorTag_ReadTemprMaxNum = (byte)(this.cbx_SensorTag_ReadNumber.SelectedIndex+1);
			switch(this.cbx_SensorTag_SensorTagType.SelectedIndex)
			{
			case 0:
				SensorTag_SensorTagType = (byte)ConstCode.SensorTagAccessFlag._SensorTagAccessFlag_Rfm_Temperature;
				break;
			case 1:
				MessageBox.Show("Not support this Tag Type Currently!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
				//break;
			case 2:
				SensorTag_SensorTagType = (byte)ConstCode.SensorTagAccessFlag._SensorTagAccessFlag_YEH_Temperature;
				break;
            case 3://2019-03-05
                SensorTag_SensorTagType = (byte)ConstCode.SensorTagAccessFlag._SensorTagAccessFlag_YEH_Temperature3G;
                break;
			case 4://
				SensorTag_SensorTagType = (byte)ConstCode.SensorTagAccessFlag._SensorTagAccessFlag_YEH_Temperature3GSL;
				//txtSend.Text = Commands.RFID_Q_ReadSensorTag_YEH3GSL(Commands.ReaderDeviceAddr, SensorTag_SensorTagType);
				//txtSend.Text = Commands.RFID_Q_ReadSensorTag(Commands.ReaderDeviceAddr, SensorTag_SensorTagType, ReadParam);	//AA AA FF 06 CA 10 12 0D A5 
				txtSend.Text = Commands.RFID_Q_ReadSensorTagMTR_YEH3(Commands.ReaderDeviceAddr);
				Sp.GetInstance().Send(txtSend.Text);
				return;
				//break;
			default:
				break;
			}		 
			SensorTag_GetAllTagEpcInfor();

			SensorTag_ReadTemprCounter=0;//2018-02-01
			bSensorTag_ReadThreadExit=false;
			if(iSelMaskBufCounter!=0)
			{
				SensorTag_StartTemperatureOneThread();
			}
            
		}

        //-----------------------------------------------------
         private delegate void txtSendDelegate(string strtext);
         private void set_txtSend(string strtext)
         {
             if (this.txtSend.InvokeRequired)
             {
                 txtSendDelegate md = new txtSendDelegate(this.set_txtSend);
                 this.Invoke(md, new object[] { strtext });
             }
             else
                 this.txtSend.Text = strtext;
         }

		//-------------------------------------------------

		//public EventWaitHandle SensorTag_ReadTemprEveWaitHandle = new EventWaitHandle(false, EventResetMode.AutoReset);
		private AutoResetEvent SensorTag_ReadTemprEveWaitHandle = new AutoResetEvent(false);
		private void SensorTag_StartTemperatureOneThread()
		{
			Thread thread = new Thread(new ThreadStart(this.SensorTag_TemperatureThreadOneProc));
			thread.IsBackground = true;
			thread.Start();
			//this.SensorTag_ReadTemprEveWaitHandle.WaitOne(5000, false);
		}

		static bool bSensorTag_ReadThreadExit = false;
		//private AutoResetEvent exitEvent = new AutoResetEvent(false);
		private void SensorTag_TemperatureThreadOneProc()
		{
			string strCmdFrame;
			string strSelPC,strSelEpcMask;
			for(int k=0;k<iSelMaskBufCounter;k++)
			{
				if ((bool)this.dgv_SensorTag.Rows[k].Cells[0].EditedFormattedValue==true)
				{//Read the Sensor Tag has been Checked.
					dgv_SensorTag.Rows[k].Selected = true;

					strSelPC      = SensorTag_table.Rows[k][_SensorTag_DGV_ColumnsIndex_PC].ToString();
					strSelPC      = strSelPC.Replace(" ", "");
					strSelEpcMask = SensorTag_table.Rows[k][_SensorTag_DGV_ColumnsIndex_Epc].ToString();
					strSelEpcMask = strSelEpcMask.Replace(" ", "");
					
					ReadParam.EpcLen = (byte)(strSelEpcMask.Length / 2);
					ushort PcVaule= Convert.ToUInt16(strSelPC, 16);
					ReadParam.EpcLen = (byte)(PcVaule >> 11);
					ReadParam.EpcLen = (byte)(ReadParam.EpcLen * 2);
					for (byte i=0;i<ReadParam.EpcLen;i++)
						ReadParam.EPC[i] = Convert.ToByte(strSelEpcMask.Substring(i * 2, 2), 16);

					//strCmdFrame = Commands.RFID_Q_ReadSensorTag(Commands.ReaderDeviceAddr, (byte)ConstCode.SensorTagAccessFlag._SensorTagAccessFlag_Rfm_Temperature, ReadParam);
					strCmdFrame = Commands.RFID_Q_ReadSensorTag(Commands.ReaderDeviceAddr, SensorTag_SensorTagType, ReadParam);
					Sp.GetInstance().Send(strCmdFrame);
	
					set_txtSend(strCmdFrame);
					SensorTag_ReadTemprEveWaitHandle.WaitOne();//5000, false);

					dgv_SensorTag.Rows[k].Selected = false;
					
				}

				if(bSensorTag_ReadThreadExit)
				{
					break;
				}
		
			}
           
            /*string strTagEpc;
		            for (int k = 0; k < dgv_SensorTag.Rows.Count; k++)
		            {
		                if ((bool)this.dgv_SensorTag.Rows[k].Cells[0].EditedFormattedValue == true)
		                {// if Checked, 
		                    dgv_SensorTag.Rows[k].Selected = true;//

		                    strTagEpc = dgv_SensorTag.Rows[k].Cells[_SensorTag_DGV_ColumnsIndex_Epc].Value.ToString();
		                    strTagEpc = strTagEpc.Replace(" ", "");
		                    strSelMaskBuffer[k] = string.Empty;
		                    //strSelMaskBuffer[k] = strSelMask;
		                }
		            }*/
		}
		//----------------------------------------------------------------------------------
		private bool bSensorTagTmprAutoThreadFlag=false;
        private void btn_SensorTag_GetTmpAuto_Click(object sender, EventArgs e)
        {
            if (btn_SensorTag_GetTmpAuto.Text == "Get Temperature Auto")
            {
                btn_SensorTag_GetTmpAuto.Text = "Stop Auto";
				
                SensorTag_ReadTemprMaxNum = (byte)(this.cbx_SensorTag_ReadNumber.SelectedIndex+1);
                SensorTag_StartTemperatureAutoThread();
            }
            else
            {
                btn_SensorTag_GetTmpAuto.Text = "Get Temperature Auto";
				bSensorTagTmprAutoThreadFlag=false;
            }
        }

		private void SensorTag_StartTemperatureAutoThread()
		{
            btn_Clear_SensorTag_Click(null, null);

			bSensorTagTmprAutoThreadFlag=true;
			Thread thread = new Thread(new ThreadStart(this.SensorTag_TemperatureThreadAutoProc));
			//Thread thread = new Thread(new ThreadStart(this.SensorTag_TemperatureThreadAutoProcInvoke));
            thread.IsBackground = true;
            thread.Start();
            //this.SensorTag_ReadTemprEveWaitHandle.WaitOne(5000, false);
		}


		public int SensorTag_TmprThreadFsmState=0;
		private void SensorTag_TemperatureThreadAutoProc()
		{
			//btn_Clear_SensorTag_Click(null, null);
			
			while(bSensorTagTmprAutoThreadFlag)	
			{
				SensorTag_TmprThreadFsmState++;
				switch(SensorTag_TmprThreadFsmState)
				{
				case 1:
					btn_SensorTag_InventoryOne_Click(null, null);
                    Thread.Sleep(1000);
					break;
				case 2:
					SensorTag_GetAllTagEpcInfor();
					break;
				case 3:
					SensorTag_TemperatureThreadOneProc();
					break;
				default:
					SensorTag_TmprThreadFsmState=0;
					break;
				}
			}		
			
		}
		delegate void SensorTag_TemperatureThreadCallback();
		private void SensorTag_TemperatureThreadAutoProcInvoke()
		{
			if(this.InvokeRequired)
			{
				SensorTag_TemperatureThreadCallback dg =new SensorTag_TemperatureThreadCallback(SensorTag_TemperatureThreadAutoProc);
				this.Invoke(dg, new object[] {  });
			}
			else
			{
				SensorTag_TemperatureThreadAutoProc();
			}
		}


        private void SensorTag_dgv_MouseUp(object sender, MouseEventArgs e)
        {
            int rowIndex = dgv_SensorTag.CurrentRow.Index;
            if (dgv_SensorTag.Rows[rowIndex].Cells[2].Value.ToString() != null)
            {
                //txtSelMask.Text = dgv_SensorTag.Rows[rowIndex].Cells[2].Value.ToString();
            }
            //txtSelLength.Text = (txtSelMask.Text.Replace(" ", "").Length * 4).ToString("X2");
        }

		private void btn_SensorTag_StopRead_Click(object sender, EventArgs e)
        {             
            bSensorTag_ReadThreadExit=true;
			
			txtSend.Text = Commands.RFID_Q_StopSensorTag(Commands.ReaderDeviceAddr);
            Sp.GetInstance().Send(txtSend.Text); 
			//exitEvent.Set();
			this.SensorTag_ReadTemprEveWaitHandle.Set();
        }
		
        private void btn_SensorTag_Test_Click(object sender, EventArgs e)
        {
						
        }

        #endregion

        #region ZedGraph Display
        private PointPairList ZedList_Temperature = new PointPairList();
        private PointPairList ZedList_SensorRSSI = new PointPairList();
		private GraphPane myPane;//
		private const double _zedgraph_x_step_ = 1.0;
		private const double _zedgraph_x_max_ = 52.0;
		private void Zed_Inital()
		{
            myPane = this.zg1.GraphPane;// Get a reference to the GraphPane instance in the ZedGraphControl
			// Set the titles and axis labels
			myPane.Title.Text = "Temperature & Sensor RSSI";
			myPane.XAxis.Title.Text = "Time Point";
			myPane.YAxis.Title.Text = "Temperature";
			myPane.Y2Axis.Title.Text = "Sensor RSSI";
            //myPane.Title.FontSpec.IsItalic = true;
            myPane.Title.FontSpec.Size = 20f;
            myPane.YAxis.Title.FontSpec.Size = 18f;
            myPane.Y2Axis.Title.FontSpec.Size = 18f;

			// Make up some data points based on the Sine function
			//PointPairList ZedList_Temperature = new PointPairList();
			//PointPairList ZedList_SensorRSSI = new PointPairList();
			/*for ( int i = 0; i < 36; i++ )
			{
				double x = (double)i * 5.0;
				double y = Math.Sin( (double)i * Math.PI / 15.0 ) * 16.0;
				double y2 = y * 2;//13.5;
				ZedList_Temperature.Add( x, y );
				ZedList_SensorRSSI.Add( x, y2 );
			}*/

			// Generate a red curve with diamond symbols, and "Temperature" in the legend
            LineItem myCurve = myPane.AddCurve("Temperature(°C)",
				ZedList_Temperature, Color.Red, SymbolType.Diamond );
			// Fill the symbols with white
			myCurve.Symbol.Fill = new Fill( Color.White );

			// Generate a blue curve with circle symbols, and "RSSI" in the legend
			myCurve = myPane.AddCurve( "RSSI",
				ZedList_SensorRSSI, Color.Blue, SymbolType.Circle );
			// Fill the symbols with white
			myCurve.Symbol.Fill = new Fill( Color.White );
			// Associate this curve with the Y2 axis
			myCurve.IsY2Axis = true;

			// Show the x axis grid
			myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.XAxis.Scale.Min = -1;        
            myPane.XAxis.Scale.Max = _zedgraph_x_max_;    
            //myPane.XAxis.Scale.MinGrace = true;
            //myPane.XAxis.Scale.MaxGrace = true;
            myPane.XAxis.Scale.MinorStep = 1;
            myPane.XAxis.Scale.MajorStep = 5;
			//myPane.XAxis.Type = ZedGraph.AxisType.LinearAsOrdinal;

			// Make the Y axis scale red
			myPane.YAxis.Scale.FontSpec.FontColor = Color.Red;
			myPane.YAxis.Title.FontSpec.FontColor = Color.Red;
			// turn off the opposite tics so the Y tics don't show up on the Y2 axis
			myPane.YAxis.MajorTic.IsOpposite = false;
			myPane.YAxis.MinorTic.IsOpposite = false;
			// Don't display the Y zero line
			myPane.YAxis.MajorGrid.IsZeroLine = false;
			// Align the Y axis labels so they are flush to the axis
			myPane.YAxis.Scale.Align = AlignP.Inside;
			// Manually set the axis range
			myPane.YAxis.Scale.Min = -20;
			myPane.YAxis.Scale.Max = 50;

			// Enable the Y2 axis display
			myPane.Y2Axis.IsVisible = true;
			// Make the Y2 axis scale blue
			myPane.Y2Axis.Scale.FontSpec.FontColor = Color.Blue;
			myPane.Y2Axis.Title.FontSpec.FontColor = Color.Blue;
			// turn off the opposite tics so the Y2 tics don't show up on the Y axis
			myPane.Y2Axis.MajorTic.IsOpposite = false;
			myPane.Y2Axis.MinorTic.IsOpposite = false;
			// Display the Y2 axis grid lines
			myPane.Y2Axis.MajorGrid.IsVisible = true;
			// Align the Y2 axis labels so they are flush to the axis
			myPane.Y2Axis.Scale.Align = AlignP.Inside;
            // Manually set the axis range
            myPane.Y2Axis.Scale.Min = -1;
            myPane.Y2Axis.Scale.Max = 33;

			// Fill the axis background with a gradient
			//myPane.Chart.Fill = new Fill( Color.White, Color.LightGray, 45.0f );
			 // Fill the axis background with a gradient
            myPane.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45.0f);

			// Add a text box with instructions
			//TextObj text = new TextObj(
			//	"Zoom: left mouse & drag\nPan: middle mouse & drag\nContext Menu: right mouse",
			//	0.05f, 0.95f, CoordType.ChartFraction, AlignH.Left, AlignV.Bottom );
			//text.FontSpec.StringAlignment = StringAlignment.Near;
			//myPane.GraphObjList.Add( text );

			// Enable scrollbars if needed
			zg1.IsShowHScrollBar = true;
			zg1.IsShowVScrollBar = true;
			zg1.IsAutoScrollRange = true;
			zg1.IsScrollY2 = true;

			// OPTIONAL: Show tooltips when the mouse hovers over a point
			zg1.IsShowPointValues = true;
			zg1.PointValueEvent += new ZedGraphControl.PointValueHandler( Zed_PointValueHandler );

			// OPTIONAL: Add a custom context menu item
			zg1.ContextMenuBuilder += new ZedGraphControl.ContextMenuBuilderEventHandler(
							Zed_ContextMenuBuilder );

			// OPTIONAL: Handle the Zoom Event
			zg1.ZoomEvent += new ZedGraphControl.ZoomEventHandler( Zed_ZoomEvent );

			// Size the control to fit the window
			//Zed_SetSize();

			// Tell ZedGraph to calculate the axis ranges
			// Note that you MUST call this after enabling IsAutoScrollRange, since AxisChange() sets
			// up the proper scrolling parameters
			zg1.AxisChange();
			// Make sure the Graph gets redrawn
			zg1.Invalidate();
		}
		private void Zed_SetSize()
		{
			zg1.Location = new Point( 10, 10 );
			// Leave a small margin around the outside of the control
			zg1.Size = new Size( this.ClientRectangle.Width - 20,
					this.ClientRectangle.Height - 20 );
		}

		/// <summary>
		/// Display customized tooltips when the mouse hovers over a point
		/// </summary>
		private string Zed_PointValueHandler( ZedGraphControl control, GraphPane pane,
						CurveItem curve, int iPt )
		{
			// Get the PointPair that is under the mouse
			PointPair pt = curve[iPt];

			return curve.Label.Text + " is " + pt.Y.ToString( "f2" ) + " units at " + pt.X.ToString( "f1" ) + ".";
		}

		/// <summary>
		/// Customize the context menu by adding a new item to the end of the menu
		/// </summary>
		private void Zed_ContextMenuBuilder( ZedGraphControl control, ContextMenuStrip menuStrip,
						Point mousePt, ZedGraphControl.ContextMenuObjectState objState )
		{
			ToolStripMenuItem item = new ToolStripMenuItem();
			item.Name = "add-Temperature";
			item.Tag = "add-Temperature";
			item.Text = "Add a new Temperature Point";
			item.Click += new System.EventHandler( Zed_AddBetaPoint );

			menuStrip.Items.Add( item );
		}

		/// <summary>
		/// Handle the "Add New Beta Point" context menu item.  This finds the curve with
		/// the CurveItem.Label = "Beta", and adds a new point to it.
		/// </summary>
		private void Zed_AddBetaPoint( object sender, EventArgs args )
		{
			// Get a reference to the "Beta" curve IPointListEdit
			IPointListEdit ip = zg1.GraphPane.CurveList["Beta"].Points as IPointListEdit;
			if ( ip != null )
			{
				double x = ip.Count * 5.0;
				double y = Math.Sin( ip.Count * Math.PI / 15.0 ) * 16.0 * 13.5;
				ip.Add( x, y );
				zg1.AxisChange();
				zg1.Refresh();
			}
		}

		// Respond to a Zoom Event
		private void Zed_ZoomEvent( ZedGraphControl control, ZoomState oldState,
					ZoomState newState )
		{
			// Here we get notification everytime the user zooms
		}

		delegate void Zedgraph_RefreshCallback();
		private void Zedgraph_Refresh()
        {            
            this.zg1.AxisChange();
            this.zg1.Refresh();
        }
		private void Zedgraph_RefreshInThread()
        {
            if (this.zg1.InvokeRequired)
            {
                // It's on a different thread, so use Invoke.
                Zedgraph_RefreshCallback dg = new Zedgraph_RefreshCallback(Zedgraph_Refresh);
                this.Invoke(dg, new object[] {  });
            }
            else
            {
                // It's on the same thread, no need for Invoke 
                this.zg1.AxisChange();
                this.zg1.Refresh();
            }
        }
		private void Zedgraph_ScrollToRightSide()
		{
			if(Zed_Xpoint_Index>=_zedgraph_x_max_)
			{
				this.zg1.GraphPane.XAxis.Scale.Max += 1;
				this.zg1.GraphPane.XAxis.Scale.Min += 1;
				this.zg1.ScrollMaxX = this.zg1.GraphPane.XAxis.Scale.Max+1;
			}
		}
		
		private double Zed_Xpoint_Index=0;
		//private const double _zedgraph_x_step_ = 1.0;
		private void Zed_AddPoint_Temperature(double X, double Yp)
		{
			ZedList_Temperature.Add(X*_zedgraph_x_step_,Yp);
		}
		private void Zed_AddPoint_SensorRssi(double X, double Yp)
		{
			ZedList_SensorRSSI.Add(X*_zedgraph_x_step_,Yp);
		}

		private void Zed_AddTagTmprRssiInfor(double dTmprV, double dSnrRssi)
		{
			Zed_AddPoint_Temperature(Zed_Xpoint_Index,dTmprV);
			Zed_AddPoint_SensorRssi(Zed_Xpoint_Index,dSnrRssi);
			Zedgraph_Refresh();
			Zed_Xpoint_Index++;
		}
		
		//--------------------------------------------------------------------
        private void btn_Zed_Clear_Click(object sender, EventArgs e)
        {
        	Zed_Xpoint_Index=0;
            ZedList_Temperature.Clear();
            ZedList_SensorRSSI.Clear();

			//Zed_Inital();
			Zedgraph_Refresh();
        }

        #endregion

        private void cbxPort_DropDown(object sender, EventArgs e)
        {
            string[] NamesArr = SerialPort.GetPortNames();

            this.cbxPort.Items.Clear();
            if (NamesArr.Length != 0)
            {
                foreach (var oo in NamesArr)
                {
                    this.cbxPort.Items.Add(oo);
                    btnConn.Enabled = true;
                }
                this.cbxPort.SelectedIndex = 0;
            }
        }

/// <summary>
/// ///////////////////////////////
/// </summary>
        ///
        #region Ant Operation
        private const int _ANT_Max_Quantity_ = 8;

        private Commands.AntWorkParamStruct Ant = new Commands.AntWorkParamStruct(true);
        private CheckBox[] AntEnableBitCheck = new CheckBox[_ANT_Max_Quantity_];/* { checkBox_RF_Ant_Enable1, checkBox_RF_Ant_Enable2,
                                            checkBox_RF_Ant_Enable3, checkBox_RF_Ant_Enable4,
                                            checkBox_RF_Ant_Enable5, checkBox_RF_Ant_Enable6,
                                            checkBox_RF_Ant_Enable7, checkBox_RF_Ant_Enable8
            };*/
        private RadioButton[] AntPortRb = new RadioButton[_ANT_Max_Quantity_];
        private ComboBox[] AntRfPowerCmb = new ComboBox[_ANT_Max_Quantity_];
        private TextBox[] AntPollingCountTxt = new TextBox[_ANT_Max_Quantity_];

        private bool bAnt_InitalFlag = false;
        private void Ant_Inital()
        {
            this.comboBoxRF_AntPort_Port1.SelectedIndex = 0;
            this.comboBoxRF_AntPort_Port2.SelectedIndex = 0;
            this.comboBoxRF_AntPort_Port3.SelectedIndex = 0;
            this.comboBoxRF_AntPort_Port4.SelectedIndex = 0;

            this.radioButton_AntPort1.Checked = true;
            this.checkBox_RF_Ant_Enable1.Checked = true;
            this.comboBox_RF_AntPort_Quantity.SelectedIndex = 0;

            AntEnableBitCheck[0] = checkBox_RF_Ant_Enable1;
            AntEnableBitCheck[1] = checkBox_RF_Ant_Enable2;
            AntEnableBitCheck[2] = checkBox_RF_Ant_Enable3;
            AntEnableBitCheck[3] = checkBox_RF_Ant_Enable4;
            AntEnableBitCheck[4] = checkBox_RF_Ant_Enable5;
            AntEnableBitCheck[5] = checkBox_RF_Ant_Enable6;
            AntEnableBitCheck[6] = checkBox_RF_Ant_Enable7;
            AntEnableBitCheck[7] = checkBox_RF_Ant_Enable8;

            AntPortRb[0]= radioButton_AntPort1;
            AntPortRb[1]= radioButton_AntPort2;
            AntPortRb[2]= radioButton_AntPort3;
            AntPortRb[3]= radioButton_AntPort4;
            AntPortRb[4]= radioButton_AntPort5;
            AntPortRb[5]= radioButton_AntPort6;
            AntPortRb[6]= radioButton_AntPort7;
            AntPortRb[7]= radioButton_AntPort8;

            AntRfPowerCmb[0] = comboBoxRF_AntPort_Port1;
            AntRfPowerCmb[1] = comboBoxRF_AntPort_Port2;
            AntRfPowerCmb[2] = comboBoxRF_AntPort_Port3;
            AntRfPowerCmb[3] = comboBoxRF_AntPort_Port4;
            AntRfPowerCmb[4] = comboBoxRF_AntPort_Port5;
            AntRfPowerCmb[5] = comboBoxRF_AntPort_Port6;
            AntRfPowerCmb[6] = comboBoxRF_AntPort_Port7;
            AntRfPowerCmb[7] = comboBoxRF_AntPort_Port8;

            AntPollingCountTxt[0] = textBox_RF_AntPort_InvCnter1;
            AntPollingCountTxt[1] = textBox_RF_AntPort_InvCnter2;
            AntPollingCountTxt[2] = textBox_RF_AntPort_InvCnter3;
            AntPollingCountTxt[3] = textBox_RF_AntPort_InvCnter4;
            AntPollingCountTxt[4] = textBox_RF_AntPort_InvCnter5;
            AntPollingCountTxt[5] = textBox_RF_AntPort_InvCnter6;
            AntPollingCountTxt[6] = textBox_RF_AntPort_InvCnter7;
            AntPollingCountTxt[7] = textBox_RF_AntPort_InvCnter8;

            bAnt_InitalFlag = true;
        }
        private void AntResponseMessageProcess(Commands.ReaderResponseFrameString rxStrPkts) //string strCmdL)
        {
            bool bParamError = false;
            string sstr;
            int i, k = 0;

            if (rxStrPkts.strStatus != ConstCode.FAIL_OK)
            {
                setToolStripStatusMessage1("Error Code: 0x" + rxStrPkts.strStatus, Color.Red);
                return;
            }
            switch (rxStrPkts.strCmdL)
            {
                case "00":
                    if (rxStrPkts.strParameters[0] != Ant.Quantity.ToString("X2"))
                        bParamError = true;
                    if (rxStrPkts.strParameters[1] != Ant.Enable[0].ToString("X2"))
                        bParamError = true;
                    if (rxStrPkts.strParameters[2] != Ant.Enable[1].ToString("X2"))
                        bParamError = true;
                    if (rxStrPkts.strParameters[3] != Ant.Enable[2].ToString("X2"))
                        bParamError = true;
                    if (rxStrPkts.strParameters[4] != Ant.Enable[3].ToString("X2"))
                        bParamError = true;
                    if (rxStrPkts.strParameters[5] != Ant.PollingCycle.ToString("X2"))
                        bParamError = true;
                    k = 6;
                    for (i = 0; i < Ant.Quantity; i++)
                    {
                        sstr = rxStrPkts.strParameters[k] + rxStrPkts.strParameters[k+1];
                        if (sstr != Ant.AntRFPower[i].ToString("X4"))
                            bParamError = true;

                        sstr = rxStrPkts.strParameters[k+2] + rxStrPkts.strParameters[k+3];
                        if (sstr != Ant.PollingNumber[i].ToString("X4"))
                            bParamError = true;
                        k=k+4;
                    }
                    if(bParamError==false)
                        setToolStripStatusMessage1("Set Antenna Parameters Successed!", Color.Purple);
                    else
                        setToolStripStatusMessage1("Set Antenna Parameters Failed!", Color.Red);
                    break;

                case "01":
                    try
                    {
                        Ant.Quantity = byte.Parse(rxStrPkts.strParameters[0]);// Convert.ToByte(rxStrPkts.strParameters[0])
                        comboBox_RF_AntPort_Quantity.Text = Ant.Quantity.ToString();
                        Ant.Enable[0] = Convert.ToByte(rxStrPkts.strParameters[1],16); //byte.Parse(rxStrPkts.strParameters[1]);

                        for (i = 0; i < _ANT_Max_Quantity_; i++)   ///!!!
                        {
                            if (((Ant.Enable[0] >> i) & 0x01) != 0x00)
                            {
                                AntEnableBitCheck[i].Checked = true;
                            }
                            else
                            {
                                AntEnableBitCheck[i].Checked = false;
                            }
                        }
                        Ant.PollingCycle = byte.Parse(rxStrPkts.strParameters[5]);
                        if(Ant.PollingCycle!=0)
                            checkBox_RF_AntPort_AutoPolling.Checked = true ;
                        else
                            checkBox_RF_AntPort_AutoPolling.Checked = false;

                        k = 6;
                        for (i = 0; i < Ant.Quantity; i++)
                        {
                            sstr = rxStrPkts.strParameters[k] + rxStrPkts.strParameters[k + 1];
                            Ant.AntRFPower[i] = Convert.ToUInt16(sstr,16);
                            //i = (Ant.AntRFPower[i] / 100) - 30;
                            AntRfPowerCmb[i].SelectedIndex =30- (Ant.AntRFPower[i]/100);
                            sstr = rxStrPkts.strParameters[k + 2] + rxStrPkts.strParameters[k + 3];
                            Ant.PollingNumber[i] = Convert.ToUInt16(sstr, 16);
                            AntPollingCountTxt[i].Text = Ant.PollingNumber[i].ToString();
                            k = k + 4;
                        }
                        setToolStripStatusMessage1("Get Antenna Parameters Successed!", Color.Purple);
                    }
                    catch(System.Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        setToolStripStatusMessage1("Exception:"+ex.Message, Color.Red);
                     }
                    break;

                case "02":
                    k = Convert.ToInt16(rxStrPkts.strParameters[0], 16);
                    k = k + 1;
                    setToolStripStatusMessage1("Switch to Antenna Port: Ant" + k.ToString(), Color.MediumSeaGreen);
                    break;

                case "03":
                    try
                    {
                        k = Convert.ToInt16(rxStrPkts.strParameters[0], 16);
                        for (i = 0; i < _ANT_Max_Quantity_; i++)
                        {
                            AntPortRb[i].Checked=false;
                        }
                        AntPortRb[k].Checked = true;
                        k=k+1;
                        setToolStripStatusMessage1("Get Current Antenna Port: Ant"+ k.ToString(), Color.Purple);
                    }
                    catch(System.Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        setToolStripStatusMessage1("Exception:"+ex.Message, Color.Red);
                     }
                    break;
            }
        }
        
        private ulong AntGetEnableSetting()
        {
            ulong EnSet=0,t;
            for (int i = 0; i < 8; i++)
            {
                if (AntEnableBitCheck[i].Checked)
                {
                    t = 1;
                    t = t << i;
                    EnSet = EnSet | t;
                }
            }
            return EnSet;
        }
        private void AntSetEnableSetting(ulong EnbSet)
        {
            ulong EnbSet1=EnbSet;
            for (int i = 0; i < 8; i++)
            {                
                if((EnbSet1 & 0x00000001)!=0)
                    AntEnableBitCheck[i].Checked = true;
                else
                    AntEnableBitCheck[i].Checked = false;
                EnbSet1 = EnbSet1 >> 1;
            }
        }

        private void button_RF_Ant_Set_Click(object sender, EventArgs e)
        {
            byte i;
            Ant.Quantity = byte.Parse(comboBox_RF_AntPort_Quantity.SelectedItem.ToString());

            for (i = 0; i <4; i++)
                Ant.Enable[i] = 0;

            ulong lEnbleBits = AntGetEnableSetting();
            Ant.Enable[0] = (byte)(lEnbleBits & 0x000000FF);
            Ant.Enable[1] = (byte)(lEnbleBits>>8 & 0x000000FF);
            Ant.Enable[2] = (byte)(lEnbleBits >> 16 & 0x000000FF);
            Ant.Enable[3] = (byte)(lEnbleBits >> 32 & 0x000000FF);
            //------------------
            float powerFloat = 0;
            int powerDBm = 0;
            try
            {
                for (i=0; i < Ant.Quantity; i++)
                {
                    powerFloat = float.Parse(AntRfPowerCmb[i].SelectedItem.ToString().Replace("dBm", ""));
                    powerDBm = (int)(powerFloat * 100);
                    Ant.AntRFPower[i] = (ushort)powerDBm;
                    Ant.PollingNumber[i] = ushort.Parse(AntPollingCountTxt[i].Text);
                }
            }
            catch (Exception formatException)
            {
                Console.WriteLine(formatException.ToString());
            }

            if (checkBox_RF_AntPort_AutoPolling.Checked)
                Ant.PollingCycle = 1;
            else
                Ant.PollingCycle = 0;

            txtSend.Text = Commands.RFID_Q_AntWorkParamters(ReaderDeviceAddress, ConstCode.READER_OPERATION_SET, Ant);
            Sp.GetInstance().Send(txtSend.Text);

        }

        private void button_RF_Ant_Get_Click(object sender, EventArgs e)
        {
            txtSend.Text = Commands.RFID_Q_AntWorkParamters(ReaderDeviceAddress, ConstCode.READER_OPERATION_GET, Ant);
            Sp.GetInstance().Send(txtSend.Text);
        }

        private void comboBox_RF_AntPort_Quantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bAnt_InitalFlag == false)
                return;
            int i;
            for (i = 0; i < _ANT_Max_Quantity_; i++)
            {
                AntEnableBitCheck[i].Enabled = false;
                AntPortRb[i].Enabled = false;
                AntRfPowerCmb[i].Enabled = false;
                AntPollingCountTxt[i].Enabled = false;
            }

            Ant.Quantity = byte.Parse(comboBox_RF_AntPort_Quantity.SelectedItem.ToString());
            for (i = 0; i < Ant.Quantity; i++)
            {
                AntEnableBitCheck[i].Enabled = true;
                AntPortRb[i].Enabled = true;
                AntRfPowerCmb[i].Enabled = true;
                AntPollingCountTxt[i].Enabled = true;
            }

            if (Ant.Quantity == 1)
            {
                AntEnableBitCheck[0].Checked = true;
                radioButton_AntPort1_Click(sender, e);
            }
        }

        private void SwitchAntennaPort(byte AntNo)
        {
            txtSend.Text = Commands.RFID_Q_SetAntCurrentAntPort(ReaderDeviceAddress, AntNo);
            Sp.GetInstance().Send(txtSend.Text);
        }

        private void radioButton_AntPort1_Click(object sender, EventArgs e)
        {
            SwitchAntennaPort(0);
        }

        private void radioButton_AntPort2_Click(object sender, EventArgs e)
        {
            SwitchAntennaPort(1);
        }

        private void radioButton_AntPort3_Click(object sender, EventArgs e)
        {
            SwitchAntennaPort(2);
        }

        private void radioButton_AntPort4_Click(object sender, EventArgs e)
        {
            SwitchAntennaPort(3);
        }

        private void radioButton_AntPort5_Click(object sender, EventArgs e)
        {
            SwitchAntennaPort(4);
        }

        private void radioButton_AntPort6_Click(object sender, EventArgs e)
        {
            SwitchAntennaPort(5);
        }

        private void radioButton_AntPort7_Click(object sender, EventArgs e)
        {
            SwitchAntennaPort(6);
        }

        private void radioButton_AntPort8_Click(object sender, EventArgs e)
        {
            SwitchAntennaPort(7);
        }
        private void button_RF_Ant_GetCurrentAntPort_Click(object sender, EventArgs e)
        {
            byte AntPort = 0;
            txtSend.Text = Commands.RFID_Q_AntCurrentAntPort(ReaderDeviceAddress, ConstCode.READER_OPERATION_GET, AntPort);
            Sp.GetInstance().Send(txtSend.Text);
        }
        #endregion

        private void cbxMemBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxMemBank.SelectedIndex )
            {
            case 0:
                setToolStripStatusMessage1("RFU Bank is reserve for future!", Color.DeepPink);
                break;
            case 1:
                {
                    txtWordPtr0.Text = "02";
                    txtWordPtr1.Text = "00";
                    txtWordCnt0.Text = "06";
                    txtWordCnt1.Text = "00";
                    setToolStripStatusMessage1("EPC ID Data is start from word pointer 0x02 with 0x06 word length normally!", Color.DeepPink);
                    setToolStripStatusMessage2("0x00=CRC,0x01=PC,0x02~0x07=EPC", Color.DeepSkyBlue);
                }
                break;
             case 2:
                {
                    txtWordPtr0.Text = "00";
                    txtWordPtr1.Text = "00";
                    txtWordCnt0.Text = "04";
                    txtWordCnt1.Text = "00";
                    setToolStripStatusMessage1("TID Bank is 4 word length normally!", Color.DeepPink);
                }
                break;
             case 3:
                {
                    txtWordPtr0.Text = "00";
                    txtWordPtr1.Text = "00";
                    txtWordCnt0.Text = "08";
                    txtWordCnt1.Text = "00";
                    setToolStripStatusMessage1("Some Tag has no USER Bank!", Color.DeepPink);
                }
                break;

            }
        }

        //private void btnAddItem_Click(object sender, EventArgs e)
        //{
        //    if (txtepctagid.Text != string.Empty && txtRegNo.Text != string.Empty)
        //        AddItemRegister();
        //    else
        //        MessageBox.Show("RfID and RegNo. Sould not empty");
        //}

        //private void txtRegNo_TextChanged(object sender, EventArgs e)
        //{
        //    txtRegRFID.Text = txtepctagid.Text + " " + txtRegNo.Text ;
        //}

        //private void btnClearRfidtag_Click(object sender, EventArgs e)
        //{
        //    txtepctagid.Clear();
        //}

        private void UnsubscribeAllControlEvents(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Button button)
                {
                   // button.Click -=btnAddItem_Click;
                }
                else if (control is TextBox textBox)
                {
                    //textBox.TextChanged -=txtRegNo_TextChanged;
                }
                // Add more controls and their events as needed

                // If the control contains other controls (e.g., a panel), recursively unsubscribe their events
                if (control.HasChildren)
                {
                    UnsubscribeAllControlEvents(control);
                }
            }
        }

        // Call this method on your form's closing or disposing event
        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    UnsubscribeAllControlEvents(this);  // Pass 'this' (the form) as the parent control
        //}

        private void LoadStockInComboBox()
        {
            var stockInList = unitOfWork.StockIns.GetAll();//.OrderByDescending(o=>o.Id);//.OrderByDescending();
            comboBoxStockIn.DataSource = stockInList;
            comboBoxStockIn.DisplayMember = "Invoice_No";
            comboBoxStockIn.ValueMember = "Id";
        }

        private void comboBoxStockIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStockPackagingComboBox();
         
        }

        private void LoadStockPackagingComboBox()
        {
       
            if (comboBoxStockIn.SelectedItem != null)
            {
                var selectedItem = comboBoxStockIn.SelectedItem as Stock_In;
                var stockPackagingList = unitOfWork.StockPackagings.GetAll()
                    .Where(ps => ps.Stock_In_Id == Convert.ToInt32(selectedItem.Id))
                    .OrderByDescending(o=>o.Id).ToList();
  
                comboBoxStockPackaging.DataSource = stockPackagingList;
                comboBoxStockPackaging.DisplayMember = "Box_No";
                comboBoxStockPackaging.ValueMember = "Id";
            }
        }

        private void LoadStockInItemsGrid()
        {
            var stockInId =(Stock_In) comboBoxStockIn.SelectedItem;
            var stockPackageId = (Stock_Packaging)comboBoxStockPackaging.SelectedItem;
            if (stockInId.Id!=null && stockPackageId.Id!=null)
            {
                var stockInItems = unitOfWork.StockInItems.GetAll()
                                  .Where(si => si.Stock_In_Id == stockInId.Id && si.StockPackaging.Id==stockPackageId.Id)
                                  .OrderByDescending(o=>o.Id);

                dataGridViewStockInItems.DataSource = stockInItems.ToList();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int stockPackagingId=0;
            if (comboBoxStockIn.SelectedValue != null &&
                   stockPackagingId > 0 && textBoxEquipmentRegNo.Text != string.Empty && textBoxEquipmentRFID.Text != string.Empty)
            {
                stockPackagingId = Convert.ToInt32(comboBoxStockPackaging.SelectedValue);

                var stockPackaging = unitOfWork.StockPackagings.GetById(stockPackagingId);

                // Validate that we are not exceeding Box_Qty
                int existingItemsCount = unitOfWork.StockInItems.GetAll().ToList()
                                         .Where(si => si.Stock_Packaging_Id == stockPackagingId).Count();
                if (existingItemsCount >= stockPackaging.Box_Qty)
                {
                    MessageBox.Show("Cannot add more items. Box quantity limit exceeded.");
                    return;
                }

                // Create a new Stock_In_Items
               
                var stockInItem = new Stock_In_Items
                {
                    Stock_In_Id = Convert.ToInt32(comboBoxStockIn.SelectedValue),
                    Stock_Packaging_Id = stockPackagingId,
                    //Equipment_Id = 1,
                    Equipment_Reg_No = textBoxEquipmentRegNo.Text,
                    Equipment_Rfid = textBoxEquipmentRFID.Text,
                    Description = textBoxDescription.Text,
                    Is_Active = 1, // Assuming new item is active
                    Created_By = 1, // Replace with actual user
                    Created_At = DateTime.Now,
                    Updated_At = DateTime.Now
                };

                unitOfWork.StockInItems.Insert(stockInItem);
                unitOfWork.StockInItems.Save();

                LoadStockInItemsGrid(); // Refresh grid after adding item
                                        // ClearFields(); // Clear input fields after adding
            }
            else
            {
                MessageBox.Show("Please select the Stock Packaging Id");
            }

        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewStockInItems.CurrentRow == null)
            {
                MessageBox.Show("Select an item to update.");
                return;
            }

            int stockInItemId = Convert.ToInt32(dataGridViewStockInItems.CurrentRow.Cells["Id"].Value);
            var stockInItem = unitOfWork.StockInItems.GetById(stockInItemId);

            // Update fields
            stockInItem.Equipment_Reg_No = textBoxEquipmentRegNo.Text;
            stockInItem.Equipment_Rfid = textBoxEquipmentRFID.Text;
            stockInItem.Description = textBoxDescription.Text;
            stockInItem.Updated_By = 1; // Replace with actual user
            stockInItem.Updated_At = DateTime.Now;

            unitOfWork.StockInItems.Update(stockInItem);
            unitOfWork.StockInItems.Save();

            LoadStockInItemsGrid();
            //ClearFields();
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStockInItems.CurrentRow == null)
            {
                MessageBox.Show("Select an item to delete.");
                return;
            }

            int stockInItemId = Convert.ToInt32(dataGridViewStockInItems.CurrentRow.Cells["Id"].Value);
            var stockInItem = unitOfWork.StockInItems.GetById(stockInItemId);

            unitOfWork.StockInItems.Delete(stockInItem);
            unitOfWork.StockInItems.Save();

            LoadStockInItemsGrid();
            //ClearFields();
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Clear input fields
            textBoxEquipmentRegNo.Clear();
            textBoxEquipmentRFID.Clear();
            textBoxDescription.Clear();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this != null && !this.IsDisposed)
            {

                if (Sp.GetInstance().IsOpen())
                {
                    Sp.GetInstance().Close();
                }
                Sp.GetInstance().ComDevice.Close();
                Sp.GetInstance().ComDevice.Dispose();
                

                // Dispose or stop any timers or threads related to hardware communication
                if (timerCheckReader != null)
                {
                    timerCheckReader.Stop();
                    timerCheckReader.Dispose();
                }

                // Reset any flags or states
                readerConnected = false;
                checkingReaderAvailable = false;
                hardwareVersion = "";

                if (rp != null)
                {                

                        Sp.GetInstance().ComDevice.DataReceived -= rp.DataReceived;
                        rp.PacketReceived -= rp_PaketReceived;
                        Sp.GetInstance().DataSent -= ComDataSent;

                }


                // Close the form properly
                EventUnsubscriber.UnsubscribeAllEvents(this);

                // Dispose the form to release resources
                //this.Dispose();

                // Set the reference to null to free memory
                //this. = null;
            }

            //// Ensure the serial port is closed
          

        }

        private void comboBoxStockPackaging_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStockInItemsGrid();
        }

        private void dataGridViewStockInItems_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string rowNumber = (e.RowIndex + 1).ToString();

            // Get the size of the row header
            SizeF size = e.Graphics.MeasureString(rowNumber, dataGridViewStockInItems.Font);

            // Define where the row number will be placed inside the row header
            e.Graphics.DrawString(rowNumber, dataGridViewStockInItems.Font, Brushes.Black,
                                  e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
        }

        private void btnAddBox_Click(object sender, EventArgs e)
        {

            var selectedStockIn = (Stock_In)comboBoxStockIn.SelectedItem;
            if (selectedStockIn != null)
            {
                int stockInId = selectedStockIn.Id;

                // Open the StockPackagingForm and pass the Stock_In_Id
                StockPackagingForm stockPackagingForm = new StockPackagingForm(stockInId, unitOfWork);
                stockPackagingForm.ShowDialog();

                // Optionally, reload the stock packaging list after closing the form
                LoadStockPackagingComboBox();
            }

        }
    }


}
