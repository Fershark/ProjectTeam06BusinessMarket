namespace ProjectTeam06BusinessMarketplaceForms
{
    partial class AddOrUpdateCategoriesForm
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
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.labelCategoriesName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonAddCategories = new System.Windows.Forms.Button();
            this.buttonUpdateCategories = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.Location = new System.Drawing.Point(35, 25);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(202, 108);
            this.listBoxCategories.TabIndex = 0;
            // 
            // labelCategoriesName
            // 
            this.labelCategoriesName.AutoSize = true;
            this.labelCategoriesName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoriesName.Location = new System.Drawing.Point(35, 207);
            this.labelCategoriesName.Name = "labelCategoriesName";
            this.labelCategoriesName.Size = new System.Drawing.Size(147, 20);
            this.labelCategoriesName.TabIndex = 1;
            this.labelCategoriesName.Text = "Categories Name";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(35, 328);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(100, 20);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Description";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 234);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 44);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(35, 357);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 44);
            this.textBox2.TabIndex = 4;
            // 
            // buttonAddCategories
            // 
            this.buttonAddCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCategories.Location = new System.Drawing.Point(38, 441);
            this.buttonAddCategories.Name = "buttonAddCategories";
            this.buttonAddCategories.Size = new System.Drawing.Size(75, 35);
            this.buttonAddCategories.TabIndex = 5;
            this.buttonAddCategories.Text = "Add";
            this.buttonAddCategories.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateCategories
            // 
            this.buttonUpdateCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateCategories.Location = new System.Drawing.Point(154, 441);
            this.buttonUpdateCategories.Name = "buttonUpdateCategories";
            this.buttonUpdateCategories.Size = new System.Drawing.Size(75, 35);
            this.buttonUpdateCategories.TabIndex = 6;
            this.buttonUpdateCategories.Text = "Update";
            this.buttonUpdateCategories.UseVisualStyleBackColor = true;
            // 
            // AddOrUpdateCategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 531);
            this.Controls.Add(this.buttonUpdateCategories);
            this.Controls.Add(this.buttonAddCategories);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelCategoriesName);
            this.Controls.Add(this.listBoxCategories);
            this.Name = "AddOrUpdateCategoriesForm";
            this.Text = "Add or Update Categories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.Label labelCategoriesName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonAddCategories;
        private System.Windows.Forms.Button buttonUpdateCategories;
    }
}