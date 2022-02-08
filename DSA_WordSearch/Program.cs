
using DSA_WordSearch.CoreOperations;
using DSA_WordSearch.Helpers;
using DSA_WordSearch.UserInputOutOperations;

namespace DSA_WordSearch
{
    public class Program
    {
        public static void Main()
        {
            #region Declarations
            // Declaration Section
            UserInputOperations userInputOutput = new UserInputOperations();
            DSAWordSearch dSAWordSearch = new DSAWordSearch();
            #endregion

            #region Print User Instrucations to Screen
            userInputOutput.PrintMessageToScreen("Only a-z are allowed in a word");
            userInputOutput.PrintMessageToScreen("FOLLOWING DATA STRUCTURE OPERATIONS ARE AVAILABLE");
            userInputOutput.PrintMessageToScreen("=====================================================");
            userInputOutput.PrintMessageToScreen("1. Inserts a string word into the structure.");
            userInputOutput.PrintMessageToScreen("2. Search for a word in the structure");
            userInputOutput.PrintMessageToScreen("3. Search for a word starts with a prefix in the structure");
            userInputOutput.PrintMessageToScreen("=====================================================");
            #endregion


            try
            {
                do
                {
                    userInputOutput.PrintMessageToScreen("Enter an Option : ");
                    var userInput = userInputOutput.ReadInputFromUser();
                    var inputOption = userInput.ConvertToInteger();
                    bool result = false;
                    string word = string.Empty;

                    switch (inputOption)
                    {
                        case 1:
                            userInputOutput.PrintMessageToScreen("Enter a word in small case");
                            dSAWordSearch.Insert(userInputOutput.ReadInputFromUser());
                            break;
                        case 2:
                            userInputOutput.PrintMessageToScreen("Enter a word to search in small case");
                            word = userInputOutput.ReadInputFromUser();
                            result = dSAWordSearch.Search(word);
                            if (result)
                                userInputOutput.PrintMessageToScreen("Word is Present");
                            else
                                userInputOutput.PrintMessageToScreen("Word is not present");
                            break;
                        case 3:
                            userInputOutput.PrintMessageToScreen("Enter a prefix to search in small case");
                            word = userInputOutput.ReadInputFromUser();
                            result = dSAWordSearch.FindStartWith(word);
                            if (result)
                                userInputOutput.PrintMessageToScreen(string.Format("Word with prefix '{0}' is Present",word));
                            else
                                userInputOutput.PrintMessageToScreen(string.Format("Word with prefix '{0}' is not Present", word));
                            break;
                       default: userInputOutput.PrintMessageToScreen("Opetion is invalid");
                            break;

                    }

                    userInputOutput.PrintMessageToScreen("Do you want to continue (Y/N)? ");
                } while (userInputOutput.ReadInputFromUser().ToUpper() != "N");
            }
            catch (Exception)
            {
                userInputOutput.PrintMessageToScreen(@"An Error Occurred While Processing");
                userInputOutput.PrintMessageToScreen("Press any Key To Exit");
                Console.ReadKey();
            }

        }
    }
}
