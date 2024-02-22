
using Finance.Shared;

double pay = Calculate.AmortizeLoan(114000, 360, 5);
WriteLine($"Your estimated payment is: {pay:C}");

BaseInfo patrick = new(150000, 360, 7.375);
WriteLine($"Payment on {patrick.Balance:C} is {Calculate.AmortizeLoan(patrick.Balance, patrick.TermInMonths, patrick.Apr):C}");
WriteLine($"APR: {patrick.Apr}%");