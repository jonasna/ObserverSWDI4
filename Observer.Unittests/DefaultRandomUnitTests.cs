using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Impl;
using NUnit.Framework;

namespace Observer.Unittests
{
    [TestFixture]
    public class DefaultRandomUnitTests
    {
        [Test]
        public void DefaultRandom_ResultIsInRange0_10()
        {
            var uut = new DefaultRandom(0,10);
            Assert.That(uut.GetResult, Is.GreaterThanOrEqualTo(0).And.LessThan(10));
        }
    }
}
