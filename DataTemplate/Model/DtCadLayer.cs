using System.Windows.Media;

namespace DataTemplate.Model;

public class DtCadLayer
{
	public String Name { get; set; }
	public String Description { get; set; }
	public SolidColorBrush Color { get; set; }
	public Boolean Visible { get; set; }
	public Boolean Locked { get; set; }
	public Boolean Current { get; set; }

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
