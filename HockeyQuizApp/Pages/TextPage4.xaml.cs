namespace HockeyQuizApp.Pages;

public partial class TextPage4 : ContentPage
{
	public TextPage4()
	{
		InitializeComponent();
	}

    private async void Back_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }


    private async void StartQuiz_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new QuizPage());
    }
}