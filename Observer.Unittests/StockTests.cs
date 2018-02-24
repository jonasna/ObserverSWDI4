using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Observer.Impl;

namespace Observer.Unittests
{
    [TestFixture]
    public class StockTests
    {
        [Test]
        public void StockConstructor_InputArguments_ObjectFieldsMatchArguments()
        {
            var uut = new Stock("ABC", 2, FakeRegulator);
        }
    }
}
