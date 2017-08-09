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

namespace NearbyRestaurants
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public listofRest RestaurantInfo(string zipcode)
        {
            listofRest output = new listofRest();
            List<RestDetails> result = new List<RestDetails>();
            string apikey = "OMcih1Gv-IU1j0gQSOoydElmrpIb9LVgdqy3q4dX5DFQkBHJzdQzYh-oRPikBfEK_v20q2ecHo0gMWuzXxYZLLvH0sUoy4jYU20oFGjh9zrSrpFJ6bJMpcZ3kBs3WXYx";
            string baseurl = @"https://api.yelp.com/v3/businesses/search?term=restaurants&location=" + zipcode;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseurl);
            request.Headers["Authorization"] = "Bearer " + apikey;
            try
            {
                WebResponse response = request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                if (responseStream != null)
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    String responseJSON = streamReader.ReadToEnd();


                    Node responseList = JsonConvert.DeserializeObject<Node>(responseJSON);
                    for (int i = 0; i < responseList.businesses.Count; i++)
                    {
                        result.Add(new RestDetails()
                        {
                            name = responseList.businesses[i].name,
                            isclose = responseList.businesses[i].is_closed,
                            price = responseList.businesses[i].price,
                            phone = responseList.businesses[i].display_phone,
                            
                        });
                    }
                        
                }
            }
            catch(Exception e)
            {
                Console.Out.WriteLine(e.Message);
            }
            output.listRest = result;
            return output;
        }

        public class Node
        {
            public List<Businesses> businesses { get; set; }
            public string total { get; set; }
            public Region region { get; set; }
             
        }


        public class Businesses
        {
            public string id { get; set; }
            public string name { get; set; }
            public string image_url { get; set; }
            public bool is_closed { get; set; }
            public string url { get; set;}
            public int review_count { get; set; }
            public List<Categories> categories { get; set; }
            public double rating { get; set; }
            public Coordinates coordinates { get; set;}
            public List<object> transactions { get; set; }
            public string price { get; set; }
            public Location location { get; set; }
            public string phone { get; set; }
            public string display_phone { get; set; }
            public double distance { get; set; }
        }

        public class Region
        {
            public Center center { get; set; }
        }

        public class Categories
        {
            public string alias { get; set; }
            public string title { get; set; }

        }

        public class Coordinates
        {
            public double latitude { get; set; }
            public double longitude { get; set; }
        }


        public class Location
        {
            public string address1 { get; set; }
            public string address2 { get; set; }
            public string address3 { get; set; }
            public string city { get; set; }
            public string zipcode { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public List<string> display_address { get; set; }
        }

        public class Center
        {
            public double latitude { get; set; }
            public double longitude { get; set; }
        }
    }
}
