using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurveyProject
{
    public partial class AnswerQ1 : System.Web.UI.Page
    {
        public List<string> allQuestions = new List<string>();
        public List<string> allAnswers = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID"].ToString() == "Astronaut")
            {
                allQuestions = (List<string>)Session["AstronautQuestions"];
                LoadQuestions(allQuestions);
            }
            else if(Session["ID"].ToString() == "Scientist")
            {
                allQuestions = (List<string>)Session["ScientistQuestions"];
                LoadQuestions(allQuestions);
            }
            else if (Session["ID"].ToString() == "Staff")
            {
                allQuestions = (List<string>)Session["StaffQuestions"];
                LoadQuestions(allQuestions);
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < allAnswers.Count; i++)

            allAnswers.Add(txtQ1.Text);
            allAnswers.Add(txtQ2.Text);
            allAnswers.Add(txtQ3.Text);
            allAnswers.Add(txtQ4.Text);
            allAnswers.Add(txtQ5.Text);
            allAnswers.Add(txtQ6.Text);
            allAnswers.Add(txtQ7.Text);
            allAnswers.Add(txtQ8.Text);
            allAnswers.Add(txtQ9.Text);
            allAnswers.Add(txtQ10.Text);

            Session["AllAnswers"] = allAnswers;

            Response.Redirect("~/Login.aspx");

        }

        private void LoadQuestions(List<string> s)
        {
            int i = 0;
            lblQ1.Text = s[i]; i++;
            lblQ2.Text = s[i]; i++;
            lblQ3.Text = s[i]; i++;
            lblQ4.Text = s[i]; i++;
            lblQ5.Text = s[i]; i++;
            lblQ6.Text = s[i]; i++;
            lblQ7.Text = s[i]; i++;
            lblQ8.Text = s[i]; i++;
            lblQ9.Text = s[i]; i++;
            lblQ10.Text = s[i]; i++;
        }
    }
}