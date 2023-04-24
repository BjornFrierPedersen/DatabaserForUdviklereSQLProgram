using System.Diagnostics;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

var sw = new Stopwatch();
sw.Start();

var dbContext = new SkoleinfoContext(new DbContextOptions<SkoleinfoContext>());
var repository = new Repository(dbContext);

repository.CreateRandomDataset(100);

sw.Stop();
var elapsed = sw.Elapsed.Milliseconds;
Console.WriteLine($"Elapsed miliseconds: {elapsed}");

