using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Accessibility;
using MySql.Data.MySqlClient;
using HappyTech.FrontEnd;

namespace HappyTech.BackEnd.FormBackEnds
{
    public class LoginBackEnd
    {
        private Login m_frontEnd;       // Associated FrontEnd

        /// <summary>
        /// Constructor for a LoginBackEnd
        /// </summary>
        /// <param name="a_frontEnd">Associated FrontEnd</param>
        public LoginBackEnd(Login a_frontEnd)
        {
            m_frontEnd = a_frontEnd;
            a_frontEnd.Connect(this);
        }

        /// <summary>
        /// Login to Application
        /// </summary>
        /// <param name="a_username">Username to login using</param>
        /// <param name="a_password">Password to login using</param>
        public void Login(string a_username, string a_password)
        {
            if (ValidateLogin(a_username, a_password))
            {
                new MainMenu(CheckHR(a_username, a_password)).Show();
                m_frontEnd.Hide();
            }
        }

        /// <summary>
        /// Validate login details
        /// </summary>
        /// <param name="a_username">Username to login using</param>
        /// <param name="a_password">Password to login using</param>
        /// <returns>True if username matches password false if not</returns>
        private bool ValidateLogin(string a_username, string a_password)
        {
            if (DatabaseConnection.Instance.Open())
            {
                int l_count = -1;
                MySqlDataReader l_dataReader = DatabaseConnection.Instance.Select("SELECT COUNT(login_id) FROM logins WHERE username = '" + a_username + "' AND password = '" + a_password + "';");
                while (l_dataReader.Read())
                {
                    l_count = l_dataReader.GetInt32(0);
                }
                DatabaseConnection.Instance.Close();
                switch (l_count)
                {
                    case 1:
                        return true;
                    case 0:
                        MessageBox.Show("Incorrect Username and Password Combination");
                        return false;
                    case -1:
                        MessageBox.Show("No Users in database");
                        return false;
                    default:
                        MessageBox.Show("Multiple Users with same password, Please consult Database Admins");
                        return false;
                }
            }
            return false;
        }

        /// <summary>
        /// Check if user is in HR
        /// </summary>
        /// <param name="a_username">Username to check</param>
        /// <param name="a_password">Password to check</param>
        /// <returns>True if HR false if not</returns>
        private bool CheckHR(string a_username, string a_password)
        {
            if (DatabaseConnection.Instance.Open())
            {
                bool l_hr = false;
                MySqlDataReader l_dataReader = DatabaseConnection.Instance.Select("SELECT hr_user FROM logins WHERE username = '" + a_username + "' AND password = '" + a_password + "';");
                while (l_dataReader.Read())
                {
                    l_hr = l_dataReader.GetBoolean(0);
                }
                DatabaseConnection.Instance.Close();
                return l_hr;
            }
            return false;
        }
    }
}
