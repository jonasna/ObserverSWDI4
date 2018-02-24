using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Observer.Impl;
using NSubstitute;
using Observer.Impl.Interfaces;

namespace Observer.Unittests
{
    [TestFixture]
    public class StockTests
    {
        [Test]
        public void StockConstructor_InputArguments_ObjectFieldsMatchArguments()
        {
            var FakeRegulator = Substitute.For<IRegulator>();
            var uut = new Stock("ABC", 2, FakeRegulator);
        }
    }
}
