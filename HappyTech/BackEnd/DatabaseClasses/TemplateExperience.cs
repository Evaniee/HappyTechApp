using System;
using System.Collections.Generic;
using System.Text;

namespace HappyTech.BackEnd.DatabaseClasses
{
    public class TemplateExperience
    {
        private int m_template_experience_id;       // Database's template_experience_id field

        /// <summary>
        /// Getter & Setter for m_feedback_experience_id
        /// </summary>
        public int template_experience_id { get { return m_template_experience_id; } set { m_template_experience_id = value; } }


        private int m_experience_id;                // Database's experience_id field

        /// <summary>
        /// Getter & Setter for m_experience_id
        /// </summary>
        public int experience_id { get { return m_experience_id; } set { m_experience_id = value; } }


        private int m_template_id;                  // Database's template_id field

        /// <summary>
        /// Getter & Setter for m_feedback_id
        /// </summary>
        public int template_id { get { return m_template_id; } set { m_template_id = value; } }
    }
}
