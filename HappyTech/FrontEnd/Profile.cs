using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HappyTech.FrontEnd
{
    public partial class Profile : Form
    {
        private HappyTech.BackEnd.DatabaseClasses.Applicant m_applicant;
        public Profile(HappyTech.BackEnd.DatabaseClasses.Applicant a_applicant)
        {
            m_applicant = a_applicant;
            InitializeComponent();
            Populate(a_applicant);
        }

        private void Populate(HappyTech.BackEnd.DatabaseClasses.Applicant a_applicant)
        {
            this.lbl_title.Text = "Profile: [" + a_applicant.applicant_id + "] " + a_applicant.name;
            this.lbl_name.Text = "Name: " + a_applicant.name;
            this.lbl_age.Text = "Age: " + a_applicant.age;
            this.lbl_address.Text = "Address: " + a_applicant.address;
            this.lbl_emailAddress.Text = "Email Address: " + a_applicant.email_address;
            this.lbl_contactNumber.Text = "Contact Number: " + a_applicant.contact_number;
            this.lbl_disabilities.Text = "Disabilities: " + a_applicant.disabilities;
            this.chk_rightToWork.Checked = a_applicant.right_to_work;
        }
    }
}
