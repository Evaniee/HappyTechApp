namespace HappyTech.FrontEnd
{
    partial class TemplateQuestion
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
            this.cmb_addExist = new System.Windows.Forms.ComboBox();
            this.lbl_addExist = new System.Windows.Forms.Label();
            this.lbl_edit = new System.Windows.Forms.Label();
            this.lbl_addEdit = new System.Windows.Forms.Label();
            this.cmb_addEdit = new System.Windows.Forms.ComboBox();
            this.cmb_remove = new System.Windows.Forms.ComboBox();
            this.lbl_remove = new System.Windows.Forms.Label();
            this.txt_selected = new System.Windows.Forms.TextBox();
            this.lbl_questions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_addExist
            // 
            this.cmb_addExist.FormattingEnabled = true;
            this.cmb_addExist.Location = new System.Drawing.Point(12, 162);
            this.cmb_addExist.Name = "cmb_addExist";
            this.cmb_addExist.Size = new System.Drawing.Size(121, 23);
            this.cmb_addExist.TabIndex = 0;
            this.cmb_addExist.SelectedIndexChanged += new System.EventHandler(this.cmb_addExist_SelectedIndexChanged);
            // 
            // lbl_addExist
            // 
            this.lbl_addExist.AutoSize = true;
            this.lbl_addExist.Location = new System.Drawing.Point(12, 144);
            this.lbl_addExist.Name = "lbl_addExist";
            this.lbl_addExist.Size = new System.Drawing.Size(192, 15);
            this.lbl_addExist.TabIndex = 1;
            this.lbl_addExist.Text = "Add Existing Question to Template:";
            // 
            // lbl_edit
            // 
            this.lbl_edit.AutoSize = true;
            this.lbl_edit.Location = new System.Drawing.Point(12, 192);
            this.lbl_edit.Name = "lbl_edit";
            this.lbl_edit.Size = new System.Drawing.Size(0, 15);
            this.lbl_edit.TabIndex = 2;
            // 
            // lbl_addEdit
            // 
            this.lbl_addEdit.AutoSize = true;
            this.lbl_addEdit.Location = new System.Drawing.Point(12, 192);
            this.lbl_addEdit.Name = "lbl_addEdit";
            this.lbl_addEdit.Size = new System.Drawing.Size(215, 15);
            this.lbl_addEdit.TabIndex = 1;
            this.lbl_addEdit.Text = "Change Question and Add to Template:";
            // 
            // cmb_addEdit
            // 
            this.cmb_addEdit.FormattingEnabled = true;
            this.cmb_addEdit.Location = new System.Drawing.Point(12, 210);
            this.cmb_addEdit.Name = "cmb_addEdit";
            this.cmb_addEdit.Size = new System.Drawing.Size(121, 23);
            this.cmb_addEdit.TabIndex = 0;
            this.cmb_addEdit.SelectedIndexChanged += new System.EventHandler(this.cmb_addEdit_SelectedIndexChanged);
            // 
            // cmb_remove
            // 
            this.cmb_remove.FormattingEnabled = true;
            this.cmb_remove.Location = new System.Drawing.Point(12, 254);
            this.cmb_remove.Name = "cmb_remove";
            this.cmb_remove.Size = new System.Drawing.Size(121, 23);
            this.cmb_remove.TabIndex = 0;
            this.cmb_remove.SelectedIndexChanged += new System.EventHandler(this.cmb_remove_SelectedIndexChanged);
            // 
            // lbl_remove
            // 
            this.lbl_remove.AutoSize = true;
            this.lbl_remove.Location = new System.Drawing.Point(12, 236);
            this.lbl_remove.Name = "lbl_remove";
            this.lbl_remove.Size = new System.Drawing.Size(186, 15);
            this.lbl_remove.TabIndex = 1;
            this.lbl_remove.Text = "Remove Question From Template:";
            // 
            // txt_selected
            // 
            this.txt_selected.Location = new System.Drawing.Point(256, 162);
            this.txt_selected.Multiline = true;
            this.txt_selected.Name = "txt_selected";
            this.txt_selected.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_selected.Size = new System.Drawing.Size(532, 115);
            this.txt_selected.TabIndex = 3;
            // 
            // lbl_questions
            // 
            this.lbl_questions.AutoSize = true;
            this.lbl_questions.Location = new System.Drawing.Point(256, 144);
            this.lbl_questions.Name = "lbl_questions";
            this.lbl_questions.Size = new System.Drawing.Size(63, 15);
            this.lbl_questions.TabIndex = 4;
            this.lbl_questions.Text = "Questions:";
            // 
            // TemplateQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_questions);
            this.Controls.Add(this.txt_selected);
            this.Controls.Add(this.lbl_remove);
            this.Controls.Add(this.cmb_remove);
            this.Controls.Add(this.cmb_addEdit);
            this.Controls.Add(this.lbl_addEdit);
            this.Controls.Add(this.lbl_edit);
            this.Controls.Add(this.lbl_addExist);
            this.Controls.Add(this.cmb_addExist);
            this.Name = "TemplateQuestion";
            this.Text = "NewQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_addExist;
        private System.Windows.Forms.Label lbl_addExist;
        private System.Windows.Forms.Label lbl_edit;
        private System.Windows.Forms.Label lbl_addEdit;
        private System.Windows.Forms.ComboBox cmb_addEdit;
        private System.Windows.Forms.ComboBox cmb_remove;
        private System.Windows.Forms.Label lbl_remove;
        private System.Windows.Forms.TextBox txt_selected;
        private System.Windows.Forms.Label lbl_questions;
    }
}