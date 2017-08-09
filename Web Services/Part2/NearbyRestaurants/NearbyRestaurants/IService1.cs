using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace NearbyRestaurants
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebInvoke(Method ="GET", ResponseFormat = WebMessageFormat.Json, UriTemplate ="restaurant?address={zipcode}")]
        listofRest RestaurantInfo(string zipcode);

        // TODO: Add your service operations here
    }
    [DataContract]
    public class listofRest
    {
        [DataMember]
        public List<RestDetails> listRest { get; set; }
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class RestDetails    
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public bool isclose { get; set; }
        [DataMember]
        public string price { get; set; }
        [DataMember]
        public string phone { get; set; }
       
    }
}
