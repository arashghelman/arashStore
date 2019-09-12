using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class PersonForm : Form
    {
        #region [- ctor -]
        public PersonForm()
        {
            InitializeComponent();
            Ref_PersonViewModel = new ViewModel.PersonViewModel();
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
        #endregion

        #region [- AssignToolTip() -]
        public void AssignToolTip()
        {
            toolTip1.SetToolTip(txtbxFirstName, "Enter your first name.");
            toolTip1.SetToolTip(txtbxLastName, "Enter your last name.");
            toolTip1.SetToolTip(txtbxBirthYear, "Enter the year you were born.");
            toolTip1.SetToolTip(cmbbxSex, "Select your gender");
            toolTip1.SetToolTip(txtbxPhoneNumber, "Enter your phone number.");
            toolTip1.SetToolTip(txtbxEmailAddress, "Enter your email address.");
        }
        #endregion

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
                    lblError1.Text = hint;
                    errorProvider1.SetError(txtbxFirstName, lblError1.Text);
                }
                else
                {
                    errorProvider1.Clear();
                    lblError1.Text = string.Empty;
                }
            }
        }
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

        #region [- BtnRefresh_Click -]
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            dgvPerson.DataSource = Ref_PersonViewModel.Refresh();
        }
        #endregion

        //public void DetectEachChar(string text)
        //{
        //    bool hasDigit = false;
        //    foreach (char letter in text)
        //    {
        //        if (char.IsDigit(letter))
        //        {
        //            hasDigit = true;
        //        }
        //    }
        //}

    }
}
