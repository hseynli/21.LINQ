﻿int[] numbers = { 1, 2, 3, 4 };

var query = from x in numbers
            select new { Input = x, Output = x * 2 };

foreach (var item in query)
    Console.WriteLine("Input = {0}, \t Output = {1}", item.Input, item.Output);

// Delay.
Console.ReadKey();