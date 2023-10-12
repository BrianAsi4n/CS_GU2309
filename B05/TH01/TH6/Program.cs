using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nhập vào 1 số nguyên là tháng. Xuất ra số ngày trong
            //tháng đó. Lưu ý: tháng 2 mặc định lấy 28 ngày.

            Console.WriteLine("nhap vao thang bat ky;");
            int month = int.Parse(Console.ReadLine());
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                Console.WriteLine($"thang {month} co 31 ngay");
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                Console.WriteLine($"thang {month} co 30 ngay");
            }
            else
                Console.WriteLine($"thang {month} co 28 ngay");
        }
    }
}
