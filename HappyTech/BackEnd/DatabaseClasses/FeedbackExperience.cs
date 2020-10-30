using System;
using System.Collections.Generic;
using System.Text;

namespace HappyTech.BackEnd.DatabaseClasses
{
    public class FeedbackExperience
    {
        private int m_feedback_experience_id;       // Database's feedback_experience_id field

        /// <summary>
        /// Getter & Setter for m_feedback_experience_id
        /// </summary>
        public int feedback_experience_id { get { return m_feedback_experience_id; } set { m_feedback_experience_id = value; } }


        private int m_experience_id;                // Database's experience_id field

        /// <summary>
        /// Getter & Setter for m_experience_id
        /// </summary>
        public int experience_id { get { return m_experience_id; } set { m_experience_id = value; } }


        private int m_feedback_id;                  // Database's feedback_id field

        /// <summary>
        /// Getter & Setter for m_feedback_id
        /// </summary>
        public int feedback_id { get { return m_feedback_id; } set { m_feedback_id = value; } }


        private int m_score;                        // Database's score field

        /// <summary>
        /// Getter & Setter for m_score
        /// </summary>
        public int score { get { return m_score; } set { m_score = value; } }
    }
}
