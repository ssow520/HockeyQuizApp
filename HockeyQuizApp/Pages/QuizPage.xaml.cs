using HockeyQuizApp.Models;
namespace HockeyQuizApp.Pages;

public partial class QuizPage : ContentPage
{
    private List<Question> questions = new();
    private int currentQuestion = 0;
    private int score = 0;

    private int timeLeft = 10;
    private bool timerRunning = false;
    private Random rnd = new Random();



    public QuizPage()
	{
		InitializeComponent();
        LoadQuestions();

        questions = questions.OrderBy(ques => rnd.Next()).ToList();

        DisplayQuestion();
    }
    
    void LoadQuestions()
    {
        questions = new List<Question>()
        {
            new Question{
                Text="Où est né le hockey ?",
                Image="canada_map.png",
                Options=new List<string>{"USA","Canada","France","Russie"},
                CorrectAnswer="Canada",
                Explanation="Le hockey moderne est né au Canada au 19e siècle.",
                Category="Facile"
            },

            new Question{
                Text="Combien de périodes dans un match ?",
                Image="hockey_clock.jpg",
                Options=new List<string>{"2","3","4","5"},
                CorrectAnswer="3",
                Explanation="Un match officiel comporte 3 périodes.",
                Category="Facile"
            },

            new Question{
                Text="Quel trophée gagne le champion NHL ?",
                Image="stanley_cup.png",
                Options=new List<string>{"Super Bowl","Coupe Stanley","Coupe du Monde","Trophée FIFA"},
                CorrectAnswer="Coupe Stanley",
                Explanation="La Coupe Stanley est remise au champion de la LNH.",
                Category="Moyen"
            },

            new Question{
                Text="Combien de joueurs par équipe sur la glace ?",
                Image="players_on_ice.png",
                Options=new List<string>{"5","6","7","8"},
                CorrectAnswer="6",
                Explanation="5 joueurs + 1 gardien = 6 joueurs.",
                Category="Facile"
            },

            new Question{
                Text="Quel trophée gagne le champion ?",
                Image="stanley_cup.png",
                Options=new List<string>{"Coupe Stanley","Coupe du Monde","Super Bowl","Coupe Davis"},
                CorrectAnswer="Coupe Stanley",
                Explanation="La Coupe Stanley est le trophée du champion.",
                Category="Facile"
            },

            new Question{
                Text="Quel objet est utilisé pour jouer ?",
                Image="puck.png",
                Options=new List<string>{"Balle","Rondelle","Disque en bois","Ballon"},
                CorrectAnswer="Rondelle",
                Explanation="Le hockey se joue avec une rondelle en caoutchouc.",
                Category="Facile"
            },

            new Question{
                Text="Combien de minutes par période ?",
                Image="period_timer.png",
                Options=new List<string>{"15","20","25","30"},
                CorrectAnswer="20",
                Explanation="Chaque période dure 20 minutes.",
                Category="Facile"
            },

            new Question{
                Text="Qui protège le filet ?",
                Image="goalie.png",
                Options=new List<string>{"Gardien","Capitaine","Arbitre","Défenseur"},
                CorrectAnswer="Gardien",
                Explanation="Le gardien protège le filet.",
                Category="Facile"
            },

            new Question{
                Text="Quel pays est célèbre pour le hockey ?",
                Image="canada_flag.png",
                Options=new List<string>{"Canada","Brésil","Italie","Espagne"},
                CorrectAnswer="Canada",
                Explanation="Le hockey est un sport emblématique du Canada.",
                Category="Facile"
            },

            new Question{
                Text="Le hockey se joue sur ?",
                Image="rules_hockey.png",
                Options=new List<string>{"Herbe","Glace","Sable","Béton"},
                CorrectAnswer="Glace",
                Explanation="Le hockey sur glace se joue sur une surface glacée.",
                Category="Facile"
            },

            new Question{
                Text="Combien de joueurs au total par équipe ?",
                Image="team_formation.jpg",
                Options=new List<string>{"6","7","8","9"},
                CorrectAnswer="6",
                Explanation="Chaque équipe a 6 joueurs sur la glace.",
                Category="Facile"
            },

            new Question{
                Text="Le hockey est un sport ?",
                Image="ice_hockey.jpg",
                Options=new List<string>{"Aquatique","De glace","Motorisé","Aérien"},
                CorrectAnswer="De glace",
                Explanation="Le hockey sur glace se joue sur une patinoire.",
                Category="Facile"
            },

            new Question{
                Text="Quel équipement protège la tête ?",
                Image="helmet.png",
                Options=new List<string>{"Casque","Gants","Patins","Bouclier"},
                CorrectAnswer="Casque",
                Explanation="Le casque protège la tête contre les blessures.",
                Category="Facile"
            },

            new Question{
                Text="Les séries éliminatoires servent à ?",
                Image="playoffs.png",
                Options=new List<string>{"Choisir le champion","S'entraîner","Changer les règles","Recruter"},
                CorrectAnswer="Choisir le champion",
                Explanation="Les playoffs déterminent l'équipe championne.",
                Category="Moyen"
            },

            new Question{
                Text="Le hockey est populaire en ?",
                Image="north_america_map.png",
                Options=new List<string>{"Afrique","Amérique du Nord","Australie","Asie"},
                CorrectAnswer="Amérique du Nord",
                Explanation="Il est surtout populaire au Canada et aux USA.",
                Category="Facile"
            },

            new Question{
                Text="Le gardien utilise ?",
                Image="goalie_stick.png",
                Options=new List<string>{"Un bâton spécial","Une raquette","Un ballon","Une batte"},
                CorrectAnswer="Un bâton spécial",
                Explanation="Le gardien utilise un bâton différent des autres joueurs.",
                Category="Moyen"
            },

            new Question{
                Text="La LNH comprend ?",
                Image="north_america_map.png",
                Options=new List<string>{"Canada seulement","USA seulement","Canada et USA","Europe"},
                CorrectAnswer="Canada et USA",
                Explanation="La LNH regroupe des équipes canadiennes et américaines.",
                Category="Moyen"
            },

            new Question{
                Text="Le but est de ?",
                Image="hockey_goal.png",
                Options=new List<string>{"Marquer des paniers","Marquer des buts","Marquer des essais","Faire des passes"},
                CorrectAnswer="Marquer des buts",
                Explanation="L'objectif est d'envoyer la rondelle dans le filet.",
                Category="Facile"
            },

            new Question{
                Text="Le hockey est joué au ?",
                Image="century.png",
                Options=new List<string>{"19e siècle","15e siècle","10e siècle","21e siècle"},
                CorrectAnswer="19e siècle",
                Explanation="Le hockey moderne est né au 19e siècle.",
                Category="Moyen"
            },

            new Question{
                Text="Les joueurs portent ?",
                Image="hockey_gear.png",
                Options=new List<string>{"Armure","Protection","Rien","Costume"},
                CorrectAnswer="Protection",
                Explanation="Les joueurs portent des équipements de protection complets.",
                Category="Facile"
            }
        };
    }


