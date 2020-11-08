using System;
using System.Collections.Generic;
using System.Text;

namespace HappyTech.BackEnd.DatabaseClasses
{
    public class TemplateSkillset
    {
        private int m_template_skillset_id;      // This is the databases template_skillset_id field

        //Get and set m_template_skillset_id
        public int template_skillset_id
        {
            get
            {
                return m_template_skillset_id;
            }

            set
            {
                m_template_skillset_id = value;
            }
        }

        private int m_template_id;              // This is the databases feedback_id field

        //Get and set m_template_id
        public int template_id
        {
            get
            {
                return m_template_id;
            }

            set
            {
                m_template_id = value;
            }
        }

        private int m_skillset_id;              // This is the databases skillset_id

        //Get and set m_skillset_id
        public int skillset_id
        {
            get
            {
                return m_skillset_id;
            }

            set
            {
                m_skillset_id = value;
            }
        }
    }
}
