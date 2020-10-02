//Jack
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5___Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int age;
            Console.WriteLine("How old are you?");

            if (!Int32.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Error");
            }
            else
            {

                if (age > 18)
                {
                    Console.WriteLine("Adult");
                }

                else if (age <= 18 && age > 12)
                {
                    Console.WriteLine("Teenager");
                }

                else if (age <= 12 && age > 10)
                {
                    Console.WriteLine("Preeteen");
                }

                else if (age <= 10 && age > 5)
                {
                    Console.WriteLine("Child");
                }

                else if (age <= 5)
                {
                    Console.WriteLine("Toddler");
                }



            }
            //2
            Console.WriteLine("What category is the hurricane?");
            int strength;
            Int32.TryParse(Console.ReadLine(), out strength);

            switch (strength)
            {
                case 1:
                    Console.WriteLine("The hurricane reaches speed of 74-95 mph 64-82 kt 119-153 km/h.");
                    break;
                case 2:
                    Console.WriteLine("The hurricane reaches speed of 96-110 mph 83-95 kt 154-177 km/h.");
                    break;
                case 3:
                    Console.WriteLine("The hurricane reaches speed of 111-129 mph 96-112 kt 178-208 km/h.");
                    break;
                case 4:
                    Console.WriteLine("The hurricane reaches speed of 130-156 mph 113-136 kt 209-251 km/h.");
                    break;
                case 5:
                    Console.WriteLine("The hurricane reaches speed of 157 mph or higher 137 kt or higher 252 km / h or higher");
                    break;
                default:
                    Console.WriteLine("It is not strong enough to be considered a hurricane, or is not a class of hurricane that exists.");
                    break;
            }
            //3
            Random generator = new Random();

            int ranNum = generator.Next(2, 7);
            int chosenNum;
            Console.WriteLine($"The random number is {ranNum}, please enter a larger number.");
           
            if (!Int32.TryParse(Console.ReadLine(), out chosenNum )|| chosenNum < ranNum)
            {
                Console.WriteLine("Error");
            }

            else
            {
                if (chosenNum % ranNum == 0)
                {
                    Console.WriteLine("Divisible");
                }
                    
                else if (chosenNum % ranNum != 0)
                {
                    Console.WriteLine("Not Divisible");
                }




            }
                





            Console.ReadLine();
        }
    }
}
