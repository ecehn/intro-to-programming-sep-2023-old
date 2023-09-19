namespace CSharpNotes.Types;
public class Bannana
{
    [Fact]
    public void CanFormatANAmeAccordingToBusinessRules()
    {
        // We always show names in the LastName, FirstName format.

        //var formatters = new Formatters(); - can be omitted when static is used

        var fullName = Formatters.FormatName("Han", "Solo");

        Assert.Equal("Solo, Han", fullName);
    }
}

// Single Point of Truth - SPOT - HERE IS THE CODE THAT KNOWS THE RULE ABOUT FORMATTING
// A utilities class that does some work for us (Services)
public class Formatters
{
    // Static keyword
    public static string FormatName(string firstName, string lastName)
    {
        return $"{lastName}, {firstName}";
    }
}
