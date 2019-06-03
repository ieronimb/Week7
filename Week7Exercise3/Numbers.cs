using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7Exercise3
{
    class Numbers
    {
        /* Write a method ReadNumber(int start, int end) that enters an integer number in a given range ( start, end ).
        If an invalid number or non-number text is entered, the method should throw an exception. Using this method write 
        a program that enters 10 numbers:	a1, a2, ..., a10, such that 1 < a1 < ... < a10 < 100
        Output
        Print 1 < a1 < ... < a10 < 100
        Or Exception if the above inequality is not true*/

        class ReadNumberMethod
        {
            static int ReadNumber(int start, int end, int i)
            {
                int number = int.Parse(Console.ReadLine());

                if ((number < start) || (number > end) || (number < i))
                {
                    throw new ArgumentOutOfRangeException();
                }
                return number;
            }

            static void Main(string[] args)
            {
                try
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.Write("Enter number {0} in the range [{1}...{2}] : ", i, 1, 10);
                        int number = ReadNumber(1, 100, i);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("The number is not integer!");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Null is not integer.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number is not in the range of integer.");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The number is not in the range.");
                }
                Console.ReadKey();
            }
        }
    }
}
