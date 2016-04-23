using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSCSharpSolution
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your name ?");

            string InputMessage = Console.ReadLine();

            if (InputMessage == "")
            {
                Console.WriteLine("You should be an idiot.");
            } else
            {
                Console.WriteLine("Are you really {0}", InputMessage);
            }
            
            Console.ReadLine();
        }
    }
}
