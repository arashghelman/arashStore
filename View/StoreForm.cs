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
        public StoreForm()
        {
            InitializeComponent();
            Ref_ProductViewModel = new ViewModel.ProductViewModel();
        }
        public ViewModel.ProductViewModel Ref_ProductViewModel { get; set; }

        private void StoreForm_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = Ref_ProductViewModel.Refresh();
            StretchImageLayout();

        }

        public static Image ConvertToImage(Binary iBinary)
        {
            var arrayBinary = iBinary.ToArray();
            Image rImage = null;
            using (MemoryStream ms = new MemoryStream(arrayBinary))
            {
                rImage = Image.FromStream(ms);
            }
            return rImage;
        }

        private void BtnPurchase_Click(object sender, EventArgs e)
        {
            PersonForm Ref_PersonForm = new PersonForm();
            Ref_PersonForm.Show();
        }

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
    }
}
