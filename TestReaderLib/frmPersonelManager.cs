using Kote.Repository;
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
    public partial class frmPersonelManager : Form
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        public frmPersonelManager()
        {
            InitializeComponent();
            ClearForm();
            LoadPersonnelData();

        }

        private void LoadPersonnelData()
        {
            try
            {
                // Fetch data using the UnitOfWork pattern
                var personnelList = unitOfWork.PersonnelRepository.Get().ToList();

                // Bind the data to the DataGridView
                dataGridViewPersonnel.DataSource = personnelList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var personnel = new Personnel
            {
                Army_No = txtArmyNo.Text,
                Rank = txtRank.Text,
                Name = txtName.Text,
                Unit_Name = txtUnitName.Text,
                Contact_No = txtContactNo.Text,
                Biomatric_No = txtBiometricNo.Text,
                Created_By = 1, // Example value
                Created_At = DateTime.Now,
                Updated_By = 1,
                Updated_At = DateTime.Now
            };

            unitOfWork.PersonnelRepository.Insert(personnel);
            unitOfWork.Save();
            MessageBox.Show("Personnel added successfully");
            LoadPersonnelData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var personnel = unitOfWork.PersonnelRepository.GetByID(1); // Assume ID 1
            if (personnel != null)
            {
                personnel.Rank = txtRank.Text;
                personnel.Name = txtName.Text;
                personnel.Unit_Name = txtUnitName.Text;
                personnel.Contact_No = txtContactNo.Text;
                personnel.Biomatric_No = txtBiometricNo.Text;
                personnel.Updated_By = 1;
                personnel.Updated_At = DateTime.Now;

                unitOfWork.PersonnelRepository.Update(personnel);
                unitOfWork.Save();
                MessageBox.Show("Personnel updated successfully");
                LoadPersonnelData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var personnel = unitOfWork.PersonnelRepository.GetByID(1); // Assume ID 1
            if (personnel != null)
            {
                unitOfWork.PersonnelRepository.Delete(personnel);
                unitOfWork.Save();
                MessageBox.Show("Personnel deleted successfully");
                LoadPersonnelData();
            }
        }
        private void dataGridViewPersonnel_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPersonnel.CurrentRow != null)
            {
                // Retrieve the selected personnel ID from the grid's selected row
                int id = Convert.ToInt32(dataGridViewPersonnel.CurrentRow.Cells["Id"].Value);

                // Use UnitOfWork to retrieve the selected personnel's data
                var personnel = unitOfWork.PersonnelRepository.GetByID(id);
                if (personnel != null)
                {
                    // Populate the form fields with the personnel data
                    txtArmyNo.Text = personnel.Army_No;
                    txtRank.Text = personnel.Rank;
                    txtName.Text = personnel.Name;
                    txtUnitName.Text = personnel.Unit_Name;
                    txtContactNo.Text = personnel.Contact_No;
                    txtBiometricNo.Text = personnel.Biomatric_No;
                }
            }
        }
        private void ClearForm()
        {
            txtArmyNo.Text = string.Empty;
            txtRank.Text = string.Empty;
            txtName.Text = string.Empty;
            txtUnitName.Text = string.Empty;
            txtContactNo.Text = string.Empty;
            txtBiometricNo.Text = string.Empty;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //var personnel = unitOfWork.PersonnelRepository.GetByID(1); // Assume ID 1
            //if (personnel != null)
            //{
            //    txtArmyNo.Text = personnel.Army_No;
            //    txtRank.Text = personnel.Rank;
            //    txtName.Text = personnel.Name;
            //    txtUnitName.Text = personnel.Unit_Name;
            //    txtContactNo.Text = personnel.Contact_No;
            //    txtBiometricNo.Text = personnel.Biomatric_No;
            //}
            ClearForm();
        }

        private void frmPersonelManager_Load(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
