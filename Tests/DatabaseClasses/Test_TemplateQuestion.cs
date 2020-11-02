using HappyTech.BackEnd.DatabaseClasses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.DatabaseClasses
{
    [TestFixture]
    class Test_TemplateQuestion
    {
        private TemplateQuestion m_templateQuestion;

        [SetUp]
        public void Setup()
        {
            m_templateQuestion = new TemplateQuestion();
        }

        [Test]
        public void Test_template_question_id()
        {
            m_templateQuestion.template_question_id = 1;
            Assert.AreEqual(m_templateQuestion.template_question_id, 1);
        }

        [Test]
        public void Test_question_id()
        {
            m_templateQuestion.question_id = 1;
            Assert.AreEqual(m_templateQuestion.question_id, 1);
        }

        [Test]
        public void Test_template_id()
        {
            m_templateQuestion.template_id = 1;
            Assert.AreEqual(m_templateQuestion.template_id, 1);
        }
    }
}
