using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace MasterDetails;

public partial class MainWindowVM : ObservableObject
{
	public ObservableCollection<AppUser> Users { get; set; }

	public MainWindowVM()
	{
		this.Users = new ObservableCollection<AppUser>()
		{
			new AppUser("markk",        "AYq+6f^$,m", "Mark",   "Knopfler",   "mark.knopfler@direstraits.com",   false),
			new AppUser("davidgilmour", "u,p?32E~$P", "David",  "Gilmour",    "thewall@pinkfloid.com",           false),
			new AppUser("toritori",     "G>M=6zmqpJ", "Tori",   "Amos",       "cornflakegirl@toriamos.com",      false),
			new AppUser("johnnyleeh",   "Kh.f5@Hp2{", "John",   "Lee Hooker", "johnny@blues.com",                false),
			new AppUser("francobatt",   "b>Tk-*5qLy", "Franco", "Battiato",   "f.battiato@lavocedelpadrone.com", true),
			new AppUser("janis.j",      "J:8.xM_j2P", "Janis",  "Joplin",     "jj@janisjoplin.com",              false),
		};
	}
}