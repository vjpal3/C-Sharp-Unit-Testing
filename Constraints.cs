using System;
using NUnit.Framework;
namespace BasicTDD.Tests
{
    [TestFixture]
    class Constraints
    {
        [Test]
        public void TestConstraints ()
        {
            var array = new string[] { "abc", "nmb", "bdr" };
            Assert.That(array, Is.All.Contain("b"));
            Assert.That(array, Is.Not.Length.EqualTo(4));
            Assert.That(@"e:\tmp.txt", Does.Not.Exist);
            Assert.That(42, Is.Not.Null);
            Assert.That(42, Is.Not.NaN);
            Assert.That(42, Is.Not.True);
            Assert.That((2 == 4), Is.False);
            Assert.That((2 + 2), Is.Not.EqualTo(3));

            var intArray = new int[] { 1, 2, 3, 4, 9, 8 };
            Assert.That(intArray, Is.All.GreaterThan(0));

            // Does constraint is mostly used with strings.
            string phrase = "Are you Ok?";
            Assert.That(phrase, Does.EndWith("?"));
            Assert.That(phrase, Does.Not.EndWith("!"));
            Assert.That(phrase, Does.Not.Contain("GoodBuy"));

            // Has constraint is used with some constraint
            object[] strings = new Object[] { "abc", "def", "xrt", "bay" };
            Assert.That(strings, Has.Some.StartsWith("ba"));

            object[] doubles = new object[] { 0.99, 1.2, 4.6, 2.3 };
            Assert.That(doubles, Has.Some.EqualTo(1.0).Within(0.05));

            // "Or & And" compound conatraints
            Assert.That(-5, Is.LessThan(1).Or.GreaterThan(10));
            Assert.That(5, Is.LessThan(10).And.GreaterThan(1));
        }
    }
}
