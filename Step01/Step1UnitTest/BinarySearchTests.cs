
using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Step1UnitTest
{
    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]
        public void Search_Moq10DifferentMemberArray_Return10()
        {
            // Arrange
            int[] moqArray = { 1, 14, 26, 2, 11, 7, 19, 32, 4, 10 };

            // Act
            Array.Sort(moqArray);
            int binarySearchResult = BinarySearch.BinarySearch.Search(moqArray, 10, 0, (0 + moqArray.Length - 1) / 2, moqArray.Length - 1);

            // Assert
            Assert.AreEqual(10, binarySearchResult);
        }

        [TestMethod]
        public void Search_Moq10DifferentMemberArray_ReturnFalse()
        {
            // Arrange
            int[] moqArray = { 1, 14, 26, 2, 11, 7, 19, 32, 4, 10 };

            // Act
            Array.Sort(moqArray);
            int binarySearchResult = BinarySearch.BinarySearch.Search(moqArray, 15, 0, (0 + moqArray.Length - 1) / 2, moqArray.Length - 1);

            // Assert
            Assert.AreNotEqual(15, binarySearchResult);
        }

        [TestMethod]
        public void Search_Moq10DifferentAndSameMemberArray_Return5()
        {
            // Arrange
            int[] moqArray = { 9, 6, 4, 5, 2, 2, 1, 4, 3, 3 };

            // Act
            Array.Sort(moqArray);
            int binarySearchResult = BinarySearch.BinarySearch.Search(moqArray, 5, 0, (0 + moqArray.Length - 1) / 2, moqArray.Length - 1);

            // Assert
            Assert.AreEqual(5, binarySearchResult);
        }
    }
}
