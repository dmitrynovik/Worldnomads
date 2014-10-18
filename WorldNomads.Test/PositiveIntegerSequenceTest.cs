using System;
using System.Linq;
using NUnit.Framework;
using WorldNomads.Lib.Sequences;

namespace WorldNomads.Test
{
    [TestFixture]
    public class PositiveIntegerSequenceTest
    {
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void  When_0_Error()
        {
            var sequence = new PositiveIntegerSequence(0);
        }

        [Test]
        public void When_3_Output_Is_1_2_3()
        {
            var seq = new PositiveIntegerSequence(3);
            Assert.IsTrue(seq.Results.Cast<int>().SequenceEqual(new int[] { 1, 2, 3 }));
        }
    }
}
