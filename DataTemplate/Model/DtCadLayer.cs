using System.Windows.Media;

namespace DataTemplate.Model;

public class DtCadLayer
{
	public String Name { get; set; }
	public String Description { get; set; }
	public SolidColorBrush Color { get; set; }
	public Boolean Enabled { get; set; }

	public DtCadLayer()
	{
		this.Name = String.Empty;
		this.Description = String.Empty;
		this.Color = new SolidColorBrush(Colors.Black);
		this.Enabled = true;
	}

	public DtCadLayer(String name, String description, SolidColorBrush color, Boolean enabled)
	{
		this.Name = name;
		this.Description = description;
		this.Color = color;
		this.Enabled = enabled;
	}
}
