using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HappyTech.BackEnd.DatabaseClasses;
using HappyTech.BackEnd;

namespace HappyTech.FrontEnd
{
    public partial class Feedback : Form
    {
        #region Variables
        private int m_locationY;                                        // Next object's Y coord
        private JobApplication m_jobApplication;                        // Associated job application
        private Applicant m_applicant;                                  // Associated job applicant
        private JobPosition m_jobPosition;                              // Associated job position
        private Template m_template;                                    // Associated template
        private List<Question> m_questions;                             // Associated questions
        private List<Experience> m_experiences;                         // Associated experiences
        private List<Skillset> m_skillsets;                             // Associated skillsets
        private List<Teamworking> m_teamworkings;                       // Associated teamworkings

        List<Tuple<Label, TextBox,ComboBox>> m_questionComponents;      // Components for Questions
        List<Tuple<Label, TextBox, ComboBox>> m_experienceComponents;   // Components for Experiences
        List<Tuple<Label, CheckBox>> m_skillsetComponents;              // Components for Skillsets
        List<Tuple<Label, CheckBox>> m_teamworkingComponents;           // Components for Teamworkings

        private Button btn_submit;                                      // Button for submitting
        private TextBox txt_comments;                                   // Textbox for comments
        #endregion

        /// <summary>
        /// Constructor for Feedback Form
        /// </summary>
        /// <param name="a_jobApplication">Application to write feedback for</param>
        public Feedback(JobApplication a_jobApplication)
        {
            InitializeComponent();
            m_locationY = 50;
            m_jobApplication = a_jobApplication;
            m_questions = new List<Question>();
            m_experiences = new List<Experience>();
            m_skillsets = new List<Skillset>();
            m_teamworkings = new List<Teamworking>();
            m_questionComponents = new List<Tuple<Label, TextBox, ComboBox>>();
            m_experienceComponents = new List<Tuple<Label, TextBox, ComboBox>>();
            m_skillsetComponents = new List<Tuple<Label, CheckBox>>();
            m_teamworkingComponents = new List<Tuple<Label, CheckBox>>();
            Populate();
        }

        /// <summary>
        /// Populate the form
        /// </summary>
        private void Populate()
        {
            m_jobPosition = BuisnessMetaLayer.Instance.GetDBJobPositions().Find(x => x.job_code == m_jobApplication.job_code);
            m_applicant = BuisnessMetaLayer.Instance.GetDBApplicant().Find(x => x.applicant_id == m_jobApplication.applicant_id);
            m_template = BuisnessMetaLayer.Instance.GetDBTemplate().Find(x => x.template_id == m_jobPosition.template_id);

            // Title
            Title(m_locationY);

            // Questions
            List<HappyTech.BackEnd.DatabaseClasses.TemplateQuestion> l_templateQuestions = BuisnessMetaLayer.Instance.GetDBTemplateQuestion().FindAll(x => x.template_id == m_template.template_id);
            List<Question> l_allQuestions = BuisnessMetaLayer.Instance.GetDBQuestion();
            foreach (HappyTech.BackEnd.DatabaseClasses.TemplateQuestion i_templateQuestion in l_templateQuestions)
                m_questions.Add(l_allQuestions.Find(x => x.question_id == i_templateQuestion.question_id));
            QuestionSection(m_locationY);

            // Experience
            List<HappyTech.BackEnd.DatabaseClasses.TemplateExperience> l_templateExperiences = BuisnessMetaLayer.Instance.GetDBTemplateExperience().FindAll(x => x.template_id == m_template.template_id);
            List<Experience> l_allExperiences = BuisnessMetaLayer.Instance.GetDBExperience();
            foreach (HappyTech.BackEnd.DatabaseClasses.TemplateExperience i_templateExperience in l_templateExperiences)
                m_experiences.Add(l_allExperiences.Find(x => x.experience_id == i_templateExperience.experience_id));
            ExperienceSection(m_locationY);

            // Skillset
            List<HappyTech.BackEnd.DatabaseClasses.TemplateSkillset> l_templateSkillsets = BuisnessMetaLayer.Instance.GetDBTemplateSkillset().FindAll(x => x.template_id == m_template.template_id);
            List<Skillset> l_allSkillsets = BuisnessMetaLayer.Instance.GetDBSkillset();
            foreach (HappyTech.BackEnd.DatabaseClasses.TemplateSkillset i_templateSkillset in l_templateSkillsets)
                m_skillsets.Add(l_allSkillsets.Find(x => x.skillset_id == i_templateSkillset.skillset_id));
            SkillsetSection(m_locationY);

            // Teamworking
            List<HappyTech.BackEnd.DatabaseClasses.TemplateTeamworking> l_templateTeamworkings = BuisnessMetaLayer.Instance.GetDBTemplateTeamworking().FindAll(x => x.template_id == m_template.template_id);
            List<Teamworking> l_allTeamworkings = BuisnessMetaLayer.Instance.GetDBTeamworking();
            foreach (HappyTech.BackEnd.DatabaseClasses.TemplateTeamworking i_templateTeamworking in l_templateTeamworkings)
                m_teamworkings.Add(l_allTeamworkings.Find(x => x.teamworking_id == i_templateTeamworking.teamworking_id));
            TeamworkingSection(m_locationY);

            // Comments
            Comments(m_locationY);
            
            // Submit
            Submit(m_locationY);
        }

