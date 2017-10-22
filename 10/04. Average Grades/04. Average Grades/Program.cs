namespace _04.Average_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Student {

        public string Name;
        public List<double> Grades = new List<double>();
        public double AverageGrade;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<Student>Students = new List<Student>();
            for (int i = 0; i < num; i++)
            {
                string[] studentData = Console.ReadLine().Split().ToArray();
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
            Students = Students.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade).ToList();

            foreach (var zubar in Students)
            {
                Console.WriteLine("{0} -> {1:f2}", zubar.Name, zubar.AverageGrade);
            }
        }
    }
}
