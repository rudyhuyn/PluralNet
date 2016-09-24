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
    public class MalteseProvider : IPluralProvider
    {
        public PluralTypeEnum ComputePlural(decimal n)
        {
            var isInt = n.IsInt();
            if (isInt)
            {
                var i = (int)n;
                if (i == 1)
                {
                    return PluralTypeEnum.ONE;
                }
                if (i == 0 || (i % 100).IsBetween(2, 10))
                {
                    return PluralTypeEnum.FEW;
                }
                if ((i % 100).IsBetween(11, 19))
                {
                    return PluralTypeEnum.MANY;
                }
            }
         
            return PluralTypeEnum.OTHER;

        }
    }
}
