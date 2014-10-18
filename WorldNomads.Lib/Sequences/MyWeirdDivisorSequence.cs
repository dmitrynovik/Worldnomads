using System;
using System.Collections.Generic;

namespace WorldNomads.Lib.Sequences
{
    public class MyWeirdDivisorSequence : PositiveSequence<object>
    {
        public override string DisplayName
        {
            get { return @"Sequence of whole positive numbers except C if divisible by 3, E if divisible by 5, and Z if divisible by 15."; }
        }

        public override IEnumerable<object> EnumerateUntil(uint upperBound)
        {
            Validate(upperBound);

            for (var i = 1; i <= upperBound; ++i)
            {
                if (i.IsMultipleOf(15))
                    yield return 'Z';
                else if (i.IsMultipleOf(3))
                    yield return 'C';
                else if (i.IsMultipleOf(5))
                    yield return 'E';
                else
                    yield return i;
            }
        }
    }
}
