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
    public partial class Position : Form
    {
        private JobPosition m_jobPosition;
        private List<JobApplication> m_jobApplications;
        private List<Applicant> m_applicants;

        private List<Label> m_nameLabels;
        private List<CheckBox> m_hiredCheckBoxes;
        private List<Button> m_profileButtons;
        private List<Button> m_feedbackButtons;
        private List<Label> m_scoreLabels;
        private List<CheckBox> m_sentCheckBoxes;
        private List<CheckBox> m_contactedCheckBoxes;

        public Position(JobPosition a_jobPosition)
        {
            InitializeComponent();
            m_jobPosition = a_jobPosition;

            m_jobApplications = new PositionBackEnd().FindApplications(m_jobPosition);
            m_applicants = new PositionBackEnd().FindApplicants(m_jobApplications);

            m_nameLabels = new List<Label>();
            m_hiredCheckBoxes = new List<CheckBox>();
            m_profileButtons = new List<Button>();
            m_feedbackButtons = new List<Button>();
            m_scoreLabels = new List<Label>();
            m_sentCheckBoxes = new List<CheckBox>();
            m_contactedCheckBoxes = new List<CheckBox>();

            lbl_title.Text = a_jobPosition.title;
            Populate();
        }

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
                this.Controls.Add(l_profileButton);
                l_profileButton.Show();

                // Feedback Button
                Button l_feedbackButton = MakeFeedbackButton();
                m_feedbackButtons.Add(l_feedbackButton);
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

        private Label MakeNameLabel()
        {
            // Vars
            int l_locationY = 200 + (m_nameLabels.Count * 50);

            Label l_label = new Label()
            {
                Location = new System.Drawing.Point(10, l_locationY),
                Name = "lbl_name" + m_nameLabels.Count + 1,
                Size = new System.Drawing.Size(100, 26),
                Text = m_applicants[m_nameLabels.Count].name
            };

            return l_label;
        }

        private CheckBox MakeHiredCheckBox()
        {
            int l_locationY = 200 + (m_hiredCheckBoxes.Count * 50);

            CheckBox l_checkBox = new CheckBox()
            {
                Location = new System.Drawing.Point(132, l_locationY),
                Name = "chk_hired" + m_hiredCheckBoxes.Count + 1,
                Size = new System.Drawing.Size(26, 26),
                Checked = m_jobApplications[m_hiredCheckBoxes.Count].hired
            };

            return l_checkBox;
        }

        private Button MakeProfileButton()
        {
            int l_locationY = 200 + (m_profileButtons.Count * 50);

            Button l_button = new Button()
            {
                Location = new System.Drawing.Point(180, l_locationY),
                Name = "btn_profile" + m_profileButtons.Count + 1,
                Size = new System.Drawing.Size(100, 26),
                Text = "Profile"
            };

            return l_button;
        }

        private Button MakeFeedbackButton()
        {
            {
                int l_locationY = 200 + (m_feedbackButtons.Count * 50);

                Button l_button = new Button()
                {
                    Location = new System.Drawing.Point(290, l_locationY),
                    Name = "btn_feedback" + m_feedbackButtons.Count + 1,
                    Size = new System.Drawing.Size(100, 26),
                    Text = "Feedback"
                };

                return l_button;
            }
        }

        private Label MakeScoreLabel()
        {
            int l_locationY = 200 + (m_scoreLabels.Count * 50);

            Label l_label = new Label()
            {
                Location = new System.Drawing.Point(400, l_locationY),
                Name = "lbl_score" + m_scoreLabels.Count + 1,
                Size = new System.Drawing.Size(50, 26),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Text = m_jobApplications[m_scoreLabels.Count].score.ToString()
            };

            return l_label;
        }

        private CheckBox MakeSentCheckBox()
        {
            int l_locationY = 200 + (m_sentCheckBoxes.Count * 50);

            CheckBox l_checkBox = new CheckBox()
            {
                Location = new System.Drawing.Point(472, l_locationY),
                Name = "chk_sent" + m_sentCheckBoxes.Count + 1,
                Size = new System.Drawing.Size(26, 26),
                Checked = m_jobApplications[m_sentCheckBoxes.Count].sent
            };

            return l_checkBox;
        }

        private CheckBox MakeContactedCheckBox()
        {
            int l_locationY = 200 + (m_contactedCheckBoxes.Count * 50);

            CheckBox l_checkBox = new CheckBox()
            {
                Location = new System.Drawing.Point(522, l_locationY),
                Name = "chk_contacted" + m_contactedCheckBoxes.Count + 1,
                Size = new System.Drawing.Size(25, 25),
                Checked = m_jobApplications[m_contactedCheckBoxes.Count].contacted
            };

            return l_checkBox;
        }

        private void btn_addApplicant_Click(object sender, EventArgs e)
        {

        }
    }
}
