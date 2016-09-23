/*
 * Huyn.PluralNet
 * Author  Rudy Huyn (6Studio)
 * License MIT / http://bit.ly/mit-license
 * 
 * Version 1.00
 */

using Huyn.PluralNet.Utils;
using Huyn.PluralNet.Interfaces;


namespace Huyn.PluralNet.Providers
{
    public class PolishProvider : IPluralProvider
    {
        public PluralTypeEnum ComputePlural(decimal n)
        {
            if ((n % 10).IsBetween(2, 4) && !(n % 100).IsBetween(12, 14))
            {
                return PluralTypeEnum.FEW;
            }
            if (n != 1 && (n % 10).IsBetween(0, 1) ||
                (n % 10).IsBetween(5, 9) ||
                (n % 100).IsBetween(12, 14))
            {
                return PluralTypeEnum.MANY;
            }
            if (n == 1)
            {
                return PluralTypeEnum.ONE;
            }
            return PluralTypeEnum.OTHER;
        }
    }
}
