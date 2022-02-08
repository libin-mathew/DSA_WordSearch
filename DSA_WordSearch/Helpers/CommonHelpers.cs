
namespace DSA_WordSearch.Helpers
{
    /// <summary>
    /// Static helper for common operations
    /// Class contains extenstion methods 
    /// </summary>
    public static class CommonHelpers
    {
        /// <summary>
        /// To Convert the input to Integer
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int ConvertToInteger(this string input)
        {
            var isNumeric = int.TryParse(input, out int numberResult);
            int convertedInput = numberResult;
            return convertedInput;
        }
    }
}
