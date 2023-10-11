using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height, weight;

            Console.WriteLine("nhap height: ");
            if (TryReadInteger(out height) && IsInRange(height, 0, 999))
            {
                Console.WriteLine("Nhập cân ưeight: ");
                if (TryReadInteger(out weight) && IsInRange(weight, 0, 999))
                {
                    Console.WriteLine($"Chieu cao: {height} cm");
                    Console.WriteLine($"can nang: {weight} kg");
                }
                else
                {
                    Console.WriteLine("can nang ko hop le ");
                }
            }
            else
            {
                Console.WriteLine("Chieu cao ko hop le");
            }
        }

        static bool TryReadInteger(out int result)
        {
            return int.TryParse(Console.ReadLine(), out result);
        }

        static bool IsInRange(int value, int min, int max)
        {
            return value >= min && value <= max;
        }
    }
    
}
