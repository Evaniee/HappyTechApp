using HappyTech.BackEnd.DatabaseClasses;
using HappyTech.FrontEnd;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;

namespace HappyTech.BackEnd.FormBackEnds
{
    public class CurrentPositionsBackEnd
    {
        private CurrentPositions m_frontEnd;    // Associated front end
        
        /// <summary>
        /// Constructor for CurrentPositions Back End
        /// </summary>
        /// <param name="a_frontEnd">Front End to associated</param>
        public CurrentPositionsBackEnd(CurrentPositions a_frontEnd)
        {
            m_frontEnd = a_frontEnd;
            m_frontEnd.Connect(this);
            Populate();
        }

        /// <summary>
        /// Populate Front End with values
        /// </summary>
        public void Populate()
        {
            List<string> l_values = new List<string>();
            List<JobPosition> l_allPositons = BuisnessMetaLayer.Instance.GetDBJobPositions();
            foreach (JobPosition i_position in l_allPositons)
            {
                l_values.Add(i_position.job_code + ": " + i_position.title);
            }
            m_frontEnd.Populate(l_values);
        }

        public void SelectedNew(string a_selectedText)
        {
            string[] l_selectedTextArray = a_selectedText.Split(':');
            string l_selectedCode = l_selectedTextArray[0];
            List<JobPosition> l_allPositons = BuisnessMetaLayer.Instance.GetDBJobPositions();
            JobPosition l_position = l_allPositons.Find(x => x.job_code == l_selectedCode);
            MessageBox.Show(l_position.job_code + ": " + l_position.title + "\nTemplate ID:" + l_position.template_id + "\n" + l_position.description);
            new Position(l_position).Show();
        }
    }
}
