using System;
using System.Collections.Generic;
using System.Text;

namespace HappyTech.BackEnd.DatabaseClasses
{
    public class Template
    {
        private int m_template_id;        // Database's template_id field

        /// <summary>
        /// Getter & Setter for m_template_id
        /// </summary>
        public int template_id { get { return m_template_id; } set { m_template_id = value; } }

        private string m_title;        // Database's title field

        /// <summary>
        /// Getter & Setter for m_template
        /// </summary>
        public string title { get { return m_title; } set { m_title = value; } }
    }
}
