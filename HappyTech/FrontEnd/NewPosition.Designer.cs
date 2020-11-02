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
            this.SuspendLayout();
            // 
            // lbl_newPosition
            // 
            this.lbl_newPosition.AutoSize = true;
            this.lbl_newPosition.Location = new System.Drawing.Point(337, 70);
            this.lbl_newPosition.Name = "lbl_newPosition";
            this.lbl_newPosition.Size = new System.Drawing.Size(74, 15);
            this.lbl_newPosition.TabIndex = 0;
            this.lbl_newPosition.Text = "New Postion";
            // 
            // NewPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_newPosition);
            this.Name = "NewPosition";
            this.Text = "NewPosition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_newPosition;
    }
}