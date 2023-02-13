
namespace MauiCode;

public partial class MainPage : ContentPage
{
	Button loginButton;
	Button detailButton;
	VerticalStackLayout layout;

	public MainPage()
	{
		this.BackgroundColor = Color.FromArgb("512bdf");

		layout = new VerticalStackLayout
		{
			Margin = new Thickness(15, 0, 15, 15),
			Padding = new Thickness(30, 20, 30, 30),
			
			Children =
			{
				new Label { Text = "Please log in", FontSize = 30, TextColor = Color.FromRgb(255, 255, 100), Margin = new Thickness(0, 30, 0, 0) },
				new Label { Text = "Username", TextColor = Color.FromArgb("bfff00"), Margin = new Thickness(0, 20, 0, 0) },
				new Entry { TextColor = Color.FromRgb(255, 255, 255), FontSize = 20, },
                new Label { Text = "Password", TextColor = Color.FromArgb("bfff00"), Margin = new Thickness(0, 20, 0, 0) },
				new Entry { IsPassword = true, TextColor = Color.FromRgb(255, 255, 100), FontSize = 20 }
                         }
		};

		loginButton = new Button { Text = "Login", BackgroundColor = Color.FromRgb(0, 148, 255), Margin = new Thickness(0, 30, 0, 0) };
		ToolTipProperties.SetText(loginButton, "click here after entering your credentials");
		layout.Children.Add(loginButton);

        detailButton = new Button { Text = "UI - XAML", BackgroundColor = Colors.White, TextColor = Colors.Indigo, BorderWidth=1, BorderColor = Colors.Indigo, Margin = new Thickness(0, 80, 0, 0), WidthRequest=200 };
        ToolTipProperties.SetText(detailButton, "click to see the XAML markup UI");
        layout.Children.Add(detailButton);

        Content = layout;
		
		loginButton.Clicked += async (sender, e) =>
		{
			await DisplayAlert("Test", "Login buton test", "OK");
		};

        detailButton.Clicked += async (sender, e) =>
        {
            await Shell.Current.GoToAsync("DetailPage");
        };


    }

	
}

