using System;
using System.Collections.Generic;
using System.Linq;

namespace WorldNomads.Lib.Sequences
{
    public class OddPositiveIntegerSequence : PositiveIntegerSequence
    {
        public override string DisplayName
        {
            get { return "Odd positive whole numbers"; }
        }

        public override IEnumerable<uint> EnumerateUntil(uint upperBound)
        {
            Validate(upperBound);

            foreach (var n in base.EnumerateUntil(upperBound))
                if (n % 2 == 1)
                    yield return n;
        }
    }
}
