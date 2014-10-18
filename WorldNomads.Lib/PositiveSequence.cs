using System;
using System.Collections.Generic;

namespace WorldNomads.Lib
{
    public abstract class PositiveSequence<TOut> : ISequence<uint, TOut>
    {
        public PositiveSequence(uint upperBound)
        {
            if (upperBound <= 0) 
                throw new ArgumentException("Must enter positive integer", "start");

            UpperBound = upperBound;
        }

        public uint UpperBound { get; private set; }

        public abstract IEnumerable<TOut> Enumerate();
    }
}
