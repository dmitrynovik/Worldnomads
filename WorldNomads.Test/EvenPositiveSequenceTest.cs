using System;
using System.Collections.Generic;
using System.Linq;
using WorldNomads.Lib.Sequences;
using NUnit.Framework;

namespace WorldNomads.Test
{
    public class EvenPositiveIntegerSequenceTest
    {
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void  When_0_Error()
        {
            var sequence = new EvenPositiveIntegerSequence(0);
        }

        [Test]
        public void When_3_Output_Is_2()
        {
            var setup = new EvenPositiveIntegerSequence(3);
            var result = setup.Enumerate();
            Assert.IsTrue(result.SequenceEqual(new uint[] { 2 }));
        }
    }
}
