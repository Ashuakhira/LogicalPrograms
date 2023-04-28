using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelandConsonant
{
    public class SwapNumber
    {
        public static void SwapingTheNumber()
        {
            Console.WriteLine("Please enter numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swaping a=" + a + "b=" + b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("After swaping a=" + a + "b=" + b);


        }
    }
}
