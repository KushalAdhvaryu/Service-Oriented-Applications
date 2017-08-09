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

namespace TestPage
{
    public partial class NearbyRestaurants : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
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
                    Output.Text = " ";
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
    }
}