
namespace MathGameMobile;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

   

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        string Input = string.Empty;
        Input = enNumberOfQuesation.Text.Trim();

        if (Input != string.Empty)
        Input = Input.Trim('.');

        if (!Input.Any(char.IsDigit) || Input == "0" || string.IsNullOrEmpty(Input))
        {
            DisplayAlert("Error", "this field can't be a empty", "Ok");
            return;
        }

        short NumberOfQuesation = Convert.ToInt16(Input);
        short Level = 0, Operation = 0;

        if (rbEasy.IsChecked)
            Level = 1;
        else if (rbMed.IsChecked)
            Level = 2;
        else
            Level = 3;


        if (rbAdd.IsChecked)
            Operation = 1;
        else if (rbSub.IsChecked)
            Operation = 2;
        else if (rbMult.IsChecked)
            Operation = 3;
        else if (rbDiv.IsChecked)
            Operation = 4;


        if (rbMix.IsChecked)
            Operation = 5;

        Navigation.PushModalAsync(new pgQusationBoard(NumberOfQuesation,Level,Operation));
    }
}