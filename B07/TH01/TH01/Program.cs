using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1.Nhập số nguyên A và kiểm tra xem A có phải là số nguyên\r\ntố hay không?");
                Console.WriteLine("2.In ra tất cả số chẵn trong khoảng (M,N). Với N, M nhập từ\r\nbàn phím.");
                Console.WriteLine("3.Nhập vào 1 số nguyên và xuất là Yes nếu nó là số hoàn\r\nhảo, ngược lại xuất No. Gợi ý: số hoàn hảo là số mà tổng\r\nước số của nó (không tính nó) bằng chính nó.");
                Console.WriteLine("4.Nhập vào 2 số nguyên a và b. Yêu cầu tìm UCLN của 2 số\r\nđó.");
                Console.WriteLine("5.Nhập vào 1 số nguyên n, xuất ra n!");
                Console.WriteLine("6.Nhập vào số i, yêu cầu xuất ra bảng cửu chương thứ i");
                Console.WriteLine("7.In ra bảng cửu chương từ 2 tới 10");
                Console.WriteLine("8.Nhập vào 1 số nguyên n. Xuất ra kết quả phép tính theo\r\ncông thức sau kết quả lấy 3 chữ số thập phân:\r\n1+1/23+1/33+...+1/n3");
                Console.WriteLine("Nhập vào 2 số nguyên dương N,M (N > M). Yêu cầu kiểm\r\ntra tích các chữ số của N có bằng tổng các ước của M hay\r\nkhông? Nếu có xuất YES ngược lại xuất NO. Ví dụ:\r\n• Nhập N=23, M=6 => NO\r\n• Nhập N=34, M=6 => YES");
                Console.WriteLine("[BOBA] Nhập vào 3 số nguyên dương N,M,K. Kiểm tra tổng\r\ncác chữ số của N cộng với chữ số đầu tiên của M có bằng K\r\nhay không? Nếu có xuất Yes ngược lại xuất No.");
                Console.WriteLine("0.exit");
                Console.WriteLine("   ");
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("                   ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Main1();
                        break;
                    case 2:
                        Main2();
                        break;
                    case 3:
                        Main3();
                        break;
                    case 4:
                        Main4();
                        break;
                    case 5:
                        Main5();
                        break;
                    case 6:
                        Main6();
                        break;
                    case 7:
                        Main7();
                        break;
                    case 8:
                        Main8();
                        break;
                    case 9:
                        Main9();
                        break;
                    case 10:
                        Main10();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
        private static void Main1()
        {
            #region Nhập số nguyên A và kiểm tra xem A có phải là số nguyên tố hay không ?
            Console.WriteLine("Enter a:");
            int a = int.Parse(Console.ReadLine());
            if (a < 2)
            {
                Console.WriteLine($"{a} ko  so nguyen to");
            }
            else
            {
                int i = 2;
                bool check = true;
                while (i <= Math.Sqrt(a))
                {
                    if (a % i == 0)
                    {
                        check = false;
                        break;
                    }
                    i++;
                }
                if (check)
                {
                    Console.WriteLine($"{a} la so nguyen to");
                }
                else
                {
                    Console.WriteLine($"{a} ko la so nguyen to");
                }
            }

            #endregion
        }
        private static void Main2()
        {
            #region In ra tất cả số chẵn trong khoảng (M,N). Với N, M nhập từ bàn phím.
            Console.WriteLine("nhap m:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap n:");
            int n = int.Parse(Console.ReadLine());
            if (m <= n)
            {
                Console.WriteLine($"cac so chan trong khoang{m} to {n} la:");
                for (int i = m; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                    else
                    {
                        Console.WriteLine("m nho hon hoac bang n");
                    }
                }
            }

            #endregion
        }
        private static void Main3()
        {
            #region Nhập vào 1 số nguyên và xuất là Yes nếu nó là số hoàn hảo, ngược lại xuất No
            int a, sum = 0;
            Console.WriteLine("nhap so nguyen A:");
            a = int.Parse(Console.ReadLine());
            //sử dụng vòng lặp for để lặp và tính tỏng các ước số của a
            //vì ước số trừ chính nó luôn luôn nhỏ hơn 1/2 số đó
            for (int i = 1; i <= a / 2; i++)
            {
                if (a % i == 0)
                {
                    sum += i;
                }
            }
            //sau khi tính tổng, ta so sánh với số a ban đầu
            //nếu bằng thi đó là số hoàn hảo 
            if (sum == 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

            #endregion
        }
        private static void Main4()
        {
            #region Nhập vào 2 số nguyên a và b. Yêu cầu tìm UCLN của 2 số đó.
            Console.WriteLine("nhap a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"ucln cua{a} va {b} la {UCLN(a, b)}");
        }
        static int UCLN(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
            #endregion
        }
        private static void Main5()
        {
            #region Nhập vào 1 số nguyên n, xuất ra n!
            int n, giaithua = 1;
            Console.WriteLine("nhap vao n:");
             n = int.Parse(Console.ReadLine());
            for(int i= 1; i <=n;i++)
            {
                giaithua *= i;
            }
            Console.WriteLine($"{n}!={giaithua}");
            #endregion
        }
        private static void Main6()
        {
            #region Nhập vào số i, yêu cầu xuất ra bảng cửu chương thứ i
            Console.WriteLine("Nhap i:");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine($"bang kieu chua thu{i}");
            
            for(int j =1; j <= 10; j++)
            {
                int ketqua = i * j;
                Console.WriteLine($"{i}x{j}={ketqua}");
            }
            #endregion
        }
        private static void Main7()
        {
            #region In ra bảng cửu chương từ 2 tới 10
            for(int i = 2; i <= 10; i++)
            {
                Console.WriteLine($"bang kieu chung thu {i}");
                for(int j = 1; j <=10; j++)
                {
                    int ketqua = i * j;
                    Console.WriteLine($"{i}x{j}={ketqua}");
                }
                Console.WriteLine();
            }

            #endregion
        }
        private static void Main8()
        {
            
        }
        private static void Main9()
        {

        }
        private static void Main10()
        {

        }
    }
}
