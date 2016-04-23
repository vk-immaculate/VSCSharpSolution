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
            string InputMessage;
            Console.WriteLine("Please enter your name ?");
            InputMessage = Console.ReadLine();
            Console.WriteLine("Are you {0}", InputMessage);
            Console.ReadLine();
        }
    }
}
