using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelandConsonant
{
    public class EvenOdd
    {
        public static void CheckEvenOdd()
        {
            int i;
            Console.WriteLine("Please enter the number ");
            i = int.Parse(Console.ReadLine());
            if(i % 2 == 0)
            {
                Console.WriteLine("Entered Number is Even Number ");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Entered number is Odd NUmber ");
                    Console.ReadLine();
            }
        }
    }
}
