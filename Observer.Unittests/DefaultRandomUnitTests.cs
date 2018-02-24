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
    class DefaultRandomUnitTests
    {
        [Test]
        void DefaultRandom_ResultIsInRange0_10()
        {
            var uut = new DefaultRandom();
        }
    }
}
