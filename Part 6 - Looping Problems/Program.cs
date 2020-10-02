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

            do
            {
                Console.WriteLine("What is the minimum value");

            } while (!Int32.TryParse(Console.ReadLine(), out min));
            do
            {
                Console.WriteLine("What is the maximum value");

            } while (!Int32.TryParse(Console.ReadLine(), out max));
            if ((max - 1) <= min)
            {
                do
                {
                    Console.WriteLine("Please enter a bigger maximum");

                } while (!Int32.TryParse(Console.ReadLine(), out max) || (max - 1) <= min);

            }
            if (max > (min + 1))
            {
                do
                {
                    Console.WriteLine("What is a number between the max and min?");

                } while (!Int32.TryParse(Console.ReadLine(), out range) || range > max || range < min);
            }
                
            Console.WriteLine("That number is within range.");


            //2

            int selection = 0;
            double above = 0;
            double overall = 0;
            do
            {
                Console.WriteLine("Please enter all of your marks (in %), we will determine the percentage of them above 70%");
                Console.WriteLine("Enter 999 to submit.");

                if (selection >= 70 && selection != 999)
                {
                    above += 1;
                    overall += 1;

                }

                else if (selection < 70)
                {
                    overall += 1;
                }
                
                if (overall == 0)
                {
                    overall += 1;
                }

            } while ((!Int32.TryParse(Console.ReadLine(), out selection)) || selection != 999 );


            Console.WriteLine($"The percentage of marks above 70% is {(above / overall) * 100}%");

            //3

            int n, choice, sum = 0;
            do
            {
                Console.WriteLine("Please give me a number.");
            } while (!Int32.TryParse(Console.ReadLine(), out choice));

            for (n = 1; n <= choice; n += 2)
            {
                sum += n;
            }

            Console.WriteLine($"The sum of all the odd numbers between {choice} and 1 is {sum}");

            //4

            do
            {
                Console.WriteLine("Please enter your minimum number.");
            } while (!Int32.TryParse(Console.ReadLine(), out min));

            do
            {
                Console.WriteLine("Please enter your maximum number that is larger than the minimum.");
            } while (!Int32.TryParse(Console.ReadLine(), out max) || max <= min);

            for (int i = 0; i <= 24; i++)
            {
                int randomInt = generate.Next(min, (max + 1));
                Console.WriteLine(randomInt);
            }


            Console.ReadLine();


            




        }

    }
}