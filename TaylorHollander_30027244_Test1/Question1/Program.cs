using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1 = Calculate base^exponent based on user input
            Console.WriteLine("This program will give the result of a base^exponent...");

            //User input for the base set as base1 and converted to double
            Console.WriteLine("Please enter a number for the base: ");
            double base1 = double.Parse(Console.ReadLine());

            //User input for exponent set as exp and converted to double
            Console.WriteLine("Please enter a number for the exponent: ");
            double exp = double.Parse(Console.ReadLine());

            //Double called result makes the base^exponent calculation
            double result = (base1 * base1) * exp;

            //Result displayed to the user
            Console.WriteLine($"{base1}^{exp} = {result}");

            Console.ReadLine();
        }
    }
}
