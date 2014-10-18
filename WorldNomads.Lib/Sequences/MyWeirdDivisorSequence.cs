using System;
using System.Collections.Generic;

namespace WorldNomads.Lib.Sequences
{
    public class MyWeirdDivisorSequence : PositiveSequence<object>
    {
        public MyWeirdDivisorSequence(uint upperBound) : base(upperBound) {  }

        public override IEnumerable<object> Enumerate()
        {
            for (var i = 1; i <= UpperBound; ++i)
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
