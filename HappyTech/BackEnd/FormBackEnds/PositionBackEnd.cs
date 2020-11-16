using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using HappyTech.BackEnd.DatabaseClasses;

namespace HappyTech.BackEnd.FormBackEnds
{
    public class PositionBackEnd
    {

        public List<JobApplication> FindApplications(JobPosition a_jobPosition)
        {
            return BuisnessMetaLayer.Instance.GetDBJobApplications().FindAll(x => x.job_code == a_jobPosition.job_code);
        }

        public List<Applicant> FindApplicants(List<JobApplication> a_applications)
        {
            List<Applicant> l_applicants = new List<Applicant>();
            foreach (JobApplication i_jobApplication in a_applications)
                foreach (Applicant i_applicant in BuisnessMetaLayer.Instance.GetDBApplicant().FindAll(x => x.applicant_id == i_jobApplication.applicant_id))
                    l_applicants.Add(i_applicant);
            return l_applicants;
        }
    }
}
