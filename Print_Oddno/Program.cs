using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Oddno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i >= 50; i--)
            {
                if (i % 2 != 0)
                {

                    Console.WriteLine(i);
                }
            }

        }
    }
}
