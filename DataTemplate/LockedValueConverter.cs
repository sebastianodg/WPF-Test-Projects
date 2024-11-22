using System.Globalization;
using System.Windows.Data;

namespace DataTemplate;

[ValueConversion(typeof(Boolean), typeof(String))]
public class LockedValueConverter : IValueConverter
{
	private readonly String _lockIconCode = "\uE72E";
	private readonly String _editIconCode = "\uE70F";

	public Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture)
	{
		if ((Boolean)value)
			return this._lockIconCode;
		else
			return this._editIconCode;
	}

	public Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture)
	{
		if ((String)value == this._lockIconCode)
			return true;
		else
			return false;
	}
}
