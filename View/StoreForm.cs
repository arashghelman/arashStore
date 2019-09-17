using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.IO;

namespace View
{
    public partial class StoreForm : Form
    {
        #region [- ctor -]
        public StoreForm()
        {
            InitializeComponent();
            Ref_ProductViewModel = new ViewModel.ProductViewModel();
        }
        #endregion

        #region [- props -]
        public ViewModel.ProductViewModel Ref_ProductViewModel { get; set; }
        #endregion

        #region [- StoreForm_Load -]
        private void StoreForm_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = Ref_ProductViewModel.Refresh();
            HideColumns();
            StretchImageLayout();
        } 
        #endregion
              
        #region [- StretchImageLayout() -]
        private void StretchImageLayout()
        {
            for (int i = 0; i < dgvProducts.Columns.Count; i++)
                if (dgvProducts.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dgvProducts.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
        }
        #endregion

        #region [- HideColumns() -]
        private void HideColumns()
        {
            dgvProducts.Columns["Code"].Visible = false;
            dgvProducts.Columns["Quantity"].Visible = false;
        }
        #endregion

        #region [- BtnManagement_Click -]
        private void BtnManagement_Click(object sender, EventArgs e)
        {
            LoginForm Ref_LoginForm = new LoginForm();
            Ref_LoginForm.Show();
        }
        #endregion

        #region [- DgvProducts_Click -]
        private void DgvProducts_Click(object sender, EventArgs e)
        {
            PersonForm Ref_PersonForm = new PersonForm();
            string name = dgvProducts.CurrentRow.Cells[1].Value.ToString();
            decimal unitPrice = Convert.ToDecimal(dgvProducts.CurrentRow.Cells[3].Value);
            decimal discount = Convert.ToDecimal(dgvProducts.CurrentRow.Cells[5].Value);
            decimal price = unitPrice - discount;
            Ref_PersonForm.txtbxPurchaseName.Text = name;
            Ref_PersonForm.txtbxPurchasePrice.Text = price.ToString();

            byte[] data = (byte[])dgvProducts.CurrentRow.Cells[4].Value;
            MemoryStream ms = new MemoryStream(data);
            Ref_PersonForm.pctrbxPurchase.Image = Image.FromStream(ms);

            Ref_PersonForm.Show();
        } 
        #endregion
    }
}
