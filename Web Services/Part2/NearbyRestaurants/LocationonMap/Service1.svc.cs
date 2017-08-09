using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LocationonMap
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string[] MapInfo(double latitude, double longitude)
        {
            string[] result = new string[2];
            string staticapikey= "AIzaSyD6esfrlagXsTDlpKrOmjtfrV0vywj5Ik8";
            string streetviewapikey = "AIzaSyB2I93j7CWL2dfmRCWdy09CAPODIqN_wwI";
            string staticbaseurl = "https://maps.googleapis.com/maps/api/staticmap?center="+ latitude + ","+ longitude +
                                    "&zoom=15&size=640x640&markers=color:red%7Clabel:L%7C"+ latitude + ","+ longitude +"&key="+ staticapikey;
            string streetviewbaseurl = "https://maps.googleapis.com/maps/api/streetview?size=640x640&location=" + latitude + "," + longitude +
                                       "&heading=100&pitch=28&scale=2&key=" + streetviewapikey;

            result[0] = staticbaseurl;
            result[1] = streetviewbaseurl;

            return result;
        }
    }
}
