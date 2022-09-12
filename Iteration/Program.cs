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
            /*
            // repeat 8 times telling how many lines it takes up
            int num = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int a = 0; a < i + 1; a++)
                {
                    Console.WriteLine($"This takes up {i + 1} lines");
                }
                Console.ReadLine();
            }

            // repeat until best number is 8
            while (num != 8)
            {
                Console.WriteLine("What is the best number?");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Well done, 8 is indeed the best number");
            */

            // repeats from 1 to 50
            for(int i = 1; i <= 50; i++)
            {
                // find out if the number is odd or even
                string numType = "";
                if (i % 2 == 0) {numType = "Even";}
                else {numType = "Odd";}

                // find out if the number is a multiple of 3
                bool threeMult = false;
                if (i % 3 == 0) {threeMult = true;}

                if (threeMult) {Console.WriteLine($"{i} is {numType} and a multiple of 3");}
                else {Console.WriteLine($"{i} is {numType}");}
            }

            Console.ReadLine();
        }
    }
}
