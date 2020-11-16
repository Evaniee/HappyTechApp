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
        private TemplateExperienceBackEnd m_frontEnd;           // Associated Front End
        private NewTemplateBackEnd m_newTemplateBackEnd;        // NewTemplateBackEnd to inform
        List<Experience> m_experiences;
        [SetUp]
        public void Setup()
        {
            m_frontEnd = new TemplateExperienceBackEnd(m_newTemplateBackEnd, m_experiences);
        }

        [Test]
        public void test_Open()
        {
            FormCollection l_allForms = Application.OpenForms;
            foreach (Form i_form in l_allForms)
            {
                if (i_form.Name == "TemplateExperienceBackEnd")
                    Assert.Fail();
            }
            l_allForms = Application.OpenForms;
            foreach (Form i_form in l_allForms)
            {
                if (i_form.Name == "TemplateExperienceBackEnd")
                    Assert.Pass();
            }
            Assert.Fail();
        }
    }
}
