using System;
using System.Collections.Generic;

namespace WorldNomads.Lib.Sequences
{
    public class PositiveIntegerSequence : PositiveSequence<uint>
    {
        public override string DisplayName
        {
            get { return @"Positive whole integers."; }
        }

        public PositiveIntegerSequence(uint upperBound) : base(upperBound)
        {
        }

        protected override IEnumerable<object> EnumerateUntil(uint bounds)
        {
            for (uint i = 1; i <= _upperBound; ++i)
                yield return i;            
        }
    }
}
