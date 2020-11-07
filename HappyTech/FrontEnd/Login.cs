using HappyTech.BackEnd;
using HappyTech.BackEnd.FormBackEnds;
using HappyTech.FrontEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTech
{
    public partial class Login : Form
    {
        private LoginBackEnd m_backEnd;     // BackEnd associated with FrontEnd

        /// <summary>
        /// Constructor for the Login Form
        /// </summary>
        public Login()
        {
            m_backEnd = new LoginBackEnd(this);
            InitializeComponent();
        }

        /// <summary>
        /// Connect the Login's BackEnd to the FrontEnd
        /// </summary>
        /// <param name="a_backEnd"></param>
        public void Connect(LoginBackEnd a_backEnd)
        {
            m_backEnd = a_backEnd;
        }

        /// <summary>
        /// Event handler for btn_login being clicked
        /// </summary>
        /// <param name="sender">Sender of event</param>
        /// <param name="e">Arguments of event</param>
        private void btn_login_Click(object sender, EventArgs e)
        {
            string l_username = txt_username.Text;
            string l_password = txt_password.Text;
            m_backEnd.Login(l_username, l_password);
        }
    }
}
