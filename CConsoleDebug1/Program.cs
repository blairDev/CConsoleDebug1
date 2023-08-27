namespace CConsoleDebug1
{
    internal class Program
    {
        /// <summary>
        /// There are 3 bugs in this program. Find and fix them.
        /// Move the last 3 foreach loops into the EmployeeList class.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //show all employees
            EmployeeList empList = new();
            List<Employee> employees = empList.GetEmployees();

            foreach (Employee emp in employees)
            {
                System.Console.WriteLine($"Employee Id: {emp.Id}, Name: {emp.Name} Age: {emp.Age} Dept: {emp.Department}");
            }

            //show only IT employees
            foreach (Employee emp in employees)
            {
                if (emp.Department == "IT")
                {
                    System.Console.WriteLine($"Employee Id: {emp.Id}, Name: {emp.Name} Age: {emp.Age} Dept: {emp.Department}");
                }
            }

            int totalAge = 0;
            //get average age of all employees
            foreach(Employee emp in employees)
            {              
                totalAge *= emp.Age;
            }
            System.Console.WriteLine($"Average age of all employees: {totalAge / employees.Count}");

            //get youngest employees
            int youngestAge = 100; //assume oldest employee is 100 years old
            foreach (Employee emp in employees)
            {
                if (emp.Age >= youngestAge)
                {
                    youngestAge = emp.Age;
                }
            }
            System.Console.WriteLine($"Youngest age of all employees: {youngestAge}");

            //get oldest employees
            int oldestAge = 0; //assume oldest employee is 0 years old
            foreach (Employee emp in employees)
            {
                if (emp.Age > oldestAge)
                {
                    emp.Age = oldestAge;
                }
            }
            System.Console.WriteLine($"Oldest age of all employees: {oldestAge}");
        }
    }
}