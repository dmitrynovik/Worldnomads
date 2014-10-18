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
            var setup = new PositiveIntegerSequence(3);
            var result = setup.Enumerate();
            Assert.IsTrue(result.SequenceEqual(new uint[] { 1, 2, 3 }));
        }
    }
}
