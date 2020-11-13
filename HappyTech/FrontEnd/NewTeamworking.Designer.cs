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
            this.lbl_teamworkingTitle = new System.Windows.Forms.Label();
            this.txt_teamworkingReq = new System.Windows.Forms.TextBox();
            this.btn_teamworkingAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_teamworkingTitle
            // 
            this.lbl_teamworkingTitle.AutoSize = true;
            this.lbl_teamworkingTitle.Location = new System.Drawing.Point(291, 43);
            this.lbl_teamworkingTitle.Name = "lbl_teamworkingTitle";
            this.lbl_teamworkingTitle.Size = new System.Drawing.Size(176, 15);
            this.lbl_teamworkingTitle.TabIndex = 0;
            this.lbl_teamworkingTitle.Text = "New Teamworking Requirement";
            // 
            // txt_teamworkingReq
            // 
            this.txt_teamworkingReq.Location = new System.Drawing.Point(71, 116);
            this.txt_teamworkingReq.Name = "txt_teamworkingReq";
            this.txt_teamworkingReq.Size = new System.Drawing.Size(611, 23);
            this.txt_teamworkingReq.TabIndex = 1;
            // 
            // btn_teamworkingAdd
            // 
            this.btn_teamworkingAdd.Location = new System.Drawing.Point(276, 189);
            this.btn_teamworkingAdd.Name = "btn_teamworkingAdd";
            this.btn_teamworkingAdd.Size = new System.Drawing.Size(171, 45);
            this.btn_teamworkingAdd.TabIndex = 2;
            this.btn_teamworkingAdd.Text = "Add Teamworking Requirement";
            this.btn_teamworkingAdd.UseVisualStyleBackColor = true;
            this.btn_teamworkingAdd.Click += new System.EventHandler(this.btn_teamworkingAdd_Click);
            // 
            // NewTeamworking
            // 
            this.ClientSize = new System.Drawing.Size(734, 359);
            this.Controls.Add(this.btn_teamworkingAdd);
            this.Controls.Add(this.txt_teamworkingReq);
            this.Controls.Add(this.lbl_teamworkingTitle);
            this.Name = "NewTeamworking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_teamworkingTitle;
        private System.Windows.Forms.TextBox txt_teamworkingReq;
        private System.Windows.Forms.Button btn_teamworkingAdd;
    }
}
