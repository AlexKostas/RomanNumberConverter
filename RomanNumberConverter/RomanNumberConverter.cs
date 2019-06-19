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

        //TODO: Change this to iterative solution
        public static string IntegerToRoman(int number) {
            if(number < 0)
                throw new ArgumentOutOfRangeException();
            if (number == 0) return "";
            if (number >= 1000) return "M" + IntegerToRoman(number - 1000);
            if (number >= 900) return "CM" + IntegerToRoman(number - 900); 
            if (number >= 500) return "D" + IntegerToRoman(number - 500);
            if (number >= 400) return "CD" + IntegerToRoman(number - 400);
            if (number >= 100) return "C" + IntegerToRoman(number - 100);            
            if (number >= 90) return "XC" + IntegerToRoman(number - 90);
            if (number >= 50) return "L" + IntegerToRoman(number - 50);
            if (number >= 40) return "XL" + IntegerToRoman(number - 40);
            if (number >= 10) return "X" + IntegerToRoman(number - 10);
            if (number >= 9) return "IX" + IntegerToRoman(number - 9);
            if (number >= 5) return "V" + IntegerToRoman(number - 5);
            if (number >= 4) return "IV" + IntegerToRoman(number - 4);
            if (number >= 1) return "I" + IntegerToRoman(number - 1);
            throw new Exception("Operation failed");
        }
    }
}