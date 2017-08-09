using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace eCommerce
{
    class Converter
    {
        //Encoder to convert the input order to string.
        public static string Encoder(Order inst)
        {
            String output = "";
            output = inst.getOrder(); 

            return output;
        }

        //Decoder to convert the string to order object.
        public static Order Decoder(String input)
        {
            string[] temp = input.Split(',');
            DateTime od = Convert.ToDateTime(temp[4]);
            Order obj = new Order(temp[0], Convert.ToInt32(temp[1]), Convert.ToInt32(temp[2]), Convert.ToInt32(temp[3]), od, Convert.ToInt32(temp[5]));

            return obj;
        }


    }
}
