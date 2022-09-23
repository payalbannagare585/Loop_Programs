using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//accept a number from user & print the arithmetic table

namespace Print_ArithmeticTable
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter value:");
            num = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= 10; ++i)
            {
                Console.WriteLine(num + "*" + i + "=" + num * i + "\n");
            }

        }
    }
}
