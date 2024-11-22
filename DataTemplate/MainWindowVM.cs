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
			Visible = true,
			Locked = false,
			Current = true,
		};

		this.CadLayersList = new List<DtCadLayer>()
		{
			new DtCadLayer()
			{
				Name = "Layer 1",
				Description = "First Test Layer",
				Color = new SolidColorBrush(Colors.Black),
				Visible = true,
				Locked = false,
				Current = true,
			},
			new DtCadLayer()
			{
				Name = "Layer 2",
				Description = "Second Test Layer",
				Color = new SolidColorBrush(Colors.Orange),
				Visible = false,
				Locked = false,
				Current = false,
			},
			new DtCadLayer()
			{
				Name = "Layer 3",
				Description = "Third Test Layer",
				Color = new SolidColorBrush(Colors.DarkViolet),
				Visible = true,
				Locked = true,
				Current = false,
			},
		};
	}
}
