using System;
using System.Globalization;
using Xamarin.Forms;

namespace MintPlayer.XamarinForms.Converters
{
    /// <summary>Binding converter that outputs the inverted value of its input.</summary>
    public class InvertConverter : IValueConverter
    {
        /// <summary>Conversion from source to target.</summary>
        /// <param name="value">Source value.</param>
        /// <param name="targetType">Requested type by the binding target.</param>
        /// <param name="parameter">Converter parameter.</param>
        /// <param name="culture">Culture to use for the conversion.</param>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool b)
            {
                return !b;
            }
            else
            {
                throw new ArgumentException($"Value provided to the {nameof(InvertConverter)} must be a bool");
            }
        }

        /// <summary>Conversion from target to source.</summary>
        /// <param name="value">Target value.</param>
        /// <param name="targetType">Requested types by the binding sources.</param>
        /// <param name="parameter">Converter parameter.</param>
        /// <param name="culture">Culture to use for the conversion.</param>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool b)
            {
                return !b;
            }
            else
            {
                throw new ArgumentException($"Value provided to the {nameof(InvertConverter)} must be a bool");
            }
        }
    }
}
