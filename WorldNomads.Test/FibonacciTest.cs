using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using WorldNomads.Lib.Sequences;

namespace WorldNomads.Test
{
    public class FibonacciTest
    {
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void  When_0_Error()
        {
            var sequence = new Fibonacci();
            sequence.EnumerateUntil(0);
        }

        [Test]
        public void When_1_Output_Is_1_1()
        {
            var setup = new Fibonacci();
            var result = setup.EnumerateUntil(1);
            Assert.IsTrue(result.SequenceEqual(new uint[] { 1, 1 }));
        }

        [Test]
        public void When_8_Output_Is_1_1_2_3_5_8()
        {
            var setup = new Fibonacci();
            var result = setup.EnumerateUntil(8);
            Assert.IsTrue(result.SequenceEqual(new uint[] { 1, 1, 2, 3, 5, 8 }));
        }

        [Test]
        public void When_9_Output_Is_1_1_2_3_5_8()
        {
            var setup = new Fibonacci();
            var result = setup.EnumerateUntil(9);
            Assert.IsTrue(result.SequenceEqual(new uint[] { 1, 1, 2, 3, 5, 8 }));
        }
    }
}
