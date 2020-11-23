using HappyTech.BackEnd.DatabaseClasses;
using HappyTech.FrontEnd;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Text;
using System.Windows.Forms;

namespace HappyTech.BackEnd.FormBackEnds
{
    public class TemplateSkillsetBackEnd
    {
        FrontEnd.TemplateSkillset m_frontEnd;                
        NewTemplateBackEnd m_newTemplateBackEnd;        
        List<Skillset> m_skillsets;

        /// <summary>
        /// Constructor for TemplateSkillsetBackEnd
        /// </summary>
        /// <param name="a_newTemplateBackEnd"></param>
        /// <param name="a_skillsets"></param>
        public TemplateSkillsetBackEnd(NewTemplateBackEnd a_newTemplateBackEnd, List<Skillset> a_skillsets)
        {
            m_skillsets = a_skillsets;
            new FrontEnd.TemplateSkillset(this);
            m_newTemplateBackEnd = a_newTemplateBackEnd;
        }

        /// <summary>
        /// To connect to front end
        /// </summary>
        /// <param name="a_templateSkillset"></param>
        public void Connect(FrontEnd.TemplateSkillset a_templateSkillset)
        {
            m_frontEnd = a_templateSkillset;
        }

        /// <summary>
        /// To open front end
        /// </summary>
        public void Open()
        {
            m_frontEnd.Show();
            UpdateFrontEnd();
        }

        /// <summary>
        /// Adds a new skillset or an existing from the database to the template
        /// </summary>
        /// <param name="a_skillsetString"></param>
        public void AddNewSkillset(string a_skillsetString)
        {
            //if question is in the database
            if (a_skillsetString != "New Skillset")
            {
                string[] l_skillsetArray = a_skillsetString.Split(':');
                int l_skillsetID = int.Parse(l_skillsetArray[0]);
                List<Skillset> l_allSkillsets = BuisnessMetaLayer.Instance.GetDBSkillset();
                Skillset l_skillset = l_allSkillsets.Find(x => x.skillset_id == l_skillsetID);
                m_skillsets.Add(l_skillset);
                UpdateFrontEnd();
            }
            //if question is new
            else
                AddExistingSkillset(null);
        }

        /// <summary>
        /// add skillset that already exists
        /// </summary>
        /// <param name="a_skillsetString"></param>
        public void AddExistingSkillset(string a_skillsetString)
        {
            Skillset l_skillset = new Skillset();

            if (a_skillsetString != null)
            {
                string[] l_skillsetArray = a_skillsetString.Split(':');
                int l_skillsetID = int.Parse(l_skillsetArray[0]);
                List<Skillset> l_allSkillsets = BuisnessMetaLayer.Instance.GetDBSkillset();
                l_skillset = l_allSkillsets.Find(x => x.skillset_id == l_skillsetID);
            }
            new FrontEnd.NewSkillset(this, l_skillset).Show();
        }

        /// <summary>
        /// remove skillset from the template
        /// </summary>
        /// <param name="a_skillsetString"></param>
        public void RemoveSkillset(string a_skillsetString)
        {
            string[] l_skillsetArray = a_skillsetString.Split(':');
            int l_skillsetID = int.Parse(l_skillsetArray[0]);
            List<Skillset> l_skillsets = BuisnessMetaLayer.Instance.GetDBSkillset();
            Skillset l_skillset = l_skillsets.Find(x => x.skillset_id == l_skillsetID);
            DialogResult l_remove = MessageBox.Show("Remove Skillset From Template?:\n" + l_skillset.skillset_id + ": " + l_skillset.skillset, "Delete Skillset?", MessageBoxButtons.YesNo);
            if (l_remove == DialogResult.Yes)
            {
                m_skillsets.RemoveAll(x => x.skillset_id == l_skillsetID);
            }
            UpdateFrontEnd();
            UpdateNewTemplate();
        }

        /// <summary>
        /// Update the template back end with new values
        /// </summary>
        public void UpdateNewTemplate()
        {
            m_newTemplateBackEnd.UpdateSkillset(m_skillsets);
        }

        /// <summary>
        /// adds skillset to list
        /// </summary>
        /// <param name="a_skillset"></param>
        public void AddSkillset(Skillset a_skillset)
        {
            m_skillsets.Add(a_skillset);
            UpdateNewTemplate();
            UpdateFrontEnd();
        }

        /// <summary>
        /// updates front end
        /// </summary>
        public void UpdateFrontEnd()
        {
            List<Skillset> l_allSkillsets = BuisnessMetaLayer.Instance.GetDBSkillset();

            List<string> l_addValues = new List<string>();
            l_addValues.Add("New Skillset");
            foreach (Skillset i_skillset in l_allSkillsets)
                if (m_skillsets.Find(x => x.skillset_id == i_skillset.skillset_id) == null)
                    l_addValues.Add(i_skillset.skillset_id + ": " + i_skillset.skillset + "\n");

            List<string> l_editValues = new List<string>();
            foreach (Skillset i_skillset in l_allSkillsets)
                l_editValues.Add(i_skillset.skillset_id + ": " + i_skillset.skillset);

            List<string> l_removeValues = new List<string>();
            foreach (Skillset i_skillset in m_skillsets)
                l_removeValues.Add(i_skillset.skillset_id + ": " + i_skillset.skillset);

            StringBuilder l_textValue = new StringBuilder();
            foreach (Skillset i_skillset in m_skillsets)
                l_textValue.Append(Environment.NewLine + i_skillset.skillset_id + ": " + i_skillset.skillset);
            l_textValue.Append("");
            string l_textBoxValue = l_textValue.ToString();
            l_textValue.Clear();

            m_frontEnd.Update(l_addValues, l_editValues, l_removeValues, l_textBoxValue);
        }
    }
}
