using System;
using System.Globalization;
using System.Linq;
using Xamarin.Forms;

namespace MintPlayer.XamarinForms.Converters
{
    /// <summary>Binding converter that outputs the multiplification of the inputs.</summary>
    public class MultiplyConverter : IMultiValueConverter
    {
        /// <summary>Conversion from source to target.</summary>
        /// <param name="values">Source values.</param>
        /// <param name="targetType">Requested type by the binding target.</param>
        /// <param name="parameter">Converter parameter.</param>
        /// <param name="culture">Culture to use for the conversion.</param>
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return values.Cast<double>().Aggregate((a, b) => a * b);
        }

        /// <summary>Conversion from target to source.</summary>
        /// <param name="value">Target value.</param>
        /// <param name="targetTypes">Requested types by the binding sources.</param>
        /// <param name="parameter">Converter parameter.</param>
        /// <param name="culture">Culture to use for the conversion.</param>
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException($"The {nameof(MultiplyConverter)} can only be used with Mode=OneWay");
        }
    }
}
