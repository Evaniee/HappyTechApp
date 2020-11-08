using HappyTech.BackEnd.DatabaseClasses;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using HappyTech.FrontEnd;
using System.Windows.Forms;

namespace HappyTech.BackEnd.FormBackEnds
{
    public class NewPositionBackEnd
    {
        NewPosition m_frontEnd;         // Associated front end

        /// <summary>
        /// Constructor for New Position Back End
        /// </summary>
        /// <param name="a_frontEnd">Associated front end</param>
        public NewPositionBackEnd(NewPosition a_frontEnd)
        {
            m_frontEnd = a_frontEnd;
            m_frontEnd.Connect(this);
        }

        /// <summary>
        /// Generate values to populate job template drop down box
        /// </summary>
        /// <returns>Values to populate job template drop down box with</returns>
        public List<string> PopulateJobTemplate()
        {
            List<string> l_values = new List<string>();
            l_values.Add("New Template");
            List<Template> l_templates = BuisnessMetaLayer.Instance.GetDBTemplate();
            foreach (Template i_template in l_templates)
            {
                string l_value = i_template.template_id + ": " + i_template.title;
                l_values.Add(l_value);
            }
            return l_values;
        }

        /// <summary>
        /// Check selected index and open new template if 0
        /// </summary>
        /// <param name="a_selectedIndex">Current index selected</param>
        public void TemplateSelected(int a_selectedIndex)
        {
            if (a_selectedIndex == 0)
                new NewTemplate().Show();
        }

        /// <summary>
        /// Submits JobPosition to Database
        /// </summary>
        /// <param name="a_title">Position Title</param>
        /// <param name="a_code">Position Code</param>
        /// <param name="a_description">Poistion Description</param>
        /// <param name="a_template">Position Template</param>
        public void SubmitPosition(string a_title, string a_code, string a_description, string a_template)
        {
            string[] a_templateArray = a_template.Split(':');
            string a_template_id = a_templateArray[0];
            string a_insertSQL = "INSERT INTO job_position VALUES ('" + a_code + "', " + a_template_id + ", '" + a_title + "', '" + a_description + "');";
            if (BuisnessMetaLayer.Instance.Insert(a_insertSQL))
                m_frontEnd.Close();
            else
                DatabaseConnection.Instance.Close();
        }
    }
}
