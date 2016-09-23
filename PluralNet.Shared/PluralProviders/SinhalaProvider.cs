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
    public class SinhalaProvider : IPluralProvider
    {
        public PluralTypeEnum ComputePlural(decimal n)
        {
            if (n == 0 || n == 1 || n.DigitsAfterDecimal() == 1)
                return PluralTypeEnum.ONE;
            return PluralTypeEnum.OTHER;
        }
    }
}
