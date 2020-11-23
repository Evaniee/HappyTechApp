using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HappyTech.BackEnd;
using HappyTech.BackEnd.DatabaseClasses;
using HappyTech.BackEnd.FormBackEnds;

namespace HappyTech.FrontEnd
{
    public partial class Position : Form
    {
        private JobPosition m_jobPosition;                  // Associated Job Position
        private List<JobApplication> m_jobApplications;     // Associtated Job Applications
        private List<Applicant> m_applicants;               // Associated Applicants
            
        private List<Label> m_nameLabels;                   // Name Labels
        private List<CheckBox> m_hiredCheckBoxes;           // Hired Check Boxes
        private List<Button> m_profileButtons;              // Profile Buttons
        private List<Button> m_feedbackButtons;             // Feedback Buttons
        private List<Label> m_scoreLabels;                  // Score Labels
        private List<CheckBox> m_sentCheckBoxes;            // Sent Check Boxes
        private List<CheckBox> m_contactedCheckBoxes;       // Contacted Check Boxes

        /// <summary>
        /// Constructr for Position Form
        /// </summary>
        /// <param name="a_jobPosition">Associated Job position</param>
        public Position(JobPosition a_jobPosition)
        {
            InitializeComponent();
            m_jobPosition = a_jobPosition;
            lbl_title.Text = a_jobPosition.title;
            m_jobApplications = new PositionBackEnd().FindApplications(m_jobPosition);
            m_applicants = new PositionBackEnd().FindApplicants(m_jobApplications);

            m_nameLabels = new List<Label>();
            m_hiredCheckBoxes = new List<CheckBox>();
            m_profileButtons = new List<Button>();
            m_feedbackButtons = new List<Button>();
            m_scoreLabels = new List<Label>();
            m_sentCheckBoxes = new List<CheckBox>();
            m_contactedCheckBoxes = new List<CheckBox>();
            Populate();
        }

        /// <summary>
        /// Populate the form with components
        /// </summary>
        public void Populate()
        {
            foreach(JobApplication i_jobApplication in m_jobApplications)
            {
                // Name Label
                Label l_nameLabel = MakeNameLabel();
                m_nameLabels.Add(l_nameLabel);
                this.Controls.Add(l_nameLabel);
                l_nameLabel.Show();

                // Hired Check Box
                CheckBox l_hiredCheckBox = MakeHiredCheckBox();
                m_hiredCheckBoxes.Add(l_hiredCheckBox);
                this.Controls.Add(l_hiredCheckBox);
                l_hiredCheckBox.Show();

                // Profile Button
                Button l_profileButton = MakeProfileButton();
                m_profileButtons.Add(l_profileButton);
                l_profileButton.Click += new System.EventHandler(this.btn_profile_Click);
                this.Controls.Add(l_profileButton);
                l_profileButton.Show();

                // Feedback Button
                Button l_feedbackButton = MakeFeedbackButton(i_jobApplication);
                m_feedbackButtons.Add(l_feedbackButton);
                l_feedbackButton.Click += new System.EventHandler(this.btn_feedback_Click);
                this.Controls.Add(l_feedbackButton);
                l_feedbackButton.Show();

                // Score Label
                Label l_scoreLabel = MakeScoreLabel();
                m_scoreLabels.Add(l_scoreLabel);
                this.Controls.Add(l_scoreLabel);
                l_scoreLabel.Show();

                // Sent Checkbox
                CheckBox l_sentCheckBox = MakeSentCheckBox();
                m_sentCheckBoxes.Add(l_sentCheckBox);
                this.Controls.Add(l_sentCheckBox);
                l_sentCheckBox.Show();

                // Contacted Checkbox
                CheckBox l_contactedCheckBox = MakeContactedCheckBox();
                m_contactedCheckBoxes.Add(l_contactedCheckBox);
                this.Controls.Add(l_contactedCheckBox);
                l_contactedCheckBox.Show();
            }
        }

