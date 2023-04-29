using System.Diagnostics;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

var sw = new Stopwatch();
sw.Start();

var dbContext = new SkoleinfoContext(new DbContextOptions<SkoleinfoContext>());
var repository = new Repository(dbContext);

Console.WriteLine("How many top level entities (kommuner) do you want to create? - Please beware that the corresponding number of related entities will be created as well");
Console.WriteLine("Number of entities:");

var isInteger =  int.TryParse(Console.ReadLine(), out var amount);
while (!isInteger)
{
    Console.WriteLine("That's not an integer, try again");
    isInteger =  int.TryParse(Console.ReadLine(), out amount);
}

repository.CreateRandomDataset(amount);

sw.Stop();
var elapsed = sw.Elapsed.Milliseconds;
Console.WriteLine($"Elapsed miliseconds: {elapsed}\n\nPress any key to close...");

Console.ReadLine();

