
using System;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Step1UnitTest
{
    [TestClass]
    public class BubbleSortTests
    {
        [TestMethod]
        public void Sort_Moq10DifferentMemberArray_ReturnMoqSortedArray()
        {
            // Arrange
            int[] moqArray = new int[] { 1, 20, 13, 4, 15, 46, 7, 48, 9, 10 };
            int[]? result = null;

            // Act
            result = BubbleSort.BubbleSort.Sort(moqArray);

            // Assert
            Array.Sort(moqArray.ToArray());
            CollectionAssert.AreEqual(moqArray, result);
        }

        public void Sort_Moq30DifferentAndSameMemberArray_ReturnMoqSortedArray()
        {
            // Arrange
            int[] moqArray = new int[] { 1, 20, 13, 4, 15, 46, 7, 48, 9, 10,
                                         1, 20, 13, 4, 15, 46, 7, 48, 9, 10,
                                         1, 20, 13, 4, 15, 46, 7, 48, 9, 10,
                                         1, 20, 13, 4, 15, 46, 7, 48, 9, 10 };
            int[]? result = null;

            // Act
            result = BubbleSort.BubbleSort.Sort(moqArray);

            // Assert
            Array.Sort(moqArray.ToArray());
            CollectionAssert.AreEqual(moqArray, result);
        }
    }
}
