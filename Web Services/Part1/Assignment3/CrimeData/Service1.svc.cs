using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json;
namespace CrimeData
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public listofCrime CrimeInfo(string latitude, string longitude)
        {
            string key = "privatekeyforspotcrimepublicusers-commercialuse-877.410.1607";
            string baseurl = @"http://api.spotcrime.com/crimes.json?key="+key+"&lat=" + latitude + "&lon=" + longitude + "&radius=0.02";
            listofCrime output = new listofCrime();
            List<Crimedetail> result = new List<Crimedetail>();

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseurl);
            try
            {
                WebResponse response = request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                if (responseStream != null)
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    String responseJSON = streamReader.ReadToEnd();


                    Node responseList = JsonConvert.DeserializeObject<Node>(responseJSON);
                    for (int i = 0; i < responseList.crimes.Count; i++)
                    {
                        result.Add(new Crimedetail()
                        {
                            type = responseList.crimes[i].type,
                            date = responseList.crimes[i].date,
                            address = responseList.crimes[i].address,
                           

                        });
                    }

                }
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.Message);
            }
            output.listCrime = result;
            return output;

        }

        public class Node
        {
            public List<Crimes> crimes { get; set; }
        }

        public class Crimes
        {
            public int cdid { get; set; }
            public string type { get; set; }
            public string date { get; set; }
            public string address { get; set; }
            public string link { get; set; }
            public double lat { get; set;}
        }
      /* public Crimedetail CrimeInfo(string zipcode)
        {
            Crimedetail result = new Crimedetail();
            
            string baseurl = @"https://azure.geodataservice.net/GeoDataService.svc/GetUSDemographics?includecrimedata=true&zipcode=" + zipcode;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseurl);
            request.Method = "GET";
            try
            {
                WebResponse response = request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                if (responseStream != null)
                {
                    XmlDocument xmlDoc = new XmlDocument();
                   
                    xmlDoc.Load(responseStream);
                   
                    XmlNode node = xmlDoc.DocumentElement;
                    foreach(XmlNode childNode in node.ChildNodes)
                    {
                        foreach (XmlNode grandchild in childNode.ChildNodes)
                        {
             
                            if (grandchild.Name == "ViolentCrime") {
                                result.violentCrime = Convert.ToInt32(grandchild.Value);
                            }else if(grandchild.Name == "MurderAndManslaughter")
                            {
                                result.murder = Convert.ToInt32(grandchild.InnerText);
                            }
                            else if (grandchild.Name == "ForcibleRape")
                            {
                                result.forcibleRapee = grandchild.InnerText;
                            }
                            else if (grandchild.Name == "Robbery")
                            {
                                result.robbery = grandchild.InnerText;
                            }
                            else if (grandchild.Name == "AggravatedAssault")
                            {
                                result.aggravatedAssault = grandchild.InnerText;
                            }
                            else if (grandchild.Name == "PropertyCrime")
                            {
                                result.propertyCrime = grandchild.InnerText;
                            }
                            else if (grandchild.Name == "Burglary")
                            {
                                result.burglary = grandchild.InnerText;
                            }
                            else if (grandchild.Name == "LarcenyTheft")
                            {
                                result.larcenyTheft = grandchild.InnerText;
                            }
                            else if (grandchild.Name == "MotorVehicleTheft")
                            {
                                result.motorVehicleTheft = grandchild.InnerText;
                            }
                            else if (grandchild.Name == "Arson")
                            {
                                result.arson = grandchild.InnerText;
                            }
                        }
                    }
                    
                }
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.Message);
            }
            return result;
        }*/
    }
}
