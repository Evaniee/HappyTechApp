using Accessibility;
using HappyTech.BackEnd.DatabaseClasses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.DatabaseClasses
{
    [TestFixture]
    class Test_Questions
    {
        private Question m_question;

        [SetUp]
        public void Setup()
        {
            m_question = new Question();
        }

        [Test]
        public void Test_question_id()
        {
            m_question.question_id = 1;
            Assert.AreEqual(m_question.question_id, 1);
        }

        [Test]
        public void Test_question()
        {
            m_question.question = "Test Question";
            Assert.AreEqual(m_question.question, "Test Question");
        }

        [Test]
        public void Test_response1()
        {
            m_question.response1 = "Test Response 1";
            Assert.AreEqual(m_question.response1, "Test Response 1");
        }

        [Test]
        public void Test_response2()
        {
            m_question.response2 = "Test Response 2";
            Assert.AreEqual(m_question.response2, "Test Response 2");
        }

        [Test]
        public void Test_response3()
        {
            m_question.response3 = "Test Response 3";
            Assert.AreEqual(m_question.response3, "Test Response 3");
        }

        [Test]
        public void Test_response4()
        {
            m_question.response4 = "Test Response 4";
            Assert.AreEqual(m_question.response4, "Test Response 4");
        }

        [Test]
        public void Test_response5()
        {
            m_question.response5 = "Test Response 5";
            Assert.AreEqual(m_question.response5, "Test Response 5");
        }
    }
}