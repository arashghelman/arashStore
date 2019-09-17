﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Drawing.Imaging;

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
            SetMandatoryHint();
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
                    string hint = "only characters!";
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
                    string hint = "only characters!";
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
                    string hint = "only numbers!";
                    lblErrorBirthYear.Text = hint;
                    errorProvider1.SetError(txtbxBirthYear, lblErrorBirthYear.Text);
                }
                else
                {
                    errorProvider1.Clear();
                    lblErrorBirthYear.Text = string.Empty;
                }
                int temp;
                bool time = Int32.TryParse(txtbxBirthYear.Text, out temp);
                string warning = "invalid date!";
                if (temp > 2020 || temp < 0)
                {
                    lblErrorBirthYear.Text = warning;
                    errorProvider1.SetError(txtbxBirthYear, lblErrorBirthYear.Text);
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
                    string hint = "only numbers!";
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
                txtbxPhoneNumber.Text,
                txtbxEmailAddress.Text
                );
            MessageBox.Show("You've successfully purchased this product", "Success");
            Application.Exit();
        }
        #endregion

        #region [- SetMandatoryHint() -]
        private void SetMandatoryHint()
        {
            string hint = "*";
            lblFirstNameHint.Text = hint;
            lblLastNameHint.Text = hint;
            lblPhoneNumberHint.Text = hint;
            lblBirthYearHint.Text = hint;
        }
        #endregion    

    }
}


