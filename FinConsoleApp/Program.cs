using Boyd.Shared;
using Spectre.Console;  // Type from loggin library?

BaseInfo basePatrick = new()
{
    Apr = 0.05, Balance = 114000, TermInMonths = 360
};
AnsiConsole.WriteLine($"APR is {basePatrick.Apr:P1}");

