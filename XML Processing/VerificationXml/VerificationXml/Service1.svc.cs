using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace VerificationXml
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        List<string> output = new List<string>();
        public List<string> xmlverification(string xmlUrl, string xsdUrl)
        {
            
            try
            {
                XmlSchemaSet sch = new XmlSchemaSet();
                sch.Add("", xsdUrl);
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.ValidationType = ValidationType.Schema;
                settings.Schemas = sch;
                settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);
                XmlReader reader = XmlReader.Create(xmlUrl, settings);
                while (reader.Read()) ;
                if(output.Count == 0)
                { output.Add("No Errors. The XML file validation has completed."); }
            }
            catch (Exception ex)
            {
                output.Add(ex.Message);
            }
            return output;
        }
        private void ValidationCallBack(object sender, ValidationEventArgs e)
        {
             output.Add(e.Message);
        }

    }
}
