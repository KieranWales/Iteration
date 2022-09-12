using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int a = 0; a < i + 1; a++)
                {
                    Console.WriteLine($"This takes up {i + 1} lines");
                }
                Console.ReadLine();
            }

            while (num != 8)
            {
                Console.WriteLine("What is the best number?");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Well done, 8 is indeed the best number");
            Console.ReadLine();
        }
    }
}
