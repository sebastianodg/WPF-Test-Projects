using DataTemplate.Model;
using System.Windows.Media;

namespace DataTemplate;

public class MainWindowVM
{
	public DtCadLayer CadLayer { get; set; }

	public List<DtCadLayer> CadLayersList { get; set; }

	public MainWindowVM()
	{
		this.CadLayer = new DtCadLayer()
		{
			Name = "Layer 1",
			Description = "First Test Layer",
			Color = new SolidColorBrush(Colors.Black),
			Enabled = true,
		};

		this.CadLayersList = new List<DtCadLayer>()
		{
			new DtCadLayer()
			{
				Name = "Layer 1",
				Description = "First Test Layer",
				Color = new SolidColorBrush(Colors.Black),
				Enabled = true,
			},
			new DtCadLayer()
			{
				Name = "Layer 2",
				Description = "Second Test Layer",
				Color = new SolidColorBrush(Colors.Red),
				Enabled = false,
			},
			new DtCadLayer()
			{
				Name = "Layer 3",
				Description = "Third Test Layer",
				Color = new SolidColorBrush(Colors.DarkViolet),
				Enabled = true,
			},
		};
	}
}
