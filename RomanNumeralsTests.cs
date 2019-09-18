using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace BasicTDD.Tests
{
    [TestFixture]
    class RomanNumeralsTests
    {
        [TestCase("LXXXVIII", 88)]
        [TestCase("XCI", 91)]
        [TestCase("CD", 400)]
        [TestCase("CM", 900)]
        [TestCase("XLIX", 49)]
        [TestCase("I", 1)]

        public void ParseRomanNumeralsToDigits_ReturnsCorrectValue(string romanVal, int expected)
        {
            int result = RomanNumerals.ParseRomanNumeralsToDigits(romanVal);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ParseRomanNumeralsToDigits_InvalidFormat_ThrowsKeyNotFoundException()
        {
            void action() => RomanNumerals.ParseRomanNumeralsToDigits("XZLI");
            //void action() => SerialPortParser.ParsePort("1");
            Assert.Throws<KeyNotFoundException>(action);

        }

    }
}
