// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using CodeChallenge2023;

var challenge = new Challenge();
var solution = new Solution();

Console.WriteLine("Running challenge code");
var stopwatchChallenge = new Stopwatch();
stopwatchChallenge.Start();
var sumChallenge = await challenge.GetBmi();
stopwatchChallenge.Stop();

Console.WriteLine("Running solution code");
var stopwatchSolution = new Stopwatch();
stopwatchSolution.Start();
var sumSolution = await solution.GetBmi();
stopwatchSolution.Stop();

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("------RESULTS------");
Console.WriteLine($"Initial calculation of BMI resulted in {sumChallenge} and took {stopwatchChallenge.ElapsedMilliseconds}ms");
Console.WriteLine("---------");
Console.WriteLine($"Finetuned calculation of BMI resulted in {sumSolution} and took {stopwatchSolution.ElapsedMilliseconds}ms");
Console.WriteLine("---------");