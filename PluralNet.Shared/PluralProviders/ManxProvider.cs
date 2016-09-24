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
    public class ManxProvider : IPluralProvider
    {
        public PluralTypeEnum ComputePlural(decimal n)
        {
            var isInt = n.IsInt();
            var i = (int)n;
            if (isInt)
            {
                if (i % 10 == 1)
                    return PluralTypeEnum.ONE;
                if (i % 10 == 2)
                    return PluralTypeEnum.TWO;
                if (i % 20 == 0)
                    return PluralTypeEnum.FEW;
                return PluralTypeEnum.OTHER;
            }
            else
            {
                return PluralTypeEnum.MANY;
            }
        }
    }
}
