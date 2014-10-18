using System;
using System.Linq;
using System.Collections.Generic;

namespace WorldNomads.Lib.Sequences
{
    public class EvenPositiveIntegerSequence : PositiveIntegerSequence
    {
        public EvenPositiveIntegerSequence(uint upperBounds) : base(upperBounds) { }

        public override string DisplayName
        {
            get { return "Even positive whole numbers"; }
        }

        protected override IEnumerable<object> EnumerateUntil(uint upperBound)
        {
            for (uint i = 1; i <= _upperBound; ++i)
                if (i % 2 == 0)
                    yield return i;
        }
    }
}
