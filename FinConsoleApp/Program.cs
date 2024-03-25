
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using Finance.Shared;

//WriteLine("The Main entry for -> Consoles");
 BaseInfo basePatrick = new()
 {
     Apr = 5.0, Balance = 114000.00, Name = "Patrick", StartDate = new(2024, 4, 1)

 };
 WriteLine($"Account created: {basePatrick.CreateDate}");
WriteLine($"Start date for loan is {basePatrick.StartDate:d} at {basePatrick.Apr:P1} with a balance of {basePatrick.Balance:C}");
WriteLine($"The amortized payment would be: {Calculate.CalculateAmortozation(basePatrick.Balance,basePatrick.Apr, 360):C}.");
