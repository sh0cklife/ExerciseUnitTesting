using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_NumberLowerThanTwo()
    {
        // Arrange
        long lowerThanTwo = -2;
        // Act + Assert
        Assert.That(() => PrimeFactor.FindLargestPrimeFactor(lowerThanTwo), Throws.ArgumentException);
        
    }

    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        long primeNumber = 7;
        long result = PrimeFactor.FindLargestPrimeFactor(primeNumber);
        Assert.That(result, Is.EqualTo(7));
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        long primeNumber = 1000000000000;
        long result = PrimeFactor.FindLargestPrimeFactor(primeNumber);
        Assert.That(result, Is.EqualTo(5));
    }
    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumberWithoutZeros()
    {
        long primeNumber = 123456789123456789;
        long result = PrimeFactor.FindLargestPrimeFactor(primeNumber);
        Assert.That(result, Is.EqualTo(52579));
    }
}
