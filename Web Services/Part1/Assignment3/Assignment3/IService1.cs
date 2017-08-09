using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Assignment3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<WeatherDetails> WeatherInfo(string zipcode);



        // TODO: Add your service operations here
    }



    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class WeatherDetails
    {
        [DataMember]
        public string weather
        {
            get;
            set;
        }

        [DataMember]
        public string description
        {
            get;
            set;
        }

        [DataMember]
        public float temperature
        {
            get;
            set;
        }

        [DataMember]
        public float max_temp
        {
            get;
            set;
        }

        [DataMember]
        public float min_temp
        {
            get;
            set;
        }

        [DataMember]
        public float humidity
        {
            get;
            set;
        }

        [DataMember]
        public string date
        {
            get;
            set;
        }
    }
}
