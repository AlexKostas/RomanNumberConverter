using NUnit.Framework;

namespace RomanNumberConverter.UnitTests {
    [TestFixture]
    public class RomanNumberFormatterTests {
        [Test]
        [TestCase(" III ", "III")]
        [TestCase(" M X V II   ", "MXVII")]
        [TestCase("m x v i i", "MXVII")]
        public void FormatRomanNumber_WhenCalled_ReturnFormattedRoman(string inp, string expected) {
            Assert.That(RomanNumberFormatter.FormatRomanNumber(inp), Is.EqualTo(expected));
        }

        [Test]
        [TestCase("CPXX")]
        [TestCase("!@*#*)Q")]
        [TestCase("HELLO WORLD")]
        [TestCase("MDCLMXVIHIVXKVDM")]
        public void FormatRomanNumber_GivenInvalidInput_ThrowInvalidOperationException(string inp) {
            Assert.That(() => RomanNumberFormatter.FormatRomanNumber(inp),
                Throws.InvalidOperationException);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public void FormatRomanNumber_GivenNullInput_ThrowsArgumentNullException(string input) {
            Assert.That(() => RomanNumberFormatter.FormatRomanNumber(input),
                Throws.ArgumentNullException);
        }
    }
}