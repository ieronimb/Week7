using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4BitArray64
{
    class BitArrays
    {
        static void Main(string[] args)
        {
            BitArray64 arrayOne = new BitArray64(1157u);           
            BitArray64 arrayTwo = new BitArray64(15u);            

            Console.WriteLine("\nNumber one == number two?");
            Console.WriteLine(arrayOne == arrayTwo);

            Console.WriteLine("\nNumber one !- number two?");
            Console.WriteLine(arrayOne != arrayTwo);

            Console.WriteLine("\nNumber one is equal to itself?");
            Console.WriteLine(arrayOne.Equals(arrayOne));           
           
            Console.ReadKey();
        }
    }
}
