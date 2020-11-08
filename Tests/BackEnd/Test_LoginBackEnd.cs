using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using HappyTech.BackEnd.FormBackEnds;
using HappyTech.FrontEnd;
using HappyTech;
using System.Windows.Forms;

namespace Tests.BackEnd
{
    [TestFixture]
    class Test_LoginBackEnd
    {
        private Login m_frontEnd;

        [SetUp]
        public void Setup()
        {
            m_frontEnd = new Login();
        }

        [Test]
        public void Test_Login()
        {
            m_frontEnd.BackEnd.Login("a", "a");
            FormCollection l_allForms = Application.OpenForms;
            foreach (Form i_form in l_allForms)
            {
                if (i_form.Name == "MainMenu")
                {
                    MainMenu l_form = (MainMenu)i_form;
                    if (l_form.BackEnd.HR)
                        Assert.Pass();
                }
            }
            Assert.Fail();
        }
    }
}
