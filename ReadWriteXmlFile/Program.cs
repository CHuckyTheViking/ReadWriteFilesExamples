using SharedClassLibrary;
using System;

namespace ReadWriteXmlFile
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlService.WriteToFile(@"c:\Files\books.xml");
            XmlService.ReadFromFile(@"c:\Files\books.xml");
        }
    }
}
