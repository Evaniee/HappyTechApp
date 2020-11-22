using System;
using System.Collections.Generic;
using System.Text;

namespace HappyTech.BackEnd.DatabaseClasses
{
    public class Feedback
    {
        private int m_feedback_id;                  // Database's feedback_id field

        /// <summary>
        /// Getter & Setter for m_feedback_id
        /// </summary>
        public int feedback_id { get { return m_feedback_id; } set { m_feedback_id = value; } }


        private int m_template_id;                  // Database's template_id field

        /// <summary>
        /// Getter & Setter for m_template_id
        /// </summary>
        public int template_id { get { return m_template_id; } set { m_template_id = value; } }


        private string m_comments;                  // Database's comments field

        /// <summary>
        /// Getter & Setter for m_comments
        /// </summary>
        public string comments { get { return m_comments; } set { m_comments = value; } }
    }
}
