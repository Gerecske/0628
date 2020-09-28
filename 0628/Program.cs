using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0628
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("I have " + rnd.Next(1, 21) + " aple pie");
            Console.ReadKey();
        }
    }
}
