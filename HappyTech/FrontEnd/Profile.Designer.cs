namespace HappyTech.FrontEnd
{
    partial class Profile
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_emailAddress = new System.Windows.Forms.Label();
            this.lbl_contactNumber = new System.Windows.Forms.Label();
            this.lbl_disabilities = new System.Windows.Forms.Label();
            this.lbl_rightToWork = new System.Windows.Forms.Label();
            this.chk_rightToWork = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(50, 100);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(44, 15);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Profile:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(50, 160);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(42, 15);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(50, 200);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(31, 15);
            this.lbl_age.TabIndex = 2;
            this.lbl_age.Text = "Age:";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(50, 240);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(52, 15);
            this.lbl_address.TabIndex = 3;
            this.lbl_address.Text = "Address:";
            // 
            // lbl_emailAddress
            // 
            this.lbl_emailAddress.AutoSize = true;
            this.lbl_emailAddress.Location = new System.Drawing.Point(50, 280);
            this.lbl_emailAddress.Name = "lbl_emailAddress";
            this.lbl_emailAddress.Size = new System.Drawing.Size(84, 15);
            this.lbl_emailAddress.TabIndex = 4;
            this.lbl_emailAddress.Text = "Email Address:";
            // 
            // lbl_contactNumber
            // 
            this.lbl_contactNumber.AutoSize = true;
            this.lbl_contactNumber.Location = new System.Drawing.Point(50, 320);
            this.lbl_contactNumber.Name = "lbl_contactNumber";
            this.lbl_contactNumber.Size = new System.Drawing.Size(99, 15);
            this.lbl_contactNumber.TabIndex = 5;
            this.lbl_contactNumber.Text = "Contact Number:";
            // 
            // lbl_disabilities
            // 
            this.lbl_disabilities.AutoSize = true;
            this.lbl_disabilities.Location = new System.Drawing.Point(50, 360);
            this.lbl_disabilities.Name = "lbl_disabilities";
            this.lbl_disabilities.Size = new System.Drawing.Size(66, 15);
            this.lbl_disabilities.TabIndex = 6;
            this.lbl_disabilities.Text = "Disabilities:";
            // 
            // lbl_rightToWork
            // 
            this.lbl_rightToWork.AutoSize = true;
            this.lbl_rightToWork.Location = new System.Drawing.Point(50, 400);
            this.lbl_rightToWork.Name = "lbl_rightToWork";
            this.lbl_rightToWork.Size = new System.Drawing.Size(84, 15);
            this.lbl_rightToWork.TabIndex = 7;
            this.lbl_rightToWork.Text = "Right To Work:";
            // 
            // chk_rightToWork
            // 
            this.chk_rightToWork.AutoSize = true;
            this.chk_rightToWork.Location = new System.Drawing.Point(140, 401);
            this.chk_rightToWork.Name = "chk_rightToWork";
            this.chk_rightToWork.Size = new System.Drawing.Size(15, 14);
            this.chk_rightToWork.TabIndex = 8;
            this.chk_rightToWork.UseVisualStyleBackColor = true;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chk_rightToWork);
            this.Controls.Add(this.lbl_rightToWork);
            this.Controls.Add(this.lbl_disabilities);
            this.Controls.Add(this.lbl_contactNumber);
            this.Controls.Add(this.lbl_emailAddress);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_title);
            this.Name = "Profile";
            this.Text = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_emailAddress;
        private System.Windows.Forms.Label lbl_contactNumber;
        private System.Windows.Forms.Label lbl_disabilities;
        private System.Windows.Forms.Label lbl_rightToWork;
        private System.Windows.Forms.CheckBox chk_rightToWork;
    }
}