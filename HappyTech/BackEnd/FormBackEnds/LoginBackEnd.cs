using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HappyTech.BackEnd.FormBackEnds
{
    class LoginBackEnd
    {
        public bool ValidateLogin(string a_username, string a_password)
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

        public bool CheckHR(string a_username, string a_password)
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
