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
        //TemplateExperienceBackEnd m_templateExperience;           // Associated TemplateExperienceBackEnd
        TemplateSkillsetBackEnd m_templateSkillset;               // Associated TemplateSkillsetBackEnd
        //TemplateTeamworkingBackEnd m_templateTeamworking;         // Associated TemplateTeamworkingBackEnd

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
            //m_templateExperience = new TemplateExperienceBackEnd(this, m_experiences);
            m_templateSkillset = new TemplateSkillsetBackEnd(this, m_skillsets);
            //m_templateTeamworking = new TemplateTeamworkingBackEnd(this, m_teamworkings);
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
            new NewExperience().Show();
        }

        /// <summary>
        /// Open New Skillset
        /// </summary>
        public void NewSkillset()
        {
            //new NewSkillset().Show()
            m_templateSkillset.Open();
        }

        /// <summary>
        /// Open New Teamworking
        /// </summary>
        public void NewTeamworking()
        {
            //new NewTeamworking().Show();
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
            MessageBox.Show("Submitted");
        }
    }
}
