namespace CSharpNotes.Types;
public class DeclaringLocalVariables
{
    [Fact]

    public void ExplicitlyTypedLocalVariable()
    {
        // Type identifier [= value]
        int a = 0;
        System.Int32 b = 2;

        System.String dogName = "Buddy";

        Assert.Equal("Buddy", dogName);

        Assert.Equal(2, b);
        Assert.Equal(0, a);
    }

    [Fact]

    public void ImplicitlyTypedLocalVariablesWithVar()
    {
        // If you are going to initialize the variable, C# already knows the type
        var a = 0; // if there is a literal number w/ no decimal point, it is an int
        var b = 1.0; // A number with a decimal point is inferred to be a double point precision number
        var c = "Cat"; // This is a string.
        var d = 'A'; // this is a char
        var e = true;
        var salary = 80123.23M; // 'M' suffix to change to decimal type

        var rover = new Dog();
    }

    [Fact]

    public void ImplicitlyTypedLocalVariablesWithNew()
    {
        // .NET 5
        Dog rover = new();
    }
}


public class Dog { }
