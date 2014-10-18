using System;
using System.Collections.Generic;

namespace WorldNomads.Lib
{
    public interface ISequence<TIn, TOut>
    {
        IEnumerable<TOut> Enumerate();
    }
}
