using DSA_WordSearch.CoreOperations;
using DSA_WordSearch.Helpers;
using DSA_WordSearch.UserInputOutOperations;
using NUnit.Framework;
using System;
using System.IO;

namespace DSA_WordSearch_Test
{
    public class DataStructureTest
    {
        private UserInputOperations? _inputOperations;
        private DSAWordSearch? _WordSearch;

        [SetUp]
        public void Setup()
        {
            _inputOperations = new UserInputOperations();
            _WordSearch = new DSAWordSearch();
        }

        #region Helper Method Test Cases
        [Test]
        public void ConvertToInteger_Negative()
        {
            var input = "NaN";
            var output = input.ConvertToInteger();
            Assert.AreEqual(output, 0);
        }
        [Test]
        public void ConvertToInteger_Positive()
        {
            var input = "20";
            var output = input.ConvertToInteger();
            Assert.AreEqual(output, 20);
        }
        #endregion

        #region Input Output Related Tests
        [Test]
        public void PrintMessageToScreen()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            var message = "Enter a Number";
            _inputOperations.PrintMessageToScreen(message);
            // Console.WriteLine add new line character along with text
            Assert.AreEqual(message + System.Environment.NewLine, stringWriter.ToString());
        }
        [Test]
        public void ReadInputFromUser()
        {
            var stringReader = new StringReader("7");
            Console.SetIn(stringReader);
            var message = _inputOperations.ReadInputFromUser();
            Assert.AreEqual("7", message);
        }
        #endregion

        #region Data structure Test
        [Test]
        public void TestWordInsertAndSearch()
        {
            _WordSearch.Insert("test");
            _WordSearch.Insert("mobile");
            _WordSearch.Insert("car");
            Assert.IsTrue(_WordSearch.Search("test"));
        }
        [Test]
        public void TestWordInsertAndPrefixSearch()
        {
            _WordSearch.Insert("test");
            _WordSearch.Insert("app");
            _WordSearch.Insert("car");
            _WordSearch.Insert("apple");
            Assert.IsTrue(_WordSearch.FindStartWith("app"));
        }
        [Test]
        public void TestFindNode()
        {
            _WordSearch.Insert("test");
            _WordSearch.Insert("app");
            _WordSearch.Insert("car");
            _WordSearch.Insert("apple");
            var node = _WordSearch.FindNode("app");
            Assert.IsTrue(node != null);
        }
        [Test]
        public void TestFindNodeAsWord()
        {
            _WordSearch.Insert("test");
            _WordSearch.Insert("app");
            _WordSearch.Insert("car");
            _WordSearch.Insert("apple");
            var node = _WordSearch.FindNode("app");
            Assert.IsTrue(node != null && node.isEndOfTheWord);
        }
        #endregion
    }
}