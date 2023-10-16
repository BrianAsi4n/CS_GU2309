using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TH1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            while(choice!=0)
            {
                Console.WriteLine("MENU");
                Console.WriteLine(".1: Viết chương trình in ra nội dung của một" +
                    " chuỗi kí tự nào đó nhập vào từ bàn phím. Ví dụ: “I’m Iron Man”.");
                Console.WriteLine(".2: Nhập vào một số nguyên n, hãy cho biết số đó chẵn hay lẻ, " +
                    "chia hết cho 3 không, in kết quả kiểm tra ra màn hình. Mỗi kết luận trên một dòng");
                Console.WriteLine(".3: Nhập vào hai số nguyên a, b. In ra màn hình kết quả các phép tính" +
                    " +, -, *, /,%. Lưu ý khi xử lý các phép chia sẽ cần ép kiểu, kiểm tra mẫu khác 0." +
                    " Xuất kết quả ra màn hình trên từng dòng.");
                Console.WriteLine(".4: Nhập vào hai số nguyên a, b. So sánh xem số nào lớn hơn, số nào nhỏ" +
                    " hơn hay hai số bằng nhau. In kết quả ra màn hình.");
                Console.WriteLine("5: Hãy nhập 4 số nguyên a, b, c, d. Tìm giá trị nhỏ nhất trong đó và in " +
                    "ra màn hình. Trong trường hợp 4 số bằng nhau thì in ra: không có số nhỏ nhất");
                Console.WriteLine("6: Hãy nhập 4 số nguyên bất kì sau đó lưu vào 4 biến a, b, c, d. Tìm giá trị lớn thứ hai trong số chúng, in kết quả ra màn hình. Trường hợp tất cả cùng giá trị thì không có số lớn thứ hai.");
                Console.WriteLine(".7: Viết chương trình nhập vào hai cạnh của hình chữ nhật và tính chu vi và diện tích của hình chữ nhật đó. Hiển thị kết quả lên màn hình.");
                Console.WriteLine(".8: Viết chương trình nhập bán kính của hình tròn và tính chu vi, diện tích hình tròn đó. ");
                Console.WriteLine("9: Giải và biện luận phương trình bậc nhất a𝑥 + b = �");
                Console.WriteLine("10: Giải và biện luận phương trình bậc 2 a𝑥2 + b𝑥1 + c = 0");
                Console.WriteLine(".11: Nhập vào ba số thực a, b, c đều dương. Kiểm tra xem đó có phải là ba cạnhcủa một tam giác hay không. Nếu có hãy chỉ ra đó là loại tam giác nào?");
                Console.WriteLine("chon chuc nang");
                Console.WriteLine("             ");
                    Console.WriteLine("          ");
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
                        Main1();
                        break;
                    case 8:
                        Main1();
                        break;
                    case 9:
                        Main1();
                        break;
                    case 10:
                        Main1();
                        break;
                    case 11:
                        Main1();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("chua chon");
                        break;
                }
                
            }

        }
        
        private static void Main1()
        {
#region .1: Viết chương trình in ra nội dung của một chuỗi kí tự nào đó nhập vào từ bàn phím. “I’m Iron Man”.
            Console.WriteLine("Nhap vao noi dung:");
            string a = Console.ReadLine();
            Console.WriteLine(a);
            #endregion 
        }
        private static void Main2()
        {
            #region Nhập vào một số nguyên n, hãy cho biết số đó chẵn hay lẻ, chia hết cho 3 không, in kết quả kiểm tra ra màn hình
            int n = -1;
            Console.WriteLine("nhap vao 1 so:");
            if(int.TryParse(Console.ReadLine(),out n)){
                if(n %2 == 0)
                {
                    Console.WriteLine($"{n} la chan");
                }
                else
                {
                    Console.WriteLine($"{n} la le");
                }
                if(n %3 == 0)
                {
                    Console.WriteLine($"{n} chia het cho 3");
                }
                else
                {
                    Console.WriteLine($"{n} ko chia het cho 3");
                }
            }

            #endregion
        }
        private static void Main3()
        {
            #region Nhập vào hai số nguyên a, b. In ra màn hình kết quả các phép tính +, -, *, /,%.Lưu ý khi xử lý các phép chia sẽ cần ép kiểu, kiểm tra mẫu khác 0
            Console.WriteLine("nhap a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap b:");
            int b = int.Parse(Console.ReadLine());

            int tong = a + b;
            int hieu = a - b;
            int tich = a * b;
            Console.WriteLine($"{a}+{b}={tong}");
            Console.WriteLine($"{a}*{b}={tich}");
            Console.WriteLine($"{a}-{b}={hieu}");
            if (b != 0)
            {
                float thuong = (float)a / b;
                int du = a % b;
                Console.WriteLine($"{a}/{b}={thuong}");
                Console.WriteLine($"{a}%{b}={du}");
            }
            else
            {
                Console.WriteLine("chon sai");
            }
            #endregion
        }
        private static void Main4()
        {
            #region Nhập vào hai số nguyên a, b. So sánh xem số nào lớn hơn, số nào nhỏ hơnhay hai số bằng nhau
            Console.WriteLine("nhap a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b:");
            int b = int.Parse(Console.ReadLine());
            if (a < b)
            {
                Console.WriteLine($"{a}<{b}");
            }else if (a == b)
            {
                Console.WriteLine($"{a}={b}");
            }
            else
            {
                Console.WriteLine($"{a}>{b}");
            }

            #endregion
        }
        private static void Main5()
        {
            #region Hãy nhập 4 số nguyên a, b, c, d. Tìm giá trị nhỏ nhất trong đó và in ra màn hình.Trong trường hợp 4 số bằng nhau thì in ra: không có số nhỏ nhất
            Console.WriteLine("nhap a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap c:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap d");
            int d  = int.Parse(Console.ReadLine());

            
            if(a == b && b == c && c == d )
            {
                Console.WriteLine("ko co so nho nhat");
            }
            else
            {
               int min = Math.Min(Math.Min(Math.Min(a, b), c), d);
                Console.WriteLine($"min la {min}");
            }

            #endregion
        }
        private static void Main6()
        {

        }
    }
}
