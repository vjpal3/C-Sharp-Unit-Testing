using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BasicTDD.Tests
{
    [TestFixture]
    class CharacterTestsAdditional
    {
        #region String Tests
        [Test]
        public void ShouldSetName()
        {
            const string expectedValue = "John";
            Character c = new Character(Type.Elf, expectedValue);

            Assert.That(c.Name, Is.EqualTo(expectedValue));
            Assert.That(c.Name, Is.Not.Empty);
            Assert.That(c.Name, Contains.Substring("ohn"));
        }

        [Test]
        public void ShouldSetNameCaseInsensitive()
        {
            const string expectedUpperCase = "JOHN";
            const string expectedLowerCase = "john";
            Character c = new Character(Type.Elf, expectedUpperCase);

            Assert.That(c.Name, Is.EqualTo(expectedLowerCase).IgnoreCase);
        }

        #endregion 

    }
}
