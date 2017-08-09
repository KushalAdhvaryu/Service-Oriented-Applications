using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        // Creating instance of Service Client.
        Celsius2Farenheit.Service1Client c2f = new Celsius2Farenheit.Service1Client();
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertC2F_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
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

        private void Celsius_TextChanged(object sender, EventArgs e)
        {
            Celsius.MaxLength = 10;
        }

        private void InputF_TextChanged(object sender, EventArgs e)
        {
            InputF.MaxLength = 10;
        }
    }
}
