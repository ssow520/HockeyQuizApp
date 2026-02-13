using HockeyQuizApp.Pages;

namespace HockeyQuizApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void StartReading_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TextPage1());
        }
    }
}
