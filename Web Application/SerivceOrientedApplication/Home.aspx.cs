using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //Verify if Session is Logged In.
            string isAuth = Context.User.Identity.Name;
           
            if (Session["login"] == null && isAuth == "")
            {
                Label1.Text = "Welcome New User!";
            }
            else if((string)Session["login"] == "member")
            {
                Label1.Text = "Welcome " + (string)Session["name"];
                Label2.Text = "User Type: " + Session["login"];
            }
            else
            {
                Label1.Text = "Welcome " + Context.User.Identity.Name;
            }
        }
       
    }

    protected void manage_register_Click(object sender, EventArgs e)
    {
        if (Session["login"] != null)
        {
            string script = "<script type=\"text/javascript\">alert('You are already logged in cannot Register.');</script>";
            ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script);
        }
        else
        {
            Response.Redirect("Image_verify.aspx");
        }


    }

    protected void member_page_Click(object sender, EventArgs e)
    {
         Response.Redirect("~/Member/MemberPage.aspx");
        
        
    }

   

    protected void logout_Click(object sender, EventArgs e)
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
       
            FormsAuthentication.SignOut();
            Response.Redirect(Request.RawUrl);      
        }

        
    

    protected void public_Click(object sender, EventArgs e)
    {
        Response.Redirect("index.aspx");
    }

   



    protected void staff_page_Click(object sender, EventArgs e)
    {
      
            Response.Redirect("~/Staff/StaffPage.aspx");
        
        
        
    }

    protected void Admin_page_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/AdminPage.aspx");
        
        
        
    }



    protected void hidden_Click(object sender, EventArgs e)
    {

    }
}