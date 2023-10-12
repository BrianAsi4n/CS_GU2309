using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TH01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nhập vào 1 số và kiểm tra số đó có phải là số chẵn không?
            //Xuất: yes hoặc no.

           
            int so=-1;
            int luot_dem = 3;
            nhap_du_lieu:
               Console.Write("nhap mot so: ");
            if (int.TryParse(Console.ReadLine(), out so))
            {
                if (so % 2 == 0)
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
                if(luot_dem == 0)
                {
                    Console.WriteLine("qua so lan thu");
                    goto nhiem_vu;
                }
                Console.WriteLine(" nhap lai so nguyen hop le");
                goto nhap_du_lieu;
            }
        nhiem_vu:
            Console.WriteLine("--------------");
        }
    }
}
