using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayOfWeek = 6;

            if(dayOfWeek <= 5)
            {
                Console.WriteLine("I have to go to work!");
            }
            else
            {
                Console.WriteLine("weekend");
            }
        }
    }
}
