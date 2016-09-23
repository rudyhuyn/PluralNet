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
    public class CroatProvider : IPluralProvider
    {
        public PluralTypeEnum ComputePlural(decimal n)
        {
            if (n.IsInt())
            {
                var integer = (int)n;
                if (integer % 10 == 1 && integer % 100 != 11)
                {
                    return PluralTypeEnum.ONE;
                }
                if ((integer % 10).IsBetween(2, 4) && !(integer % 100).IsBetween(12, 14))
                {
                    return PluralTypeEnum.FEW;
                }
            }
            var f = n.DigitsAfterDecimal();
            if (f % 10 == 1 && f % 100 != 11)
            {
                return PluralTypeEnum.ONE;
            }

            if ((f % 10).IsBetween(2, 4) && !(f % 100).IsBetween(12, 14))
            {
                return PluralTypeEnum.FEW;
            }

            return PluralTypeEnum.OTHER;
        }
    }
}
