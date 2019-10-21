using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VezbanjeGita
{
    class Program
    {
        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("SmartInIt");
            int a = getRandom();
        }

        private static int getRandom()
        {
            return rnd.Next(1, 150);
        }
    }
}
