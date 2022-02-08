

namespace DSA_WordSearch.CoreOperations
{
    public class DSAWordSearch : IDSAWordSearch
    {
        private Node parentRoot;
        public DSAWordSearch()
        {
            parentRoot =new Node('\0'); // Represent a dummy root node
        }
        public bool FindStartWith(string word)
        {
            return FindNode(word) != null;// if not null, then the prefix was there in the word
        }

        /// <summary>
        /// To Insert a word to the DS
        /// </summary>
        /// <param name="word"></param>
        public void Insert(string word)
        {
            Node currentNode = parentRoot;
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                // Char is represented in ASCII (256 in total) and the corresponding value for 'a' is 97.
                // Here we are dealing with only 26 char (a-z) and trying to convert the 256 to 26 length representation(a-z).
                // if the current char is 'b'(ASCII value is 98), so b(98)- a(97) = 1. Zero will be considered as 'a'
                if (currentNode.children[c-'a'] == null)
                {
                    currentNode.children[c - 'a'] = new Node(c); 
                }
                currentNode = currentNode.children[c - 'a'];
            }
            currentNode.isEndOfTheWord = true; // Very last char of a word
        }

        /// <summary>
        /// Search for the word
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool Search(string word)
        {
            Node? node = FindNode(word);
            return node != null && node.isEndOfTheWord; // isEndOfTheWord will be true if we can find the full word coz it is representing the last char in word
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public Node? FindNode(string word)
        {
            Node current = parentRoot;
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                // Char is represented in ASCII (256 in total) and the corresponding value for 'a' is 97.
                // Here we are dealing with only 26 char (a-z) and trying to convert the 256 to 26 length representation(a-z).
                // if the current char is 'b'(ASCII value is 98), so b(98)- a(97) = 1. Zero will be considered as 'a'
                if (current.children[c-'a'] == null)
                {
                    return null;
                }
                current = current.children[c - 'a'];
            }
            return current;
        }
    }
}
