using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    // TODO: finish test
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string email = "test@example.com";

        // Act
        bool isValidEmail = Email.IsValidEmail(email);

        // Assert
        Assert.IsTrue(isValidEmail);
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        string email = "test.example.com";
        bool isValidEmail = Email.IsValidEmail(email);
        Assert.IsFalse(isValidEmail);
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        string email = null;
        bool isValidEmail = Email.IsValidEmail(email);
        Assert.IsFalse(isValidEmail);
    }
}
