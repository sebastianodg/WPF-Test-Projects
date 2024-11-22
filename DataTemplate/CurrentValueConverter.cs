using System.Globalization;
using System.Windows.Data;

namespace DataTemplate;

[ValueConversion(typeof(Boolean), typeof(String))]
public class CurrentValueConverter : IValueConverter
{
	private readonly String _radioBtnOnIconCode = "\uECCB";
	private readonly String _radioBtnOffIconCode = "\uECCA";

	public Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture)
	{
		if ((Boolean)value)
			return this._radioBtnOnIconCode;
		else
			return this._radioBtnOffIconCode;
	}

	public Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture)
	{
		if ((String)value == this._radioBtnOnIconCode)
			return true;
		else
			return false;
	}
}
