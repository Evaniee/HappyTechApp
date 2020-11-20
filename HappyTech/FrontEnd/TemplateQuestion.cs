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
    public partial class TemplateQuestion : Form
    {
        private TemplateQuestionBackEnd m_templateQuestionBackEnd;          // Associated Back End
        private bool m_update;                                              // Is a datasource update occuring

        /// <summary>
        /// Constructor for Template Question front end
        /// </summary>
        /// <param name="a_templateQuestionBackEnd">Associated Back End</param>
        public TemplateQuestion(TemplateQuestionBackEnd a_templateQuestionBackEnd)
        {
            m_templateQuestionBackEnd = a_templateQuestionBackEnd;
            InitializeComponent();
            m_templateQuestionBackEnd.Connect(this);
            m_templateQuestionBackEnd.UpdateFrontEnd();
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
                m_templateQuestionBackEnd.AddNewQuestion(cmb_addExist.Text);
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
                m_templateQuestionBackEnd.AddExistingQuestion(cmb_addEdit.Text);
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
                m_templateQuestionBackEnd.RemoveQuestion(cmb_remove.Text);
        }

        /// <summary>
        /// Get the associated back end
        /// </summary>
        public TemplateQuestionBackEnd BackEnd { get { return m_templateQuestionBackEnd; } }

        /// <summary>
        /// Occurs when ReturnQuestion button is pressed
        /// </summary>
        /// <param name="sender">Object that sent event</param>
        /// <param name="e">Event arguments</param>
        private void btn_ReturnQuestion_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
