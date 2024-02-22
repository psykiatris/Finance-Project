using System.Reflection;

namespace Finance.Shared;

public class BaseInfo
{
    #region Fields for basic information regarding user.

    public DateTime StartDate;
    public double Balance;
    public double Apr;
    public double TermInMonths;

    #endregion

    #region Constructors

    public BaseInfo()
    {
    }

    public BaseInfo(double p, double rate, double periods)
    {
        StartDate = DateTime.Today;
        Balance = p;
        Apr = rate;
        TermInMonths = periods;
    }

    #endregion
}