using Accessibility;
using HappyTech.BackEnd.DatabaseClasses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.DatabaseClasses
{
    [TestFixture]
    class Test_Experience
    {
        private Experience m_experience;

        [SetUp]
        public void Setup()
        {
            m_experience = new Experience();
        }

        [Test]
        public void Test_experience_id()
        {
            m_experience.experience_id = 1;
            Assert.AreEqual(m_experience.experience_id, 1);
        }

        [Test]
        public void Test_experience()
        {
            m_experience.experience = "Test Experience";
            Assert.AreEqual(m_experience.experience, "Test Experience");
        }

        [Test]
        public void Test_response1()
        {
            m_experience.response1 = "Test Response 1";
            Assert.AreEqual(m_experience.response1, "Test Response 1");
        }

        [Test]
        public void Test_response2()
        {
            m_experience.response2 = "Test Response 2";
            Assert.AreEqual(m_experience.response2, "Test Response 2");
        }

        [Test]
        public void Test_response3()
        {
            m_experience.response3 = "Test Response 3";
            Assert.AreEqual(m_experience.response3, "Test Response 3");
        }

        [Test]
        public void Test_response4()
        {
            m_experience.response4 = "Test Response 4";
            Assert.AreEqual(m_experience.response4, "Test Response 4");
        }

        [Test]
        public void Test_response5()
        {
            m_experience.response5 = "Test Response 5";
            Assert.AreEqual(m_experience.response5, "Test Response 5");
        }
    }
}
