using Huyn.PluralNet;
using System.Globalization;
using Huyn.PluralNet.Interfaces;
using Huyn.PluralNet.Utils;

#if SILVERLIGHT || DESKTOP || PORTABLE
using System.Resources;
#endif

#if WINRT
using Windows.ApplicationModel.Resources;
#endif

namespace Huyn.PluralNet
{
    public static class ResourceLoaderExtension
    {
        private static IPluralProvider _pluralProvider;

#if WINRT
        public static string GetPlural(this ResourceLoader resource, string key, decimal number)
#endif
#if SILVERLIGHT || DESKTOP || PORTABLE
        public static string GetPlural(this ResourceManager resource, string key, decimal number)
#endif  
        {

            if (_pluralProvider == null)
            {
                _pluralProvider = PluralHelper.GetPluralChooser(new CultureInfo(resource.GetString("ResourceLanguage")));
            }
            string selectedSentence = null;
            var pluralType = _pluralProvider.ComputePlural(number);
            try
            {
                switch (pluralType)
                {
                    case PluralTypeEnum.ZERO:
                        selectedSentence = resource.GetString(key + "_Zero");
                        break;
                    case PluralTypeEnum.ONE:
                        selectedSentence = resource.GetString(key + "_One");
                        break;
                    case PluralTypeEnum.OTHER:
                        selectedSentence = resource.GetString(key + "_Other");
                        break;
                    case PluralTypeEnum.TWO:
                        selectedSentence = resource.GetString(key + "_Two");
                        break;
                    case PluralTypeEnum.FEW:
                        selectedSentence = resource.GetString(key + "_Few");
                        break;
                    case PluralTypeEnum.MANY:
                        selectedSentence = resource.GetString(key + "_Many");
                        break;
                }
            }
            catch { }
            return selectedSentence ?? "";
        }

    }
}
