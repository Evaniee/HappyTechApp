using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using HappyTech.BackEnd.DatabaseClasses;

namespace Tests.DatabaseClasses
{
    [TestFixture]
    class Test_JobPosition
    {
        JobPosition m_jobPosition;

        [SetUp]
        public void Setup()
        {
            m_jobPosition = new JobPosition();
        }

        [Test]
        public void Test_description()
        {
            m_jobPosition.description = "Description";
            Assert.AreEqual(m_jobPosition.description, "Description");
        }

        [Test]
        public void Test_job_code()
        {
            m_jobPosition.job_code = "Code";
            Assert.AreEqual(m_jobPosition.job_code, "Code");
        }

        [Test]
        public void Test_template_id()
        {
            m_jobPosition.template_id = 1;
            Assert.AreEqual(m_jobPosition.template_id, 1);
        }

        [Test]
        public void Test_title()
        {
            m_jobPosition.title = "Title";
            Assert.AreEqual(m_jobPosition.title, "Title");
        }
    }
}
