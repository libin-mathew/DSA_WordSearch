

namespace DSA_WordSearch.CoreOperations
{
    /// <summary>
    /// Represents a node for each character in a word
    /// </summary>
    public class Node
    {
        public char character;
        public bool isEndOfTheWord; // To mark a char as the last char of a word
        public Node[] children; // Each next char of the word is considered as the child of the current char and so on.

        public Node(char character)
        {
            this.character = character;
            isEndOfTheWord = false;
            children = new Node[26]; //Represent a-z
        }

    }
}
