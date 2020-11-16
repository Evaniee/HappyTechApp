using System;
using System.Collections.Generic;
using System.Text;

namespace HappyTech.BackEnd.DatabaseClasses
{
    public class Applicant
    {
        private int m_applicant_id;                 // Database's applicant_id field

        /// <summary>
        /// Getter & Setter for m_applicant_id
        /// </summary>
        public int applicant_id { get { return m_applicant_id; } set { m_applicant_id = value; } }

        private string m_name;                      // Database's name field

        /// <summary>
        /// Getter & Setter for m_name
        /// </summary>
        public string name { get { return m_name; } set { m_name = value; } }

        private string m_age;                       // Database's age field

        /// <summary>
        /// Getter & Setter for m_age
        /// </summary>
        public string age { get { return m_age; } set { m_age = value; } }

        private string m_address;                   // Database's address field
        /// <summary>
        /// Getter & Setter for m_address
        /// </summary>
        public string address { get { return m_address; } set { m_address = value; } }

        private string m_email_address;              // Database's email_address field

        /// <summary>
        /// Getter & Setter for m_email_address
        /// </summary>
        public string email_address { get { return m_email_address; } set { m_email_address = value; } }

        private string m_contact_number;            // Database's contact_number field

        /// <summary>
        /// Getter & Setter for m_contact_number
        /// </summary>
        public string contact_number { get { return m_contact_number; } set { m_contact_number = value; } }

        private string m_disabilities;              // Database's disabilities field

        /// <summary>
        /// Getter & Setter for m_disabilities
        /// </summary>
        public string disabilities { get { return m_disabilities; } set { m_disabilities = value; } }

        public bool m_right_to_work;                // Database's right_to_work field

        /// <summary>
        /// Getter & Setter for m_right_to_work
        /// </summary>
        public bool right_to_work { get { return m_right_to_work; } set { m_right_to_work = value; } }
    }
}
