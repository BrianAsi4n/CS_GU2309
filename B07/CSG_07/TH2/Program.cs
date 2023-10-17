using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = -1;
            Console.WriteLine("Enter a number:");
            number = int.Parse(Console.ReadLine());
            if(number < 2)
            {
                Console.WriteLine($"{number} is not a prime");
            }else
            {
                int i = 2;
                bool check = true;
                while( i <= Math.Sqrt(number) )
                {
                    if(number % i == 0)
                    {
                        check = false;
                        break;
                    }
                    i++;

                }
                if (check)
                {
                    Console.WriteLine($"{number} is a prime");
                }
                else
                {
                    Console.WriteLine($"{number} is not a prime");
                }
            }
        }
    }
}
