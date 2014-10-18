using System;
using System.Collections.Generic;
using System.Linq;

namespace WorldNomads.Lib.Sequences
{
    public class OddPositiveIntegerSequence : PositiveIntegerSequence
    {
        public OddPositiveIntegerSequence(uint upperBounds) : base(upperBounds) { }

        public override string DisplayName
        {
            get { return "Odd positive whole numbers"; }
        }

        protected override IEnumerable<object> EnumerateUntil(uint upperBound)
        {
            for (uint i = 1; i <= _upperBound; ++i)
                if (i % 2 == 1)
                    yield return i;
        }
    }
}
