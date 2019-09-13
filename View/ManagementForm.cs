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
        public ManagementForm()
        {
            InitializeComponent();
            Ref_ProductViewModel = new ViewModel.ProductViewModel();
        }

        public ViewModel.ProductViewModel Ref_ProductViewModel { get; set; }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            fileDialogUpload.ShowDialog();
            lblFileName.Text = fileDialogUpload.FileName;

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            byte[] imageByte = null;
            FileStream Ref_FileStream = new FileStream(lblFileName.Text, FileMode.Open, FileAccess.Read);
            BinaryReader Ref_BinaryReader = new BinaryReader(Ref_FileStream);
            imageByte = Ref_BinaryReader.ReadBytes((int)Ref_FileStream.Length);

            Ref_ProductViewModel.Add
                (
                txtbxName.Text,
                Convert.ToInt32(nmrcUpDwnQuantity.TextAlign),
                Convert.ToDecimal(txtbxUnitPrice.Text),
                Convert.ToDecimal(txtbxDiscount.Text),
                imageByte
                );
        }
        //public byte[] AddImage()
        //{
        //    byte[] imageByte = null;
        //    FileStream Ref_FileStream = new FileStream(lblFileName.Text, FileMode.Open, FileAccess.Read);
        //    BinaryReader Ref_BinaryReader = new BinaryReader(Ref_FileStream);
        //    imageByte = Ref_BinaryReader.ReadBytes((int)Ref_FileStream.Length);
        //    return imageByte;
        //}
        
    }
}
