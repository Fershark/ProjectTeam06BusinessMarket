namespace ProjectTeam06BusinessMarketplaceForms
{
    partial class ProjectTeam06BusinessMarketplaceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageAdmin = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelProductsSold = new System.Windows.Forms.Label();
            this.labelOrdersSold = new System.Windows.Forms.Label();
            this.buttonBackupDatabase = new System.Windows.Forms.Button();
            this.buttonDeleteAndSeedDatabase = new System.Windows.Forms.Button();
            this.buttonAddUpdateBusinesses = new System.Windows.Forms.Button();
            this.dataGridViewBackupDatabases = new System.Windows.Forms.DataGridView();
            this.labelBackupDatabase = new System.Windows.Forms.Label();
            this.buttonAddUpdateCategories = new System.Windows.Forms.Button();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.labelCategories = new System.Windows.Forms.Label();
            this.dataGridViewBussinessName = new System.Windows.Forms.DataGridView();
            this.labelBusinesses = new System.Windows.Forms.Label();
            this.tabPageBusiness = new System.Windows.Forms.TabPage();
            this.buttonPurchase = new System.Windows.Forms.Button();
            this.buttonAddUpdateProduct = new System.Windows.Forms.Button();
            this.dataGridViewPastOrder = new System.Windows.Forms.DataGridView();
            this.labelPastOrder = new System.Windows.Forms.Label();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.labelOrder = new System.Windows.Forms.Label();
            this.dataGridViewOtherProduct = new System.Windows.Forms.DataGridView();
            this.labelOtherProduct = new System.Windows.Forms.Label();
            this.dataGridViewBusinessProduct = new System.Windows.Forms.DataGridView();
            this.labelBusinessProduct = new System.Windows.Forms.Label();
            this.buttonRestoreDatabase = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBackupDatabases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBussinessName)).BeginInit();
            this.tabPageBusiness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPastOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOtherProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusinessProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageAdmin);
            this.tabControl.Controls.Add(this.tabPageBusiness);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(868, 728);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageAdmin
            // 
            this.tabPageAdmin.Controls.Add(this.buttonRestoreDatabase);
            this.tabPageAdmin.Controls.Add(this.dataGridView1);
            this.tabPageAdmin.Controls.Add(this.labelProductsSold);
            this.tabPageAdmin.Controls.Add(this.labelOrdersSold);
            this.tabPageAdmin.Controls.Add(this.buttonBackupDatabase);
            this.tabPageAdmin.Controls.Add(this.buttonDeleteAndSeedDatabase);
            this.tabPageAdmin.Controls.Add(this.buttonAddUpdateBusinesses);
            this.tabPageAdmin.Controls.Add(this.dataGridViewBackupDatabases);
            this.tabPageAdmin.Controls.Add(this.labelBackupDatabase);
            this.tabPageAdmin.Controls.Add(this.buttonAddUpdateCategories);
            this.tabPageAdmin.Controls.Add(this.dataGridViewCategories);
            this.tabPageAdmin.Controls.Add(this.labelCategories);
            this.tabPageAdmin.Controls.Add(this.dataGridViewBussinessName);
            this.tabPageAdmin.Controls.Add(this.labelBusinesses);
            this.tabPageAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAdmin.Location = new System.Drawing.Point(4, 29);
            this.tabPageAdmin.Name = "tabPageAdmin";
            this.tabPageAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdmin.Size = new System.Drawing.Size(860, 695);
            this.tabPageAdmin.TabIndex = 0;
            this.tabPageAdmin.Text = "Admin";
            this.tabPageAdmin.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Location = new System.Drawing.Point(533, 274);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.Size = new System.Drawing.Size(262, 138);
            this.dataGridView1.TabIndex = 12;
            // 
            // labelProductsSold
            // 
            this.labelProductsSold.AutoSize = true;
            this.labelProductsSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductsSold.Location = new System.Drawing.Point(529, 251);
            this.labelProductsSold.Name = "labelProductsSold";
            this.labelProductsSold.Size = new System.Drawing.Size(121, 20);
            this.labelProductsSold.TabIndex = 11;
            this.labelProductsSold.Text = "Products Sold";
            // 
            // labelOrdersSold
            // 
            this.labelOrdersSold.AutoSize = true;
            this.labelOrdersSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdersSold.Location = new System.Drawing.Point(26, 251);
            this.labelOrdersSold.Name = "labelOrdersSold";
            this.labelOrdersSold.Size = new System.Drawing.Size(101, 20);
            this.labelOrdersSold.TabIndex = 10;
            this.labelOrdersSold.Text = "Orders sold";
            // 
            // buttonBackupDatabase
            // 
            this.buttonBackupDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackupDatabase.Location = new System.Drawing.Point(582, 616);
            this.buttonBackupDatabase.Name = "buttonBackupDatabase";
            this.buttonBackupDatabase.Size = new System.Drawing.Size(126, 51);
            this.buttonBackupDatabase.TabIndex = 9;
            this.buttonBackupDatabase.Text = "Backup database";
            this.buttonBackupDatabase.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteAndSeedDatabase
            // 
            this.buttonDeleteAndSeedDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteAndSeedDatabase.Location = new System.Drawing.Point(435, 616);
            this.buttonDeleteAndSeedDatabase.Name = "buttonDeleteAndSeedDatabase";
            this.buttonDeleteAndSeedDatabase.Size = new System.Drawing.Size(126, 51);
            this.buttonDeleteAndSeedDatabase.TabIndex = 8;
            this.buttonDeleteAndSeedDatabase.Text = "Delete and seed database";
            this.buttonDeleteAndSeedDatabase.UseVisualStyleBackColor = true;
            // 
            // buttonAddUpdateBusinesses
            // 
            this.buttonAddUpdateBusinesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUpdateBusinesses.Location = new System.Drawing.Point(309, 172);
            this.buttonAddUpdateBusinesses.Name = "buttonAddUpdateBusinesses";
            this.buttonAddUpdateBusinesses.Size = new System.Drawing.Size(234, 33);
            this.buttonAddUpdateBusinesses.TabIndex = 7;
            this.buttonAddUpdateBusinesses.Text = "Add/Update Businesses";
            this.buttonAddUpdateBusinesses.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBackupDatabases
            // 
            this.dataGridViewBackupDatabases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBackupDatabases.Location = new System.Drawing.Point(30, 274);
            this.dataGridViewBackupDatabases.Name = "dataGridViewBackupDatabases";
            this.dataGridViewBackupDatabases.Size = new System.Drawing.Size(447, 138);
            this.dataGridViewBackupDatabases.TabIndex = 6;
            // 
            // labelBackupDatabase
            // 
            this.labelBackupDatabase.AutoSize = true;
            this.labelBackupDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBackupDatabase.Location = new System.Drawing.Point(577, 574);
            this.labelBackupDatabase.Name = "labelBackupDatabase";
            this.labelBackupDatabase.Size = new System.Drawing.Size(131, 20);
            this.labelBackupDatabase.TabIndex = 5;
            this.labelBackupDatabase.Text = "Database tools";
            // 
            // buttonAddUpdateCategories
            // 
            this.buttonAddUpdateCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUpdateCategories.Location = new System.Drawing.Point(119, 616);
            this.buttonAddUpdateCategories.Name = "buttonAddUpdateCategories";
            this.buttonAddUpdateCategories.Size = new System.Drawing.Size(115, 51);
            this.buttonAddUpdateCategories.TabIndex = 4;
            this.buttonAddUpdateCategories.Text = "Add/Update Categories";
            this.buttonAddUpdateCategories.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Location = new System.Drawing.Point(30, 484);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.Size = new System.Drawing.Size(293, 126);
            this.dataGridViewCategories.TabIndex = 3;
            // 
            // labelCategories
            // 
            this.labelCategories.AutoSize = true;
            this.labelCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategories.Location = new System.Drawing.Point(126, 461);
            this.labelCategories.Name = "labelCategories";
            this.labelCategories.Size = new System.Drawing.Size(96, 20);
            this.labelCategories.TabIndex = 2;
            this.labelCategories.Text = "Categories";
            // 
            // dataGridViewBussinessName
            // 
            this.dataGridViewBussinessName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBussinessName.Location = new System.Drawing.Point(29, 38);
            this.dataGridViewBussinessName.Name = "dataGridViewBussinessName";
            this.dataGridViewBussinessName.Size = new System.Drawing.Size(807, 128);
            this.dataGridViewBussinessName.TabIndex = 1;
            // 
            // labelBusinesses
            // 
            this.labelBusinesses.AutoSize = true;
            this.labelBusinesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusinesses.Location = new System.Drawing.Point(26, 13);
            this.labelBusinesses.Name = "labelBusinesses";
            this.labelBusinesses.Size = new System.Drawing.Size(101, 20);
            this.labelBusinesses.TabIndex = 0;
            this.labelBusinesses.Text = "Businesses";
            // 
            // tabPageBusiness
            // 
            this.tabPageBusiness.Controls.Add(this.buttonPurchase);
            this.tabPageBusiness.Controls.Add(this.buttonAddUpdateProduct);
            this.tabPageBusiness.Controls.Add(this.dataGridViewPastOrder);
            this.tabPageBusiness.Controls.Add(this.labelPastOrder);
            this.tabPageBusiness.Controls.Add(this.dataGridViewOrder);
            this.tabPageBusiness.Controls.Add(this.labelOrder);
            this.tabPageBusiness.Controls.Add(this.dataGridViewOtherProduct);
            this.tabPageBusiness.Controls.Add(this.labelOtherProduct);
            this.tabPageBusiness.Controls.Add(this.dataGridViewBusinessProduct);
            this.tabPageBusiness.Controls.Add(this.labelBusinessProduct);
            this.tabPageBusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageBusiness.Location = new System.Drawing.Point(4, 29);
            this.tabPageBusiness.Name = "tabPageBusiness";
            this.tabPageBusiness.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBusiness.Size = new System.Drawing.Size(860, 695);
            this.tabPageBusiness.TabIndex = 1;
            this.tabPageBusiness.Text = "Business";
            this.tabPageBusiness.UseVisualStyleBackColor = true;
            // 
            // buttonPurchase
            // 
            this.buttonPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPurchase.Location = new System.Drawing.Point(331, 377);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(167, 31);
            this.buttonPurchase.TabIndex = 9;
            this.buttonPurchase.Text = "Purchase";
            this.buttonPurchase.UseVisualStyleBackColor = true;
            // 
            // buttonAddUpdateProduct
            // 
            this.buttonAddUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUpdateProduct.Location = new System.Drawing.Point(322, 185);
            this.buttonAddUpdateProduct.Name = "buttonAddUpdateProduct";
            this.buttonAddUpdateProduct.Size = new System.Drawing.Size(199, 31);
            this.buttonAddUpdateProduct.TabIndex = 8;
            this.buttonAddUpdateProduct.Text = "Add/Update Product";
            this.buttonAddUpdateProduct.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPastOrder
            // 
            this.dataGridViewPastOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPastOrder.Location = new System.Drawing.Point(472, 470);
            this.dataGridViewPastOrder.Name = "dataGridViewPastOrder";
            this.dataGridViewPastOrder.Size = new System.Drawing.Size(371, 124);
            this.dataGridViewPastOrder.TabIndex = 7;
            // 
            // labelPastOrder
            // 
            this.labelPastOrder.AutoSize = true;
            this.labelPastOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPastOrder.Location = new System.Drawing.Point(468, 426);
            this.labelPastOrder.Name = "labelPastOrder";
            this.labelPastOrder.Size = new System.Drawing.Size(95, 20);
            this.labelPastOrder.TabIndex = 6;
            this.labelPastOrder.Text = "Past Order";
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(23, 470);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.Size = new System.Drawing.Size(372, 124);
            this.dataGridViewOrder.TabIndex = 5;
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrder.Location = new System.Drawing.Point(23, 426);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(54, 20);
            this.labelOrder.TabIndex = 4;
            this.labelOrder.Text = "Order";
            // 
            // dataGridViewOtherProduct
            // 
            this.dataGridViewOtherProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOtherProduct.Location = new System.Drawing.Point(27, 249);
            this.dataGridViewOtherProduct.Name = "dataGridViewOtherProduct";
            this.dataGridViewOtherProduct.Size = new System.Drawing.Size(802, 122);
            this.dataGridViewOtherProduct.TabIndex = 3;
            // 
            // labelOtherProduct
            // 
            this.labelOtherProduct.AutoSize = true;
            this.labelOtherProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOtherProduct.Location = new System.Drawing.Point(23, 216);
            this.labelOtherProduct.Name = "labelOtherProduct";
            this.labelOtherProduct.Size = new System.Drawing.Size(71, 20);
            this.labelOtherProduct.TabIndex = 2;
            this.labelOtherProduct.Text = "Product";
            // 
            // dataGridViewBusinessProduct
            // 
            this.dataGridViewBusinessProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBusinessProduct.Location = new System.Drawing.Point(23, 54);
            this.dataGridViewBusinessProduct.Name = "dataGridViewBusinessProduct";
            this.dataGridViewBusinessProduct.Size = new System.Drawing.Size(805, 125);
            this.dataGridViewBusinessProduct.TabIndex = 1;
            // 
            // labelBusinessProduct
            // 
            this.labelBusinessProduct.AutoSize = true;
            this.labelBusinessProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusinessProduct.Location = new System.Drawing.Point(20, 25);
            this.labelBusinessProduct.Name = "labelBusinessProduct";
            this.labelBusinessProduct.Size = new System.Drawing.Size(149, 20);
            this.labelBusinessProduct.TabIndex = 0;
            this.labelBusinessProduct.Text = "Business Product";
            // 
            // buttonRestoreDatabase
            // 
            this.buttonRestoreDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestoreDatabase.Location = new System.Drawing.Point(728, 616);
            this.buttonRestoreDatabase.Name = "buttonRestoreDatabase";
            this.buttonRestoreDatabase.Size = new System.Drawing.Size(126, 51);
            this.buttonRestoreDatabase.TabIndex = 13;
            this.buttonRestoreDatabase.Text = "Restore database";
            this.buttonRestoreDatabase.UseVisualStyleBackColor = true;
            // 
            // ProjectTeam06BusinessMarketplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 752);
            this.Controls.Add(this.tabControl);
            this.Name = "ProjectTeam06BusinessMarketplaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Business Marketplace";
            this.tabControl.ResumeLayout(false);
            this.tabPageAdmin.ResumeLayout(false);
            this.tabPageAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBackupDatabases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBussinessName)).EndInit();
            this.tabPageBusiness.ResumeLayout(false);
            this.tabPageBusiness.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPastOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOtherProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusinessProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAdmin;
        private System.Windows.Forms.TabPage tabPageBusiness;
        private System.Windows.Forms.Label labelBusinesses;
        private System.Windows.Forms.DataGridView dataGridViewBussinessName;
        private System.Windows.Forms.Label labelCategories;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.Label labelBusinessProduct;
        private System.Windows.Forms.Label labelOtherProduct;
        private System.Windows.Forms.DataGridView dataGridViewBusinessProduct;
        private System.Windows.Forms.Button buttonAddUpdateCategories;
        private System.Windows.Forms.DataGridView dataGridViewOtherProduct;
        private System.Windows.Forms.Label labelBackupDatabase;
        private System.Windows.Forms.DataGridView dataGridViewBackupDatabases;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.DataGridView dataGridViewPastOrder;
        private System.Windows.Forms.Label labelPastOrder;
        private System.Windows.Forms.Button buttonAddUpdateProduct;
        private System.Windows.Forms.Button buttonPurchase;
        private System.Windows.Forms.Button buttonBackupDatabase;
        private System.Windows.Forms.Button buttonDeleteAndSeedDatabase;
        private System.Windows.Forms.Button buttonAddUpdateBusinesses;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelProductsSold;
        private System.Windows.Forms.Label labelOrdersSold;
        private System.Windows.Forms.Button buttonRestoreDatabase;
    }
}

