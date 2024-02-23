
using Finance.Shared;
using Microsoft.VisualBasic;

double pay = Calculate.AmortizeLoan(114000, 360, 5);
WriteLine($"Your estimated payment is: {pay:C}");
DateTime date = new(2022, 8, 22);
BaseInfo patrick = new(p:114000, period: 360, rate: 5.0);
BaseInfo gloria = new(50000, 60, 7.25);
gloria.StartDate = new(2022, 8, 12);
WriteLine($"Patrick's account was created {patrick.CreateDate}");
WriteLine($"Gloria's loan began on {gloria.StartDate}.");
WriteLine($"Gloria's accpimt was created {gloria.CreateDate}");
WriteLine($"Patrick's loan began {patrick.StartDate}");
