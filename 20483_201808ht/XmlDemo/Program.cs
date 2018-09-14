using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            doc.Load(@"c:\temp\person.xml");
            var res = doc.SelectNodes("//person[@id=1]");

        }
    }
}
