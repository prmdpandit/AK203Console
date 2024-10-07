using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kote.Repository;

namespace ModuleReader
{
    public partial class frmUserManager : Form
    {
        private UnitOfWork unitOfWork;

        public frmUserManager()
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork();
            LoadUsers();
        }
        private void LoadUsers()
        {
            var users = unitOfWork.UserRepository.Get().ToList();
            dataGridViewUsers.DataSource = users;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var user = new Users
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Is_Active = chkIsActive.Checked ? 0 : 1,
                Created_At = DateTime.Now,
                Created_By = 1 // Example, you should replace it with the actual user id
            };

            unitOfWork.UserRepository.Insert(user);
            unitOfWork.Save();
            LoadUsers();
            ClearForm();
        }

   

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["Id"].Value);
                var user = unitOfWork.UserRepository.GetByID(userId);

                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;
                user.Is_Active = chkIsActive.Checked ? 0 : 1;
                user.Updated_By = 1; // Example, you should replace it with the actual user id
                user.Updated_At = DateTime.Now;

                unitOfWork.UserRepository.Update(user);
                unitOfWork.Save();
                LoadUsers();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Please select a user to update.");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["Id"].Value);
                unitOfWork.UserRepository.Delete(userId);
                unitOfWork.Save();
                LoadUsers();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Please select a user to delete.");
            }
        }

        private void ClearForm()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            chkIsActive.Checked = false;
        }

        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                txtUsername.Text = dataGridViewUsers.SelectedRows[0].Cells["Username"].Value.ToString();
                txtPassword.Text = dataGridViewUsers.SelectedRows[0].Cells["Password"].Value.ToString();
                chkIsActive.Checked = Convert.ToBoolean(dataGridViewUsers.SelectedRows[0].Cells["IsActive"].Value);
            }
        }


    }
}
