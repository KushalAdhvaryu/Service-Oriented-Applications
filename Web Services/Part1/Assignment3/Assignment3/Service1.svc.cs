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

namespace Assignment3   
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public List<WeatherDetails> WeatherInfo(string zipcode)
        {

            List<WeatherDetails> result = new List<WeatherDetails>();
            string apikey = "7e391b9bdeca893ad8e285b3e5a77e32";
            string baseurl = @"http://api.openweathermap.org/data/2.5/forecast?appid=" + apikey + "&zip=" + zipcode + "&units=imperial" ;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseurl);
            request.Method = "GET";
            try
            {
                WebResponse response = request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                if (responseStream != null)
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    String responseJSON = streamReader.ReadToEnd();
                    Console.Out.Write(responseJSON);

                    Node responseList = JsonConvert.DeserializeObject<Node>(responseJSON);
                    
                    for (int i = 0; i < responseList.list.Count; i++)
                    {
                        result.Add(new WeatherDetails()
                        {
                            weather = responseList.list[i].weather[0].main,
                            description = responseList.list[i].weather[0].description,
                            temperature = responseList.list[i].main.temp,
                            max_temp = responseList.list[i].main.temp_max,
                            min_temp = responseList.list[i].main.temp_min,
                            humidity = responseList.list[i].main.humidity,
                            date = responseList.list[i].dt_txt,
                        });
                    }                   
                }
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.Message);
            }
               return result;
        }

        public class Node
        {
            public string cod { get; set; }
            public double message { get; set; }
            public int cnt { get; set; }
            public List<List> list { get; set; }
            public City city { get; set; }
        }

        public class List
        {
            public int dt { get; set; }
            public Main main { get; set; }
            public List<Weather> weather { get; set; }
            public Clouds clouds { get; set; }
            public Wind wind { get; set; }
            public Sys sys { get; set; }
            public string dt_txt { get; set; }

        }

        public class City
        {
            public int id { get; set; }
            public string name { get; set; }
            public Coord coord { get; set; }
            public string country { get; set; }
            public int population { get; set; }

        }

        public class Main
        {
            public float temp { get; set; }
            public float temp_min { get; set; }
            public float temp_max { get; set; }
            public float pressure { get; set; }
            public float sea_level { get; set; }
            public float grn_level { get; set; }
            public int humidity { get; set; }
            public double temp_kf { get; set; }
        }

        public class Weather
        {
            public int id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }
        public class Clouds
        {
            public int all { get; set; }
        }

        public class Wind
        {
            public float speed { get; set; }
            public float deg { get; set; }
        }

        public class Sys
        {
            public string pod { get; set; }
        }

        public class Coord
        {
            public float lat { get; set; }
            public float lon { get; set; }
        }

    }
}
