namespace HappyTech.FrontEnd
{
    partial class NewTemplate
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
            this.btn_questions = new System.Windows.Forms.Button();
            this.btn_experience = new System.Windows.Forms.Button();
            this.btn_skillset = new System.Windows.Forms.Button();
            this.btn_teamworking = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_questions
            // 
            this.btn_questions.Location = new System.Drawing.Point(304, 234);
            this.btn_questions.Name = "btn_questions";
            this.btn_questions.Size = new System.Drawing.Size(122, 23);
            this.btn_questions.TabIndex = 0;
            this.btn_questions.Text = "Questions";
            this.btn_questions.UseVisualStyleBackColor = true;
            this.btn_questions.Click += new System.EventHandler(this.btn_questions_Click);
            // 
            // btn_experience
            // 
            this.btn_experience.Location = new System.Drawing.Point(304, 263);
            this.btn_experience.Name = "btn_experience";
            this.btn_experience.Size = new System.Drawing.Size(122, 23);
            this.btn_experience.TabIndex = 0;
            this.btn_experience.Text = "Experience";
            this.btn_experience.UseVisualStyleBackColor = true;
            this.btn_experience.Click += new System.EventHandler(this.btn_experience_Click);
            // 
            // btn_skillset
            // 
            this.btn_skillset.Location = new System.Drawing.Point(304, 292);
            this.btn_skillset.Name = "btn_skillset";
            this.btn_skillset.Size = new System.Drawing.Size(122, 23);
            this.btn_skillset.TabIndex = 0;
            this.btn_skillset.Text = "Skillset";
            this.btn_skillset.UseVisualStyleBackColor = true;
            this.btn_skillset.Click += new System.EventHandler(this.btn_skillset_Click);
            // 
            // btn_teamworking
            // 
            this.btn_teamworking.Location = new System.Drawing.Point(304, 321);
            this.btn_teamworking.Name = "btn_teamworking";
            this.btn_teamworking.Size = new System.Drawing.Size(122, 23);
            this.btn_teamworking.TabIndex = 0;
            this.btn_teamworking.Text = "Teamworking";
            this.btn_teamworking.UseVisualStyleBackColor = true;
            this.btn_teamworking.Click += new System.EventHandler(this.btn_teamworking_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(304, 350);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(122, 23);
            this.btn_submit.TabIndex = 0;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(304, 205);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(122, 23);
            this.txt_title.TabIndex = 1;
            this.txt_title.Text = "Template Title";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(304, 187);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(32, 15);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Title:";
            // 
            // NewTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_teamworking);
            this.Controls.Add(this.btn_skillset);
            this.Controls.Add(this.btn_experience);
            this.Controls.Add(this.btn_questions);
            this.Name = "NewTemplate";
            this.Text = "NewTemplate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_questions;
        private System.Windows.Forms.Button btn_experience;
        private System.Windows.Forms.Button btn_skillset;
        private System.Windows.Forms.Button btn_teamworking;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label lbl_title;
    }
}