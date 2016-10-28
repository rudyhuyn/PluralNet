#if WINRT || SILVERLIGHT

using System;
using System.Globalization;

#if WINRT
using Windows.ApplicationModel.Resources;
using Windows.UI.Xaml.Data;
#elif SILVERLIGHT
using System.Windows.Data;
using System.Resources;
#endif

namespace Huyn.PluralNet.Converters
{
    public class PluralConverter : IValueConverter
    {
#if SILVERLIGHT
        public ResourceManager ResourceManager { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (ResourceManager == null)
            {
                throw new NullReferenceException("PluralConverter.ResourceManager can't be null");
            }
#elif WINRT

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var culture = !string.IsNullOrWhiteSpace(language) ? new CultureInfo(language) : null;
#endif
            var key = parameter as string;

            if (string.IsNullOrWhiteSpace(key))
            {
                return string.Empty;
            }

            var number = System.Convert.ToDecimal(value);

#if SILVERLIGHT
            var pluralFormat = ResourceManager.GetPlural(key, number);
#elif WINRT
            var resource = ResourceLoader.GetForCurrentView();
            var pluralFormat = resource.GetPlural(key, number);
#endif

            return string.Format(culture, pluralFormat, number);
        }

#if SILVERLIGHT || DESKTOP
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
#elif WINRT
        public object ConvertBack(object value, Type targetType, object parameter, string language)
#endif
        {
            return null;
        }
    }
}

#endif