using System;
using NUnit.Framework;

namespace BasicTDD.Tests
{
    [TestFixture]
    class DegreeConverterTests
    {
        [Test]
        public void ToFahrenheit_ZeroCelsius_Returns32()
        {
            var result = new DegreeConverter().ToFahrenheit(0);
            Assert.That(result, Is.EqualTo(32));
        }

        [Test]
        public void ToCelsius_ThirtytwoFahrenheit_Returns0()
        {
            var result = new DegreeConverter().ToCelsius(32);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
