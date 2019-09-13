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
            this.button1 = new System.Windows.Forms.Button();
            this.grpbxPurchaseInfo = new System.Windows.Forms.GroupBox();
            this.lblPurchaseInfo = new System.Windows.Forms.Label();
            this.lblEmailError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grpbxPurchaseInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(65, 55);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(63, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name: ";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(65, 81);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(64, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name: ";
            // 
            // lblBirthYear
            // 
            this.lblBirthYear.AutoSize = true;
            this.lblBirthYear.Location = new System.Drawing.Point(65, 111);
            this.lblBirthYear.Name = "lblBirthYear";
            this.lblBirthYear.Size = new System.Drawing.Size(56, 13);
            this.lblBirthYear.TabIndex = 2;
            this.lblBirthYear.Text = "Birth Year:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(65, 141);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(31, 13);
            this.lblSex.TabIndex = 3;
            this.lblSex.Text = "Sex: ";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(65, 166);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(65, 198);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(76, 13);
            this.lblEmailAddress.TabIndex = 5;
            this.lblEmailAddress.Text = "Email Address:";
            // 
            // txtbxFirstName
            // 
            this.txtbxFirstName.Location = new System.Drawing.Point(143, 52);
            this.txtbxFirstName.Name = "txtbxFirstName";
            this.txtbxFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtbxFirstName.TabIndex = 6;
            this.txtbxFirstName.TextChanged += new System.EventHandler(this.TxtbxFirstName_TextChanged);
            // 
            // txtbxLastName
            // 
            this.txtbxLastName.Location = new System.Drawing.Point(143, 78);
            this.txtbxLastName.Name = "txtbxLastName";
            this.txtbxLastName.Size = new System.Drawing.Size(100, 20);
            this.txtbxLastName.TabIndex = 7;
            this.txtbxLastName.TextChanged += new System.EventHandler(this.TxtbxLastName_TextChanged);
            // 
            // txtbxBirthYear
            // 
            this.txtbxBirthYear.Location = new System.Drawing.Point(143, 104);
            this.txtbxBirthYear.Name = "txtbxBirthYear";
            this.txtbxBirthYear.Size = new System.Drawing.Size(100, 20);
            this.txtbxBirthYear.TabIndex = 8;
            this.txtbxBirthYear.TextChanged += new System.EventHandler(this.TxtbxBirthYear_TextChanged);
            // 
            // txtbxPhoneNumber
            // 
            this.txtbxPhoneNumber.Location = new System.Drawing.Point(162, 163);
            this.txtbxPhoneNumber.Name = "txtbxPhoneNumber";
            this.txtbxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtbxPhoneNumber.TabIndex = 9;
            // 
            // txtbxEmailAddress
            // 
            this.txtbxEmailAddress.Location = new System.Drawing.Point(162, 195);
            this.txtbxEmailAddress.Name = "txtbxEmailAddress";
            this.txtbxEmailAddress.Size = new System.Drawing.Size(100, 20);
            this.txtbxEmailAddress.TabIndex = 10;
            this.txtbxEmailAddress.Leave += new System.EventHandler(this.TxtbxEmailAddress_Leave);
            // 
            // cmbbxSex
            // 
            this.cmbbxSex.FormattingEnabled = true;
            this.cmbbxSex.Location = new System.Drawing.Point(141, 133);
            this.cmbbxSex.Name = "cmbbxSex";
            this.cmbbxSex.Size = new System.Drawing.Size(121, 21);
            this.cmbbxSex.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(168, 237);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
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
            this.lblErrorFirstName.Location = new System.Drawing.Point(262, 55);
            this.lblErrorFirstName.Name = "lblErrorFirstName";
            this.lblErrorFirstName.Size = new System.Drawing.Size(0, 13);
            this.lblErrorFirstName.TabIndex = 17;
            // 
            // lblErrorLastName
            // 
            this.lblErrorLastName.AutoSize = true;
            this.lblErrorLastName.Location = new System.Drawing.Point(262, 81);
            this.lblErrorLastName.Name = "lblErrorLastName";
            this.lblErrorLastName.Size = new System.Drawing.Size(0, 13);
            this.lblErrorLastName.TabIndex = 18;
            // 
            // lblErrorBirthYear
            // 
            this.lblErrorBirthYear.AutoSize = true;
            this.lblErrorBirthYear.Location = new System.Drawing.Point(262, 107);
            this.lblErrorBirthYear.Name = "lblErrorBirthYear";
            this.lblErrorBirthYear.Size = new System.Drawing.Size(0, 13);
            this.lblErrorBirthYear.TabIndex = 19;
            // 
            // lblErrorPhoneNumber
            // 
            this.lblErrorPhoneNumber.AutoSize = true;
            this.lblErrorPhoneNumber.Location = new System.Drawing.Point(277, 166);
            this.lblErrorPhoneNumber.Name = "lblErrorPhoneNumber";
            this.lblErrorPhoneNumber.Size = new System.Drawing.Size(0, 13);
            this.lblErrorPhoneNumber.TabIndex = 20;
            // 
            // lblErrorEmailAddress
            // 
            this.lblErrorEmailAddress.AutoSize = true;
            this.lblErrorEmailAddress.Location = new System.Drawing.Point(277, 198);
            this.lblErrorEmailAddress.Name = "lblErrorEmailAddress";
            this.lblErrorEmailAddress.Size = new System.Drawing.Size(0, 13);
            this.lblErrorEmailAddress.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // grpbxPurchaseInfo
            // 
            this.grpbxPurchaseInfo.Controls.Add(this.lblPurchaseInfo);
            this.grpbxPurchaseInfo.Location = new System.Drawing.Point(431, 28);
            this.grpbxPurchaseInfo.Name = "grpbxPurchaseInfo";
            this.grpbxPurchaseInfo.Size = new System.Drawing.Size(232, 301);
            this.grpbxPurchaseInfo.TabIndex = 23;
            this.grpbxPurchaseInfo.TabStop = false;
            this.grpbxPurchaseInfo.Text = "Purchase Info";
            // 
            // lblPurchaseInfo
            // 
            this.lblPurchaseInfo.AutoSize = true;
            this.lblPurchaseInfo.Location = new System.Drawing.Point(6, 24);
            this.lblPurchaseInfo.Name = "lblPurchaseInfo";
            this.lblPurchaseInfo.Size = new System.Drawing.Size(0, 13);
            this.lblPurchaseInfo.TabIndex = 0;
            // 
            // lblEmailError
            // 
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.Location = new System.Drawing.Point(277, 198);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(0, 13);
            this.lblEmailError.TabIndex = 24;
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 411);
            this.Controls.Add(this.lblEmailError);
            this.Controls.Add(this.grpbxPurchaseInfo);
            this.Controls.Add(this.button1);
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
            this.Text = "PersonForm";
            this.Load += new System.EventHandler(this.PersonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grpbxPurchaseInfo.ResumeLayout(false);
            this.grpbxPurchaseInfo.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpbxPurchaseInfo;
        private System.Windows.Forms.Label lblPurchaseInfo;
        private System.Windows.Forms.Label lblEmailError;
    }
}