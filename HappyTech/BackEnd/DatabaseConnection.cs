using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Text;
using System.IO;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace HappyTech.BackEnd
{
    public class DatabaseConnection
    {
        /*
         * Based off the example at
         * https://www.codeproject.com/Articles/43438/Connect-C-to-MySQL
         */

        private static DatabaseConnection m_instance;                                       // Current instance of the DatabaseConnection Singleton

        private const string m_propertiesPath = @"DatabaseConnectionProperties.dat";        // Filepath for properties file containing database connection properties

        private MySqlConnection m_connection;                                               // Database Connection

        /// <summary>
        /// Private constructor for DatabaseConnection
        /// </summary>
        private DatabaseConnection()
        {
            Dictionary<string, string> l_properties = Properties();
            string l_connectionString;

            // If properties uses an account with a password
            if (l_properties.ContainsKey("Password)"))
                l_connectionString = "server=" + l_properties["Server"] + ";database=" + l_properties["Database"] + ";uid=" + l_properties["User"] + ";password=" + l_properties["Password"];
            else
                l_connectionString = "server=" + l_properties["Server"] + ";database=" + l_properties["Database"] + ";uid=" + l_properties["User"];

            m_connection = new MySqlConnection(l_connectionString);

            // REMOVE FOR FINAL
            //Debug.WriteLine("Connection string: {0}", l_connectionString);
        }

        /// <summary>
        /// Gets the current instance of the BuisnessMetaLayer Singletone or makes one if it does not exist
        /// </summary>
        public static DatabaseConnection Instance
        {
            get
            {
                if (m_instance == null)
                    m_instance = new DatabaseConnection();
                return m_instance;
            }
        }

        /// <summary>
        /// Gets properties from filepath defined by m_propertiesPath
        /// </summary>
        /// <returns>Properties for Email Client or Null if file not found</returns>
        public Dictionary<string, string> Properties()
        {
            string l_fileData = null;
            Dictionary<string, string> l_properties = new Dictionary<string, string>();

            // Read from Properties
            try
            {
                StreamReader l_reader = new StreamReader(m_propertiesPath);
                using (l_reader) l_fileData = l_reader.ReadToEnd().Replace("\r", "");

                string[] l_keyValuePair;
                string[] l_records = l_fileData.Split('\n');
                foreach (string i_record in l_records)
                {
                    l_keyValuePair = i_record.Split('=');
                    l_properties.Add(l_keyValuePair[0], l_keyValuePair[1]);
                }
                l_reader.Close();
                return l_properties;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Database Connection Properties file cannot be found. Expected path: " + @m_propertiesPath + ".");
                return null;
            }
        }

        #region SQL Statements

        /// <summary>
        /// Attempts to open a connection to the database.
        /// Message boxes prompt on errors, detailed error messages for 0 and 1045
        /// </summary>
        /// <returns>True if successful, false if errors</returns>
        public bool Open()
        {
            try
            {
                if(m_connection.State != System.Data.ConnectionState.Open) 
                    m_connection.Open();
                return true;
            }
            catch(MySqlException e)
            {
                switch (e.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server");
                        return false;
                    case 1045:
                        MessageBox.Show("Invalid Username and / or Password combination from properties file (" + m_propertiesPath + ")");
                        return false;
                    default:
                        MessageBox.Show("Error: " + e.Message);
                        return false;
                }
            }
        }

        /// <summary>
        /// Attempts to close a connection to the database.
        /// Message boxes prompt on errors
        /// </summary>
        /// <returns>True if successful, false if errors</returns>
        public bool Close()
        {
            try
            {
                m_connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Attempt to perform a INSERT statement on the database
        /// Messages boxes prompt on errors
        /// </summary>
        /// <param name="a_insertSQL">INSERT statement string</param>
        /// <returns>True if successful, false if errors</returns>
        public bool Insert(string a_insertSQL)
        {
            try
            {
                if (Open())
                {
                    MySqlCommand l_command = new MySqlCommand();
                    l_command.CommandText = a_insertSQL;
                    l_command.Connection = m_connection;
                    l_command.ExecuteNonQuery();
                    if (Close())
                        return true;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            return false;
        }

        /// <summary>
        /// Attempt to perform a UPDATE statement on the database
        /// Messages boxes prompt on errors
        /// </summary>
        /// <param name="a_updateSQL">UPDATE statement string</param>
        /// <returns>True if successful, false if errors</returns>
        public bool Update(string a_updateSQL)
        {
            try
            {
                if (Open())
                {
                    MySqlCommand l_command = new MySqlCommand();
                    l_command.CommandText = a_updateSQL;
                    l_command.Connection = m_connection;
                    l_command.ExecuteNonQuery();
                    if (Close())
                        return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                return false;
            }
            return false;
        }

        /// <summary>
        /// Attempt to perform a DELETE statement on the database
        /// Messages boxes prompt on errors
        /// </summary>
        /// <param name="a_deleteSQL">DELETE statement string</param>
        /// <returns>True if successful, false if errors</returns>
        public bool Delete(string a_deleteSQL)
        {
            try
            {
                if (Open())
                {
                    MySqlCommand l_command = new MySqlCommand();
                    l_command.CommandText = a_deleteSQL;
                    l_command.Connection = m_connection;
                    l_command.ExecuteNonQuery();
                    if (Close())
                        return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            return false;
        }

        /// <summary>
        /// Attempt to perform a SELECT query on the database
        /// Message boxes prompt on errors
        /// </summary>
        /// <param name="a_selectSQL">SELECT query string</param>
        /// <returns>MySqlDataReader containing read information, null if errors</returns>
        public MySqlDataReader Select(string a_selectSQL)
        {
            try
            {
                if (Open())
                    if (m_connection != null)
                    {
                        MySqlCommand l_command = new MySqlCommand();
                        l_command.CommandText = a_selectSQL;
                        l_command.Connection = m_connection;
                        MySqlDataReader l_dataReader = l_command.ExecuteReader();
                        return l_dataReader;
                    }
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            return null;
        }

        #endregion
    }
}
