//Jack Carlson
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("J J J J J   C C C  "); 
            Console.WriteLine("    J     C       C");
            Console.WriteLine("    J     C        ");
            Console.WriteLine("    J     C        ");
            Console.WriteLine("J   J     C        ");
            Console.WriteLine("J   J     C       C");
            Console.WriteLine("  J         C C C  ");
            

            //2
            string firstName = "Jack";
            string favMovie = "The Matrix";
            
            Console.WriteLine($"Hello {firstName.ToLower()}, nice to meet you! My favourite movie is {favMovie.ToLower()}.");

            favMovie = favMovie.ToUpper();
            Console.WriteLine(favMovie);

            Console.WriteLine(favMovie.Contains("THE"));

            favMovie = favMovie.Replace("A", "@");
            favMovie = favMovie.Replace("E", "3");
            Console.WriteLine(favMovie);


            Console.ReadLine();
        }
    }
}
