using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinqProject
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; 
        public int Salary { get; set; }

        public string Department { get; set; } = string.Empty ;
    }
     class EmployeeList
     {
        public void CheckEmployeeSalary()
        {

                 List<Employee> list = new List<Employee>
                 {
                     new Employee{Id = 1 , Name = "Asmita", Salary = 232536},
                     new Employee{Id = 3 , Name = "Akash", Salary = 480000},
                     new Employee{Id = 4 , Name = "Sagar", Salary = 343000},
                     new Employee{Id = 2 , Name = "Chetan", Salary = 847834738},
                     new Employee{Id = 5 , Name = "Aniket", Salary = 12415 },
                     new Employee{Id = 7 , Name = "Pranay", Salary = 10010},
                     new Employee{Id = 6 , Name = "Pravin", Salary = 32652},
                     new Employee{Id = 8 , Name = "Ankita", Salary = 432362}

                 };


            var result = list.Where(emp => emp.Salary > 50000).ToList();

            Console.WriteLine("Employees with Salary > 50,000:");

            foreach (var emp in result)
            {
                if(emp.Name != null)
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}");
            }
        }

        public void AverageSalaryByDepartment()
        {

                 List<Employee> list1 = new List<Employee>
                 {
                     new Employee{Id = 1 , Name = "Asmita", Salary = 232536, Department = "IT"},
                     new Employee{Id = 3 , Name = "Akash", Salary = 480000, Department = "Finance"},
                     new Employee{Id = 4 , Name = "Sagar", Salary = 343000, Department = "HR"},
                     new Employee{Id = 2 , Name = "Chetan", Salary = 847834738 , Department = "HR"},
                     new Employee{Id = 5 , Name = "Aniket", Salary = 12415 , Department = "IT"},
                     new Employee{Id = 7 , Name = "Pranay", Salary = 10010, Department = "Finance"},
                     new Employee{Id = 6 , Name = "Pravin", Salary = 32652, Department = "IT"},
                     new Employee{Id = 8 , Name = "Ankita", Salary = 432362, Department = "HR"}

                 };


                  var avgSalaryByDep = list1.GroupBy(e => e.Department).
                                        Select(group =>new
                                        {
                                           group.Key,
                                           avgSalary = group.Average(e => e.Salary),
                                        } );

                  Console.WriteLine("Average salary by department:");
                   foreach (var dept in avgSalaryByDep)
                   {
                           Console.WriteLine($"{dept.Key}: {dept.avgSalary:F2}");
                   }
        }


    }



}
