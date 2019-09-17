using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace View
{
    public partial class ManagementForm : Form
    {
        #region [- ctor -]
        public ManagementForm()
        {
            InitializeComponent();
            Ref_ProductViewModel = new ViewModel.ProductViewModel();
            Ref_PersonViewModel = new ViewModel.PersonViewModel();
        }
        #endregion

        #region [- props -]
        public ViewModel.PersonViewModel Ref_PersonViewModel { get; set; }
        public ViewModel.ProductViewModel Ref_ProductViewModel { get; set; }
        #endregion

        #region [- ManagementForm_Load -]
        private void ManagementForm_Load(object sender, EventArgs e)
        {
            cmbbxPersonSex.Items.AddRange(new string[] { "Male", "Female" });
        }
        #endregion

        #region [- Manage Products -]

        #region [- DgvProducts_CellClick -]
        private void DgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblShowProductCode.Text= dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtbxProductName.Text = dgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
            nmrcUpDwnProductQuantity.Value = decimal.Parse(dgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString());             
            txtbxProductUnitPrice.Text = dgvProducts.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtbxProductDiscount.Text = dgvProducts.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        #endregion

        #region [- BtnUpload_Click -]
        private void BtnUpload_Click(object sender, EventArgs e)
        {
            fileDialogUpload.ShowDialog();
            lblFileName.Text = fileDialogUpload.FileName;
        }
        #endregion

        #region [- BtnProductAdd_Click -]
        private void BtnProductAdd_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to add a new product?","Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dialogResult==DialogResult.Yes)
            {
                MessageBox.Show("You have added a new product. ");
                Ref_ProductViewModel.Add
                                (
                                txtbxProductName.Text,
                                Convert.ToInt32(nmrcUpDwnProductQuantity.Value),
                                Convert.ToDecimal(txtbxProductUnitPrice.Text),
                                Convert.ToDecimal(txtbxProductDiscount.Text),
                                AddImage()
                                );
                RefreshProductsGridView();
                EmptyProductFields();
            }
            if (dialogResult==DialogResult.No)
            {
                EmptyProductFields();
            }
            
        }
        #endregion

        #region [- BtnProductRemove_Click -]
        private void BtnProductRemove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove existing product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Product is removed.");
                Ref_ProductViewModel.Remove();

                RefreshProductsGridView();
                EmptyProductFields();
            }
            if (dialogResult == DialogResult.No)
            {
                EmptyProductFields();
            }
        }
        #endregion

        #region [- BtnProductEdit_Click -]
        private void BtnProductEdit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to change product info?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult==DialogResult.Yes)
            {
                MessageBox.Show("Changes are added.");
                Ref_ProductViewModel.Edit(
                    Convert.ToInt32(lblShowProductCode.Text),
                    txtbxProductName.Text,
                    Convert.ToInt32(nmrcUpDwnProductQuantity.Value),
                    Convert.ToDecimal(txtbxProductDiscount.Text),
                    Convert.ToDecimal(txtbxProductUnitPrice.Text),
                    AddImage()
                    );
                RefreshProductsGridView();
                EmptyProductFields();
            }
            if (dialogResult==DialogResult.No)
            {
                EmptyProductFields();
            }
        }
        #endregion

        #region [- BtnProductRefresh_Click -]
        private void BtnProductRefresh_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = Ref_ProductViewModel.Refresh();
        }
        #endregion

        #region [- AddImage() -]
        private byte[] AddImage()
        {
            FileStream Ref_FileStream = new FileStream(lblFileName.Text, FileMode.Open, FileAccess.Read);
            BinaryReader Ref_BinaryReader = new BinaryReader(Ref_FileStream);
            byte[] imageByte = Ref_BinaryReader.ReadBytes((int)Ref_FileStream.Length);
            return imageByte;
        }
        #endregion

        #region [- EmptyProductFields() -]
        private void EmptyProductFields()
        {
            txtbxProductName.Text = string.Empty;
            txtbxProductUnitPrice.Text = string.Empty;
            nmrcUpDwnProductQuantity.Value = 0;
            txtbxProductDiscount.Text = string.Empty;
            lblFileName.Text = string.Empty;
        } 
        #endregion

        #region [- RefreshProductsGridView() -]
        private void RefreshProductsGridView()
        {
            dgvProducts.DataSource = Ref_ProductViewModel.Refresh();
        }
        #endregion

        #endregion

        #region [- Manage People -]

        #region [- DgvPerson_CellClick -]
        private void DgvPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblShowPersonID.Text = dgvPerson.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtbxPersonFirstName.Text = dgvPerson.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtbxPersonLastName.Text = dgvPerson.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtbxPersonBirthYear.Text = dgvPerson.Rows[e.RowIndex].Cells[3].Value.ToString();
            lblShowPersonAge.Text = dgvPerson.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbbxPersonSex.Text = dgvPerson.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtbxPersonPhoneNumber.Text = dgvPerson.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtbxPersonEmailAddress.Text = dgvPerson.Rows[e.RowIndex].Cells[7].Value.ToString();
        }
        #endregion

        #region [- BtnPersonRemove_Click -]
        private void BtnPersonRemove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this person?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult==DialogResult.Yes)
            {
                MessageBox.Show("Person is removed.");
                Ref_PersonViewModel.Remove();

                RefreshPersonGridView();
                EmptyPersonFiels();
            }
            if (dialogResult==DialogResult.No)
            {
                EmptyPersonFiels();
            }
        }
        #endregion

        #region [- BtnPersonEdit_Click -]
        private void BtnPersonEdit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to change this person's info?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult==DialogResult.Yes)
            {
                MessageBox.Show("Person's info changed.");
                Ref_PersonViewModel.Edit
                                (
                                Convert.ToInt32(lblShowPersonID.Text),
                                txtbxPersonFirstName.Text,
                                txtbxPersonLastName.Text,
                                Convert.ToInt32(txtbxPersonBirthYear.Text),
                                Convert.ToInt32(lblShowPersonAge.Text),
                                cmbbxPersonSex.Text,
                                txtbxPersonPhoneNumber.Text,
                                txtbxPersonEmailAddress.Text
                                );

                RefreshPersonGridView();
                EmptyPersonFiels();
            }
            if (dialogResult==DialogResult.No)
            {
                EmptyPersonFiels();
            }           
        }
        #endregion

        #region [- BtnPersonRefresh_Click -]
        private void BtnPersonRefresh_Click(object sender, EventArgs e)
        {
            dgvPerson.DataSource = Ref_PersonViewModel.Refresh();
        }
        #endregion

        #region [- EmptyPersonFiels() -]
        private void EmptyPersonFiels()
        {
            txtbxPersonFirstName.Text = string.Empty;
            txtbxPersonLastName.Text = string.Empty;
            txtbxPersonBirthYear.Text = string.Empty;
            lblShowPersonAge.Text = string.Empty;
            txtbxPersonPhoneNumber.Text = string.Empty;
            txtbxPersonEmailAddress.Text = string.Empty;
            cmbbxPersonSex.Text = string.Empty;
            lblShowPersonID.Text = string.Empty;
        } 
        #endregion

        #region [- RefreshPersonGridView() -]
        private void RefreshPersonGridView()
        {
            dgvPerson.DataSource = Ref_PersonViewModel.Refresh();
        }
        #endregion

        #endregion






        private byte[] ConvertToByte()
        {
            byte[] bytes = Encoding.Unicode.GetBytes(lblFileName.Text);
            return bytes;
        }
    }
}
