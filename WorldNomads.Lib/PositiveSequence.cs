using System;
using System.Collections.Generic;

namespace WorldNomads.Lib
{
    public abstract class PositiveSequence<TOut> : Sequence<int>
    {
        public PositiveSequence(int bounds) : base(bounds)
        {
            if (bounds <= 0)
                throw new ArgumentException("Please enter positive whole number");
        }
    }
}
