Console.OutputEncoding = System.Text.Encoding.UTF8;

int[] numbers = { 1, 2, 3, 4 };

var query = from x in numbers
            where x % 2 == 0
            select x * 2;

foreach (var item in query)
    Console.WriteLine(item);

// Delay.
Console.ReadKey();

public static class MySet
{
    public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
        Console.WriteLine("Custom yazılmış Where metodu.");
        return Enumerable.Where(source, predicate);
    }

    public static IEnumerable<R> Select<T, R>(this IEnumerable<T> source, Func<T, R> selector)
    {
        Console.WriteLine("Custom yazılmış Select metodu.");
        return Enumerable.Select(source, selector);
    }
}