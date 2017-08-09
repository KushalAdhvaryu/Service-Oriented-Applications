using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CrimeData
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        /* [OperationContract]
         [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "crimedata?address={zipcode}")]
         Crimedetail CrimeInfo(string zipcode); */
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "crimedata?latitude={latitude}&longitude={longitude}")]
        listofCrime CrimeInfo(string latitude, string longitude);


        // TODO: Add your service operations here
    }
    [DataContract]
    public class listofCrime
    {
        [DataMember]
        public List<Crimedetail> listCrime { get; set; }
    }
    [DataContract]
    public class Crimedetail
    {
        [DataMember]
        public string type { get; set; }
        [DataMember]
        public string date { get; set; }
        [DataMember]
        public string address { get; set; }
    }

  /*  [DataContract]
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
   public class Crimedetail
    {
        [DataMember]
        public int violentCrime { get; set; }
        [DataMember]
        public int murder { get; set; }

        [DataMember]
        public string forcibleRapee { get; set; }
        [DataMember]
        public string robbery { get; set; }

        [DataMember]
        public string aggravatedAssault { get; set; }
        [DataMember]
        public string propertyCrime { get; set; }

        [DataMember]
        public string burglary { get; set; }
        [DataMember]
        public string larcenyTheft { get; set; }

        [DataMember]
        public string motorVehicleTheft { get; set; }
        [DataMember]
        public string arson { get; set; }


    }*/
}
