using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tygia = 23000;
            Console.WriteLine("Enter usd:");
            double usd = double.Parse(Console.ReadLine());
            double vnd = usd * tygia;
            Console.WriteLine($"{vnd} vnd ");
        }
    }
}
