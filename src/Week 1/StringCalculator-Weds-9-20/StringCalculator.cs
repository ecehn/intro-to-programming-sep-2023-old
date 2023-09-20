
namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {

        if (numbers == "") { return 0; }
        GuardAgainstNegativeNumbers(numbers);
        var (delimiters, processedNumbers) = ProcessNumbers(numbers);
        return processedNumbers.Split(delimiters.ToArray()).Select(int.Parse).Sum();

    }
    private static void GuardAgainstNegativeNumbers(string numbers)
    {
        if (numbers.Contains('-'))
        {
            throw new NoNegativeNumbersException();
        }
    }

    private (char[], string) ProcessNumbers(string numbers)
    {
        var delimiters = new List<char>
        {
            ',',
            '\n'
        };
        if (numbers.StartsWith("//"))
        {
            var newDelimiter = numbers.Substring(2, 1);
            numbers = numbers.Substring(4);
            delimiters.Add(char.Parse(newDelimiter));

        }
        return (delimiters.ToArray<char>(), numbers);
    }

    public class NoNegativeNumbersException : ArgumentOutOfRangeException { };
}
