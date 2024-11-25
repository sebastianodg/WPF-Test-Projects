using CommunityToolkit.Mvvm.ComponentModel;

namespace MasterDetails;

public partial class AppUser : ObservableObject
{
	[ObservableProperty]
	private String _userName;

	[ObservableProperty]
	private String _password;

	[ObservableProperty]
	private String _firstName;

	[ObservableProperty]
	private String _lastName;

	[ObservableProperty]
	private String _email;

	[ObservableProperty]
	private Boolean _IsAdministrator;

	public AppUser()
	{
		this._userName = String.Empty;
		this._password = String.Empty;
		this._firstName = String.Empty;
		this._lastName = String.Empty;
		this._email = String.Empty;
		this._IsAdministrator = false;
	}

	public AppUser(String userName, String password, String firstName, String lastName, String email, Boolean isAdministrator)
	{
		this._userName = userName;
		this._password = password;
		this._firstName = firstName;
		this._lastName = lastName;
		this._email = email;
		this._IsAdministrator = isAdministrator;
	}
}
