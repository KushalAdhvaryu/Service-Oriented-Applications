using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Web.Security;

public partial class Member_MemberPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Get Login member type.
        string isAuth = (string)Session["login"];
        if (!IsPostBack)
        {
            //Verfies if session is logged in. Else redirect to Member login page.
            if (Session["login"] == null || isAuth == "")
            {

               
            }
            else if (isAuth == "member")
            {


                //Set strings to be displayed on page.
                Label1.Text = "Welcome " + (string)Session["name"];
                Label3.Text = "User Type: " + Session["login"];

                //Check for cookies if its null.
                HttpCookie myCookies = Request.Cookies["myCookieId"];
                if ((myCookies == null) || (myCookies["zipcode"] == ""))
                {

                    Label2.Text = "Start your search by entering Zipcode. ";
                }
                else
                {
                    //If exists display stored zipcode.
                    zipcode.Text = myCookies["zipcode"];
                    Label2.Text = "Previously entered zipcode. ";
                }
            }

        }

    }

    protected void logout_Click(object sender, EventArgs e)
    {
        //Clear Cookies on Logout.
        if (Request.Cookies["myCookieId"] != null)
        {
            HttpCookie myCookie = new HttpCookie("myCookieId");
            myCookie.Expires = DateTime.Now.AddDays(-1d);
            Response.Cookies.Add(myCookie);
        }

        //Clear Session on Logout.
        Session.Clear();
        Session.RemoveAll();
        Session.Abandon();

        FormsAuthentication.SignOut();
        //Redirect
        Response.Redirect("~/Home.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Set cookies when user uses service.
        HttpCookie myCookies = Request.Cookies["myCookieId"];
        myCookies["zipcode"] = zipcode.Text;
        Response.Cookies.Add(myCookies);

        //Verify using regex for USA Zipcode.
        if (!Regex.IsMatch(zipcode.Text, @"^[0-9]+$") || zipcode.Text.Length != 5)
        {
            Label4.Text = " Enter Valid Zip Code.";
            Label4.ForeColor = System.Drawing.Color.Red;
        }
        else
        {
            try
            {
                Label4.Text = " ";
                string baseurl = "https://maps.googleapis.com/maps/api/geocode/json?address=" + zipcode.Text + "&key=AIzaSyBYwoaBzK93ZOYRY15p15LldAujyI-Gz-c";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseurl);
                WebResponse response = request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader streamReader = new StreamReader(responseStream);
                string responseJSON = streamReader.ReadToEnd();
                LocationDetails responseList = JsonConvert.DeserializeObject<LocationDetails>(responseJSON);
                latitude.Text = Convert.ToString(responseList.results[0].geometry.location.lat);
                longitude.Text = Convert.ToString(responseList.results[0].geometry.location.lng);
            }
            catch (Exception ex)
            {
                Label4.Text = " Enter Valid Zip Code.";
                Label4.ForeColor = System.Drawing.Color.Red;
            }

        }

    }

    public class LocationDetails
    {
        public List<Results> results { get; set; }
        public string status { get; set; }

    }

    public class Results
    {
        public List<Address> address_components { get; set; }
        public String formatted_address { get; set; }
        public Geometry geometry { get; set; }
        String place_id { get; set; }
        public List<String> types { get; set; }

    }
    public class Address
    {
        public string long_name { get; set; }
        public string short_name { get; set; }
        public List<String> types { get; set; }
    }

    public class Geometry
    {
        public Bounds bounds { get; set; }
        public Location location { get; set; }
        String location_type { get; set; }
        public Viewport viewport { get; set; }

    }
    public class Bounds
    {
        public Northeast northeast { get; set; }
        public Southwest southwest { get; set; }
    }
    public class Viewport
    {
        public Northeast1 northeast { get; set; }
        public Southwest1 southwest { get; set; }
    }

    public class Northeast
    {
        public double lat { get; set; }
        public double lng { get; set; }
    }
    public class Southwest
    {
        public double lat { get; set; }
        public double lng { get; set; }
    }

    public class Location
    {
        public double lat { get; set; }
        public double lng { get; set; }
    }
    public class Northeast1
    {
        public double lat { get; set; }
        public double lng { get; set; }
    }
    public class Southwest1
    {
        public double lat { get; set; }
        public double lon { get; set; }
    }


    protected void restSer_Click(object sender, EventArgs e)
    {
        ListView1.Items.Clear();

        if (!Regex.IsMatch(zipcode.Text, @"^[0-9]+$") || zipcode.Text.Length != 5)
        {
            Output.Text = "Regex : Enter Valid Zip Code.";
            Output.ForeColor = System.Drawing.Color.Red;
        }
        else
        {
            try
            {
                mv1.ActiveViewIndex = 0;
                Output.Text = " List of Restuarants ";
                string baseurl = "http://webstrar3.fulton.asu.edu/page0/Service1.svc/restaurant?address=" + zipcode.Text;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseurl);
                WebResponse response = request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader streamReader = new StreamReader(responseStream);
                string responseJSON = streamReader.ReadToEnd();
                listofRest responseList = JsonConvert.DeserializeObject<listofRest>(responseJSON);
                ListView1.DataSource = responseList.listRest;
                ListView1.DataBind();
            }
            catch
            {
                Output.Text = "Enter Valid Zip Code.";
                Output.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
    public class listofRest
    {
        public List<RestDetails> listRest { get; set; }
    }
    public class RestDetails
    {

        public string name { get; set; }

        public bool isclose { get; set; }

        public string price { get; set; }

        public string phone { get; set; }

    }



    protected void LocationMap_Click1(object sender, EventArgs e)
    {
        try
        {
            mv1.ActiveViewIndex = 1;
            Output.Text = " ";
            MapService.Service1Client callService = new MapService.Service1Client();
            string[] result = new string[2];
            result = callService.MapInfo(Double.Parse(latitude.Text), Double.Parse(longitude.Text));
            staticurl.Text = result[0];
            StaticImage.ImageUrl = result[0];
            streetviewurl.Text = result[1];
            StreetImage.ImageUrl = result[1];

        }
        catch
        {
            Output.Text = "Enter Valid Latitude and Longitude.";
            Output.ForeColor = System.Drawing.Color.Red;
        }
    }


    protected void home_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Home.aspx");
    }
}