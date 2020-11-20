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
    public partial class TemplateTeamworking : Form
    {
        private TemplateTeamworkingBackEnd m_templateTeamworkingBackEnd;
        private bool m_update;

        public TemplateTeamworking(TemplateTeamworkingBackEnd a_backEnd)
        {
            m_templateTeamworkingBackEnd = a_backEnd;
            InitializeComponent();
            m_templateTeamworkingBackEnd.Connect(this);
            m_templateTeamworkingBackEnd.UpdateFrontEnd();
        }

        private void NewTeamworking_Load(object sender, EventArgs e)
        {
            // test
            int i = 0;
        }
        public void Update(List<string> a_addValues, List<string> a_editValues, List<string> a_removeValues, string a_textBoxValue)
        {
            m_update = true;
            cmb_NewTeamworking.DataSource = a_addValues;
            cmb_EditTeamworking.DataSource = a_editValues;
            cmb_RemoveTeamworking.DataSource = a_removeValues;
            txt_teamworkingReq.Text = a_textBoxValue;
            m_update = false;
        }

        /// <summary>
        /// Occurs when the Add New combo box's selected index is changed
        /// </summary>
        /// <param name="sender">Object that sent event</param>
        /// <param name="e">Event arguments</param>
        private void cmb_NewTeamworking_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Prevents occuring when updating datasource
            if (!m_update)
                m_templateTeamworkingBackEnd.AddNewTeamworking(cmb_NewTeamworking.Text);
            
        }

        /// <summary>
        /// Occurs when the Edit combo box's selected index is changed
        /// </summary>
        /// <param name="sender">Object that sent event</param>
        /// <param name="e">Event arguments</param>
        private void cmb_EditTeamworking_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Prevents occuring when updating datasource
            if (!m_update)
                m_templateTeamworkingBackEnd.AddExistingTeamworking(cmb_EditTeamworking.Text);
        }

        /// <summary>
        /// Occurs when the Remove combo box's selected index is changed
        /// </summary>
        /// <param name="sender">Object that sent event</param>
        /// <param name="e">Event arguments</param>
        private void cmb_RemoveTeamworking_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Prevents occuring when updating datasource
            if (!m_update)
                m_templateTeamworkingBackEnd.RemoveTeamworking(cmb_RemoveTeamworking.Text);
        }

        /// <summary>
        /// Get the associated back end
        /// </summary>
        public TemplateTeamworkingBackEnd BackEnd { get { return m_templateTeamworkingBackEnd; } }

        /// <summary>
        /// Occurs when ReturnTeamworking button is pressed
        /// </summary>
        /// <param name="sender">Object that sent event</param>
        /// <param name="e">Event arguments</param>
        private void btn_ReturnTeamworking_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}
