using HappyTech.BackEnd;
using HappyTech.BackEnd.DatabaseClasses;
using HappyTech.BackEnd.FormBackEnds;
using HappyTech.FrontEnd;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Tests.BackEnd
{
    [TestFixture]
    class Test_NewTeamworkingBackEnd
    {
        private NewTeamworking m_frontend;
        private TemplateTeamworkingBackEnd m_templateTeamworkingBackEnd;

        [SetUp]
        public void Setup()
        {
            m_frontend = new NewTeamworking(m_templateTeamworkingBackEnd, new Teamworking());
        }

        [Test]
        public void test_Populate()
        {
            Teamworking l_teamworking = new Teamworking()
            {
                teamworking = "Can you work in a team?",
            };

            m_frontend.BackEnd.Populate(l_teamworking);
            List<string> l_textValues = m_frontend.textValues;
            if (l_textValues == null)
                Assert.Fail("No Values Found");
            else if (l_textValues[0] != "Can you work in a team?")
                Assert.Fail("No Teamworking found (" + l_textValues[0] + ")");
            Assert.Pass();
        }

        [Test]
        public void test_Submit()
        {
            string l_teamworkingExpected = "Can you work in a team?";

            List<Teamworking> l_allTeamworkings = BuisnessMetaLayer.Instance.GetDBTeamworking();
            foreach (Teamworking i_teamworking in l_allTeamworkings)
            {
                string l_teamworking = i_teamworking.teamworking;

                if (i_teamworking.teamworking == l_teamworkingExpected)
                    Assert.Pass();
            }
            Assert.Fail();
        }
    }
}
