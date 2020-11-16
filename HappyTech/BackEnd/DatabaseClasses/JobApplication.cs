using System;
using System.Collections.Generic;
using System.Text;

namespace HappyTech.BackEnd.DatabaseClasses
{
    public class JobApplication
    {
        private int m_job_application_id;          // Database's job_application_id field

        /// <summary>
        /// Getter & Setter for m_job_application_id
        /// </summary>
        public int job_application_id { get { return m_job_application_id; } set { m_job_application_id = value; } }

        private int m_applicant_id;                 // Database's applicant_id field

        /// <summary>
        /// Getter & Setter for m_applicant_id
        /// </summary>
        public int applicant_id { get { return m_applicant_id; } set { m_applicant_id = value; } }

        private string m_job_code;                  // Database's job_code field

        /// <summary>
        /// Getter & Setter for m_job_code
        /// </summary>
        public string job_code { get { return m_job_code; } set { m_job_code = value; } }

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

        private bool m_hired;                       // Databases hired field

        /// <summary>
        /// Getter & Setter for m_hired
        /// </summary>
        public bool hired { get { return m_hired; } set { m_hired = value; } }

        private bool m_sent;                        // Databases sent field

        /// <summary>
        /// Getter & Setter for m_sent
        /// </summary>
        public bool sent { get { return m_sent; } set { m_sent = value; } }

        private bool m_contacted;                   // Databases contacted field

        /// <summary>
        /// Getter & Setter for m_contacted
        /// </summary>
        public bool contacted { get { return m_contacted; } set { m_contacted = value; } }
    }
}
