using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HappyTech.BackEnd;
using HappyTech.BackEnd.DatabaseClasses;
using HappyTech.BackEnd.FormBackEnds;

namespace HappyTech.FrontEnd
{
    public partial class TemplateExperience : Form
    {
        private TemplateExperienceBackEnd m_templateExperienceBackEnd;          // Associated Back End
        private bool m_update;                                              // Is a datasource update occuring

        /// <summary>
        /// Constructor for Template Experience front end
        /// </summary>
        /// <param name="a_templateExperienceBackEnd">Associated Back End</param>
        public TemplateExperience(TemplateExperienceBackEnd a_templateExperienceBackEnd)
        {
            m_templateExperienceBackEnd = a_templateExperienceBackEnd;
            InitializeComponent();
            m_templateExperienceBackEnd.Connect(this);
            m_templateExperienceBackEnd.UpdateFrontEnd();
        }

        /// <summary>
        /// Update datasources for associated front end's components
        /// </summary>
        /// <param name="a_addValues">Values for add combo box</param>
        /// <param name="a_editValues">Values for edit combo box</param>
        /// <param name="a_removeValues">Values for remove combo box</param>
        /// <param name="a_textBoxValue">Value for selected text box</param>
        public void Update(List<string> a_addValues, List<string> a_editValues, List<string> a_removeValues, string a_textBoxValue)
        {
            m_update = true;
            cmb_addExist.DataSource = a_addValues;
            cmb_addEdit.DataSource = a_editValues;
            cmb_remove.DataSource = a_removeValues;
            txt_selected.Text = a_textBoxValue;
            m_update = false;
        }

        /// <summary>
        /// Occurs when the Add New combo box's selected index is changed
        /// </summary>
        /// <param name="sender">Object that sent event</param>
        /// <param name="e">Event arguments</param>
        private void cmb_addExist_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Prevents occuring when updating datasource
            if (!m_update)
                m_templateExperienceBackEnd.AddNewExperience(cmb_addExist.Text);
        }

        /// <summary>
        /// Occurs when the Edit combo box's selected index is changed
        /// </summary>
        /// <param name="sender">Object that sent event</param>
        /// <param name="e">Event arguments</param>
        private void cmb_addEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Prevents occuring when updating datasource
            if (!m_update)
                m_templateExperienceBackEnd.AddExistingExperience(cmb_addEdit.Text);
        }

        /// <summary>
        /// Occurs when the Remove combo box's selected index is changed
        /// </summary>
        /// <param name="sender">Object that sent event</param>
        /// <param name="e">Event arguments</param>
        private void cmb_remove_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Prevents occuring when updating datasource
            if (!m_update)
                m_templateExperienceBackEnd.RemoveExperience(cmb_remove.Text);
        }

        /// <summary>
        /// Get the associated back end
        /// </summary>
        public TemplateExperienceBackEnd BackEnd { get { return m_templateExperienceBackEnd; } }

        public String TextBox { get { return txt_selected.Text; } }

        /// <summary>
        /// Occurs when ReturnExperience button is pressed
        /// </summary>
        /// <param name="sender">Object that sent event</param>
        /// <param name="e">Event arguments</param>
        private void btn_ReturnExperience_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
