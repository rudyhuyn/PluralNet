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
    public class SlovenianProvider : IPluralProvider
    {
        public PluralTypeEnum ComputePlural(decimal n)
        {
            var isInt = n.IsInt();
            if (isInt)
            {
                switch ((int)n)
                {
                    case 1:
                        return PluralTypeEnum.ONE;
                    case 2:
                        return PluralTypeEnum.TWO;
                    case 3:
                    case 4:
                        return PluralTypeEnum.TWO;
                }

                return PluralTypeEnum.OTHER;
            }
            else
            {
                return PluralTypeEnum.FEW;
            }
        }
    }
}
