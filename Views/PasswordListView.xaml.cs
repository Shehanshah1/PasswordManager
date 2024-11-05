namespace PasswordManager.Views;

public partial class PasswordListView : ContentPage
{
	public PasswordListView()
	{
		InitializeComponent();
	}
    private async void OnAddNewPasswordButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewPasswordView());
    }

}