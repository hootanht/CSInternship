
using ChangeOperator.Models;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Step1UnitTest
{
    [TestClass]
    public class ChangeOperatorTests
    {
        [TestMethod]
        public void Sum_2DifferentPost_Return8()
        {
            // Arrange
            Post post1 = new Post() { Title = "Post 1", ViewCount = 5 };
            Post post2 = new Post() { Title = "Post 2", ViewCount = 3 };

            // Act
            int result = post1 + post2;

            // Assert
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Sum_2SamePost_Return10()
        {
            // Arrange
            Post post1 = new Post() { Title = "Post 1", ViewCount = 5 };

            // Act
            int result = post1 + post1;

            // Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Sum_2DifferentPostWithNullViewCount_Return0()
        {
            // Arrange
            Post post1 = new Post() { Title = "Post 1" };
            Post post2 = new Post() { Title = "Post 2" };

            // Act
            int result = post1 + post2;

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}
