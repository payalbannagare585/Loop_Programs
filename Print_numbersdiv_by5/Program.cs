using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//print numbers from 1- 100 which are divisible by 5


namespace Print_numbersdiv_by5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Divided by 5:");
            for(int i=1;i<=100;i++)
            {
                if ( i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
