using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //DONE: Print the Sum of numbers
            Console.WriteLine($"Sum of numbers:  {numbers.Sum(x => x)}");

            //DONE: Print the Average of numbers
            Console.WriteLine($"Average of numbers:  {numbers.Average(x => x)}");

            Console.WriteLine();

            //DONE: Order numbers in ascending order and print to the console
            foreach (int i in numbers.OrderBy(x => x))
                Console.WriteLine($"Ascending numbers:  > {i}");
            Console.WriteLine();

            //DONE: Order numbers in decsending order and print to the console
            foreach (int i in numbers.OrderByDescending(x => x))
                Console.WriteLine($"Descending numbers:  > {i}");
            Console.WriteLine();

            //DONE: Print to the console only the numbers greater than 6
            foreach (int i in numbers.Where(x => x > 6))
                Console.WriteLine($"Greater than 6 > {i}");
            Console.WriteLine();

            //DONE: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            foreach (int i in numbers.OrderBy(x => x).TakeLast(4))
                Console.WriteLine($"Print only 4 > {i}");
            Console.WriteLine();

            //DONE: Change the value at index 4 to your age, then print the numbers in decsending order
            numbers[4] = 62;
            foreach (int i in numbers.OrderByDescending(x => x))
                Console.WriteLine($"Print with my age > {i}");
            Console.WriteLine();

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //DONE: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            foreach (Employee e in employees.Where(x => x.FirstName[0] == 'C' || x.FirstName[0] == 'S').OrderBy(n => n.FirstName))
                Console.WriteLine($"C & S Firstnames:  > {e.FullName} ");

            Console.WriteLine();

            //DONE: Print all the employees' FullName and Age who are over the age 26 to the console and
            // order this by Age first and then by FirstName in the same result.
            foreach (Employee e in employees.Where(x => x.Age > 26).OrderBy(n => n.Age).OrderBy(m => m.FirstName))
                Console.WriteLine($"Ascending Age:  > {e.Age}-{e.FullName} ");
            Console.WriteLine();

            //DONE: Print the Sum and then the Average of the employees' YearsOfExperience if their
            //      YOE is less than or equal to 10 AND Age is greater than 35.

            foreach (Employee e in employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35)) 
                Console.WriteLine($"YOE and Age: > {e.FullName}, {e.YearsOfExperience}, {e.Age}");
           
            var employees2 = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
            Console.WriteLine($"SUM YOE > {employees2.Sum(x => x.YearsOfExperience)}");
            Console.WriteLine($"AVG YOE >{employees2.Average(x => x.YearsOfExperience)}");
            Console.WriteLine();

            //DONE: Add an employee to the end of the list without using employees.Add()
            Employee emp = new Employee();
            emp.Age = 47;
            emp.YearsOfExperience = 10;
            emp.LastName = "Patterson";
            emp.FirstName = "David";
            employees.Insert(employees.Count, emp );
           
            foreach(Employee e in employees) Console.WriteLine(e.FirstName);

            Console.WriteLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
