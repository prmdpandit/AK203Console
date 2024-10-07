using AK203.Repository;
using RFID_MoudleReader;
using RFID_Reader_Cmds;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace ModuleReader
{
    public partial class MDIKote : Form
    {
        private int childFormNumber = 0;
        private Form activeChildForm=null;
        private readonly IUnitOfWork unitOfWork;
        public MDIKote(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
        }

        // Start

        private void userRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmUserManager userForm = new frmUserManager();
            //userForm.MdiParent = this;
            //userForm.Show();
        }

        //private void personnelEntryToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    PersonnelEntryForm personnelForm = new PersonnelEntryForm();
        //    personnelForm.MdiParent = this;
        //    personnelForm.Show();
        //}

        //private void itemRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ItemRegistrationForm itemForm = new ItemRegistrationForm();
        //    itemForm.MdiParent = this;
        //    itemForm.Show();
        //}

        //private void addLocationToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    AddLocationForm locationForm = new AddLocationForm();
        //    locationForm.MdiParent = this;
        //    locationForm.Show();
        //}

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Handle logout logic here
            this.Close();
        }


        // End

        private void ShowNewForm(object sender, EventArgs e)
        {
            //frmUserManager userForm = new frmUserManager();
            //userForm.MdiParent = this;          
            //userForm.Show();
      
        }

        private void OpenFile(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            //if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            //{
            //    string FileName = openFileDialog.FileName;
            //}
            //frmPersonelManager personelForm = new frmPersonelManager();
            //personelForm.MdiParent = this;
            //personelForm.Show();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //frmGunCategory gunCategoryForm = new frmGunCategory();
            //gunCategoryForm.MdiParent = this;
            //gunCategoryForm.Show();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void personelEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPersonelManager personelForm = new frmPersonelManager();
            //personelForm.MdiParent = this;
            //personelForm.Show();
        }

        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmUserManager userForm = new frmUserManager();
            //userForm.MdiParent = this;
            //userForm.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmGunCategory gunCategoryForm = new frmGunCategory();
            //gunCategoryForm.MdiParent = this;
            //gunCategoryForm.Show();
        }

        private void itemRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var container = new UnityContainer();

            // Resolve Form1, which will automatically resolve IUnitOfWork and Ak203DbContext
            Form1 form =new Form1(unitOfWork);
            //gunRegistrationForm.MdiParent = this;
            //gunRegistrationForm.Show();
            OpenChildForm(form);
        }

        private void ingresEgressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmEgress frmEgress = new frmEgress();
            ////frmEgress.MdiParent = this;
            ////frmEgress.Show();
            //OpenChildForm(frmEgress);
        }

        private void outEgressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmEgressIn frmEgressIn = new frmEgressIn();
            ////frmEgressIn.MdiParent = this;
            ////frmEgressIn.Show();
            //OpenChildForm(frmEgressIn);

        }

        private void OpenChildForm(Form childForm)
        {
            // Check if there's already an instance of the child form
            if (activeChildForm != null)
            {
                CloseAndDisposeForm(activeChildForm); // Dispose of the previous form
            }

            // Open the new child form
            childForm.MdiParent = this;
            childForm.Show();
            activeChildForm = childForm; // Keep track of the active child form
        }


        // Call this method when you need to close and dispose of the child form
        private void CloseAndDisposeForm(Form childForm)
        {
            if (childForm != null && !childForm.IsDisposed)
            {
                // Unsubscribe any event handlers if necessary
                UnsubscribeEventHandlers(childForm);

                // Stop any running timers or threads associated with this form
                StopTimersOrThreads(childForm);

                // Close the form properly
                childForm.Close();

                // Dispose the form to release resources
                childForm.Dispose();

                // Set the reference to null to free memory
                childForm = null;
            }
        }

        // Example method for unsubscribing event handlers (if needed)
        private void UnsubscribeEventHandlers(Form form)
        {
            // Unsubscribe any event handlers related to the form
            // Example: form.SomeEvent -= SomeEventHandler;
        }

        // Example method for stopping timers/threads (if needed)
        private void StopTimersOrThreads(Form form)
        {
            // Stop any running timers or background workers associated with the form
            // Example: form.SomeTimer.Stop();
        }

    }
}
