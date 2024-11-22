using System.Windows;

namespace DataTemplate;

public partial class MainWindow : Window
{
	public MainWindowVM MainWindowViewModel { get; set; }

	public MainWindow()
	{
		this.InitializeComponent();

		this.MainWindowViewModel = new MainWindowVM();
		this.DataContext = this.MainWindowViewModel;
	}
}