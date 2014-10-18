using System;
using System.Collections.Generic;

namespace WorldNomads.Lib.Sequences
{
    public class EvenPositiveIntegerSequence : PositiveIntegerSequence
    {
        public EvenPositiveIntegerSequence(uint upperBound) : base(upperBound) { }

        public override IEnumerable<uint> Enumerate()
        {
            foreach (var n in base.Enumerate())
                if (n % 2 == 0)
                    yield return n;
        }
    }
}