        /// <summary>
        /// Create title section
        /// </summary>
        /// <param name="a_locationY">Current Y Coord</param>
        private void Title(int a_locationY)
        {
            Label lbl_title = new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(100, a_locationY),
                Name = "lbl_title",
                Size = new System.Drawing.Size(200, 25),
                Text = "Feedback For [" + m_jobPosition.job_code + "] " + m_jobPosition.title + " applicant " + m_applicant.name
            };

            // Add Controls
            this.Controls.Add(lbl_title);

            // Increment next Position
            m_locationY += 50;
        }

        #region Sections
        /// <summary>
        /// Create question Section
        /// </summary>
        /// <param name="a_locationY">Current Y Coord</param>
        private void QuestionSection(int a_locationY)
        {
            Label lbl_questionSection = new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(100, a_locationY),
                Name = "lbl_questionSection",
                Size = new System.Drawing.Size(200, 25),
                Text = "Questions:"
            };

            // Add Controls
            this.Controls.Add(lbl_questionSection);

            // Increment next Position
            m_locationY += 50;

            foreach (Question i_question in m_questions)
            {
                NewQuestion(i_question, m_locationY);
            }
        }

        /// <summary>
        /// Create experience Section
        /// </summary>
        /// <param name="a_locationY">Current Y Coord</param>
        private void ExperienceSection(int a_locationY)
        {
            Label lbl_experienceSection = new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(100, a_locationY),
                Name = "lbl_experienceSection",
                Size = new System.Drawing.Size(200, 25),
                Text = "Experience:"
            };

            // Add Controls
            this.Controls.Add(lbl_experienceSection);

            // Increment next Position
            m_locationY += 50;

            foreach (Experience i_experience in m_experiences)
            {
                NewExperience(i_experience, m_locationY);
            }
        }

        /// <summary>
        /// Create skillset Section
        /// </summary>
        /// <param name="a_locationY">Current Y Coord</param>
        private void SkillsetSection(int a_locationY)
        {
            Label lbl_skillsetSection = new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(100, a_locationY),
                Name = "lbl_skillsetSection",
                Size = new System.Drawing.Size(200, 25),
                Text = "Skillset:"
            };

            // Add Controls
            this.Controls.Add(lbl_skillsetSection);

            // Increment next Position
            m_locationY += 50;

            foreach (Skillset i_skillset in m_skillsets)
            {
                NewSkillset(i_skillset, m_locationY);
            }
        }

        /// <summary>
        /// Create teamworking Section
        /// </summary>
        /// <param name="a_locationY">Current Y Coord</param>
        private void TeamworkingSection(int a_locationY)
        {
            Label lbl_teamworkingSection = new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(100, a_locationY),
                Name = "lbl_skillsetSection",
                Size = new System.Drawing.Size(200, 25),
                Text = "Teamworking:"
            };

            // Add Controls
            this.Controls.Add(lbl_teamworkingSection);

            // Increment next Position
            m_locationY += 50;

            foreach (Teamworking i_teamworking in m_teamworkings)
            {
                NewTeamworking(i_teamworking, m_locationY);
            }
        }
        #endregion

        #region Components
        /// <summary>
        /// Create question
        /// </summary>
        /// <param name="a_question">Question to make</param>
        /// <param name="a_locationY">Current Y Coord</param>
        private void NewQuestion(Question a_question, int a_locationY)
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

            // Add to List
            m_questionComponents.Add(new Tuple<Label, TextBox, ComboBox>(lbl_question, txt_responses, cmb_selected));

            // Add Controls
            this.Controls.Add(lbl_question);
            this.Controls.Add(txt_responses);
            this.Controls.Add(cmb_selected);

            // Increment next Position
            m_locationY += 150;
        }

        /// <summary>
        /// Create experience
        /// </summary>
        /// <param name="a_experience">Experience to make</param>
        /// <param name="a_locationY">Current Y Coord</param>
        private void NewExperience(Experience a_experience, int a_locationY)
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

            // Add to List
            m_experienceComponents.Add(new Tuple<Label, TextBox, ComboBox>(lbl_experience, txt_responses, cmb_selected));

            // Add Controls
            this.Controls.Add(lbl_experience);
            this.Controls.Add(txt_responses);
            this.Controls.Add(cmb_selected);

            // Increment next Position
            m_locationY += 150;
        }

        /// <summary>
        /// Create skillset
        /// </summary>
        /// <param name="a_skillset">Skillset to make</param>
        /// <param name="a_locationY">Current Y Coord</param>
        private void NewSkillset(Skillset a_skillset, int a_locationY)
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

            // Add to List
            m_skillsetComponents.Add(new Tuple<Label, CheckBox>(lbl_skillset, chk_achived));

            // Add Conrols
            this.Controls.Add(lbl_skillset);
            this.Controls.Add(chk_achived);

            // Increment Next Postion
            m_locationY += 50;
        }

        /// <summary>
        /// Create teamworking
        /// </summary>
        /// <param name="a_teamworking">Teamworking to make</param>
        /// <param name="a_locationY">Current Y Coord</param>
        private void NewTeamworking(Teamworking a_teamworking, int a_locationY)
        {
            // Skillset Label
            Label lbl_teamworking = new Label()
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

            // Add to List
            m_teamworkingComponents.Add(new Tuple<Label, CheckBox>(lbl_teamworking, chk_achived));

            // Add Conrols
            this.Controls.Add(lbl_teamworking);
            this.Controls.Add(chk_achived);

            // Increment Next Postion
            m_locationY += 50;
        }

        /// <summary>
        /// Create comments section
        /// </summary>
        /// <param name="a_locationY">Current Y Coord</param>
        private void Comments(int a_locationY)
        {
            // Experience Label
            Label lbl_comments = new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(100, a_locationY),
                Name = "lbl_comments",
                Size = new System.Drawing.Size(200, 25),
                Text = "Comments:"
            };

            // Experience Responses Text Box
            txt_comments = new TextBox()
            {
                Location = new System.Drawing.Point(100, a_locationY + 25),
                Multiline = true,
                Name = "txt_comments",
                ScrollBars = System.Windows.Forms.ScrollBars.Both,
                Size = new System.Drawing.Size(500, 100)
            };

            // Add Controls
            this.Controls.Add(lbl_comments);
            this.Controls.Add(txt_comments);

            // Increment next Position
            m_locationY += 150;
        }

        /// <summary>
        /// Add submit button
        /// </summary>
        /// <param name="a_locationY">Current Y Coord</param>
        private void Submit(int a_locationY)
        {
            btn_submit = new Button()
            {
                Location = new System.Drawing.Point(300, a_locationY),
                Name = "btn_submit",
                Size = new System.Drawing.Size(100, 50),
                Text = "Submit",
            };

            // Assign Handlers

            // Add Conrols
            this.Controls.Add(btn_submit);
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);

            // Increment Next Postion
            m_locationY += 75;
        }
        #endregion

        /// <summary>
        /// On Click Event for Submit Button
        /// Submits feedback to database
        /// </summary>
        /// <param name="sender">Object that sent event</param>
        /// <param name="e">Event arguments</param>
        private void btn_submit_Click(object sender, EventArgs e)
        {
            // Vars
            int l_score = 0;
            string l_sqlString;

            // Feedback
            l_sqlString = "INSERT INTO feedback VALUES (null, " + m_template.template_id + ", '" + txt_comments.Text + "');";
            BuisnessMetaLayer.Instance.Insert(l_sqlString);
            HappyTech.BackEnd.DatabaseClasses.Feedback l_feedback = BuisnessMetaLayer.Instance.GetDBFeedback().Find(x => x.comments == txt_comments.Text && x.template_id == m_template.template_id);

            // Question
            foreach (Tuple<Label, TextBox, ComboBox> i_questionComponent in m_questionComponents)
            { 
                // Score
                l_score += int.Parse(i_questionComponent.Item3.Text);

                // Insert into DB
                l_sqlString = "INSERT INTO feedback_question VALUES (null, " + l_feedback.feedback_id + ", " + i_questionComponent.Item1.Text.Split(':')[0] + ", " + int.Parse(i_questionComponent.Item3.Text) + ");";
                BuisnessMetaLayer.Instance.Insert(l_sqlString);
            }
            // Experience
            foreach (Tuple<Label, TextBox, ComboBox> i_experienceComponent in m_experienceComponents)
            {
                // Score
                l_score += int.Parse(i_experienceComponent.Item3.Text);

                // Insert into DB
                l_sqlString = "INSERT INTO happy_tech.feedback_experience VALUES (null, " + l_feedback.feedback_id + ", " + i_experienceComponent.Item1.Text.Split(':')[0] + ", " + int.Parse(i_experienceComponent.Item3.Text) + ");";
                BuisnessMetaLayer.Instance.Insert(l_sqlString);
            }
            // Skillset
            foreach (Tuple<Label, CheckBox> i_skillsetComponent in m_skillsetComponents)
            {
                // Score
                if (i_skillsetComponent.Item2.Checked)
                    l_score++;

                // Insert into DB
                l_sqlString = "INSERT INTO happy_tech.feedback_skillset VALUES (null, " + l_feedback.feedback_id + ", " + i_skillsetComponent.Item1.Text.Split(':')[0] + ", " + i_skillsetComponent.Item2.Checked + ");";
                BuisnessMetaLayer.Instance.Insert(l_sqlString);
            }
            // Teamworking
            foreach (Tuple<Label, CheckBox> i_teamworkingComponent in m_teamworkingComponents)
            {
                // Score
                if (i_teamworkingComponent.Item2.Checked)
                    l_score++;

                // Insert into DB
                l_sqlString = "INSERT INTO happy_tech.feedback_teamworking VALUES (null, " + l_feedback.feedback_id + ", " + i_teamworkingComponent.Item1.Text.Split(':')[0] + ", " + i_teamworkingComponent.Item2.Checked + ");";
                BuisnessMetaLayer.Instance.Insert(l_sqlString);
            }

            // Job Applicant
            l_sqlString = "UPDATE job_application SET feedback_id = " + l_feedback.feedback_id + ", score = " + l_score + " WHERE job_application_id = " + m_jobApplication.job_application_id + ";";
            BuisnessMetaLayer.Instance.Update(l_sqlString);
        }
    }
}
