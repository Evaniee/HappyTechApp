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
    class Test_NewExperienceBackEnd
    {
        private NewExperience m_frontend;
        private TemplateExperienceBackEnd m_templateExperienceBackEnd;

        [SetUp]
        public void Setup()
        {
            m_frontend = new NewExperience(m_templateExperienceBackEnd, new Experience());
        }

        [Test]
        public void test_Populate()
        {
            Experience l_experience = new Experience()
            {
                experience = "C# coding",
                response1 = "10years+",
                response2 = "5years",
                response3 = "2years",
                response4 = "1years",
                response5 = "no experience"
            };

            m_frontend.BackEnd.Populate(l_experience);
            List<string> l_textValues = m_frontend.textValues;
            if (l_textValues == null)
                Assert.Fail("No Values Found");
            else if (l_textValues[0] != "C# coding")
                Assert.Fail("No Experience found (" + l_textValues[0] + ")");
            else if (l_textValues[1] != "10years+")
                Assert.Fail("No response 1 found (" + l_textValues[1] + ")");
            else if (l_textValues[2] != "5years")
                Assert.Fail("No response 2 found (" + l_textValues[2] + ")");
            else if (l_textValues[3] != "2years")
                Assert.Fail("No response 3 found (" + l_textValues[3] + ")");
            else if (l_textValues[4] != "1years")
                Assert.Fail("No response 4 found (" + l_textValues[4] + ")");
            else if (l_textValues[5] != "no experience")
                Assert.Fail("No response 5 found (" + l_textValues[5] + ")");
            Assert.Pass();
        }
    }
}
