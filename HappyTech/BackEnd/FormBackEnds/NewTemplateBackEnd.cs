using HappyTech.BackEnd.DatabaseClasses;
using HappyTech.FrontEnd;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace HappyTech.BackEnd.FormBackEnds
{
    public class NewTemplateBackEnd
    {
        NewTemplate m_frontEnd;                                     // Associated Front End
        TemplateQuestionBackEnd m_templateQuestion;                 // Associated TemplateQuestionBackEnd
        TemplateExperienceBackEnd m_templateExperience;             // Associated TemplateExperienceBackEnd
        TemplateSkillsetBackEnd m_templateSkillset;                 // Associated TemplateSkillsetBackEnd
        TemplateTeamworkingBackEnd m_templateTeamworking;           // Associated TemplateTeamworkingBackEnd

        private List<Question> m_questions;                         // Template's questions
        private List<Experience> m_experiences;                     // Template's experiences
        private List<Skillset> m_skillsets;                         // Template's skillsets
        private List<Teamworking> m_teamworkings;                   // Template's teamworkings


        public NewTemplateBackEnd(NewTemplate a_frontEnd)
        {
            m_questions = new List<Question>();
            m_experiences = new List<Experience>();
            m_skillsets = new List<Skillset>();
            m_teamworkings = new List<Teamworking>();
            m_frontEnd = a_frontEnd;                                            
            m_frontEnd.Connect(this);
            m_templateQuestion = new TemplateQuestionBackEnd(this, m_questions);
            m_templateExperience = new TemplateExperienceBackEnd(this, m_experiences);
            m_templateSkillset = new TemplateSkillsetBackEnd(this, m_skillsets);
            m_templateTeamworking = new TemplateTeamworkingBackEnd(this, m_teamworkings);
        }

        /// <summary>
        /// Open New Question
        /// </summary>
        public void NewQuestion()
        {
            m_templateQuestion.Open();
        }

        /// <summary>
        /// Open New Experience
        /// </summary>
        public void NewExperience()
        {
            m_templateExperience.Open();
        }

        /// <summary>
        /// Open New Skillset
        /// </summary>
        public void NewSkillset()
        {
            m_templateSkillset.Open();
        }

        /// <summary>
        /// Open New Teamworking
        /// </summary>
        public void NewTeamworking()
        {
            m_templateTeamworking.Open();
        }

        /// <summary>
        /// Update questions with new values
        /// </summary>
        /// <param name="a_questions">New Value of template's questions</param>
        public void UpdateQuestions(List<Question> a_questions)
        {
            m_questions = a_questions;
        }

        /// <summary>
        /// Update experiences with new values
        /// </summary>
        /// <param name="a_experiences">New Value of template's experiences</param>
        public void UpdateExperiences(List<Experience> a_experiences)
        {
            m_experiences = a_experiences;
        }

        /// <summary>
        /// Update skillsets with new values
        /// </summary>
        /// <param name="a_skillsets">New Value of template's skillsets</param>
        public void UpdateSkillset(List<Skillset> a_skillsets)
        {
            m_skillsets = a_skillsets;
        }

        /// <summary>
        /// Update teamworkings with new values
        /// </summary>
        /// <param name="a_teamworkings">New Value of template's teamworkings</param>
        public void UpdateTeamworking(List<Teamworking> a_teamworkings)
        {
            m_teamworkings = a_teamworkings;
        }

        public void Submit()
        {
            // Add Template
            string l_sqlString = "INSERT INTO happy_tech.template VALUES (null, '" + m_frontEnd.TemplateTitle + "');";
            BuisnessMetaLayer.Instance.Insert(l_sqlString);
            
            // Find Template
            Template l_insertedTemplate = BuisnessMetaLayer.Instance.GetDBTemplate().Find(x => x.title == m_frontEnd.TemplateTitle);

            // Add Questions
            foreach(Question i_question in m_questions)
            {
                l_sqlString = "INSERT INTO happy_tech.template_questions VALUES (null, " + l_insertedTemplate.template_id + ", " + i_question.question_id + ");";
                BuisnessMetaLayer.Instance.Insert(l_sqlString);
            }

            // Add Experiences
            foreach (Experience i_experience in m_experiences)
            {
                l_sqlString = "INSERT INTO happy_tech.template_experience VALUES (null, " + l_insertedTemplate.template_id + ", " + i_experience.experience_id + ");";
                BuisnessMetaLayer.Instance.Insert(l_sqlString);
            }

            // Add Skillsets
            foreach (Skillset i_skillset in m_skillsets)
            {
                l_sqlString = "INSERT INTO happy_tech.template_skillset VALUES (null, " + l_insertedTemplate.template_id + ", " + i_skillset.skillset_id + ");";
                BuisnessMetaLayer.Instance.Insert(l_sqlString);
            }

            // Add Teamworkings
            foreach (Teamworking i_teamworking in m_teamworkings)
            {
                l_sqlString = "INSERT INTO happy_tech.template_teamworking VALUES (null, " + l_insertedTemplate.template_id + ", " + i_teamworking.teamworking_id + ");";
                BuisnessMetaLayer.Instance.Insert(l_sqlString);
            }
            MessageBox.Show("Submitted!");
            m_frontEnd.Close();
        }
    }
}
