using HappyTech.FrontEnd;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace HappyTech.BackEnd.FormBackEnds
{
    public class MainMenuBackEnd
    {
        private bool m_hr;                  // Is logged in user a HR user
        private MainMenu m_frontEnd;        // Associated Front End

        /// <summary>
        /// Constructor for Main Menu Backend
        /// </summary>
        /// <param name="a_frontEnd">Associated Front End</param>
        /// <param name="a_hr">Logged in as HR</param>
        public MainMenuBackEnd(MainMenu a_frontEnd, bool a_hr)
        {
            m_frontEnd = a_frontEnd;
            m_frontEnd.Connect(this);
            m_hr = a_hr;
        }

        /// <summary>
        /// Open a New Position Form
        /// </summary>
        public void OpenNewPosition()
        {
            new NewPosition().Show();
        }

        /// <summary>
        /// Open a Current Position Form
        /// </summary>
        public void OpenCurrentPositions()
        {
            new CurrentPositions().Show();
        }

        /// <summary>
        /// Log out of Application
        /// </summary>
        public void LogOut()
        {
            Application.Exit();
        }

        public bool HR { get { return m_hr; } }
    }
}
