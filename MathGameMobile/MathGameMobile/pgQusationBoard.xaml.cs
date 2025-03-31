using MathGame;

namespace MathGameMobile;

public partial class pgQusationBoard : ContentPage
{
    Random random = new Random();

    clsGameInfo GameInfo = new clsGameInfo();

    bool isMix = false;
    public pgQusationBoard(short numberOfQuestion, short level, short operation)

    {
		InitializeComponent();

        GameInfo.NumberOfQuestion = numberOfQuestion;
        GameInfo.Level = (clsGameInfo.enLevel)level;
        GameInfo.Operation = (clsGameInfo.enOperation)operation;
    }


    void OperationType()
    {
        switch (GameInfo.Operation)
        {
            case clsGameInfo.enOperation.Add:
                GameInfo.OperationText = "+";
                break;
            case clsGameInfo.enOperation.Sub:
                GameInfo.OperationText = "-";
                break;
            case clsGameInfo.enOperation.Multi:
                GameInfo.OperationText = "*";
                break;
            case clsGameInfo.enOperation.Div:
                GameInfo.OperationText = "/";
                break;
        }

        lbOperation.Text = GameInfo.OperationText;
    }

    void ChooseNum()
    {
        switch (GameInfo.Level)
        {
            case clsGameInfo.enLevel.Easy:
                GameInfo.Num1 = random.Next(1, 20);
                GameInfo.Num2 = random.Next(1, 20);
                break;
            case clsGameInfo.enLevel.Med:
                GameInfo.Num1 = random.Next(21, 50);
                GameInfo.Num2 = random.Next(21, 500);
                break;
            case clsGameInfo.enLevel.Hard:
                GameInfo.Num1 = random.Next(51, 100);
                GameInfo.Num2 = random.Next(51, 100);
                break;
            default:
                GameInfo.Num1 = random.Next(1, 50);
                GameInfo.Num2 = random.Next(1, 50);
                break;
        }

        lbNum1.Text = GameInfo.Num1.ToString();
        lbNum2.Text = GameInfo.Num2.ToString();

    }

    void CalculteResult()
    {
        switch (GameInfo.Operation)
        {
            case clsGameInfo.enOperation.Add:
                GameInfo.Result = GameInfo.Num1 + GameInfo.Num2;
                break;
            case clsGameInfo.enOperation.Sub:
                GameInfo.Result = GameInfo.Num1 - GameInfo.Num2;
                break;
            case clsGameInfo.enOperation.Multi:
                GameInfo.Result = GameInfo.Num1 * GameInfo.Num2;
                break;
            case clsGameInfo.enOperation.Div:
                GameInfo.Result = GameInfo.Num1 / GameInfo.Num2;
                break;
            default:
                GameInfo.Result = GameInfo.Num1 + GameInfo.Num2;
                break;
        }

        GameInfo.Result = Math.Round(GameInfo.Result, 1);
    }

    void CheckResult()
    {
        if (GameInfo.Result == GameInfo.UserInput)
        {
            GameInfo.CorrectAnswer++;
            //this.BackgroundColor = Colors.Green;
            DisplayAlert("Great", "Your answer is correct", "Ok");
        }
        else
        {
            GameInfo.WrongAnswer++;
            //this.BackgroundColor = Colors.Red;
            DisplayAlert("Wrong", "The correct answer is : " + GameInfo.Result, "Ok");

        }
    }

    void GenrateQuesation()
    {
        if (GameInfo.Operation == clsGameInfo.enOperation.Mix)
        {
            isMix = true;
        }

        if (isMix)
        {
            GameInfo.Operation = (clsGameInfo.enOperation)random.Next(1, 4);
        }

        lbNumberOfQuesation.Text = GameInfo.NumberOfQuestion.ToString();

        lbQuesationNumber.Text = GameInfo.QuestionNumber.ToString();

        OperationType();

        ChooseNum();
    }

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        GameInfo.QuestionNumber = 1;

        GenrateQuesation();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        string Input = enInput.Text;

        if (!Input.Any(char.IsDigit))
        {
            DisplayAlert("Error", "this field can't be a empty", "Ok");
            return;
        }
        else
            enInput.Text = enInput.Text.TrimEnd('.');


        CalculteResult();

        GameInfo.UserInput = Math.Round(float.Parse(enInput.Text), 1);

        CheckResult();

        if (GameInfo.NumberOfQuestion == GameInfo.QuestionNumber)
        {
            Navigation.PushModalAsync(new pgGameInfo(GameInfo));
        }
        else
        {

            GameInfo.QuestionNumber++;

            GenrateQuesation();
        }
    }
}