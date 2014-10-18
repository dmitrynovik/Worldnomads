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
            // Reflect types implementing PositiveSequence<int>:
            _sequenceTypes = Assembly.GetExecutingAssembly().GetTypes().Where(IsSequence);
        }

        private static bool IsSequence(Type t)
        {
            return !t.IsAbstract && t.IsClass && typeof(Sequence<int>).IsAssignableFrom(t);
        }

        public IEnumerable<Sequence<int>> EnumerateAll(int upperBound)
        {
            return _sequenceTypes.Select(t => (Sequence<int>)Activator.CreateInstance(t, upperBound)).ToArray();
        }
    }
}
