using System;
using System.Collections.Generic;
using System.Text;

namespace HappyTech.BackEnd.DatabaseClasses
{
    public class TemplateTeamworking
    {
        private int m_template_teamworking_id;

        public int template_teamworking_id
        {
            get
            {
                return m_template_teamworking_id;
            }

            set
            {
                m_template_teamworking_id = value;
            }
        }

        private int m_template_id;

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

        private int m_teamworking_id;


        public int teamworking_id
        {
            get
            {
                return m_teamworking_id;
            }

            set
            {
                m_teamworking_id = value;
            }
        }
    }
}

