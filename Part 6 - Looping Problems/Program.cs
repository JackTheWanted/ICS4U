//Jack
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Part_6___Looping_Problems
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Random generate = new Random();
            //1
            int min;
            int max;
            int range;

            Console.WriteLine("What is the minimum value");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the maximum value");
            max = Convert.ToInt32(Console.ReadLine());
            if (max <= min)
            {
                Console.WriteLine("Error: not possible set of numbers.");
                System.Environment.Exit(0);
            }
            Console.WriteLine("What is a number between the max and min?");
            range = Convert.ToInt32(Console.ReadLine());


            while (range > max || range < min)
            {
                Console.WriteLine("What is a number between the max and min?");
                range = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("That number is within range.");


            //2

            int selection;
            double above = 0;
            double overall = 0;
            do
            {
                Console.WriteLine("Please enter all of your marks (in %), we will determine the percentage of them above 70%");
                Console.WriteLine("Enter 000 to submit.");
                if (!Int32.TryParse(Console.ReadLine(), out selection))
                {
                    Console.WriteLine("Error");
                    System.Environment.Exit(0);

                }

                else if (selection >= 70)
                {
                    above += 1;
                    overall += 1;
                }

                else if (selection < 70)
                {
                    overall += 1;
                }


            } while (selection != 000);

            Console.WriteLine($"The percentage of marks above 70% is {above / overall * 100}%");

            //3

            int n, choice, sum = 0;

            Console.WriteLine("Please give me a number.");
            choice = Convert.ToInt32(Console.ReadLine());

            for (n = 1; n <= choice; n += 2)
            {
                sum += n;
            }

            Console.WriteLine($"The sum of all the odd numbers between {choice} and 1 is {sum}");

            //4

            Console.WriteLine("Please enter your minimum number.");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your maximum number.");
            max = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 24; i++)
            {
                int randomInt = generate.Next((min + 1), max);
                Console.WriteLine(randomInt);
            }


                Console.ReadLine();







        }

    }
}