using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace LinqXmlConsoleApplication
{
    public class LinqModifyOperation
    {
        private XDocument xdocument = XDocument.Load(@"F:\dotnet\LinqXmlSolution\StudentsXml.xml");
        public void operation()
        {
            //AddXElement();
            //AddCopy();
            //ModifyXElementValue();
            RemoveXElement();
            xdocument.Save(@"F:\dotnet\LinqXmlSolution\StudentsXml.xml");
        }

        private void AddXElement()
        {
            
            XElement dadStudentXElement = createStudentXElement("19", "DAD", "MALE");
            xdocument.Element("students").Add(dadStudentXElement);


        }

        private void AddCopy()
        {
            XElement originalXelement = xdocument.Descendants("student").First();
            XElement copyXelement = new XElement(originalXelement);
            copyXelement.Element("name").Value = "mom";
            xdocument.Element("students").Add(copyXelement);
        }

        private XElement createStudentXElement(string id, string name, string gender)
        {
            XElement studentXElement = new XElement("student",
                new XAttribute("id", id),
                new XElement("name", name),
                new XElement("gender", gender));
            return studentXElement;
        }

        private void ModifyXElementValue()
        {
            XElement xElement = xdocument.Descendants("student").Where(x => x.Element("name").Value.Equals("mom")).First();
            xElement.Attribute("id").Value = "5";
            xElement.Element("gender").Value = "female";
        }

        private void RemoveXElement()
        {
            xdocument.Descendants("student").Where(x => x.Element("name").Value.Equals("pin")).Remove();
        }
    }
}
