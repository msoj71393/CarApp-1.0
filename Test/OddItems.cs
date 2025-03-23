using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test
{
    internal class OddItems
    {


        public static void isPalindrome()
        {
            Engine engine = new Engine();
            double origionalNumber, tempNumber, remainder, reverseNumber = 0;

            Console.WriteLine("\n");
            origionalNumber = engine.mileage;
            Console.WriteLine("\n");

            tempNumber = origionalNumber;

            while (origionalNumber > 0)
            {
                remainder = origionalNumber % 10;
                Console.WriteLine("Remainder = " + remainder);
                reverseNumber = reverseNumber * 10 + remainder;
                Console.WriteLine("Reverse number = " + reverseNumber);
                origionalNumber = origionalNumber / 10;
                Console.WriteLine("Origional number = " + origionalNumber);
                Console.WriteLine("\n");
            }

            Console.WriteLine("Origional Number : {0}", tempNumber);
            Console.WriteLine("Reverse number : {0}", reverseNumber);

            Console.WriteLine("=========================");
            if (tempNumber == reverseNumber)
            {
                Console.WriteLine("Milage is a palindrome");
            }
            else
            {
                Console.WriteLine("Milage is not a palindrom");
            }

            Console.WriteLine("\n\n");
        }
    }
}
