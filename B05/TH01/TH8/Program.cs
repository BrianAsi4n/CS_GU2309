using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nhập vào 1 số gồm 4 chữ số abcd, yêu cầu tính tổng của:
            //ad + bc = ??.Ví dụ: 1234 thì kết quả 14 + 23 = 37

            Console.Write("Nhập một số gồm 4 chữ số (abcd): ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 1000 && number <= 9999)
            {
                int a = number / 1000;           // Lấy chữ số hàng nghìn (a)
                int b = (number / 100) % 10;      // Lấy chữ số hàng trăm (b)
                int c = (number / 10) % 10;       // Lấy chữ số hàng chục (c)
                int d = number % 10;              // Lấy chữ số hàng đơn vị (d)

                int result = (a * 10 + d) + (b * 10 + c);
                Console.WriteLine($"Tổng {a}{d} + {b}{c} = {result} " );
            }
            else
            {
                Console.WriteLine("Số không hợp lệ. Vui lòng nhập một số gồm 4 chữ số.");
            }
        }
    }
}
