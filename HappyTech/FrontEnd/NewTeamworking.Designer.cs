namespace HappyTech.FrontEnd
{
    partial class NewTeamworking
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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.txt_Teamworking = new System.Windows.Forms.TextBox();
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
            this.lbl_Title.Text = "Teamworking";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(307, 386);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(162, 23);
            this.btn_Submit.TabIndex = 2;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click_1);
            // 
            // txt_Teamworking
            // 
            this.txt_Teamworking.Location = new System.Drawing.Point(12, 162);
            this.txt_Teamworking.Multiline = true;
            this.txt_Teamworking.Name = "txt_Teamworking";
            this.txt_Teamworking.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Teamworking.Size = new System.Drawing.Size(776, 68);
            this.txt_Teamworking.TabIndex = 0;
            // 
            // NewTeamworking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Teamworking);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lbl_Title);
            this.Name = "NewTeamworking";
            this.Text = "NewTeamworking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox txt_Teamworking;
    }
}
