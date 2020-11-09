using Accessibility;
using HappyTech.BackEnd.DatabaseClasses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.DatabaseClasses
{
    [TestFixture]
    class Test_Teamworking
    {
        private Teamworking m_teamworking;

        [SetUp]
        public void Setup()
        {
            m_teamworking = new Teamworking();
        }

        [Test]
        public void Test_teamworking_id()
        {
            m_teamworking.teamworking_id = 1;
            Assert.AreEqual(m_teamworking.teamworking_id, 1);
        }

        [Test]
        public void Test_teamworking()
        {
            m_teamworking.teamworking = "Test teamworking";
            Assert.AreEqual(m_teamworking.teamworking, "Test teamworking");
        }

    }
}
