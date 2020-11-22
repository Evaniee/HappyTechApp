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
    public partial class Feedback : Form
    {
        private int m_locationY;

        public Feedback()
        {
            InitializeComponent();
            m_locationY = 200;
            NewQuestion(new Question() { question = "TestQ", question_id = 1, response1 = "r1", response2 = "r2", response3 = "r3", response4 = "r4", response5 = "r5" }, m_locationY);
            NewExperience(new Experience() { experience = "Test1E", experience_id = 1, response1 = "r1", response2 = "r2", response3 = "r3", response4 = "r4", response5 = "r5" }, m_locationY);
            NewSkillset(new Skillset() { skillset = "Test1S", skillset_id = 1 }, m_locationY);
            NewTeamworking(new Teamworking() { teamworking = "Test1T", teamworking_id = 1 }, m_locationY);
            NewQuestion(new Question() { question = "Test2Q", question_id = 2, response1 = "r1", response2 = "r2", response3 = "r3", response4 = "r4", response5 = "r5" }, m_locationY);
        }

        private void GetFeedbackValues()
        {

        }

        public void QuestionSection()
        {

        }

        public void NewQuestion(Question a_question, int a_locationY)
        {
            // Question Label
            Label lbl_question = new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(100, a_locationY),
                Name = "lbl_question" + a_question.question_id,
                Size = new System.Drawing.Size(200, 25),
                Text = a_question.question_id + ": " + a_question.question
            };

            // Question Responses Text Box
            TextBox txt_responses = new TextBox()
            {
                Text =
                    "1: " + a_question.response1 + Environment.NewLine +
                    "2: " + a_question.response2 + Environment.NewLine +
                    "3: " + a_question.response3 + Environment.NewLine +
                    "4: " + a_question.response4 + Environment.NewLine +
                    "5: " + a_question.response5,
                Location = new System.Drawing.Point(100, a_locationY + 25),
                Multiline = true,
                Name = "txt_selectedQues" + a_question.question_id,
                ScrollBars = System.Windows.Forms.ScrollBars.Both,
                Size = new System.Drawing.Size(500, 100)
            };

            // Question Grade Combo Box
            ComboBox cmb_selected = new ComboBox()
            {
                FormattingEnabled = true,
                Location = new System.Drawing.Point(500, a_locationY),
                Name = "cmb_selectedQues" + a_question.question_id,
                DataSource = new int[5] { 1, 2, 3, 4, 5 },
                Size = new System.Drawing.Size(100,25)
            };

            // Add Controls
            this.Controls.Add(lbl_question);
            this.Controls.Add(txt_responses);
            this.Controls.Add(cmb_selected);

            // Increment next Position
            m_locationY += 150;
        }

        public void NewExperience(Experience a_experience, int a_locationY)
        {
            // Experience Label
            Label lbl_experience = new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(100, a_locationY),
                Name = "lbl_experience" + a_experience.experience_id,
                Size = new System.Drawing.Size(200, 25),
                Text = a_experience.experience_id + ": " + a_experience.experience
            };

            // Experience Responses Text Box
            TextBox txt_responses = new TextBox()
            {
                Text =
                    "1: " + a_experience.response1 + Environment.NewLine +
                    "2: " + a_experience.response2 + Environment.NewLine +
                    "3: " + a_experience.response3 + Environment.NewLine +
                    "4: " + a_experience.response4 + Environment.NewLine +
                    "5: " + a_experience.response5,
                Location = new System.Drawing.Point(100, a_locationY + 25),
                Multiline = true,
                Name = "txt_selectedExp" + a_experience.experience_id,
                ScrollBars = System.Windows.Forms.ScrollBars.Both,
                Size = new System.Drawing.Size(500, 100)
            };

            // Experience Grade Combo Box
            ComboBox cmb_selected = new ComboBox()
            {
                FormattingEnabled = true,
                Location = new System.Drawing.Point(500, a_locationY),
                Name = "cmb_selectedExp" + a_experience.experience_id,
                DataSource = new int[5] { 1, 2, 3, 4, 5 },
                Size = new System.Drawing.Size(100, 25)
            };

            // Add Controls
            this.Controls.Add(lbl_experience);
            this.Controls.Add(txt_responses);
            this.Controls.Add(cmb_selected);

            // Increment next Position
            m_locationY += 150;
        }

        public void NewSkillset(Skillset a_skillset, int a_locationY)
        {
            // Skillset Label
            Label lbl_skillset = new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(100, a_locationY),
                Name = "lbl_skillset" + a_skillset.skillset_id,
                Size = new System.Drawing.Size(475, 25),
                Text = a_skillset.skillset_id + ": " + a_skillset.skillset
            };

            // Skillset Achived Check Box
            CheckBox chk_achived = new CheckBox()
            {
                Location = new System.Drawing.Point(575, m_locationY),
                Name = "chk_achivedSkill" + a_skillset.skillset_id,
                Size = new System.Drawing.Size(25, 25),
                Checked = false
            };

            // Add Conrols
            this.Controls.Add(lbl_skillset);
            this.Controls.Add(chk_achived);

            // Increment Next Postion
            m_locationY += 50;
        }

        public void NewTeamworking(Teamworking a_teamworking, int a_locationY)
        {
            // Skillset Label
            Label lbl_skillset = new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(100, a_locationY),
                Name = "lbl_teamworking" + a_teamworking.teamworking_id,
                Size = new System.Drawing.Size(475, 25),
                Text = a_teamworking.teamworking_id + ": " + a_teamworking.teamworking
            };

            // Skillset Achived Check Box
            CheckBox chk_achived = new CheckBox()
            {
                Location = new System.Drawing.Point(575, m_locationY),
                Name = "chk_achivedTeam" + a_teamworking.teamworking_id,
                Size = new System.Drawing.Size(25, 25),
                Checked = false
            };

            // Add Conrols
            this.Controls.Add(lbl_skillset);
            this.Controls.Add(chk_achived);

            // Increment Next Postion
            m_locationY += 50;
        }
    }
}
