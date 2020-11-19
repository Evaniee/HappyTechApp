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

        [Test]
        public void test_Submit()
        {
            string l_experienceExpected = "C# coding";
            string l_response1Expected = "10years+";
            string l_response2Expected = "5years";
            string l_response3Expected = "2years";
            string l_response4Expected = "1year";
            string l_response5Expected = "no experience";

            List<Experience> l_allExperiences = BuisnessMetaLayer.Instance.GetDBExperience();
            foreach(Experience i_experience in l_allExperiences) 
            {
                string l_experience = i_experience.experience;
                string l_response1 = i_experience.response1;
                string l_response2 = i_experience.response2;
                string l_response3 = i_experience.response3;
                string l_response4 = i_experience.response4;
                string l_response5 = i_experience.response5;
                if (i_experience.response1 == l_response1Expected)
                    if (i_experience.response2 == l_response2Expected)
                        if (i_experience.response3 == l_response3Expected) 
                            if (i_experience.response4 == l_response4Expected)
                                if (i_experience.response5 == l_response5Expected)
                                    Assert.Pass();
            }
            Assert.Fail("Could Not Find");
        }
    }
}
