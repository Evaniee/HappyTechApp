using HappyTech.BackEnd.DatabaseClasses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.DatabaseClasses
{
    [TestFixture]
    class Test_TemplateExperience
    {
        private TemplateExperience m_templateExperience;

        [SetUp]
        public void Setup()
        {
            m_templateExperience = new TemplateExperience();
        }

        [Test]
        public void Test_template_experience_id()
        {
            m_templateExperience.template_experience_id = 1;
            Assert.AreEqual(m_templateExperience.template_experience_id, 1);
        }

        [Test]
        public void Test_experience_id()
        {
            m_templateExperience.experience_id = 1;
            Assert.AreEqual(m_templateExperience.experience_id, 1);
        }

        [Test]
        public void Test_template_id()
        {
            m_templateExperience.template_id = 1;
            Assert.AreEqual(m_templateExperience.template_id, 1);
        }
    }
}
