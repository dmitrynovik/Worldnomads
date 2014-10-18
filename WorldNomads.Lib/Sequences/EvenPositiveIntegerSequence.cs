using System;
using System.Collections.Generic;

namespace WorldNomads.Lib.Sequences
{
    public class EvenPositiveIntegerSequence : PositiveIntegerSequence
    {
        public override string DisplayName
        {
            get { return "Even positive whole numbers"; }
        }

        public override IEnumerable<uint> EnumerateUntil(uint upperBound)
        {
            Validate(upperBound);

            foreach (var n in base.EnumerateUntil(upperBound))
                if (n % 2 == 0)
                    yield return n;
        }
    }
}
