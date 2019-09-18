using System;
using NUnit.Framework;

namespace BasicTDD.Tests
{
    [TestFixture]
    class FizzBuzzTests
    {
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(17, "")]
       public void Ask_Number_ReturnsCorrectString(int number, string expectedValue)
        {
            string result = FizzBuzz.Ask(number);
            Assert.That(result, Is.EqualTo(expectedValue));

        }

    }
}
