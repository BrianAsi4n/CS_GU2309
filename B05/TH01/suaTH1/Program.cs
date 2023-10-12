using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suaTH1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap vao so: ");
            int so = int.Parse(Console.ReadLine());
            if(so % 2 == 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
