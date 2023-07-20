
namespace StringCalculatorKata;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        // Given 
        var calculator = new StringCalculator(); // Says you know what this is, implicit typing

        // When
        var result= calculator.Add("");
        // Result
        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("2", 2)]
    [InlineData("108", 108)]

    public void SingleDigit(string numbers, int expected)
    {
        // Given 
        var calculator = new StringCalculator(); // Says you know what this is, implicit typing

        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1, 2", 3)]
    [InlineData("3, 3", 6)]
    [InlineData("8, 2", 10)]
    [InlineData("10, 2", 12)]

    [InlineData("108, 200", 308)]
    public void TwoDigits(string numbers, int expected)
    {
        var calculator = new StringCalculator(); // Says you know what this is, implicit typing

        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData("1, 2, 3", 6)]
    public void ArbitraryNumbers(string numbers, int expected)
    {
        var calculator = new StringCalculator(); // Says you know what this is, implicit typing

        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1\n 2\n 3", 6)]
    [InlineData("1\n 2, 3", 6)]

    public void NewLineSeparators(string numbers, int expected)
    {
        var calculator = new StringCalculator(); // Says you know what this is, implicit typing

        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);
    }

    [Theory(Skip ="Not ready yet")]
    [InlineData("//X")]
    [InlineData("1\n 2, 3", 6)]

    public void CustomDelimeter(string numbers, int expected)
    {
        var calculator = new StringCalculator(); // Says you know what this is, implicit typing

        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);
    }


}
