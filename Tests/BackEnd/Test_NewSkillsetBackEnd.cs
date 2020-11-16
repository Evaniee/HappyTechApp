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
    class Test_NewSkillsetBackEnd
    {
        private NewSkillset m_frontend;
        private TemplateSkillsetBackEnd m_templateSkillsetBackEnd;

        [SetUp]
        public void Setup()
        {
            m_frontend = new NewSkillset(m_templateSkillsetBackEnd, new Skillset());
        }

        [Test]
        public void test_Populate()
        {
            Skillset l_skillset = new Skillset()
            {
                skillset = "Can you run a team?",
            };

            m_frontend.BackEnd.Populate(l_skillset);
            List<string> l_textValues = m_frontend.textValues;
            if (l_textValues == null)
                Assert.Fail("No Values Found");
            else if (l_textValues[0] != "Can you run a team?")
                Assert.Fail("No Skillset found (" + l_textValues[0] + ")");
            Assert.Pass();
        }

        [Test]
        public void test_Submit()
        {
            string l_skillsetExpected = "Can you run a team?";

            List<Skillset> l_allSkillsets = BuisnessMetaLayer.Instance.GetDBSkillset();
            foreach (Skillset i_skillset in l_allSkillsets)
            {
                string l_skillset = i_skillset.skillset;

                if (i_skillset.skillset == l_skillsetExpected)
                    Assert.Pass();
            }
            Assert.Fail();
        }


    }
}
