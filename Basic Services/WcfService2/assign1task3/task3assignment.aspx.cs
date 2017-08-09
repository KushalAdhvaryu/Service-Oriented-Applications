using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

public partial class task3assignment : System.Web.UI.Page
{
    // Creating instance of Service Client.
   tempconversion.Service1Client c2f = new tempconversion.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        // Regular Expression used to validate the input. And Show appropriate Message in output field.
        if (!Regex.IsMatch(Celsius.Text, @"^[+-]?[0-9]{1,8}(?:\.[0-9]{1,9})?$"))
        {
            OutputF.Text = "Enter a valid number.";
        }
        else
        {
            // Converting Text Box input value to integer.
            int c = Convert.ToInt32(Celsius.Text);
            // Calling function from service to convert Celsius to Fahrenhiet.
            int f = c2f.c2f(c);
            // Setting Fahrenhiet value to output label.
            OutputF.Text = f.ToString();

        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        // Regular Expression used to validate the input. And Show appropriate Message in output field.
        if (!Regex.IsMatch(InputF.Text, @"^[+-]?[0-9]{1,8}(?:\.[0-9]{1,9})?$"))
        {
            OutputC.Text = "Enter a valid number.";
        }
        else
        {
            // Converting Text Box input value to integer.
            int f = Convert.ToInt32(InputF.Text);
            // Calling function from service to convert Fahrenhiet to Celsius.
            int c = c2f.f2c(f);
            // Display the value to output label.
            OutputC.Text = c.ToString();
        }
    }

    protected void Celsius_TextChanged(object sender, EventArgs e)
    {
        //Validatin max length to be 10
        Celsius.MaxLength = 10;
    }

    protected void InputF_TextChanged(object sender, EventArgs e)
    {
        //Validating max length to be 10.
        InputF.MaxLength = 10;
    }
}