namespace ProjectTeam06BusinessMarketplaceForms
{
    partial class Orders
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
            this.groupBoxOrders = new System.Windows.Forms.GroupBox();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.labelProductsCountData = new System.Windows.Forms.Label();
            this.labelProductsCount = new System.Windows.Forms.Label();
            this.labelOrdersCountData = new System.Windows.Forms.Label();
            this.labelOrdersCount = new System.Windows.Forms.Label();
            this.labelProductsInOrder = new System.Windows.Forms.Label();
            this.dataGridViewOrderProducts = new System.Windows.Forms.DataGridView();
            this.labelOrders = new System.Windows.Forms.Label();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.groupBoxOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOrders
            // 
            this.groupBoxOrders.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxOrders.Controls.Add(this.labelInstructions);
            this.groupBoxOrders.Controls.Add(this.labelProductsCountData);
            this.groupBoxOrders.Controls.Add(this.labelProductsCount);
            this.groupBoxOrders.Controls.Add(this.labelOrdersCountData);
            this.groupBoxOrders.Controls.Add(this.labelOrdersCount);
            this.groupBoxOrders.Controls.Add(this.labelProductsInOrder);
            this.groupBoxOrders.Controls.Add(this.dataGridViewOrderProducts);
            this.groupBoxOrders.Controls.Add(this.labelOrders);
            this.groupBoxOrders.Controls.Add(this.dataGridViewOrders);
            this.groupBoxOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOrders.Location = new System.Drawing.Point(12, 12);
            this.groupBoxOrders.Name = "groupBoxOrders";
            this.groupBoxOrders.Size = new System.Drawing.Size(819, 510);
            this.groupBoxOrders.TabIndex = 20;
            this.groupBoxOrders.TabStop = false;
            this.groupBoxOrders.Text = "Orders";
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructions.Location = new System.Drawing.Point(15, 25);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(157, 13);
            this.labelInstructions.TabIndex = 14;
            this.labelInstructions.Text = "Select an order to see its details";
            // 
            // labelProductsCountData
            // 
            this.labelProductsCountData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductsCountData.Location = new System.Drawing.Point(61, 483);
            this.labelProductsCountData.Name = "labelProductsCountData";
            this.labelProductsCountData.Size = new System.Drawing.Size(60, 16);
            this.labelProductsCountData.TabIndex = 13;
            this.labelProductsCountData.Text = "0";
            this.labelProductsCountData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelProductsCount
            // 
            this.labelProductsCount.AutoSize = true;
            this.labelProductsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductsCount.Location = new System.Drawing.Point(11, 483);
            this.labelProductsCount.Name = "labelProductsCount";
            this.labelProductsCount.Size = new System.Drawing.Size(47, 16);
            this.labelProductsCount.TabIndex = 12;
            this.labelProductsCount.Text = "Count";
            // 
            // labelOrdersCountData
            // 
            this.labelOrdersCountData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdersCountData.Location = new System.Drawing.Point(61, 266);
            this.labelOrdersCountData.Name = "labelOrdersCountData";
            this.labelOrdersCountData.Size = new System.Drawing.Size(60, 16);
            this.labelOrdersCountData.TabIndex = 11;
            this.labelOrdersCountData.Text = "0";
            this.labelOrdersCountData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelOrdersCount
            // 
            this.labelOrdersCount.AutoSize = true;
            this.labelOrdersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdersCount.Location = new System.Drawing.Point(11, 266);
            this.labelOrdersCount.Name = "labelOrdersCount";
            this.labelOrdersCount.Size = new System.Drawing.Size(47, 16);
            this.labelOrdersCount.TabIndex = 10;
            this.labelOrdersCount.Text = "Count";
            // 
            // labelProductsInOrder
            // 
            this.labelProductsInOrder.AutoSize = true;
            this.labelProductsInOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductsInOrder.Location = new System.Drawing.Point(11, 315);
            this.labelProductsInOrder.Name = "labelProductsInOrder";
            this.labelProductsInOrder.Size = new System.Drawing.Size(126, 16);
            this.labelProductsInOrder.TabIndex = 2;
            this.labelProductsInOrder.Text = "Products in order";
            // 
            // dataGridViewOrderProducts
            // 
            this.dataGridViewOrderProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderProducts.Location = new System.Drawing.Point(14, 334);
            this.dataGridViewOrderProducts.Name = "dataGridViewOrderProducts";
            this.dataGridViewOrderProducts.Size = new System.Drawing.Size(790, 146);
            this.dataGridViewOrderProducts.TabIndex = 3;
            // 
            // labelOrders
            // 
            this.labelOrders.AutoSize = true;
            this.labelOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrders.Location = new System.Drawing.Point(11, 51);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(55, 16);
            this.labelOrders.TabIndex = 4;
            this.labelOrders.Text = "Orders";
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(14, 70);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(790, 193);
            this.dataGridViewOrders.TabIndex = 5;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 533);
            this.Controls.Add(this.groupBoxOrders);
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.groupBoxOrders.ResumeLayout(false);
            this.groupBoxOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOrders;
        private System.Windows.Forms.Label labelOrdersCountData;
        private System.Windows.Forms.Label labelOrdersCount;
        private System.Windows.Forms.Label labelProductsInOrder;
        private System.Windows.Forms.DataGridView dataGridViewOrderProducts;
        private System.Windows.Forms.Label labelOrders;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Label labelProductsCountData;
        private System.Windows.Forms.Label labelProductsCount;
        private System.Windows.Forms.Label labelInstructions;
    }
}