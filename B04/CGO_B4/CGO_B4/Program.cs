using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_B4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ho va ten: ");
            string fullName = Console.ReadLine();

           
            Console.WriteLine("nhap so:");
            int age = int.Parse(Console.ReadLine());

            float avg = float.Parse(Console.ReadLine());

            Console.WriteLine("Hello " + fullName);
            Console.WriteLine("Tuoi:" + age);
            Console.WriteLine()
        }
    }
}
