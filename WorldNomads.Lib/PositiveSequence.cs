using System;
using System.Collections.Generic;

namespace WorldNomads.Lib
{
    public abstract class PositiveSequence<TOut> : Sequence<uint>
    {
        public PositiveSequence(uint bounds) : base(bounds)
        {
            if (bounds <= 0)
                throw new ArgumentException("Please entter positive whole number");
        }
    }
}
