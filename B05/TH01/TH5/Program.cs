using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Giải phương trình Ax + B = 0. Với A, B là hệ sô được nhập vào từ bàn phím
                • Nếu phương trình vô nghiệm xuất kết quả: VN
                • Nếu phương trình VSN xuất ra : VSN
                • Nếu phương có nghiệm, xuất ra nghiệm (Lưu ý: lấy 2 chữ số thập phân)
             */

            Console.WriteLine("Nhap so a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap so b: ");
            double b = double.Parse(Console.ReadLine());

            if(a == 0)
            {
                if(b == 0)
                {
                    Console.WriteLine("phuong trinh VSn");
                }
                else
                {
                    Console.WriteLine("phuong trinh Vn");
                }
            }
            else
            {
                double ketqua = -b / a;
                Console.WriteLine($"Nhiem x = {ketqua.ToString("0.00")}");
            }
        }
    }
}
