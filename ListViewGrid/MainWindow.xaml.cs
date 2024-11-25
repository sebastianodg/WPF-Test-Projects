using System.Diagnostics;
using System.Windows;

namespace ListViewGrid;

public partial class MainWindow : Window
{
	public List<Person> Persons { get; set; }

	public MainWindow()
	{
		this.InitializeComponent();

		this.Persons = new List<Person>()
		{
			new Person("John", "Doe"),
			new Person("Frank", "Zappa"),
			new Person("David", "Gilmour"),
			new Person("Mark", "Knopfler"),
			new Person("John", "Lee Hooker"),
		};

		this.DataContext = this;
	}
}