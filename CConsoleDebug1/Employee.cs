using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CConsoleDebug1
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
    }

    public class EmployeeList
    {
        List<Employee> employees = new List<Employee>();

        public EmployeeList()
        {
            Employee emp1 = new Employee() { Id = 1, Name = "John Lennon", Age = 30, Department = "IT" };
            Employee emp2 = new Employee() { Id = 2, Name = "Paul Mccartney", Age = 25, Department = "HR" };
            Employee emp3 = new Employee() { Id = 3, Name = "George Harrison", Age = 40, Department = "Production" };
            Employee emp4 = new Employee() { Id = 4, Name = "Ringo Star", Age = 35, Department = "Production" };
            Employee emp5 = new Employee() { Id = 5, Name = "Mick Jagger", Age = 65, Department = "Finance" };
            Employee emp6 = new Employee() { Id = 6, Name = "Keith Richards", Age = 45, Department = "IT" };
            Employee emp7 = new Employee() { Id = 7, Name = "Charlie Watts", Age = 50, Department = "Production" };
            Employee emp8 = new Employee() { Id = 8, Name = "Ronnie Wood", Age = 55, Department = "Production" };
            Employee emp9 = new Employee() { Id = 9, Name = "Bill Wyman", Age = 60, Department = "Production" };

            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            employees.Add(emp4);
            employees.Add(emp5);
            employees.Add(emp6);
            employees.Add(emp7);
            employees.Add(emp8);
            employees.Add(emp9);
            employees.Add(new Employee() { Id = 10, Name = "Diana Ross", Age = 30, Department = "IT" });
            employees.Add(new Employee() { Id = 11, Name = "Mary Wilson", Age = 23, Department = "HR" });
            employees.Add(new Employee() { Id = 12, Name = "Florence Ballard", Age = 40, Department = "Production" });
            employees.Add(new Employee() { Id = 13, Name = "Susanna Hoffs", Age = 35, Department = "Production" });
            employees.Add(new Employee() { Id = 14, Name = "Debbi Peterson", Age = 66, Department = "Finance" });
            employees.Add(new Employee() { Id = 15, Name = "Annette Zilinskas", Age = 45, Department = "IT" });
            employees.Add(new Employee() { Id = 16, Name = "Vicki Peterson", Age = 50, Department = "Production" });

        }
        
        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public Employee GetEmployeeById(int Id)
        {
            foreach (Employee emp in employees)
            {
                if (emp.Id == Id)
                {
                    return emp;
                }
            }
            return null;
        }
    }
}
