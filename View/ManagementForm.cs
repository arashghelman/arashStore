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
            Ref_ProductViewModel.Add
                (
                txtbxProductName.Text,
                Convert.ToInt32(nmrcUpDwnProductQuantity.Value),
                Convert.ToDecimal(txtbxProductUnitPrice.Text),
                Convert.ToDecimal(txtbxProductDiscount.Text),
                AddImage()
                );
        }
        #endregion

        #region [- BtnProductRemove_Click -]
        private void BtnProductRemove_Click(object sender, EventArgs e)
        {
            Ref_ProductViewModel.Remove();
        }
        #endregion

        #region [- BtnProductEdit_Click -]
        private void BtnProductEdit_Click(object sender, EventArgs e)
        {
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

        #endregion

        #region [- Manage People -]

        #region [- DgvPerson_CellClick -]
        private void DgvPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblShowPersonID.Text = dgvPerson.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtbxPersonFirstName.Text = dgvPerson.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtbxPersonLastName.Text = dgvPerson.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtbxPersonBirthYear.Text = dgvPerson.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbbxPersonSex.Text = dgvPerson.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtbxPersonPhoneNumber.Text = dgvPerson.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtbxPersonEmailAddress.Text = dgvPerson.Rows[e.RowIndex].Cells[7].Value.ToString();
        }
        #endregion

        #region [- BtnPersonRemove_Click -]
        private void BtnPersonRemove_Click(object sender, EventArgs e)
        {
            Ref_PersonViewModel.Remove();
        }
        #endregion

        #region [- BtnPersonEdit_Click -]
        private void BtnPersonEdit_Click(object sender, EventArgs e)
        {
            Ref_PersonViewModel.Edit
                (
                Convert.ToInt32(lblShowPersonID.Text),
                txtbxPersonFirstName.Text,
                txtbxPersonLastName.Text,
                Convert.ToInt32(txtbxPersonBirthYear.Text),
                cmbbxPersonSex.Text,
                Convert.ToInt32(txtbxPersonPhoneNumber.Text),
                txtbxPersonEmailAddress.Text
                );
        }
        #endregion

        #region [- BtnPersonRefresh_Click -]
        private void BtnPersonRefresh_Click(object sender, EventArgs e)
        {
            dgvPerson.DataSource = Ref_PersonViewModel.Refresh();
        }
        #endregion 
        #endregion


        public void InitializeID()
        {
            DataGridViewCellEventArgs e;
        }
    }
}
