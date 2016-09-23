/*
 * Huyn.PluralNet
 * Author  Rudy Huyn (6Studio)
 * License MIT / http://bit.ly/mit-license
 * 
 * Version 1.00
 */

namespace Huyn.PluralNet.Utils
{
    public static class DecimalExtension
    {
        public static bool IsBetween(this decimal number, decimal start, decimal end)
        {
            return start <= number && number <= end;
        }
        public static bool IsBetweenEndNotIncluded(this decimal number, decimal start, decimal end)
        {
            return start <= number && number < end;
        }

        public static bool IsInt(this decimal number)
        {
            return (int)number == number;
        }

        public static uint GetNumberOfDigitsAfterDecimal(this decimal number)
        {
            return (uint)((number - (int)number).ToString()).Length - 2;
        }


        public static long DigitsAfterDecimal(this decimal number)
        {
            try
            {
                //need optimization
                var str = ((number - (int)number).ToString()).Substring(2);
                if (str == "")
                    return 0;
                return long.Parse(str);
            }
            catch
            {
                return 0;
            }
        }
    }
}
