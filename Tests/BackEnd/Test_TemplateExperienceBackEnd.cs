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
    class Test_TemplateExperienceBackEnd
    {
        private TemplateExperienceBackEnd m_backEnd;           // Associated Back End
        private NewTemplateBackEnd m_newTemplateBackEnd;        // NewTemplateBackEnd to inform
        //private TemplateExperience m_templateExperience;
        List<Experience> m_experiences;
        [SetUp]
        public void Setup()
        {
            m_backEnd = new TemplateExperienceBackEnd(m_newTemplateBackEnd, new List<Experience>());
        }

        [Test]
        public void test_Open()
        {
            m_backEnd.Open();
            FormCollection l_allForms = Application.OpenForms;
            foreach (Form i_form in l_allForms)
            {
                if (i_form.Name == "TemplateExperience")
                    Assert.Pass();
            }
            Assert.Fail("didn't open");
        }

        public void test_AddNewExperience()
        {

        }
    }
}
