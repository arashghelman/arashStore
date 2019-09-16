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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        #region [- BtnRegister_Click -]
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var streamWriter = new StreamWriter("C:\\" + txtbxUsername.Text + "\\login.ID");
                streamWriter.Write(txtbxUsername.Text + "\n" + txtbxPassword.Text);
                streamWriter.Close();
            }
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory("C:\\" + txtbxUsername.Text);
                var streamWriter = new StreamWriter("C:\\" + txtbxUsername.Text + "\\login.ID");
                streamWriter.Write(txtbxUsername.Text + "\n" + txtbxPassword.Text);
                streamWriter.Close();
            }
            RegisterForm Ref_RegisterForm = new RegisterForm();
            Ref_RegisterForm.Hide();
        }
        #endregion

        #region [- BtnCancel_Click -]
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            RegisterForm Ref_RegisterForm = new RegisterForm();
            Ref_RegisterForm.Close();
        } 
        #endregion

        private void CheckUser()
        {
            var streamReader = new StreamReader("C:\\" + txtbxUsername.Text + "\\login.ID");
            string username = streamReader.ReadLine();
            if (username==txtbxUsername.Text)
            {
                MessageBox.Show("This user already exists", "Information");
            }
        }
    }
}
