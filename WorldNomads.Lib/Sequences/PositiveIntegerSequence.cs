using System;
using System.Collections.Generic;

namespace WorldNomads.Lib.Sequences
{
    public class PositiveIntegerSequence : PositiveSequence<int>
    {
        public override string DisplayName
        {
            get { return @"Positive whole integers."; }
        }

        public PositiveIntegerSequence(int upperBound) : base(upperBound)
        {
        }

        protected override IEnumerable<object> EnumerateUntil(int bounds)
        {
            for (int i = 1; i <= _upperBound; ++i)
                yield return i;            
        }
    }
}
