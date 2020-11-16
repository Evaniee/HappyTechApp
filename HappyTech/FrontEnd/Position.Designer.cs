namespace HappyTech.FrontEnd
{
    partial class Position
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
            this.btn_addApplicant = new System.Windows.Forms.Button();
            this.btn_informApplicant = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_hired = new System.Windows.Forms.Label();
            this.lbl_profile = new System.Windows.Forms.Label();
            this.lbl_feedback = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_sent = new System.Windows.Forms.Label();
            this.lbl_contacted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(400, 52);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(0, 20);
            this.lbl_title.TabIndex = 0;
            // 
            // btn_addApplicant
            // 
            this.btn_addApplicant.Location = new System.Drawing.Point(213, 99);
            this.btn_addApplicant.Name = "btn_addApplicant";
            this.btn_addApplicant.Size = new System.Drawing.Size(143, 29);
            this.btn_addApplicant.TabIndex = 1;
            this.btn_addApplicant.Text = "Add Applicant";
            this.btn_addApplicant.UseVisualStyleBackColor = true;
            this.btn_addApplicant.Click += new System.EventHandler(this.btn_addApplicant_Click);
            // 
            // btn_informApplicant
            // 
            this.btn_informApplicant.Location = new System.Drawing.Point(477, 99);
            this.btn_informApplicant.Name = "btn_informApplicant";
            this.btn_informApplicant.Size = new System.Drawing.Size(156, 29);
            this.btn_informApplicant.TabIndex = 2;
            this.btn_informApplicant.Text = "Inform Applicants";
            this.btn_informApplicant.UseVisualStyleBackColor = true;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(10, 175);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(52, 20);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_hired
            // 
            this.lbl_hired.AutoSize = true;
            this.lbl_hired.Location = new System.Drawing.Point(120, 175);
            this.lbl_hired.Name = "lbl_hired";
            this.lbl_hired.Size = new System.Drawing.Size(49, 20);
            this.lbl_hired.TabIndex = 3;
            this.lbl_hired.Text = "Hired:";
            // 
            // lbl_profile
            // 
            this.lbl_profile.AutoSize = true;
            this.lbl_profile.Location = new System.Drawing.Point(180, 175);
            this.lbl_profile.Name = "lbl_profile";
            this.lbl_profile.Size = new System.Drawing.Size(55, 20);
            this.lbl_profile.TabIndex = 3;
            this.lbl_profile.Text = "Profile:";
            // 
            // lbl_feedback
            // 
            this.lbl_feedback.AutoSize = true;
            this.lbl_feedback.Location = new System.Drawing.Point(290, 175);
            this.lbl_feedback.Name = "lbl_feedback";
            this.lbl_feedback.Size = new System.Drawing.Size(75, 20);
            this.lbl_feedback.TabIndex = 3;
            this.lbl_feedback.Text = "Feedback:";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Location = new System.Drawing.Point(400, 175);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(49, 20);
            this.lbl_score.TabIndex = 3;
            this.lbl_score.Text = "Score:";
            // 
            // lbl_sent
            // 
            this.lbl_sent.AutoSize = true;
            this.lbl_sent.Location = new System.Drawing.Point(460, 175);
            this.lbl_sent.Name = "lbl_sent";
            this.lbl_sent.Size = new System.Drawing.Size(41, 20);
            this.lbl_sent.TabIndex = 3;
            this.lbl_sent.Text = "Sent:";
            // 
            // lbl_contacted
            // 
            this.lbl_contacted.AutoSize = true;
            this.lbl_contacted.Location = new System.Drawing.Point(510, 175);
            this.lbl_contacted.Name = "lbl_contacted";
            this.lbl_contacted.Size = new System.Drawing.Size(80, 20);
            this.lbl_contacted.TabIndex = 3;
            this.lbl_contacted.Text = "Contacted:";
            // 
            // Position
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_contacted);
            this.Controls.Add(this.lbl_sent);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_feedback);
            this.Controls.Add(this.lbl_profile);
            this.Controls.Add(this.lbl_hired);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_informApplicant);
            this.Controls.Add(this.btn_addApplicant);
            this.Controls.Add(this.lbl_title);
            this.Location = new System.Drawing.Point(295, 175);
            this.Name = "Position";
            this.Text = "Feedback:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_addApplicant;
        private System.Windows.Forms.Button btn_informApplicant;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_hired;
        private System.Windows.Forms.Label lbl_profile;
        private System.Windows.Forms.Label lbl_feedback;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_sent;
        private System.Windows.Forms.Label lbl_contacted;
    }
}