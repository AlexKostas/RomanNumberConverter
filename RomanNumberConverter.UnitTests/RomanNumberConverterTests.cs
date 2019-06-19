using System;
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
        [TestCase("DJSBVJD")]
        [TestCase("xvii")]
        [TestCase(null)]
        [TestCase("    ")]
        [TestCase("")]
        public void RomanToInteger_GivenInvalidInput_ReturnsArgumentException(string input) {
            Assert.That(() => RomanNumberConverter.RomanToInteger(input), Throws.ArgumentException);
        }

        [Test]
        [TestCase(19, "XIX")]
        [TestCase(999, "CMXCIX")]
        [TestCase(11984, "MMMMMMMMMMMCMLXXXIV")]
        public void IntegerToRoman_GivenIntegers_ReturnsRomanNumber(int num, string expectedRoman) {
            Assert.That(RomanNumberConverter.IntegerToRoman(num), Is.EqualTo(expectedRoman));
        }

        [Test]
        [TestCase(-5768)]
        [TestCase(-437686376)]
        [TestCase(-10000)]
        [TestCase(-1)]
        public void IntegerToRoma_GivenInvalidInput_ReturnsArgumentOutOfRangeException(int input) {
            Assert.That(() => RomanNumberConverter.IntegerToRoman(input),
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}