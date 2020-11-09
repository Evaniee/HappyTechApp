using System;
using System.Collections.Generic;
using System.Text;

namespace HappyTech.BackEnd.DatabaseClasses
{
    public class Experience
    {
        private int m_experience_id;                // Database's experience_id field

        /// <summary>
        /// Getter & Setter for m_experience_id
        /// </summary>
        public int experience_id { get { return m_experience_id; } set { m_experience_id = value; } }

        private string m_experience;      // Database's experience field

        /// <summary>
        /// Getter & Setter for m_question
        /// </summary>
        public string experience { get { return m_experience; } set { m_experience = value; } }

        private string m_response1;         // Databases response1 field

        /// <summary>
        /// Getter & Setter for m_response1
        /// </summary>
        public string response1 { get { return m_response1; } set { m_response1 = value; } }


        private string m_response2;         // Databases response2 field

        /// <summary>
        /// Getter & Setter for m_response2
        /// </summary>
        public string response2 { get { return m_response2; } set { m_response2 = value; } }


        private string m_response3;         // Databases response3 field

        /// <summary>
        /// Getter & Setter for m_response3
        /// </summary>
        public string response3 { get { return m_response3; } set { m_response3 = value; } }


        private string m_response4;         // Databases response4 field

        /// <summary>
        /// Getter & Setter for m_response4
        /// </summary>
        public string response4 { get { return m_response4; } set { m_response4 = value; } }


        private string m_response5;         // Databases response5 field

        /// <summary>
        /// Getter & Setter for m_response5
        /// </summary>
        public string response5 { get { return m_response5; } set { m_response5 = value; } }
    }
}
