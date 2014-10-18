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
            var sequence = new MyWeirdDivisorSequence();
            Console.WriteLine( sequence.EnumerateUntil(0).ToArray() );
        }

        [Test]
        public void When_15_Output_Is_1_2_C_4_E_C_7_8_C_E_11_C_13_14_Z()
        {
            var setup = new MyWeirdDivisorSequence();
            var result = setup.EnumerateUntil(15);
            Assert.IsTrue(result.SequenceEqual(new object[] 
                { 1, 2, 'C', 4, 'E', 'C', 7, 8, 'C', 'E', 11, 'C', 13, 14, 'Z' }));
        }
    }
}
