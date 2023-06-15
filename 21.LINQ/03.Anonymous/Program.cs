var instance = new { My = new MyClass() };

instance.My.field = 1;
instance.My.Method();

// Delay.
Console.ReadKey();

class MyClass
{
    public int field;

    public void Method()
    {
        Console.WriteLine(field);
    }
}