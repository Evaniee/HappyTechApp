﻿using System;
using System.Collections.Generic;
using System.Text;
using SelectPdf;
using HappyTech.BackEnd.DatabaseClasses;

namespace HappyTech.BackEnd
{
    class PdfMaker
    {
        private HtmlToPdf m_converter;
        private Feedback m_feedback;                                
        private List<FeedbackQuestion> m_fQuestions;
        private List<FeedbackExperience> m_fExperiences;
        private List<FeedbackSkillset> m_fSkillsets;
        private List<FeedbackTeamworking> m_fTeamworkings;

        private List<Question> m_questions;
        private List<Experience> m_experiences;
        private List<Skillset> m_skillsets;
        private List<Teamworking> m_teamworkings;

        private StringBuilder m_htmlBuilder;

        private string m_applicantName;
        private string m_positonName;
        private string m_pdfName;

        /// <summary>
        /// Constructor for Pdf Maker
        /// </summary>
        /// <param name="a_feedback">Associated Feedback</param>7
        /// <param name="a_applicantName">Name of applicant</param>
        /// <param name="a_positionName">Name / title of job position</param>
        /// <param name="a_pdfName">Name of PDF</param>
        public PdfMaker(Feedback a_feedback, string a_applicantName, string a_positionName, string a_pdfName)
        {
            // Setup
            m_converter = new HtmlToPdf();
            m_feedback = a_feedback;
            m_applicantName = a_applicantName;
            m_positonName = a_positionName;
            m_pdfName = a_pdfName;
            FeedbackValues();

            // Html Related
            m_htmlBuilder = new StringBuilder();
            GenericToHtml();
            QuestionToHtml();
            ExperienceToHtml();
            SkillsetToHtml();
            TeamworkingToHtml();
            CommentsToHtml();

            // Finalize
            ConvertToPDF(m_htmlBuilder.ToString());
        }

        /// <summary>
        /// Get the lists of associated questions, experiences, skillsets and teamworkings
        /// </summary>
        private void FeedbackValues()
        {
            m_fQuestions = BuisnessMetaLayer.Instance.GetDBFeedbackQuestion().FindAll(x => x.feedback_id == m_feedback.feedback_id);
            m_fExperiences = BuisnessMetaLayer.Instance.GetDBFeedbackExperience().FindAll(x => x.feedback_id == m_feedback.feedback_id);
            m_fSkillsets = BuisnessMetaLayer.Instance.GetDBFeedbackSkillset().FindAll(x => x.feedback_id == m_feedback.feedback_id);
            m_fTeamworkings = BuisnessMetaLayer.Instance.GetDBFeedbackTeamworking().FindAll(x => x.feedback_id == m_feedback.feedback_id);

            List<Question> l_questions = BuisnessMetaLayer.Instance.GetDBQuestion();
            m_questions = new List<Question>();
            foreach(FeedbackQuestion i_fQuestion in m_fQuestions)
                m_questions.Add(l_questions.Find(x => x.question_id == i_fQuestion.question_id));

            List<Experience> l_experiences = BuisnessMetaLayer.Instance.GetDBExperience();
            m_experiences = new List<Experience>();
            foreach (FeedbackExperience i_fExperience in m_fExperiences)
                m_experiences.Add(l_experiences.Find(x => x.experience_id == i_fExperience.experience_id));

            List<Skillset> l_skillsets = BuisnessMetaLayer.Instance.GetDBSkillset();
            m_skillsets = new List<Skillset>();
            foreach (FeedbackSkillset i_fSkillset in m_fSkillsets)
                m_skillsets.Add(l_skillsets.Find(x => x.skillset_id == i_fSkillset.skillset_id));

            List<Teamworking> l_teamworkings = BuisnessMetaLayer.Instance.GetDBTeamworking();
            m_teamworkings = new List<Teamworking>();
            foreach (FeedbackTeamworking i_fTeamworking in m_fTeamworkings)
                m_teamworkings.Add(l_teamworkings.Find(x => x.teamworking_id == i_fTeamworking.teamworking_id));

        }

        /// <summary>
        /// Generic information for pdf
        /// </summary>
        private void GenericToHtml()
        {
            m_htmlBuilder.Append("<p>Thank you " + m_applicantName + " for applying to the " + m_positonName + " position at HappyTech. As part of our company policy we provide all applicants with feedback on their interviews. This doccument contains feedback from your recent application<p>");
        }

        /// <summary>
        /// Convert Questions into HTML for pdf conversion
        /// </summary>
        private void QuestionToHtml()
        {
            m_htmlBuilder.Append("<table border \"1\"><thead style=\"display: a_tableBody header-group\"><caption>Questions</caption><tr><td style=\"word - wrap: break-word\">Question</td><td style=\"word - wrap: break-word\">Criteria Met</td><td style=\"word - wrap: break-word\">Suitability for Role (Max 5)</td></tr></thead><tbody>");
            for(int i  = 0; i < m_questions.Count; i++)
            {
                m_htmlBuilder.Append("<tr><td style=\"word - wrap: break-word\">" + m_questions[i].question + "</td>");
                switch (m_fQuestions[i].score)
                {
                    case 1:
                        m_htmlBuilder.Append("<td style=\"word - wrap: break-word\">" + m_questions[i].response1 + "</td><td>Low</td></tr>");
                        break;
                    case 2:
                        m_htmlBuilder.Append("<td style=\"word - wrap: break-word\">" + m_questions[i].response2 + "</td><td>Below Ideal</td></tr>");
                        break;
                    case 3:
                        m_htmlBuilder.Append("<td style=\"word - wrap: break-word\">" + m_questions[i].response3 + "</td><td>Suitable</td></tr>");
                        break;
                    case 4:
                        m_htmlBuilder.Append("<td style=\"word - wrap: break-word\">" + m_questions[i].response4 + "</td><td>Above Ideal</td></tr>");
                        break;
                    case 5:
                        m_htmlBuilder.Append("<td style=\"word - wrap: break-word\">" + m_questions[i].response5 + "</td><td>High</td></tr>");
                        break;
                }
            }
            m_htmlBuilder.Append("</tbody>");
        }

