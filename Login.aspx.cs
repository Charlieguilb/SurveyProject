using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurveyProject
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            int i = rblEmployeeType.SelectedIndex;



            if (i == 0 && id == "1")
                Response.Redirect("~/AdminPage.aspx");
            else if (i == 1 && id == "2")
            {
                Session["ID"] = "Astronaut";
                Response.Redirect("~/AnswerQ.aspx");
            }
                
            else if (i == 2 && id == "3")
            {
                Session["ID"] = "Scientist";
                Response.Redirect("~/AnswerQ.aspx");
            }
                
            else if (i == 3 && id == "4")
            {
                Session["ID"] = "Staff";
                Response.Redirect("~/AnswerQ.aspx");
            }
        }
    }
}