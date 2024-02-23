
using Finance.Shared;
using Microsoft.VisualBasic;

double pay = Calculate.AmortizeLoan(114000, 360, 5);
WriteLine($"Your estimated payment is: {pay:C}");
DateTime date = new(2022, 8, 22);
BaseInfo patrick = new(114000, 360, 5.0, date);
BaseInfo gloria = new(50000, 60, 7.25);
WriteLine($"Patrick's loan began on {patrick.StartDate}");
WriteLine($"Gloria's account began {gloria.StartDate}");;