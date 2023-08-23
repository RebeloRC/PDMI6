//Author: Rodrigo Rebelo & Luiz Gustavo

using TP_01_PDMI6.Pages;

namespace TP_01_PDMI6;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void Login(object sender, EventArgs e)
    {
		if (userInput.Text == "admin" && passwordInput.Text == "senha@dmin")
		{
			DisplayAlert("Alert", "Success!", "OK");
		} else {
            DisplayAlert("Alert", "Wrong!", "OK");
        }
    }

	private void ClearInputs(object sender, EventArgs e) {
		userInput.Text = "";
		passwordInput.Text = "";	
	}

	private async void GoToCreditsPage(object sender, EventArgs e) {

		await Shell.Current.GoToAsync(nameof(CreditsPage));
	
	}




}

