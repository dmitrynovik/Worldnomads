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
            var seq = new OddPositiveIntegerSequence(3);
            Assert.IsTrue(seq.Results.Cast<int>().SequenceEqual(new int[] { 1, 3 }));
        }
    }
}
