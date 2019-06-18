using NUnit.Framework;

namespace RomanNumberConverter.UnitTests {
    [TestFixture]
    public class RomanNumberConverterTests {
        [Test]
        [TestCase("XVII", 17)]
        [TestCase("MDCLXVI", 1666)]
        public void RomanToInteger_GivenRomanNumber_ReturnsInteger(string roman, int integer) {
            Assert.That(RomanNumberConverter.RomanToInteger(roman), Is.EqualTo(integer));
        }

        [Test]
        [TestCase("X V I I")]
        [TestCase("XV II")]
        [TestCase(null)]
        [TestCase("    ")]
        [TestCase("")]
        public void RomanToInteger_GivenInvalidInput_ReturnsArgumentException(string input) {
            Assert.That(() => RomanNumberConverter.RomanToInteger(input), Throws.ArgumentException);
        }
    }
}