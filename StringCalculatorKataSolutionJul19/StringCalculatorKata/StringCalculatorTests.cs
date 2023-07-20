
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


}
