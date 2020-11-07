namespace HappyTech.FrontEnd
{
    partial class MainMenu
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
            this.btn_newPosition = new System.Windows.Forms.Button();
            this.btn_currentPosition = new System.Windows.Forms.Button();
            this.btn_logOut = new System.Windows.Forms.Button();
            this.lbl_mainMenu = new System.Windows.Forms.Label();
            this.lbl_hr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_newPosition
            // 
            this.btn_newPosition.Location = new System.Drawing.Point(329, 142);
            this.btn_newPosition.Name = "btn_newPosition";
            this.btn_newPosition.Size = new System.Drawing.Size(138, 23);
            this.btn_newPosition.TabIndex = 0;
            this.btn_newPosition.Text = "New Position";
            this.btn_newPosition.UseVisualStyleBackColor = true;
            this.btn_newPosition.Click += new System.EventHandler(this.btn_newPosition_Click);
            // 
            // btn_currentPosition
            // 
            this.btn_currentPosition.Location = new System.Drawing.Point(329, 214);
            this.btn_currentPosition.Name = "btn_currentPosition";
            this.btn_currentPosition.Size = new System.Drawing.Size(138, 23);
            this.btn_currentPosition.TabIndex = 1;
            this.btn_currentPosition.Text = "Current Positions";
            this.btn_currentPosition.UseVisualStyleBackColor = true;
            this.btn_currentPosition.Click += new System.EventHandler(this.btn_currentPosition_Click);
            // 
            // btn_logOut
            // 
            this.btn_logOut.Location = new System.Drawing.Point(329, 279);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(138, 23);
            this.btn_logOut.TabIndex = 2;
            this.btn_logOut.Text = "Log Out";
            this.btn_logOut.UseVisualStyleBackColor = true;
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // lbl_mainMenu
            // 
            this.lbl_mainMenu.AutoSize = true;
            this.lbl_mainMenu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_mainMenu.Location = new System.Drawing.Point(329, 57);
            this.lbl_mainMenu.Name = "lbl_mainMenu";
            this.lbl_mainMenu.Size = new System.Drawing.Size(138, 32);
            this.lbl_mainMenu.TabIndex = 4;
            this.lbl_mainMenu.Text = "Main Menu";
            // 
            // lbl_hr
            // 
            this.lbl_hr.AutoSize = true;
            this.lbl_hr.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_hr.Location = new System.Drawing.Point(374, 89);
            this.lbl_hr.Name = "lbl_hr";
            this.lbl_hr.Size = new System.Drawing.Size(41, 30);
            this.lbl_hr.TabIndex = 5;
            this.lbl_hr.Text = "HR";
            this.lbl_hr.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_hr);
            this.Controls.Add(this.lbl_mainMenu);
            this.Controls.Add(this.btn_logOut);
            this.Controls.Add(this.btn_currentPosition);
            this.Controls.Add(this.btn_newPosition);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_newPosition;
        private System.Windows.Forms.Button btn_currentPosition;
        private System.Windows.Forms.Button btn_logOut;
        private System.Windows.Forms.Label lbl_mainMenu;
        private System.Windows.Forms.Label lbl_hr;
    }
}