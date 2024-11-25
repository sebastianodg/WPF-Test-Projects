using Wpf.Ui;
using Wpf.Ui.Controls;

namespace MasterDetails;

public partial class MainWindow : INavigationWindow
{
	private MainWindowVM _vm;

	public MainWindow()
	{
		this.InitializeComponent();

		this._vm = new MainWindowVM();
		this.DataContext = this._vm;
	}

	public INavigationView GetNavigation()
	{
		throw new NotImplementedException();
	}

	public Boolean Navigate(Type pageType)
	{
		throw new NotImplementedException();
	}

	public void SetServiceProvider(IServiceProvider serviceProvider)
	{
		throw new NotImplementedException();
	}

	public void SetPageService(IPageService pageService)
	{
		throw new NotImplementedException();
	}

	public void ShowWindow()
	{
		throw new NotImplementedException();
	}

	public void CloseWindow()
	{
		throw new NotImplementedException();
	}
}