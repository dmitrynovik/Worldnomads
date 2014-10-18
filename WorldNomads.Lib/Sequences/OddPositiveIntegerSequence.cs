using System;
using System.Collections.Generic;
using System.Linq;

namespace WorldNomads.Lib.Sequences
{
    public class OddPositiveIntegerSequence : PositiveIntegerSequence
    {
        public OddPositiveIntegerSequence(uint upperBound) : base(upperBound) {  }

        public override IEnumerable<uint> Enumerate()
        {
            foreach (var n in base.Enumerate())
                if (n % 2 == 1)
                    yield return n;
        }
    }
}
