using System;
using System.Linq;

namespace RomanNumberConverter.Helpers {
    public static class RomanNumberFormatter {
        public static string FormatRomanNumber(string romanNumber) {
            if (string.IsNullOrWhiteSpace(romanNumber))
                throw new ArgumentNullException();
            romanNumber = romanNumber.ToUpper();
            romanNumber = RemoveWhitespace(romanNumber);
            if (RomanNumberIsValid(romanNumber))
                return romanNumber;
            throw new InvalidOperationException("This is not a Roman Number");
        }

        static bool RomanNumberIsValid(string romanNumber) {
            foreach (var letter in romanNumber)
                if (!LetterIsValid(letter))
                    return false;
            return true;
        }

        static bool LetterIsValid(char letter) {
            return letter.Equals('I') || letter.Equals('V') || letter.Equals('X') ||
                   letter.Equals('L') || letter.Equals('C') || letter.Equals('D') ||
                   letter.Equals('M');
        }

        static string RemoveWhitespace(string input) {
            return new string(input.ToCharArray().Where(c => !char.IsWhiteSpace(c)).ToArray());
        }
    }
}