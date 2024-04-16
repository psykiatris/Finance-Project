using System.Runtime.CompilerServices;

namespace Boyd.Shared;

public class Calculate
{
    public static double CalculateAmortozation(double p, double rate,
        double periods)
    {
        double moInt = (rate == 0) ? 0.0 : (rate / (12 * 100));

        double payments = (moInt == 0) ? (p / periods) : (p * (moInt / (1 - (Math.Pow(1 / (1 + moInt), periods)))));


        return payments;


    }

}

