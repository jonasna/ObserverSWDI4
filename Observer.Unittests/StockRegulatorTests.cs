using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework;
using Observer.Impl;
using Observer.Impl.Interfaces;

namespace Observer.Unittests
{
    [TestFixture]
    class StockRegulatorTests
    {
        [Test]
        public void Regulate_RandomNrIsOne_IncreaseValueIsCalled()
        {
            var fakeRandom = Substitute.For<IRandom>();
            fakeRandom.GenerateRandom(1, 3).Returns(1);

            var fakeStock = Substitute.For<IStock>();

            var uut = new StockRegulator(fakeRandom, fakeStock);

            uut.Regulate();

            // Assert
            fakeStock.Received().IncreaseValue();
        }

        [Test]
        public void Regulate_RandomNrIsTwo_DecreaseValueIsCalled()
        {
            var fakeRandom = Substitute.For<IRandom>();
            fakeRandom.GenerateRandom(1, 3).Returns(2);

            var fakeStock = Substitute.For<IStock>();

            var uut = new StockRegulator(fakeRandom, fakeStock);

            // Act
            uut.Regulate();

            // Assert
            fakeStock.Received().DecreaseValue();
        }
    }
}
