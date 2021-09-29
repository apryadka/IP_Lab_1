using System;

namespace SuperLibrary
{
    public class Lib
    {
        /// <summary>
        /// converts a value in kilograms to tons.
        /// </summary>
        /// <param name="kilogram">number of kilograms</param>
        /// <returns>number of tons</returns>
        public static double ConvertKilogramToTonne(double kilogram)
        {
            try
            {
                if (kilogram > 0.0)
                {
                    return Convert.ToDouble(kilogram / 1000);
                }
                return 0.0;
            }
            catch (ArgumentException e)
            {
                throw new ArgumentException(e.StackTrace);
            }
          
        }

        /// <summary>
        /// Summ(n,a)
        /// </summary>
        /// <param name="n">the number of members of the Summ</param>
        /// <param name="a">argument of the Summ function</param>
        /// <returns>returns the sum of the series</returns>
        public static double Summ(int n, double a)
        {
            try
            {
                double result = 0.0;
                if (n > 0.0 && a > 0.0)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        result += 1 / Math.Pow(a, 2 * i - 2);
                    }
                }
                return result;
            }
            catch (ArgumentException e)
            {
                throw new ArgumentException(e.StackTrace);
            }
        }

    }
}
