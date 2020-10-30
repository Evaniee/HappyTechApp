using HappyTech.BackEnd;
using HappyTech.BackEnd.FormBackEnds;
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
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            LoginBackEnd l_loginBackEnd = new LoginBackEnd();
            if (l_loginBackEnd.ValidateLogin(txt_username.Text, txt_password.Text))
                if (l_loginBackEnd.CheckHR(txt_username.Text, txt_password.Text))
                    MessageBox.Show("Logged in as HR");       //change this line for main menu connection (HR)
                else
                    MessageBox.Show("Logged in as Normal");   //change this line for main menu connection (Normal) 
        }
    }
}
