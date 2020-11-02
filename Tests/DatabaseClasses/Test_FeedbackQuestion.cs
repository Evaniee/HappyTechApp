using HappyTech.BackEnd.DatabaseClasses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.DatabaseClasses
{
    [TestFixture]
    class Test_FeedbackQuestion
    {
        FeedbackQuestion m_feedbackQuestion;

        [SetUp]
        public void Setup()
        {
            m_feedbackQuestion = new FeedbackQuestion();
        }

        [Test]
        public void Test_feedback_question_id()
        {
            m_feedbackQuestion.feedback_question_id = 1;
            Assert.AreEqual(m_feedbackQuestion.feedback_question_id, 1);
        }

        [Test]
        public void Test_question_id()
        {
            m_feedbackQuestion.question_id = 1;
            Assert.AreEqual(m_feedbackQuestion.question_id, 1);
        }

        [Test]
        public void Test_feedback_id()
        {
            m_feedbackQuestion.feedback_id = 1;
            Assert.AreEqual(m_feedbackQuestion.feedback_id, 1);
        }

        [Test]
        public void Test_score()
        {
            m_feedbackQuestion.score = 1;
            Assert.AreEqual(m_feedbackQuestion.score, 1);
        }
    }
}
