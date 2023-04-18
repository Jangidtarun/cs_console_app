Console.WriteLine("what is your name?");
var name = Console.ReadLine();
var currentdate = DateTime.Now;
Console.WriteLine($"Hello, {name}, on {currentdate:d} at {currentdate:t}.");
Console.Write($"Press any key to exit...");
Console.ReadKey(true);