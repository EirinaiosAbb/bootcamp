using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program

    {

        static void Main(string[] args)
        {
            Console.WriteLine("give your num");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("give your second num");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a < b)
            {
                Console.WriteLine(a <= b);

            }
            
        }
    }

}