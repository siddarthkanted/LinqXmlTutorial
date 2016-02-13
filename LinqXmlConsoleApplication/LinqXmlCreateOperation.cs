using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Text;

namespace LinqXmlConsoleApplication
{
    /*
     * 4 important classes xdecleration to create 1
     * xelement to create 2 and 3
     * xattribute to create "id"
     * xcomment to create any comment
     * 
     * 
     * <xml version="1.0" enconding="utf-8" standalone="yes"> ===1
     * <students>         ====2
     * <student id="3">  
     * <name>sid</name>   ====3
     * <gender>male</name>
     * </student>
     * <student id="5">
     * <name>rak</name>
     * <gender>male</name>
     * </student>
     * </students>
     */
    public class LinqXmlCreateOperation
    {

        public void createXmlDocument()
        {
            XElement studentsXElement = createStudents();
            XDocument xdocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("created using linq"),
                studentsXElement
                );
            xdocument.Save(@"F:\dotnet\LinqXmlSolution\StudentsXml.xml");
        }

        private XElement createStudents()
        {
            XElement sidXElement = createStudentXElement("3", "sid", "male");
            XElement rakXElement = createStudentXElement("5", "rak", "male");
            XElement studentsXElement = new XElement("students", sidXElement, rakXElement);
            return studentsXElement;
        }

        private XElement createStudentXElement(string id, string name, string gender)
        {
            XElement studentXElement = new XElement("student",
                new XAttribute("id", id),
                new XElement("name", name),
                new XElement("gender", gender));
            return studentXElement;
        }
    }
}
