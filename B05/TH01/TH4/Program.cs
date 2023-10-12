using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TH4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nhập vào 2 số nguyên và 1 phép toán. Yêu cầu xuất ra kết quả
            //phép tính dựa trên phép toán(là 1 trong 4 phép toán: +,-,*,%)
            Console.WriteLine("nhap so nguyen thu nhat:");
            int so1 = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so nguyen thu hai:");
            int so2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap phep toan muon tinh:");
            char pt = char.Parse(Console.ReadLine());

            int ketqua = 0;
            switch (pt)
            {
                case '+':
                    ketqua = so1 + so2;
                    break;
                case '-':
                    ketqua = so1 - so2;
                    break;
                case '*':
                    ketqua = so1 * so2;
                    break;
                case '/':
                    if (so2 != 0)
                    {
                        ketqua = so1  / so2;
                    }
                    else
                    {
                        Console.WriteLine("ko thuc hien duoc");
                    }
                    break;
                case '%':
                    if (so2 != 0)
                    {
                        ketqua = so1 % so2;
                    }
                    else
                    {
                        Console.WriteLine("ko thuc hien duoc");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Phép toán không hợp lệ.");
                    return;
            }
            Console.WriteLine($"ket qua:{ketqua}");
        }
    }
}
