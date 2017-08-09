using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestPage
{
    public partial class LocationonMap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MapServi_Click(object sender, EventArgs e)
        {

            try
            {
                
                Output.Text = " ";
                MapService.Service1Client callService = new MapService.Service1Client();
                string[] result = new string[2];
                result = callService.MapInfo(Double.Parse(latitude.Text),Double.Parse(longitude.Text));
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

    }
}