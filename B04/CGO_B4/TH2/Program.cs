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
            Console.WriteLine("Enter width: ");
            float width = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            float height = float.Parse(Console.ReadLine());
             float area = width * height;
           
            Console.WriteLine($"{width} * {height} = {area}");
        }
    }
}
