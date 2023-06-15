﻿var query = from x in Enumerable.Range(1, 10)
            let innerRange = Enumerable.Range(1, 10)
            from y in innerRange
            select new { X = x, Y = y, Product = x * y };

foreach (var item in query)
    Console.WriteLine("{0} * {1} = {2}", item.X, item.Y, item.Product);

// Delay.
Console.ReadKey();