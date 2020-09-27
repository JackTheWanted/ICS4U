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
            ////////////////////////////////////////////////////////////////////////////////

            //2

            int selection;
            int above = 0;
            int overall = 0;
            do
            {
                Console.WriteLine("What is the mark in %");
                Console.WriteLine("Enter 000 to submit.");
                if (!Int32.TryParse(Console.ReadLine(), out selection))
                {
                    Console.WriteLine("Error");
                    System.Environment.Exit(0);

                }
                else
                       if (selection >= 70)
                {
                    above += 1;
                    overall += 1;
                }

                else if (selection < 70)
                {
                    overall += 1;
                }


                else if (selection == 000)
                {
                    Console.WriteLine($"The percentage of marks above 70% is {above / overall}%");
                }



                Console.ReadLine();






            }

        }
}
