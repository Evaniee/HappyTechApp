using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HappyTech.FrontEnd
{
    public partial class NewPosition : Form
    {
        public NewPosition()
        {
            InitializeComponent();
        }

        public void Populate_cmb_jobTemplate(List<string> a_values)
        {
            cmb_jobTemplate.DataSource = a_values;
        }

        private void cmb_jobTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
