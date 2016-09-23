/*
 * Huyn.PluralNet
 * Author  Rudy Huyn (6Studio)
 * License MIT / http://bit.ly/mit-license
 * 
 * Version 1.00
 */
using Huyn.PluralNet.Utils;
using Huyn.PluralNet.Interfaces;

namespace Huyn.PluralNet
{
    public class LithuanianProvider : IPluralProvider
    {
        public PluralTypeEnum ComputePlural(decimal n)
        {
            if ((n % 10).IsBetween(2, 9) && !(n % 100).IsBetween(11, 19))
            {
                return PluralTypeEnum.FEW;
            }
            if ((n % 10) == 1 && !(n % 100).IsBetween(11, 19))
            {
                return PluralTypeEnum.ONE;
            }
            if (n.GetNumberOfDigitsAfterDecimal() != 0)
                return PluralTypeEnum.MANY;
            return PluralTypeEnum.OTHER;

        }
    }
}
