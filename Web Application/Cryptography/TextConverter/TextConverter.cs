using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace TextConverter
{
    public class TextConvertercls
    {
        public string setSecret(string Input)
        {
            string output = "" ;
            byte[] inputArr = UTF8Encoding.UTF8.GetBytes(Input);
            try
            {
                TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();
                DES.Key = UTF8Encoding.UTF8.GetBytes("ABCDEFGHIJKLMNOP");
                DES.Mode = CipherMode.ECB;
                DES.Padding = PaddingMode.PKCS7;
                ICryptoTransform trsnfm = DES.CreateEncryptor();
                byte[] outputArr = trsnfm.TransformFinalBlock(inputArr, 0, inputArr.Length);
                DES.Clear();
                output = Convert.ToBase64String(outputArr, 0, outputArr.Length);

            }
            catch(Exception ex)
            {
                output = "Exception Occured";
            }
            return output;
        }

        public string getSecret(string Input)
        {
            string output = " ";
            byte[] inputArr = Convert.FromBase64String(Input);
            try
            {
                TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();
                DES.Key = UTF8Encoding.UTF8.GetBytes("ABCDEFGHIJKLMNOP");
                DES.Mode = CipherMode.ECB;
                DES.Padding = PaddingMode.PKCS7;
                ICryptoTransform trsnfm = DES.CreateDecryptor();
                byte[] outputArr = trsnfm.TransformFinalBlock(inputArr, 0, inputArr.Length);
                DES.Clear();
                output = UTF8Encoding.UTF8.GetString(outputArr);
            }
            catch(Exception ex)
            {
                output = "Excpetion Occured";
            }

            return output;
        }
    }
}
