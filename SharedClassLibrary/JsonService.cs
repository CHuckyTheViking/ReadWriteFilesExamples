using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;

namespace SharedClassLibrary
{
    public static class JsonService
    {
        public static void WriteToFile(string filepath, Person person)
        {
            var json = JsonConvert.SerializeObject(person);

            using StreamWriter writer = new StreamWriter(filepath);
            writer.WriteLine(json);
          
        }

        public static void ReadFromFile(string filepath)
        {
            using StreamReader reader = new StreamReader(filepath);
            var json = reader.ReadToEnd();
            Console.WriteLine(json);
        }

        public static void WriteToFileCorrect(string filepath, Person person)
        {
            try
            {
                using StreamReader reader = new StreamReader(filepath);
                var json = reader.ReadToEnd();
                reader.Close();

                if (json != string.Empty)
                {
                    var list = JsonConvert.DeserializeObject<List<Person>>(json);
                    list.Add(person);

                    var json2 = JsonConvert.SerializeObject(list);


                    using StreamWriter writer = new StreamWriter(@"c:\Files\persons.json");
                    writer.Write(json2);

                    writer.Close();
                }
            }
            catch
            {
                using StreamWriter writer = new StreamWriter(filepath);
                var list = new List<Person>() { person };
                var json = JsonConvert.SerializeObject(list);

                writer.Write(json);

                writer.Close();
            }
    
        }
    }
}
