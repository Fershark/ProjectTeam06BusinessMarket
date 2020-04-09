namespace ProjectTeam06BusinessMarketplaceForms
{
    partial class AddOrUpdateBusinessNameForm
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
            this.listBoxName = new System.Windows.Forms.ListBox();
            this.labelBusinessName = new System.Windows.Forms.Label();
            this.labelBusinessAddress = new System.Windows.Forms.Label();
            this.labelBusinessEmail = new System.Windows.Forms.Label();
            this.labelIsAdmin = new System.Windows.Forms.Label();
            this.textBoxBusinessName = new System.Windows.Forms.TextBox();
            this.textBoxBusinessAddress = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBoxIsAdmin = new System.Windows.Forms.CheckBox();
            this.labelBusinessId = new System.Windows.Forms.Label();
            this.labelBusinessIdNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxName
            // 
            this.listBoxName.FormattingEnabled = true;
            this.listBoxName.Location = new System.Drawing.Point(48, 39);
            this.listBoxName.Name = "listBoxName";
            this.listBoxName.Size = new System.Drawing.Size(225, 134);
            this.listBoxName.TabIndex = 0;
            this.listBoxName.SelectedIndexChanged += new System.EventHandler(this.listBoxName_SelectedIndexChanged);
            // 
            // labelBusinessName
            // 
            this.labelBusinessName.AutoSize = true;
            this.labelBusinessName.Location = new System.Drawing.Point(39, 232);
            this.labelBusinessName.Name = "labelBusinessName";
            this.labelBusinessName.Size = new System.Drawing.Size(35, 13);
            this.labelBusinessName.TabIndex = 2;
            this.labelBusinessName.Text = "Name";
            // 
            // labelBusinessAddress
            // 
            this.labelBusinessAddress.AutoSize = true;
            this.labelBusinessAddress.Location = new System.Drawing.Point(39, 322);
            this.labelBusinessAddress.Name = "labelBusinessAddress";
            this.labelBusinessAddress.Size = new System.Drawing.Size(45, 13);
            this.labelBusinessAddress.TabIndex = 3;
            this.labelBusinessAddress.Text = "Address";
            // 
            // labelBusinessEmail
            // 
            this.labelBusinessEmail.AutoSize = true;
            this.labelBusinessEmail.Location = new System.Drawing.Point(39, 391);
            this.labelBusinessEmail.Name = "labelBusinessEmail";
            this.labelBusinessEmail.Size = new System.Drawing.Size(32, 13);
            this.labelBusinessEmail.TabIndex = 4;
            this.labelBusinessEmail.Text = "Email";
            // 
            // labelIsAdmin
            // 
            this.labelIsAdmin.AutoSize = true;
            this.labelIsAdmin.Location = new System.Drawing.Point(39, 484);
            this.labelIsAdmin.Name = "labelIsAdmin";
            this.labelIsAdmin.Size = new System.Drawing.Size(47, 13);
            this.labelIsAdmin.TabIndex = 5;
            this.labelIsAdmin.Text = "Is Admin";
            // 
            // textBoxBusinessName
            // 
            this.textBoxBusinessName.Location = new System.Drawing.Point(42, 262);
            this.textBoxBusinessName.Name = "textBoxBusinessName";
            this.textBoxBusinessName.Size = new System.Drawing.Size(100, 20);
            this.textBoxBusinessName.TabIndex = 6;
            // 
            // textBoxBusinessAddress
            // 
            this.textBoxBusinessAddress.Location = new System.Drawing.Point(42, 349);
            this.textBoxBusinessAddress.Name = "textBoxBusinessAddress";
            this.textBoxBusinessAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxBusinessAddress.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(42, 421);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // checkBoxIsAdmin
            // 
            this.checkBoxIsAdmin.AutoSize = true;
            this.checkBoxIsAdmin.Location = new System.Drawing.Point(42, 512);
            this.checkBoxIsAdmin.Name = "checkBoxIsAdmin";
            this.checkBoxIsAdmin.Size = new System.Drawing.Size(66, 17);
            this.checkBoxIsAdmin.TabIndex = 9;
            this.checkBoxIsAdmin.Text = "Is Admin";
            this.checkBoxIsAdmin.UseVisualStyleBackColor = true;
            // 
            // labelBusinessId
            // 
            this.labelBusinessId.AutoSize = true;
            this.labelBusinessId.Location = new System.Drawing.Point(39, 195);
            this.labelBusinessId.Name = "labelBusinessId";
            this.labelBusinessId.Size = new System.Drawing.Size(63, 13);
            this.labelBusinessId.TabIndex = 10;
            this.labelBusinessId.Text = "Business ID";
            // 
            // labelBusinessIdNumber
            // 
            this.labelBusinessIdNumber.AutoSize = true;
            this.labelBusinessIdNumber.Location = new System.Drawing.Point(139, 195);
            this.labelBusinessIdNumber.Name = "labelBusinessIdNumber";
            this.labelBusinessIdNumber.Size = new System.Drawing.Size(18, 13);
            this.labelBusinessIdNumber.TabIndex = 11;
            this.labelBusinessIdNumber.Text = "ID";
            // 
            // AddOrUpdateBusinessNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 591);
            this.Controls.Add(this.labelBusinessIdNumber);
            this.Controls.Add(this.labelBusinessId);
            this.Controls.Add(this.checkBoxIsAdmin);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxBusinessAddress);
            this.Controls.Add(this.textBoxBusinessName);
            this.Controls.Add(this.labelIsAdmin);
            this.Controls.Add(this.labelBusinessEmail);
            this.Controls.Add(this.labelBusinessAddress);
            this.Controls.Add(this.labelBusinessName);
            this.Controls.Add(this.listBoxName);
            this.Name = "AddOrUpdateBusinessNameForm";
            this.Text = "Add or Update Business Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxName;
        private System.Windows.Forms.Label labelBusinessName;
        private System.Windows.Forms.Label labelBusinessAddress;
        private System.Windows.Forms.Label labelBusinessEmail;
        private System.Windows.Forms.Label labelIsAdmin;
        private System.Windows.Forms.TextBox textBoxBusinessName;
        private System.Windows.Forms.TextBox textBoxBusinessAddress;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBoxIsAdmin;
        private System.Windows.Forms.Label labelBusinessId;
        private System.Windows.Forms.Label labelBusinessIdNumber;
    }
}