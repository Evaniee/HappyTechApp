using Accessibility;
using HappyTech.BackEnd.DatabaseClasses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.DatabaseClasses
{
    [TestFixture]
    class Test_Skillset
    {
        private Skillset m_skillset;

        [SetUp]
        public void Setup()
        {
            m_skillset = new Skillset();
        }

        [Test]
        public void Test_skillset_id()
        {
            m_skillset.skillset_id = 1;
            Assert.AreEqual(m_skillset.skillset_id, 1);
        }

        [Test]
        public void Test_question()
        {
            m_skillset.skillset = "Test Skillset";
            Assert.AreEqual(m_skillset.skillset, "Test Skillset");
        }
    }
}
