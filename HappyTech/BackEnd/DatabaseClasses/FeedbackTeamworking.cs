using System;
using System.Collections.Generic;
using System.Text;

namespace HappyTech.BackEnd.DatabaseClasses
{
    class FeedbackTeamworking
    {
        private int m_feedback_teamworking_id;

        public int feedback_questions_id
        {
            get
            {
                return m_feedback_teamworking_id;
            }
        }

        private int m_feedback_id;

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

        private int m_teamworking_id;

        public int teamworking_id
        {
            get
            {
                return m_feedback_id;
            }

            set
            {
                m_teamworking_id = value;
            }
        }

        private bool m_achived;

        public bool archived
        {
            get
            {
                return m_achived;
            }

            set
            {
                m_achived = value;
            }
        }
    }
}
