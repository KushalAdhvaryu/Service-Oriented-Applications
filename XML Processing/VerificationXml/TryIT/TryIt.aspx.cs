using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TryIT
{
    public partial class TryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try {
                verifyService.Service1Client verifyxml = new verifyService.Service1Client();
                String[] result = verifyxml.xmlverification(xmlurl.Text, xsdurl.Text);
                output_verify.Text = "";
                for (int i=0; i< result.Length; i++)
                {
                    output_verify.Text += result[i] + "<br/>";
                    
                }
                
            }
            catch (Exception)
            {
                output_verify.Text = "Enter valid Inputs";
                output_verify.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                xpathService.Service1Client verifyxml = new xpathService.Service1Client();
                String[] result = verifyxml.xpathsearch(xmlurl_xpath.Text, xpath_expr.Text);
                output_xpath.Text = "";
                for (int i = 0; i < result.Length; i++)
                {
                    output_xpath.Text += result[i] + "<br/>";

                }

            }
            catch (Exception)
            {
                output_xpath.Text = "Enter valid Inputs";
                output_verify.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}