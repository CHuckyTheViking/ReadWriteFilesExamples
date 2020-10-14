using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ReadWriteTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteToFile("textfile.txt", "My name is Jesper Müllern and i'm 25 years old and lives in Köping");
            WriteToFile("textfile.txt", "Hello There Jesper, i'm computer");
            ReadFromFile("textfile.txt");
        }

        private static void WriteToFile(string filename, string content)
        {
            File.AppendAllText($@"c:\Files\{filename}", content);
        }

        private static void ReadFromFile(string filename)
        {
            var content = File.ReadAllText($@"c:\Files\{filename}");
            Console.WriteLine(content);
        }

    }
}
