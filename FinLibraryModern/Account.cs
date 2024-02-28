namespace Finance.Shared;

public class Account
{
    public decimal Balance { get; set; }
    public int AccountNumber { get; set; }
    public decimal TerInMonths { get; set; }
    public decimal InterestRate { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime AccountOpenDate;


}

public class CreditCardAccount : Account
{
    /* For short-term (2 years or less) loans & credit
     cards, etc. in 3-month increments up to 24 months.*/

}

public class MortgageAccount : Account
{
    /* For long-term real estate with terms either
     15-yr (180 months), or 30-yr (360 months).
     May include HELOCs (20 yr or 240 months)
     */
}

public class MidTermAccount : Account
{
    /* Mid-term loans, such as auto loans (36 months or 3
     years, 48 months or 4 years, 60 months or 5 years, 7
     years or 72 months). IOnclues personal lines of credit.
     */
}