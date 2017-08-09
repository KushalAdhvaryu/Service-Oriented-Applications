using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webbrowser
{
    public partial class Form1 : Form
    {
        // Creating instances of services encrypt and stock quote.
        TextEncrypt.ServiceClient encrypt = new TextEncrypt.ServiceClient();
        StockValue.ServiceClient stockvalue = new StockValue.ServiceClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // To Navigate URL passing URL box value to Navigate method.
            webBrowser1.Navigate(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // To perform action when Refresh is clicked.
            webBrowser1.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            // To Stop loading URL when Stop button is clicked.
            webBrowser1.Stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // To navigate Back URL when user clicks Back Arrow.
            webBrowser1.GoBack();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // To Navigate Forward URL when user clicks forward Arrow.
            webBrowser1.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Calling Encrypt Method of Encryption service when Encrypt button is clicked.
            label2.Text = encrypt.Encrypt(textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // To call Decrypt method when Send To Reciever is clicked. But for Output text an Exception will be shown in Output label value.
                label2.Text = encrypt.Decrypt(label2.Text);
            }
            catch(Exception ex)
            {
                label2.Text = " ";
                label2.Text = ex.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Calling getStockQuote method to recieve stock value of company entered.
            label6.Text = stockvalue.getStockquote(textBox3.Text);
        }
    }
}
