using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTables();
            Dictionaries();
            WorkWithLists();
            Console.ReadKey();
        }

        private static void HashTables()
        {
            Hashtable table = new Hashtable();
            table.Add("Name", "Masha");
            table.Add("test", "Tom");
            foreach (var key in table.Keys)
            {
                Console.WriteLine("The name for " + key + " is " + table[key]);
            }

            Console.WriteLine("The user name is: " + table["Name"]);
        }

        public static void Dictionaries()
        {
            string[] dataM = new string[] { "test1", "masha" };
            string[] dataT = new string[] { "test2", "Tom" };
            Dictionary<int, string[]> dict = new Dictionary<int, string[]>();
            dict.Add(1, dataM);
            dict.Add(2, dataT);
            foreach (var value in dict)
            {
                string[] data = value.Value;
                foreach (var dataInfo in data)
                {
                    Console.WriteLine(dataInfo);
                }
            }

            Dictionary<int, Students> dict2 = new Dictionary<int, Students>();
            dict2.Add(1, new Students() { Name = "Masha", Age = 22 });
            dict2.Add(2, new Students() { Name = "Tom", Age = 25 });
            foreach (var item in dict2)
            {
                Students data = item.Value;
                var name = data.Name;
                Console.WriteLine(name);
            }
        }

        public static void WorkWithLists()
        {
            List<Students> students = new List<Students>()
            {
                new Students
                {
                    Name = "Tom",
                    Age = 12
                },
                new Students
                {
                    Name = "Masha",
                    Age = 15
                }
            };

            foreach (var student in students)
            {
                Console.WriteLine($"The student name is: {student.Name}");
            }
        }
    }

    public class Students
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
