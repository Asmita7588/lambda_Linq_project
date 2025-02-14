using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinqProject
{
    internal class Student
    {
        public string Name { get; set; } = string.Empty;
        public int Score { get; set; }
    }

    class GetStudentScore
    {
        public void FindScore() {

            List<Student> students = new List<Student>
            {
            new Student{ Name = "Arun" , Score = 89},
            new Student{ Name = "tarun" , Score = 98 },
            new Student{ Name = "varun" , Score = 78},
            new Student{ Name = "shriya" , Score = 81 },
            new Student{ Name = "sharvari" , Score = 67}

            };


            var highScorers = students.Where(s => s.Score > 80)
               .Select(s => s.Name)
               .ToList();

            foreach (var student in highScorers)
            {
                Console.WriteLine($" Student Name = {student}");
            }
        }
    }
}

