namespace HappyTech.FrontEnd
{
    partial class TemplateTeamworking
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
            this.cmb_NewTeamworking = new System.Windows.Forms.ComboBox();
            this.cmb_EditTeamworking = new System.Windows.Forms.ComboBox();
            this.cmb_RemoveTeamworking = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ReturnTeamworking = new System.Windows.Forms.Button();
            this.lst_TeamworkingRequirements = new System.Windows.Forms.ListBox();
            this.lbl_TeamworkingReq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_NewTeamworking
            // 
            this.cmb_NewTeamworking.FormattingEnabled = true;
            this.cmb_NewTeamworking.Location = new System.Drawing.Point(86, 179);
            this.cmb_NewTeamworking.Name = "cmb_NewTeamworking";
            this.cmb_NewTeamworking.Size = new System.Drawing.Size(158, 23);
            this.cmb_NewTeamworking.TabIndex = 0;
            this.cmb_NewTeamworking.Text = "Add New Requirement";
            // 
            // cmb_EditTeamworking
            // 
            this.cmb_EditTeamworking.FormattingEnabled = true;
            this.cmb_EditTeamworking.Location = new System.Drawing.Point(86, 239);
            this.cmb_EditTeamworking.Name = "cmb_EditTeamworking";
            this.cmb_EditTeamworking.Size = new System.Drawing.Size(158, 23);
            this.cmb_EditTeamworking.TabIndex = 1;
            this.cmb_EditTeamworking.Text = "Edit Requirement";
            // 
            // cmb_RemoveTeamworking
            // 
            this.cmb_RemoveTeamworking.FormattingEnabled = true;
            this.cmb_RemoveTeamworking.Location = new System.Drawing.Point(86, 298);
            this.cmb_RemoveTeamworking.Name = "cmb_RemoveTeamworking";
            this.cmb_RemoveTeamworking.Size = new System.Drawing.Size(158, 23);
            this.cmb_RemoveTeamworking.TabIndex = 2;
            this.cmb_RemoveTeamworking.Text = "Remove Teamworking";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Teamworking";
            // 
            // btn_ReturnTeamworking
            // 
            this.btn_ReturnTeamworking.Location = new System.Drawing.Point(356, 359);
            this.btn_ReturnTeamworking.Name = "btn_ReturnTeamworking";
            this.btn_ReturnTeamworking.Size = new System.Drawing.Size(127, 23);
            this.btn_ReturnTeamworking.TabIndex = 4;
            this.btn_ReturnTeamworking.Text = "Return To Template";
            this.btn_ReturnTeamworking.UseVisualStyleBackColor = true;
            // 
            // lst_TeamworkingRequirements
            // 
            this.lst_TeamworkingRequirements.FormattingEnabled = true;
            this.lst_TeamworkingRequirements.ItemHeight = 15;
            this.lst_TeamworkingRequirements.Location = new System.Drawing.Point(546, 179);
            this.lst_TeamworkingRequirements.Name = "lst_TeamworkingRequirements";
            this.lst_TeamworkingRequirements.Size = new System.Drawing.Size(184, 169);
            this.lst_TeamworkingRequirements.TabIndex = 5;
            // 
            // lbl_TeamworkingReq
            // 
            this.lbl_TeamworkingReq.AutoSize = true;
            this.lbl_TeamworkingReq.Location = new System.Drawing.Point(576, 149);
            this.lbl_TeamworkingReq.Name = "lbl_TeamworkingReq";
            this.lbl_TeamworkingReq.Size = new System.Drawing.Size(154, 15);
            this.lbl_TeamworkingReq.TabIndex = 6;
            this.lbl_TeamworkingReq.Text = "Teamworking Requirements";
            // 
            // NewTeamworking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_TeamworkingReq);
            this.Controls.Add(this.lst_TeamworkingRequirements);
            this.Controls.Add(this.btn_ReturnTeamworking);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_RemoveTeamworking);
            this.Controls.Add(this.cmb_EditTeamworking);
            this.Controls.Add(this.cmb_NewTeamworking);
            this.Name = "NewTeamworking";
            this.Text = "NewTeamworking";
            this.Load += new System.EventHandler(this.NewTeamworking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_NewTeamworking;
        private System.Windows.Forms.ComboBox cmb_EditTeamworking;
        private System.Windows.Forms.ComboBox cmb_RemoveTeamworking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ReturnTeamworking;
        private System.Windows.Forms.ListBox lst_TeamworkingRequirements;
        private System.Windows.Forms.Label lbl_TeamworkingReq;
    }
}