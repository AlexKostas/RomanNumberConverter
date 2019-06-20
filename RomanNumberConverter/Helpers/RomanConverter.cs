using System;
using System.Linq;
using System.Text;

namespace RomanNumberConverter.Helpers {
    public static class RomanConverter {
        public static int RomanToInteger(string romanNumber) {
            if (string.IsNullOrWhiteSpace(romanNumber))
                throw new ArgumentException();

            var letters = romanNumber.ToCharArray();
            return letters.Sum(RomanLetterValue);
        }

        static int RomanLetterValue(char letter) {
            switch (letter) {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default:
                    throw new ArgumentException();
            }
        }

        public static string IntegerToRoman(int number) {
            if(number < 0) throw new ArgumentOutOfRangeException();
            var result = new StringBuilder();
            int[] digitsValues = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
            string[] romanDigits = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", 
                "CM", "M" };
            while (number > 0)
            {
                for (int i = digitsValues.Count() - 1; i >= 0; i--)
                    if (number / digitsValues[i] >= 1)
                    {
                        number -= digitsValues[i];
                        result.Append(romanDigits[i]);
                        break;
                    }
            }
            return result.ToString();
        }
    }
}