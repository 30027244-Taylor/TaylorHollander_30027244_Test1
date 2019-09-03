using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 2 - Sum of five different prices
            Console.WriteLine("...This program will give the sum of 5 prices...");

            //Variables set, used decimal for the two decimal places required
            decimal total = 0;
            bool loop = true;
            int item = 1;

            //Do While Loop
            do
            {
                Console.WriteLine($"Please enter the price of item {item}: ");
                total = total + decimal.Parse(Console.ReadLine());
                item++;

                //If statement ensures only five items are asked for
                if (item >= 6)
                {
                    loop = false;
                }
            } while (loop == true);

            //Displays total to the user
            Console.WriteLine($"The total of those items is: ${total}");

            Console.ReadLine();
        }
    }
}
