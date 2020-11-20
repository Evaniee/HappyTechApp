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
    class Test_TemplateQuestionBackEnd
    {
        private TemplateQuestionBackEnd m_backEnd;           // Associated Back End
        private NewTemplateBackEnd m_newTemplateBackEnd;        // NewTemplateBackEnd to inform

        [SetUp]
        public void Setup()
        {
            m_backEnd = new TemplateQuestionBackEnd(m_newTemplateBackEnd, new List<Question>());
        }

        [Test]
        public void test_Open()
        {
            m_backEnd.Open();
            FormCollection l_allForms = Application.OpenForms;
            foreach (Form i_form in l_allForms)
            {
                if (i_form.Name == "TemplateQuestion")
                    Assert.Pass();
            }
            Assert.Fail("didn't open");
        }

        [Test]
        public void test_AddNewQuestion()
        {
            m_backEnd.AddNewQuestion("New Question");
            FormCollection l_allForms = Application.OpenForms;
            foreach (Form i_form in l_allForms)
            {
                if (i_form.Name == "NewQuestion")
                    Assert.Pass();
            }
            Assert.Fail("didn't open");
        }

        [Test]
        public void test_AddExistingQuestion()
        {
            m_backEnd.AddExistingQuestion(null);
            FormCollection l_allForms = Application.OpenForms;
            foreach (Form i_form in l_allForms)
            {
                if (i_form.Name == "NewQuestion")
                    Assert.Pass();
            }
            Assert.Fail("didn't open");
        }
    }
}