using System;
using System.Globalization;
using System.Linq;
using Xamarin.Forms;

namespace MintPlayer.XamarinForms.Converters
{
    /// <summary>Binding converter that compares the first element with the second element.</summary>
    public class CompareConverter : IMultiValueConverter
    {
        /// <summary>Conversion from source to target.</summary>
        /// <param name="values">Source values.</param>
        /// <param name="targetType">Requested type by the binding target.</param>
        /// <param name="parameter">Operator to use for comparison.</param>
        /// <param name="culture">Culture to use for the conversion.</param>
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length != 2)
            {
                throw new ArgumentException($"The {nameof(CompareConverter)} requires 2 values", nameof(values));
            }

            if (parameter is string op)
            {
                var doubles = values.Cast<double>().ToArray();
                switch (op)
                {
                    case "<":
                        return doubles[0] < doubles[1];
                    case "<=":
                        return doubles[0] <= doubles[1];
                    case "=":
                        return doubles[0] == doubles[1];
                    case ">=":
                        return doubles[0] >= doubles[1];
                    case ">":
                        return doubles[0] > doubles[1];
                    case "!=":
                        return doubles[0] != doubles[1];
                    default:
                        throw new ArgumentException($"Invalid ConverterParameter {op} for {nameof(CompareConverter)}. Possible parameter values: <, <=, =, >=, >, !=");
                }
            }
            else
            {
                throw new ArgumentException($"The {nameof(CompareConverter)} requires a string as ConverterParameter", nameof(parameter));
            }
        }

        /// <summary>Conversion from target to source.</summary>
        /// <param name="value">Target value.</param>
        /// <param name="targetTypes">Requested types by the binding sources.</param>
        /// <param name="parameter">Converter parameter.</param>
        /// <param name="culture">Culture to use for the conversion.</param>
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException($"The {nameof(CompareConverter)} can only be used with Mode=OneWay");
        }
    }
}
