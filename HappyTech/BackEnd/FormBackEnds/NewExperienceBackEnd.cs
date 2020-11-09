using HappyTech.BackEnd.DatabaseClasses;
using System;
using System.Collections.Generic;
using System.Text;
using HappyTech.FrontEnd;


namespace HappyTech.BackEnd.FormBackEnds
{
    public class NewExperienceBackEnd
    {
        private NewExperience m_frontend;                                   // Associated Front End
        private TemplateExperienceBackEnd m_templateExperienceBackEnd;      // Associated Template Experience Back End

        /// <summary>
        /// Constructor for NewExperienceBackEnd
        /// </summary>
        /// <param name="a_frontEnd">Associated Front End</param>
        /// <param name="a_templateExperienceBackEnd">Associated template experience back end</param>
        public NewExperienceBackEnd(NewExperience a_frontEnd, TemplateExperienceBackEnd a_templateExperienceBackEnd)
        {
            m_frontend = a_frontEnd;
            m_frontend.Connect(this);
            m_templateExperienceBackEnd = a_templateExperienceBackEnd;
        }

        /// <summary>
        /// Return fields to populate form with
        /// </summary>
        /// <param name="a_experience">Experience to populate using</param>
        public void Populate(Experience a_experience)
        {
            m_frontend.Populate(a_experience.experience, a_experience.response1, a_experience.response2, a_experience.response3, a_experience.response4, a_experience.response5);
        }

        /// <summary>
        /// Submit a experience to the database
        /// </summary>
        /// <param name="a_experience">Experience of new experience</param>
        /// <param name="a_response1">Response 1 of new experience</param>
        /// <param name="a_response2">Response 2 of new experience</param>
        /// <param name="a_response3">Response 3 of new experience</param>
        /// <param name="a_response4">Response 4 of new experience</param>
        /// <param name="a_response5">Response 5 of new experience</param>
        public void Submit(string a_experience, string a_response1, string a_response2, string a_response3, string a_response4, string a_response5)
        {
            string a_insertSQL = "INSERT INTO experience VALUES (null, '" + a_experience + "', '" + a_response1 + "', '" + a_response2 + "', '" + a_response3 + "', '" + a_response4 + "', '" + a_response5 + "');";
            BuisnessMetaLayer.Instance.Insert(a_insertSQL);
            List<Experience> l_allExperiences = BuisnessMetaLayer.Instance.GetDBExperience();
            List<Experience> l_experiences = l_allExperiences.FindAll(x => x.experience == a_experience);
            Experience l_experience = null;
            if (l_experiences.Count > 1)
            {
                foreach (Experience i_experience in l_experiences)
                {
                    if (i_experience.response1 == a_response1)
                        if (i_experience.response2 == a_response2)
                            if (i_experience.response3 == a_response3)
                                if (i_experience.response4 == a_response4)
                                    if (i_experience.response5 == a_response5)
                                    {
                                        l_experience = i_experience;
                                        break;
                                    }
                }
            }
            else
                l_experience = l_experiences[0];
            m_templateExperienceBackEnd.AddExperience(l_experience);
            m_frontend.Close();
        }
    }
}
