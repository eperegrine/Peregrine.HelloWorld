namespace Peregrine.HelloWorld;

public class Greeter
{
    private string Prefix { get; }
    private string Postfix { get; }

    public Greeter(string prefix = "Hello, ", string postfix = "!")
    {
        Prefix = prefix;
        Postfix = postfix;
    }

    public string Greet (string msg) => $"{Prefix}{msg}{Postfix}";
}