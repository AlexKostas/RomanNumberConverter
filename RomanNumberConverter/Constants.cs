namespace RomanNumberConverter {
    public static class Constants {
        public const string WelcomeMessage = "Welcome to Roman Number Converter!";
        public const string Directions = "Type an integer which is greater than zero to " +
        "convert it to roman or a valid roman number to convert it to integer. Type " +
                                         QuitOption + " to exit";
        public const string QuitOption = "quit";
        public const string RomanFromIntResultMessage = "Roman number for {0} is: {1}";
        public const string ArgumentOutOfRangeError = "Please enter a value greater than or equal" +
                                                      " to zero";
        public const string UnknownErrorMessage = "Something went wrong";
        public const string EmptyNumberError = "Can't convert an empty number";
        public const string InvalidNumberError = "This is not a roman number";
        public const string IntFromRomanMessage = "Integer number for {0} is: {1}";
    }
}