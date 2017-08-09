using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Image_verify : System.Web.UI.Page
{
    private static string image_string;
    ImageVerifyService.ServiceClient imgSer = new ImageVerifyService.ServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        //Call Service on PageLoad if not post back. To load image.
        if (!IsPostBack)
        {
            
            image_string = imgSer.GetVerifierString("4");
            Stream stream = imgSer.GetImage(image_string);
            string imgPath = Server.MapPath( @"Pictures\xyz.jpg");
            System.Drawing.Image img = System.Drawing.Image.FromStream(stream);
            img.Save(imgPath, System.Drawing.Imaging.ImageFormat.Jpeg);
            string imgName = "~/Pictures/xyz.jpg";
            Image1.ImageUrl = imgName;

        }
    }

    protected void verify_Click(object sender, EventArgs e)
    {
        if(input.Text == image_string)
        {
            Response.Redirect("MemberRegister.aspx");
        }
        else
        {
            output.Text = "Invalid input. Try Again!";
            image_string = imgSer.GetVerifierString("4");
            Stream stream = imgSer.GetImage(image_string);
            string imgPath = Server.MapPath(@"Pictures\xyz.jpg");
            System.Drawing.Image img = System.Drawing.Image.FromStream(stream);
            img.Save(imgPath, System.Drawing.Imaging.ImageFormat.Jpeg);
            string imgName = "~/Pictures/xyz.jpg";
            Image1.ImageUrl = imgName;
        }

    }
}