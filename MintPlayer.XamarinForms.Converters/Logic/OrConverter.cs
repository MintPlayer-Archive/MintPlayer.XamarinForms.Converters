using System;
using System.Globalization;
using System.Linq;
using Xamarin.Forms;

namespace MintPlayer.XamarinForms.Converters
{
    /// <summary>Binding converter that outputs the OR equation of its inputs.</summary>
    public class OrConverter : IMultiValueConverter
    {
        /// <summary>Conversion from source to target.</summary>
        /// <param name="values">Source values.</param>
        /// <param name="targetType">Requested type by the binding target.</param>
        /// <param name="parameter">Converter parameter.</param>
        /// <param name="culture">Culture to use for the conversion.</param>
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.All(v => v is bool))
            {
                return values.Cast<bool>().Any(v => v);
            }
            else
            {
                throw new ArgumentException($"All values provided to the {nameof(OrConverter)} must be a bool");
            }
        }

        /// <summary>Conversion from target to source.</summary>
        /// <param name="value">Target value.</param>
        /// <param name="targetTypes">Requested types by the binding sources.</param>
        /// <param name="parameter">Converter parameter.</param>
        /// <param name="culture">Culture to use for the conversion.</param>
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException($"The {nameof(OrConverter)} can only be used with Mode=OneWay");
        }
    }
}