        #region Component Creation
        /// <summary>
        /// Make a name label
        /// </summary>
        /// <returns>Name label</returns>
        private Label MakeNameLabel()
        {
            // Vars
            int l_locationY = 150 + (m_nameLabels.Count * 50);

            Label l_label = new Label()
            {
                Location = new System.Drawing.Point(10, l_locationY),
                Name = "lbl_name" + (m_nameLabels.Count + 1),
                Size = new System.Drawing.Size(100, 26),
                Text = m_applicants[m_nameLabels.Count].name
            };

            return l_label;
        }

        /// <summary>
        /// Make a Hired Check Box
        /// </summary>
        /// <returns>Hired check box</returns>
        private CheckBox MakeHiredCheckBox()
        {
            int l_locationY = 150 + (m_hiredCheckBoxes.Count * 50);

            CheckBox l_checkBox = new CheckBox()
            {
                Location = new System.Drawing.Point(120, l_locationY),
                Name = "chk_hired" + (m_hiredCheckBoxes.Count + 1),
                Size = new System.Drawing.Size(26, 26),
                Checked = m_jobApplications[m_hiredCheckBoxes.Count].hired
            };

            return l_checkBox;
        }

        /// <summary>
        /// Make a profile button
        /// </summary>
        /// <returns>Profile Button</returns>
        private Button MakeProfileButton()
        {
            int l_locationY = 150 + (m_profileButtons.Count * 50);

            Button l_button = new Button()
            {
                Location = new System.Drawing.Point(170, l_locationY),
                Name = "btn_profile" + (m_profileButtons.Count + 1),
                Size = new System.Drawing.Size(100, 26),
                Text = "Profile"
            };

            return l_button;
        }

        /// <summary>
        /// Make a feedback button
        /// </summary>
        /// <param name="a_application">Associated Job Application</param>
        /// <returns>Feedback Button</returns>
        private Button MakeFeedbackButton(JobApplication a_application)
        {
            int l_locationY = 150 + (m_feedbackButtons.Count * 50);

            Button l_button = new Button()
            {
                Location = new System.Drawing.Point(280, l_locationY),
                Name = "btn_feedback" + (m_feedbackButtons.Count + 1),
                Size = new System.Drawing.Size(100, 26),
                Text = "Feedback",
                Enabled = a_application.feedback_id == 0
            };
            return l_button;
        }

        /// <summary>
        /// Make a score label
        /// </summary>
        /// <returns>Score label</returns>
        private Label MakeScoreLabel()
        {
            int l_locationY = 150 + (m_scoreLabels.Count * 50);

            Label l_label = new Label()
            {
                Location = new System.Drawing.Point(390, l_locationY),
                Name = "lbl_score" + (m_scoreLabels.Count + 1),
                Size = new System.Drawing.Size(50, 26),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Text = m_jobApplications[m_scoreLabels.Count].score.ToString()
            };

            return l_label;
        }

        /// <summary>
        /// Make a sent check box
        /// </summary>
        /// <returns>Sent check box</returns>
        private CheckBox MakeSentCheckBox()
        {
            int l_locationY = 150 + (m_sentCheckBoxes.Count * 50);

            CheckBox l_checkBox = new CheckBox()
            {
                Location = new System.Drawing.Point(450, l_locationY),
                Name = "chk_sent" + (m_sentCheckBoxes.Count + 1),
                Size = new System.Drawing.Size(26, 26),
                Checked = m_jobApplications[m_sentCheckBoxes.Count].sent
            };

            return l_checkBox;
        }

        /// <summary>
        /// Make a contacted check box
        /// </summary>
        /// <returns>Contacted check box</returns>
        private CheckBox MakeContactedCheckBox()
        {
            int l_locationY = 150 + (m_contactedCheckBoxes.Count * 50);

            CheckBox l_checkBox = new CheckBox()
            {
                Location = new System.Drawing.Point(510, l_locationY),
                Name = "chk_contacted" + (m_contactedCheckBoxes.Count + 1),
                Size = new System.Drawing.Size(26, 26),
                Checked = m_jobApplications[m_contactedCheckBoxes.Count].contacted
            };

            return l_checkBox;
        }
        #endregion

