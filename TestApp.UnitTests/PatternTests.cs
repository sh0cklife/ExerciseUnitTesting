using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    // TODO: finish test
    [Test]
    public void Test_SortInPattern_NullInput_ThrowsException()
    {
        // Arrange
        int[]? inputArray = null;

        // Act + Assert
        Assert.That(() => Pattern.SortInPattern(inputArray), Throws.ArgumentException);
    }

    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        int[] input = new int[] { 1, 2, 1, 3, 4, 10, 12, 15 };
        int[] output = Pattern.SortInPattern(input);
        Assert.That(output, Is.EqualTo(new int[] { 1, 15, 2, 12, 3, 10, 4 }));
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        int[] input = Array.Empty<int>();
        int[] output = Pattern.SortInPattern(input);
        Assert.That(output, Is.Empty);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        int[] input = new int[] { 1 };
        int[] output = Pattern.SortInPattern(input);
        Assert.That(output, Is.EqualTo(input));
    }
}
