//Jack Carlson
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3a_Console_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //1
            string name;
            Console.WriteLine("Whats your name?");
            name = Console.ReadLine();


            int age;
            Console.WriteLine("How old are you?");
            age = Convert.ToInt32(Console.ReadLine());
            //age = Convert.ToInt32();

            int year;
            Console.WriteLine("What year is it?");
            year = Convert.ToInt32(Console.ReadLine());
            year = year - age;

            Console.WriteLine($"Your name is {name} and you were born in {year}.");
            Console.ReadLine();

            //2
            int one;
            Console.WriteLine("Give me a number");
            one = Convert.ToInt32(Console.ReadLine());

            int two;
            Console.WriteLine("Give me another number");
            two = Convert.ToInt32(Console.ReadLine());

            int three;
            Console.WriteLine("Give me one more number");
            three = Convert.ToInt32(Console.ReadLine());
            int sum = one + two + three;

            Console.WriteLine($"The sum of your 3 numbers is: {sum}");

            //3
            double distance1;
            Console.WriteLine("Please enter the first distance in km");
            distance1 = Convert.ToDouble(Console.ReadLine());
            Math.Round(distance1, 2);

            double distance2;
            Console.WriteLine("Enter the second distance in km");
            distance2 = Convert.ToDouble(Console.ReadLine());
            Math.Round(distance2, 2);

            double distance3;
            Console.WriteLine("Enter the third distance in km");
            distance3 = Convert.ToDouble(Console.ReadLine());
            Math.Round(distance3, 2);

            Console.WriteLine($"The average distance is {(distance1 + distance2 + distance3)/3}km");

            //4
            double length;
            Console.WriteLine("Please enter the length in cm");
            length = Convert.ToDouble(Console.ReadLine());
            Math.Round()

            Console.ReadLine();
        }
    }
}
