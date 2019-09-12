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
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblError1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(37, 46);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(63, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name: ";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(37, 72);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(64, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name: ";
            // 
            // lblBirthYear
            // 
            this.lblBirthYear.AutoSize = true;
            this.lblBirthYear.Location = new System.Drawing.Point(37, 102);
            this.lblBirthYear.Name = "lblBirthYear";
            this.lblBirthYear.Size = new System.Drawing.Size(56, 13);
            this.lblBirthYear.TabIndex = 2;
            this.lblBirthYear.Text = "Birth Year:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(37, 132);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(31, 13);
            this.lblSex.TabIndex = 3;
            this.lblSex.Text = "Sex: ";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(37, 157);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(37, 189);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(76, 13);
            this.lblEmailAddress.TabIndex = 5;
            this.lblEmailAddress.Text = "Email Address:";
            // 
            // txtbxFirstName
            // 
            this.txtbxFirstName.Location = new System.Drawing.Point(115, 43);
            this.txtbxFirstName.Name = "txtbxFirstName";
            this.txtbxFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtbxFirstName.TabIndex = 6;
            this.txtbxFirstName.TextChanged += new System.EventHandler(this.TxtbxFirstName_TextChanged);
            // 
            // txtbxLastName
            // 
            this.txtbxLastName.Location = new System.Drawing.Point(115, 69);
            this.txtbxLastName.Name = "txtbxLastName";
            this.txtbxLastName.Size = new System.Drawing.Size(100, 20);
            this.txtbxLastName.TabIndex = 7;
            // 
            // txtbxBirthYear
            // 
            this.txtbxBirthYear.Location = new System.Drawing.Point(115, 95);
            this.txtbxBirthYear.Name = "txtbxBirthYear";
            this.txtbxBirthYear.Size = new System.Drawing.Size(100, 20);
            this.txtbxBirthYear.TabIndex = 8;
            // 
            // txtbxPhoneNumber
            // 
            this.txtbxPhoneNumber.Location = new System.Drawing.Point(134, 154);
            this.txtbxPhoneNumber.Name = "txtbxPhoneNumber";
            this.txtbxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtbxPhoneNumber.TabIndex = 9;
            // 
            // txtbxEmailAddress
            // 
            this.txtbxEmailAddress.Location = new System.Drawing.Point(134, 186);
            this.txtbxEmailAddress.Name = "txtbxEmailAddress";
            this.txtbxEmailAddress.Size = new System.Drawing.Size(100, 20);
            this.txtbxEmailAddress.TabIndex = 10;
            // 
            // cmbbxSex
            // 
            this.cmbbxSex.FormattingEnabled = true;
            this.cmbbxSex.Location = new System.Drawing.Point(113, 124);
            this.cmbbxSex.Name = "cmbbxSex";
            this.cmbbxSex.Size = new System.Drawing.Size(121, 21);
            this.cmbbxSex.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(415, 93);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(415, 124);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(415, 155);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(415, 184);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // dgvPerson
            // 
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Location = new System.Drawing.Point(85, 262);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.Size = new System.Drawing.Size(240, 150);
            this.dgvPerson.TabIndex = 16;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // lblError1
            // 
            this.lblError1.AutoSize = true;
            this.lblError1.Location = new System.Drawing.Point(234, 46);
            this.lblError1.Name = "lblError1";
            this.lblError1.Size = new System.Drawing.Size(0, 13);
            this.lblError1.TabIndex = 17;
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 490);
            this.Controls.Add(this.lblError1);
            this.Controls.Add(this.dgvPerson);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemove);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblError1;
    }
}