#if WINRT || SILVERLIGHT
using Huyn.PluralNet;
using System;
using System.Globalization;

#if WINRT
using Windows.ApplicationModel.Resources;
using Windows.UI.Xaml.Data;
#endif

#if SILVERLIGHT
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
            var key = parameter as string;
            if (string.IsNullOrWhiteSpace(key))
                return "";
            var number = (decimal)value;
            return string.Format(ResourceManager.GetPlural(key, number),number);
        }
#endif
#if WINRT
        public object Convert(object value, Type targetType, object parameter, string language)
          {
            var key = parameter as string;
            if (string.IsNullOrWhiteSpace(key))
                return "";
            var number = (decimal)value;
            var resource = ResourceLoader.GetForCurrentView();
            return string.Format(resource.GetPlural(key, number),number);
        }
#endif


#if SILVERLIGHT || DESKTOP
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
#endif
#if WINRT
        public object ConvertBack(object value, Type targetType, object parameter, string language)
#endif
        {
            return null;
        }
    }
}
#endif