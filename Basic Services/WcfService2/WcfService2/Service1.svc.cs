﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public int c2f(int c)
        {
            // using forumla to convert C to F.
            double f = c * 1.8 + 32;
            // Type cast from double to Int as per assignment 1 Document return type should be int.
            int ans = (int)f;

            return ans;

        }

        public int f2c(int f)
        {
            // using forumla to convert F to C.
            double c = (f - 32) / 1.8;
            // Type cast from double to Int as per assignment 1 Document return type should be int.
            int ans = (int)c;
            return ans; 
        }
    }
}
