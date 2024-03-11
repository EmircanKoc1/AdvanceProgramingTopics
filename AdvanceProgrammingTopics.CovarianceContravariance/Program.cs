using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AdvanceProgrammingTopics.CovarianceContravariance
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Convarience
            IEnumerable<object> arabalar = new List<string>();

            object[] isimler = new string[3] { "", "", "" };

            //contravarince
            Action<string> xDelegate = XMethod;



        }
        static void XMethod(object o)
        {
        }

    }
}
