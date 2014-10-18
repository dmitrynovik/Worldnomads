using System;
using System.Linq;
using NUnit.Framework;
using WorldNomads.Lib;

namespace WorldNomads.Test
{
    [TestFixture]
    public class SequenceFactoryTest
    {
        [Test]
        public void Assert_All_5_Types_Of_Sequences_Produced()
        {
            var factory = new SequenceFactory();
            Assert.AreEqual(5, factory.EnumerateAll(1).Count());
        }
    }
}
