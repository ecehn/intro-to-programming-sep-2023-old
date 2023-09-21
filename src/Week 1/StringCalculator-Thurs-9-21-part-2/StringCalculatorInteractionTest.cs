namespace StringCalculator;
public class StringCalculatorInteractionTests
{
    private readonly StringCalculator _calculator;
    public StringCalculatorInteractionTests()
    {
        _calculator = new StringCalculator();
    }
    [Fact]
    public void ResultsAreWrittenToALogger()
    {
        _calculator.Add("9");



        // THEN??? What am I going to assert on?

    }
}