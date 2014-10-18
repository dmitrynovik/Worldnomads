using System;
using System.Collections.Generic;
using System.Linq;
using WorldNomads.Lib.Sequences;
using NUnit.Framework;

namespace WorldNomads.Test
{
    public class MyWeirdDivisorSequenceTest
    {
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void  When_0_Error()
        {
            var sequence = new MyWeirdDivisorSequence(0);
        }

        [Test]
        public void When_15_Output_Is_1_2_C_4_E_C_7_8_C_E_11_C_13_14_Z()
        {
            var seq = new MyWeirdDivisorSequence(15);
            Assert.IsTrue(seq.Results.SequenceEqual(new object[] 
                { 1, 2, 'C', 4, 'E', 'C', 7, 8, 'C', 'E', 11, 'C', 13, 14, 'Z' }));
        }
    }
}
