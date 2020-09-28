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
            for (int i = 0; i < rnd.Next(1, 11); i++)
            {
                // Semmi
                Console.WriteLine("I have " + rnd.Next(1, 21) + " aple pie");
            }
            Console.ReadKey();
        }
    }
}
