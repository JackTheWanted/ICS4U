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
            double one;
            Console.WriteLine("Give me a number");
            one = Convert.ToDouble(Console.ReadLine());

            double two;
            Console.WriteLine("Give me another number");
            two = Convert.ToDouble(Console.ReadLine());

            double three;
            Console.WriteLine("Give me one more number");
            three = Convert.ToDouble(Console.ReadLine());
            double sum = one + two + three;
            sum = Math.Round(sum, 2);

            Console.WriteLine($"The sum of your 3 numbers is: {sum}");

            //3
            double distance1;
            Console.WriteLine("Please enter the first distance in km");
            distance1 = Convert.ToDouble(Console.ReadLine());
            

            double distance2;
            Console.WriteLine("Enter the second distance in km");
            distance2 = Convert.ToDouble(Console.ReadLine());
            

            double distance3;
            Console.WriteLine("Enter the third distance in km");
            distance3 = Convert.ToDouble(Console.ReadLine());

            double distanceAv = (distance1 + distance2 + distance3)/3;
            distanceAv = Math.Round(distanceAv, 2);
            Console.WriteLine($"The average distance is {distanceAv}km");

            //4
            double length;
            Console.WriteLine("Please enter the length in cm");
            length = Convert.ToDouble(Console.ReadLine());
            Math.Pow(length, 2);

            double height;
            Console.WriteLine("Please enter the height in cm");
            height = Convert.ToDouble(Console.ReadLine());
            Math.Pow(height, 2);

            double hypotenuse = Math.Sqrt(height + length);
            hypotenuse = Math.Round(hypotenuse, 2);
            Console.WriteLine($"The hypotenuse is {hypotenuse}cm");

            Console.ReadLine();
        }
    }
}
