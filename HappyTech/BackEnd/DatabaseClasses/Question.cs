using System;
using System.Collections.Generic;
using System.Text;

namespace HappyTech.BackEnd.DatabaseClasses
{
    class Question
    {
        private int m_question_id;      // Database's question_id field

         /// <summary>
        /// Getter & Setter for m_question_id
        /// </summary>
        public int question_id { get { return m_question_id; } set { m_question_id = value; } }


        private string m_question;      // Database's question field

        /// <summary>
        /// Getter & Setter for m_question
        /// </summary>
        public string question { get { return m_question; } set { m_question = value; } }
  

        private string m_response1;     // Databases response1 field

        /// <summary>
        /// Getter & Setter for m_response1
        /// </summary>
        public string response1 { get { return m_response1; } set { m_response1 = value; } }


        private string m_response2;     // Databases response2 field

        /// <summary>
        /// Getter & Setter for m_response2
        /// </summary>
        public string response2 { get { return m_response2; } set { m_response2 = value; } }


        private string m_response3;     // Databases response3 field

        /// <summary>
        /// Getter & Setter for m_response3
        /// </summary>
        public string response3 { get { return m_response3; } set { m_response3 = value; } }


        private string m_response4;     // Databases response4 field

        /// <summary>
        /// Getter & Setter for m_response4
        /// </summary>
        public string response4 { get { return m_response4; } set { m_response4 = value; } }


        private string m_response5;     // Databases response5 field

        /// <summary>
        /// Getter & Setter for m_response5
        /// </summary>
        public string response5 { get { return m_response5; } set { m_response5 = value; } }
    }
}
