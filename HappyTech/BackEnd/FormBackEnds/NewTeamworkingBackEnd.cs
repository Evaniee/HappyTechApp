using HappyTech.BackEnd.DatabaseClasses;
using System;
using System.Collections.Generic;
using System.Text;
using HappyTech.FrontEnd;

namespace HappyTech.BackEnd.FormBackEnds
{
    public class NewTeamworkingBackEnd
    {
        NewTeamworking m_frontend;                                 // Associated Front End
        TemplateTeamworkingBackEnd m_templateTeamworkingBackEnd;

        public NewTeamworkingBackEnd(NewTeamworking a_frontEnd, TemplateTeamworkingBackEnd a_templateTeamworkingBackEnd)
        {
            m_frontend = a_frontEnd;
            m_frontend.Connect(this);
            m_templateTeamworkingBackEnd = a_templateTeamworkingBackEnd;
        }

        public void Populate(Teamworking a_teamworking)
        {
            m_frontend.Populate(a_teamworking.teamworking);
        }

        public void Submit(string a_teamworking)
        {
            string a_insertSQL = "INSERT INTO teamworking VALUES (null, '" + a_teamworking + "');";
            BuisnessMetaLayer.Instance.Insert(a_insertSQL);
            List<Teamworking> l_allTeamworkings = BuisnessMetaLayer.Instance.GetDBTeamworking();
            List<Teamworking> l_teamworkings = l_allTeamworkings.FindAll(x => x.teamworking == a_teamworking);
            Teamworking l_teamworking = null;
            if (l_teamworkings.Count > 1)
            {
                foreach (Teamworking i_teamworking in l_teamworkings)
                {

                    l_teamworking = i_teamworking;
                    break;

                }
            }
            else
                l_teamworking = l_teamworkings[0];
            m_templateTeamworkingBackEnd.AddTeamworking(l_teamworking);
            m_frontend.Close();
        }
    }


}
