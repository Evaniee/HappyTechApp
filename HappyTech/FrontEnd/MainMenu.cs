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
    public partial class MainMenu : Form
    {
        private MainMenuBackEnd m_backEnd;          // Associated BackEnd

        /// <summary>
        /// Constructor for Main Menu
        /// </summary>
        /// <param name="a_hr">Is logged in as HR</param>
        public MainMenu(bool a_hr)
        {
            m_backEnd = new MainMenuBackEnd(this, a_hr);
            InitializeComponent();
        }

        /// <summary>
        /// Connect with BackEnd
        /// </summary>
        /// <param name="a_backEnd">BackEnd to connect</param>
        public void Connect(MainMenuBackEnd a_backEnd)
        {
            m_backEnd = a_backEnd;
        }

        /// <summary>
        /// Occurs on loading Form
        /// </summary>
        /// <param name="sender">Object that caused event</param>
        /// <param name="e">Event args</param>
        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (m_backEnd.HR)
                lbl_hr.Show();
            else
                lbl_hr.Hide();
        }

        /// <summary>
        /// Occurs when btn_newPostion is clicked
        /// </summary>
        /// <param name="sender">Object that caused event</param>
        /// <param name="e">Event args</param>
        private void btn_newPosition_Click(object sender, EventArgs e)
        {
            m_backEnd.OpenNewPosition();
        }

        /// <summary>
        /// Occurs when btn_currentPosition is clicked
        /// </summary>
        /// <param name="sender">Object that caused event</param>
        /// <param name="e">Event args</param>
        private void btn_currentPosition_Click(object sender, EventArgs e)
        {
            m_backEnd.OpenCurrentPositions();
        }

        /// <summary>
        /// Occurs when btn_logOut is clicked
        /// </summary>
        /// <param name="sender">Object that caused event</param>
        /// <param name="e">Event args</param>
        private void btn_logOut_Click(object sender, EventArgs e)
        {
            m_backEnd.LogOut();
        }
    }
}
