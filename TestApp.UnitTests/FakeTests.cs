using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveStringNumbers_NullInput_ThrowsException()
    {
        // Arrange
        char[]? input = null;

        // Act + Assert
        Assert.That(() => Fake.RemoveStringNumbers(input), Throws.ArgumentException);
    }

    [Test]
    public void Test_RemoveStringNumbers_OnlyDigitsReturnsEmptyArray()
    {
        // Arrange
        char[] input = new char[] { '0', '1', '2', '3' };
        // Act
        char[] result = Fake.RemoveStringNumbers(input);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange
        char[] input = new char[] { '0', '1', '@', 'D' };
        // Act
        char[] result = Fake.RemoveStringNumbers(input);
        // Assert
        Assert.That(result, Is.EqualTo(new char[] { '@', 'D', }));
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[] input = new char[] { '$', 'a', '@', 'D' };
        // Act
        char[] result = Fake.RemoveStringNumbers(input);
        // Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        char[] input = new char[] { };
        // Act
        char[] result = Fake.RemoveStringNumbers(input);
        // Assert
        Assert.That(result, Is.Empty);
    }
}
