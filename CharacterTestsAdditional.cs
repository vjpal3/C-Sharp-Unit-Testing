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

        #region Numerical Tests

        [Test]
        public void DefaultHealthIs100()
        {
            Character c = new Character(Type.Elf);
            const int expectedHealth = 100;
            Assert.That(c.Health, Is.EqualTo(expectedHealth));
            Assert.That(c.Health, Is.Positive);
            Assert.That(c.Health, Is.Not.Negative);
        }


        [Test]
        public void ElfSpeedIsCorrect()
        {
            Character c = new Character(Type.Elf);
            const double expectedSpeed = 1.7;
            Assert.That(c.Speed, Is.EqualTo(expectedSpeed));
        }

        [Test]
        public void Ork_SpeedIsCorrectWithTolerance()
        {
            Character c = new Character(Type.Elf);
            const double expectedOrkSpeed = 0.3 + 1.1;
            Assert.That(c.Speed, Is.Not.EqualTo(expectedOrkSpeed));

            Assert.That(c.Speed, Is.EqualTo(expectedOrkSpeed).Within(0.5));
            //Assert.That(c.Speed, Is.EqualTo(expectedOrkSpeed).Within(1).Percent);
        }
        #endregion

        #region ranges of DateTime

        [Test]
        public void Dates_AreWithinRange() 
        {
            var dt = new DateTime(2020, 2, 1);
            Assert.That(dt, Is.EqualTo(new DateTime(2020, 4, 19)).Within(TimeSpan.FromDays(90)));
            Assert.That(dt, Is.EqualTo(new DateTime(2020, 4, 19)).Within(90).Days);
        }

        #endregion

        #region Nulls and Booleans

        [Test]
        public void DefaultNameIsNull()
        {
            Character c = new Character(Type.Elf);
            Assert.That(c.Name, Is.Null);
        }

        [Test]
        public void IsDead_KillCharacter_ReturnsTrue()
        {
            var c = new Character(Type.Elf);
            c.Damage(500);
            Assert.That(c.IsDead, Is.True);
            //Assert.IsFalse(c.IsDead);
            Assert.IsTrue(c.IsDead);
        }

        #endregion

        #region Collections
        [Test]
        public void CollectionTest()
        {
            var c = new Character(Type.Elf);
            c.Weaponry.Add("Knife");
            c.Weaponry.Add("Pistol");

            Assert.That(c.Weaponry, Is.All.Not.Empty);
            Assert.That(c.Weaponry, Contains.Item("Knife"));
            Assert.That(c.Weaponry, Has.Exactly(2).Length);
            Assert.That(c.Weaponry, Has.Exactly(1).EndsWith("tol"));
            Assert.That(c.Weaponry, Is.Unique);
            Assert.That(c.Weaponry, Is.Ordered);

            var c2 = new Character(Type.Elf);
            c2.Weaponry.Add("Knife");
            c2.Weaponry.Add("Pistol");

            Assert.That(c.Weaponry, Is.EquivalentTo(c2.Weaponry));
        }

        #endregion

        #region Reference Equality
        [Test]
        public void SameCharacters_AreEqualByReference()
        {
            var c1 = new Character(Type.Elf);
            Character c2 = c1;
            Assert.That(c1, Is.SameAs(c2));
        }

        #endregion

        #region Types
        [Test]
        public void TestObjectOfCharacterType()
        {
            Object c = new Character(Type.Elf);
            Assert.That(c, Is.TypeOf<Character>());
        }

        #endregion

        #region Ranges
        [Test]
        public void DefaultCharacterArmorShouldBeGreaterThan30AndLessThan100()
        {
            var c1 = new Character(Type.Elf);
            Assert.That(c1.Armor, Is.GreaterThan(30).And.LessThan(100));
            Assert.That(c1.Armor, Is.InRange(30, 100));
        }

        #endregion
        
    }
}
