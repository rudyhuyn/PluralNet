__PluralNet__ adds support of pluralization and plural forms to your application. Very easy to use and compatible with RESW and RESX files.

#How to use it?

A Nuget package is available, you can install it from Visual Studio or using the following command line:

```nuget
Install-Package PluralNet
```

#Support plural forms in your resource files

Instead of one entry in your resource files, you must create one entry for each plural forms used by the language (One, Other, Few?, Many?, Zero?, Two?), used the ``_`` symbol to separate the resource name to the plural form id

Example:

English:
* __TimeStampDay_One__     {0} day
* __TimeStampDay_Other__   {0} days

Polish (4 plural forms)
* __TimestampMonth_One__	{0} miesiąc temu
* __TimestampMonth_Few__	{0} miesiące temu
* __TimestampMonth_Many__	{0} miesięcy temu
* __TimestampMonth_Other__	{0} miesiąca temu

In order to use the correct plural rules, the library needs to know the language used by the app and not by the system (for example a polish phone displaying an english application need to use the english rule instead of polish).
To do that, you need to add an extra entry in your RESW file (if not already done by Visual Studio):


* __ResourceLanguage__	fr-FR

# Manage plural forms code-behind

## If you use RESW:

An extension is available to extend the ResourceLoader class, instead of

```csharp
ResourceLoader.GetForCurrentView().GetString("TimeStampDay");
```

you must use:

```csharp
ResourceLoader.GetForCurrentView().GetPlural("TimeStampDay", <NUMBER>);
```

And optionally use string.Format(...) if your string supports formatting.

## If you use RESX:

Instead of 

```csharp
AppResources.TimeStampDay;
```
use:

```csharp
AppResources.ResourceManager.GetPlural("TimeStampDay", <NUMBER>);
```

You can then use string.Format(...) if your string supports formatting.

# XAML
To use pluralization XAML-side, you can use the converter ``PluralConverter``:

```xaml
<TextBlock Text="{x:Bind NumberDays, Converter={StaticResource PluralConverter}, ConverterParameter=TimeStampDay}" />
```

If your localized string uses formatting, ``{0}`` will be automatically replaced by the number.

# Platforms

The library supports:
* UWP
* Silverlight 5
* Windows Phone Silverlight 8.0
* Windows 8 and 8.1 WinRT apps
* Windows Phone 8.1 WinPRT apps
* ASP.Net Core
* .Net Desktop apps (winform, wpf, etc...)
* Xamarin Android and iOS

# Language supported

Afrikaans, Akan, Albanian, Amharic, Arabic, Armenian, Assamese, Asturian, Asu, Azerbaijani, Bambara, Basque, Belarusian, Bemba, Bena, Bengali, Bihari, Bodo, Bosnian, Breton, Bulgarian, Burmese, Catalan, Central Atlas Tamazight, Central Kurdish, Chechen, Cherokee, Chiga, Chinese, Colognian, Cornish, Croatian, Czech, Danish, Divehi, Dutch, Dzongkha, English, Esperanto, Estonian, European Portuguese, Ewe, Faroese, Filipino, Finnish, French, Friulian, Fulah, Galician, Ganda, Georgian, German, Greek, Gujarati, Gun, Hausa, Hawaiian, Hebrew, Hindi, Hungarian, Icelandic, Igbo, Inari Sami, Indonesian, Inuktitut, Irish, Italian, Japanese, Javanese, Jju, Kabuverdianu, Kabyle, Kako, Kalaallisut, Kannada, Kashmiri, Kazakh, Khmer, Korean, Koyraboro Senni, Kurdish, Kyrgyz, Lakota, Langi, Lao, Latvian, Lingala, Lithuanian, Lojban, Lower Sorbian, Lule Sami, Luxembourgish, Macedonian, Machame, Makonde, Malagasy, Malay, Malayalam, Maltese, Manx, Marathi, Masai, Metaʼ, Moldavian, Mongolian, Nahuatl, Nama, Nepali, Ngiemboon, Ngomba, North Ndebele, Northern Sami, Northern Sotho, Norwegian, Norwegian Bokmål, Norwegian Nynorsk, Nyanja, Nyankole, N’Ko, Oriya, Oromo, Ossetic, Papiamento, Pashto, Persian, Polish, Portuguese, Prussian, Punjabi, Romanian, Romansh, Rombo, Root, Russian, Rwa, Saho, Sakha, Samburu, Sami languages [Other], Sango, Scottish Gaelic, Sena, Serbian, Serbo-Croatian, Shambala, Shona, Sichuan Yi, Sinhala, Skolt Sami, Slovak, Slovenian, Soga, Somali, South Ndebele, Southern Kurdish, Southern Sami, Southern Sotho, Spanish, Swahili, Swati, Swedish, Swiss German, Syriac, Tachelhit, Tagalog, Tamil, Telugu, Teso, Thai, Tibetan, Tigre, Tigrinya, Tongan, Tsonga, Tswana, Turkish, Turkmen, Tyap, Ukrainian, Upper Sorbian, Urdu, Uyghur, Uzbek, Venda, Vietnamese, Volapük, Vunjo, Walloon, Walser, Welsh, Western Frisian, Wolof, Xhosa, Yiddish, Yoruba, Zulu


# How to help?

If you detect an issue, want to add a language, don't hesitate to submit a push request!

# more info

http://www.rudyhuyn.com/blog/?p=5341

 
