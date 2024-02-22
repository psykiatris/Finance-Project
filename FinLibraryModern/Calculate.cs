namespace Finance.Shared;

/*
 * This class provides formulas to calculate interest for
 * payments or savings, outputting data in grid or to screen
 * or file. This class does not have instances.
 */
public class Calculate
{
    public static double AmortizeLoan(double p, double periods, double rate = 0)
    {
        double moInt;
        moInt = (rate == 0) ? 0.0 : (rate / (12 * 100));

        return (moInt == 0) ? (p / periods) : (p * (moInt / (1 - (Math.Pow(1 / (1 + moInt), periods)))));


    }

    public static double CalculateSavings(double p, double rate, double period)
    {
        // TODO:    Develop method for calculating APY!
        double estimate = 0;
        return estimate;
    }

}