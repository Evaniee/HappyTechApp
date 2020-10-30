using System;
using System.Collections.Generic;
using System.Text;

namespace HappyTech.BackEnd.DatabaseClasses
{
    public class TemplateQuestion
    {
        private int m_template_question_id;     // Database's template_question_id field

        /// <summary>
        /// Getter & Setter for m_feedback_question_id
        /// </summary>
        public int template_question_id { get { return m_template_question_id; } set { m_template_question_id = value; } }


        private int m_question_id;              // Database's question_id field

        /// <summary>
        /// Getter & Setter for m_question_id
        /// </summary>
        public int question_id { get { return m_question_id; } set { m_question_id = value; } }


        private int m_template_id;              // Database's template_id field

        /// <summary>
        /// Getter & Setter for m_feedback_id
        /// </summary>
        public int template_id { get { return m_template_id; } set { m_template_id = value; } }
    }
}
