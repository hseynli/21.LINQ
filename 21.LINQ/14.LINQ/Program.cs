int[] numbers = { 1, 2, 3, 4 };

var query = from x in numbers
            select new Result(x, x * 2);

numbers[0] = 777; // Yazılan sorğu foreach dövrünün dəyişəninə müraciət zamanı işə düşəcəkdir.

foreach (var item in query)
    Console.WriteLine("Input = {0}, \t Output = {1}", item.Input, item.Output);

// Delay.
Console.ReadKey();

public class Result
{
    public Result(int input, int output)
    {
        Input = input;
        Output = output;
    }

    public int Input { get; set; }
    public int Output { get; set; }
}