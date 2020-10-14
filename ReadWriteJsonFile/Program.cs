using SharedClassLibrary;
using System;

namespace ReadWriteJsonFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //JsonService.WriteToFile(@"c:\Files\persons.json", new Person("Jesper", "Müllern", 25, "Köping"));
            //JsonService.ReadFromFile(@"c:\Files\persons.json");
            JsonService.WriteToFileCorrect(@"c:\Files\persons.json", new Person("Jesper", "Müllern", 25, "Köping"));
        }
    }
}
