using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Globalization;
using WalletWasabi.Exceptions;

namespace WalletWasabi.Gui.Converters
{
	public class MoneyBrushConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is string moneyString)
			{
				var money = decimal.Parse(moneyString);
				return money < 0 ? Brushes.IndianRed : Brushes.MediumSeaGreen;
			}
			else
			{
				throw new TypeArgumentException(value, typeof(string), nameof(value));
			}
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotSupportedException();
		}
	}
}
