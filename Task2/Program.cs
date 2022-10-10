using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задать значения M и N, программа выводит сумму натуральных чисел в промежутке

            int GetSum(int a, int b)
            {
                if ((b - a) < 1 )
                    return a;
                
                int sum = a + b;
                sum = sum + GetSum(a +1, b -1);
                return sum;

            }

            int n = 5;
            int m = 7;

            Console.WriteLine(GetSum(n, m));

            Console.ReadLine();

        }
    }
}
