﻿namespace ProjectTeam06BusinessMarketplaceForms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageAdmin = new System.Windows.Forms.TabPage();
            this.buttonSalesAdmin = new System.Windows.Forms.Button();
            this.groupBoxCategories = new System.Windows.Forms.GroupBox();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.buttonAddUpdateCategories = new System.Windows.Forms.Button();
            this.groupBoxDatabaseTools = new System.Windows.Forms.GroupBox();
            this.buttonBackupDatabase = new System.Windows.Forms.Button();
            this.buttonDeleteAndSeedDatabase = new System.Windows.Forms.Button();
            this.buttonRestoreDatabase = new System.Windows.Forms.Button();
            this.groupBoxBusinesses = new System.Windows.Forms.GroupBox();
            this.dataGridViewBussinessName = new System.Windows.Forms.DataGridView();
            this.buttonAddUpdateBusinesses = new System.Windows.Forms.Button();
            this.tabPageBusiness = new System.Windows.Forms.TabPage();
            this.groupBoxBusinessData = new System.Windows.Forms.GroupBox();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonShop = new System.Windows.Forms.Button();
            this.labelBusinessAddress = new System.Windows.Forms.Label();
            this.labelBusinessAddressData = new System.Windows.Forms.Label();
            this.labelBusinessEmail = new System.Windows.Forms.Label();
            this.labelBusinessEmailData = new System.Windows.Forms.Label();
            this.labelBusinessProduct = new System.Windows.Forms.Label();
            this.buttonAddUpdateProduct = new System.Windows.Forms.Button();
            this.dataGridViewBusinessProduct = new System.Windows.Forms.DataGridView();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.labelBusinessSelected = new System.Windows.Forms.Label();
            this.comboBoxBusinessSelected = new System.Windows.Forms.ComboBox();
            this.buttonBusinessSales = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageAdmin.SuspendLayout();
            this.groupBoxCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            this.groupBoxDatabaseTools.SuspendLayout();
            this.groupBoxBusinesses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBussinessName)).BeginInit();
            this.tabPageBusiness.SuspendLayout();
            this.groupBoxBusinessData.SuspendLayout();
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
            this.tabControl.Size = new System.Drawing.Size(855, 605);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageAdmin
            // 
            this.tabPageAdmin.Controls.Add(this.buttonSalesAdmin);
            this.tabPageAdmin.Controls.Add(this.groupBoxCategories);
            this.tabPageAdmin.Controls.Add(this.groupBoxDatabaseTools);
            this.tabPageAdmin.Controls.Add(this.groupBoxBusinesses);
            this.tabPageAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAdmin.Location = new System.Drawing.Point(4, 29);
            this.tabPageAdmin.Name = "tabPageAdmin";
            this.tabPageAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdmin.Size = new System.Drawing.Size(847, 564);
            this.tabPageAdmin.TabIndex = 0;
            this.tabPageAdmin.Text = "Admin";
            this.tabPageAdmin.UseVisualStyleBackColor = true;
            // 
            // buttonSalesAdmin
            // 
            this.buttonSalesAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalesAdmin.Location = new System.Drawing.Point(538, 466);
            this.buttonSalesAdmin.Name = "buttonSalesAdmin";
            this.buttonSalesAdmin.Size = new System.Drawing.Size(126, 33);
            this.buttonSalesAdmin.TabIndex = 17;
            this.buttonSalesAdmin.Text = "Sales";
            this.buttonSalesAdmin.UseVisualStyleBackColor = true;
            // 
            // groupBoxCategories
            // 
            this.groupBoxCategories.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxCategories.Controls.Add(this.dataGridViewCategories);
            this.groupBoxCategories.Controls.Add(this.buttonAddUpdateCategories);
            this.groupBoxCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCategories.Location = new System.Drawing.Point(20, 329);
            this.groupBoxCategories.Name = "groupBoxCategories";
            this.groupBoxCategories.Size = new System.Drawing.Size(345, 215);
            this.groupBoxCategories.TabIndex = 16;
            this.groupBoxCategories.TabStop = false;
            this.groupBoxCategories.Text = "Categories";
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Location = new System.Drawing.Point(9, 25);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dataGridViewCategories.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCategories.Size = new System.Drawing.Size(330, 145);
            this.dataGridViewCategories.TabIndex = 3;
            // 
            // buttonAddUpdateCategories
            // 
            this.buttonAddUpdateCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUpdateCategories.Location = new System.Drawing.Point(92, 176);
            this.buttonAddUpdateCategories.Name = "buttonAddUpdateCategories";
            this.buttonAddUpdateCategories.Size = new System.Drawing.Size(166, 33);
            this.buttonAddUpdateCategories.TabIndex = 4;
            this.buttonAddUpdateCategories.Text = "Add/Update Categories";
            this.buttonAddUpdateCategories.UseVisualStyleBackColor = true;
            // 
            // groupBoxDatabaseTools
            // 
            this.groupBoxDatabaseTools.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxDatabaseTools.Controls.Add(this.buttonBackupDatabase);
            this.groupBoxDatabaseTools.Controls.Add(this.buttonDeleteAndSeedDatabase);
            this.groupBoxDatabaseTools.Controls.Add(this.buttonRestoreDatabase);
            this.groupBoxDatabaseTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatabaseTools.Location = new System.Drawing.Point(371, 329);
            this.groupBoxDatabaseTools.Name = "groupBoxDatabaseTools";
            this.groupBoxDatabaseTools.Size = new System.Drawing.Size(459, 86);
            this.groupBoxDatabaseTools.TabIndex = 15;
            this.groupBoxDatabaseTools.TabStop = false;
            this.groupBoxDatabaseTools.Text = "Database tools";
            // 
            // buttonBackupDatabase
            // 
            this.buttonBackupDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackupDatabase.Location = new System.Drawing.Point(167, 25);
            this.buttonBackupDatabase.Name = "buttonBackupDatabase";
            this.buttonBackupDatabase.Size = new System.Drawing.Size(126, 51);
            this.buttonBackupDatabase.TabIndex = 9;
            this.buttonBackupDatabase.Text = "Backup database";
            this.buttonBackupDatabase.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteAndSeedDatabase
            // 
            this.buttonDeleteAndSeedDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteAndSeedDatabase.Location = new System.Drawing.Point(20, 25);
            this.buttonDeleteAndSeedDatabase.Name = "buttonDeleteAndSeedDatabase";
            this.buttonDeleteAndSeedDatabase.Size = new System.Drawing.Size(126, 51);
            this.buttonDeleteAndSeedDatabase.TabIndex = 8;
            this.buttonDeleteAndSeedDatabase.Text = "Delete and seed database";
            this.buttonDeleteAndSeedDatabase.UseVisualStyleBackColor = true;
            // 
            // buttonRestoreDatabase
            // 
            this.buttonRestoreDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestoreDatabase.Location = new System.Drawing.Point(313, 25);
            this.buttonRestoreDatabase.Name = "buttonRestoreDatabase";
            this.buttonRestoreDatabase.Size = new System.Drawing.Size(126, 51);
            this.buttonRestoreDatabase.TabIndex = 13;
            this.buttonRestoreDatabase.Text = "Restore database";
            this.buttonRestoreDatabase.UseVisualStyleBackColor = true;
            // 
            // groupBoxBusinesses
            // 
            this.groupBoxBusinesses.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxBusinesses.Controls.Add(this.dataGridViewBussinessName);
            this.groupBoxBusinesses.Controls.Add(this.buttonAddUpdateBusinesses);
            this.groupBoxBusinesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBusinesses.Location = new System.Drawing.Point(20, 18);
            this.groupBoxBusinesses.Name = "groupBoxBusinesses";
            this.groupBoxBusinesses.Size = new System.Drawing.Size(810, 305);
            this.groupBoxBusinesses.TabIndex = 14;
            this.groupBoxBusinesses.TabStop = false;
            this.groupBoxBusinesses.Text = "Businesses";
            // 
            // dataGridViewBussinessName
            // 
            this.dataGridViewBussinessName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBussinessName.Location = new System.Drawing.Point(9, 25);
            this.dataGridViewBussinessName.Name = "dataGridViewBussinessName";
            this.dataGridViewBussinessName.Size = new System.Drawing.Size(795, 235);
            this.dataGridViewBussinessName.TabIndex = 1;
            // 
            // buttonAddUpdateBusinesses
            // 
            this.buttonAddUpdateBusinesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUpdateBusinesses.Location = new System.Drawing.Point(298, 266);
            this.buttonAddUpdateBusinesses.Name = "buttonAddUpdateBusinesses";
            this.buttonAddUpdateBusinesses.Size = new System.Drawing.Size(221, 33);
            this.buttonAddUpdateBusinesses.TabIndex = 7;
            this.buttonAddUpdateBusinesses.Text = "Add/Update Businesses";
            this.buttonAddUpdateBusinesses.UseVisualStyleBackColor = true;
            // 
            // tabPageBusiness
            // 
            this.tabPageBusiness.Controls.Add(this.groupBoxBusinessData);
            this.tabPageBusiness.Controls.Add(this.labelInstructions);
            this.tabPageBusiness.Controls.Add(this.labelBusinessSelected);
            this.tabPageBusiness.Controls.Add(this.comboBoxBusinessSelected);
            this.tabPageBusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageBusiness.Location = new System.Drawing.Point(4, 29);
            this.tabPageBusiness.Name = "tabPageBusiness";
            this.tabPageBusiness.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBusiness.Size = new System.Drawing.Size(847, 572);
            this.tabPageBusiness.TabIndex = 1;
            this.tabPageBusiness.Text = "Business";
            this.tabPageBusiness.UseVisualStyleBackColor = true;
            // 
            // groupBoxBusinessData
            // 
            this.groupBoxBusinessData.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxBusinessData.Controls.Add(this.buttonBusinessSales);
            this.groupBoxBusinessData.Controls.Add(this.buttonOrders);
            this.groupBoxBusinessData.Controls.Add(this.buttonShop);
            this.groupBoxBusinessData.Controls.Add(this.labelBusinessAddress);
            this.groupBoxBusinessData.Controls.Add(this.labelBusinessAddressData);
            this.groupBoxBusinessData.Controls.Add(this.labelBusinessEmail);
            this.groupBoxBusinessData.Controls.Add(this.labelBusinessEmailData);
            this.groupBoxBusinessData.Controls.Add(this.labelBusinessProduct);
            this.groupBoxBusinessData.Controls.Add(this.buttonAddUpdateProduct);
            this.groupBoxBusinessData.Controls.Add(this.dataGridViewBusinessProduct);
            this.groupBoxBusinessData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBusinessData.Location = new System.Drawing.Point(18, 53);
            this.groupBoxBusinessData.Name = "groupBoxBusinessData";
            this.groupBoxBusinessData.Size = new System.Drawing.Size(810, 507);
            this.groupBoxBusinessData.TabIndex = 17;
            this.groupBoxBusinessData.TabStop = false;
            this.groupBoxBusinessData.Text = "BusinessName";
            // 
            // buttonOrders
            // 
            this.buttonOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrders.Location = new System.Drawing.Point(341, 459);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(130, 31);
            this.buttonOrders.TabIndex = 20;
            this.buttonOrders.Text = "Orders";
            this.buttonOrders.UseVisualStyleBackColor = true;
            // 
            // buttonShop
            // 
            this.buttonShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShop.Location = new System.Drawing.Point(491, 459);
            this.buttonShop.Name = "buttonShop";
            this.buttonShop.Size = new System.Drawing.Size(130, 31);
            this.buttonShop.TabIndex = 19;
            this.buttonShop.Text = "Shop";
            this.buttonShop.UseVisualStyleBackColor = true;
            // 
            // labelBusinessAddress
            // 
            this.labelBusinessAddress.AutoSize = true;
            this.labelBusinessAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusinessAddress.Location = new System.Drawing.Point(6, 55);
            this.labelBusinessAddress.Name = "labelBusinessAddress";
            this.labelBusinessAddress.Size = new System.Drawing.Size(66, 16);
            this.labelBusinessAddress.TabIndex = 17;
            this.labelBusinessAddress.Text = "Address";
            // 
            // labelBusinessAddressData
            // 
            this.labelBusinessAddressData.AutoSize = true;
            this.labelBusinessAddressData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusinessAddressData.Location = new System.Drawing.Point(83, 55);
            this.labelBusinessAddressData.Name = "labelBusinessAddressData";
            this.labelBusinessAddressData.Size = new System.Drawing.Size(0, 16);
            this.labelBusinessAddressData.TabIndex = 18;
            // 
            // labelBusinessEmail
            // 
            this.labelBusinessEmail.AutoSize = true;
            this.labelBusinessEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusinessEmail.Location = new System.Drawing.Point(6, 28);
            this.labelBusinessEmail.Name = "labelBusinessEmail";
            this.labelBusinessEmail.Size = new System.Drawing.Size(47, 16);
            this.labelBusinessEmail.TabIndex = 15;
            this.labelBusinessEmail.Text = "Email";
            // 
            // labelBusinessEmailData
            // 
            this.labelBusinessEmailData.AutoSize = true;
            this.labelBusinessEmailData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusinessEmailData.Location = new System.Drawing.Point(83, 28);
            this.labelBusinessEmailData.Name = "labelBusinessEmailData";
            this.labelBusinessEmailData.Size = new System.Drawing.Size(0, 16);
            this.labelBusinessEmailData.TabIndex = 16;
            // 
            // labelBusinessProduct
            // 
            this.labelBusinessProduct.AutoSize = true;
            this.labelBusinessProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusinessProduct.Location = new System.Drawing.Point(6, 82);
            this.labelBusinessProduct.Name = "labelBusinessProduct";
            this.labelBusinessProduct.Size = new System.Drawing.Size(69, 16);
            this.labelBusinessProduct.TabIndex = 0;
            this.labelBusinessProduct.Text = "Products";
            // 
            // buttonAddUpdateProduct
            // 
            this.buttonAddUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUpdateProduct.Location = new System.Drawing.Point(307, 408);
            this.buttonAddUpdateProduct.Name = "buttonAddUpdateProduct";
            this.buttonAddUpdateProduct.Size = new System.Drawing.Size(199, 31);
            this.buttonAddUpdateProduct.TabIndex = 8;
            this.buttonAddUpdateProduct.Text = "Add/Update products";
            this.buttonAddUpdateProduct.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBusinessProduct
            // 
            this.dataGridViewBusinessProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBusinessProduct.Location = new System.Drawing.Point(9, 101);
            this.dataGridViewBusinessProduct.Name = "dataGridViewBusinessProduct";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewBusinessProduct.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBusinessProduct.Size = new System.Drawing.Size(793, 301);
            this.dataGridViewBusinessProduct.TabIndex = 1;
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Location = new System.Drawing.Point(282, 3);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(293, 13);
            this.labelInstructions.TabIndex = 12;
            this.labelInstructions.Text = "Choose a business to view the information from that business";
            // 
            // labelBusinessSelected
            // 
            this.labelBusinessSelected.AutoSize = true;
            this.labelBusinessSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusinessSelected.Location = new System.Drawing.Point(280, 27);
            this.labelBusinessSelected.Name = "labelBusinessSelected";
            this.labelBusinessSelected.Size = new System.Drawing.Size(137, 16);
            this.labelBusinessSelected.TabIndex = 11;
            this.labelBusinessSelected.Text = "Business Selected";
            // 
            // comboBoxBusinessSelected
            // 
            this.comboBoxBusinessSelected.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBoxBusinessSelected.FormattingEnabled = true;
            this.comboBoxBusinessSelected.Location = new System.Drawing.Point(423, 26);
            this.comboBoxBusinessSelected.Name = "comboBoxBusinessSelected";
            this.comboBoxBusinessSelected.Size = new System.Drawing.Size(152, 21);
            this.comboBoxBusinessSelected.TabIndex = 10;
            // 
            // buttonBusinessSales
            // 
            this.buttonBusinessSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBusinessSales.Location = new System.Drawing.Point(197, 458);
            this.buttonBusinessSales.Name = "buttonBusinessSales";
            this.buttonBusinessSales.Size = new System.Drawing.Size(126, 33);
            this.buttonBusinessSales.TabIndex = 21;
            this.buttonBusinessSales.Text = "Sales";
            this.buttonBusinessSales.UseVisualStyleBackColor = true;
            // 
            // ProjectTeam06BusinessMarketplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 629);
            this.Controls.Add(this.tabControl);
            this.Name = "ProjectTeam06BusinessMarketplaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Business Marketplace";
            this.tabControl.ResumeLayout(false);
            this.tabPageAdmin.ResumeLayout(false);
            this.groupBoxCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            this.groupBoxDatabaseTools.ResumeLayout(false);
            this.groupBoxBusinesses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBussinessName)).EndInit();
            this.tabPageBusiness.ResumeLayout(false);
            this.tabPageBusiness.PerformLayout();
            this.groupBoxBusinessData.ResumeLayout(false);
            this.groupBoxBusinessData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusinessProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAdmin;
        private System.Windows.Forms.TabPage tabPageBusiness;
        private System.Windows.Forms.DataGridView dataGridViewBussinessName;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.Label labelBusinessProduct;
        private System.Windows.Forms.DataGridView dataGridViewBusinessProduct;
        private System.Windows.Forms.Button buttonAddUpdateCategories;
        private System.Windows.Forms.Button buttonAddUpdateProduct;
        private System.Windows.Forms.Button buttonBackupDatabase;
        private System.Windows.Forms.Button buttonDeleteAndSeedDatabase;
        private System.Windows.Forms.Button buttonAddUpdateBusinesses;
        private System.Windows.Forms.Button buttonRestoreDatabase;
        private System.Windows.Forms.Label labelBusinessSelected;
        private System.Windows.Forms.ComboBox comboBoxBusinessSelected;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.GroupBox groupBoxBusinessData;
        private System.Windows.Forms.Label labelBusinessAddress;
        private System.Windows.Forms.Label labelBusinessAddressData;
        private System.Windows.Forms.Label labelBusinessEmail;
        private System.Windows.Forms.Label labelBusinessEmailData;
        private System.Windows.Forms.GroupBox groupBoxBusinesses;
        private System.Windows.Forms.GroupBox groupBoxCategories;
        private System.Windows.Forms.GroupBox groupBoxDatabaseTools;
        private System.Windows.Forms.Button buttonSalesAdmin;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonShop;
        private System.Windows.Forms.Button buttonBusinessSales;
    }
}

