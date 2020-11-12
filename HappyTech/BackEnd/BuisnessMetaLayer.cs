using HappyTech.BackEnd.DatabaseClasses;
using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace HappyTech.BackEnd
{
    public class BuisnessMetaLayer
    {
        private static BuisnessMetaLayer m_instance;        // Current instance of the BuisnessMetaLayer Singleton

        /// <summary>
        /// Private constructor for BuisnessMetaLayer Singleton to force singleton behaviour
        /// </summary>
        private BuisnessMetaLayer()
        {

        }

        /// <summary>
        /// Gets the current instance of the BuisnessMetaLayer Singletone or makes one if it does not exist
        /// </summary>
        public static BuisnessMetaLayer Instance 
        {
            get
            {
                if (m_instance == null)
                    m_instance = new BuisnessMetaLayer();
                return m_instance;
            }
        }

        #region Question Classes From Database

        /// <summary>
        /// Gets all Questions from the questions table
        /// </summary>
        /// <returns>List of Questions</returns>
        public List<Question> GetDBQuestion()
        {
            // Open Connection and Read from Database
            if (DatabaseConnection.Instance.Open())
            {
                List<Question> l_questions = new List<Question>();
                MySqlDataReader l_dataReader = DatabaseConnection.Instance.Select("SELECT * FROM questions;");

                while (l_dataReader.Read())
                {
                    Question l_question = new Question();
                    l_question.question_id = l_dataReader.GetInt32(0);
                    l_question.question = l_dataReader.GetString(1);
                    l_question.response1 = l_dataReader.GetString(2);
                    l_question.response2 = l_dataReader.GetString(3);
                    l_question.response3 = l_dataReader.GetString(4);
                    l_question.response4 = l_dataReader.GetString(5);
                    l_question.response5 = l_dataReader.GetString(6);
                    l_questions.Add(l_question);
                }
                l_dataReader.Close();
                DatabaseConnection.Instance.Close();
                return l_questions;
            }
            return null;
        }

        /// <summary>
        /// Gets all FeedbackQuestions from the feedback_questions table
        /// </summary>
        /// <returns>List of FeedbackQuestions</returns>
        public List<FeedbackQuestion> GetDBFeedbackQuestion()
        {
            // Open Connection and Read from Database
            if (DatabaseConnection.Instance.Open())
            {
                List<FeedbackQuestion> l_feedbackQuestions = new List<FeedbackQuestion>();
                MySqlDataReader l_dataReader = DatabaseConnection.Instance.Select("SELECT * FROM feedback_questions;");

                while (l_dataReader.Read())
                {
                    FeedbackQuestion l_feedbackQuestion = new FeedbackQuestion();
                    l_feedbackQuestion.feedback_question_id = l_dataReader.GetInt32(0);
                    l_feedbackQuestion.feedback_id = l_dataReader.GetInt32(1);
                    l_feedbackQuestion.question_id = l_dataReader.GetInt32(2);
                    l_feedbackQuestion.score = l_dataReader.GetInt32(2);
                    l_feedbackQuestions.Add(l_feedbackQuestion);
                }
                l_dataReader.Close();
                DatabaseConnection.Instance.Close();
                return l_feedbackQuestions;
            }
            return null;
        }

        /// <summary>
        /// Gets all TemplateQuestions from the template_questions table
        /// </summary>
        /// <returns>List of TemplateQuestions</returns>
        public List<TemplateQuestion> GetDBTemplateQuestion()
        {
            // Open Connection and Read from Database
            if (DatabaseConnection.Instance.Open())
            {
                List<TemplateQuestion> l_templateQuestions = new List<TemplateQuestion>();
                MySqlDataReader l_dataReader = DatabaseConnection.Instance.Select("SELECT * FROM template_questions;");

                while (l_dataReader.Read())
                {
                    TemplateQuestion l_templateQuestion = new TemplateQuestion();
                    l_templateQuestion.template_question_id = l_dataReader.GetInt32(0);
                    l_templateQuestion.template_id = l_dataReader.GetInt32(1);
                    l_templateQuestion.question_id = l_dataReader.GetInt32(2);
                    l_templateQuestions.Add(l_templateQuestion);
                }
                l_dataReader.Close();
                DatabaseConnection.Instance.Close();
                return l_templateQuestions;
            }
            return null;
        }

        #endregion

        #region Experience Classes From Database

        /// <summary>
        /// Gets all Experiences from the feedback_experience table
        /// </summary>
        /// <returns>List of Experience</returns>
        public List<Experience> GetDBExperience()
        {
            // Open Connection and Read from Database
            if (DatabaseConnection.Instance.Open())
            {
                List<Experience> l_experiences = new List<Experience>();
                MySqlDataReader l_dataReader = DatabaseConnection.Instance.Select("SELECT * FROM experience;");

                while (l_dataReader.Read())
                {
                    Experience l_experience = new Experience();
                    l_experience.experience_id = l_dataReader.GetInt32(0);
                    l_experience.experience = l_dataReader.GetString(1);
                    l_experience.response1 = l_dataReader.GetString(2);
                    l_experience.response2 = l_dataReader.GetString(3);
                    l_experience.response3 = l_dataReader.GetString(4);
                    l_experience.response4 = l_dataReader.GetString(5);
                    l_experience.response5 = l_dataReader.GetString(6);
                    l_experiences.Add(l_experience);
                }
                l_dataReader.Close();
                DatabaseConnection.Instance.Close();
                return l_experiences;
            }
            return null;
        }

        /// <summary>
        /// Gets all FeedbackExperiences from the feedback_experiences table
        /// </summary>
        /// <returns>List of FeedbackExperience</returns>
        public List<FeedbackExperience> GetDBFeedbackExperience()
        {
            // Open Connection and Read from Database
            if (DatabaseConnection.Instance.Open())
            {
                List<FeedbackExperience> l_feedbackExperiences = new List<FeedbackExperience>();
                MySqlDataReader l_dataReader = DatabaseConnection.Instance.Select("SELECT * FROM feedback_experience;");

                while (l_dataReader.Read())
                {
                    FeedbackExperience l_feedbackExperience = new FeedbackExperience();
                    l_feedbackExperience.feedback_experience_id = l_dataReader.GetInt32(0);
                    l_feedbackExperience.feedback_id = l_dataReader.GetInt32(1);
                    l_feedbackExperience.experience_id = l_dataReader.GetInt32(2);
                    l_feedbackExperience.score = l_dataReader.GetInt32(2);
                    l_feedbackExperiences.Add(l_feedbackExperience);
                }
                l_dataReader.Close();
                DatabaseConnection.Instance.Close();
                return l_feedbackExperiences;
            }
            return null; 
        }

        /// <summary>
        /// Gets all TemplateExperiences from the template_experience table
        /// </summary>
        /// <returns>List of TemplateExperience</returns>
        public List<TemplateExperience> GetDBTemplateExperience()
        {
            // Open Connection and Read from Database
            if (DatabaseConnection.Instance.Open())
            {
                List<TemplateExperience> l_templateExperiences = new List<TemplateExperience>();
                MySqlDataReader l_dataReader = DatabaseConnection.Instance.Select("SELECT * FROM template_experience;");

                while (l_dataReader.Read())
                {
                    TemplateExperience l_templateExperience = new TemplateExperience();
                    l_templateExperience.template_experience_id = l_dataReader.GetInt32(0);
                    l_templateExperience.template_id = l_dataReader.GetInt32(1);
                    l_templateExperience.experience_id = l_dataReader.GetInt32(2);
                    l_templateExperiences.Add(l_templateExperience);
                }
                l_dataReader.Close();
                DatabaseConnection.Instance.Close();
                return l_templateExperiences;
            }
            return null;
        }

        #endregion

        #region Skillset Classes From Database

        public List<Skillset> GetDBSkillset()
        {
            // Open Connection and Read from Database
            if (DatabaseConnection.Instance.Open())
            {
                List<Skillset> l_skillsets = new List<Skillset>();
                MySqlDataReader l_dataReader = DatabaseConnection.Instance.Select("SELECT * FROM skillset;");

                while (l_dataReader.Read())
                {
                    Skillset l_skillset = new Skillset();
                    l_skillset.skillset_id = l_dataReader.GetInt32(0);
                    l_skillset.skillset = l_dataReader.GetString(1);
                    l_skillsets.Add(l_skillset);
                }
                l_dataReader.Close();
                DatabaseConnection.Instance.Close();
                return l_skillsets;
            }
            return null;
        }

        public List<FeedbackSkillset> GetDBFeedbackSkillset()
        {
            // Open Connection and Read from Database
            if (DatabaseConnection.Instance.Open())
            {
                List<FeedbackSkillset> l_feedbackSkillsets = new List<FeedbackSkillset>();
                MySqlDataReader l_dataReader = DatabaseConnection.Instance.Select("SELECT * FROM feedback_skillset;");

                while (l_dataReader.Read())
                {
                    FeedbackSkillset l_feedbackSkillset = new FeedbackSkillset();
                    l_feedbackSkillset.feedback_skillset_id = l_dataReader.GetInt32(0);
                    l_feedbackSkillset.feedback_id = l_dataReader.GetInt32(1);
                    l_feedbackSkillset.skillset_id = l_dataReader.GetInt32(2);
                    l_feedbackSkillset.achieved = l_dataReader.GetBoolean(2);
                    l_feedbackSkillsets.Add(l_feedbackSkillset);
                }
                l_dataReader.Close();
                DatabaseConnection.Instance.Close();
                return l_feedbackSkillsets;
            }
            return null;
        }

        public List<TemplateSkillset> GetDBTemplateSkillset()
        {
            // Open Connection and Read from Database
            if (DatabaseConnection.Instance.Open())
            {
                List<TemplateSkillset> l_templateSkillsets = new List<TemplateSkillset>();
                MySqlDataReader l_dataReader = DatabaseConnection.Instance.Select("SELECT * FROM template_skillset;");

                while (l_dataReader.Read())
                {
                    TemplateSkillset l_templateSkillset = new TemplateSkillset();
                    l_templateSkillset.template_skillset_id = l_dataReader.GetInt32(0);
                    l_templateSkillset.template_id = l_dataReader.GetInt32(1);
                    l_templateSkillset.skillset_id = l_dataReader.GetInt32(2);
                    l_templateSkillsets.Add(l_templateSkillset);
                }
                l_dataReader.Close();
                DatabaseConnection.Instance.Close();
                return l_templateSkillsets;
            }
            return null;
        }

        #endregion

        #region Teamworking Classes From Database

        public List<Teamworking> GetDBTeamworking()
        {
            // Open Connection and Read from Database
            if (DatabaseConnection.Instance.Open())
            {
                List<Teamworking> l_teamworkings = new List<Teamworking>();
                MySqlDataReader l_dataReader = DatabaseConnection.Instance.Select("SELECT * FROM teamworking;");

                while (l_dataReader.Read())
                {
                    Teamworking l_teamworking = new Teamworking();
                    l_teamworking.teamworking_id = l_dataReader.GetInt32(0);
                    l_teamworking.teamworking = l_dataReader.GetString(1);
                    l_teamworkings.Add(l_teamworking);
                }
                l_dataReader.Close();
                DatabaseConnection.Instance.Close();
                return l_teamworkings;
            }
            return null;
        }

        public List<FeedbackTeamworking> GetDBFeedbackTeamworking()
        {
            if (DatabaseConnection.Instance.Open())
            {
                List<FeedbackTeamworking> l_feedbackTeamworkings = new List<FeedbackTeamworking>();
                MySqlDataReader l_dataReader = DatabaseConnection.Instance.Select("SELECT * FROM feedback_teamworking;");

                while (l_dataReader.Read())
                {
                    FeedbackTeamworking l_feedbackTeamworking = new FeedbackTeamworking();
                    l_feedbackTeamworking.feedback_teamworking_id = l_dataReader.GetInt32(0);
                    l_feedbackTeamworking.feedback_id = l_dataReader.GetInt32(1);
                    l_feedbackTeamworking.teamworking_id = l_dataReader.GetInt32(2);
                    l_feedbackTeamworking.achieved = l_dataReader.GetBoolean(2);
                    l_feedbackTeamworkings.Add(l_feedbackTeamworking);
                }
                l_dataReader.Close();
                DatabaseConnection.Instance.Close();
                return l_feedbackTeamworkings;
            }
            return null;
        }

        public List<TemplateTeamworking> GetDBTemplateTeamworking()
        {
            if (DatabaseConnection.Instance.Open())
            {
                List<TemplateTeamworking> l_templateTeamworkings = new List<TemplateTeamworking>();
                MySqlDataReader l_dataReader = DatabaseConnection.Instance.Select("SELECT * FROM template_Teamworking;");

                while (l_dataReader.Read())
                {
                    TemplateTeamworking l_templateTeamworking = new TemplateTeamworking();
                    l_templateTeamworking.template_teamworking_id = l_dataReader.GetInt32(0);
                    l_templateTeamworking.template_id = l_dataReader.GetInt32(1);
                    l_templateTeamworking.teamworking_id = l_dataReader.GetInt32(2);
                    l_templateTeamworkings.Add(l_templateTeamworking);
                }
                l_dataReader.Close();
                DatabaseConnection.Instance.Close();
                return l_templateTeamworkings;
            }
            return null;
        }

        #endregion

        #region Job / Applicant Related Classes From Database

        //public List<Applicant> GetDBApplicant()
        //{

        //}

        //public List<JobApplication> GetDBJobApplications()
        //{

        //}

        public List<JobPosition> GetDBJobPositions()
        {
            // Open Connection and Read from Database
            if (DatabaseConnection.Instance.Open())
            {
                List<JobPosition> l_jobPositions = new List<JobPosition>();
                MySqlDataReader l_dataReader = DatabaseConnection.Instance.Select("SELECT * FROM job_position;");

                while (l_dataReader.Read())
                {
                    JobPosition l_jobPosition = new JobPosition();
                    l_jobPosition.job_code = l_dataReader.GetString(0);
                    l_jobPosition.template_id = l_dataReader.GetInt32(1);
                    l_jobPosition.title = l_dataReader.GetString(2);
                    l_jobPosition.description = l_dataReader.GetString(3);
                    l_jobPositions.Add(l_jobPosition);
                }
                l_dataReader.Close();
                DatabaseConnection.Instance.Close();
                return l_jobPositions;
            }
            return null;
        }

        #endregion

        #region Other Classes From Database

        //public List<Feedback> GetDBFeedback()
        //{

        //}

        /// <summary>
        /// Gets all Templates from the template table
        /// </summary>
        /// <returns>List of Templates</returns>
        public List<Template> GetDBTemplate()
        {
            // Open Connection and Read from Database
            if (DatabaseConnection.Instance.Open())
            {
                List<Template> l_templates = new List<Template>();
                MySqlDataReader l_dataReader = DatabaseConnection.Instance.Select("SELECT * FROM template;");

                while (l_dataReader.Read())
                {
                    Template l_template = new Template();
                    l_template.template_id = l_dataReader.GetInt32(0);
                    l_template.title = l_dataReader.GetString(1);
                    l_templates.Add(l_template);
                }
                l_dataReader.Close();
                DatabaseConnection.Instance.Close();
                return l_templates;
            }
            return null;
        }

        //public List<Login> GetDBLogins()
        //{

        //}

        #endregion

        #region Generic SQLs

        public bool Insert(string a_insertSQL)
        {
            return DatabaseConnection.Instance.Insert(a_insertSQL);
        }

        public bool Update(string a_updateSQL)
        {
            return DatabaseConnection.Instance.Update(a_updateSQL);
        }

        public bool Delete(string a_deleteSQL)
        {
            return DatabaseConnection.Instance.Delete(a_deleteSQL);
        }

        public MySqlDataReader Select(string a_selectSQL)
        {
            return DatabaseConnection.Instance.Select(a_selectSQL);
        }

        #endregion

        
    }
}
