using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurveyProject
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public List<string> allQuestions = new List<string>(15);
        public List<string> astronautQuestions = new List<string>(10);
        public List<string> scientistQuestions = new List<string>(10);
        public List<string> staffQuestions = new List<string>(10);

        public List<string> AllQuestions
        {
            get
            {
                if (HttpContext.Current.Session["AllQuestions"] == null)
                {
                    HttpContext.Current.Session["AllQuestions"] = new List<string>();
                }
                return HttpContext.Current.Session["AllQuestions"] as List<string>;
            }
            set
            {
                HttpContext.Current.Session["AllQuestions"] = value;
            }
        }

        public List<string> AstronautQuestions
        {
            get
            {
                if (HttpContext.Current.Session["AstronautQuestions"] == null)
                {
                    HttpContext.Current.Session["AstronautQuestions"] = new List<string>();
                }
                return HttpContext.Current.Session["AstronautQuestions"] as List<string>;
            }
            set
            {
                HttpContext.Current.Session["AstronautQuestions"] = value;
            }
        }
        public List<string> ScientistQuestions
        {
            get
            {
                if (HttpContext.Current.Session["ScientistQuestions"] == null)
                {
                    HttpContext.Current.Session["ScientistQuestions"] = new List<string>();
                }
                return HttpContext.Current.Session["ScientistQuestions"] as List<string>;
            }
            set
            {
                HttpContext.Current.Session["ScientistQuestions"] = value;
            }
        }
        public List<string> StaffQuestions
        {
            get
            {
                if (HttpContext.Current.Session["StaffQuestions"] == null)
                {
                    HttpContext.Current.Session["StaffQuestions"] = new List<string>();
                }
                return HttpContext.Current.Session["StaffQuestions"] as List<string>;
            }
            set
            {
                HttpContext.Current.Session["StaffQuestions"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!AllQuestions.Contains ("Does your space suits fit properly?"))
                    SetQuesstions();

                for (int i = 0; i<AllQuestions.Count; i++)
                {
                    lbxQuestions.Items.Add(AllQuestions[i]);
                }
                ddlEmpType.Items.Add("Astronaut");
                ddlEmpType.Items.Add("Scientist");
                ddlEmpType.Items.Add("Staff");
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            AllQuestions.Add(txtQuestion.Text);
            lbxQuestions.Items.Add(txtQuestion.Text);
        }

        protected void btnAddToList_Click(object sender, EventArgs e)
        {
            int questionToAdd = lbxQuestions.SelectedIndex;

            if (ddlEmpType.SelectedIndex == 0)
            {
                AstronautQuestions.Add(AllQuestions[questionToAdd]);
            }
                
            else if (ddlEmpType.SelectedIndex == 1)
            {
                ScientistQuestions.Add(AllQuestions[questionToAdd]);
            }
                
            else if (ddlEmpType.SelectedIndex == 2)
            {
                StaffQuestions.Add(AllQuestions[questionToAdd]);
            }
                

            lblIsThere.Text = AstronautQuestions[0];
        }

        protected void btnRemoveFromList_Click(object sender, EventArgs e)
        {
            string toRemove = AllQuestions[lbxQuestions.SelectedIndex];

            if (ddlEmpType.SelectedIndex == 0)
            {
                foreach (string s in AstronautQuestions)
                {
                    if (toRemove == s)
                    {
                        AstronautQuestions.Remove(s);
                    }
                        
                    else
                        lblIsThere.Text = "Selected question is not within selected list";
                }
            }
             else if (ddlEmpType.SelectedIndex == 1)
            {
                foreach (string s in ScientistQuestions)
                {
                    if (toRemove == s)
                    {
                        ScientistQuestions.Remove(s);
                    }
                        
                    else
                        lblIsThere.Text = "Selected question is not within selected list";
                }
            }
            else if (ddlEmpType.SelectedIndex == 2)
            {
                foreach (string s in StaffQuestions)
                {
                    if (toRemove == s)
                    {
                        StaffQuestions.Remove(s);
                    }
                        
                    else
                        lblIsThere.Text = "Selected question is not within selected list";
                }
            }

        }

        protected void btnClearList_Click(object sender, EventArgs e)
        {
            if (ddlEmpType.SelectedIndex == 0)
            {
                AstronautQuestions.Clear();
            }
            else if (ddlEmpType.SelectedIndex == 1)
            {
                ScientistQuestions.Clear();
            }
            else if (ddlEmpType.SelectedIndex == 2)
            {
                StaffQuestions.Clear();
            }
        }

        protected void btnShowLists_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ShowLists2.aspx");
        }

        private void SetQuesstions()
        {
            AllQuestions.Add("Does your space suits fit properly?");
            AllQuestions.Add("Is your freeze-dried food tasty?");
            AllQuestions.Add("Do you get enough physical activity in your space ship?");
            AllQuestions.Add("Can you see your house from space?");
            AllQuestions.Add("Do you feel threatened by aliens?");
            AllQuestions.Add("Is your budget sufficient?");
            AllQuestions.Add("Does your equipment work well?");
            AllQuestions.Add("Are your lab assistants providing enough help?");
            AllQuestions.Add("Does your workspace provide intellectual stimulation?");
            AllQuestions.Add("Did you enjoy the Christmas Party last year?");
            AllQuestions.Add("Are you content with your team leaders?");
            AllQuestions.Add("Are you satisfied with your parking spots?");
            AllQuestions.Add("Are you happy with the quality of the food in the cafeteria?");
            AllQuestions.Add("Do you have enough office supplies?");
            AllQuestions.Add("Is there adequate working space and light in your working environment?");
            AllQuestions.Add("Other concerns or comments");
        }
        protected void btnContinue_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }

        //private void SaveData(int i = 4)
        //{
        //    if (i == 0)
        //        Session["AstronautQuestions"] = astronautQuestions;
        //    else if (i == 1)
        //         Session["ScientistQuestions"] = scientistQuestions;
        //    else if (i == 2)
        //         Session["StaffQuestions"] = staffQuestions;
        //    else if (i == 3)
        //         Session["AllQuestions"] = allQuestions;
        //    else
        //    {
        //        Session["AstronautQuestions"] = astronautQuestions;
        //        Session["ScientistQuestions"] = scientistQuestions;
        //        Session["StaffQuestions"] = staffQuestions;
        //        Session["AllQuestions"] = allQuestions;
        //    }
        //}
        //private void LoadData(int i = 4)
        //{
        //    if (i == 0)
        //        astronautQuestions = (List<string>)Session["AstronautQuestions"];
        //    else if (i == 1)
        //        scientistQuestions = (List<string>)Session["ScientistQuestions"];
        //    else if (i == 2)
        //        staffQuestions = (List<string>)Session["StaffQuestions"];
        //    else if (i == 3)
        //        allQuestions = (List<string>)Session["AllQuestions"];
        //    else
        //    {
        //        astronautQuestions = (List<string>)Session["AstronautQuestions"];
        //        scientistQuestions = (List<string>)Session["ScientistQuestions"];
        //        staffQuestions = (List<string>)Session["StaffQuestions"];
        //        allQuestions = (List<string>)Session["AllQuestions"];
        //    }
        //}
    }
}