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

                m_client = new SmtpClient(l_properties["Host"], int.Parse(l_properties["Port"]));
                m_client.DeliveryMethod = SmtpDeliveryMethod.Network;
                m_client.UseDefaultCredentials = false;
                m_client.EnableSsl = true;
                m_client.Credentials = new NetworkCredential(m_emailAddress, l_properties["Password"]);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Emails cannot be sent. Please check the file at " + @m_propertiesPath + " is correct and try again.");
            }
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
        /// <param name="a_applicantEmailAddress">Email Address of Applicant</param>
        /// <param name="a_jobPositionName">Name of job position</param>
        /// <param name="a_hired">If Hired</param>
        /// <param name="a_pdfName">Name of PDF</param>
        /// <returns>True if sent, False if not</returns>
        public bool SendEmail(string a_applicantEmailAddress, string a_jobPositionName, bool a_hired, string a_pdfName)
        {
            try
            {
                m_client.Send(MakeEmail(a_applicantEmailAddress, a_jobPositionName, a_hired, a_pdfName));
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Create email to send
        /// </summary>
        /// <param name="a_applicantAddress">Email Address of Applicant</param>
        /// <param name="a_jobPosition">Name of job position</param>
        /// <param name="a_hired">If Hired</param>
        /// <param name="a_pdfName">Name of PDF</param>
        /// <returns>Email to Send</returns>
        private MailMessage MakeEmail(string a_applicantAddress, string a_jobPosition, bool a_hired, string a_pdfName)
        {
            string l_subject = "Feedback from your HappyTech " + @a_jobPosition + @" application";
            string l_body;
            if (a_hired)
                l_body = "Thank you for applying for the positon of " + @a_jobPosition + @" at HappyTech are happy to inform you that you have been chosen for the postion. Please find attached feedback from your application";
            else
                l_body = "Thank you for applying for the positon of " + @a_jobPosition + @" at HappyTech we regret to inform you that you have not been chosen for the postion. Please find attached feedback from your application";
            MailMessage l_mailMessage = new MailMessage(m_emailAddress, a_applicantAddress, l_subject, l_body);
            l_mailMessage.From = new MailAddress(m_emailAddress, @"HappyTech");
            l_mailMessage.Priority = MailPriority.High;
            l_mailMessage.Attachments.Add(new Attachment(a_pdfName));
            return l_mailMessage;
        }

        /// <summary>
        /// Gets the email address of the EmailClient Singleton
        /// </summary>
        public string EmailAddress { get { return m_emailAddress; } }
    }
}
