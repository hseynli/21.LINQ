new
{
    My = new MyClass { field = 1 }

}.My.Method();

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