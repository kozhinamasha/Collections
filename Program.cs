using System;
using System.Collections;
using System.Collections.Generic;

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

            Dictionary<int, Student> dict2 = new Dictionary<int, Student>();
            dict2.Add(1, new Student() { Name = "Masha", Age = 22 });
            dict2.Add(2, new Student() { Name = "Tom", Age = 25 });
            foreach (var item in dict2)
            {
                Student data = item.Value;
                var name = data.Name;
                Console.WriteLine(name);
            }
        }

        public static void WorkWithLists()
        {
            List<Student> students = new List<Student>()
            {
                new Student
                {
                    Name = "Tom",
                    Age = 12
                },
                new Student
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

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
