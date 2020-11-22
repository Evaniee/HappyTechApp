namespace HappyTech.FrontEnd
{
    partial class TemplateExperience
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
            this.lbl_experience = new System.Windows.Forms.Label();
            this.txt_selected = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_remove = new System.Windows.Forms.ComboBox();
            this.cmb_addEdit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_addExist = new System.Windows.Forms.ComboBox();
            this.btn_ReturnExperience = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_experience
            // 
            this.lbl_experience.AutoSize = true;
            this.lbl_experience.Location = new System.Drawing.Point(256, 159);
            this.lbl_experience.Name = "lbl_experience";
            this.lbl_experience.Size = new System.Drawing.Size(72, 15);
            this.lbl_experience.TabIndex = 4;
            this.lbl_experience.Text = "Experiences:";
            // 
            // txt_selected
            // 
            this.txt_selected.Location = new System.Drawing.Point(256, 177);
            this.txt_selected.Multiline = true;
            this.txt_selected.Name = "txt_selected";
            this.txt_selected.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_selected.Size = new System.Drawing.Size(532, 115);
            this.txt_selected.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Remove Experience From Template:";
            // 
            // cmb_remove
            // 
            this.cmb_remove.FormattingEnabled = true;
            this.cmb_remove.Location = new System.Drawing.Point(12, 269);
            this.cmb_remove.Name = "cmb_remove";
            this.cmb_remove.Size = new System.Drawing.Size(121, 23);
            this.cmb_remove.TabIndex = 0;
            this.cmb_remove.SelectedIndexChanged += new System.EventHandler(this.cmb_remove_SelectedIndexChanged);
            // 
            // cmb_addEdit
            // 
            this.cmb_addEdit.FormattingEnabled = true;
            this.cmb_addEdit.Location = new System.Drawing.Point(12, 225);
            this.cmb_addEdit.Name = "cmb_addEdit";
            this.cmb_addEdit.Size = new System.Drawing.Size(121, 23);
            this.cmb_addEdit.TabIndex = 0;
            this.cmb_addEdit.SelectedIndexChanged += new System.EventHandler(this.cmb_addEdit_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Change Experience and Add to Template:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Add Existing Experience to Template:";
            // 
            // cmb_addExist
            // 
            this.cmb_addExist.FormattingEnabled = true;
            this.cmb_addExist.Location = new System.Drawing.Point(12, 177);
            this.cmb_addExist.Name = "cmb_addExist";
            this.cmb_addExist.Size = new System.Drawing.Size(121, 23);
            this.cmb_addExist.TabIndex = 0;
            this.cmb_addExist.SelectedIndexChanged += new System.EventHandler(this.cmb_addExist_SelectedIndexChanged);
            // 
            // btn_ReturnExperience
            // 
            this.btn_ReturnExperience.Location = new System.Drawing.Point(307, 363);
            this.btn_ReturnExperience.Name = "btn_ReturnExperience";
            this.btn_ReturnExperience.Size = new System.Drawing.Size(127, 23);
            this.btn_ReturnExperience.TabIndex = 4;
            this.btn_ReturnExperience.Text = "Return To Template";
            this.btn_ReturnExperience.UseVisualStyleBackColor = true;
            this.btn_ReturnExperience.Click += new System.EventHandler(this.btn_ReturnExperience_Click);
            // 
            // TemplateExperience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ReturnExperience);
            this.Controls.Add(this.cmb_addExist);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_addEdit);
            this.Controls.Add(this.cmb_remove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_selected);
            this.Controls.Add(this.lbl_experience);
            this.Name = "TemplateExperience";
            this.Text = "Template Experience";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_experience;
        private System.Windows.Forms.TextBox txt_selected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_addEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_addExist;
        private System.Windows.Forms.ComboBox cmb_remove;
        private System.Windows.Forms.Button btn_ReturnExperience;
    }
}