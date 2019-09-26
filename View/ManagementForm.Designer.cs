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
            this.lblShowProductCode = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnProductRefresh = new System.Windows.Forms.Button();
            this.btnProductEdit = new System.Windows.Forms.Button();
            this.btnProductRemove = new System.Windows.Forms.Button();
            this.grpbxPeople = new System.Windows.Forms.GroupBox();
            this.lblShowPersonAge = new System.Windows.Forms.Label();
            this.lblPersonAge = new System.Windows.Forms.Label();
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
            this.lblProductName.Location = new System.Drawing.Point(29, 53);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(59, 20);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Name: ";
            // 
            // lblProductImage
            // 
            this.lblProductImage.AutoSize = true;
            this.lblProductImage.Location = new System.Drawing.Point(30, 193);
            this.lblProductImage.Name = "lblProductImage";
            this.lblProductImage.Size = new System.Drawing.Size(118, 20);
            this.lblProductImage.TabIndex = 1;
            this.lblProductImage.Text = "Product Photo: ";
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Location = new System.Drawing.Point(29, 86);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(72, 20);
            this.lblProductQuantity.TabIndex = 2;
            this.lblProductQuantity.Text = "Quantity:";
            // 
            // lblProductUnitPrice
            // 
            this.lblProductUnitPrice.AutoSize = true;
            this.lblProductUnitPrice.Location = new System.Drawing.Point(29, 118);
            this.lblProductUnitPrice.Name = "lblProductUnitPrice";
            this.lblProductUnitPrice.Size = new System.Drawing.Size(81, 20);
            this.lblProductUnitPrice.TabIndex = 3;
            this.lblProductUnitPrice.Text = "Unit Price:";
            // 
            // lblDiscountDiscount
            // 
            this.lblDiscountDiscount.AutoSize = true;
            this.lblDiscountDiscount.Location = new System.Drawing.Point(30, 148);
            this.lblDiscountDiscount.Name = "lblDiscountDiscount";
            this.lblDiscountDiscount.Size = new System.Drawing.Size(80, 20);
            this.lblDiscountDiscount.TabIndex = 4;
            this.lblDiscountDiscount.Text = "Discount: ";
            // 
            // txtbxProductName
            // 
            this.txtbxProductName.Location = new System.Drawing.Point(124, 53);
            this.txtbxProductName.Name = "txtbxProductName";
            this.txtbxProductName.Size = new System.Drawing.Size(119, 26);
            this.txtbxProductName.TabIndex = 5;
            // 
            // txtbxProductDiscount
            // 
            this.txtbxProductDiscount.Location = new System.Drawing.Point(124, 147);
            this.txtbxProductDiscount.Name = "txtbxProductDiscount";
            this.txtbxProductDiscount.Size = new System.Drawing.Size(119, 26);
            this.txtbxProductDiscount.TabIndex = 8;
            // 
            // txtbxProductUnitPrice
            // 
            this.txtbxProductUnitPrice.Location = new System.Drawing.Point(124, 115);
            this.txtbxProductUnitPrice.Name = "txtbxProductUnitPrice";
            this.txtbxProductUnitPrice.Size = new System.Drawing.Size(117, 26);
            this.txtbxProductUnitPrice.TabIndex = 9;
            // 
            // nmrcUpDwnProductQuantity
            // 
            this.nmrcUpDwnProductQuantity.Location = new System.Drawing.Point(124, 84);
            this.nmrcUpDwnProductQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrcUpDwnProductQuantity.Name = "nmrcUpDwnProductQuantity";
            this.nmrcUpDwnProductQuantity.Size = new System.Drawing.Size(117, 26);
            this.nmrcUpDwnProductQuantity.TabIndex = 10;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(154, 188);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(102, 30);
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
            this.btnProductAdd.Location = new System.Drawing.Point(280, 30);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(81, 35);
            this.btnProductAdd.TabIndex = 12;
            this.btnProductAdd.Text = "Add";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.BtnProductAdd_Click_1);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(16, 235);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(0, 15);
            this.lblFileName.TabIndex = 13;
            // 
            // grpbxProducts
            // 
            this.grpbxProducts.BackColor = System.Drawing.Color.Transparent;
            this.grpbxProducts.Controls.Add(this.lblShowProductCode);
            this.grpbxProducts.Controls.Add(this.lblProductCode);
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
            this.grpbxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxProducts.Location = new System.Drawing.Point(12, 12);
            this.grpbxProducts.Name = "grpbxProducts";
            this.grpbxProducts.Size = new System.Drawing.Size(367, 547);
            this.grpbxProducts.TabIndex = 14;
            this.grpbxProducts.TabStop = false;
            this.grpbxProducts.Text = "Manage Products";
            // 
            // lblShowProductCode
            // 
            this.lblShowProductCode.AutoSize = true;
            this.lblShowProductCode.Location = new System.Drawing.Point(105, 263);
            this.lblShowProductCode.Name = "lblShowProductCode";
            this.lblShowProductCode.Size = new System.Drawing.Size(0, 20);
            this.lblShowProductCode.TabIndex = 19;
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Location = new System.Drawing.Point(37, 263);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(51, 20);
            this.lblProductCode.TabIndex = 18;
            this.lblProductCode.Text = "Code:";
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(6, 312);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowTemplate.Height = 60;
            this.dgvProducts.Size = new System.Drawing.Size(355, 229);
            this.dgvProducts.TabIndex = 17;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProducts_CellClick);
            // 
            // btnProductRefresh
            // 
            this.btnProductRefresh.Location = new System.Drawing.Point(280, 205);
            this.btnProductRefresh.Name = "btnProductRefresh";
            this.btnProductRefresh.Size = new System.Drawing.Size(81, 35);
            this.btnProductRefresh.TabIndex = 16;
            this.btnProductRefresh.Text = "Refresh";
            this.btnProductRefresh.UseVisualStyleBackColor = true;
            this.btnProductRefresh.Click += new System.EventHandler(this.BtnProductRefresh_Click);
            // 
            // btnProductEdit
            // 
            this.btnProductEdit.Location = new System.Drawing.Point(280, 147);
            this.btnProductEdit.Name = "btnProductEdit";
            this.btnProductEdit.Size = new System.Drawing.Size(81, 35);
            this.btnProductEdit.TabIndex = 15;
            this.btnProductEdit.Text = "Edit";
            this.btnProductEdit.UseVisualStyleBackColor = true;
            this.btnProductEdit.Click += new System.EventHandler(this.BtnProductEdit_Click);
            // 
            // btnProductRemove
            // 
            this.btnProductRemove.Location = new System.Drawing.Point(280, 88);
            this.btnProductRemove.Name = "btnProductRemove";
            this.btnProductRemove.Size = new System.Drawing.Size(81, 35);
            this.btnProductRemove.TabIndex = 14;
            this.btnProductRemove.Text = "Remove";
            this.btnProductRemove.UseVisualStyleBackColor = true;
            this.btnProductRemove.Click += new System.EventHandler(this.BtnProductRemove_Click);
            // 
            // grpbxPeople
            // 
            this.grpbxPeople.BackColor = System.Drawing.Color.Transparent;
            this.grpbxPeople.Controls.Add(this.lblShowPersonAge);
            this.grpbxPeople.Controls.Add(this.lblPersonAge);
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
            this.grpbxPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxPeople.Location = new System.Drawing.Point(385, 12);
            this.grpbxPeople.Name = "grpbxPeople";
            this.grpbxPeople.Size = new System.Drawing.Size(367, 547);
            this.grpbxPeople.TabIndex = 15;
            this.grpbxPeople.TabStop = false;
            this.grpbxPeople.Text = "Manage People";
            // 
            // lblShowPersonAge
            // 
            this.lblShowPersonAge.AutoSize = true;
            this.lblShowPersonAge.Location = new System.Drawing.Point(171, 235);
            this.lblShowPersonAge.Name = "lblShowPersonAge";
            this.lblShowPersonAge.Size = new System.Drawing.Size(0, 20);
            this.lblShowPersonAge.TabIndex = 38;
            // 
            // lblPersonAge
            // 
            this.lblPersonAge.AutoSize = true;
            this.lblPersonAge.Location = new System.Drawing.Point(123, 235);
            this.lblPersonAge.Name = "lblPersonAge";
            this.lblPersonAge.Size = new System.Drawing.Size(42, 20);
            this.lblPersonAge.TabIndex = 37;
            this.lblPersonAge.Text = "Age:";
            // 
            // lblShowPersonID
            // 
            this.lblShowPersonID.AutoSize = true;
            this.lblShowPersonID.Location = new System.Drawing.Point(83, 235);
            this.lblShowPersonID.Name = "lblShowPersonID";
            this.lblShowPersonID.Size = new System.Drawing.Size(0, 20);
            this.lblShowPersonID.TabIndex = 36;
            // 
            // lblPersonCode
            // 
            this.lblPersonCode.AutoSize = true;
            this.lblPersonCode.Location = new System.Drawing.Point(47, 235);
            this.lblPersonCode.Name = "lblPersonCode";
            this.lblPersonCode.Size = new System.Drawing.Size(30, 20);
            this.lblPersonCode.TabIndex = 35;
            this.lblPersonCode.Text = "ID:";
            // 
            // txtbxPersonEmailAddress
            // 
            this.txtbxPersonEmailAddress.Location = new System.Drawing.Point(168, 199);
            this.txtbxPersonEmailAddress.Name = "txtbxPersonEmailAddress";
            this.txtbxPersonEmailAddress.Size = new System.Drawing.Size(120, 26);
            this.txtbxPersonEmailAddress.TabIndex = 34;
            // 
            // lblPersonEmailAddress
            // 
            this.lblPersonEmailAddress.AutoSize = true;
            this.lblPersonEmailAddress.Location = new System.Drawing.Point(47, 202);
            this.lblPersonEmailAddress.Name = "lblPersonEmailAddress";
            this.lblPersonEmailAddress.Size = new System.Drawing.Size(115, 20);
            this.lblPersonEmailAddress.TabIndex = 33;
            this.lblPersonEmailAddress.Text = "Email Address:";
            // 
            // cmbbxPersonSex
            // 
            this.cmbbxPersonSex.FormattingEnabled = true;
            this.cmbbxPersonSex.Location = new System.Drawing.Point(127, 120);
            this.cmbbxPersonSex.Name = "cmbbxPersonSex";
            this.cmbbxPersonSex.Size = new System.Drawing.Size(161, 28);
            this.cmbbxPersonSex.TabIndex = 32;
            // 
            // txtbxPersonBirthYear
            // 
            this.txtbxPersonBirthYear.Location = new System.Drawing.Point(148, 88);
            this.txtbxPersonBirthYear.Name = "txtbxPersonBirthYear";
            this.txtbxPersonBirthYear.Size = new System.Drawing.Size(140, 26);
            this.txtbxPersonBirthYear.TabIndex = 31;
            // 
            // txtbxPersonLastName
            // 
            this.txtbxPersonLastName.Location = new System.Drawing.Point(148, 56);
            this.txtbxPersonLastName.Name = "txtbxPersonLastName";
            this.txtbxPersonLastName.Size = new System.Drawing.Size(140, 26);
            this.txtbxPersonLastName.TabIndex = 30;
            // 
            // lblPersonSex
            // 
            this.lblPersonSex.AutoSize = true;
            this.lblPersonSex.Location = new System.Drawing.Point(39, 122);
            this.lblPersonSex.Name = "lblPersonSex";
            this.lblPersonSex.Size = new System.Drawing.Size(44, 20);
            this.lblPersonSex.TabIndex = 29;
            this.lblPersonSex.Text = "Sex: ";
            // 
            // lblPersonBirthYear
            // 
            this.lblPersonBirthYear.AutoSize = true;
            this.lblPersonBirthYear.Location = new System.Drawing.Point(39, 91);
            this.lblPersonBirthYear.Name = "lblPersonBirthYear";
            this.lblPersonBirthYear.Size = new System.Drawing.Size(84, 20);
            this.lblPersonBirthYear.TabIndex = 28;
            this.lblPersonBirthYear.Text = "Birth Year:";
            // 
            // lblPersonLastName
            // 
            this.lblPersonLastName.AutoSize = true;
            this.lblPersonLastName.Location = new System.Drawing.Point(39, 59);
            this.lblPersonLastName.Name = "lblPersonLastName";
            this.lblPersonLastName.Size = new System.Drawing.Size(94, 20);
            this.lblPersonLastName.TabIndex = 27;
            this.lblPersonLastName.Text = "Last Name: ";
            // 
            // dgvPerson
            // 
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Location = new System.Drawing.Point(7, 312);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.RowTemplate.Height = 30;
            this.dgvPerson.Size = new System.Drawing.Size(355, 229);
            this.dgvPerson.TabIndex = 26;
            this.dgvPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPerson_CellClick);
            // 
            // btnPersonRefresh
            // 
            this.btnPersonRefresh.Location = new System.Drawing.Point(280, 271);
            this.btnPersonRefresh.Name = "btnPersonRefresh";
            this.btnPersonRefresh.Size = new System.Drawing.Size(81, 35);
            this.btnPersonRefresh.TabIndex = 25;
            this.btnPersonRefresh.Text = "Refresh";
            this.btnPersonRefresh.UseVisualStyleBackColor = true;
            this.btnPersonRefresh.Click += new System.EventHandler(this.BtnPersonRefresh_Click);
            // 
            // btnPersonEdit
            // 
            this.btnPersonEdit.Location = new System.Drawing.Point(148, 271);
            this.btnPersonEdit.Name = "btnPersonEdit";
            this.btnPersonEdit.Size = new System.Drawing.Size(81, 35);
            this.btnPersonEdit.TabIndex = 24;
            this.btnPersonEdit.Text = "Edit";
            this.btnPersonEdit.UseVisualStyleBackColor = true;
            this.btnPersonEdit.Click += new System.EventHandler(this.BtnPersonEdit_Click);
            // 
            // btnPersonRemove
            // 
            this.btnPersonRemove.Location = new System.Drawing.Point(7, 271);
            this.btnPersonRemove.Name = "btnPersonRemove";
            this.btnPersonRemove.Size = new System.Drawing.Size(81, 35);
            this.btnPersonRemove.TabIndex = 23;
            this.btnPersonRemove.Text = "Remove";
            this.btnPersonRemove.UseVisualStyleBackColor = true;
            this.btnPersonRemove.Click += new System.EventHandler(this.BtnPersonRemove_Click);
            // 
            // txtbxPersonPhoneNumber
            // 
            this.txtbxPersonPhoneNumber.Location = new System.Drawing.Point(168, 159);
            this.txtbxPersonPhoneNumber.Name = "txtbxPersonPhoneNumber";
            this.txtbxPersonPhoneNumber.Size = new System.Drawing.Size(120, 26);
            this.txtbxPersonPhoneNumber.TabIndex = 22;
            // 
            // lblPersonPhoneNumber
            // 
            this.lblPersonPhoneNumber.AutoSize = true;
            this.lblPersonPhoneNumber.Location = new System.Drawing.Point(39, 162);
            this.lblPersonPhoneNumber.Name = "lblPersonPhoneNumber";
            this.lblPersonPhoneNumber.Size = new System.Drawing.Size(123, 20);
            this.lblPersonPhoneNumber.TabIndex = 21;
            this.lblPersonPhoneNumber.Text = "Phone Number: ";
            // 
            // txtbxPersonFirstName
            // 
            this.txtbxPersonFirstName.Location = new System.Drawing.Point(148, 25);
            this.txtbxPersonFirstName.Name = "txtbxPersonFirstName";
            this.txtbxPersonFirstName.Size = new System.Drawing.Size(140, 26);
            this.txtbxPersonFirstName.TabIndex = 20;
            // 
            // lblPersonFirstName
            // 
            this.lblPersonFirstName.AutoSize = true;
            this.lblPersonFirstName.Location = new System.Drawing.Point(39, 28);
            this.lblPersonFirstName.Name = "lblPersonFirstName";
            this.lblPersonFirstName.Size = new System.Drawing.Size(94, 20);
            this.lblPersonFirstName.TabIndex = 19;
            this.lblPersonFirstName.Text = "First Name: ";
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::View.Properties.Resources.Untitled_Artwork1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 571);
            this.Controls.Add(this.grpbxPeople);
            this.Controls.Add(this.grpbxProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagementForm";
            this.Text = "Management";
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
        private System.Windows.Forms.Label lblShowProductCode;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblShowPersonAge;
        private System.Windows.Forms.Label lblPersonAge;
    }
}