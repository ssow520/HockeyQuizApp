using HockeyQuizApp.Models;
namespace HockeyQuizApp.Pages;

public partial class QuizPage : ContentPage
{
    private List<Question> questions = new List<Question>();
    private int currentQuestion = 0;
    private int score = 0;

    public QuizPage()
	{
		InitializeComponent();
        LoadQuestions();
        DisplayQuestion();
    }

    void LoadQuestions()
    {
        questions = new List<Question>()
        {
            new Question{ 
                Text="Où est né le hockey ?", 
                Image="canada_map.png", 
                Option1="USA", 
                Option2="Canada", 
                Option3="France", 
                CorrectAnswer=2 
            },

            new Question{ 
                Text="Combien de périodes dans un match ?", 
                Image="hockey_clock.jpg", 
                Option1="2", 
                Option2="3", 
                Option3="4", 
                CorrectAnswer=2 
            },
            new Question{ 
                Text="Combien de joueurs sur la glace ?", 
                Image="players_on_ice.png", 
                Option1="6", 
                Option2="7", 
                Option3="5", 
                CorrectAnswer=1 
            },
            new Question{ 
                Text="Comment s'appelle la ligue principale ?", 
                Image="nhl_logo.png", 
                Option1="NBA", 
                Option2="LNH", 
                Option3="NFL", 
                CorrectAnswer=2 
            },
            new Question{ 
                Text="Quel trophée gagne le champion ?", 
                Image="stanley_cup.png", 
                Option1="Coupe Stanley", 
                Option2="Coupe du Monde", 
                Option3="Super Bowl", 
                CorrectAnswer=1 
            },

            new Question{ 
                Text="Quel objet est utilisé pour jouer ?", 
                Image="puck.png", 
                Option1="Balle", 
                Option2="Rondelle", 
                Option3="Disque en bois", 
                CorrectAnswer=2 
            },
            new Question{ 
                Text="Combien de minutes par période ?", 
                Image="period_timer.png", 
                Option1="15", 
                Option2="20", 
                Option3="25", 
                CorrectAnswer=2 
            },
            new Question{ 
                Text="Qui protège le filet ?", 
                Image="goalie.png", 
                Option1="Gardien", 
                Option2="Capitaine", 
                Option3="Arbitre", 
                CorrectAnswer=1 
            },
            new Question{ 
                Text="Quel pays est célèbre pour le hockey ?", 
                Image="canada_flag.png", 
                Option1="Canada", 
                Option2="Brésil", 
                Option3="Italie", 
                CorrectAnswer=1 
            },
            new Question{ 
                Text="Le hockey se joue sur ?", 
                Image="rules_hockey.png", 
                Option1="Herbe", 
                Option2="Glace", 
                Option3="Sable", 
                CorrectAnswer=2 
            },

            new Question{ 
                Text="Combien de joueurs au total par équipe ?", 
                Image="team_formation.jpg", 
                Option1="6", 
                Option2="10", 
                Option3="11", 
                CorrectAnswer=1 
            },
            new Question{ 
                Text="Le hockey est un sport ?", 
                Image="ice_hockey.jpg", 
                Option1="Aquatique", 
                Option2="De glace", 
                Option3="Motorisé", 
                CorrectAnswer=2 
            },
            new Question{ 
                Text="Quel équipement protège la tête ?", 
                Image="helmet.png", 
                Option1="Casque", 
                Option2="Gants", 
                Option3="Patins", 
                CorrectAnswer=1 
            },
            new Question{ 
                Text="Les séries éliminatoires servent à ?", 
                Image="playoffs.png", 
                Option1="Choisir le champion", 
                Option2="S'entraîner", 
                Option3="Changer les règles", 
                CorrectAnswer=1 
            },
            new Question{ 
                Text="Le hockey est populaire en ?", 
                Image="north_america_map.png", 
                Option1="Afrique", 
                Option2="Amérique du Nord", 
                Option3="Australie", 
                CorrectAnswer=2 
            },

            new Question{ 
                Text="Le gardien utilise ?", 
                Image="goalie_stick.png", 
                Option1="Un bâton spécial", 
                Option2="Une raquette", 
                Option3="Un ballon", 
                CorrectAnswer=1 
            },
            new Question{ 
                Text="La LNH comprend ?", 
                Image="north_america_map.png", 
                Option1="Canada seulement", 
                Option2="USA seulement", 
                Option3="Canada et USA", 
                CorrectAnswer=3 
            },
            new Question{ 
                Text="Le but est de ?", 
                Image="hockey_goal.png", 
                Option1="Marquer des paniers", 
                Option2="Marquer des buts", 
                Option3="Marquer des essais", 
                CorrectAnswer=2 
            },
            new Question{ 
                Text="Le hockey est joué au ?", 
                Image="century.png", 
                Option1="19e siècle", 
                Option2="15e siècle", 
                Option3="10e siècle", 
                CorrectAnswer=1 
            },
            new Question{ 
                Text="Les joueurs portent ?", 
                Image="hockey_gear.png", 
                Option1="Armure", 
                Option2="Protection", 
                Option3="Rien", 
                CorrectAnswer=2 
            },
        };
    }

    void DisplayQuestion()
    {
        var question = questions[currentQuestion];

        QuestionNumberLabel.Text = $"Question {currentQuestion + 1}/{questions.Count}";
        QuestionLabel.Text = question.Text;
        QuestionImage.Source = question.Image;

        Option1Button.Text = question.Option1;
        Option2Button.Text = question.Option2;
        Option3Button.Text = question.Option3;

        ResetButtons();
        FeedbackLabel.Text = "";
        NextButton.IsVisible = false;
    }

    void ResetButtons()
    {
        Option1Button.BackgroundColor = Colors.LightGray;
        Option2Button.BackgroundColor = Colors.LightGray;
        Option3Button.BackgroundColor = Colors.LightGray;

        Option1Button.IsEnabled = true;
        Option2Button.IsEnabled = true;
        Option3Button.IsEnabled = true;
    }

    private void Answer_Clicked(object sender, EventArgs e)
    {
        Button clicked = (Button)sender;
        int selected = 0;

        if (clicked == Option1Button) selected = 1;
        if (clicked == Option2Button) selected = 2;
        if (clicked == Option3Button) selected = 3;

        Option1Button.IsEnabled = false;
        Option2Button.IsEnabled = false;
        Option3Button.IsEnabled = false;

        if (selected == questions[currentQuestion].CorrectAnswer)
        {
            clicked.BackgroundColor = Colors.Green;
            FeedbackLabel.TextColor = Colors.White;
            FeedbackLabel.Text = "Bravo ! Bonne réponse";
            score++;
        }
        else
        {
            clicked.BackgroundColor = Colors.Red;
            FeedbackLabel.TextColor = Colors.Red;
            FeedbackLabel.Text = "Mauvaise réponse";
        }

        NextButton.IsVisible = true;
    }

    private async void Next_Clicked(object sender, EventArgs e)
    {
        currentQuestion++;

        if (currentQuestion < questions.Count)
        {
            DisplayQuestion();
        }
        else
        {
            await Navigation.PushAsync(new ResultPage(score, questions.Count));
        }
    }

}