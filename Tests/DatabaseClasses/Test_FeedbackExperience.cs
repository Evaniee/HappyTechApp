using HappyTech.BackEnd.DatabaseClasses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.DatabaseClasses
{
    [TestFixture]
    class Test_FeedbackExperience
    {
        FeedbackExperience m_feedbackExperience;

        [SetUp]
        public void Setup()
        {
            m_feedbackExperience = new FeedbackExperience();
        }

        [Test]
        public void Test_feedback_experience_id()
        {
            m_feedbackExperience.feedback_experience_id = 1;
            Assert.AreEqual(m_feedbackExperience.feedback_experience_id, 1);
        }

        [Test]
        public void Test_experience_id()
        {
            m_feedbackExperience.experience_id = 1;
            Assert.AreEqual(m_feedbackExperience.experience_id, 1);
        }

        [Test]
        public void Test_feedback_id()
        {
            m_feedbackExperience.feedback_id = 1;
            Assert.AreEqual(m_feedbackExperience.feedback_id, 1);
        }

        [Test]
        public void Test_score()
        {
            m_feedbackExperience.score = 1;
            Assert.AreEqual(m_feedbackExperience.score, 1);
        }
    }
}
