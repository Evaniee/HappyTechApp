namespace HappyTech.FrontEnd
{
    partial class NewSkillset
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.cmb_NewRequirement = new System.Windows.Forms.ComboBox();
            this.cmb_EditRequirement = new System.Windows.Forms.ComboBox();
            this.cmb_RemoveRequirement = new System.Windows.Forms.ComboBox();
            this.btn_Return = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title.Location = new System.Drawing.Point(339, 100);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(99, 37);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Skillset";
            // 
            // cmb_NewRequirement
            // 
            this.cmb_NewRequirement.FormattingEnabled = true;
            this.cmb_NewRequirement.Location = new System.Drawing.Point(46, 158);
            this.cmb_NewRequirement.Name = "cmb_NewRequirement";
            this.cmb_NewRequirement.Size = new System.Drawing.Size(203, 23);
            this.cmb_NewRequirement.TabIndex = 1;
            // 
            // cmb_EditRequirement
            // 
            this.cmb_EditRequirement.FormattingEnabled = true;
            this.cmb_EditRequirement.Location = new System.Drawing.Point(46, 225);
            this.cmb_EditRequirement.Name = "cmb_EditRequirement";
            this.cmb_EditRequirement.Size = new System.Drawing.Size(203, 23);
            this.cmb_EditRequirement.TabIndex = 1;
            // 
            // cmb_RemoveRequirement
            // 
            this.cmb_RemoveRequirement.FormattingEnabled = true;
            this.cmb_RemoveRequirement.Location = new System.Drawing.Point(46, 293);
            this.cmb_RemoveRequirement.Name = "cmb_RemoveRequirement";
            this.cmb_RemoveRequirement.Size = new System.Drawing.Size(203, 23);
            this.cmb_RemoveRequirement.TabIndex = 1;
            // 
            // btn_Return
            // 
            this.btn_Return.Location = new System.Drawing.Point(307, 386);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(162, 23);
            this.btn_Return.TabIndex = 2;
            this.btn_Return.Text = "Return To Template";
            this.btn_Return.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(505, 158);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 158);
            this.textBox1.TabIndex = 3;
            // 
            // NewSkillset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.cmb_RemoveRequirement);
            this.Controls.Add(this.cmb_EditRequirement);
            this.Controls.Add(this.cmb_NewRequirement);
            this.Controls.Add(this.lbl_Title);
            this.Name = "NewSkillset";
            this.Text = "NewSkillset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.ComboBox cmb_NewRequirement;
        private System.Windows.Forms.ComboBox cmb_EditRequirement;
        private System.Windows.Forms.ComboBox cmb_RemoveRequirement;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.TextBox textBox1;
    }
}