using Boyd.Shared;


BaseInfo basePatrick = new()
{
    Apr = 0.05, Balance = 114000, TermInMonths = 360
};
WriteLine($"APR is {basePatrick.Apr:P1}");
