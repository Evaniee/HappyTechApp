namespace HappyTech.FrontEnd
{
    partial class NewPosition
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
            this.lbl_newPosition = new System.Windows.Forms.Label();
            this.lbl_jobTitle = new System.Windows.Forms.Label();
            this.lbl_jobCode = new System.Windows.Forms.Label();
            this.txt_jobTitle = new System.Windows.Forms.TextBox();
            this.txt_jobCode = new System.Windows.Forms.TextBox();
            this.txt_jobDescription = new System.Windows.Forms.TextBox();
            this.lbl_jobDescription = new System.Windows.Forms.Label();
            this.cmb_jobTemplate = new System.Windows.Forms.ComboBox();
            this.lbl_jobPosition = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_newPosition
            // 
            this.lbl_newPosition.AutoSize = true;
            this.lbl_newPosition.Location = new System.Drawing.Point(348, 72);
            this.lbl_newPosition.Name = "lbl_newPosition";
            this.lbl_newPosition.Size = new System.Drawing.Size(74, 15);
            this.lbl_newPosition.TabIndex = 0;
            this.lbl_newPosition.Text = "New Postion";
            // 
            // lbl_jobTitle
            // 
            this.lbl_jobTitle.AutoSize = true;
            this.lbl_jobTitle.Location = new System.Drawing.Point(12, 181);
            this.lbl_jobTitle.Name = "lbl_jobTitle";
            this.lbl_jobTitle.Size = new System.Drawing.Size(53, 15);
            this.lbl_jobTitle.TabIndex = 1;
            this.lbl_jobTitle.Text = "Job Title:";
            // 
            // lbl_jobCode
            // 
            this.lbl_jobCode.AutoSize = true;
            this.lbl_jobCode.Location = new System.Drawing.Point(688, 181);
            this.lbl_jobCode.Name = "lbl_jobCode";
            this.lbl_jobCode.Size = new System.Drawing.Size(59, 15);
            this.lbl_jobCode.TabIndex = 2;
            this.lbl_jobCode.Text = "Job Code:";
            // 
            // txt_jobTitle
            // 
            this.txt_jobTitle.Location = new System.Drawing.Point(12, 199);
            this.txt_jobTitle.Name = "txt_jobTitle";
            this.txt_jobTitle.Size = new System.Drawing.Size(100, 23);
            this.txt_jobTitle.TabIndex = 3;
            this.txt_jobTitle.Text = "Job Title";
            // 
            // txt_jobCode
            // 
            this.txt_jobCode.Location = new System.Drawing.Point(688, 199);
            this.txt_jobCode.Name = "txt_jobCode";
            this.txt_jobCode.Size = new System.Drawing.Size(100, 23);
            this.txt_jobCode.TabIndex = 4;
            this.txt_jobCode.Text = "Job Code";
            // 
            // txt_jobDescription
            // 
            this.txt_jobDescription.Location = new System.Drawing.Point(262, 199);
            this.txt_jobDescription.Multiline = true;
            this.txt_jobDescription.Name = "txt_jobDescription";
            this.txt_jobDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_jobDescription.Size = new System.Drawing.Size(300, 122);
            this.txt_jobDescription.TabIndex = 5;
            this.txt_jobDescription.Text = "Job Description";
            // 
            // lbl_jobDescription
            // 
            this.lbl_jobDescription.AutoSize = true;
            this.lbl_jobDescription.Location = new System.Drawing.Point(384, 181);
            this.lbl_jobDescription.Name = "lbl_jobDescription";
            this.lbl_jobDescription.Size = new System.Drawing.Size(91, 15);
            this.lbl_jobDescription.TabIndex = 6;
            this.lbl_jobDescription.Text = "Job Description:";
            // 
            // cmb_jobTemplate
            // 
            this.cmb_jobTemplate.FormattingEnabled = true;
            this.cmb_jobTemplate.Location = new System.Drawing.Point(348, 370);
            this.cmb_jobTemplate.Name = "cmb_jobTemplate";
            this.cmb_jobTemplate.Size = new System.Drawing.Size(121, 23);
            this.cmb_jobTemplate.TabIndex = 7;
            this.cmb_jobTemplate.Text = "Job Position";
            // 
            // lbl_jobPosition
            // 
            this.lbl_jobPosition.AutoSize = true;
            this.lbl_jobPosition.Location = new System.Drawing.Point(348, 352);
            this.lbl_jobPosition.Name = "lbl_jobPosition";
            this.lbl_jobPosition.Size = new System.Drawing.Size(71, 15);
            this.lbl_jobPosition.TabIndex = 8;
            this.lbl_jobPosition.Text = "Job Position";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(364, 415);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 9;
            this.btn_submit.Text = "Submit Position";
            this.btn_submit.UseVisualStyleBackColor = true;
            // 
            // NewPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lbl_jobPosition);
            this.Controls.Add(this.cmb_jobTemplate);
            this.Controls.Add(this.lbl_jobDescription);
            this.Controls.Add(this.txt_jobDescription);
            this.Controls.Add(this.txt_jobCode);
            this.Controls.Add(this.txt_jobTitle);
            this.Controls.Add(this.lbl_jobCode);
            this.Controls.Add(this.lbl_jobTitle);
            this.Controls.Add(this.lbl_newPosition);
            this.Name = "NewPosition";
            this.Text = "NewPosition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_newPosition;
        private System.Windows.Forms.Label lbl_jobTitle;
        private System.Windows.Forms.Label lbl_jobCode;
        private System.Windows.Forms.TextBox txt_jobTitle;
        private System.Windows.Forms.TextBox txt_jobCode;
        private System.Windows.Forms.TextBox txt_jobDescription;
        private System.Windows.Forms.Label lbl_jobDescription;
        private System.Windows.Forms.ComboBox cmb_jobTemplate;
        private System.Windows.Forms.Label lbl_jobPosition;
        private System.Windows.Forms.Button btn_submit;
    }
}