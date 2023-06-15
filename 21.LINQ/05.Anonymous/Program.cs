var instance = new
{
    MyDel = new MyDelegate((string @string) => Console.WriteLine(@string))
};

instance.MyDel("Hello world!");

// Delay.
Console.ReadKey();

delegate void MyDelegate(string @string);