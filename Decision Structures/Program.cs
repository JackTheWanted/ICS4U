//Jack
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Structures
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random generator = new Random();
            int grade = 70;
            int num = generator.Next(0, 20);
            Console.WriteLine(num);
            if (grade >= 80)
            {
                Console.WriteLine("Good Job");
            }
            else if (grade < 80)
            {
                Console.WriteLine("Study Harder Idiot!");
            }

            if (num >= 5 && num <= 15)
            {
                Console.WriteLine("Between");
            }
            else if (num < 5 || num > 15);
            {
                Console.WriteLine("Not Between");
            }
            Console.ReadLine();

        }
    }
}
