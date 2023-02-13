namespace MauiCode;

public partial class DetailPage : ContentPage
{
	public DetailPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("..");
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await DisplayAlert("Test", "Login buton test", "OK");
    }
}