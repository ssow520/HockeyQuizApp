namespace HockeyQuizApp.Pages;

public partial class TextPage1 : ContentPage
{
	public TextPage1()
	{
		InitializeComponent();
	}

	private async void Next_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new TextPage2());
    }
}