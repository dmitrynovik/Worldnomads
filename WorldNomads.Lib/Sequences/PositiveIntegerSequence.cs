using System;
using System.Collections.Generic;

namespace WorldNomads.Lib.Sequences
{
    public class PositiveIntegerSequence: PositiveSequence<uint>
    {
        public PositiveIntegerSequence(uint upperBound) : base(upperBound) { }

        public override IEnumerable<uint> Enumerate()
        {
            for (uint i = 1; i <= UpperBound; ++i)
                yield return i;
        }
    }
}
