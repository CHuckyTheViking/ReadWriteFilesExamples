using SharedClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ReadWriteCsvFile
{
    class Program
    {
        private static List<Person> persons = new List<Person>();
        static void Main(string[] args)
        {
            //Directory.CreateDirectory($@"c:\Files\csv");
            string content = "Jesper;Müllern;25;Köping";
            CsvService.WriteToFile($@"c:\Files\csv\persons.csv", content);

            var persons = CsvService.ReadFromFile($@"c:\Files\csv\persons.csv");
            

            foreach (var person in persons)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} is {person.Age} years old and lives in {person.City}");
            }
        }

       

        


    }
}
