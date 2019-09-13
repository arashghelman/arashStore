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
            this.lblName = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.txtbxDiscount = new System.Windows.Forms.TextBox();
            this.txtbxUnitPrice = new System.Windows.Forms.TextBox();
            this.nmrcUpDwnQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnUpload = new System.Windows.Forms.Button();
            this.fileDialogUpload = new System.Windows.Forms.OpenFileDialog();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(72, 86);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name: ";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(32, 200);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(81, 13);
            this.lblImage.TabIndex = 1;
            this.lblImage.Text = "Product Photo: ";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(43, 119);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(43, 144);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(56, 13);
            this.lblUnitPrice.TabIndex = 3;
            this.lblUnitPrice.Text = "Unit Price:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(43, 169);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(55, 13);
            this.lblDiscount.TabIndex = 4;
            this.lblDiscount.Text = "Discount: ";
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(119, 83);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(100, 20);
            this.txtbxName.TabIndex = 5;
            // 
            // txtbxDiscount
            // 
            this.txtbxDiscount.Location = new System.Drawing.Point(119, 166);
            this.txtbxDiscount.Name = "txtbxDiscount";
            this.txtbxDiscount.Size = new System.Drawing.Size(100, 20);
            this.txtbxDiscount.TabIndex = 8;
            // 
            // txtbxUnitPrice
            // 
            this.txtbxUnitPrice.Location = new System.Drawing.Point(119, 141);
            this.txtbxUnitPrice.Name = "txtbxUnitPrice";
            this.txtbxUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtbxUnitPrice.TabIndex = 9;
            // 
            // nmrcUpDwnQuantity
            // 
            this.nmrcUpDwnQuantity.Location = new System.Drawing.Point(119, 112);
            this.nmrcUpDwnQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrcUpDwnQuantity.Name = "nmrcUpDwnQuantity";
            this.nmrcUpDwnQuantity.Size = new System.Drawing.Size(100, 20);
            this.nmrcUpDwnQuantity.TabIndex = 10;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(119, 192);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(100, 23);
            this.btnUpload.TabIndex = 11;
            this.btnUpload.Text = "Browse";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // fileDialogUpload
            // 
            this.fileDialogUpload.FileName = "openFileDialog1";
            this.fileDialogUpload.Filter = "\"JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*\"";
            this.fileDialogUpload.FilterIndex = 2;
            this.fileDialogUpload.InitialDirectory = "@\"C:\\\"";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(217, 333);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(116, 218);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(0, 13);
            this.lblFileName.TabIndex = 13;
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 418);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.nmrcUpDwnQuantity);
            this.Controls.Add(this.txtbxUnitPrice);
            this.Controls.Add(this.txtbxDiscount);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblName);
            this.Name = "ManagementForm";
            this.Text = "ManagementForm";
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.TextBox txtbxDiscount;
        private System.Windows.Forms.TextBox txtbxUnitPrice;
        private System.Windows.Forms.NumericUpDown nmrcUpDwnQuantity;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog fileDialogUpload;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblFileName;
    }
}