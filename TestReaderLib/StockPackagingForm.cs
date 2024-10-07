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
    public partial class StockPackagingForm : Form
    {
        private readonly IUnitOfWork unitOfWork;
        private int stockInId;
        public StockPackagingForm(int stockInId, IUnitOfWork _unitOfWork)
        {

            InitializeComponent();
            this.stockInId = stockInId;
            unitOfWork = _unitOfWork;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate the input
            if (string.IsNullOrWhiteSpace(txtBoxNo.Text))
            {
                MessageBox.Show("Box Number cannot be empty.");
                return;
            }

            // Create a new Stock_Packaging entity
            var stockPackaging = new Stock_Packaging
            {
                Stock_In_Id = stockInId,
                Box_No = txtBoxNo.Text,
                Box_Qty = int.Parse(txtBoxQty.Text),
                Box_Qr = txtBoxQr.Text,
                Description = txtDescription.Text
            };

            // Save to the database using your UnitOfWork or Repository pattern
            unitOfWork.StockPackagings.Insert(stockPackaging);
            unitOfWork.StockPackagings.Save();

            MessageBox.Show("Box created successfully!");
            this.Close();
        }

    }
}
