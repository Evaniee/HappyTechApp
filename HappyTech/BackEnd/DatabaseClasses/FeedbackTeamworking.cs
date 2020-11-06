using System;
using System.Collections.Generic;
using System.Text;

namespace HappyTech.BackEnd.DatabaseClasses
{
    public class FeedbackTeamworking
    {

        #region Feedback Questions
        private int m_feedback_teamworking_id;

        public int feedback_teamworking_id
        {
            get
            {
                return m_feedback_teamworking_id;
            }
            set
            {
                m_feedback_teamworking_id = value;
            }
        }
        #endregion

        #region Feedback ID
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
        #endregion

        #region Teamworking ID
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
        #endregion

        #region Achieved
        private bool m_achieved;

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

       
        #endregion

    }
}
