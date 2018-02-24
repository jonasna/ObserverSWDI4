using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        public void Start_RandomNrIsOne_IncreaseValueIsCalledTwiceIn6Seconds()
        {
            var fakeRandom = Substitute.For<IRandom>();
            fakeRandom.GenerateRandom(1, 3).Returns(1);

            var fakeStock = Substitute.For<IStock>();

            var uut = new StockRegulator(fakeRandom, fakeStock);

            // Act
            uut.Start();
            Thread.Sleep(6000);
            uut.Stop();

            // Assert
            fakeStock.Received(2).IncreaseValue();
        }

        [Test]
        public void Stop_RandomNrIsTwo_DecreaseValueIsCalledTwiceIn6Seconds()
        {
            var fakeRandom = Substitute.For<IRandom>();
            fakeRandom.GenerateRandom(1, 3).Returns(2);

            var fakeStock = Substitute.For<IStock>();

            var uut = new StockRegulator(fakeRandom, fakeStock);

            // Act
            uut.Start();
            Thread.Sleep(6000);
            uut.Stop();

            // Assert
            fakeStock.Received(2).DecreaseValue();
        }
    }
}
