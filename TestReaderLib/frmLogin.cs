using AK203.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuleReader
{
    public partial class frmLogin : Form
    {
        private readonly IUnitOfWork unitOfWork;
        public frmLogin(UnitOfWork _unitOfWork)
        {
            InitializeComponent();
            unitOfWork = _unitOfWork;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PerformLogin();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the pressed key is Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Prevent the beep sound on Enter key press
                e.SuppressKeyPress = true;

                // Call the search method
                PerformLogin();
            }
        }

        private void PerformLogin()
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            var user = unitOfWork.Users.GetAll().FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                // User authenticated
                this.Hide();
                var mainForm = new MDIKote(unitOfWork); // Assuming you have a main form to navigate to after login
                mainForm.Show();
            }
            else
            {
                // Authentication failed
                lblMessage.Text = "Invalid username or password.";
            }
        }
    }
}