        /// <summary>
        /// Convert Experiences into HTML for pdf conversion
        /// </summary>
        private void ExperienceToHtml()
        {
            m_htmlBuilder.Append("<table border \"1\"><thead style=\"display: a_tableBody header-group\"><caption>Experience</caption><tr><td style=\"word - wrap: break-word\">Experience</td><td style=\"word - wrap: break-word\">Criteria Met</td><td style=\"word - wrap: break-word\">Suitability for Role (Max 5)</td></tr></thead><tbody>");
            for (int i = 0; i < m_experiences.Count; i++)
            {
                m_htmlBuilder.Append("<tr><td style=\"word - wrap: break-word\">" + m_experiences[i].experience + "</td>");
                switch (m_fExperiences[i].score)
                {
                    case 1:
                        m_htmlBuilder.Append("<td style=\"word - wrap: break-word\">" + m_experiences[i].response1 + "</td><td>Low (1)</td></tr>");
                        break;
                    case 2:
                        m_htmlBuilder.Append("<td style=\"word - wrap: break-word\">" + m_experiences[i].response2 + "</td><td>Below Ideal (2)</td></tr>");
                        break;
                    case 3:
                        m_htmlBuilder.Append("<td style=\"word - wrap: break-word\">" + m_experiences[i].response3 + "</td><td>Suitable (3)</td></tr>");
                        break;
                    case 4:
                        m_htmlBuilder.Append("<td style=\"word - wrap: break-word\">" + m_experiences[i].response4 + "</td><td>Above Ideal (4)</td></tr>");
                        break;
                    case 5:
                        m_htmlBuilder.Append("<td style=\"word - wrap: break-word\">" + m_experiences[i].response5 + "</td><td>High (5)</td></tr>");
                        break;
                }
            }
            m_htmlBuilder.Append("</tbody>");
        }

        /// <summary>
        /// Convert Skillsets into HTML for pdf conversion
        /// </summary>
        private void SkillsetToHtml()
        {
            m_htmlBuilder.Append("<table border \"1\"><thead style=\"display: a_tableBody header-group\"><caption>Skillset</caption><tr><td style=\"word - wrap: break-word\">Skillset</td><td style=\"word - wrap: break-word\">Suitable for Role</td></tr></thead><tbody>");
            for (int i = 0; i < m_skillsets.Count; i++)
            {
                m_htmlBuilder.Append("<tr><td style=\"word - wrap: break-word\">" + m_skillsets[i].skillset + "</td>");
                if(m_fSkillsets[i].achieved)
                    m_htmlBuilder.Append("<td style=\"word - wrap: break-word\">Yes</td></tr>");
                else
                    m_htmlBuilder.Append("<td style=\"word - wrap: break-word\">No</td></tr>");

            }
            m_htmlBuilder.Append("</tbody>");
        }

        /// <summary>
        /// Convert Questions into HTML for pdf conversion
        /// </summary>
        private void TeamworkingToHtml()
        {
            m_htmlBuilder.Append("<table border \"1\"><thead style=\"display: a_tableBody header-group\"><caption>Teamworking</caption><tr><td style=\"word - wrap: break-word\">Teamworking</td><td style=\"word - wrap: break-word\">Suitable for Role</td></tr></thead><tbody>");
            for (int i = 0; i < m_teamworkings.Count; i++)
            {
                m_htmlBuilder.Append("<tr><td style=\"word - wrap: break-word\">" + m_teamworkings[i].teamworking + "</td>");
                if (m_fTeamworkings[i].achieved)
                    m_htmlBuilder.Append("<td style=\"word - wrap: break-word\">Yes</td></tr>");
                else
                    m_htmlBuilder.Append("<td style=\"word - wrap: break-word\">No</td></tr>");

            }
            m_htmlBuilder.Append("</tbody>");
        }

        /// <summary>
        /// Comments into HTML for pdf conversion
        /// </summary>
        private void CommentsToHtml()
        {
            m_htmlBuilder.Append("<table border \"1\"><thead style=\"display: a_tableBody header-group\"><caption>Comments</caption></thead><tbody><tr><td style=\"word - wrap: break-word\">" + m_feedback.comments + "</td></tr></tbody>");
        }

        /// <summary>
        /// Convert html string into pdf
        /// </summary>
        /// <param name="a_htmlString">HTML to convert into PDF</param>
        private void ConvertToPDF(string a_htmlString)
        {
            PdfDocument l_doccument = m_converter.ConvertHtmlString(a_htmlString);
            l_doccument.Save(m_pdfName);
            l_doccument.Close();
        }
        
    }
}
