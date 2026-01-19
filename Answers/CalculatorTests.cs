using Xunit;

namespace CalculatorApp.Tests;

/// <summary>
/// Testit Calculator-luokalle.
/// MALLIVASTAUS OPETTAJALLE
/// </summary>
public class CalculatorTests
{
    #region Add Tests

    [Fact]
    public void Add_PositiveNumbers_ReturnsSum()
    {
        // Arrange
        Calculator calculator = new Calculator();
        int a = 5;
        int b = 3;
        int expected = 8;

        // Act
        int result = calculator.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Add_NegativeNumbers_ReturnsSum()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Add(-5, -3);

        // Assert
        Assert.Equal(-8, result);
    }

    [Fact]
    public void Add_WithZero_ReturnsOtherNumber()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Add(5, 0);

        // Assert
        Assert.Equal(5, result);
    }

    #endregion

    #region Subtract Tests

    [Fact]
    public void Subtract_PositiveNumbers_ReturnsDifference()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Subtract(10, 3);

        // Assert
        Assert.Equal(7, result);
    }

    [Fact]
    public void Subtract_ResultIsNegative_ReturnsNegativeNumber()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Subtract(3, 10);

        // Assert
        Assert.Equal(-7, result);
    }

    [Fact]
    public void Subtract_WithZero_ReturnsFirstNumber()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Subtract(5, 0);

        // Assert
        Assert.Equal(5, result);
    }

    #endregion

    #region Multiply Tests

    [Fact]
    public void Multiply_PositiveNumbers_ReturnsProduct()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Multiply(5, 3);

        // Assert
        Assert.Equal(15, result);
    }

    [Fact]
    public void Multiply_ByZero_ReturnsZero()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Multiply(5, 0);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Multiply_NegativeAndPositive_ReturnsNegative()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Multiply(-5, 3);

        // Assert
        Assert.Equal(-15, result);
    }

    #endregion

    #region Divide Tests

    [Fact]
    public void Divide_PositiveNumbers_ReturnsQuotient()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        double result = calculator.Divide(10, 2);

        // Assert
        Assert.Equal(5.0, result);
    }

    [Fact]
    public void Divide_ResultIsDecimal_ReturnsDecimal()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        double result = calculator.Divide(10, 3);

        // Assert
        Assert.Equal(3.333333, result, 5); // 5 desimaalin tarkkuus
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
    }

    #endregion

    #region IsEven Tests

    [Fact]
    public void IsEven_EvenNumber_ReturnsTrue()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        bool result = calculator.IsEven(4);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsEven_OddNumber_ReturnsFalse()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        bool result = calculator.IsEven(5);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsEven_Zero_ReturnsTrue()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        bool result = calculator.IsEven(0);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsEven_NegativeEven_ReturnsTrue()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        bool result = calculator.IsEven(-4);

        // Assert
        Assert.True(result);
    }

    #endregion

    #region Square Tests

    [Fact]
    public void Square_PositiveNumber_ReturnsSquare()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Square(5);

        // Assert
        Assert.Equal(25, result);
    }

    [Fact]
    public void Square_Zero_ReturnsZero()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Square(0);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Square_NegativeNumber_ReturnsPositiveSquare()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Square(-5);

        // Assert
        Assert.Equal(25, result);
    }

    #endregion

    #region Max Tests

    [Fact]
    public void Max_FirstIsLarger_ReturnsFirst()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Max(10, 5);

        // Assert
        Assert.Equal(10, result);
    }

    [Fact]
    public void Max_SecondIsLarger_ReturnsSecond()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Max(5, 10);

        // Assert
        Assert.Equal(10, result);
    }

    [Fact]
    public void Max_BothEqual_ReturnsEither()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Max(5, 5);

        // Assert
        Assert.Equal(5, result);
    }

    #endregion
}
