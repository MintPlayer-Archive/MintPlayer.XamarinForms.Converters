using System;
using System.Globalization;
using Xamarin.Forms;

namespace MintPlayer.XamarinForms.Converters
{
    /// <summary>Binding converter that outputs the tangent of the input.</summary>
    public class TangentConverter : IValueConverter
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
                return System.Math.Tan(d);
            }
            catch (FormatException ex)
            {
                throw new ArgumentException($"Value provided to the {nameof(TangentConverter)} must be a double", ex);
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
                return System.Math.Atan(d);
            }
            catch (FormatException ex)
            {
                throw new ArgumentException($"Value provided to the {nameof(TangentConverter)} must be a double", ex);
            }
        }
    }
}
