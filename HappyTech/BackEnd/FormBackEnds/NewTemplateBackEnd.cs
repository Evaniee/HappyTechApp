using HappyTech.BackEnd.DatabaseClasses;
using HappyTech.FrontEnd;
using System;
using System.Collections.Generic;
using System.Text;

namespace HappyTech.BackEnd.FormBackEnds
{
    public class NewTemplateBackEnd
    {
        private List<Question> m_questions;
        private List<Experience> m_experiences;
        private List<Skillset> m_skillsets;
        //private List<Teamworking> m_teamworkings;


        public NewTemplateBackEnd()
        {
            m_questions = new List<Question>();
            m_experiences = new List<Experience>();
            m_skillsets = new List<Skillset>();
            //m_teamworkings = new List<Teamworking>();
        }

        public void NewQuestion()
        {
            new FrontEnd.TemplateQuestion().Show();
        }

        public void NewExperience()
        {
            new NewExperience().Show();
        }

        public void NewSkillset()
        {
            //new NewSkillset().Show();
        }

        public void NewTeamworking()
        {
            //new NewTeamworking().Show();
        }

    }
}
