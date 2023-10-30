using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> inputWords = new List<string> { "level", "deified" };
        // Act
        bool result = Palindrome.IsPalindrome(inputWords);
        // Assert
        Assert.IsTrue(result);
    }

    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> inputWords = new List<string> { "leval" };
        // Act
        bool result = Palindrome.IsPalindrome(inputWords);
        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> inputWords = new List<string> { "level" };
        // Act
        bool result = Palindrome.IsPalindrome(inputWords);
        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> inputWords = new List<string> { "apple" };
        // Act
        bool result = Palindrome.IsPalindrome(inputWords);
        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> inputWords = new List<string> {"LeVeL" };
        // Act
        bool result = Palindrome.IsPalindrome(inputWords);
        // Assert
        Assert.IsTrue(result);
    }
}
