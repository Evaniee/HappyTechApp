using HappyTech.BackEnd.DatabaseClasses;
using HappyTech.BackEnd.FormBackEnds;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HappyTech.FrontEnd
{
    public partial class NewSkillset : Form
    {
        NewSkillsetBackEnd m_newSkillsetBackEnd;

        public NewSkillset(TemplateSkillsetBackEnd a_templateSkillsetBackEnd, Skillset a_skillset)
        {
            new NewSkillsetBackEnd(this, a_templateSkillsetBackEnd);
            InitializeComponent();
            m_newSkillsetBackEnd.Populate(a_skillset);
        }

        public void Connect(NewSkillsetBackEnd a_newSkillsetBackEnd)
        {
            m_newSkillsetBackEnd = a_newSkillsetBackEnd;
        }

        public void Populate(string a_skillset)
        {
            if (a_skillset != null)
                txt_Skillset.Text = a_skillset;
        }

        public NewSkillsetBackEnd BackEnd
        {
            get
            {
                return m_newSkillsetBackEnd;
            }
        }

        private void btn_Submit_Click_1(object sender, EventArgs e)
        {
            m_newSkillsetBackEnd.Submit(txt_Skillset.Text);
        }
    }
}
