using System;
using System.Globalization;
using Xamarin.Forms;

namespace MintPlayer.XamarinForms.Converters
{
    /// <summary>Binding converter that outputs the concatenated string of the input substrings.</summary>
    public class StringConcatConverter : IMultiValueConverter
    {
        /// <summary>Conversion from source to target.</summary>
        /// <param name="values">Source values.</param>
        /// <param name="targetType">Requested type by the binding target.</param>
        /// <param name="parameter">Converter parameter.</param>
        /// <param name="culture">Culture to use for the conversion.</param>
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return string.Join(string.Empty, values);
        }

        /// <summary>Conversion from target to source.</summary>
        /// <param name="value">Target value.</param>
        /// <param name="targetTypes">Requested types by the binding sources.</param>
        /// <param name="parameter">Converter parameter.</param>
        /// <param name="culture">Culture to use for the conversion.</param>
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException($"The {nameof(StringConcatConverter)} can only be used with Mode=OneWay");
        }
    }
}
