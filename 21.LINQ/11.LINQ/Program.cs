using System.Collections;

ArrayList numbers = new ArrayList();
numbers.Add(1);
numbers.Add(2);

// Diapazon dəyişəni üçün birbaşa olaraq tip təyin edirik (var istifadə etmək mümkün deyil).
var query = from int n in numbers
            select n * 2;

foreach (var item in query)
    Console.WriteLine(item);

// Delay.
Console.ReadKey();