    void DisplayQuestion()
    {
        if (currentQuestion >= questions.Count)
        {
            Navigation.PushAsync(new ResultPage(score, questions.Count));
            return;
        }

        Question question = questions[currentQuestion];

        QuestionNumberLabel.Text = $"Question {currentQuestion + 1}/{questions.Count}";
        ScoreLabel.Text = $"Score : {score}/{questions.Count}";
        CategoryLabel.Text = $"Catégorie : {question.Category}";
        QuizProgressBar.Progress = (double)currentQuestion / questions.Count;

        QuestionLabel.Text = question.Text;
        QuestionImage.Source = question.Image;

        // Mélange les questions
        List<string> shuffledOptions = question.Options.OrderBy(x => rnd.Next()).ToList();

        Option1Button.Text = shuffledOptions[0];
        Option2Button.Text = shuffledOptions[1];
        Option3Button.Text = shuffledOptions[2];
        Option4Button.Text = shuffledOptions[3];

        ResetButtons();
        FeedbackLabel.Text = "";

        timeLeft = 10;
        TimerLabel.Text = "Temps : 10";
        StartTimer();
    }

    void StartTimer()
    {
        timerRunning = true;

        Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            if (!timerRunning)
                return false;

            timeLeft--;
            TimerLabel.Text = "Temps : " + timeLeft;

            if (timeLeft <= 0)
            {
                timerRunning = false;
                currentQuestion++;
                DisplayQuestion();
                return false;
            }

            return true;
        });
    }


    void ResetButtons()
    {
        foreach (Button btn in new[] { Option1Button, Option2Button, Option3Button, Option4Button })
        {
            btn.BackgroundColor = Color.FromArgb("#03A9F4");
            btn.TextColor = Colors.White;
            btn.IsEnabled = true;
            btn.CornerRadius = 25;
            btn.Padding = 15;
        }
    }

    private async void Answer_Clicked(object sender, EventArgs e)
    {
        timerRunning = false;

        Button button = (Button)sender;
        string correct = questions[currentQuestion].CorrectAnswer;

        Option1Button.IsEnabled = false;
        Option2Button.IsEnabled = false;
        Option3Button.IsEnabled = false;
        Option4Button.IsEnabled = false;

        if (button.Text == correct)
        {
            button.BackgroundColor = Colors.Green;
            FeedbackLabel.TextColor = Colors.Green;
            score++;
        }
        else
        {
            button.BackgroundColor = Colors.Red;
            FeedbackLabel.TextColor = Colors.Red;
        }

        FeedbackLabel.Text = questions[currentQuestion].Explanation;

        await Task.Delay(3000);

        currentQuestion++;
        DisplayQuestion();
    }

}