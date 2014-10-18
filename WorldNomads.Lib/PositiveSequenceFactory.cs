using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace WorldNomads.Lib
{
    public class PositiveSequenceFactory
    {
        //
        // Note: Could potentially implement same functionality using 
        //  - Managed Extensibility Framework (MEF) instead
        // OR
        // -  IoC container
        // 
        static IEnumerable<object> _sequences;

        static PositiveSequenceFactory()
        {
            // Reflect types implementing PositiveSequence<uint>:
            _sequences = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => !t.IsAbstract && t.IsClass && typeof(PositiveSequence<uint>).IsAssignableFrom(t))
                .Select(Activator.CreateInstance);
        }

        public IEnumerable<IEnumerable<object>> EnumerateAll(uint upperBound)
        {
            return _sequences.Select(seq => ((IEnumerable)seq.GetType().GetMethod("EnumerateUntil")
                    .Invoke(seq, new object[] { upperBound }))
                    .Cast<object>());
        }
    }
}
