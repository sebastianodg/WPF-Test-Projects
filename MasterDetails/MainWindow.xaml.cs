using System.Windows;
using Wpf.Ui;
using Wpf.Ui.Appearance;
using Wpf.Ui.Controls;

namespace MasterDetails;

public partial class MainWindow : FluentWindow
{
	private MainWindowVM _vm;

	public MainWindow()
	{
		this.InitializeComponent();

		this._vm = new MainWindowVM();
		this.DataContext = this._vm;

		this.Loaded += this.OnWindowLoaded;
		this.Unloaded += this.OnWindowUnloaded;

	}

	private void OnWindowLoaded(Object sender, RoutedEventArgs e)
	{
		SystemThemeWatcher.Watch(this, WindowBackdropType.Mica, true);
	}

	private void OnWindowUnloaded(Object sender, RoutedEventArgs e)
	{
		SystemThemeWatcher.UnWatch(this);
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

	private async void Prova(Object sender, System.Windows.RoutedEventArgs e)
	{
		Wpf.Ui.Controls.MessageBox messageBox = new Wpf.Ui.Controls.MessageBox()
		{
			Title = "Confirm",
			Content = "This will permanently delete the user. Are you sure?",
			CloseButtonText = "No",
			SecondaryButtonText = "Yes",
			SecondaryButtonAppearance = ControlAppearance.Danger,
		};
		await messageBox.ShowDialogAsync();
	}
}