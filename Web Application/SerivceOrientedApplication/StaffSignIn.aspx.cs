using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class StaffSignIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_Login_Click(object sender, EventArgs e)
    {
       

        try
        {
            XMLhandler validuser = new XMLhandler();
            string validatesusertype = validuser.getStaffType(tbusr_name.Text, tbpsd.Text);
            if (validatesusertype == "staff" || validatesusertype == "admin")
            {
                if ((string)Session["login"] == "member")
                {
                    if (Request.Cookies["myCookieId"] != null)
                    {
                        HttpCookie myCookie = new HttpCookie("myCookieId");
                        myCookie.Expires = DateTime.Now.AddDays(-1d);
                        Response.Cookies.Add(myCookie);
                    }
                    //Clear Session for All Types of User.
                    Session.Clear();
                    Session.RemoveAll();
                    Session.Abandon();
                }
                FormsAuthentication.RedirectFromLoginPage(validatesusertype, false);
            }
            else if (validatesusertype == "member")
            {
                Session["login"] = validatesusertype;
                Session["name"] = tbusr_name.Text;

                HttpCookie myCookies = new HttpCookie("myCookieId");
                myCookies["zipcode"] = "";
                Response.Cookies.Add(myCookies);
                myCookies.Expires = DateTime.Now.AddHours(6);
                FormsAuthentication.RedirectFromLoginPage(validatesusertype, false);
            }
            else
            {
                lbl_loginErr.Text = "Invalid Login details.";
            }
        }
        catch
        {
            lbl_loginErr.Text = "Invalid Login details.";
        }
           
       
        
    }

    protected void home_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Home.aspx");
    }
}