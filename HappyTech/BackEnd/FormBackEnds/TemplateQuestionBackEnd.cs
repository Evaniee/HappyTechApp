using HappyTech.BackEnd.DatabaseClasses;
using HappyTech.FrontEnd;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Text;
using System.Windows.Forms;

namespace HappyTech.BackEnd.FormBackEnds
{
    public class TemplateQuestionBackEnd
    {
        FrontEnd.TemplateQuestion m_frontEnd;           // Associated Front End
        NewTemplateBackEnd m_newTemplateBackEnd;        // NewTemplateBackEnd to inform
        List<Question> m_questions;                     // Template's questions

        /// <summary>
        /// Constructor for TemplateQuestionBackEnd
        /// </summary>
        /// <param name="a_newTemplateBackEnd">NewTemplateBackEnd to inform</param>
        public TemplateQuestionBackEnd(NewTemplateBackEnd a_newTemplateBackEnd, List<Question> a_questions)
        {
            m_questions = a_questions;
            new FrontEnd.TemplateQuestion(this);
            m_newTemplateBackEnd = a_newTemplateBackEnd;            
        }

        /// <summary>
        /// connection method linking back end to front end
        /// </summary>
        /// <param name="a_templateQuestion">database class for templateQuestion</param>
        public void Connect(FrontEnd.TemplateQuestion a_templateQuestion)
        {
            m_frontEnd = a_templateQuestion;
        }

        /// <summary>
        /// calls front end to open
        /// </summary>
        public void Open()
        {
            m_frontEnd.Show();
            UpdateFrontEnd();
        }

        /// <summary>
        /// Add a new question or a question from the database to the template
        /// </summary>
        /// <param name="a_questionString"></param>
        public void AddNewQuestion(string a_questionString)
        {
            // For Question in DB
            if (a_questionString != "New Question")
            {
                string[] l_questionArray = a_questionString.Split(':');
                int l_questionID = int.Parse(l_questionArray[0]);
                List<Question> l_allQuestions = BuisnessMetaLayer.Instance.GetDBQuestion();
                Question l_question = l_allQuestions.Find(x => x.question_id == l_questionID);
                m_questions.Add(l_question);
                UpdateFrontEnd();
            }
            // For new Question
            else
                AddExistingQuestion(null);
        }

        /// <summary>
        /// Add a alternative version of an existing question to the template
        /// </summary>
        /// <param name="a_questionString">Question as a string</param>
        public void AddExistingQuestion(string a_questionString)
        {
            Question l_question = new Question();

            // If not a new question
            if(a_questionString != null)
            {
                string[] l_questionArray = a_questionString.Split(':');
                int l_questionID = int.Parse(l_questionArray[0]);
                List<Question> l_allQuestions = BuisnessMetaLayer.Instance.GetDBQuestion();
                l_question = l_allQuestions.Find(x => x.question_id == l_questionID);
            }
            new FrontEnd.NewQuestion(this, l_question).Show();
        }

        /// <summary>
        /// Remove a question from the template
        /// </summary>
        /// <param name="a_questionString">Question as a strng</param>
        public void RemoveQuestion(string a_questionString)
        {
            string[] l_questionArray = a_questionString.Split(':');
            int l_questionID = int.Parse(l_questionArray[0]);
            List<Question> l_questions = BuisnessMetaLayer.Instance.GetDBQuestion();
            Question l_question = l_questions.Find(x => x.question_id == l_questionID);
            DialogResult l_remove = MessageBox.Show("Remove Question From Template?:\n" + l_question.question_id + ": " + l_question.question, "Delete Question?", MessageBoxButtons.YesNo);
            if (l_remove == DialogResult.Yes)
            {
                m_questions.RemoveAll(x => x.question_id == l_questionID);
            }
            UpdateFrontEnd();
            UpdateNewTemplate();
        }

        /// <summary>
        /// Update new template back end with new values
        /// </summary>
        public void UpdateNewTemplate()
        {
            m_newTemplateBackEnd.UpdateQuestions(m_questions);
        }

        /// <summary>
        /// adds Question from Question database class
        /// </summary>
        /// <param name="a_question">Question as a value</param>
        public void AddQuestion(Question a_question)
        {
            m_questions.Add(a_question);
            UpdateNewTemplate();
            UpdateFrontEnd();
        }

        /// <summary>
        /// Provides new values to update combo boxes on front end
        /// </summary>
        /// <returns>Tuple containing AddValues, EditValues and RemoveValues</returns>
        public void UpdateFrontEnd()
        {
            // All questions in Database
            List<Question> l_allQuestions = BuisnessMetaLayer.Instance.GetDBQuestion();

            // Add
            // Add all values not present in m_questions and new
            List<string> l_addValues = new List<string>();
            l_addValues.Add("New Question");
            foreach (Question i_question in l_allQuestions)
                if (m_questions.Find(x => x.question_id == i_question.question_id) == null)
                    l_addValues.Add(i_question.question_id + ": " + i_question.question + "\n");

            // Edit
            // Add all values
            List<string> l_editValues = new List<string>();
            foreach (Question i_question in l_allQuestions)
                l_editValues.Add(i_question.question_id + ": " + i_question.question);

            // Remove
            // Add all present values
            List<string> l_removeValues = new List<string>();
            foreach (Question i_question in m_questions)
                l_removeValues.Add(i_question.question_id + ": " + i_question.question);

            // Text Box
            // Title + all present values
            StringBuilder l_textValue = new StringBuilder();
            foreach (Question i_question in m_questions)
                l_textValue.Append(Environment.NewLine + i_question.question_id + ": " + i_question.question);
            l_textValue.Append("");
            string l_textBoxValue = l_textValue.ToString();
            l_textValue.Clear();

            m_frontEnd.Update(l_addValues, l_editValues, l_removeValues, l_textBoxValue);
        }
    }
}
