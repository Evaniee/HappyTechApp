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
    public partial class NewTemplate : Form
    {
        NewTemplateBackEnd m_backEnd;       // Associated Backend

        /// <summary>
        /// Constructor for back end
        /// </summary>
        public NewTemplate()
        {
            InitializeComponent();
            m_backEnd = new NewTemplateBackEnd(this);
        }

        /// <summary>
        /// Connect with a Backend
        /// </summary>
        /// <param name="a_backEnd">Associated Backend</param>
        public void Connect(NewTemplateBackEnd a_backEnd)
        {
            m_backEnd = a_backEnd;
        }

        /// <summary>
        /// Occurs when btn_question is clicked
        /// </summary>
        /// <param name="sender">Object that caused event</param>
        /// <param name="e">Event args</param>
        private void btn_questions_Click(object sender, EventArgs e)
        {
            m_backEnd.NewQuestion();
        }

        /// <summary>
        /// Occurs when btn_experience is clicked
        /// </summary>
        /// <param name="sender">Object that caused event</param>
        /// <param name="e">Event args</param>
        private void btn_experience_Click(object sender, EventArgs e)
        {
            m_backEnd.NewExperience();
        }

        /// <summary>
        /// Occurs when btn_skillset is clicked
        /// </summary>
        /// <param name="sender">Object that caused event</param>
        /// <param name="e">Event args</param>
        private void btn_skillset_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Skillset");
        }

        /// <summary>
        /// Occurs when btn_teamworking is clicked
        /// </summary>
        /// <param name="sender">Object that caused event</param>
        /// <param name="e">Event args</param>
        private void btn_teamworking_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Teamworking");
        }

        /// <summary>
        /// Occurs when btn_submit is clicked
        /// </summary>
        /// <param name="sender">Object that caused event</param>
        /// <param name="e">Event args</param>
        private void btn_submit_Click(object sender, EventArgs e)
        {
            m_backEnd.Submit();
        }

        /// <summary>
        /// Get the Associated BackEnd
        /// </summary>
        public NewTemplateBackEnd BackEnd { get { return m_backEnd; } }
    }
}
