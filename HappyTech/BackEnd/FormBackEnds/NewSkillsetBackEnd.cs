using HappyTech.BackEnd.DatabaseClasses;
using System;
using System.Collections.Generic;
using System.Text;
using HappyTech.FrontEnd;

namespace HappyTech.BackEnd.FormBackEnds
{
    public class NewSkillsetBackEnd
    {
        NewSkillset m_frontend;                                 // Associated Front End
        TemplateSkillsetBackEnd m_templateSkillsetBackEnd;

        public NewSkillsetBackEnd(NewSkillset a_frontEnd, TemplateSkillsetBackEnd a_templateSkillsetBackEnd)
        {
            m_frontend = a_frontEnd;
            m_frontend.Connect(this);
            m_templateSkillsetBackEnd = a_templateSkillsetBackEnd;
        }

        public void Populate(Skillset a_skillset)
        {
            m_frontend.Populate(a_skillset.skillset);
        }

        public void Submit(string a_skillset)
        {
            string a_insertSQL = "INSERT INTO skillset VALUES (null, '" + a_skillset + "');";
            BuisnessMetaLayer.Instance.Insert(a_insertSQL);
            List<Skillset> l_allSkillsets = BuisnessMetaLayer.Instance.GetDBSkillset();
            List<Skillset> l_skillsets = l_allSkillsets.FindAll(x => x.skillset == a_skillset);
            Skillset l_skillset = null;
            if (l_skillsets.Count > 1)
            {
                foreach (Skillset i_skillset in l_skillsets)
                {

                    l_skillset = i_skillset;
                    break;
           
                }
            }
            else
                l_skillset = l_skillsets[0];
            m_templateSkillsetBackEnd.AddSkillset(l_skillset);
            m_frontend.Close();
        }
    }


}
