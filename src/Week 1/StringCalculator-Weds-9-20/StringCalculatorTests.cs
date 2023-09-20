
using static StringCalculator.StringCalculator;

namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("12", 12)]
    [InlineData("108", 108)]
    public void SingleDigits(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1, 2", 3)]
    [InlineData("108, 2", 110)]
    public void TwoDigits(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1, 2, 3", 6)]
    [InlineData("0, 1, 9", 10)]
    [InlineData("12, 42, 38", 92)]
    public void AnyNumberOfDigits(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1\n2", 3)]
    [InlineData("1\n2,3", 6)]
    [InlineData("1\n2,3\n4\n5", 15)]
    public void CanHaveNewLineDelim(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("//;\n1;2", 3)]
    public void CustomDelimiter(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]

    [InlineData("-1")]
    [InlineData("1,2,3,4,5,6,7,8,900,-300,1000")]
    [InlineData("1,2,3,4,5,6,7,8\n900,-300,1000")]
    [InlineData("//-\n1-2-1")]
    public void NegativeNumbersNotAllowed(string numbers)
    {
        var calculator = new StringCalculator();

        Assert.Throws<NoNegativeNumbersException>(() => calculator.Add(numbers));
    }
}
