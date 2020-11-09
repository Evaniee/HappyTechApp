using HappyTech.BackEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HappyTech.BackEnd.DatabaseClasses;

namespace HappyTech.FrontEnd
{
    public partial class NewExperience : Form
    {
        public NewExperience()
        {
            InitializeComponent();
        }

        private void cmb_test_DropDown(object sender, EventArgs e)
        {
            List<string> l_comboValues = new List<string>();
            l_comboValues.Add("New Experience");
            foreach (Experience i_experience in BuisnessMetaLayer.Instance.GetDBExperience())
            {
                l_comboValues.Add(i_experience.experience_id + ": " + i_experience.experience);
            }

            // Initialize combo box
            var comboBox = new ComboBox
            {
                DataSource = l_comboValues,
                Location = new System.Drawing.Point(12, 12),
                Name = "comboBox",
                Size = new System.Drawing.Size(166, 21),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            // Add the combo box to the form.
            this.Controls.Add(comboBox);
        }
    }
}
