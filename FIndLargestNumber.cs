using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelandConsonant
{
    public class FIndLargestNumber
    {
        public static void LargestNumber()
        {
            int num1, num2, num3;
            Console.WriteLine("Find the largest of three numbers");
            Console.WriteLine("Inpuit the 1st number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the 2nd number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the 3rd number");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("the 1st number is the greatest among three");
                }
                else
                {
                    Console.WriteLine("the 3rd number is thegreatest among three");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("the 2nd number is the greatest among three");
            }
            else
            {
                Console.WriteLine("the 3rd number is the greatest among three");
            }
                
            
        }
    }
}
