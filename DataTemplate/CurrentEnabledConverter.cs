using System.Globalization;
using System.Windows.Data;

namespace DataTemplate;

[ValueConversion(typeof(Boolean), typeof(Boolean))]
public class CurrentEnabledConverter : IValueConverter
{
	public Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture)
	{
		if ((Boolean)value)
			return false;
		else
			return true;
	}

	public Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture)
	{
		if ((Boolean)value)
			return false;
		else
			return true;
	}
}
