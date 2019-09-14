namespace View
{
    partial class ManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementForm));
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductImage = new System.Windows.Forms.Label();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.lblProductUnitPrice = new System.Windows.Forms.Label();
            this.lblDiscountDiscount = new System.Windows.Forms.Label();
            this.txtbxProductName = new System.Windows.Forms.TextBox();
            this.txtbxProductDiscount = new System.Windows.Forms.TextBox();
            this.txtbxProductUnitPrice = new System.Windows.Forms.TextBox();
            this.nmrcUpDwnProductQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnUpload = new System.Windows.Forms.Button();
            this.fileDialogUpload = new System.Windows.Forms.OpenFileDialog();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.grpbxProducts = new System.Windows.Forms.GroupBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnProductRefresh = new System.Windows.Forms.Button();
            this.btnProductEdit = new System.Windows.Forms.Button();
            this.btnProductRemove = new System.Windows.Forms.Button();
            this.grpbxPeople = new System.Windows.Forms.GroupBox();
            this.lblShowPersonID = new System.Windows.Forms.Label();
            this.lblPersonCode = new System.Windows.Forms.Label();
            this.txtbxPersonEmailAddress = new System.Windows.Forms.TextBox();
            this.lblPersonEmailAddress = new System.Windows.Forms.Label();
            this.cmbbxPersonSex = new System.Windows.Forms.ComboBox();
            this.txtbxPersonBirthYear = new System.Windows.Forms.TextBox();
            this.txtbxPersonLastName = new System.Windows.Forms.TextBox();
            this.lblPersonSex = new System.Windows.Forms.Label();
            this.lblPersonBirthYear = new System.Windows.Forms.Label();
            this.lblPersonLastName = new System.Windows.Forms.Label();
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.btnPersonRefresh = new System.Windows.Forms.Button();
            this.btnPersonEdit = new System.Windows.Forms.Button();
            this.btnPersonRemove = new System.Windows.Forms.Button();
            this.txtbxPersonPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPersonPhoneNumber = new System.Windows.Forms.Label();
            this.txtbxPersonFirstName = new System.Windows.Forms.TextBox();
            this.lblPersonFirstName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnProductQuantity)).BeginInit();
            this.grpbxProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.grpbxPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(58, 50);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(41, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Name: ";
            // 
            // lblProductImage
            // 
            this.lblProductImage.AutoSize = true;
            this.lblProductImage.Location = new System.Drawing.Point(18, 161);
            this.lblProductImage.Name = "lblProductImage";
            this.lblProductImage.Size = new System.Drawing.Size(81, 13);
            this.lblProductImage.TabIndex = 1;
            this.lblProductImage.Text = "Product Photo: ";
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Location = new System.Drawing.Point(29, 80);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblProductQuantity.TabIndex = 2;
            this.lblProductQuantity.Text = "Quantity:";
            // 
            // lblProductUnitPrice
            // 
            this.lblProductUnitPrice.AutoSize = true;
            this.lblProductUnitPrice.Location = new System.Drawing.Point(29, 105);
            this.lblProductUnitPrice.Name = "lblProductUnitPrice";
            this.lblProductUnitPrice.Size = new System.Drawing.Size(56, 13);
            this.lblProductUnitPrice.TabIndex = 3;
            this.lblProductUnitPrice.Text = "Unit Price:";
            // 
            // lblDiscountDiscount
            // 
            this.lblDiscountDiscount.AutoSize = true;
            this.lblDiscountDiscount.Location = new System.Drawing.Point(29, 130);
            this.lblDiscountDiscount.Name = "lblDiscountDiscount";
            this.lblDiscountDiscount.Size = new System.Drawing.Size(55, 13);
            this.lblDiscountDiscount.TabIndex = 4;
            this.lblDiscountDiscount.Text = "Discount: ";
            // 
            // txtbxProductName
            // 
            this.txtbxProductName.Location = new System.Drawing.Point(105, 47);
            this.txtbxProductName.Name = "txtbxProductName";
            this.txtbxProductName.Size = new System.Drawing.Size(100, 20);
            this.txtbxProductName.TabIndex = 5;
            // 
            // txtbxProductDiscount
            // 
            this.txtbxProductDiscount.Location = new System.Drawing.Point(105, 127);
            this.txtbxProductDiscount.Name = "txtbxProductDiscount";
            this.txtbxProductDiscount.Size = new System.Drawing.Size(100, 20);
            this.txtbxProductDiscount.TabIndex = 8;
            // 
            // txtbxProductUnitPrice
            // 
            this.txtbxProductUnitPrice.Location = new System.Drawing.Point(105, 102);
            this.txtbxProductUnitPrice.Name = "txtbxProductUnitPrice";
            this.txtbxProductUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtbxProductUnitPrice.TabIndex = 9;
            // 
            // nmrcUpDwnProductQuantity
            // 
            this.nmrcUpDwnProductQuantity.Location = new System.Drawing.Point(105, 73);
            this.nmrcUpDwnProductQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrcUpDwnProductQuantity.Name = "nmrcUpDwnProductQuantity";
            this.nmrcUpDwnProductQuantity.Size = new System.Drawing.Size(100, 20);
            this.nmrcUpDwnProductQuantity.TabIndex = 10;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(105, 153);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(100, 23);
            this.btnUpload.TabIndex = 11;
            this.btnUpload.Text = "Browse";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // fileDialogUpload
            // 
            this.fileDialogUpload.Filter = "\"JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*\"";
            this.fileDialogUpload.FilterIndex = 2;
            this.fileDialogUpload.InitialDirectory = "@\"C:\\\"";
            this.fileDialogUpload.Title = "Open a Picture";
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(258, 45);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(75, 23);
            this.btnProductAdd.TabIndex = 12;
            this.btnProductAdd.Text = "Add";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.BtnProductAdd_Click_1);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(18, 174);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(0, 13);
            this.lblFileName.TabIndex = 13;
            // 
            // grpbxProducts
            // 
            this.grpbxProducts.Controls.Add(this.dgvProducts);
            this.grpbxProducts.Controls.Add(this.btnProductRefresh);
            this.grpbxProducts.Controls.Add(this.btnProductEdit);
            this.grpbxProducts.Controls.Add(this.btnProductRemove);
            this.grpbxProducts.Controls.Add(this.btnUpload);
            this.grpbxProducts.Controls.Add(this.btnProductAdd);
            this.grpbxProducts.Controls.Add(this.lblFileName);
            this.grpbxProducts.Controls.Add(this.lblProductName);
            this.grpbxProducts.Controls.Add(this.txtbxProductName);
            this.grpbxProducts.Controls.Add(this.txtbxProductUnitPrice);
            this.grpbxProducts.Controls.Add(this.lblProductImage);
            this.grpbxProducts.Controls.Add(this.lblProductUnitPrice);
            this.grpbxProducts.Controls.Add(this.lblProductQuantity);
            this.grpbxProducts.Controls.Add(this.lblDiscountDiscount);
            this.grpbxProducts.Controls.Add(this.txtbxProductDiscount);
            this.grpbxProducts.Controls.Add(this.nmrcUpDwnProductQuantity);
            this.grpbxProducts.Location = new System.Drawing.Point(12, 11);
            this.grpbxProducts.Name = "grpbxProducts";
            this.grpbxProducts.Size = new System.Drawing.Size(367, 392);
            this.grpbxProducts.TabIndex = 14;
            this.grpbxProducts.TabStop = false;
            this.grpbxProducts.Text = "Manage Products";
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(6, 208);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(355, 178);
            this.dgvProducts.TabIndex = 17;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProducts_CellClick);
            // 
            // btnProductRefresh
            // 
            this.btnProductRefresh.Location = new System.Drawing.Point(258, 131);
            this.btnProductRefresh.Name = "btnProductRefresh";
            this.btnProductRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnProductRefresh.TabIndex = 16;
            this.btnProductRefresh.Text = "Refresh";
            this.btnProductRefresh.UseVisualStyleBackColor = true;
            this.btnProductRefresh.Click += new System.EventHandler(this.BtnProductRefresh_Click);
            // 
            // btnProductEdit
            // 
            this.btnProductEdit.Location = new System.Drawing.Point(258, 102);
            this.btnProductEdit.Name = "btnProductEdit";
            this.btnProductEdit.Size = new System.Drawing.Size(75, 23);
            this.btnProductEdit.TabIndex = 15;
            this.btnProductEdit.Text = "Edit";
            this.btnProductEdit.UseVisualStyleBackColor = true;
            this.btnProductEdit.Click += new System.EventHandler(this.BtnProductEdit_Click);
            // 
            // btnProductRemove
            // 
            this.btnProductRemove.Location = new System.Drawing.Point(258, 75);
            this.btnProductRemove.Name = "btnProductRemove";
            this.btnProductRemove.Size = new System.Drawing.Size(75, 23);
            this.btnProductRemove.TabIndex = 14;
            this.btnProductRemove.Text = "Remove";
            this.btnProductRemove.UseVisualStyleBackColor = true;
            this.btnProductRemove.Click += new System.EventHandler(this.BtnProductRemove_Click);
            // 
            // grpbxPeople
            // 
            this.grpbxPeople.Controls.Add(this.lblShowPersonID);
            this.grpbxPeople.Controls.Add(this.lblPersonCode);
            this.grpbxPeople.Controls.Add(this.txtbxPersonEmailAddress);
            this.grpbxPeople.Controls.Add(this.lblPersonEmailAddress);
            this.grpbxPeople.Controls.Add(this.cmbbxPersonSex);
            this.grpbxPeople.Controls.Add(this.txtbxPersonBirthYear);
            this.grpbxPeople.Controls.Add(this.txtbxPersonLastName);
            this.grpbxPeople.Controls.Add(this.lblPersonSex);
            this.grpbxPeople.Controls.Add(this.lblPersonBirthYear);
            this.grpbxPeople.Controls.Add(this.lblPersonLastName);
            this.grpbxPeople.Controls.Add(this.dgvPerson);
            this.grpbxPeople.Controls.Add(this.btnPersonRefresh);
            this.grpbxPeople.Controls.Add(this.btnPersonEdit);
            this.grpbxPeople.Controls.Add(this.btnPersonRemove);
            this.grpbxPeople.Controls.Add(this.txtbxPersonPhoneNumber);
            this.grpbxPeople.Controls.Add(this.lblPersonPhoneNumber);
            this.grpbxPeople.Controls.Add(this.txtbxPersonFirstName);
            this.grpbxPeople.Controls.Add(this.lblPersonFirstName);
            this.grpbxPeople.Location = new System.Drawing.Point(385, 12);
            this.grpbxPeople.Name = "grpbxPeople";
            this.grpbxPeople.Size = new System.Drawing.Size(367, 391);
            this.grpbxPeople.TabIndex = 15;
            this.grpbxPeople.TabStop = false;
            this.grpbxPeople.Text = "Manage People";
            // 
            // lblShowPersonID
            // 
            this.lblShowPersonID.AutoSize = true;
            this.lblShowPersonID.Location = new System.Drawing.Point(259, 133);
            this.lblShowPersonID.Name = "lblShowPersonID";
            this.lblShowPersonID.Size = new System.Drawing.Size(0, 13);
            this.lblShowPersonID.TabIndex = 36;
            // 
            // lblPersonCode
            // 
            this.lblPersonCode.AutoSize = true;
            this.lblPersonCode.Location = new System.Drawing.Point(232, 133);
            this.lblPersonCode.Name = "lblPersonCode";
            this.lblPersonCode.Size = new System.Drawing.Size(21, 13);
            this.lblPersonCode.TabIndex = 35;
            this.lblPersonCode.Text = "ID:";
            // 
            // txtbxPersonEmailAddress
            // 
            this.txtbxPersonEmailAddress.Location = new System.Drawing.Point(250, 93);
            this.txtbxPersonEmailAddress.Name = "txtbxPersonEmailAddress";
            this.txtbxPersonEmailAddress.Size = new System.Drawing.Size(100, 20);
            this.txtbxPersonEmailAddress.TabIndex = 34;
            // 
            // lblPersonEmailAddress
            // 
            this.lblPersonEmailAddress.AutoSize = true;
            this.lblPersonEmailAddress.Location = new System.Drawing.Point(247, 77);
            this.lblPersonEmailAddress.Name = "lblPersonEmailAddress";
            this.lblPersonEmailAddress.Size = new System.Drawing.Size(76, 13);
            this.lblPersonEmailAddress.TabIndex = 33;
            this.lblPersonEmailAddress.Text = "Email Address:";
            // 
            // cmbbxPersonSex
            // 
            this.cmbbxPersonSex.FormattingEnabled = true;
            this.cmbbxPersonSex.Location = new System.Drawing.Point(235, 45);
            this.cmbbxPersonSex.Name = "cmbbxPersonSex";
            this.cmbbxPersonSex.Size = new System.Drawing.Size(121, 21);
            this.cmbbxPersonSex.TabIndex = 32;
            // 
            // txtbxPersonBirthYear
            // 
            this.txtbxPersonBirthYear.Location = new System.Drawing.Point(106, 92);
            this.txtbxPersonBirthYear.Name = "txtbxPersonBirthYear";
            this.txtbxPersonBirthYear.Size = new System.Drawing.Size(100, 20);
            this.txtbxPersonBirthYear.TabIndex = 31;
            // 
            // txtbxPersonLastName
            // 
            this.txtbxPersonLastName.Location = new System.Drawing.Point(106, 52);
            this.txtbxPersonLastName.Name = "txtbxPersonLastName";
            this.txtbxPersonLastName.Size = new System.Drawing.Size(100, 20);
            this.txtbxPersonLastName.TabIndex = 30;
            // 
            // lblPersonSex
            // 
            this.lblPersonSex.AutoSize = true;
            this.lblPersonSex.Location = new System.Drawing.Point(292, 27);
            this.lblPersonSex.Name = "lblPersonSex";
            this.lblPersonSex.Size = new System.Drawing.Size(31, 13);
            this.lblPersonSex.TabIndex = 29;
            this.lblPersonSex.Text = "Sex: ";
            // 
            // lblPersonBirthYear
            // 
            this.lblPersonBirthYear.AutoSize = true;
            this.lblPersonBirthYear.Location = new System.Drawing.Point(20, 99);
            this.lblPersonBirthYear.Name = "lblPersonBirthYear";
            this.lblPersonBirthYear.Size = new System.Drawing.Size(56, 13);
            this.lblPersonBirthYear.TabIndex = 28;
            this.lblPersonBirthYear.Text = "Birth Year:";
            // 
            // lblPersonLastName
            // 
            this.lblPersonLastName.AutoSize = true;
            this.lblPersonLastName.Location = new System.Drawing.Point(20, 59);
            this.lblPersonLastName.Name = "lblPersonLastName";
            this.lblPersonLastName.Size = new System.Drawing.Size(64, 13);
            this.lblPersonLastName.TabIndex = 27;
            this.lblPersonLastName.Text = "Last Name: ";
            // 
            // dgvPerson
            // 
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Location = new System.Drawing.Point(6, 207);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.Size = new System.Drawing.Size(355, 178);
            this.dgvPerson.TabIndex = 26;
            this.dgvPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPerson_CellClick);
            // 
            // btnPersonRefresh
            // 
            this.btnPersonRefresh.Location = new System.Drawing.Point(286, 173);
            this.btnPersonRefresh.Name = "btnPersonRefresh";
            this.btnPersonRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnPersonRefresh.TabIndex = 25;
            this.btnPersonRefresh.Text = "Refresh";
            this.btnPersonRefresh.UseVisualStyleBackColor = true;
            this.btnPersonRefresh.Click += new System.EventHandler(this.BtnPersonRefresh_Click);
            // 
            // btnPersonEdit
            // 
            this.btnPersonEdit.Location = new System.Drawing.Point(143, 173);
            this.btnPersonEdit.Name = "btnPersonEdit";
            this.btnPersonEdit.Size = new System.Drawing.Size(75, 23);
            this.btnPersonEdit.TabIndex = 24;
            this.btnPersonEdit.Text = "Edit";
            this.btnPersonEdit.UseVisualStyleBackColor = true;
            this.btnPersonEdit.Click += new System.EventHandler(this.BtnPersonEdit_Click);
            // 
            // btnPersonRemove
            // 
            this.btnPersonRemove.Location = new System.Drawing.Point(6, 173);
            this.btnPersonRemove.Name = "btnPersonRemove";
            this.btnPersonRemove.Size = new System.Drawing.Size(75, 23);
            this.btnPersonRemove.TabIndex = 23;
            this.btnPersonRemove.Text = "Remove";
            this.btnPersonRemove.UseVisualStyleBackColor = true;
            this.btnPersonRemove.Click += new System.EventHandler(this.BtnPersonRemove_Click);
            // 
            // txtbxPersonPhoneNumber
            // 
            this.txtbxPersonPhoneNumber.Location = new System.Drawing.Point(113, 122);
            this.txtbxPersonPhoneNumber.Name = "txtbxPersonPhoneNumber";
            this.txtbxPersonPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtbxPersonPhoneNumber.TabIndex = 22;
            // 
            // lblPersonPhoneNumber
            // 
            this.lblPersonPhoneNumber.AutoSize = true;
            this.lblPersonPhoneNumber.Location = new System.Drawing.Point(1, 125);
            this.lblPersonPhoneNumber.Name = "lblPersonPhoneNumber";
            this.lblPersonPhoneNumber.Size = new System.Drawing.Size(84, 13);
            this.lblPersonPhoneNumber.TabIndex = 21;
            this.lblPersonPhoneNumber.Text = "Phone Number: ";
            // 
            // txtbxPersonFirstName
            // 
            this.txtbxPersonFirstName.Location = new System.Drawing.Point(113, 24);
            this.txtbxPersonFirstName.Name = "txtbxPersonFirstName";
            this.txtbxPersonFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtbxPersonFirstName.TabIndex = 20;
            // 
            // lblPersonFirstName
            // 
            this.lblPersonFirstName.AutoSize = true;
            this.lblPersonFirstName.Location = new System.Drawing.Point(29, 27);
            this.lblPersonFirstName.Name = "lblPersonFirstName";
            this.lblPersonFirstName.Size = new System.Drawing.Size(63, 13);
            this.lblPersonFirstName.TabIndex = 19;
            this.lblPersonFirstName.Text = "First Name: ";
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(761, 411);
            this.Controls.Add(this.grpbxPeople);
            this.Controls.Add(this.grpbxProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagementForm";
            this.Text = "Store Management";
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnProductQuantity)).EndInit();
            this.grpbxProducts.ResumeLayout(false);
            this.grpbxProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.grpbxPeople.ResumeLayout(false);
            this.grpbxPeople.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductImage;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.Label lblProductUnitPrice;
        private System.Windows.Forms.Label lblDiscountDiscount;
        private System.Windows.Forms.TextBox txtbxProductName;
        private System.Windows.Forms.TextBox txtbxProductDiscount;
        private System.Windows.Forms.TextBox txtbxProductUnitPrice;
        private System.Windows.Forms.NumericUpDown nmrcUpDwnProductQuantity;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog fileDialogUpload;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.GroupBox grpbxProducts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnProductRefresh;
        private System.Windows.Forms.Button btnProductEdit;
        private System.Windows.Forms.Button btnProductRemove;
        private System.Windows.Forms.GroupBox grpbxPeople;
        private System.Windows.Forms.TextBox txtbxPersonFirstName;
        private System.Windows.Forms.Label lblPersonFirstName;
        private System.Windows.Forms.Button btnPersonRefresh;
        private System.Windows.Forms.Button btnPersonEdit;
        private System.Windows.Forms.Button btnPersonRemove;
        private System.Windows.Forms.TextBox txtbxPersonPhoneNumber;
        private System.Windows.Forms.Label lblPersonPhoneNumber;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.ComboBox cmbbxPersonSex;
        private System.Windows.Forms.TextBox txtbxPersonBirthYear;
        private System.Windows.Forms.TextBox txtbxPersonLastName;
        private System.Windows.Forms.Label lblPersonSex;
        private System.Windows.Forms.Label lblPersonBirthYear;
        private System.Windows.Forms.Label lblPersonLastName;
        private System.Windows.Forms.TextBox txtbxPersonEmailAddress;
        private System.Windows.Forms.Label lblPersonEmailAddress;
        private System.Windows.Forms.Label lblShowPersonID;
        private System.Windows.Forms.Label lblPersonCode;
    }
}