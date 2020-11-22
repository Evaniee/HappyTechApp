using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HappyTech.BackEnd.FormBackEnds;

namespace HappyTech.FrontEnd
{
    public partial class NewPosition : Form
    {
        private NewPositionBackEnd m_backEnd;       // Associated Back End
        private bool m_update;                      // Are components being updated

        /// <summary>
        /// Constructor for new position
        /// </summary>
        public NewPosition()
        {
            m_backEnd = new NewPositionBackEnd(this);
            InitializeComponent();
            Populate_cmb_jobTemplate(m_backEnd.PopulateJobTemplate());
        }

        /// <summary>
        /// Connect with backend
        /// </summary>
        /// <param name="a_backEnd">Backend to associate</param>
        public void Connect(NewPositionBackEnd a_backEnd)
        {
            m_backEnd = a_backEnd;
        }

        /// <summary>
        /// Populate job template combo box
        /// </summary>
        /// <param name="a_values">Values to populate using</param>
        public void Populate_cmb_jobTemplate(List<string> a_values)
        {
            m_update = true;
            cmb_jobTemplate.DataSource = a_values;
            m_update = false;
        }

        /// <summary>
        /// Occurs when job template combo boxes selected index is changed
        /// </summary>
        /// <param name="sender">Sender of event</param>
        /// <param name="e">Event arguements</param>
        private void cmb_jobTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!m_update)
                m_backEnd.TemplateSelected(cmb_jobTemplate.SelectedIndex);
        }

        /// <summary>
        /// Occurs when submit button is pressed
        /// </summary>
        /// <param name="sender">Object that sent event</param>
        /// <param name="e">Event arguements</param>
        private void btn_submit_Click(object sender, EventArgs e)
        {
            m_backEnd.SubmitPosition(txt_jobTitle.Text, txt_jobCode.Text, txt_jobDescription.Text, cmb_jobTemplate.Text);
        }

        /// <summary>
        /// Getter for back end
        /// </summary>
        public NewPositionBackEnd BackEnd { get { return m_backEnd; } }

        private void btn_updateCmb_Click(object sender, EventArgs e)
        {
            Populate_cmb_jobTemplate(m_backEnd.PopulateJobTemplate());
        }
    }
}
