using System;
using System.Collections.Generic;
using System.Text;

namespace HappyTech.BackEnd.DatabaseClasses
{
    public class FeedbackQuestion
    {
        private int m_feedback_question_id;      // Database's feedback_question_id field

        /// <summary>
        /// Getter & Setter for m_feedback_question_id
        /// </summary>
        public int feedback_question_id { get { return m_feedback_question_id; } set { m_feedback_question_id = value; } }


        private int m_question_id;              // Database's question_id field

        /// <summary>
        /// Getter & Setter for m_question_id
        /// </summary>
        public int question_id { get { return m_question_id; } set { m_question_id = value; } }


        private int m_feedback_id;              // Database's feedback_id field

        /// <summary>
        /// Getter & Setter for m_feedback_id
        /// </summary>
        public int feedback_id { get { return m_feedback_id; } set { m_feedback_id = value; } }


        private int m_score;                    // Database's score field

        /// <summary>
        /// Getter & Setter for m_score
        /// </summary>
        public int score { get { return m_score; } set { m_score = value; } }
    }
}
