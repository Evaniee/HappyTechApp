using System;
using System.Collections.Generic;
using System.Text;
using HappyTech.BackEnd.DatabaseClasses;
using NUnit.Framework;

namespace Tests.DatabaseClasses
{
    [TestFixture]
    class Test_Template
    {
        private Template m_template;

        [SetUp]
        public void Setup()
        {
            m_template = new Template();
        }

        [Test]
        public void Test_experience_id()
        {
            m_template.template_id = 1;
            Assert.AreEqual(m_template.template_id, 1);
        }

        [Test]
        public void Test_experience()
        {
            m_template.title = "Test Title";
            Assert.AreEqual(m_template.title, "Test Title");
        }
    }
}
