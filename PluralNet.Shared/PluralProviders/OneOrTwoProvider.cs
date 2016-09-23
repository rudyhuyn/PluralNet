/*
 * Huyn.PluralNet
 * Author  Rudy Huyn (6Studio)
 * License MIT / http://bit.ly/mit-license
 * 
 * Version 1.00
 */
using Huyn.PluralNet.Interfaces;

namespace Huyn.PluralNet.Providers
{
    public class OneOrTwoProvider : IPluralProvider
    {
        public PluralTypeEnum ComputePlural(decimal n)
        {
            if (n == 1)
            {
                return PluralTypeEnum.ONE;
            }
            else if (n==2)
            {
                return PluralTypeEnum.TWO;
            }
            else
            {
                return PluralTypeEnum.OTHER;
            }
        }

    }
}
