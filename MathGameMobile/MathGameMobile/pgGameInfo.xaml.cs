using MathGame;
namespace MathGameMobile;

public partial class pgGameInfo : ContentPage
{
    clsGameInfo GameInfo;
    public pgGameInfo(clsGameInfo gameInfo)
	{
        InitializeComponent();

        GameInfo = gameInfo;

    }

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        if (GameInfo.WrongAnswer > GameInfo.CorrectAnswer)
        {
            //BackgroundColor = Colors.Red;
            lbFinalResult.Text = "Fail";
            //Soun Player = new SoundPlayer();
            //Player.SoundLocation = @"C:\Users\good1\Downloads\8-bit-video-game-lose-sound-version-1-145828.wav";
            //Player.Play();
        }

         else if  (GameInfo.WrongAnswer < GameInfo.CorrectAnswer)
        {
            //BackgroundColor = Colors.Green;
            lbFinalResult.Text = "Pass";
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = @"C:\Users\good1\Downloads\8-bit-video-game-win-level-sound-version-1-145827.wav";
            //Player.Play();
        }
        else
        {
            lbFinalResult.Text = "Draw";
        }

        lbNumberOfQuesations.Text = GameInfo.NumberOfQuestion.ToString();
        lbOperationLevel.Text = GameInfo.Operation.ToString();
        lbWrongQuesation.Text = GameInfo.WrongAnswer.ToString();
        lbRigthQuesation.Text = GameInfo.CorrectAnswer.ToString();
        lbQuesationLevel.Text = GameInfo.Level.ToString();

    }

    private  void Button_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new MainPage());

    }
}