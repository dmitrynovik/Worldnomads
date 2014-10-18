using System;
using System.Linq;
using System.Collections.Generic;

namespace WorldNomads.Lib
{
    public abstract class Sequence<TIn>
    {
        private IEnumerable<object> _results;
        protected readonly TIn _upperBound;

        public Sequence(TIn bounds)
        {
            _upperBound = bounds;
            _results = EnumerateUntil(bounds).ToArray();
        }

        public abstract string DisplayName { get; }

        public IEnumerable<object> Results
        {
            get
            {
                return _results;
            }
        }

        protected abstract IEnumerable<object> EnumerateUntil(TIn bounds);
    }
}
