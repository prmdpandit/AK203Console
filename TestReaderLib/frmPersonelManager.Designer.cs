using System.Windows.Forms;

namespace ModuleReader
{
    partial class frmPersonelManager
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtArmyNo;
        private TextBox txtRank;
        private TextBox txtName;
        private TextBox txtUnitName;
        private TextBox txtContactNo;
        private TextBox txtBiometricNo;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnView;
        private DataGridView dataGridViewPersonnel;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtArmyNo = new System.Windows.Forms.TextBox();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtBiometricNo = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.dataGridViewPersonnel = new System.Windows.Forms.DataGridView();
            this.lblArmyNo = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUnitName = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblBiometricNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtArmyNo
            // 
            this.txtArmyNo.Location = new System.Drawing.Point(120, 30);
            this.txtArmyNo.Name = "txtArmyNo";
            this.txtArmyNo.Size = new System.Drawing.Size(200, 20);
            this.txtArmyNo.TabIndex = 0;
            // 
            // txtRank
            // 
            this.txtRank.Location = new System.Drawing.Point(120, 70);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(200, 20);
            this.txtRank.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 110);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtUnitName
            // 
            this.txtUnitName.Location = new System.Drawing.Point(120, 150);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(200, 20);
            this.txtUnitName.TabIndex = 3;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(120, 190);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(200, 20);
            this.txtContactNo.TabIndex = 4;
            // 
            // txtBiometricNo
            // 
            this.txtBiometricNo.Location = new System.Drawing.Point(120, 230);
            this.txtBiometricNo.Name = "txtBiometricNo";
            this.txtBiometricNo.Size = new System.Drawing.Size(200, 20);
            this.txtBiometricNo.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(350, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(350, 70);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(350, 110);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(350, 150);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 30);
            this.btnView.TabIndex = 9;
            this.btnView.Text = "Clear";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dataGridViewPersonnel
            // 
            this.dataGridViewPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonnel.Location = new System.Drawing.Point(30, 280);
            this.dataGridViewPersonnel.Name = "dataGridViewPersonnel";
            this.dataGridViewPersonnel.RowTemplate.Height = 24;
            this.dataGridViewPersonnel.Size = new System.Drawing.Size(720, 150);
            this.dataGridViewPersonnel.TabIndex = 10;
            this.dataGridViewPersonnel.SelectionChanged += new System.EventHandler(this.dataGridViewPersonnel_SelectionChanged);
            // 
            // lblArmyNo
            // 
            this.lblArmyNo.AutoSize = true;
            this.lblArmyNo.Location = new System.Drawing.Point(30, 33);
            this.lblArmyNo.Name = "lblArmyNo";
            this.lblArmyNo.Size = new System.Drawing.Size(50, 13);
            this.lblArmyNo.TabIndex = 16;
            this.lblArmyNo.Text = "Army No:";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(30, 73);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(36, 13);
            this.lblRank.TabIndex = 15;
            this.lblRank.Text = "Rank:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 113);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name:";
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.Location = new System.Drawing.Point(30, 153);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(60, 13);
            this.lblUnitName.TabIndex = 13;
            this.lblUnitName.Text = "Unit Name:";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Location = new System.Drawing.Point(30, 193);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(64, 13);
            this.lblContactNo.TabIndex = 12;
            this.lblContactNo.Text = "Contact No:";
            // 
            // lblBiometricNo
            // 
            this.lblBiometricNo.AutoSize = true;
            this.lblBiometricNo.Location = new System.Drawing.Point(30, 233);
            this.lblBiometricNo.Name = "lblBiometricNo";
            this.lblBiometricNo.Size = new System.Drawing.Size(70, 13);
            this.lblBiometricNo.TabIndex = 11;
            this.lblBiometricNo.Text = "Biometric No:";
            // 
            // frmPersonelManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewPersonnel);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBiometricNo);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtUnitName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtRank);
            this.Controls.Add(this.txtArmyNo);
            this.Controls.Add(this.lblBiometricNo);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.lblUnitName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.lblArmyNo);
            this.Name = "frmPersonelManager";
            this.Text = "Personnel Management";
            this.Load += new System.EventHandler(this.frmPersonelManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Label lblArmyNo;
        private Label lblRank;
        private Label lblName;
        private Label lblUnitName;
        private Label lblContactNo;
        private Label lblBiometricNo;
    }
}