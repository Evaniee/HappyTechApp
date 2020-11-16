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
    public partial class CurrentPositions : Form
    {
        private CurrentPositionsBackEnd m_backEnd;
        private bool m_update;

        public CurrentPositions()
        {
            InitializeComponent();
            new CurrentPositionsBackEnd(this);
        }

        public void Connect(CurrentPositionsBackEnd a_backEnd)
        {
            m_backEnd = a_backEnd;
        }

        public void Populate(List<string> a_values)
        {
            m_update = true;
            cmb_currentPositions.DataSource = a_values;
            m_update = false;
        }

        private void cmb_currentPositions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!m_update)
                m_backEnd.SelectedNew(cmb_currentPositions.Text);
        }
    }
}
