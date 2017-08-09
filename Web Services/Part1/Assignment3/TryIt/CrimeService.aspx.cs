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

namespace TryIt
{
    public partial class CrimeService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CrimeServi_Click(object sender, EventArgs e)
        {
            if(latitude.Text == "" || longitude.Text == "")
           // if (!Regex.IsMatch(zipcode.Text, @"^[+-]?[0-9]{1,8}(?:\.[0-9]{1,9})?$") || zipcode.Text.Length != 5)
            {
              /*  ViolentCrime.Text = " ";
                Murder.Text = " ";
                Rape.Text = " ";
                Robbery.Text = " ";
                Assualt.Text = " ";
                Property.Text = " ";
                Burgalry.Text = " ";
                Larceny.Text = " ";
                MotorVehicle.Text = " ";
                Arson.Text = " "; */
                Output.Text = "Enter Valid Latitude and Longitude.";
                Output.ForeColor = System.Drawing.Color.Red;
            }
            else
            { 
                try {
                    Output.Text = " ";
                    string baseurl = "http://webstrar3.fulton.asu.edu/page3/Service1.svc/crimedata?latitude=" + latitude.Text+"&longitude="+ longitude.Text;
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseurl);
                    WebResponse response = request.GetResponse();
                    Stream responseStream = response.GetResponseStream();
                    StreamReader streamReader = new StreamReader(responseStream);
                    string responseJSON = streamReader.ReadToEnd();
                    listofCrime responseList = JsonConvert.DeserializeObject<listofCrime>(responseJSON);
                    ListView1.DataSource = responseList.listCrime;
                    ListView1.DataBind();

                    /*     ViolentCrime.Text = responseList.violentCrime;
                         Murder.Text = responseList.murder;
                         Rape.Text = responseList.forcibleRapee;
                         Robbery.Text = responseList.robbery;
                         Assualt.Text = responseList.aggravatedAssault;
                         Property.Text = responseList.propertyCrime;
                         Burgalry.Text = responseList.burglary;
                         Larceny.Text = responseList.larcenyTheft;
                         MotorVehicle.Text = responseList.motorVehicleTheft;
                         Arson.Text = responseList.arson;*/
                }
                catch(Exception ex)
                {
                  /*  ViolentCrime.Text = " ";
                    Murder.Text = " ";
                    Rape.Text = " ";
                    Robbery.Text = " ";
                    Assualt.Text = " ";
                    Property.Text = " ";
                    Burgalry.Text = " ";
                    Larceny.Text = " ";
                    MotorVehicle.Text = " ";
                    Arson.Text = " "; */
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

        /*   public class Crimedetail
           {
               public string violentCrime { get; set; }
               public string murder { get; set; }
               public string forcibleRapee { get; set; }
               public string robbery { get; set; }
               public string aggravatedAssault { get; set; }
               public string propertyCrime { get; set; }
               public string burglary { get; set; }
               public string larcenyTheft { get; set; }
               public string motorVehicleTheft { get; set; }     
               public string arson { get; set; }


           }*/
    }
    
}