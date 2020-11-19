using HappyTech.BackEnd.DatabaseClasses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.DatabaseClasses
{
    [TestFixture]
    class Test_TemplateSkillset
    {
        private TemplateSkillset m_templateSkillset;

        [SetUp]
        public void Setup()
        {
            m_templateSkillset = new TemplateSkillset();
        }

        [Test]
        public void Test_template_skillset_id()
        {
            m_templateSkillset.template_skillset_id = 1;
            Assert.AreEqual(m_templateSkillset.template_skillset_id, 1);
        }

        [Test]
        public void Test_skillset_id()
        {
            m_templateSkillset.skillset_id = 1;
            Assert.AreEqual(m_templateSkillset.skillset_id, 1);
        }

        [Test]
        public void Test_template_id()
        {
            m_templateSkillset.template_id = 1;
            Assert.AreEqual(m_templateSkillset.template_id, 1);
        }
    }
}
