using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 3a - Solve 2(x-3) + x = 12 for x
            //Expand brackets > 2x - 6 + x = 12
            //Add like terms > 3x - 6 = 12
            //Subtract 6 from both sides > 3x = 18
            //Divide both sides by 3 > x = 6
            // x = 6


            //Question 3b - Guess the value of x game

            //Integer called x set as the value of x as found above
            int x = 6;

            //Program ask user for their guess and converts it to an integer called guess
            Console.WriteLine("----- Can you solve this equation to find x? ----- \n 2(x - 3) + x = 12");
            Console.WriteLine("Please enter your guess: "); 
            int guess = int.Parse(Console.ReadLine()); 

            //If statement checks user input against x and displays whether they are correct or not
            if (guess == x)
            {
                Console.WriteLine("That is correct!");
            }

            else
            {
                Console.WriteLine("Sorry your guess is incorrect.");
            }

            Console.ReadLine();

        }
    }
}
