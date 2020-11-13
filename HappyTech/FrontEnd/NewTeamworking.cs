using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HappyTech.BackEnd.DatabaseClasses;
using HappyTech.BackEnd.FormBackEnds;

namespace HappyTech.FrontEnd
{
    public partial class NewTeamworking : Form
    {
        private NewTeamworkingBackEnd m_backEnd;
        public NewTeamworking(TemplateTeamworkingBackEnd a_templateTeamworkingBackEnd, Teamworking a_teamworking)
        {
            new NewTeamworkingBackEnd(this, a_templateTeamworkingBackEnd);
            InitializeComponent();
            m_backEnd.Populate(a_teamworking);
        }

        public void Connect(NewTeamworkingBackEnd a_backEnd)
        {
            m_backEnd = a_backEnd;
        }

        public void Populate(string a_teamworking)
        {
            if (a_teamworking != null)
                txt_teamworkingReq.Text = a_teamworking;
        }

        private void btn_teamworkingAdd_Click(object sender, EventArgs e)
        {
            m_backEnd.Submit(txt_teamworkingReq.Text);
        }


        /// <summary>
        /// Getter for back end
        /// </summary>
        public NewTeamworkingBackEnd BackEnd { get { return m_backEnd; } }
    }
}
