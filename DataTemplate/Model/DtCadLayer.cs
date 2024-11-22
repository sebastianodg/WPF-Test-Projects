using System.Windows.Media;

namespace DataTemplate.Model;

internal class DtCadLayer
{
	public String Name { get; set; }
	public String Description { get; set; }
	public Color Color { get; set; }
	public Boolean Enabled { get; set; }

	public DtCadLayer()
	{
		this.Name = String.Empty;
		this.Description = String.Empty;
		this.Color = Colors.Black;
		this.Enabled = true;
	}

	public DtCadLayer(String name, String description, Color color, Boolean enabled)
	{
		this.Name = name;
		this.Description = description;
		this.Color = color;
		this.Enabled = enabled;
	}
}
