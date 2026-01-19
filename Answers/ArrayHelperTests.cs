using Xunit;

namespace CalculatorApp.Tests;

/// <summary>
/// Testit ArrayHelper-luokalle.
/// MALLIVASTAUS OPETTAJALLE
/// </summary>
public class ArrayHelperTests
{
    #region Sum Tests

    [Fact]
    public void Sum_ValidArray_ReturnsSum()
    {
        // Arrange
        ArrayHelper helper = new ArrayHelper();
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Act
        int result = helper.Sum(numbers);

        // Assert
        Assert.Equal(15, result);
    }

    [Fact]
    public void Sum_EmptyArray_ReturnsZero()
    {
        // Arrange
        ArrayHelper helper = new ArrayHelper();
        int[] numbers = { };

        // Act
        int result = helper.Sum(numbers);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Sum_NullArray_ReturnsZero()
    {
        // Arrange
        ArrayHelper helper = new ArrayHelper();

        // Act
        int result = helper.Sum(null);

        // Assert
        Assert.Equal(0, result);
    }

    #endregion

    #region Average Tests

    [Fact]
    public void Average_ValidArray_ReturnsAverage()
    {
        // Arrange
        ArrayHelper helper = new ArrayHelper();
        int[] numbers = { 2, 4, 6, 8 };

        // Act
        double result = helper.Average(numbers);

        // Assert
        Assert.Equal(5.0, result);
    }

    [Fact]
    public void Average_EmptyArray_ReturnsZero()
    {
        // Arrange
        ArrayHelper helper = new ArrayHelper();
        int[] numbers = { };

        // Act
        double result = helper.Average(numbers);

        // Assert
        Assert.Equal(0.0, result);
    }

    #endregion

    #region FindMax Tests

    [Fact]
    public void FindMax_ValidArray_ReturnsMax()
    {
        // Arrange
        ArrayHelper helper = new ArrayHelper();
        int[] numbers = { 3, 7, 2, 9, 1 };

        // Act
        int result = helper.FindMax(numbers);

        // Assert
        Assert.Equal(9, result);
    }

    [Fact]
    public void FindMax_NegativeNumbers_ReturnsMax()
    {
        // Arrange
        ArrayHelper helper = new ArrayHelper();
        int[] numbers = { -5, -2, -8, -1 };

        // Act
        int result = helper.FindMax(numbers);

        // Assert
        Assert.Equal(-1, result);
    }

    [Fact]
    public void FindMax_EmptyArray_ThrowsException()
    {
        // Arrange
        ArrayHelper helper = new ArrayHelper();
        int[] numbers = { };

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => helper.FindMax(numbers));
    }

    #endregion

    #region FindMin Tests

    [Fact]
    public void FindMin_ValidArray_ReturnsMin()
    {
        // Arrange
        ArrayHelper helper = new ArrayHelper();
        int[] numbers = { 3, 7, 2, 9, 1 };

        // Act
        int result = helper.FindMin(numbers);

        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void FindMin_NegativeNumbers_ReturnsMin()
    {
        // Arrange
        ArrayHelper helper = new ArrayHelper();
        int[] numbers = { -5, -2, -8, -1 };

        // Act
        int result = helper.FindMin(numbers);

        // Assert
        Assert.Equal(-8, result);
    }

    [Fact]
    public void FindMin_EmptyArray_ThrowsException()
    {
        // Arrange
        ArrayHelper helper = new ArrayHelper();
        int[] numbers = { };

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => helper.FindMin(numbers));
    }

    #endregion

    #region Contains Tests

    [Fact]
    public void Contains_ValueExists_ReturnsTrue()
    {
        // Arrange
        ArrayHelper helper = new ArrayHelper();
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Act
        bool result = helper.Contains(numbers, 3);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Contains_ValueDoesNotExist_ReturnsFalse()
    {
        // Arrange
        ArrayHelper helper = new ArrayHelper();
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Act
        bool result = helper.Contains(numbers, 10);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Contains_EmptyArray_ReturnsFalse()
    {
        // Arrange
        ArrayHelper helper = new ArrayHelper();
        int[] numbers = { };

        // Act
        bool result = helper.Contains(numbers, 1);

        // Assert
        Assert.False(result);
    }

    #endregion

    #region Reverse Tests

    [Fact]
    public void Reverse_ValidArray_ReturnsReversed()
    {
        // Arrange
        ArrayHelper helper = new ArrayHelper();
        int[] numbers = { 1, 2, 3, 4, 5 };
        int[] expected = { 5, 4, 3, 2, 1 };

        // Act
        int[] result = helper.Reverse(numbers);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Reverse_EmptyArray_ReturnsEmpty()
    {
        // Arrange
        ArrayHelper helper = new ArrayHelper();
        int[] numbers = { };

        // Act
        int[] result = helper.Reverse(numbers);

        // Assert
        Assert.Empty(result);
    }

    #endregion

    #region GetEvenNumbers Tests

    [Fact]
    public void GetEvenNumbers_MixedArray_ReturnsOnlyEven()
    {
        // Arrange
        ArrayHelper helper = new ArrayHelper();
        int[] numbers = { 1, 2, 3, 4, 5, 6 };
        int[] expected = { 2, 4, 6 };

        // Act
        int[] result = helper.GetEvenNumbers(numbers);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GetEvenNumbers_OnlyOdd_ReturnsEmpty()
    {
        // Arrange
        ArrayHelper helper = new ArrayHelper();
        int[] numbers = { 1, 3, 5, 7 };

        // Act
        int[] result = helper.GetEvenNumbers(numbers);

        // Assert
        Assert.Empty(result);
    }

    #endregion

    #region CountOccurrences Tests

    [Fact]
    public void CountOccurrences_MultipleOccurrences_ReturnsCount()
    {
        // Arrange
        ArrayHelper helper = new ArrayHelper();
        int[] numbers = { 1, 2, 3, 2, 4, 2, 5 };

        // Act
        int result = helper.CountOccurrences(numbers, 2);

        // Assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void CountOccurrences_NoOccurrences_ReturnsZero()
    {
        // Arrange
        ArrayHelper helper = new ArrayHelper();
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Act
        int result = helper.CountOccurrences(numbers, 10);

        // Assert
        Assert.Equal(0, result);
    }

    #endregion

    #region RemoveDuplicates Tests

    [Fact]
    public void RemoveDuplicates_WithDuplicates_ReturnsUnique()
    {
        // Arrange
        ArrayHelper helper = new ArrayHelper();
        int[] numbers = { 1, 2, 2, 3, 3, 3, 4 };
        int[] expected = { 1, 2, 3, 4 };

        // Act
        int[] result = helper.RemoveDuplicates(numbers);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void RemoveDuplicates_NoDuplicates_ReturnsSame()
    {
        // Arrange
        ArrayHelper helper = new ArrayHelper();
        int[] numbers = { 1, 2, 3, 4 };
        int[] expected = { 1, 2, 3, 4 };

        // Act
        int[] result = helper.RemoveDuplicates(numbers);

        // Assert
        Assert.Equal(expected, result);
    }

    #endregion
}
