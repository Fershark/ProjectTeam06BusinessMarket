namespace ProjectTeam06BusinessMarketplaceForms
{
    partial class ShopForm
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
            this.groupBoxShop = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelOtherProduct = new System.Windows.Forms.Label();
            this.dataGridViewOtherProduct = new System.Windows.Forms.DataGridView();
            this.labelOrder = new System.Windows.Forms.Label();
            this.buttonAddToOrder = new System.Windows.Forms.Button();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.groupBoxShop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOtherProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxShop
            // 
            this.groupBoxShop.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxShop.Controls.Add(this.label1);
            this.groupBoxShop.Controls.Add(this.labelTotal);
            this.groupBoxShop.Controls.Add(this.labelOtherProduct);
            this.groupBoxShop.Controls.Add(this.dataGridViewOtherProduct);
            this.groupBoxShop.Controls.Add(this.labelOrder);
            this.groupBoxShop.Controls.Add(this.buttonAddToOrder);
            this.groupBoxShop.Controls.Add(this.dataGridViewOrder);
            this.groupBoxShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxShop.Location = new System.Drawing.Point(11, 12);
            this.groupBoxShop.Name = "groupBoxShop";
            this.groupBoxShop.Size = new System.Drawing.Size(810, 417);
            this.groupBoxShop.TabIndex = 19;
            this.groupBoxShop.TabStop = false;
            this.groupBoxShop.Text = "Shop";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(748, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(630, 335);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(49, 20);
            this.labelTotal.TabIndex = 10;
            this.labelTotal.Text = "Total";
            // 
            // labelOtherProduct
            // 
            this.labelOtherProduct.AutoSize = true;
            this.labelOtherProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOtherProduct.Location = new System.Drawing.Point(6, 29);
            this.labelOtherProduct.Name = "labelOtherProduct";
            this.labelOtherProduct.Size = new System.Drawing.Size(69, 16);
            this.labelOtherProduct.TabIndex = 2;
            this.labelOtherProduct.Text = "Products";
            // 
            // dataGridViewOtherProduct
            // 
            this.dataGridViewOtherProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOtherProduct.Location = new System.Drawing.Point(9, 48);
            this.dataGridViewOtherProduct.Name = "dataGridViewOtherProduct";
            this.dataGridViewOtherProduct.Size = new System.Drawing.Size(790, 122);
            this.dataGridViewOtherProduct.TabIndex = 3;
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrder.Location = new System.Drawing.Point(6, 207);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(47, 16);
            this.labelOrder.TabIndex = 4;
            this.labelOrder.Text = "Order";
            // 
            // buttonAddToOrder
            // 
            this.buttonAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToOrder.Location = new System.Drawing.Point(311, 176);
            this.buttonAddToOrder.Name = "buttonAddToOrder";
            this.buttonAddToOrder.Size = new System.Drawing.Size(167, 31);
            this.buttonAddToOrder.TabIndex = 9;
            this.buttonAddToOrder.Text = "Add to order";
            this.buttonAddToOrder.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(9, 226);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.Size = new System.Drawing.Size(790, 102);
            this.dataGridViewOrder.TabIndex = 5;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 454);
            this.Controls.Add(this.groupBoxShop);
            this.Name = "ShopForm";
            this.Text = "ShopForm";
            this.groupBoxShop.ResumeLayout(false);
            this.groupBoxShop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOtherProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxShop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelOtherProduct;
        private System.Windows.Forms.DataGridView dataGridViewOtherProduct;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Button buttonAddToOrder;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
    }
}