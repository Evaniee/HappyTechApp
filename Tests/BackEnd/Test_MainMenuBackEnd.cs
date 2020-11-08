using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using HappyTech;
using HappyTech.FrontEnd;
using System.Windows.Forms;

namespace Tests.BackEnd
{
    [TestFixture]
    class Test_MainMenuBackEnd
    {
        MainMenu m_frontEnd;

        [SetUp]
        public void SetUp()
        {
            m_frontEnd = new MainMenu(true);
        }

        [Test]
        public void Test_OpenNewPositon()
        {
            m_frontEnd.BackEnd.OpenNewPosition();
            FormCollection l_allForms = Application.OpenForms;
            foreach (Form i_form in l_allForms)
                if (i_form.Name == "NewPosition")
                    Assert.Pass();
            Assert.Fail();
        }

        [Test]
        public void Test_OpenCurrentPositions()
        {
            m_frontEnd.BackEnd.OpenCurrentPositions();
            FormCollection l_allForms = Application.OpenForms;
            foreach (Form i_form in l_allForms)
                if (i_form.Name == "CurrentPositions")
                    Assert.Pass();
            Assert.Fail();
        }

    }
}
