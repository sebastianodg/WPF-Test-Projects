using System.Globalization;
using System.Windows.Data;

namespace DataTemplate;

[ValueConversion(typeof(Boolean), typeof(String))]
public class VisibleValueConverter : IValueConverter
{
	private readonly String _brightnessIconCode = "\uE706";
	private readonly String _quiteHoursIconCode = "\uE708";

	public Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture)
	{
		if ((Boolean)value)
			return this._brightnessIconCode;
		else
			return this._quiteHoursIconCode;
	}

	public Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture)
	{
		if ((String)value == this._brightnessIconCode)
			return true;
		else
			return false;
	}
}
