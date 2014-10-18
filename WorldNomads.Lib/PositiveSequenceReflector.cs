using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace WorldNomads.Lib
{
    public class PositiveSequenceReflector
    {
        //
        // Note: could implement same functionality using Managed Extensibility Framework (MEF) instead of Reflection
        // 

        static IEnumerable<Type> _sequenceTypes;

        static PositiveSequenceReflector()
        {
            // Reflect types implementing PositiveSequence<uint>:
            _sequenceTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => !t.IsAbstract && t.IsClass && typeof(PositiveSequence<uint>).IsAssignableFrom(t));
        }

        public IEnumerable<IEnumerable<object>> EnumerateAll(uint bound)
        {
            return _sequenceTypes.Select(t => {
                    var seq = Activator.CreateInstance(t, bound);
                    var result = (IEnumerable)t.GetMethod("Enumerate").Invoke(seq, null);
                    return result.Cast<object>();
                });
        }
    }
}
