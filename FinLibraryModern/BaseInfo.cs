
namespace Finance.Shared;
/*
 * This class obtains basic account information so that
 * calculations can be made and saved, printed to the
 * screen, or output to a text (or .csv) file.
 */
public class BaseInfo
{
    #region Fields for basic information regarding user.

    public DateTime StartDate;
    public string? Name;
    public double Balance;
    public double Apr;
    public double TermInMonths;
    public int AccountNumber;

    #endregion

    #region Constructors

    public BaseInfo()
    {
        StartDate = DateTime.Today;
        Name = "AccountHolder";
        Balance = 0;
        AccountNumber = 0;
        Apr = 0;
        TermInMonths = 1;

    }

    public BaseInfo(double p, double period, double rate = 0.0)
    {
        
        StartDate = DateTime.Today;
        Name = "AccountHolder";
        AccountNumber = 0;
        Balance = p;
        Apr = rate;     // Interest rate defaults to zero.
        TermInMonths = period;
    }

    public BaseInfo(string? name, int account, double p,
        double period, double rate = 0.0)
    {
        StartDate = DateTime.Today;
        Name = name;
        AccountNumber = account;
        Balance = p;
        TermInMonths = period;
        Apr = rate;
    }

    #endregion

    #region Methods to set and get base account info

    private int GetAccountNumber()
    {
        return AccountNumber;
    }

    #endregion
}