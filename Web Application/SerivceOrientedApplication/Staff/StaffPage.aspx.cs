using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Text.RegularExpressions;

public partial class Staff_StaffPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Get session.
        
        if (!IsPostBack)
        {
            //Verfies if session is logged in. Else redirect to Staff login page.
            Label1.Text = "Welcome " + Context.User.Identity.Name + " !";
           
        }
    }

    protected void logout_Click(object sender, EventArgs e)
    {
        FormsAuthentication.SignOut();
        Response.Redirect("~/Home.aspx");
    }



    protected void home_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Home.aspx");
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        if (!Regex.IsMatch(zipcode.Text, @"^[+-]?[0-9]{1,8}(?:\.[0-9]{1,9})?$") || zipcode.Text.Length != 5)
        {
            ListView1.DataSource = null;
            ListView1.Items.Clear();
            Output.Text = "Enter Valid Zip Code.";
            Output.ForeColor = System.Drawing.Color.Red;

        }
        else
        {
            try
            {
                Output.Text = " ";
                WeatherService.Service1Client callService = new WeatherService.Service1Client();
                ListView1.DataSource = callService.WeatherInfo(zipcode.Text);
                ListView1.DataBind();
            }
            catch (Exception ex)
            {
                ListView1.DataSource = null;
                ListView1.Items.Clear();
                Output.Text = "Enter Valid Zip Code";
                Output.ForeColor = System.Drawing.Color.Red;

            }

        }
    }
}
