using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using Newtonsoft.Json;

public partial class Staff_AdminPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        {
            Label1.Text = "Welcome " + Context.User.Identity.Name + " !";

        }
        
    }



    protected void logout_Click(object sender, EventArgs e)
    {
        FormsAuthentication.SignOut();
        Response.Redirect("~/Home.aspx");
        //Redirect.
       
    }

    protected void home_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Home.aspx");
    }


    protected void CrimeServi_Click(object sender, EventArgs e)
    {
        if (latitude.Text == "" || longitude.Text == "")

        {
           
            Output.Text = "Enter Valid Latitude and Longitude.";
            Output.ForeColor = System.Drawing.Color.Red;
        }
        else
        {
            try
            {
                Output.Text = " ";
                string baseurl = "http://webstrar3.fulton.asu.edu/page3/Service1.svc/crimedata?latitude=" + latitude.Text + "&longitude=" + longitude.Text;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseurl);
                WebResponse response = request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader streamReader = new StreamReader(responseStream);
                string responseJSON = streamReader.ReadToEnd();
                listofCrime responseList = JsonConvert.DeserializeObject<listofCrime>(responseJSON);
             
                ListView1.DataSource = responseList.listCrime;
                ListView1.DataBind();

               
            }
            catch (Exception ex)
            {
               
                Output.Text = "Enter Valid Latitude and Longitude.";
                Output.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
    public class listofCrime
    {

        public List<Crimedetail> listCrime { get; set; }
    }

    public class Crimedetail
    {

        public string type { get; set; }

        public string date { get; set; }

        public string address { get; set; }
    }
}