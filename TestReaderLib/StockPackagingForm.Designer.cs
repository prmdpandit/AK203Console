using System.Windows.Forms;

namespace ModuleReader
{
           partial class StockPackagingForm
        {
            // Required designer variable.
            private System.ComponentModel.IContainer components = null;

            // Clean up any resources being used.
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            #region Windows Form Designer generated code

            private void InitializeComponent()
            {
            this.lblBoxNo = new System.Windows.Forms.Label();
            this.txtBoxNo = new System.Windows.Forms.TextBox();
            this.lblBoxQty = new System.Windows.Forms.Label();
            this.txtBoxQty = new System.Windows.Forms.TextBox();
            this.lblBoxQr = new System.Windows.Forms.Label();
            this.txtBoxQr = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBoxNo
            // 
            this.lblBoxNo.AutoSize = true;
            this.lblBoxNo.Location = new System.Drawing.Point(20, 20);
            this.lblBoxNo.Name = "lblBoxNo";
            this.lblBoxNo.Size = new System.Drawing.Size(45, 13);
            this.lblBoxNo.TabIndex = 0;
            this.lblBoxNo.Text = "Box No:";
            // 
            // txtBoxNo
            // 
            this.txtBoxNo.Location = new System.Drawing.Point(120, 20);
            this.txtBoxNo.Name = "txtBoxNo";
            this.txtBoxNo.Size = new System.Drawing.Size(200, 20);
            this.txtBoxNo.TabIndex = 1;
            // 
            // lblBoxQty
            // 
            this.lblBoxQty.AutoSize = true;
            this.lblBoxQty.Location = new System.Drawing.Point(20, 60);
            this.lblBoxQty.Name = "lblBoxQty";
            this.lblBoxQty.Size = new System.Drawing.Size(70, 13);
            this.lblBoxQty.TabIndex = 2;
            this.lblBoxQty.Text = "Box Quantity:";
            // 
            // txtBoxQty
            // 
            this.txtBoxQty.Location = new System.Drawing.Point(120, 60);
            this.txtBoxQty.Name = "txtBoxQty";
            this.txtBoxQty.Size = new System.Drawing.Size(200, 20);
            this.txtBoxQty.TabIndex = 3;
            // 
            // lblBoxQr
            // 
            this.lblBoxQr.AutoSize = true;
            this.lblBoxQr.Location = new System.Drawing.Point(20, 100);
            this.lblBoxQr.Name = "lblBoxQr";
            this.lblBoxQr.Size = new System.Drawing.Size(47, 13);
            this.lblBoxQr.TabIndex = 4;
            this.lblBoxQr.Text = "Box QR:";
            this.lblBoxQr.Visible = false;
            // 
            // txtBoxQr
            // 
            this.txtBoxQr.Location = new System.Drawing.Point(120, 100);
            this.txtBoxQr.Name = "txtBoxQr";
            this.txtBoxQr.Size = new System.Drawing.Size(200, 20);
            this.txtBoxQr.TabIndex = 5;
            this.txtBoxQr.Visible = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(20, 93);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(120, 93);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 34);
            this.txtDescription.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 180);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // StockPackagingForm
            // 
            this.ClientSize = new System.Drawing.Size(350, 230);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtBoxQr);
            this.Controls.Add(this.lblBoxQr);
            this.Controls.Add(this.txtBoxQty);
            this.Controls.Add(this.lblBoxQty);
            this.Controls.Add(this.txtBoxNo);
            this.Controls.Add(this.lblBoxNo);
            this.Name = "StockPackagingForm";
            this.Text = "Create Stock Packaging";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            // Declare form controls
            private System.Windows.Forms.Label lblBoxNo;
            private System.Windows.Forms.TextBox txtBoxNo;
            private System.Windows.Forms.Label lblBoxQty;
            private System.Windows.Forms.TextBox txtBoxQty;
            private System.Windows.Forms.Label lblBoxQr;
            private System.Windows.Forms.TextBox txtBoxQr;
            private System.Windows.Forms.Label lblDescription;
            private System.Windows.Forms.TextBox txtDescription;
            private System.Windows.Forms.Button btnSave;
        }
    }