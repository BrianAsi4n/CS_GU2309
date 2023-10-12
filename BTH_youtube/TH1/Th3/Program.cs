using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so b");
            int b = int.Parse(Console.ReadLine());

            int tong = a + b;
            int hieu = a - b;
            int tich = a * b;
            Console.WriteLine($"tong {a} + {b} = {tong}");
            Console.WriteLine($"hieu {a} - {b} = {hieu}");
            Console.WriteLine($"tich {a} * {b} = {tich}");
            if (b != 0)
            {
                float thuong = (float)a / b;
                int du = a % b;
                Console.WriteLine($"thuong {a} / {b} = {thuong}");
                Console.WriteLine($"du {a} % {b} = {du}");
            }
            else
            {
                Console.WriteLine("ko thuc hien dc ");
            }
        }
    }
}
