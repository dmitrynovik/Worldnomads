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
        static IEnumerable<Type> _sequenceTypes;

        static SequenceFactory()
        {
            // Reflect types implementing PositiveSequence<uint>:
            _sequenceTypes = Assembly.GetExecutingAssembly().GetTypes().Where(IsSequence);
        }

        private static bool IsSequence(Type t)
        {
            return !t.IsAbstract && t.IsClass && typeof(Sequence<uint>).IsAssignableFrom(t);
        }

        public IEnumerable<Sequence<uint>> EnumerateAll(uint upperBound)
        {
            return _sequenceTypes.Select(t => (Sequence<uint>)Activator.CreateInstance(t, upperBound)).ToArray();
        }
    }
}
