namespace ProjectTeam06BusinessMarketplaceForms
{
    partial class Shop
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
            this.buttonRemovefromOrder = new System.Windows.Forms.Button();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.labelTotalData = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelOtherProduct = new System.Windows.Forms.Label();
            this.dataGridViewOtherProducts = new System.Windows.Forms.DataGridView();
            this.labelOrder = new System.Windows.Forms.Label();
            this.buttonAddToOrder = new System.Windows.Forms.Button();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.groupBoxShop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOtherProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxShop
            // 
            this.groupBoxShop.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxShop.Controls.Add(this.buttonRemovefromOrder);
            this.groupBoxShop.Controls.Add(this.buttonCheckout);
            this.groupBoxShop.Controls.Add(this.labelTotalData);
            this.groupBoxShop.Controls.Add(this.labelTotal);
            this.groupBoxShop.Controls.Add(this.labelOtherProduct);
            this.groupBoxShop.Controls.Add(this.dataGridViewOtherProducts);
            this.groupBoxShop.Controls.Add(this.labelOrder);
            this.groupBoxShop.Controls.Add(this.buttonAddToOrder);
            this.groupBoxShop.Controls.Add(this.dataGridViewOrder);
            this.groupBoxShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxShop.Location = new System.Drawing.Point(11, 12);
            this.groupBoxShop.Name = "groupBoxShop";
            this.groupBoxShop.Size = new System.Drawing.Size(810, 487);
            this.groupBoxShop.TabIndex = 19;
            this.groupBoxShop.TabStop = false;
            this.groupBoxShop.Text = "Shop";
            // 
            // buttonRemovefromOrder
            // 
            this.buttonRemovefromOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemovefromOrder.Location = new System.Drawing.Point(9, 413);
            this.buttonRemovefromOrder.Name = "buttonRemovefromOrder";
            this.buttonRemovefromOrder.Size = new System.Drawing.Size(167, 31);
            this.buttonRemovefromOrder.TabIndex = 22;
            this.buttonRemovefromOrder.Text = "Remove from order";
            this.buttonRemovefromOrder.UseVisualStyleBackColor = true;
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckout.Location = new System.Drawing.Point(669, 448);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(130, 31);
            this.buttonCheckout.TabIndex = 21;
            this.buttonCheckout.Text = "Checkout";
            this.buttonCheckout.UseVisualStyleBackColor = true;
            // 
            // labelTotalData
            // 
            this.labelTotalData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalData.Location = new System.Drawing.Point(699, 420);
            this.labelTotalData.Name = "labelTotalData";
            this.labelTotalData.Size = new System.Drawing.Size(100, 16);
            this.labelTotalData.TabIndex = 11;
            this.labelTotalData.Text = "0";
            this.labelTotalData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(632, 420);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(44, 16);
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
            // dataGridViewOtherProducts
            // 
            this.dataGridViewOtherProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOtherProducts.Location = new System.Drawing.Point(9, 48);
            this.dataGridViewOtherProducts.Name = "dataGridViewOtherProducts";
            this.dataGridViewOtherProducts.Size = new System.Drawing.Size(790, 167);
            this.dataGridViewOtherProducts.TabIndex = 3;
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrder.Location = new System.Drawing.Point(6, 266);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(47, 16);
            this.labelOrder.TabIndex = 4;
            this.labelOrder.Text = "Order";
            // 
            // buttonAddToOrder
            // 
            this.buttonAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToOrder.Location = new System.Drawing.Point(321, 221);
            this.buttonAddToOrder.Name = "buttonAddToOrder";
            this.buttonAddToOrder.Size = new System.Drawing.Size(167, 31);
            this.buttonAddToOrder.TabIndex = 9;
            this.buttonAddToOrder.Text = "Add to order";
            this.buttonAddToOrder.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(9, 285);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.Size = new System.Drawing.Size(790, 122);
            this.dataGridViewOrder.TabIndex = 5;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 509);
            this.Controls.Add(this.groupBoxShop);
            this.Name = "Shop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.groupBoxShop.ResumeLayout(false);
            this.groupBoxShop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOtherProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxShop;
        private System.Windows.Forms.Label labelTotalData;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelOtherProduct;
        private System.Windows.Forms.DataGridView dataGridViewOtherProducts;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Button buttonAddToOrder;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Button buttonCheckout;
        private System.Windows.Forms.Button buttonRemovefromOrder;
    }
}