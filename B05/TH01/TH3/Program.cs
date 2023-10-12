using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nhập vào 3 sô nguyên a,b,c.Tìm sô lớn nhất và sô nhỏ nhất trong 3 số đó.
            Console.WriteLine("nhap so a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so c: ");
            int c = int.Parse(Console.ReadLine());

            int max = Math.Max(Math.Max(a, b), c);
            int min = Math.Min(Math.Min(a, b), c);
            Console.WriteLine($"so lon nhat la {max}");
            Console.WriteLine($"so be nhat la {min}");
        }
    }
}
