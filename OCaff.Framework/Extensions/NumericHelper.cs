namespace OCaff.Framework.Extensions
{
    /// <summary>
    /// Helper/extension class for added <see cref="int"/> functionality.
    /// </summary>
    public static class NumericHelper
    {
        /// <summary>
        /// Compares the value to specified value.
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        public static int Compare(this int value1, int value2)
        {
            if (value1 > value2)
                return 1;

            if (value1 < value2)
                return -1;

            return 0;
        }

        /// <summary>
        /// Determines whether the value is between the minimum and maximum value.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="minimumValue"></param>
        /// <param name="maximumValue"></param>
        /// <returns></returns>
        public static bool Between(this int value, int minimumValue, int maximumValue)
        {
            return minimumValue <= value && value <= maximumValue;
        }

        /// <summary>
        /// Returns the value or the minimum whichever is greater.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="minimumValue"></param>
        /// <returns></returns>
        public static int Minimum(this int value, int minimumValue)
        {
            return value < minimumValue ? minimumValue : value;
        }

        /// <summary>
        /// Returns the value or the maximum value whichever is less.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="maximumValue"></param>
        /// <returns></returns>
        public static int Maximum(this int value, int maximumValue)
        {
            return value > maximumValue ? maximumValue : value;
        }

        /// <summary>
        /// Returns the value or the minimum whichever is greater.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="minimumValue"></param>
        /// <returns></returns>
        public static double Minimum(this double value, double minimumValue)
        {
            return value < minimumValue ? minimumValue : value;
        }
    }
}