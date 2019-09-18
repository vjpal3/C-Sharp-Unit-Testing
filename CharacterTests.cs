using System;
using NUnit.Framework;


namespace BasicTDD.Tests
{
    [TestFixture]
    class CharacterTests
    {
        private Character character;

        [SetUp]
        public void Setup()
        {
            character = new Character(Type.Elf);
        }

        [TearDown]
        public void Teardown()
        {
            character.Dispose();
            character = null;
        }

        [Test]
        public void IsDead_KillCharacter_ReturnsTrue()
        {
            character.Damage(500);
            Assert.That(character.IsDead, Is.True);
        }

        [Test]
        public void IsDead_DefaultCharacter_ReturnsFalse()
        {
            Assert.That(character.IsDead, Is.False);
        }

        [TestCase(100, 45)]
        [TestCase(80, 65)]
        public void Health_Damage_ReturnsCorrectValue(int damage, int expectedHealth)
        {
            character.Damage(damage);
            Assert.That(character.Health, Is.EqualTo(expectedHealth));
        }
    }
}
