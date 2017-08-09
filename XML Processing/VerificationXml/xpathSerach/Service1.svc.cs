using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.XPath;

namespace xpathSerach
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<String> xpathsearch(string xmlurl, string pathExpr)
        {
            List<String> output = new List<string>();
            try
            {
                XPathDocument xmlDoc = new XPathDocument(xmlurl);
                XPathNavigator iter = xmlDoc.CreateNavigator();
                XPathNodeIterator pathitr = iter.Select(pathExpr);
                while(pathitr.MoveNext())
                {
                    output.Add(pathitr.Current.Value);
                    output.Add(" ");

                }

            }
            catch(Exception ex)
            {
                output.Add(ex.Message);

            }
            return output;
        }
    }
}
