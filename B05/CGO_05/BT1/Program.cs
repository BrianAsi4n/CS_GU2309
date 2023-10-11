using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập số cần đọc (0-999): ");
            if (int.TryParse(Console.ReadLine(), out int number) && number >= 0 && number <= 999)
            {
                string result = "";

                if (number < 10)
                {
                    result = ReadOnes(number);
                }
                else if (number < 20)
                {
                    result = ReadTeens(number);
                }
                else if (number < 100)
                {
                    int tens = number / 10;
                    int ones = number % 10;
                    result = ReadTens(tens) + " " + ReadOnes(ones);
                }
                else if (number <= 999)
                {
                    int hundreds = number / 100;
                    int remainder = number % 100;

                    result = ReadOnes(hundreds) + " hundred";

                    if (remainder > 0)
                    {
                        result += " and ";
                        if (remainder < 10)
                        {
                            result += ReadOnes(remainder);
                        }
                        else if (remainder < 20)
                        {
                            result += ReadTeens(remainder);
                        }
                        else
                        {
                            int tens = remainder / 10;
                            int ones = remainder % 10;
                            result += ReadTens(tens) + " " + ReadOnes(ones);
                        }
                    }
                }

                Console.WriteLine("Số bạn đã nhập đọc là: " + result);
            }
            else
            {
                Console.WriteLine("Số không hợp lệ. Hãy nhập số từ 0 đến 999.");
            }
        }

        static string ReadOnes(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "";
            }
        }

        static string ReadTeens(int number)
        {
            switch (number)
            {
                case 10: return "ten";
                case 11: return "eleven";
                case 12: return "twelve";
                case 13: return "thirteen";
                case 14: return "fourteen";
                case 15: return "fifteen";
                case 16: return "sixteen";
                case 17: return "seventeen";
                case 18: return "eighteen";
                case 19: return "nineteen";
                default: return "";
            }
        }

        static string ReadTens(int number)
        {
            switch (number)
            {
                case 2: return "twenty";
                case 3: return "thirty";
                case 4: return "forty";
                case 5: return "fifty";
                case 6: return "sixty";
                case 7: return "seventy";
                case 8: return "eighty";
                case 9: return "ninety";
                default: return "";
            }
        }
    }
    
}
