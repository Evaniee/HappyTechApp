using System;
using System.Collections.Generic;
using System.Text;

namespace HappyTech.BackEnd.DatabaseClasses
{
    public class Teamworking
    {
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

        private string m_teamworking;    

        public string teamworking
        {
            get
            {
                return m_teamworking;
            }
            set
            {
                m_teamworking = value;
            }
        }
    }
}
