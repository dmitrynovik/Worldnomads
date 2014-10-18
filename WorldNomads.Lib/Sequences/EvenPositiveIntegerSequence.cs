using System;
using System.Linq;
using System.Collections.Generic;

namespace WorldNomads.Lib.Sequences
{
    public class EvenPositiveIntegerSequence : PositiveIntegerSequence
    {
        public EvenPositiveIntegerSequence(int upperBounds) : base(upperBounds) { }

        public override string DisplayName
        {
            get { return "Even positive whole numbers"; }
        }

        protected override IEnumerable<object> EnumerateUntil(int upperBound)
        {
            for (int i = 1; i <= _upperBound; ++i)
                if (i % 2 == 0)
                    yield return i;
        }
    }
}
