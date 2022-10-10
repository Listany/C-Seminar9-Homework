using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // программа выводит все натуральные числа от 1 до n. Рекурсия

            string PrintDigits (int a)
            {
                if (a == 1)
                {
                    return "1";
                }
                string result = a + PrintDigits(a - 1);
                return result;
            }

            int n = 5;

            Console.WriteLine(PrintDigits(n));

            Console.ReadLine();
                




        }
    }
}
