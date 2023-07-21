
namespace StringCalculatorKata;
// July 20th

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

    [Fact]
    public void OneReturnsOne()
    {
        var calculator = new StringCalculator(); // Says you know what this is, implicit typing

        // When
        var result = calculator.Add("1");
        // Result
        Assert.Equal(1, result);
    }
    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(3, "3")]
    [InlineData(4, "4")]

    public void SingleDigitsReturn(int expected, string number)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(number);

        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData(2, "1, 1")]
    [InlineData(5, "2, 3")]
    [InlineData(7, "3, 4")]
    [InlineData(11, "5, 6")]
    public void AddTwoDigits(int expected, string number)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(number);
        Assert.Equal(expected, result);

    }

    [Theory]
    [InlineData(57, "3, 4, 47, 1, 2")]
    [InlineData(106, "7, 6, 93")]
    public void AddArbitraryDigits(int expected, string number)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(number);
        Assert.Equal(expected, result);

    }

    [Theory]
    [InlineData(8, "3\n2,3")]
    [InlineData(5, "3\n2")]
    public void HandleNewLines(int expected, string number)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(number);
        Assert.Equal(expected, result);

    }


}
