using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HappyTech.BackEnd.FormBackEnds;

namespace HappyTech.FrontEnd
{
    public partial class TemplateTeamworking : Form
    {
        private TemplateTeamworkingBackEnd m_templateTeamworkingBackEnd;

        public TemplateTeamworking(TemplateTeamworkingBackEnd a_backEnd)
        {
            m_templateTeamworkingBackEnd = a_backEnd;
            InitializeComponent();
            m_templateTeamworkingBackEnd.Connect(this);
            m_templateTeamworkingBackEnd.UpdateFrontEnd();
        }

        private void NewTeamworking_Load(object sender, EventArgs e)
        {

        }
    }
}
