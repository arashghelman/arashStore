using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace View
{
    public partial class PersonForm : Form
    {
        #region [- ctor -]
        public PersonForm()
        {
            InitializeComponent();
            Ref_PersonViewModel = new ViewModel.PersonViewModel();
            Ref_ProductViewModel = new ViewModel.ProductViewModel();
        }
        #endregion

        #region [- PersonForm_Load -]
        private void PersonForm_Load(object sender, EventArgs e)
        {
            cmbbxSex.Items.AddRange(new string[] { "Male", "Female" });
            AssignToolTip();
        }
        #endregion

        #region [- props -]
        public ViewModel.PersonViewModel Ref_PersonViewModel { get; set; }
        public ViewModel.ProductViewModel Ref_ProductViewModel { get; set; }
        #endregion

        #region [- AssignToolTip() -]
        private void AssignToolTip()
        {
            toolTip1.SetToolTip(txtbxFirstName, "Enter your first name");
            toolTip1.SetToolTip(txtbxLastName, "Enter your last name");
            toolTip1.SetToolTip(txtbxBirthYear, "Enter the year you were born");
            toolTip1.SetToolTip(cmbbxSex, "Select your gender");
            toolTip1.SetToolTip(txtbxPhoneNumber, "Enter your phone number");
            toolTip1.SetToolTip(txtbxEmailAddress, "Enter your email address");
        }
        #endregion

        #region [- Text Validation -]

        #region [- TxtbxFirstName_TextChanged -]
        private void TxtbxFirstName_TextChanged(object sender, EventArgs e)
        {
            string text = txtbxFirstName.Text;
            bool hasDigit = false;
            foreach (char letter in text)
            {
                if (char.IsDigit(letter))
                {
                    hasDigit = true;
                }
                if (hasDigit)
                {
                    string hint = "You should only enter characters!";
                    lblErrorFirstName.Text = hint;
                    errorProvider1.SetError(txtbxFirstName, lblErrorFirstName.Text);
                }
                else
                {
                    errorProvider1.Clear();
                    lblErrorFirstName.Text = string.Empty;
                }
            }
        }
        #endregion

        #region [- TxtbxLastName_TextChanged -]
        private void TxtbxLastName_TextChanged(object sender, EventArgs e)
        {
            string text = txtbxLastName.Text;
            bool hasDigit = false;
            foreach (char letter in text)
            {
                if (char.IsDigit(letter))
                {
                    hasDigit = true;
                }
                if (hasDigit)
                {
                    string hint = "You should only enter characters!";
                    lblErrorLastName.Text = hint;
                    errorProvider1.SetError(txtbxLastName, lblErrorLastName.Text);
                }
                else
                {
                    errorProvider1.Clear();
                    lblErrorLastName.Text = string.Empty;
                }
            }
        }
        #endregion

        #region [- TxtbxBirthYear_TextChanged -]
        private void TxtbxBirthYear_TextChanged(object sender, EventArgs e)
        {
            string text = txtbxBirthYear.Text;
            bool hasDigit = true;
            foreach (char letter in text)
            {
                if (char.IsLetter(letter))
                {
                    hasDigit = false;
                }
                if (!hasDigit)
                {
                    string hint = "You should only enter numbers!";
                    lblErrorBirthYear.Text = hint;
                    errorProvider1.SetError(txtbxBirthYear, lblErrorBirthYear.Text);
                }
                else
                {
                    errorProvider1.Clear();
                    lblErrorBirthYear.Text = string.Empty;
                }
            }
        }
        #endregion

        #region [- TxtbxPhoneNumber_Leave -]
        private void TxtbxPhoneNumber_Leave(object sender, EventArgs e)
        {
            string text = txtbxPhoneNumber.Text;
            bool hasDigit = true;
            foreach (char letter in text)
            {
                if (char.IsLetter(letter))
                {
                    hasDigit = false;
                }
                if (!hasDigit)
                {
                    string hint = "You should only enter numbers!";
                    lblErrorPhoneNumber.Text = hint;
                    errorProvider1.SetError(txtbxPhoneNumber, lblErrorPhoneNumber.Text);
                }
                else
                {
                    errorProvider1.Clear();
                    lblErrorPhoneNumber.Text = string.Empty;
                }
            }
        }
        #endregion

        #region [- TxtbxEmailAddress_Leave -]
        private void TxtbxEmailAddress_Leave(object sender, EventArgs e)
        {
            string pattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            if (Regex.IsMatch(txtbxEmailAddress.Text, pattern))
            {
                errorProvider1.Clear();
                lblEmailError.Text = string.Empty;
            }
            else
            {
                string hint = "wrong format!!";
                lblEmailError.Text = hint;
                errorProvider1.SetError(txtbxEmailAddress, lblEmailError.Text);
            }
        }
        #endregion 

        #endregion



        #region [- BtnAdd_Click -]
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Ref_PersonViewModel.Add
                (
                txtbxFirstName.Text,
                txtbxLastName.Text,
                Convert.ToInt32(txtbxBirthYear.Text),
                cmbbxSex.Text,
                Convert.ToInt32(txtbxPhoneNumber.Text),
                txtbxEmailAddress.Text
                );
        } 
        #endregion












        private void ShowPurchaseMessage(string message)
        {
            message = "You've successfully purchased these items: \n";
        }







        private void Button1_Click(object sender, EventArgs e)
        {
            ManagementForm Ref = new ManagementForm();
            Ref.Show();
        }      
        }


        //public void DetectEachChar(string text, string hint)
        //{
        //    bool hasDigit = false;
        //    foreach (char letter in text)
        //    {
        //        if (char.IsDigit(letter))
        //        {
        //            hasDigit = true;
        //        }
        //        if (hasDigit)
        //        {
        //            hint = "You should only enter characters!";
        //            errorProvider1.SetError(,hint);
        //        }
        //        else
        //        {
        //            errorProvider1.Clear();
        //        }
        //    }
        //}

    }


