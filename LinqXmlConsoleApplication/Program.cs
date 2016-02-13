using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqXmlConsoleApplication
{
    class Program
    {
        static void LinqXmlCreateOperation()
        {
            LinqXmlCreateOperation l = new LinqXmlCreateOperation();
            l.createXmlDocument();
        }

        static void LinqQueryOperation()
        {
            LinqQueryOperation l = new LinqQueryOperation();
            l.query();

        }

        static void LinqModifyOperation()
        {
            LinqModifyOperation l = new LinqModifyOperation();
            l.operation();
        }

        static void Main(string[] args)
        {
            //LinqXmlCreateOperation();
            //LinqQueryOperation();
            LinqModifyOperation();
            Console.WriteLine("finsih");
            Console.ReadLine();
        }
    }
}
