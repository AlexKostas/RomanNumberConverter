using System;

namespace RomanNumberConverter {
    internal static class Program {
        public static void Main() {
            Console.WriteLine("Welcome to Roman Number converter!");
            while (true) {
                string input = GetInputFromConsole();
                
                if (input.Equals("")) continue;
                if (input.Equals("quit")) break;

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
            Console.WriteLine("Type an integer which is greater than zero to convert it " +
                    "to roman or a valid roman number to convert it to integer. Type quit to exit");
            string input = Console.ReadLine() ?? string.Empty;
            return input.ToLower().Trim();
        }
        
        static void RomanFromInt(int num) {
            try {
                string romanNum = RomanNumberConverter.IntegerToRoman(num);
                Console.WriteLine("Roman number for {0} is: {1}", num, romanNum);
            }
            catch (ArgumentOutOfRangeException) {
                Console.WriteLine("Please enter a value greater than or equal to zero");
                throw;
            }
            catch (Exception) {
                Console.WriteLine("Something went wrong");
                throw;
            }
        }

        static void IntFromRoman(string inputtedRoman) {
            string formattedRoman = GetFormattedRoman(inputtedRoman);
            try {
                int result = RomanNumberConverter.RomanToInteger(formattedRoman);
                Console.WriteLine("Integer number for {0} is: {1}", formattedRoman, result);
            }
            catch (Exception) {
                Console.WriteLine("Something went wrong");
                throw;
            }
        }

        static string GetFormattedRoman(string inputtedRoman) {
            try {
                return RomanNumberFormatter.FormatRomanNumber(inputtedRoman);
            }
            catch (ArgumentNullException) {
                Console.WriteLine("Can't convert an empty number");
                throw;
            }
            catch (InvalidOperationException) {
                Console.WriteLine("This is not a roman number");
                throw;
            }
        }
    }
}