﻿using HappyTech.BackEnd.DatabaseClasses;
using System;
using System.Collections.Generic;
using System.Text;
using HappyTech.FrontEnd;

namespace HappyTech.BackEnd.FormBackEnds
{
    public class NewQuestionBackEnd
    {
        NewQuestion m_frontend;                                 // Associated Front End
        TemplateQuestionBackEnd m_templateQuestionBackEnd;      // Associated Template Question Back End

        /// <summary>
        /// Constructor for NewQuestionBackEnd
        /// </summary>
        /// <param name="a_frontEnd">Associated Front End</param>
        /// <param name="a_templateQuestionBackEnd">Associated template question back end</param>
        public NewQuestionBackEnd(NewQuestion a_frontEnd, TemplateQuestionBackEnd a_templateQuestionBackEnd)
        {
            m_frontend = a_frontEnd;
            m_frontend.Connect(this);
            m_templateQuestionBackEnd = a_templateQuestionBackEnd;
        }

        /// <summary>
        /// Return fields to populate form with
        /// </summary>
        /// <param name="a_question">Question to populate using</param>
        public void Populate(Question a_question)
        {
            m_frontend.Populate(a_question.question, a_question.response1, a_question.response2, a_question.response3, a_question.response4, a_question.response5);
        }

        /// <summary>
        /// Submit a question to the database
        /// </summary>
        /// <param name="a_question">Question of new question</param>
        /// <param name="a_response1">Response 1 of new question</param>
        /// <param name="a_response2">Response 2 of new question</param>
        /// <param name="a_response3">Response 3 of new question</param>
        /// <param name="a_response4">Response 4 of new question</param>
        /// <param name="a_response5">Response 5 of new question</param>
        public void Submit(string a_question, string a_response1, string a_response2, string a_response3, string a_response4, string a_response5)
        {
            string a_insertSQL = "INSERT INTO questions VALUES (null, '" + a_question + "', '" + a_response1 + "', '" + a_response2 + "', '" + a_response3 + "', '" + a_response4 + "', '" + a_response5 + "');";
            BuisnessMetaLayer.Instance.Insert(a_insertSQL);
            List<Question> l_allQuestions = BuisnessMetaLayer.Instance.GetDBQuestion();
            List<Question> l_questions = l_allQuestions.FindAll(x => x.question == a_question);
            Question l_question = null;
            if (l_questions.Count > 1)
            {
                foreach (Question i_question in l_questions)
                {
                    if (i_question.response1 == a_response1)
                        if (i_question.response2 == a_response2)
                            if (i_question.response3 == a_response3)
                                if (i_question.response4 == a_response4)
                                    if (i_question.response5 == a_response5)
                                    {
                                        l_question = i_question;
                                        break;
                                    }
                }
            }
            else
                l_question = l_questions[0];
            m_templateQuestionBackEnd.AddQuestion(l_question);
            m_frontend.Close();
        }
    }
}
