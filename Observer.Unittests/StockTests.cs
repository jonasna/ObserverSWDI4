using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Observer.Impl;
using NSubstitute;
using Observer.Impl.Interfaces;

// Fakes are generated through NSubstitute.

namespace Observer.Unittests
{
    [TestFixture]
    public class StockTests
    {
        [Test]
        public void StockConstructor_InputArguments_ObjectFieldsMatchArguments()
        {
            var fakeRegulator = Substitute.For<IRegulator>();
            var uut = new Stock("ABC", 2, fakeRegulator);
            Assert.That(uut.Value, Is.EqualTo(2));
            Assert.That(uut.Navn, Is.EqualTo("ABC"));
        }

        [Test]
        public void StockConstructor_InputArguments_RegulatorStartCalled()
        {
            var fakeRegulator = Substitute.For<IRegulator>();
            var uut = new Stock("ABC", 2, fakeRegulator);
            uut.StartRegulate();
            fakeRegulator.Received().Start();
        }

        [Test]
        public void StockConstructor_InputArguments_NoRegulatorPassed_ValuesAreSet()
        {
            var uut = new Stock("ABC", 2);
            uut.StartRegulate();
            Assert.That(uut.Value, Is.EqualTo(2));
            Assert.That(uut.Navn, Is.EqualTo("ABC"));
        }

        [Test]
        public void StockConstructor_InputArguments_RegulatorStopCalled()
        {
            var fakeRegulator = Substitute.For<IRegulator>();
            var uut = new Stock("ABC", 2, fakeRegulator);
            uut.StopRegulate();
            fakeRegulator.Received().Stop();
        }

        [Test]
        public void StockConstructor_IncreaseValue_PriceIsEqualToExpected()
        {
            var fakeRegulator = Substitute.For<IRegulator>();
            var uut = new Stock("ABC", 100, fakeRegulator);
            uut.IncreaseValue();
            Assert.That(uut.Value, Is.EqualTo(105));
        }

        [Test]
        public void StockConstructor_DecreaseValue_PriceIsEqualToExpected()
        {
            var fakeRegulator = Substitute.For<IRegulator>();
            var uut = new Stock("ABC", 100, fakeRegulator);
            uut.DecreaseValue();
            Assert.That(uut.Value, Is.EqualTo(95));
        }
    }
}
