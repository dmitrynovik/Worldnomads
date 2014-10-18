using System;
using System.Collections.Generic;
using System.Linq;
using WorldNomads.Lib.Sequences;
using NUnit.Framework;

namespace WorldNomads.Test
{
    public class OddPositiveIntegerSequenceTest
    {
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void  When_0_Error()
        {
            var sequence = new OddPositiveIntegerSequence(0);
        }

        [Test]
        public void When_3_Output_Is_1_3()
        {
            var setup = new OddPositiveIntegerSequence(3);
            var result = setup.Enumerate();
            Assert.IsTrue(result.SequenceEqual(new uint[] { 1, 3 }));
        }
    }
}
