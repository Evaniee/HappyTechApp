using HappyTech.BackEnd.DatabaseClasses;
using HappyTech.FrontEnd;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Text;
using System.Windows.Forms;

namespace HappyTech.BackEnd.FormBackEnds
{
    public class TemplateTeamworkingBackEnd
    {
        FrontEnd.TemplateTeamworking m_frontEnd;           // Associated Front End
        NewTemplateBackEnd m_newTemplateBackEnd;        // NewTemplateBackEnd to inform
        List<Teamworking> m_teamworking;                     // Template's teamworking

        /// <summary>
        /// Constructor for TemplateTeamworkingnBackEnd
        /// </summary>
        /// <param name="a_newTeamworkingBackEnd">NewTemplateBackEnd to inform</param>
        public TemplateTeamworkingBackEnd(NewTemplateBackEnd a_newTemplateBackEnd, List<Teamworking> a_teamworking)
        {
            m_teamworking = a_teamworking;
            new FrontEnd.TemplateTeamworking(this);
            m_newTemplateBackEnd = a_newTemplateBackEnd;
        }

        public void Connect(FrontEnd.TemplateTeamworking a_templateTeamworking)
        {
            m_frontEnd = a_templateTeamworking;
        }

        public void Open()
        {
            m_frontEnd.Show();
            UpdateFrontEnd();
        }

        /// <summary>
        /// Add a new question or a question from the database to the template
        /// </summary>
        /// <param name="a_teamworkingString"></param>
        public void AddNewTeamworking(string a_teamworkingString)
        {
            // For Teamworking in DB
            if (a_teamworkingString != "New Teamworking")
            {
                string[] l_teamworkingArray = a_teamworkingString.Split(':');
                int l_teamworkingID = int.Parse(l_teamworkingArray[0]);
                List<Teamworking> l_allTeamworking = BuisnessMetaLayer.Instance.GetDBTeamworking();
                Teamworking l_teamworking = l_allTeamworking.Find(x => x.teamworking_id == l_teamworkingID);
                m_teamworking.Add(l_teamworking);
                UpdateFrontEnd();
            }
            // For new Question
            else
                AddExistingTeamworking(null);
        }

        /// <summary>
        /// Add a alternative version of an existing teamworking to the template
        /// </summary>
        /// <param name="a_teamworkingString">Teamworking as a string</param>
        public void AddExistingTeamworking(string a_teamworkingString)
        {
            Teamworking l_teamworking = new Teamworking();

            // If not a new question
            if (a_teamworkingString != null)
            {
                string[] l_teamworkingArray = a_teamworkingString.Split(':');
                int l_teamworkingID = int.Parse(l_teamworkingArray[0]);
                List<Teamworking> l_allTeamworkings = BuisnessMetaLayer.Instance.GetDBTeamworking();
                l_teamworking = l_allTeamworkings.Find(x => x.teamworking_id == l_teamworkingID);
            }
            new FrontEnd.NewTeamworking(this, l_teamworking).Show();
        }

        /// <summary>
        /// Remove a question from the template
        /// </summary>
        /// <param name="a_teamworkingString">Teamworking as a strng</param>
        public void RemoveTeamworking(string a_teamworkingString)
        {
            string[] l_teamworkingArray = a_teamworkingString.Split(':');
            int l_teamworkingID = int.Parse(l_teamworkingArray[0]);
            List<Teamworking> l_teamworkings = BuisnessMetaLayer.Instance.GetDBTeamworking();
            Teamworking l_teamworking = l_teamworkings.Find(x => x.teamworking_id == l_teamworkingID);
            DialogResult l_remove = MessageBox.Show("Remove Teamworking From Template?:\n" + l_teamworking.teamworking_id + ": " + l_teamworking.teamworking, "Delete Teamworking?", MessageBoxButtons.YesNo);
            if (l_remove == DialogResult.Yes)
            {
                m_teamworking.RemoveAll(x => x.teamworking_id == l_teamworkingID);
            }
            UpdateFrontEnd();
            UpdateNewTemplate();
        }

        /// <summary>
        /// Update new template back end with new values
        /// </summary>
        public void UpdateNewTemplate()
        {
            m_newTemplateBackEnd.UpdateTeamworking(m_teamworking);
        }

        public void AddTeamworking(Teamworking a_teamworking)
        {
            m_teamworking.Add(a_teamworking);
            UpdateNewTemplate();
            UpdateFrontEnd();
        }

        /// <summary>
        /// Provides new values to update combo boxes on front end
        /// </summary>
        /// <returns>Tuple containing AddValues, EditValues and RemoveValues</returns>
        public void UpdateFrontEnd()
        {
            // All questions in Database
            List<Teamworking> l_allTeamworking = BuisnessMetaLayer.Instance.GetDBTeamworking();

            // Add
            // Add all values not present in m_teamworking and new
            List<string> l_addValues = new List<string>();
            l_addValues.Add("New Teamworking");
            foreach (Teamworking i_teamworking in l_allTeamworking)
                if (m_teamworking.Find(x => x.teamworking_id == i_teamworking.teamworking_id) == null)
                    l_addValues.Add(i_teamworking.teamworking_id + ": " + i_teamworking.teamworking + "\n");

            // Edit
            // Add all values
            List<string> l_editValues = new List<string>();
            foreach (Teamworking i_teamworking in l_allTeamworking)
                l_editValues.Add(i_teamworking.teamworking_id + ": " + i_teamworking.teamworking);

            // Remove
            // Add all present values
            List<string> l_removeValues = new List<string>();
            foreach (Teamworking i_teamworking in m_teamworking)
                l_removeValues.Add(i_teamworking.teamworking_id + ": " + i_teamworking.teamworking);

            // Text Box
            // Title + all present values
            StringBuilder l_textValue = new StringBuilder();
            foreach (Teamworking i_teamworking in m_teamworking)
                l_textValue.Append(Environment.NewLine + i_teamworking.teamworking_id + ": " + i_teamworking.teamworking);
            l_textValue.Append("");
            string l_textBoxValue = l_textValue.ToString();
            l_textValue.Clear();

            m_frontEnd.Update(l_addValues, l_editValues, l_removeValues, l_textBoxValue);
        }
    }
}

