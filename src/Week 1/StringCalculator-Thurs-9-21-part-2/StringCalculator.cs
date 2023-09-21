
namespace StringCalculator;

public class StringCalculator
{
    private readonly ILogger _logger;
    public StringCalculator(ILogger logger)
    {
        _logger = logger;
    }
    public int Add(string numbers)
    {
        int result;
        if (numbers == "")
        {
            result = 0;
        }
        else
        {
            result = numbers.Split(',').Select(int.Parse).Sum();
        }

        return result;
    }
}

public interface ILogger
{
    void Write(string message);
}
