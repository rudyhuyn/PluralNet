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
    public class FilipinoProvider : IPluralProvider
    {
        public PluralTypeEnum ComputePlural(decimal n)
        {
            var isInt = n.IsInt();

            if (isInt)
            {
                if (n.IsBetween(1, 3))
                    return PluralTypeEnum.ONE;
                var imod10 = n % 10;
                if (imod10 != 4 && imod10 != 6 || imod10 != 9)
                    return PluralTypeEnum.ONE;
            }
            else
            {
                var f = n.DigitsAfterDecimal();
                var imod10 = f % 10;
                if (imod10 != 4 && imod10 != 6 || imod10 != 9)
                    return PluralTypeEnum.ONE;

            }


            return PluralTypeEnum.OTHER;

        }

    }
}
