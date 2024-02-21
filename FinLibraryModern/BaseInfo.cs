using System.Reflection;

namespace Finance.Shared;

public class BaseInfo
{
    public DateTime StartDate;
    public double Balance;
    public double Apr;
    public double TermInMonths;

    public BaseInfo() {}

    
    public BaseInfo(double p, double rate,double periods)
    {
        StartDate = DateTime.Now;
        Balance = p;
        Apr = rate;
        TermInMonths = periods;
    }
    



}