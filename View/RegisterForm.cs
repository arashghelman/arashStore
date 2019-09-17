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
        #region [- ctor -]
        public RegisterForm()
        {
            InitializeComponent();
        } 
        #endregion

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
            MessageBox.Show("You're successfully registered", "Success");
            RegisterForm Ref_RegisterForm = new RegisterForm();
            Ref_RegisterForm.Close();//doesn't work
        }
        #endregion

        #region [- BtnCancel_Click -]
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtbxUsername.Text = string.Empty;
            txtbxPassword.Text = string.Empty;
        } 
        #endregion
    }
}
