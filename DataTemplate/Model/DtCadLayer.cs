using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Media;

namespace DataTemplate.Model;

public partial class DtCadLayer : ObservableObject
{
	[ObservableProperty]
	private String _name;

	[ObservableProperty]
	private String _description;

	[ObservableProperty]
	private SolidColorBrush _color;

	[ObservableProperty]
	private Boolean _visible;

	[ObservableProperty]
	private Boolean _locked;

	[ObservableProperty]
	private Boolean _current;

	public DtCadLayer()
	{
		this.Name = String.Empty;
		this.Description = String.Empty;
		this.Color = new SolidColorBrush(Colors.Black);
		this.Visible = true;
		this.Locked = false;
		this.Current = false;
	}

	public DtCadLayer(String name, String description, SolidColorBrush color, Boolean visible, Boolean locked, Boolean current)
	{
		this.Name = name;
		this.Description = description;
		this.Color = color;
		this.Visible = visible;
		this.Locked= locked;
		this.Current = current;
	}
}
