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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        #region [- BtnRegister_Click -]
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm Ref_RegisterForm = new RegisterForm();
            Ref_RegisterForm.Show();
        }
        #endregion

        #region [- BtnLogin_Click -]
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var streamReader = new StreamReader("C:\\" + txtbxUsername.Text + "\\login.ID");
                string username = streamReader.ReadLine();
                string password = streamReader.ReadLine();
                streamReader.Close();
                if (username == txtbxUsername.Text)
                {
                    MessageBox.Show("You are successfully logged in", "Success");
                    ManagementForm Ref_ManagementForm = new ManagementForm();
                    LoginForm Ref_LoginForm = new LoginForm();
                    Ref_LoginForm.Close();
                    Ref_ManagementForm.Show();
                }
                else
                {
                    MessageBox.Show("You can't be found", "Error");
                }
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("User doesn't exist", "Error");
            }
        } 
        #endregion
    }
}
