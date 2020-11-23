using HappyTech.BackEnd.DatabaseClasses;
using HappyTech.BackEnd.FormBackEnds;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HappyTech.FrontEnd
{
    public partial class NewQuestion : Form
    {
        NewQuestionBackEnd m_newQuestionBackEnd;

        /// <summary>
        /// Constructor for New Question Front End
        /// </summary>
        /// <param name="a_templateQuestionBackEnd">Associated Back End</param>
        /// <param name="a_question">Question to populate form with (Nullable)</param>
        public NewQuestion(TemplateQuestionBackEnd a_templateQuestionBackEnd, Question a_question)
        {
            new NewQuestionBackEnd(this, a_templateQuestionBackEnd);
            InitializeComponent();
            m_newQuestionBackEnd.Populate(a_question);
        }

        /// <summary>
        /// Connect to an associated NewQuestionBackEnd
        /// </summary>
        /// <param name="a_newQuestionBackEnd">Associated NewQuestionBackEnd</param>
        public void Connect(NewQuestionBackEnd a_newQuestionBackEnd)
        {
            m_newQuestionBackEnd = a_newQuestionBackEnd;
        }

        /// <summary>
        /// Populate text boxes with existing question data
        /// </summary>
        /// <param name="a_question">Question of new question</param>
        /// <param name="a_response1">Response 1 of new question</param>
        /// <param name="a_response2">Response 2 of new question</param>
        /// <param name="a_response3">Response 3 of new question</param>
        /// <param name="a_response4">Response 4 of new question</param>
        /// <param name="a_response5">Response 5 of new question</param>
        public void Populate(string a_question, string a_response1, string a_response2, string a_response3, string a_response4, string a_response5)
        {
            if (a_question != null)
                txt_question.Text = a_question;
            if (a_response1 != null)
                txt_reponse1.Text = a_response1;
            if (a_response2 != null)
                txt_reponse2.Text = a_response2;
            if (a_response3 != null)
                txt_reponse3.Text = a_response3;
            if (a_response4 != null)
                txt_reponse4.Text = a_response4;
            if (a_response5 != null)
                txt_reponse5.Text = a_response5;
        }

        /// <summary>
        /// Occurs when the submit button is clicked
        /// </summary>
        /// <param name="sender">Object that sent event</param>
        /// <param name="e">Event arguments</param>
        public void btn_submit_Click(object sender, EventArgs e) 
        {
            m_newQuestionBackEnd.Submit(txt_question.Text, txt_reponse1.Text, txt_reponse2.Text, txt_reponse3.Text, txt_reponse4.Text, txt_reponse5.Text);
        }

        /// <summary>
        /// Getter for back end
        /// </summary>
        public NewQuestionBackEnd BackEnd { get { return m_newQuestionBackEnd; } }


        #region UNit test class
        /// <summary>
        /// Method created to enable NUit tests
        /// </summary>
        public List<string> textValues
        {
            get
            {
                List<string> l_textValues = new List<string>();
                l_textValues.Add(txt_question.Text);
                l_textValues.Add(txt_reponse1.Text);
                l_textValues.Add(txt_reponse2.Text);
                l_textValues.Add(txt_reponse3.Text);
                l_textValues.Add(txt_reponse4.Text);
                l_textValues.Add(txt_reponse5.Text);
                return l_textValues;
            }
        }
        #endregion 
    }
}
