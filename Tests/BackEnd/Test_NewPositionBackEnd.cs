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
    class Test_NewPositionBackEnd
    {
        private NewPosition m_frontEnd;

        [SetUp]
        public void Setup()
        {
            m_frontEnd = new NewPosition();
        }

        [Test]
        public void Test_PopulateJobTemplate()
        {
            List<string> l_values = m_frontEnd.BackEnd.PopulateJobTemplate();
            if (l_values == null)
                Assert.Fail("No Values Found");
            if (l_values[0] != "New Template")
                Assert.Fail("New Template not showing");
            if (l_values[1] != "1: Programmer")
                Assert.Fail("Entry 1 Failed");
            if (l_values[2] != "2: Gardener")
                Assert.Fail("Entry 2 Failed");
            if (l_values[3] != "3: Builder")
                Assert.Fail("Entry 3 Failed");
            if (l_values[4] != "4: CEO")
                Assert.Fail("Entry 4 Failed");
            Assert.Pass();
        }

        [Test]
        public void Test_TemplateSelected()
        {
            m_frontEnd.BackEnd.TemplateSelected(1);
            FormCollection l_allForms = Application.OpenForms;
            foreach(Form i_form in l_allForms)
            {
                if (i_form.Name == "NewTemplate")
                    Assert.Fail();
            }
            m_frontEnd.BackEnd.TemplateSelected(0);
            l_allForms = Application.OpenForms;
            foreach (Form i_form in l_allForms)
            {
                if (i_form.Name == "NewTemplate")
                    Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void Test_Submit()
        {
            m_frontEnd.BackEnd.SubmitPosition("Title", "Code", "Description", "1: Programmer");
            List <JobPosition> l_jobPositions = BuisnessMetaLayer.Instance.GetDBJobPositions();
            BuisnessMetaLayer.Instance.Select("SELECT COUNT(*) FROM job_position WHERE title = 'Title' AND job_code = 'Code' AND description = 'Description';");
            BuisnessMetaLayer.Instance.Delete("DELETE FROM job_position WHERE title = 'Title' AND job_code = 'Code' AND description = 'Description';");
        }
    }
}
