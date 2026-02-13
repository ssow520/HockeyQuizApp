namespace HockeyQuizApp.Pages;

public partial class ResultPage : ContentPage
{
	public ResultPage(int score, int total)
	{
		InitializeComponent();
        ScoreLabel.Text = $"Votre score : {score}/{total}";

        if (score == total)
            MessageLabel.Text = "Incroyable ! Vous êtes un vrai champion du hockey 🏒!";
        else if (score >= total / 2)
            MessageLabel.Text = "Bien joué ! Vous connaissez assez le hockey 👍";
        else
            MessageLabel.Text = "Continuez à apprendre, vous y arriverez ! 💪";
    }

    private async void Restart_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TextPage1());
    }
}