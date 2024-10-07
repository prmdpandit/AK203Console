namespace ModuleReader
{
    partial class MDIKote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIKote));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.itemRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresEgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outEgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(729, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelEntryToolStripMenuItem,
            this.itemRegistrationToolStripMenuItem,
            this.ingresEgressToolStripMenuItem,
            this.outEgressToolStripMenuItem,
            this.userAccountToolStripMenuItem,
            this.categoryToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(729, 29);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // itemRegistrationToolStripMenuItem
            // 
            this.itemRegistrationToolStripMenuItem.Name = "itemRegistrationToolStripMenuItem";
            this.itemRegistrationToolStripMenuItem.Size = new System.Drawing.Size(167, 25);
            this.itemRegistrationToolStripMenuItem.Text = "&Weapon Registration";
            this.itemRegistrationToolStripMenuItem.Click += new System.EventHandler(this.itemRegistrationToolStripMenuItem_Click);
            // 
            // ingresEgressToolStripMenuItem
            // 
            this.ingresEgressToolStripMenuItem.Name = "ingresEgressToolStripMenuItem";
            this.ingresEgressToolStripMenuItem.Size = new System.Drawing.Size(67, 25);
            this.ingresEgressToolStripMenuItem.Text = "&Egress";
            this.ingresEgressToolStripMenuItem.Visible = false;
            this.ingresEgressToolStripMenuItem.Click += new System.EventHandler(this.ingresEgressToolStripMenuItem_Click);
            // 
            // outEgressToolStripMenuItem
            // 
            this.outEgressToolStripMenuItem.Name = "outEgressToolStripMenuItem";
            this.outEgressToolStripMenuItem.Size = new System.Drawing.Size(72, 25);
            this.outEgressToolStripMenuItem.Text = "&Ingress";
            this.outEgressToolStripMenuItem.Visible = false;
            this.outEgressToolStripMenuItem.Click += new System.EventHandler(this.outEgressToolStripMenuItem_Click);
            // 
            // userAccountToolStripMenuItem
            // 
            this.userAccountToolStripMenuItem.Name = "userAccountToolStripMenuItem";
            this.userAccountToolStripMenuItem.Size = new System.Drawing.Size(142, 25);
            this.userAccountToolStripMenuItem.Text = "&User Managment";
            this.userAccountToolStripMenuItem.Visible = false;
            this.userAccountToolStripMenuItem.Click += new System.EventHandler(this.userAccountToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(116, 25);
            this.categoryToolStripMenuItem.Text = "&Weapon CMS";
            this.categoryToolStripMenuItem.Visible = false;
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // personelEntryToolStripMenuItem
            // 
            this.personelEntryToolStripMenuItem.Name = "personelEntryToolStripMenuItem";
            this.personelEntryToolStripMenuItem.Size = new System.Drawing.Size(151, 25);
            this.personelEntryToolStripMenuItem.Text = "&Register Personnel";
            this.personelEntryToolStripMenuItem.Visible = false;
            this.personelEntryToolStripMenuItem.Click += new System.EventHandler(this.personelEntryToolStripMenuItem_Click);
            // 
            // MDIKote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIKote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COD-J KOTE MANAGMENT SYSTEM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem itemRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresEgressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outEgressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEntryToolStripMenuItem;
    }
}



