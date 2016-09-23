/*
 * Huyn.PluralNet
 * Author  Rudy Huyn (6Studio)
 * License MIT / http://bit.ly/mit-license
 * 
 * Version 1.00
 */
using Huyn.PluralNet.Interfaces;
using Huyn.PluralNet.Utils;

namespace Huyn.PluralNet.Providers
{
    public class CentralAtlasTamazightProvider : IPluralProvider
    {
        public PluralTypeEnum ComputePlural(decimal n)
        {
            if (n == 0 || n == 1 || (n.IsInt() && n.IsBetween(11, 99)))
            {
                return PluralTypeEnum.ONE;
            }
            return PluralTypeEnum.OTHER;
        }
    }
}
