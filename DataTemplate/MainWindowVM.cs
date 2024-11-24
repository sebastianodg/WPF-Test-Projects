using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DataTemplate.Model;
using System.Collections.ObjectModel;
using System.Windows.Media;

namespace DataTemplate;

public partial class MainWindowVM : ObservableObject
{
	public DtCadLayer CadLayer { get; set; }

	public ObservableCollection<DtCadLayer> CadLayersList { get; set; }

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

		this.CadLayersList = new ObservableCollection<DtCadLayer>()
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
			new DtCadLayer()
			{
				Name = "Layer 4",
				Description = "Fourth Test Layer",
				Color = new SolidColorBrush(Colors.DarkViolet),
				Visible = true,
				Locked = false,
				Current = false,
			},
		};
	}

	[RelayCommand]
	public void SetCurrentLayer(DtCadLayer clickedLayer)
	{
		if (clickedLayer == null)
			return;

		// Se il layer è già il livello corrente, non posso fare nulla
		if (clickedLayer.Current)
			return;

		// Impostazione del layer clickato come layer corrente
		foreach (DtCadLayer layer in this.CadLayersList)
		{
			layer.Current = layer == clickedLayer;

			if (layer.Current)
			{
				layer.Locked = false;
				layer.Visible = true;
			}
		}
	}

	[RelayCommand]
	public void ToggleLayerVisible(DtCadLayer clickedLayer)
	{
		clickedLayer.Visible = !clickedLayer.Visible;
	}

	[RelayCommand]
	public void ToggleLayerLocked(DtCadLayer clickedLayer)
	{
		clickedLayer.Locked = !clickedLayer.Locked;
	}
}
