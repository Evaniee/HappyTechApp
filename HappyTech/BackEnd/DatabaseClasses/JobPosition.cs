using System;
using System.Collections.Generic;
using System.Text;

namespace HappyTech.BackEnd.DatabaseClasses
{
    public class JobPosition
    {
        private string m_job_code;          // Database's job_code field

        /// <summary>
        /// Getter & Setter for m_job_code
        /// </summary>
        public string job_code { get { return m_job_code; } set { m_job_code = value; } }

        private int m_template_id;          // Database's template_id field

        /// <summary>
        /// Getter & Setter for m_template_id
        /// </summary>
        public int template_id { get { return m_template_id; } set { m_template_id = value; } }

        private string m_title;             // Database's title field

        /// <summary>
        /// Getter & Setter for m_title
        /// </summary>
        public string title { get { return m_title; } set { m_title = value; } }

        private string m_description;       // Database's description field

        /// <summary>
        /// Getter & Setter for m_description
        /// </summary>
        public string description { get { return m_description; } set { m_description = value; } }
    }
}
