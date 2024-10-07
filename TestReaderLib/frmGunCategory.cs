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
    public partial class frmGunCategory : Form
    {
        private UnitOfWork _unitOfWork;
        public frmGunCategory()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
        }

        private void frmGunCategory_Load(object sender, EventArgs e)
        {
            LoadGunCategories();
        }

        private void LoadGunCategories()
        {
            dataGridViewGunCategory.DataSource = _unitOfWork.GunCategoryRepository.Get().ToList();
            ClearForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var category = new GunCategory
            {
                 
                Category_Name = txtCategoryName.Text,
                Description = txtDescription.Text
            };

            _unitOfWork.GunCategoryRepository.Insert(category);
            _unitOfWork.Save();
            LoadGunCategories();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewGunCategory.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridViewGunCategory.CurrentRow.Cells[0].Value);
                var category = _unitOfWork.GunCategoryRepository.GetByID(id);

                if (category != null)
                {
                    category.Category_Name = txtCategoryName.Text;
                    category.Description = txtDescription.Text;

                    _unitOfWork.GunCategoryRepository.Update(category);
                    _unitOfWork.Save();
                    LoadGunCategories();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewGunCategory.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridViewGunCategory.CurrentRow.Cells[0].Value);
                var category = _unitOfWork.GunCategoryRepository.GetByID(id);

                if (category != null)
                {
                    _unitOfWork.GunCategoryRepository.Delete(category);
                    _unitOfWork.Save();
                    LoadGunCategories();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtCategoryName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            dataGridViewGunCategory.ClearSelection();
        }

        private void dataGridViewGunCategory_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewGunCategory.CurrentRow != null)
            {
                txtCategoryName.Text = dataGridViewGunCategory.CurrentRow.Cells["Category_Name"].Value.ToString();
               // txtDescription.Text = dataGridViewGunCategory.CurrentRow.Cells["Description"].Value.ToString();
            }
        }
    }
}
