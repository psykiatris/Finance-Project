
using Finance.Shared;

double pay = Calculate.AmortizeLoan(114000, 5, 360);
WriteLine($"Your estimated payment is: {pay:C}");

BaseInfo patrick = new(150000, 7.375, 360);
WriteLine($"Payment on {patrick.Balance:C} is {Calculate.AmortizeLoan(patrick.Balance, patrick.Apr, patrick.TermInMonths):C}");
WriteLine(patrick.Apr);