        /// <summary>
        /// Occurs on clicking add applicant button
        /// </summary>
        /// <param name="sender">Object that sent event</param>
        /// <param name="e">Event arguments</param>
        private void btn_addApplicant_Click(object sender, EventArgs e)
        {
            new NewApplicant(m_jobPosition).Show();
        }

        /// <summary>
        /// Occurs on clicking a profile button
        /// </summary>
        /// <param name="sender">Object that sent event</param>
        /// <param name="e">Event arguments</param>
        private void btn_profile_Click(object sender, EventArgs e)
        {
            Button l_button = (Button)sender;
            int l_index = m_profileButtons.IndexOf(m_profileButtons.Find(x => x.Name == l_button.Name));
            JobApplication l_jobApplication = m_jobApplications[l_index];
            Applicant l_applicant = BuisnessMetaLayer.Instance.GetDBApplicant().Find(x => x.applicant_id == l_jobApplication.applicant_id);
            new Profile(l_applicant).Show();
        }

        /// <summary>
        /// Occurs on clicking update button
        /// </summary>
        /// <param name="sender">Object that sent event</param>
        /// <param name="e">Event arguments</param>
        private void btn_update_Click(object sender, EventArgs e)
        {

            for(int i = m_jobApplications.Count - 1; i != -1; i--)
            {
                JobApplication l_jobApplication = m_jobApplications[i];
                bool l_hired = m_hiredCheckBoxes[i].Checked;
                bool l_sent = m_sentCheckBoxes[i].Checked;
                bool l_contacted = m_contactedCheckBoxes[i].Checked;
                string l_sqlString = "UPDATE happy_tech.job_application SET hired = " + l_hired + ", sent = " + l_sent + ", contacted = " + l_contacted + " WHERE job_application_id = " + l_jobApplication.job_application_id + ";";
                BuisnessMetaLayer.Instance.Update(l_sqlString);
            }
            // Remove Controls
            for(int i = m_applicants.Count + 1; i != 0; i--)
            {
                this.Controls.RemoveByKey("lbl_name" + i);
                this.Controls.RemoveByKey("chk_hired" + i);
                this.Controls.RemoveByKey("btn_profile" + i);
                this.Controls.RemoveByKey("btn_feedback" + i);
                this.Controls.RemoveByKey("lbl_score" + i);
                this.Controls.RemoveByKey("chk_sent" + i);
                this.Controls.RemoveByKey("chk_contacted" + i);
            }

            // Clear Lists
            m_nameLabels.Clear();
            m_hiredCheckBoxes.Clear();
            m_profileButtons.Clear();
            m_feedbackButtons.Clear();
            m_scoreLabels.Clear();
            m_sentCheckBoxes.Clear();
            m_contactedCheckBoxes.Clear();

            // Update Lists
            m_jobApplications = new PositionBackEnd().FindApplications(m_jobPosition);
            m_applicants = new PositionBackEnd().FindApplicants(m_jobApplications);

            // Repopulate
            Populate();
        }

        /// <summary>
        /// Occurs on clicking a feedback button
        /// </summary>
        /// <param name="sender">Object that sent event</param>
        /// <param name="e">Event arguments</param>
        private void btn_feedback_Click(object sender, EventArgs e)
        {
            Button l_button = (Button)sender;
            int l_index = m_feedbackButtons.IndexOf(m_feedbackButtons.Find(x => x.Name == l_button.Name));
            JobApplication l_jobApplication = m_jobApplications[l_index];
            new Feedback(l_jobApplication).Show();
        }

        /// <summary>
        /// Occurs on clicking inform applicants button
        /// </summary>
        /// <param name="sender">Object that sent event</param>
        /// <param name="e">Event arguments</param>
        private void btn_informApplicant_Click(object sender, EventArgs e)
        {
            // INFORM CODE TO GO HERE

            // Can inform if all applicants have 
            bool l_valid = true;
            foreach (JobApplication i_jobApplication in m_jobApplications)
            {
                if (i_jobApplication.feedback_id == 0)
                {
                    l_valid = false;
                    MessageBox.Show("All applicants have to have feedback written before informing everyone.");
                    break;
                }
            }
            if (l_valid)
                MessageBox.Show("INFORM APPLICANTS HERE");
        }
    }
}
