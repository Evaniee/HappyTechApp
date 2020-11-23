using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HappyTech.FrontEnd
{
    public partial class NewApplicant : Form
    {
        private HappyTech.BackEnd.DatabaseClasses.JobPosition m_jobPosition;    // Job Position Applicnat is applying for
        
        /// <summary>
        /// Constructor for NewApplicant form
        /// </summary>
        /// <param name="a_jobPosition">Job position applicant is applying for</param>
        public NewApplicant(HappyTech.BackEnd.DatabaseClasses.JobPosition a_jobPosition)
        {
            InitializeComponent();
            m_jobPosition = a_jobPosition;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string l_name = txt_name.Text;
            string l_age = txt_age.Text;
            string l_address = txt_address.Text;
            string l_emailAddress = txt_email.Text;
            string l_contactNumber = txt_number.Text;
            string l_disabilities = txt_disabilities.Text;
            bool l_rightToWork = chk_rightToWork.Checked;
            string l_sqlString = "INSERT INTO happy_tech.applicant VALUES (null, '" + l_name + "', " + l_age + ", '" + l_address + "', '" + l_emailAddress + "', '" + l_contactNumber + "', '" + l_disabilities + "', " + l_rightToWork + ");";
            HappyTech.BackEnd.BuisnessMetaLayer.Instance.Insert(l_sqlString);
            HappyTech.BackEnd.DatabaseClasses.Applicant l_applicant = HappyTech.BackEnd.BuisnessMetaLayer.Instance.GetDBApplicant().Find(x => x.name == l_name && x.age == l_age && x.address == l_address && x.email_address == l_emailAddress && x.contact_number == l_contactNumber && x.disabilities == l_disabilities && x.right_to_work == l_rightToWork);
            int l_applicantID = l_applicant.applicant_id;
            string l_jobCode = m_jobPosition.job_code;
            MessageBox.Show(l_applicantID.ToString() + " & " + l_jobCode);
            l_sqlString = "INSERT INTO happy_tech.job_application VALUES (null, " + l_applicantID + ", '" + l_jobCode + "', null, " + 0 + ", false, false, false);";
            MessageBox.Show(l_sqlString);
            HappyTech.BackEnd.BuisnessMetaLayer.Instance.Insert(l_sqlString);
        }
    }
}
