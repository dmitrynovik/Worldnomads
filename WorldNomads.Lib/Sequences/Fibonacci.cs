using System;
using System.Collections.Generic;

namespace WorldNomads.Lib.Sequences
{
    public class Fibonacci : PositiveIntegerSequence
    {
        public Fibonacci(uint upperBound) : base(upperBound) { }

        public override IEnumerable<uint> Enumerate()
        {
            uint current = 1;
            uint previous = 1;
            var result = new List<uint>() { 1 }; // Fib(0)

            while (current <= UpperBound)
            {
                result.Add(current);

                var tmp = current;
                current = current + previous;
                previous = tmp;
            }
            return result;
        }
    }
}
