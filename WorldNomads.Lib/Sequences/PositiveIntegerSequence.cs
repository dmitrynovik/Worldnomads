using System;
using System.Collections.Generic;

namespace WorldNomads.Lib.Sequences
{
    public class PositiveIntegerSequence : PositiveSequence
    {
        public override string DisplayName
        {
            get { return @"Positive whole numbers."; }
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
