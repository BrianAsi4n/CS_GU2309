using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSG_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            int sum = 0;
            while (i < n)
            {
                if(i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
