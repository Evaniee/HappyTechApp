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
    public partial class NewExperience : Form
    {
        NewExperienceBackEnd m_newExperienceBackEnd;

        /// <summary>
        /// Constructor for New Experience Front End
        /// </summary>
        /// <param name="a_templateExperienceBackEnd">Associated Back End</param>
        /// <param name="a_experience">Experience to populate form with (Nullable)</param>
        public NewExperience(TemplateExperienceBackEnd a_templateExperienceBackEnd, Experience a_experience)
        {
            new NewExperienceBackEnd(this, a_templateExperienceBackEnd);
            InitializeComponent();
            m_newExperienceBackEnd.Populate(a_experience);
        }

        /// <summary>
        /// Connect to an associated NewExperienceBackEnd
        /// </summary>
        /// <param name="a_newExperienceBackEnd">Associated NewExperienceBackEnd</param>
        public void Connect(NewExperienceBackEnd a_newExperienceBackEnd)
        {
            m_newExperienceBackEnd = a_newExperienceBackEnd;
        }

        /// <summary>
        /// Populate text boxes with existing experience data
        /// </summary>
        /// <param name="a_experience">Experience of new experience</param>
        /// <param name="a_response1">Response 1 of new experience</param>
        /// <param name="a_response2">Response 2 of new experience</param>
        /// <param name="a_response3">Response 3 of new experience</param>
        /// <param name="a_response4">Response 4 of new experience</param>
        /// <param name="a_response5">Response 5 of new experience</param>
        public void Populate(string a_experience, string a_response1, string a_response2, string a_response3, string a_response4, string a_response5)
        {
            if (a_experience != null)
                txt_experience.Text = a_experience;
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
            m_newExperienceBackEnd.Submit(txt_experience.Text, txt_reponse1.Text, txt_reponse2.Text, txt_reponse3.Text, txt_reponse4.Text, txt_reponse5.Text);
        }

        /// <summary>
        /// Getter for back end
        /// </summary>
        public NewExperienceBackEnd BackEnd { get { return m_newExperienceBackEnd; } }
    }
}
