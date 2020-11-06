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
        private bool m_hr;

        public MainMenu(bool a_hr)
        {
            m_hr = a_hr;
            InitializeComponent();
        }


        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (m_hr == true)
                lbl_hr.Show();
            else
                lbl_hr.Hide();
        }

        private void btn_newPosition_Click(object sender, EventArgs e)
        {
            NewPosition newposition = new NewPosition();
            newposition.Show();
        }

        private void btn_currentPosition_Click(object sender, EventArgs e)
        {
            CurrentPositions currentposition = new CurrentPositions();
            currentposition.Show();
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewExperience newexperience = new NewExperience();
            newexperience.Show();
        }
    }
}
