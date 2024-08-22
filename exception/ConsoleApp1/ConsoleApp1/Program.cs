using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program : Exception
    {
        static void Main(string[] args)
        {
            //    try
            //    {
            //        Console.WriteLine("Enter a number:");
            //        int number = Convert.ToInt32(Console.ReadLine());

            //        Console.WriteLine("Enter another number to divide by:");
            //        int divisor = Convert.ToInt32(Console.ReadLine());

            //        int result = Divide(number, divisor);
            //        Console.WriteLine($"Result: {result}");
            //    }
            //    catch (FormatException ex)
            //    {
            //        Console.WriteLine("Error: Input was not a valid number.");
            //        Console.WriteLine($"Exception Details: {ex.Message}");
            //    }
            //    catch (DivideByZeroException ex)
            //    {
            //        Console.WriteLine("Error: Cannot divide by zero.");
            //        Console.WriteLine($"Exception Details: {ex.Message}");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("An unexpected error occurred.");
            //        Console.WriteLine($"Exception Details: {ex.Message}");
            //    }
            //    finally
            //    {
            //        Console.ReadKey();
            //        Console.WriteLine("Program execution completed.");
            //    }
            //}

            //static int Divide(int numerator, int denominator)
            //{
            //    return numerator / denominator;
            //}

            //var employees = new List<Employee>
            //{
            //new Employee { Department = "HR", Salary = 5000 },
            //new Employee { Department = "HR", Salary = 6000 },
            //new Employee { Department = "HR", Salary = 5500 },
            //new Employee { Department = "IT", Salary = 7000 },
            //new Employee { Department = "IT", Salary = 8000 },
            //new Employee { Department = "Finance", Salary = 9000 },
            //new Employee { Department = "Finance", Salary = 10000 },
            //new Employee { Department = "Finance", Salary = 9500 },
            //new Employee { Department = "Finance", Salary = 9800 }
            //};

            //// LINQ query to find the department with the highest average salary
            //var topDepartment = employees
            //    .GroupBy(e => e.Department)
            //    .Where(g => g.Count() >= 3)
            //    .Select(g => new
            //    {
            //        Department = g.Key,
            //        AverageSalary = g.Average(e => e.Salary)
            //    })
            //    .OrderByDescending(d => d.AverageSalary)
            //    .FirstOrDefault();

            //Console.WriteLine(topDepartment?.Department ?? "null");

            //var numbers = new List<int> {1  };

            //// Retrieve the first element
            //int firstNumber = numbers.First();
            //Console.WriteLine($"First number: {firstNumber}");

            //// Retrieve the first even number
            //int firstEvenNumber = numbers.First(n => n % 2 == 0);
            //Console.WriteLine($"First even number: {firstEvenNumber}");

            //var numbers = new List<int> { 1, 2, 3, 4, 5 };

            //// Retrieve the first element
            //int firstNumber = numbers.FirstOrDefault();
            //Console.WriteLine($"First number: {firstNumber}");

            //// Retrieve the first even number
            //int firstEvenNumber = numbers.FirstOrDefault(n => n % 2 == 0);
            //Console.WriteLine($"First even number: {firstEvenNumber}");

            //// Returns 0 because the collection is empty (default value for int)
            //var emptyList = new List<int>();
            //var firstInEmptyList = emptyList.FirstOrDefault();
            //Console.WriteLine($"First in empty list: {firstInEmptyList}");

            //// Works similarly with reference types, returns null if no matching element
            //var emptyStringList = new List<string>();
            //var firstInEmptyStringList = emptyStringList.FirstOrDefault();
            //Console.WriteLine($"First in empty string list: {firstInEmptyStringList ?? "No elements"}");


            //var numbers = new List<int> { 2, 3, 4, 5 };

            //// Retrieve the single element with the value 3
            //int singleNumber = numbers.Single(n => n == 3);
            //Console.WriteLine($"Single number: {singleNumber}");

            //// Retrieve the single element with the value 3
            //int singleOrDefaultNumber = numbers.SingleOrDefault(n => n == 3);
            //Console.WriteLine($"Single or default number: {singleOrDefaultNumber}");

            //// Returns 0 because there are no elements that match the condition
            //int singleOrDefaultNotFound = numbers.SingleOrDefault(n => n == 10);
            //Console.WriteLine($"Single or default not found: {singleOrDefaultNotFound}");

            //Console.WriteLine("Enter a numerator:");
            //string numeratorInput = Console.ReadLine();

            //Console.WriteLine("Enter a denominator:");
            //string denominatorInput = Console.ReadLine();
            try
            {
                // Attempt to convert inputs to integers
                int numerator = 1;
                int denominator = 0;

                int result = numerator / denominator;  // This would normally throw DivideByZeroException
                Console.WriteLine("Result: " + result);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            
            finally
            {
                Console.WriteLine("This message is always displayed, regardless of an exception.");
            }
            Console.ReadKey();
        }
    }

    public class Employee
    {
        public string Department { get; set; }
        public decimal Salary { get; set; }
    }
}
