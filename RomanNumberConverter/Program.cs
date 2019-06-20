using System;
using RomanNumberConverter.Helpers;

namespace RomanNumberConverter {
    internal static class Program {
        public static void Main() {
            Console.WriteLine(Constants.WelcomeMessage);
            while (true) {
                string input = GetInputFromConsole();
                
                if (input.Equals(string.Empty)) continue;
                if (input.Equals(Constants.QuitOption)) break;

                try {
                    int inputedInt = int.Parse(input);
                    try {
                        RomanFromInt(inputedInt);
                    }
                    catch (Exception) {
                        // ignored since execution should continue in next iteration of while loop
                    }
                }
                catch (FormatException) {
                    try {
                        IntFromRoman(input);
                    }
                    catch (Exception) {
                        // ignored since execution should continue in next iteration of while loop
                    }
                }
            }
        }

        static string GetInputFromConsole() {
            Console.WriteLine(Constants.Directions);
            string input = Console.ReadLine() ?? string.Empty;
            return input.ToLower().Trim();
        }
        
        static void RomanFromInt(int num) {
            try {
                string romanNum = RomanConverter.IntegerToRoman(num);
                Console.WriteLine(Constants.RomanFromIntResultMessage, num, romanNum);
            }
            catch (ArgumentOutOfRangeException) {
                Console.WriteLine(Constants.ArgumentOutOfRangeError);
                throw;
            }
            catch (Exception) {
                Console.WriteLine(Constants.UnknownErrorMessage);
                throw;
            }
        }

        static void IntFromRoman(string inputtedRoman) {
            string formattedRoman = GetFormattedRoman(inputtedRoman);
            try {
                int result = RomanConverter.RomanToInteger(formattedRoman);
                Console.WriteLine(Constants.IntFromRomanMessage, formattedRoman, result);
            }
            catch (Exception) {
                Console.WriteLine(Constants.UnknownErrorMessage);
                throw;
            }
        }

        static string GetFormattedRoman(string inputtedRoman) {
            try {
                return RomanNumberFormatter.FormatRomanNumber(inputtedRoman);
            }
            catch (ArgumentNullException) {
                Console.WriteLine(Constants.EmptyNumberError);
                throw;
            }
            catch (InvalidOperationException) {
                Console.WriteLine(Constants.InvalidNumberError);
                throw;
            }
        }
    }
}