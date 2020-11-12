using HappyTech.BackEnd.DatabaseClasses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.DatabaseClasses
{
    [TestFixture]
    class Test_FeedbackSkillset
    {
        FeedbackSkillset m_feedbackSkillset;

        [SetUp]
        public void Setup()
        {
            m_feedbackSkillset = new FeedbackSkillset();
        }

        [Test]
        public void Test_feedback_skillset_id()
        {
            m_feedbackSkillset.feedback_skillset_id = 1;
            Assert.AreEqual(m_feedbackSkillset.feedback_skillset_id, 1);
        }

        [Test]
        public void Test_skillset_id()
        {
            m_feedbackSkillset.skillset_id = 1;
            Assert.AreEqual(m_feedbackSkillset.skillset_id, 1);
        }

        [Test]
        public void Test_feedback_id()
        {
            m_feedbackSkillset.feedback_id = 1;
            Assert.AreEqual(m_feedbackSkillset.feedback_id, 1);
        }

        [Test]
        public void Test_achieved()
        {
            m_feedbackSkillset.achieved = true;
            Assert.AreEqual(m_feedbackSkillset.achieved, true);
        }
    }
}
