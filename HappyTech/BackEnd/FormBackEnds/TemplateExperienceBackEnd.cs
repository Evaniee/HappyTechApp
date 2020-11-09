using HappyTech.BackEnd.DatabaseClasses;
using HappyTech.FrontEnd;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Text;
using System.Windows.Forms;

namespace HappyTech.BackEnd.FormBackEnds
{
    public class TemplateExperienceBackEnd
    {
        FrontEnd.TemplateExperience m_frontEnd;           // Associated Front End
        NewTemplateBackEnd m_newTemplateBackEnd;        // NewTemplateBackEnd to inform
        List<Experience> m_experiences;                     // Template's experiences

        /// <summary>
        /// Constructor for TemplateExperienceBackEnd
        /// </summary>
        /// <param name="a_newTemplateBackEnd">NewTemplateBackEnd to inform</param>
        public TemplateExperienceBackEnd(NewTemplateBackEnd a_newTemplateBackEnd, List<Experience> a_experiences)
        {
            m_experiences = a_experiences;
            new FrontEnd.TemplateExperience(this);
            m_newTemplateBackEnd = a_newTemplateBackEnd;
        }

        public void Connect(FrontEnd.TemplateExperience a_templateExperience)
        {
            m_frontEnd = a_templateExperience;
        }

        public void Open()
        {
            m_frontEnd.Show();
            UpdateFrontEnd();
        }

        /// <summary>
        /// Add a new experience or a experience from the database to the template
        /// </summary>
        /// <param name="a_experienceString"></param>
        public void AddNewExperience(string a_experienceString)
        {
            // For Experience in DB
            if (a_experienceString != "New Experience")
            {
                string[] l_experienceArray = a_experienceString.Split(':');
                int l_experienceID = int.Parse(l_experienceArray[0]);
                List<Experience> l_allExperiences = BuisnessMetaLayer.Instance.GetDBExperience();
                Experience l_experience = l_allExperiences.Find(x => x.experience_id == l_experienceID);
                m_experiences.Add(l_experience);
                UpdateFrontEnd();
            }
            // For new Experience
            else
                AddExistingExperience(null);
        }

        /// <summary>
        /// Add a alternative version of an existing experience to the template
        /// </summary>
        /// <param name="a_experienceString">Experience as a string</param>
        public void AddExistingExperience(string a_experienceString)
        {
            Experience l_experience = new Experience();

            // If not a new experience
            if (a_experienceString != null)
            {
                string[] l_experienceArray = a_experienceString.Split(':');
                int l_experienceID = int.Parse(l_experienceArray[0]);
                List<Experience> l_allExperiences = BuisnessMetaLayer.Instance.GetDBExperience();
                l_experience = l_allExperiences.Find(x => x.experience_id == l_experienceID);
            }
            new FrontEnd.NewExperience(this, l_experience).Show();
        }

        /// <summary>
        /// Remove a experience from the template
        /// </summary>
        /// <param name="a_experienceString">Experience as a strng</param>
        public void RemoveExperience(string a_experienceString)
        {
            string[] l_experienceArray = a_experienceString.Split(':');
            int l_experienceID = int.Parse(l_experienceArray[0]);
            List<Experience> l_experiences = BuisnessMetaLayer.Instance.GetDBExperience();
            Experience l_experience = l_experiences.Find(x => x.experience_id == l_experienceID);
            DialogResult l_remove = MessageBox.Show("Remove Experience From Template?:\n" + l_experience.experience_id + ": " + l_experience.experience, "Delete Experience?", MessageBoxButtons.YesNo);
            if (l_remove == DialogResult.Yes)
            {
                m_experiences.RemoveAll(x => x.experience_id == l_experienceID);
            }
            UpdateFrontEnd();
            UpdateNewTemplate();
        }

        /// <summary>
        /// Update new template back end with new values
        /// </summary>
        public void UpdateNewTemplate()
        {
            m_newTemplateBackEnd.UpdateExperiences(m_experiences);
        }

        public void AddExperience(Experience a_experience)
        {
            m_experiences.Add(a_experience);
            UpdateNewTemplate();
            UpdateFrontEnd();
        }

        /// <summary>
        /// Provides new values to update combo boxes on front end
        /// </summary>
        /// <returns>Tuple containing AddValues, EditValues and RemoveValues</returns>
        public void UpdateFrontEnd()
        {
            // All experiences in Database
            List<Experience> l_allExperiences = BuisnessMetaLayer.Instance.GetDBExperience();

            // Add
            // Add all values not present in m_experiences and new
            List<string> l_addValues = new List<string>();
            l_addValues.Add("New Experience");
            foreach (Experience i_experience in l_allExperiences)
                if (m_experiences.Find(x => x.experience_id == i_experience.experience_id) == null)
                    l_addValues.Add(i_experience.experience_id + ": " + i_experience.experience + "\n");

            // Edit
            // Add all values
            List<string> l_editValues = new List<string>();
            foreach (Experience i_experience in l_allExperiences)
                l_editValues.Add(i_experience.experience_id + ": " + i_experience.experience);

            // Remove
            // Add all present values
            List<string> l_removeValues = new List<string>();
            foreach (Experience i_experience in m_experiences)
                l_removeValues.Add(i_experience.experience_id + ": " + i_experience.experience);

            // Text Box
            // Title + all present values
            StringBuilder l_textValue = new StringBuilder();
            foreach (Experience i_experience in m_experiences)
                l_textValue.Append(Environment.NewLine + i_experience.experience_id + ": " + i_experience.experience);
            l_textValue.Append("");
            string l_textBoxValue = l_textValue.ToString();
            l_textValue.Clear();

            m_frontEnd.Update(l_addValues, l_editValues, l_removeValues, l_textBoxValue);
        }
    }
}
