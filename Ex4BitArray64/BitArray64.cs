using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4BitArray64
{
        /*4.  64 Bit array
        Define a class BitArray64 to hold 64 bit values inside an ulong value.
        Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=
        BitArray64 simpleArray = new BitArray64();
        simpleArray.Add(1);
        simpleArray.Add(2);
        simpleArray.Add(3);
        simpleArray.Add(3);
        Console.WriteLine(simpleArray[2] == simpleArray[3]);
        foreach (var value in simpleArray)
        {
        Console.WriteLine(value);
        }*/

    class BitArray64 : IEnumerable<int>
    {
        //Camp constant
        private const byte bits = 64;
        //Camp
        private ulong number;

        //Cosntructor
        public BitArray64(ulong number)
        {
            this.number = number;
        }
        //Proprietati
        public ulong Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
        // [] https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/using-indexers
        public byte this[int index] 
        {
            get
            {
                if (index < 0 || index >= bits)
                {
                    throw new ArgumentOutOfRangeException("The index is out of range");
                }
               return (byte)(this.Number);
            }
            set
            {
                if (index < 0 || index >= bits)
                {
                    throw new ArgumentOutOfRangeException("The index is out of range");
                }                          
            }
        }
        //IEnumerable<int>
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < bits; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        //Operator ==
        public static bool operator == (BitArray64 firstNumber, BitArray64 secondNumber)
        {
            return BitArray64.Equals(firstNumber, secondNumber);
        }
        //Operator !=
        public static bool operator !=(BitArray64 firstNumber, BitArray64 secondNumber)
        {
            return !(BitArray64.Equals(firstNumber, secondNumber));
        }
        //Get Hascode
        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this.Number.GetHashCode(); //https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=netframework-4.8
        }

        //Equals(…)
        public override bool Equals(object param)
        {
            BitArray64 bitArray64 = param as BitArray64;
            return this.Number.Equals(bitArray64.Number);
        }
    }
}

