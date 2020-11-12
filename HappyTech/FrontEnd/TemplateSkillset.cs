using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HappyTech.BackEnd;
using HappyTech.BackEnd.DatabaseClasses;
using HappyTech.BackEnd.FormBackEnds;

namespace HappyTech.FrontEnd
{
    public partial class TemplateSkillset : Form
    {
        private TemplateSkillsetBackEnd m_templateSkillsetBackEnd;          
        private bool m_update;

        public TemplateSkillset(TemplateSkillsetBackEnd a_templateSkillsetBackEnd)
        {
            m_templateSkillsetBackEnd = a_templateSkillsetBackEnd;
            InitializeComponent();
            m_templateSkillsetBackEnd.Connect(this);
            m_templateSkillsetBackEnd.UpdateFrontEnd();
        }

        public void Update(List<string> a_addValues, List<string> a_editValues, List<string> a_removeValues, string a_textBoxValue)
        {
            m_update = true;
            cmb_AddExistSkillset.DataSource = a_addValues;
            cmb_EditSkillset.DataSource = a_editValues;
            cmb_RemoveSkillset.DataSource = a_removeValues;
            txt_Requirements.Text = a_textBoxValue;
            m_update = false;
        }

        private void cmb_AddExistSkillset_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Prevents occuring when updating datasource
            if (!m_update)
                m_templateSkillsetBackEnd.AddNewSkillset(cmb_AddExistSkillset.Text);
        }

        private void cmb_EditSkillset_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Prevents occuring when updating datasource
            if (!m_update)
                m_templateSkillsetBackEnd.AddExistingSkillset(cmb_EditSkillset.Text);
        }

        private void cmb_RemoveSkillset_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Prevents occuring when updating datasource
            if (!m_update)
                m_templateSkillsetBackEnd.RemoveSkillset(cmb_RemoveSkillset.Text);
        }

        public TemplateSkillsetBackEnd BackEnd 
        { 
            get 
            { 
                return m_templateSkillsetBackEnd; 
            } 
        }







        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
