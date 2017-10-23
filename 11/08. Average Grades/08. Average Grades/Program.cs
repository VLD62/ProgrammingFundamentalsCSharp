namespace _08.Average_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System.Text;

    class Student
    {

        public string Name;
        public List<double> Grades = new List<double>();
        public double AverageGrade;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(File.ReadLines("Input.txt").First());
            List<Student> Students = new List<Student>();
            string input;
            using (var fileStream = File.OpenRead("Input.txt"))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128))
       
            {
                while ((input = streamReader.ReadLine()) != null)
                {
                    for (int i = 0; i < num; i++)
                    {
                        string[] studentData = streamReader.ReadLine().Split().ToArray();
                        Student student = new Student();
                        student.Name = studentData[0];

                        for (int j = 1; j < studentData.Length; j++)
                        {
                            student.Grades.Add(Convert.ToDouble(studentData[j]));
                        }

                        student.AverageGrade = student.Grades.Average();

                        if (student.AverageGrade >= 5.00)
                        {
                            Students.Add(student);
                        }
                    }
                }

            }
            Students = Students.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade).ToList();

            using (StreamWriter outputFile = new StreamWriter("Output.txt"))
            {
                foreach (var zubar in Students)
                {
                    outputFile.WriteLine("{0} -> {1:f2}", zubar.Name, zubar.AverageGrade);
                }
            }
        }
    }
}
