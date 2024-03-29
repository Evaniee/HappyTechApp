﻿namespace HappyTech.FrontEnd
{
    partial class TemplateSkillset
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
            this.lbl_Subtitle = new System.Windows.Forms.Label();
            this.txt_Requirements = new System.Windows.Forms.TextBox();
            this.lbl_RemoveSkillset = new System.Windows.Forms.Label();
            this.cmb_RemoveSkillset = new System.Windows.Forms.ComboBox();
            this.lbl_EditSkillset = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_AddSkillset = new System.Windows.Forms.Label();
            this.cmb_AddExistSkillset = new System.Windows.Forms.ComboBox();
            this.cmb_EditSkillset = new System.Windows.Forms.ComboBox();
            this.btn_ReturnSkillset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Subtitle
            // 
            this.lbl_Subtitle.AutoSize = true;
            this.lbl_Subtitle.Location = new System.Drawing.Point(256, 159);
            this.lbl_Subtitle.Name = "lbl_Subtitle";
            this.lbl_Subtitle.Size = new System.Drawing.Size(83, 15);
            this.lbl_Subtitle.TabIndex = 4;
            this.lbl_Subtitle.Text = "Requirements:";
            // 
            // txt_Requirements
            // 
            this.txt_Requirements.Location = new System.Drawing.Point(256, 177);
            this.txt_Requirements.Multiline = true;
            this.txt_Requirements.Name = "txt_Requirements";
            this.txt_Requirements.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Requirements.Size = new System.Drawing.Size(532, 115);
            this.txt_Requirements.TabIndex = 3;
            // 
            // lbl_RemoveSkillset
            // 
            this.lbl_RemoveSkillset.AutoSize = true;
            this.lbl_RemoveSkillset.Location = new System.Drawing.Point(12, 251);
            this.lbl_RemoveSkillset.Name = "lbl_RemoveSkillset";
            this.lbl_RemoveSkillset.Size = new System.Drawing.Size(174, 15);
            this.lbl_RemoveSkillset.TabIndex = 1;
            this.lbl_RemoveSkillset.Text = "Remove Skillset From Template:";
            // 
            // cmb_RemoveSkillset
            // 
            this.cmb_RemoveSkillset.FormattingEnabled = true;
            this.cmb_RemoveSkillset.Location = new System.Drawing.Point(12, 269);
            this.cmb_RemoveSkillset.Name = "cmb_RemoveSkillset";
            this.cmb_RemoveSkillset.Size = new System.Drawing.Size(121, 23);
            this.cmb_RemoveSkillset.TabIndex = 0;
            this.cmb_RemoveSkillset.SelectedIndexChanged += new System.EventHandler(this.cmb_RemoveSkillset_SelectedIndexChanged);
            // 
            // lbl_EditSkillset
            // 
            this.lbl_EditSkillset.AutoSize = true;
            this.lbl_EditSkillset.Location = new System.Drawing.Point(12, 207);
            this.lbl_EditSkillset.Name = "lbl_EditSkillset";
            this.lbl_EditSkillset.Size = new System.Drawing.Size(106, 15);
            this.lbl_EditSkillset.TabIndex = 1;
            this.lbl_EditSkillset.Text = "Edit Requirements:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 2;
            // 
            // lbl_AddSkillset
            // 
            this.lbl_AddSkillset.AutoSize = true;
            this.lbl_AddSkillset.Location = new System.Drawing.Point(12, 159);
            this.lbl_AddSkillset.Name = "lbl_AddSkillset";
            this.lbl_AddSkillset.Size = new System.Drawing.Size(168, 15);
            this.lbl_AddSkillset.TabIndex = 1;
            this.lbl_AddSkillset.Text = "Add Requirement to Template:";
            // 
            // cmb_AddExistSkillset
            // 
            this.cmb_AddExistSkillset.FormattingEnabled = true;
            this.cmb_AddExistSkillset.Location = new System.Drawing.Point(12, 177);
            this.cmb_AddExistSkillset.Name = "cmb_AddExistSkillset";
            this.cmb_AddExistSkillset.Size = new System.Drawing.Size(121, 23);
            this.cmb_AddExistSkillset.TabIndex = 0;
            this.cmb_AddExistSkillset.SelectedIndexChanged += new System.EventHandler(this.cmb_AddExistSkillset_SelectedIndexChanged);
            // 
            // cmb_EditSkillset
            // 
            this.cmb_EditSkillset.FormattingEnabled = true;
            this.cmb_EditSkillset.Location = new System.Drawing.Point(12, 225);
            this.cmb_EditSkillset.Name = "cmb_EditSkillset";
            this.cmb_EditSkillset.Size = new System.Drawing.Size(121, 23);
            this.cmb_EditSkillset.TabIndex = 0;
            this.cmb_EditSkillset.SelectedIndexChanged += new System.EventHandler(this.cmb_EditSkillset_SelectedIndexChanged);
            // 
            // btn_ReturnSkillset
            // 
            this.btn_ReturnSkillset.Location = new System.Drawing.Point(332, 365);
            this.btn_ReturnSkillset.Name = "btn_ReturnSkillset";
            this.btn_ReturnSkillset.Size = new System.Drawing.Size(127, 23);
            this.btn_ReturnSkillset.TabIndex = 4;
            this.btn_ReturnSkillset.Text = "Return To Template";
            this.btn_ReturnSkillset.UseVisualStyleBackColor = true;
            this.btn_ReturnSkillset.Click += new System.EventHandler(this.btn_ReturnSkillset_Click);
            // 
            // TemplateSkillset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_EditSkillset);
            this.Controls.Add(this.cmb_AddExistSkillset);
            this.Controls.Add(this.lbl_AddSkillset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_EditSkillset);
            this.Controls.Add(this.cmb_RemoveSkillset);
            this.Controls.Add(this.lbl_RemoveSkillset);
            this.Controls.Add(this.txt_Requirements);
            this.Controls.Add(this.lbl_Subtitle);
            this.Controls.Add(this.btn_ReturnSkillset);
            this.Name = "TemplateSkillset";
            this.Text = "Template Skillset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Subtitle;
        private System.Windows.Forms.TextBox txt_Requirements;
        private System.Windows.Forms.Label lbl_RemoveSkillset;
        private System.Windows.Forms.ComboBox cmb_RemoveSkillset;
        private System.Windows.Forms.Label lbl_EditSkillset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_AddSkillset;
        private System.Windows.Forms.ComboBox cmb_AddExistSkillset;
        private System.Windows.Forms.ComboBox cmb_EditSkillset;
        private System.Windows.Forms.Button btn_ReturnSkillset;
    }
}