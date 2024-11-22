using System.Windows;

namespace DataTemplate;

public partial class MainWindow : Window
{
	public MainWindow()
	{
		this.InitializeComponent();
		this.DataContext = new MainWindowVM();
	}
}