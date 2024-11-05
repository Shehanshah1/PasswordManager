namespace PasswordManager.Views;

public partial class NewUserView : ContentPage
{
	public NewUserView()
	{
		InitializeComponent();
	}

    private async void OnCreateAccountButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//PasswordListView");
    }
}