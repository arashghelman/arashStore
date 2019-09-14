namespace View
{
    partial class StoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.productViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPurchase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(173, 39);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowTemplate.Height = 60;
            this.dgvProducts.Size = new System.Drawing.Size(432, 303);
            this.dgvProducts.TabIndex = 0;
            // 
            // productViewModelBindingSource
            // 
            this.productViewModelBindingSource.DataSource = typeof(ViewModel.ProductViewModel);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(350, 372);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(75, 23);
            this.btnPurchase.TabIndex = 1;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.BtnPurchase_Click);
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 430);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.dgvProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StoreForm";
            this.Text = "StoreForm";
            this.Load += new System.EventHandler(this.StoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.BindingSource productViewModelBindingSource;
        private System.Windows.Forms.Button btnPurchase;
    }
}