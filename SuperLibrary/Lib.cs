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
                else { return 0.0; }
            }
            catch (ArgumentException e)
            {
                throw new ArgumentException(e.StackTrace);
            }
          
        }
    }
}
