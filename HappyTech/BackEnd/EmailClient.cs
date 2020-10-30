using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace HappyTech.BackEnd
{
    public class EmailClient
    {
        private static EmailClient m_instance;                                  // Current instance of the EmailClient Singleton

        private readonly string m_propertiesPath = @"EmailProperties.dat";      // Filepath for properties file containing email properties

        private SmtpClient m_client;                                            // SmtpClient for sending emails
        private string m_emailAddress;                                          // String version of SmtpClient's email address

        /// <summary>
        /// Private constructor for EmailClient Singleton
        /// </summary>
        private EmailClient()
        {
            Dictionary<string, string> l_properties = Properties();

            try
            {
                m_emailAddress = l_properties["EmailAddress"];

                m_client = new SmtpClient();
                m_client.Host = l_properties["Host"];
                m_client.Port = int.Parse(l_properties["Port"]);
                m_client.DeliveryMethod = SmtpDeliveryMethod.Network;
                m_client.UseDefaultCredentials = false;
                m_client.Credentials = new NetworkCredential(m_emailAddress, l_properties["Password"]);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Emails cannot be sent. Please check the file at " + @m_propertiesPath + " is correct and try again.");
            }
            // REMOVE FOR FINAL
            Debug.WriteLine("Instantiated EmailClient with the following properties\nHost: {0}\nPort: {1}\nEmailAddress: {2}\nPassword: {3}", l_properties["Host"], l_properties["Port"], l_properties["EmailAddress"], l_properties["Password"]);
        }

        /// <summary>
        /// Gets the current instance of the EmailClient Singleton or makes one if it does not exist
        /// </summary>
        public static EmailClient Instance 
        {
            get 
            {
                if (m_instance == null)
                    m_instance = new EmailClient();
                return m_instance;
            } 
        }

        /// <summary>
        /// Gets properties from filepath defined by m_propertiesPath
        /// </summary>
        /// <returns>Properties for Email Client or Null if file not found</returns>
        private Dictionary<string, string> Properties()
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
                foreach(string i_record in l_records)
                {
                    l_keyValuePair = i_record.Split('=');
                    l_properties.Add(l_keyValuePair[0], l_keyValuePair[1]);
                }
                l_reader.Close();
                return l_properties;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Email Properties file cannot be found. Expected path: " + @m_propertiesPath + ".");
                return null;
            }
        }

        /// <summary>
        /// Attempt to send an email
        /// </summary>
        /// <param name="a_email">Email to send</param>
        /// <returns>True if successful, False if not</returns>
        public bool SendEmail(MailMessage a_email)
        {
            try
            {
                m_client.Send(a_email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the email address of the EmailClient Singleton
        /// </summary>
        public string EmailAddress { get { return m_emailAddress; } }
    }
}
