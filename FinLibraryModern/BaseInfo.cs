
namespace Finance.Shared;

/*
 * This class obtains basic account information so that
 * calculations can be made and saved, printed to the
 * screen, or output to a text (or .csv) file.
 */
public class BaseInfo
{
    #region Properties for basic information regarding user.

    public readonly DateTime CreateDate; // When object is created. A timestamp
    private DateTime? _periodStartDate = DateTime.Today;    // Initialize it to current date.
    public DateTime? StartDate // When period starts. Input by user
    {
        get { return _periodStartDate; }
        set
        {
            if (value.HasValue)
            {
                {
                    _periodStartDate = value;
                }
            }
        }
}

    private string? _name;

    public string? Name
    {
        get { return _name; }
        set { _name = value; }
    }

    private double _balance;

    public double Balance
    {
        get { return _balance; }
        set { _balance = value; }
    }

    private double _apr;

    public double Apr
    {
        get { return _apr; }
        set { _apr = value; }
    }

    private double _term;

    public double TermInMonths
    {
        get { return _term; }
        set { _term = value; }
    }

    private int _accountNum;

    public int AccountNumber
    {
        get { return _accountNum; }
        set { _accountNum = value; }
    }

    #endregion

    #region Constructors

    public BaseInfo()
    {
        CreateDate = DateTime.Now;
        Name = "AccountHolder";
        Balance = 0;
        AccountNumber = GetHashCode();
        Apr = 0;
        TermInMonths = 1;
    }

    public BaseInfo(double p, double period, double rate = 0.0)
    {
        CreateDate = DateTime.Now;
        Name = "AccountHolder";
        AccountNumber = GetHashCode();
        Balance = p;
        Apr = rate; // Interest rate defaults to zero.
        TermInMonths = period;
    }

    public BaseInfo(string? name, double p,
        double period, double rate = 0.0)
    {
        CreateDate = DateTime.Now;
        Name = name;
        AccountNumber = GetHashCode();
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