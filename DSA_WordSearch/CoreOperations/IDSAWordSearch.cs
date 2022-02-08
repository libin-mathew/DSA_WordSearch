

namespace DSA_WordSearch.CoreOperations
{
    /// <summary>
    /// Core Operations
    /// </summary>
    public interface IDSAWordSearch
    {
        void Insert(string word);
        bool Search(string word);
        bool FindStartWith(string word);
        public Node? FindNode(string word);
    }
}
