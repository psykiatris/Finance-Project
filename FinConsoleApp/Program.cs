
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using Finance.Shared;

//WriteLine("The Main entry for -> Consoles");
 BaseInfo basePatrick = new()
 {
     Apr = 5.0, TermInMonths = 360,Balance = 114000.00, Name = "Patrick", StartDate = new(2024, 4, 1)

 };
 WriteLine($"Account created: {basePatrick.CreateDate}");
WriteLine($"With a balance of: {basePatrick.Balance:C} at {basePatrick.Apr}% over a period of {basePatrick.TermInMonths / 12} years,");
WriteLine($"The payment would be: {Calculate.CalculateAmortozation(basePatrick.Balance,basePatrick.Apr, 360):C}.");
WriteLine();
double pymt =
    Calculate.CalculateAmortozation(basePatrick.Balance, basePatrick.Apr, 360);
WriteLine($"Account #: {basePatrick.AccountNumber}");

