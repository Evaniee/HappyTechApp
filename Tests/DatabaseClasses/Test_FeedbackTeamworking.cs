using HappyTech.BackEnd.DatabaseClasses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.DatabaseClasses
{
    class Test_FeedbackTeamworking
    {
        FeedbackTeamworking m_feedbackTeamworking;

        [SetUp]
        public void Setup()
        {
            m_feedbackTeamworking = new FeedbackTeamworking();
        }

        [Test]
        public void Test_feedback_teamworking_id()
        {
            m_feedbackTeamworking.feedback_teamworking_id = 1;
            Assert.AreEqual(m_feedbackTeamworking.feedback_teamworking_id, 1);
        }

        [Test]
        public void Test_teamworking_id()
        {
            m_feedbackTeamworking.teamworking_id = 1;
            Assert.AreEqual(m_feedbackTeamworking.teamworking_id, 1);
        }

        [Test]
        public void Test_feedback_id()
        {
            m_feedbackTeamworking.feedback_id = 1;
            Assert.AreEqual(m_feedbackTeamworking.feedback_id, 1);
        }

        [Test]
        public void Test_achieved()
        {
            m_feedbackTeamworking.achieved = true;
            Assert.AreEqual(m_feedbackTeamworking.achieved, true);
        }
    }
}
