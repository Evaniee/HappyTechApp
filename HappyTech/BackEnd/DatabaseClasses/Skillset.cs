using System;
using System.Collections.Generic;
using System.Text;

namespace HappyTech.BackEnd.DatabaseClasses
{
    public class Skillset
    {
        private int m_skillset_id;      // This is the databases skillset_id field

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

        private string m_skillset;      // This is the databases skillset field

        //Get and set m_skillset
        public string skillset
        {
            get
            {
                return m_skillset;
            }
            set
            {
                m_skillset = value;
            }
        }
    }
}
