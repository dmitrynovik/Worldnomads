using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace WorldNomads.Lib
{
    public class SequenceFactory
    {
        //
        // NOTE: Could potentially implement same functionality using 
        //  - Managed Extensibility Framework (MEF)
        // OR
        // -  IoC container
        // 
        static IEnumerable<object> _sequences;

        static SequenceFactory()
        {
            // Reflect types implementing PositiveSequence<uint>:
            _sequences = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => IsSequence(t))
                .Select(Activator.CreateInstance);
        }

        private static bool IsSequence(Type t)
        {
            return !t.IsAbstract && t.IsClass && 
                (typeof(PositiveSequence<uint>).IsAssignableFrom(t) || typeof(PositiveSequence<object>).IsAssignableFrom(t));
        }

        public IEnumerable<IEnumerable<object>> EnumerateAll(uint upperBound)
        {
            return _sequences.Select(seq => ((IEnumerable)seq.GetType().GetMethod("EnumerateUntil")
                    .Invoke(seq, new object[] { upperBound }))
                    .Cast<object>());
        }
    }
}
