using System;
using System.Globalization;
using Xamarin.Forms;

namespace MintPlayer.XamarinForms.Converters
{
    /// <summary>
    /// Binding converter that outputs the natural logarithm of the input.
    /// For logarithms with another base, use Ln(x) / Ln(b).
    /// </summary>
    public class LnConverter : IValueConverter
    {
        /// <summary>Conversion from source to target.</summary>
        /// <param name="value">Source value.</param>
        /// <param name="targetType">Requested type by the binding target.</param>
        /// <param name="parameter">Converter parameter.</param>
        /// <param name="culture">Culture to use for the conversion.</param>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                var d = System.Convert.ToDouble(value);
                return System.Math.Log(d);
            }
            catch (FormatException ex)
            {
                throw new ArgumentException("Value must be a double", ex);
            }
        }

        /// <summary>Conversion from target to source.</summary>
        /// <param name="value">Target value.</param>
        /// <param name="targetType">Requested types by the binding sources.</param>
        /// <param name="parameter">Converter parameter.</param>
        /// <param name="culture">Culture to use for the conversion.</param>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                var d = System.Convert.ToDouble(value);
                return System.Math.Exp(d);
            }
            catch (FormatException ex)
            {
                throw new ArgumentException("Value must be a double", ex);
            }
        }
    }
}
