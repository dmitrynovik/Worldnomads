using System;
using System.Collections.Generic;

namespace WorldNomads.Lib.Sequences
{
    public class PositiveIntegerSequence: PositiveSequence<uint>
    {
        public override IEnumerable<uint> EnumerateUntil(uint upperBound)
        {
            Validate(upperBound);

            for (uint i = 1; i <= upperBound; ++i)
                yield return i;
        }
    }
}
