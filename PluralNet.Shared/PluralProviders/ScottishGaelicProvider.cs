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
    public class ScottishGaelicProvider : IPluralProvider
    {
        public PluralTypeEnum ComputePlural(decimal n)
        {
            if (n.IsInt())
            {
                var i = (int)n;
                switch (i)
                {
                    case 1:
                    case 11:
                        return PluralTypeEnum.ONE;
                    case 2:
                    case 12:
                        return PluralTypeEnum.TWO;
                }
                if (i <= 19)
                    return PluralTypeEnum.FEW;
            }
            return PluralTypeEnum.OTHER;
        }
    }
}
