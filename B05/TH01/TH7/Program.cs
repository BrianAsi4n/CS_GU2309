using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nhập vào 2 số nguyên là tháng và năm. Xuất ra chính xác
            //số ngày trong tháng đó.Lưu ý kiểm tra năm nhuận cho tháng 2.
            Console.WriteLine("nhap vao thang bat ky;");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap vao nam bat ky:");
            int year = int.Parse(Console.ReadLine());
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                Console.WriteLine($"thang {month} co 31 ngay");
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                Console.WriteLine($"thang {month} co 30 ngay");
            }
            else if (month == 2)
            {
                if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0 )
                {
                    Console.WriteLine($"nam {year} la nam nhuan , nem thang {month} co 29 ngay");
                }
                else
                {
                  Console.WriteLine($"thang {month} co 28 ngay");
                }
            }
            else
            {
                Console.WriteLine("nhap so roi");
            }
                
        }
    }
}
