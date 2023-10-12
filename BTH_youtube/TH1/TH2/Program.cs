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
            int n = -1;
            int luotdem = 3;
        nhap_du_lieu:

            Console.WriteLine("Nhap so n:");

            if (int.TryParse(Console.ReadLine(), out n)){ 
                if(n % 2 == 0)
                {
                    Console.WriteLine($"{n} la so chan");
                }
                else 
                {
                    Console.WriteLine($"{n} la so le");
                }
                if(n % 3 == 0)
                {
                    Console.WriteLine($"{n} chia het cho 3");
                }
                else
                {
                    Console.WriteLine($"{n} ko chia het cho 3");
                }
            }
            else
            {
                luotdem--;
                if(luotdem == 0)
                {
                    Console.WriteLine("qua so lan nhap");
                    goto nhiemvu;
                }
                Console.WriteLine("nhap lai");
                goto nhap_du_lieu;
            }
        nhiemvu:
            Console.WriteLine("----------");
        }
    }
}
