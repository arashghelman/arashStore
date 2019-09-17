namespace View
{
    partial class PersonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonForm));
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblBirthYear = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.txtbxFirstName = new System.Windows.Forms.TextBox();
            this.txtbxLastName = new System.Windows.Forms.TextBox();
            this.txtbxBirthYear = new System.Windows.Forms.TextBox();
            this.txtbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtbxEmailAddress = new System.Windows.Forms.TextBox();
            this.cmbbxSex = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblErrorFirstName = new System.Windows.Forms.Label();
            this.lblErrorLastName = new System.Windows.Forms.Label();
            this.lblErrorBirthYear = new System.Windows.Forms.Label();
            this.lblErrorPhoneNumber = new System.Windows.Forms.Label();
            this.lblErrorEmailAddress = new System.Windows.Forms.Label();
            this.grpbxPurchaseInfo = new System.Windows.Forms.GroupBox();
            this.pctrbxPurchase = new System.Windows.Forms.PictureBox();
            this.txtbxPurchasePrice = new System.Windows.Forms.TextBox();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.txtbxPurchaseName = new System.Windows.Forms.TextBox();
            this.lblPurchaseName = new System.Windows.Forms.Label();
            this.lblEmailError = new System.Windows.Forms.Label();
            this.lblFirstNameHint = new System.Windows.Forms.Label();
            this.lblLastNameHint = new System.Windows.Forms.Label();
            this.lblBirthYearHint = new System.Windows.Forms.Label();
            this.lblPhoneNumberHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grpbxPurchaseInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(31, 52);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(94, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name: ";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(31, 106);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(94, 20);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name: ";
            // 
            // lblBirthYear
            // 
            this.lblBirthYear.AutoSize = true;
            this.lblBirthYear.BackColor = System.Drawing.Color.Transparent;
            this.lblBirthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthYear.Location = new System.Drawing.Point(31, 158);
            this.lblBirthYear.Name = "lblBirthYear";
            this.lblBirthYear.Size = new System.Drawing.Size(84, 20);
            this.lblBirthYear.TabIndex = 2;
            this.lblBirthYear.Text = "Birth Year:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.BackColor = System.Drawing.Color.Transparent;
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(31, 208);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(44, 20);
            this.lblSex.TabIndex = 3;
            this.lblSex.Text = "Sex: ";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(31, 266);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(119, 20);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.Location = new System.Drawing.Point(31, 333);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(115, 20);
            this.lblEmailAddress.TabIndex = 5;
            this.lblEmailAddress.Text = "Email Address:";
            // 
            // txtbxFirstName
            // 
            this.txtbxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxFirstName.Location = new System.Drawing.Point(146, 49);
            this.txtbxFirstName.Name = "txtbxFirstName";
            this.txtbxFirstName.Size = new System.Drawing.Size(148, 26);
            this.txtbxFirstName.TabIndex = 6;
            this.txtbxFirstName.TextChanged += new System.EventHandler(this.TxtbxFirstName_TextChanged);
            // 
            // txtbxLastName
            // 
            this.txtbxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxLastName.Location = new System.Drawing.Point(146, 103);
            this.txtbxLastName.Name = "txtbxLastName";
            this.txtbxLastName.Size = new System.Drawing.Size(148, 26);
            this.txtbxLastName.TabIndex = 7;
            this.txtbxLastName.TextChanged += new System.EventHandler(this.TxtbxLastName_TextChanged);
            // 
            // txtbxBirthYear
            // 
            this.txtbxBirthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxBirthYear.Location = new System.Drawing.Point(146, 155);
            this.txtbxBirthYear.Name = "txtbxBirthYear";
            this.txtbxBirthYear.Size = new System.Drawing.Size(148, 26);
            this.txtbxBirthYear.TabIndex = 8;
            this.txtbxBirthYear.TextChanged += new System.EventHandler(this.TxtbxBirthYear_TextChanged);
            // 
            // txtbxPhoneNumber
            // 
            this.txtbxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPhoneNumber.Location = new System.Drawing.Point(171, 263);
            this.txtbxPhoneNumber.Name = "txtbxPhoneNumber";
            this.txtbxPhoneNumber.Size = new System.Drawing.Size(123, 26);
            this.txtbxPhoneNumber.TabIndex = 9;
            this.txtbxPhoneNumber.Leave += new System.EventHandler(this.TxtbxPhoneNumber_Leave);
            // 
            // txtbxEmailAddress
            // 
            this.txtbxEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxEmailAddress.Location = new System.Drawing.Point(171, 330);
            this.txtbxEmailAddress.Name = "txtbxEmailAddress";
            this.txtbxEmailAddress.Size = new System.Drawing.Size(123, 26);
            this.txtbxEmailAddress.TabIndex = 10;
            this.txtbxEmailAddress.Leave += new System.EventHandler(this.TxtbxEmailAddress_Leave);
            // 
            // cmbbxSex
            // 
            this.cmbbxSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxSex.FormattingEnabled = true;
            this.cmbbxSex.Location = new System.Drawing.Point(146, 207);
            this.cmbbxSex.Name = "cmbbxSex";
            this.cmbbxSex.Size = new System.Drawing.Size(148, 28);
            this.cmbbxSex.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(88, 426);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(163, 40);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // lblErrorFirstName
            // 
            this.lblErrorFirstName.AutoSize = true;
            this.lblErrorFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFirstName.Location = new System.Drawing.Point(311, 54);
            this.lblErrorFirstName.Name = "lblErrorFirstName";
            this.lblErrorFirstName.Size = new System.Drawing.Size(0, 15);
            this.lblErrorFirstName.TabIndex = 17;
            // 
            // lblErrorLastName
            // 
            this.lblErrorLastName.AutoSize = true;
            this.lblErrorLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorLastName.Location = new System.Drawing.Point(311, 108);
            this.lblErrorLastName.Name = "lblErrorLastName";
            this.lblErrorLastName.Size = new System.Drawing.Size(0, 15);
            this.lblErrorLastName.TabIndex = 18;
            // 
            // lblErrorBirthYear
            // 
            this.lblErrorBirthYear.AutoSize = true;
            this.lblErrorBirthYear.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorBirthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorBirthYear.Location = new System.Drawing.Point(311, 161);
            this.lblErrorBirthYear.Name = "lblErrorBirthYear";
            this.lblErrorBirthYear.Size = new System.Drawing.Size(0, 15);
            this.lblErrorBirthYear.TabIndex = 19;
            // 
            // lblErrorPhoneNumber
            // 
            this.lblErrorPhoneNumber.AutoSize = true;
            this.lblErrorPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPhoneNumber.Location = new System.Drawing.Point(311, 267);
            this.lblErrorPhoneNumber.Name = "lblErrorPhoneNumber";
            this.lblErrorPhoneNumber.Size = new System.Drawing.Size(0, 15);
            this.lblErrorPhoneNumber.TabIndex = 20;
            // 
            // lblErrorEmailAddress
            // 
            this.lblErrorEmailAddress.AutoSize = true;
            this.lblErrorEmailAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEmailAddress.Location = new System.Drawing.Point(311, 336);
            this.lblErrorEmailAddress.Name = "lblErrorEmailAddress";
            this.lblErrorEmailAddress.Size = new System.Drawing.Size(0, 15);
            this.lblErrorEmailAddress.TabIndex = 21;
            // 
            // grpbxPurchaseInfo
            // 
            this.grpbxPurchaseInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpbxPurchaseInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpbxPurchaseInfo.Controls.Add(this.pctrbxPurchase);
            this.grpbxPurchaseInfo.Controls.Add(this.txtbxPurchasePrice);
            this.grpbxPurchaseInfo.Controls.Add(this.lblPurchasePrice);
            this.grpbxPurchaseInfo.Controls.Add(this.txtbxPurchaseName);
            this.grpbxPurchaseInfo.Controls.Add(this.lblPurchaseName);
            this.grpbxPurchaseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxPurchaseInfo.Location = new System.Drawing.Point(460, 49);
            this.grpbxPurchaseInfo.Name = "grpbxPurchaseInfo";
            this.grpbxPurchaseInfo.Size = new System.Drawing.Size(292, 476);
            this.grpbxPurchaseInfo.TabIndex = 23;
            this.grpbxPurchaseInfo.TabStop = false;
            this.grpbxPurchaseInfo.Text = "Purchase Info";
            // 
            // pctrbxPurchase
            // 
            this.pctrbxPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctrbxPurchase.Location = new System.Drawing.Point(28, 204);
            this.pctrbxPurchase.Name = "pctrbxPurchase";
            this.pctrbxPurchase.Size = new System.Drawing.Size(242, 251);
            this.pctrbxPurchase.TabIndex = 4;
            this.pctrbxPurchase.TabStop = false;
            // 
            // txtbxPurchasePrice
            // 
            this.txtbxPurchasePrice.Enabled = false;
            this.txtbxPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPurchasePrice.Location = new System.Drawing.Point(130, 103);
            this.txtbxPurchasePrice.Name = "txtbxPurchasePrice";
            this.txtbxPurchasePrice.Size = new System.Drawing.Size(140, 26);
            this.txtbxPurchasePrice.TabIndex = 3;
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchasePrice.Location = new System.Drawing.Point(8, 106);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(48, 20);
            this.lblPurchasePrice.TabIndex = 2;
            this.lblPurchasePrice.Text = "Price:";
            // 
            // txtbxPurchaseName
            // 
            this.txtbxPurchaseName.Enabled = false;
            this.txtbxPurchaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPurchaseName.Location = new System.Drawing.Point(130, 37);
            this.txtbxPurchaseName.Name = "txtbxPurchaseName";
            this.txtbxPurchaseName.Size = new System.Drawing.Size(140, 26);
            this.txtbxPurchaseName.TabIndex = 1;
            // 
            // lblPurchaseName
            // 
            this.lblPurchaseName.AutoSize = true;
            this.lblPurchaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseName.Location = new System.Drawing.Point(8, 40);
            this.lblPurchaseName.Name = "lblPurchaseName";
            this.lblPurchaseName.Size = new System.Drawing.Size(114, 20);
            this.lblPurchaseName.TabIndex = 0;
            this.lblPurchaseName.Text = "Product Name:";
            // 
            // lblEmailError
            // 
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailError.Location = new System.Drawing.Point(311, 336);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(0, 15);
            this.lblEmailError.TabIndex = 24;
            // 
            // lblFirstNameHint
            // 
            this.lblFirstNameHint.AutoSize = true;
            this.lblFirstNameHint.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstNameHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameHint.ForeColor = System.Drawing.Color.Red;
            this.lblFirstNameHint.Location = new System.Drawing.Point(16, 52);
            this.lblFirstNameHint.Name = "lblFirstNameHint";
            this.lblFirstNameHint.Size = new System.Drawing.Size(0, 20);
            this.lblFirstNameHint.TabIndex = 25;
            // 
            // lblLastNameHint
            // 
            this.lblLastNameHint.AutoSize = true;
            this.lblLastNameHint.BackColor = System.Drawing.Color.Transparent;
            this.lblLastNameHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameHint.ForeColor = System.Drawing.Color.Red;
            this.lblLastNameHint.Location = new System.Drawing.Point(16, 106);
            this.lblLastNameHint.Name = "lblLastNameHint";
            this.lblLastNameHint.Size = new System.Drawing.Size(0, 20);
            this.lblLastNameHint.TabIndex = 26;
            // 
            // lblBirthYearHint
            // 
            this.lblBirthYearHint.AutoSize = true;
            this.lblBirthYearHint.BackColor = System.Drawing.Color.Transparent;
            this.lblBirthYearHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthYearHint.ForeColor = System.Drawing.Color.Red;
            this.lblBirthYearHint.Location = new System.Drawing.Point(16, 158);
            this.lblBirthYearHint.Name = "lblBirthYearHint";
            this.lblBirthYearHint.Size = new System.Drawing.Size(0, 20);
            this.lblBirthYearHint.TabIndex = 27;
            // 
            // lblPhoneNumberHint
            // 
            this.lblPhoneNumberHint.AutoSize = true;
            this.lblPhoneNumberHint.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumberHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumberHint.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneNumberHint.Location = new System.Drawing.Point(16, 266);
            this.lblPhoneNumberHint.Name = "lblPhoneNumberHint";
            this.lblPhoneNumberHint.Size = new System.Drawing.Size(0, 20);
            this.lblPhoneNumberHint.TabIndex = 28;
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::View.Properties.Resources.Untitled_Artwork2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 571);
            this.Controls.Add(this.lblPhoneNumberHint);
            this.Controls.Add(this.lblBirthYearHint);
            this.Controls.Add(this.lblLastNameHint);
            this.Controls.Add(this.lblFirstNameHint);
            this.Controls.Add(this.lblEmailError);
            this.Controls.Add(this.grpbxPurchaseInfo);
            this.Controls.Add(this.lblErrorEmailAddress);
            this.Controls.Add(this.lblErrorPhoneNumber);
            this.Controls.Add(this.lblErrorBirthYear);
            this.Controls.Add(this.lblErrorLastName);
            this.Controls.Add(this.lblErrorFirstName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbbxSex);
            this.Controls.Add(this.txtbxEmailAddress);
            this.Controls.Add(this.txtbxPhoneNumber);
            this.Controls.Add(this.txtbxBirthYear);
            this.Controls.Add(this.txtbxLastName);
            this.Controls.Add(this.txtbxFirstName);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblBirthYear);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonForm";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.PersonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grpbxPurchaseInfo.ResumeLayout(false);
            this.grpbxPurchaseInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxPurchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblBirthYear;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox txtbxFirstName;
        private System.Windows.Forms.TextBox txtbxLastName;
        private System.Windows.Forms.TextBox txtbxBirthYear;
        private System.Windows.Forms.TextBox txtbxPhoneNumber;
        private System.Windows.Forms.TextBox txtbxEmailAddress;
        private System.Windows.Forms.ComboBox cmbbxSex;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblErrorFirstName;
        private System.Windows.Forms.Label lblErrorLastName;
        private System.Windows.Forms.Label lblErrorBirthYear;
        private System.Windows.Forms.Label lblErrorPhoneNumber;
        private System.Windows.Forms.Label lblErrorEmailAddress;
        private System.Windows.Forms.GroupBox grpbxPurchaseInfo;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.Label lblLastNameHint;
        private System.Windows.Forms.Label lblFirstNameHint;
        private System.Windows.Forms.Label lblPhoneNumberHint;
        private System.Windows.Forms.Label lblBirthYearHint;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label lblPurchaseName;
        public System.Windows.Forms.TextBox txtbxPurchasePrice;
        public System.Windows.Forms.TextBox txtbxPurchaseName;
        public System.Windows.Forms.PictureBox pctrbxPurchase;
    }
}