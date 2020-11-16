using HappyTech.BackEnd.DatabaseClasses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.DatabaseClasses
{
    class Test_TemplateTeamworking
    {
        private TemplateTeamworking m_templateTeamworking;


        [SetUp]
        public void Setup()
        {
            m_templateTeamworking = new TemplateTeamworking();
        }

        [Test]
        public void Test_template_teamworking_id()
        {
            m_templateTeamworking.template_teamworking_id = 1;
            Assert.AreEqual(m_templateTeamworking.template_teamworking_id, 1);
        }

        [Test]
        public void Test_teamworking_id()
        {
            m_templateTeamworking.teamworking_id = 1;
            Assert.AreEqual(m_templateTeamworking.teamworking_id, 1);
        }

        [Test]
        public void Test_template_id()
        {
            m_templateTeamworking.template_id = 1;
            Assert.AreEqual(m_templateTeamworking.template_id, 1);
        }
    }
}
