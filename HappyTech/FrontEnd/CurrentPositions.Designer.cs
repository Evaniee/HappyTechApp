namespace HappyTech.FrontEnd
{
    partial class CurrentPositions
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
            this.lbl_currentPositions = new System.Windows.Forms.Label();
            this.cmb_currentPositions = new System.Windows.Forms.ComboBox();
            this.lbl_currentPosition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_currentPositions
            // 
            this.lbl_currentPositions.AutoSize = true;
            this.lbl_currentPositions.Location = new System.Drawing.Point(346, 86);
            this.lbl_currentPositions.Name = "lbl_currentPositions";
            this.lbl_currentPositions.Size = new System.Drawing.Size(98, 15);
            this.lbl_currentPositions.TabIndex = 0;
            this.lbl_currentPositions.Text = "Current Positions";
            // 
            // cmb_currentPositions
            // 
            this.cmb_currentPositions.FormattingEnabled = true;
            this.cmb_currentPositions.Location = new System.Drawing.Point(183, 194);
            this.cmb_currentPositions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_currentPositions.Name = "cmb_currentPositions";
            this.cmb_currentPositions.Size = new System.Drawing.Size(463, 23);
            this.cmb_currentPositions.TabIndex = 1;
            this.cmb_currentPositions.SelectedIndexChanged += new System.EventHandler(this.cmb_currentPositions_SelectedIndexChanged);
            // 
            // lbl_currentPosition
            // 
            this.lbl_currentPosition.AutoSize = true;
            this.lbl_currentPosition.Location = new System.Drawing.Point(346, 176);
            this.lbl_currentPosition.Name = "lbl_currentPosition";
            this.lbl_currentPosition.Size = new System.Drawing.Size(101, 15);
            this.lbl_currentPosition.TabIndex = 0;
            this.lbl_currentPosition.Text = "Current Positions:";
            // 
            // CurrentPositions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_currentPosition);
            this.Controls.Add(this.cmb_currentPositions);
            this.Controls.Add(this.lbl_currentPositions);
            this.Name = "CurrentPositions";
            this.Text = "Current Positions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_currentPositions;
        private System.Windows.Forms.ComboBox cmb_currentPositions;
        private System.Windows.Forms.Label lbl_currentPosition;
    }
}