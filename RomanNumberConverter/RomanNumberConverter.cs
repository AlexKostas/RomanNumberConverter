using System;
using System.Linq;

namespace RomanNumberConverter {
    public static class RomanNumberConverter {
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
    }
}