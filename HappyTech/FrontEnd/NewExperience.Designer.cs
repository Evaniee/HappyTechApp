namespace HappyTech.FrontEnd
{
    partial class NewExperience
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
            this.cmb_test = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmb_test
            // 
            this.cmb_test.AllowDrop = true;
            this.cmb_test.FormattingEnabled = true;
            this.cmb_test.Location = new System.Drawing.Point(100, 107);
            this.cmb_test.Name = "cmb_test";
            this.cmb_test.Size = new System.Drawing.Size(121, 23);
            this.cmb_test.TabIndex = 0;
            this.cmb_test.DropDown += new System.EventHandler(this.cmb_test_DropDown);
            // 
            // NewExperience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_test);
            this.Name = "NewExperience";
            this.Text = "NewExperience";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_test;
    }
}