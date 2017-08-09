using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using TextConverter;

/// <summary>
/// Summary description for XMLhandler
/// </summary>
public class XMLhandler
{
    public XMLhandler()
    {

    }
    public bool isPresent(string username, string type)
    {
        string path = "";
        if (type == "member")
        {
            path = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data\UserData.xml");
        }

        FileStream fStream = null;
        bool answer = false;
        try
        {
            fStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            XmlDocument doc = new XmlDocument();
            doc.Load(fStream);
            XmlNodeList nodes = doc.GetElementsByTagName("user");
            foreach (XmlNode node in nodes)
            {
                if (node.FirstChild.InnerText == username)
                {
                    answer = true;
                    break;
                }
            }
            fStream.Close();

        }
        catch (Exception ex)
        {

        }
        finally
        {
            fStream.Close();
        }

        return answer;
    }

    public bool addUser(string username, string password, string email, string type)
    {
        bool isAdded = false;
        string path = "";
     
            path = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data\UserData.xml");
    

        if (File.Exists(path))
        {
            if (!isPresent(username, type))
            {
                Stream fStream = null;
                try
                {
                    fStream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                    XmlDocument doc = new XmlDocument();
                    doc.Load(fStream);
                    XmlNode user = doc.CreateElement("user");
                    XmlNode usrnme = doc.CreateElement("username");
                    XmlNode pswrd = doc.CreateElement("password");
                    XmlNode eml = doc.CreateElement("email");
                    XmlNode typ = doc.CreateElement("type");

                    usrnme.InnerText = username;
                    pswrd.InnerText = password;
                    eml.InnerText = email;
                    typ.InnerText = type;

                    user.AppendChild(usrnme);
                    user.AppendChild(pswrd);
                    user.AppendChild(eml);
                    user.AppendChild(typ);

                    doc.DocumentElement.AppendChild(user);

                    fStream.Position = 0;
                    doc.Save(fStream);
                    fStream.Close();
                }
                finally
                {
                    fStream.Close();
                }
                isAdded = true;
            }
        }

        return isAdded;
    }


    public string getStaffType(string username, string password)
    {
        string isPresent = "";
        string path = "";
       
       path = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data\UserData.xml");
       
        TextConvertercls obj = new TextConvertercls();
        FileStream fStream = null;
        try
        {
            fStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            XmlDocument doc = new XmlDocument();
            doc.Load(fStream);
            XmlNodeList nodes = doc.GetElementsByTagName("user");
            foreach (XmlNode node in nodes)
            {
                if (node.FirstChild.InnerText == username && obj.getSecret(node.FirstChild.NextSibling.InnerText) == password)
                {
           
                    isPresent = node.FirstChild.NextSibling.NextSibling.NextSibling.InnerText;
                    break;
                }
            }
            fStream.Close();

        }
        catch (Exception ex)
        {

        }
        finally
        {
            fStream.Close();
        }
        return isPresent;
    }
}