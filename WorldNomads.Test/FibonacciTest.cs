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
            var sequence = new Fibonacci(0);
        }

        [Test]
        public void When_1_Output_Is_1_1()
        {
            var seq = new Fibonacci(1);
            Assert.IsTrue(seq.Results.Cast<uint>().SequenceEqual(new uint[] { 1, 1 }));
        }

        [Test]
        public void When_8_Output_Is_1_1_2_3_5_8()
        {
            var seq = new Fibonacci(8);
            Assert.IsTrue(seq.Results.Cast<uint>().SequenceEqual(new uint[] { 1, 1, 2, 3, 5, 8 }));
        }

        [Test]
        public void When_9_Output_Is_1_1_2_3_5_8()
        {
            var seq = new Fibonacci(9);
            Assert.IsTrue(seq.Results.Cast<uint>().SequenceEqual(new uint[] { 1, 1, 2, 3, 5, 8 }));
        }
    }
}
