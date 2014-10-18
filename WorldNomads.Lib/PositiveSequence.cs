using System;
using System.Collections.Generic;

namespace WorldNomads.Lib
{
    public abstract class PositiveSequence<TOut> : ISequence<uint, TOut>
    {
        public abstract IEnumerable<TOut> EnumerateUntil(uint upperBound);

        public void Validate(uint upperBound)
        {
            if (upperBound <= 0)
                throw new ArgumentException("The argument must be a positive whole number", "upperBound");
        }
    }
}
