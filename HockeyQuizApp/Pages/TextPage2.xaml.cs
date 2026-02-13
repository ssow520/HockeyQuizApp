namespace HockeyQuizApp.Pages;

public partial class TextPage2 : ContentPage
{
	public TextPage2()
	{
		InitializeComponent();
	}

    private async void Back_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void Next_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TextPage3());
    }
}