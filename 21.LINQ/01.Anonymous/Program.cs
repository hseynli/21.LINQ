var instance = new { Name = "Alex", Age = 27 };

Console.WriteLine("Name = {0}, Age = {1}", instance.Name, instance.Age);

Type type = instance.GetType();

Console.WriteLine(type.ToString());

// Delay.
Console.ReadKey();