using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurveyProject
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        List<string> astronautList;
        List<string> scientistList;
        List<string> staffList;


        protected void Page_Load(object sender, EventArgs e)
        {
            astronautList = (List<string>)Session["AstronautQuestions"];
            scientistList = (List<string>)HttpContext.Current.Session["ScientistQuestions"];
            staffList = (List<string>)HttpContext.Current.Session["StaffQuestions"];
            //getSetQuestions();
            if (!IsPostBack)
            {
                if (astronautList != null)
                {
                    foreach (string s in astronautList)
                    {
                        lbxAstronautQuestions.Items.Add(s);
                    }
                }
                if (scientistList != null)
                {
                    foreach (string s in scientistList)
                    {   
                        lbxScientistQuestions.Items.Add(s);
                    }
                }
                if (staffList != null)
                {
                    foreach (string s in staffList)
                    {
                        lbxStaffQuestions.Items.Add(s);
                    }
                }    
            } 
        }
        //private void getSetQuestions()
        //{
        //    if (HttpContext.Current.Session["AstronautList"] != null)
        //        astronautList = (List<string>) HttpContext.Current.Session["AstronautList"];
        //    if (HttpContext.Current.Session["ScientistList"] != null)
        //        scientistList = (List<string>) HttpContext.Current.Session["ScientistList"];
        //    if (HttpContext.Current.Session["StaffList"] != null)
        //        staffList = (List<string>) HttpContext.Current.Session["StaffList"];
        //}

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdminPage.aspx");
        }
    }
}