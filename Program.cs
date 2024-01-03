using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataConsoleApp
{
       
           public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Course { get; set; }

            public override string ToString()
            {
                return $"Name: {Name}, Age: {Age}, Course: {Course}";
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Specify the path to the text file containing student data
                string filePath = "C:\\Users\\Hp\\Desktop\\PRACTISE EXCERCISES\\C#\\StudentData.txt";

                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Read all lines from the file
                    string[] lines = File.ReadAllLines(filePath);

                    // Create a list to store student objects
                    var students = new List<Student>();

                    // Parse each line and create Student objects
                    foreach (var line in lines)
                    {
                        string[] data = line.Split(',');
                        if (data.Length == 3)
                        {
                            var student = new Student
                            {
                                Name = data[0].Trim(),
                                Age = int.TryParse(data[1].Trim(), out int age) ? age : 0,
                                Course = data[2].Trim()
                            };

                            students.Add(student);
                        }
                    }

                    // Display student data
                    foreach (var student in students)
                    {
                        Console.WriteLine(student);
                    }
                }
                else
                {
                    Console.WriteLine($"File not found: {"C:\\Users\\Hp\\Desktop\\PRACTISE EXCERCISES\\C#"}");
                }

                Console.ReadLine(); // Keep the console window open
            }
        }

    }
