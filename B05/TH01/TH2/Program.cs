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
            //Nhập vào 1 số và kiểm tra số đó có phải là số chính phương
            //không? Xuất: yes hoặc no.
            double so = -1;
            int luot_dem = 3;
        nhap_du_lieu:
            Console.WriteLine("Nhap mot so: ");
            if (double.TryParse(Console.ReadLine(), out so) )
            {
                double ct = Math.Sqrt(so);
                if (ct == (int)ct)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }

            }
            else
            {
                luot_dem--;
                if (luot_dem == 0)
                {
                    Console.WriteLine("qua so lan thu");
                    goto nhiem_vu;
                }
                Console.WriteLine("nhap lai so hop le");
                    goto nhap_du_lieu;
            }
        nhiem_vu:
            Console.WriteLine("-----------");
        }
    }
}
