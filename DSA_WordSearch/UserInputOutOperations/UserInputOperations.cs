
namespace DSA_WordSearch.UserInputOutOperations
{
    /// <summary>
    /// Input Output Operations
    /// Class implementing IUserInputOperations
    /// </summary>
    public class UserInputOperations : IUserInputOperations
    {
        /// <summary>
        /// To Write message to the console
        /// </summary>
        /// <param name="message"></param>
        public void PrintMessageToScreen(string message)
        {
            Console.WriteLine(message);
        }

        /// <summary>
        /// To Read User Input
        /// </summary>
        /// <returns></returns>
        public string? ReadInputFromUser()
        {
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}
