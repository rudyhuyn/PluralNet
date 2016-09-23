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
    public class IrishProvider : IPluralProvider
    {
        public PluralTypeEnum ComputePlural(decimal n)
        {
            if (n.IsInt())
            {
                if (n == 1)
                {
                    return PluralTypeEnum.ONE;
                }
                if (n == 2)
                {
                    return PluralTypeEnum.TWO;
                }
                if ((n.IsBetween(3, 6)))
                {
                    return PluralTypeEnum.FEW;
                }
                if ((n.IsBetween(7, 10)))
                {
                    return PluralTypeEnum.MANY;
                }
            }
            return PluralTypeEnum.OTHER;

        }
    }
}
