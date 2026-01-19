using Xunit;

namespace CalculatorApp.Tests;

/// <summary>
/// Testit StringHelper-luokalle.
/// MALLIVASTAUS OPETTAJALLE
/// </summary>
public class StringHelperTests
{
    #region Reverse Tests

    [Fact]
    public void Reverse_ValidString_ReturnsReversed()
    {
        // Arrange
        StringHelper helper = new StringHelper();
        string input = "hello";
        string expected = "olleh";

        // Act
        string result = helper.Reverse(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Reverse_EmptyString_ReturnsEmpty()
    {
        // Arrange
        StringHelper helper = new StringHelper();
        string input = "";

        // Act
        string result = helper.Reverse(input);

        // Assert
        Assert.Equal("", result);
    }

    [Fact]
    public void Reverse_SingleCharacter_ReturnsSameCharacter()
    {
        // Arrange
        StringHelper helper = new StringHelper();
        string input = "a";

        // Act
        string result = helper.Reverse(input);

        // Assert
        Assert.Equal("a", result);
    }

    #endregion

    #region IsPalindrome Tests

    [Fact]
    public void IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        StringHelper helper = new StringHelper();

        // Act
        bool result = helper.IsPalindrome("racecar");

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_NotPalindrome_ReturnsFalse()
    {
        // Arrange
        StringHelper helper = new StringHelper();

        // Act
        bool result = helper.IsPalindrome("hello");

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPalindrome_EmptyString_ReturnsFalse()
    {
        // Arrange
        StringHelper helper = new StringHelper();

        // Act
        bool result = helper.IsPalindrome("");

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPalindrome_MixedCase_IgnoresCase()
    {
        // Arrange
        StringHelper helper = new StringHelper();

        // Act
        bool result = helper.IsPalindrome("RaceCar");

        // Assert
        Assert.True(result);
    }

    #endregion

    #region CountWords Tests

    [Fact]
    public void CountWords_TwoWords_ReturnsTwo()
    {
        // Arrange
        StringHelper helper = new StringHelper();

        // Act
        int result = helper.CountWords("Hello world");

        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void CountWords_OneWord_ReturnsOne()
    {
        // Arrange
        StringHelper helper = new StringHelper();

        // Act
        int result = helper.CountWords("One");

        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void CountWords_EmptyString_ReturnsZero()
    {
        // Arrange
        StringHelper helper = new StringHelper();

        // Act
        int result = helper.CountWords("");

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void CountWords_OnlySpaces_ReturnsZero()
    {
        // Arrange
        StringHelper helper = new StringHelper();

        // Act
        int result = helper.CountWords("   ");

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void CountWords_MultipleSpacesBetween_CountsCorrectly()
    {
        // Arrange
        StringHelper helper = new StringHelper();

        // Act
        int result = helper.CountWords("Hello    world");

        // Assert
        Assert.Equal(2, result);
    }

    #endregion

    #region Capitalize Tests

    [Fact]
    public void Capitalize_LowercaseWord_CapitalizesFirst()
    {
        // Arrange
        StringHelper helper = new StringHelper();

        // Act
        string result = helper.Capitalize("hello");

        // Assert
        Assert.Equal("Hello", result);
    }

    [Fact]
    public void Capitalize_EmptyString_ReturnsEmpty()
    {
        // Arrange
        StringHelper helper = new StringHelper();

        // Act
        string result = helper.Capitalize("");

        // Assert
        Assert.Equal("", result);
    }

    [Fact]
    public void Capitalize_SingleCharacter_ReturnsUppercase()
    {
        // Arrange
        StringHelper helper = new StringHelper();

        // Act
        string result = helper.Capitalize("a");

        // Assert
        Assert.Equal("A", result);
    }

    [Fact]
    public void Capitalize_AlreadyCapitalized_RemainsCapitalized()
    {
        // Arrange
        StringHelper helper = new StringHelper();

        // Act
        string result = helper.Capitalize("Hello");

        // Assert
        Assert.Equal("Hello", result);
    }

    #endregion
}
