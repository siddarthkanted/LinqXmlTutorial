using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Text;
using System.Linq;

namespace LinqXmlConsoleApplication
{
    public class LinqQueryOperation
    {
        //print all students whose gender is female
        /*
         * descendants find an xelement in xdocument. No need to start with root.
         * Elements need to start with the root.
         */
        public void query()
        {
            XDocument xdocument = XDocument.Load(@"F:\dotnet\LinqXmlSolution\StudentsXml.xml");
            List<XElement> studentXElementList = xdocument.Element("students").Elements("student").Where(x => ((string)x.Element("gender")).Equals("male")).ToList();
            studentXElementList.ForEach(x => Console.WriteLine(x.Element("name").Value.ToString()));
        }
    }
}
