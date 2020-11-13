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
    class Test_NewQuestionBackEnd
    {
        private NewQuestion m_frontend;
        private TemplateQuestionBackEnd m_templateQuestionBackEnd;

        [SetUp]
        public void Setup()
        {
            m_frontend = new NewQuestion(m_templateQuestionBackEnd, new Question());
        }

        [Test]
        public void test_Populate()
        {
            Question l_question = new Question()
            {
                question = "why do you think you should have this job?",
                response1 = "becuase im the best",
                response2 = "do it",
                response3 = "you will not be sorry",
                response4 = "please",
                response5 = "just dont"
            };

            m_frontend.BackEnd.Populate(l_question);
            List<string> l_textValues = m_frontend.textValues;
            if (l_textValues == null)
                Assert.Fail("No Values Found");
            else if (l_textValues[0] != "why do you think you should have this job?")
                Assert.Fail("No Question found (" + l_textValues[0] + ")");
            else if (l_textValues[1] != "becuase im the best")
                Assert.Fail("No response 1 found (" + l_textValues[1] + ")");
            else if (l_textValues[2] != "do it")
                Assert.Fail("No response 2 found (" + l_textValues[2] + ")");
            else if (l_textValues[3] != "you will not be sorry")
                Assert.Fail("No response 3 found (" + l_textValues[3] + ")");
            else if (l_textValues[4] != "please")
                Assert.Fail("No response 4 found (" + l_textValues[4] + ")");
            else if (l_textValues[5] != "just dont")
                Assert.Fail("No response 5 found (" + l_textValues[5] + ")");
            Assert.Pass();
        }

        [Test]
        public void test_Submit()
        {
            string l_questionExpected = "why do you think you should have this job?";
            string l_response1Expected = "becuase im the best";
            string l_response2Expected = "do it";
            string l_response3Expected = "you will not be sorry";
            string l_response4Expected = "please";
            string l_response5Expected = "just dont";

            List<Question> l_allQuestion = BuisnessMetaLayer.Instance.GetDBQuestion();
            foreach (Question i_question in l_allQuestion)
            {
                string l_question = i_question.question;
                string l_response1 = i_question.response1;
                string l_response2 = i_question.response2;
                string l_response3 = i_question.response3;
                string l_response4 = i_question.response4;
                string l_response5 = i_question.response5;
                if (i_question.response1 == l_response1Expected)
                    if (i_question.response2 == l_response2Expected)
                        if (i_question.response3 == l_response3Expected)
                            if (i_question.response4 == l_response4Expected)
                                if (i_question.response5 == l_response5Expected)
                                    Assert.Pass();
            }
            Assert.Fail("Could Not Find");
        }
    }
}

