using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            while (i >= 0)
            {
                Console.WriteLine(i);
                i -= 1 ;
            }

            int selection;
            do
            {
                Console.WriteLine("Who is the better captain?");
                Console.WriteLine("1 - Captain Picard");
                Console.WriteLine("2 - Captain Kirk");
                selection = Convert.ToInt32(Console.ReadLine());
            } while (selection != 1);
            Console.WriteLine("Correct");


            Console.ReadLine();
            }
    }
}
