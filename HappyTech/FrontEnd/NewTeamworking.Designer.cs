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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_teamworkingRequirement = new System.Windows.Forms.TextBox();
            this.btn_AddTeamworking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Teamworking Requirement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Requirement";
            // 
            // txt_teamworkingRequirement
            // 
            this.txt_teamworkingRequirement.Location = new System.Drawing.Point(62, 164);
            this.txt_teamworkingRequirement.Name = "txt_teamworkingRequirement";
            this.txt_teamworkingRequirement.Size = new System.Drawing.Size(692, 23);
            this.txt_teamworkingRequirement.TabIndex = 1;
            // 
            // btn_AddTeamworking
            // 
            this.btn_AddTeamworking.Location = new System.Drawing.Point(378, 262);
            this.btn_AddTeamworking.Name = "btn_AddTeamworking";
            this.btn_AddTeamworking.Size = new System.Drawing.Size(75, 23);
            this.btn_AddTeamworking.TabIndex = 2;
            this.btn_AddTeamworking.Text = "Add Teamworking Requirement";
            this.btn_AddTeamworking.UseVisualStyleBackColor = true;
            // 
            // NewTeamworking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_AddTeamworking);
            this.Controls.Add(this.txt_teamworkingRequirement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewTeamworking";
            this.Text = "NewTeamworking";
            this.Load += new System.EventHandler(this.NewTeamworking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_teamworkingRequirement;
        private System.Windows.Forms.Button btn_AddTeamworking;
    }
}