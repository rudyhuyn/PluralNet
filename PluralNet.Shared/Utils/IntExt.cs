/*
 * Huyn.PluralNet
 * Author  Rudy Huyn (6Studio)
 * License MIT / http://bit.ly/mit-license
 * 
 * Version 1.00
 */

namespace Huyn.PluralNet.Utils
{
    public static class IntExtension
    {
        public static bool IsBetween(this int number, int start, int end)
        {
            return start <= number && number <= end;
        }
        public static bool IsBetweenEndNotIncluded(this int number, int start, int end)
        {
            return start <= number && number < end;
        }

        public static bool IsBetween(this long number, long start, long end)
        {
            return start <= number && number <= end;
        }
        public static bool IsBetweenEndNotIncluded(this long number, long start, long end)
        {
            return start <= number && number < end;
        }


    }
}
