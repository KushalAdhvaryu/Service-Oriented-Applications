using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TextConverter;

public partial class MemberRegister : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
            
        }
       
    }

    protected void btn_Submit_Click(object sender, EventArgs e)
    {
        

        if (tbpsd.Text == tbcpsd.Text && tbpsd.Text != "" )
        {
            //Set user type
            string type = "member";
            //Encrypt the password
            TextConvertercls obj = new TextConvertercls();
            string secretpsd = obj.setSecret(tbpsd.Text);
            //Store in XML
            XMLhandler adddata = new XMLhandler();
            bool status = adddata.addUser(tbusr_name.Text, secretpsd, tbemail.Text, type);
            //If Successfullly stored.
            if (status)
            {
               
                //Redirect.
                errMsg.Text = "User added Successfully. Navigate to Home page using Home Link.";
                

            }
            else
            {
                //Username Conflict.
                errMsg.Text = "User with same name exists.";
            }
        }
        else
        {
            //Password do not match.
            errMsg.Text = "Passwords Do not Match. Or Error Occured.";
        }

        
        

        


      
    }
}