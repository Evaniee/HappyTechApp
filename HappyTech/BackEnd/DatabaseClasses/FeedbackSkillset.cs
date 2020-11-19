using System;
using System.Collections.Generic;
using System.Text;

namespace HappyTech.BackEnd.DatabaseClasses
{
    public class FeedbackSkillset
    {
        private int m_feedback_skillset_id;      //This is the databases feedback_skillset_id field

        //Get and set m_feedback_skillset_id
        public int feedback_skillset_id
        {
            get
            {
                return m_feedback_skillset_id;
            }

            set
            {
                m_feedback_skillset_id = value;
            }
        }

        private int m_feedback_id;              // This is databases feedback_id field

        //Get and set m_feedback_id
        public int feedback_id
        {
            get
            {
                return m_feedback_id;
            }

            set
            {
                m_feedback_id = value;
            }
        }

        private int m_skillset_id;              // This is the databases skillset_id field

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

        private bool m_achieved;                  //This is the databases achieved field

        //Get and set m_achieved
        public bool achieved
        {
            get
            {
                return m_achieved;
            }

            set
            {
                m_achieved = value;
            }
        }

    }
}
