using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MathGame
{
    public partial class frmQuestionBoard : Form
    {
        Random random = new Random();
       
        clsGameInfo GameInfo = new clsGameInfo();

        bool isMix = false;

        public frmQuestionBoard(short numberOfQuestion , short level , short operation )
        {
            InitializeComponent();

            GameInfo.NumberOfQuestion = numberOfQuestion;
            GameInfo.Level = (clsGameInfo.enLevel)level;
            GameInfo.Operation = (clsGameInfo.enOperation)operation;

        }

        void OperationType ()
        {
            switch(GameInfo.Operation)
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
            switch(GameInfo.Level)
            {
                case clsGameInfo.enLevel.Easy:
                    GameInfo.Num1 = random.Next(1,20);
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

        void CalculteResult ()
        {
            switch (GameInfo.Operation)
            {
                case clsGameInfo.enOperation.Add:
                    GameInfo.Result =  GameInfo.Num1 + GameInfo.Num2;
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

            GameInfo.Result =  Math.Round(GameInfo.Result,1);
        }

        void CheckResult ()
        {
            if (GameInfo.Result == GameInfo.UserInput)
            {
                GameInfo.CorrectAnswer++;
                this.BackColor = Color.Green;
                MessageBox.Show("Your answer is correct");
            }
            else
            {
                GameInfo.WrongAnswer++;
                this.BackColor = Color.Red;
                MessageBox.Show("The correct answer is : " + GameInfo.Result);
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

        private void frmQuesationBoard_Load(object sender, EventArgs e)
        {
            GameInfo.QuestionNumber = 1; 

            GenrateQuesation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txInput.Text = txInput.Text.TrimEnd('.');

            if (txInput.Text.Trim() == string.Empty  || txInput.Text.Trim() == "-")
            {
                MessageBox.Show("this feild can't be a empty", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            CalculteResult();
           
            GameInfo.UserInput = Math.Round(float.Parse(txInput.Text),1);

            CheckResult();

            if (GameInfo.NumberOfQuestion == GameInfo.QuestionNumber)
            {
                frmResult frmResult = new frmResult(GameInfo);

                this.Close();

                frmResult.Show();
            }
            else
            {

                GameInfo.QuestionNumber++;

                GenrateQuesation();
            }

        }

       

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            // If the text already contains a negative sign, we need to make sure that 
            //    the user is not trying to enter a character at the start
            // If there is already a negative sign and the negative sign is not selected, the key press is not valid
            // This allows the user to highlight some of the text and replace it with a negative sign
            if ((textBox.Text.IndexOf('-') > -1) && textBox.SelectionStart == 0 && !textBox.SelectedText.Contains('-'))
            {
                e.Handled = true;
            }
            // Do not accept a character that is not included in the following
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            // Only allow one decimal point
            if ((e.KeyChar == '.') && (textBox.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            // The negative sign can only be at the start
            if ((e.KeyChar == '-'))
            {
                // If the cursor is not at the start of the text, the key press is not valid
                if (textBox.SelectionStart > 0)
                {
                    e.Handled = true;
                }
                // If there is already a negative sign and the negative sign is not selected, the key press is not valid
                // This allows the user to highlight some of the text and replace it with a negative sign
                if (textBox.Text.IndexOf('-') > -1 && !textBox.SelectedText.Contains('-'))
                {
                    e.Handled = true;
                }
            }

           
        }
    }
}
