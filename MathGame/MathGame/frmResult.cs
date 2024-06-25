using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame
{
    public partial class frmResult : Form
    {
        clsGameInfo GameInfo;

        public frmResult(clsGameInfo gameInfo)
        {
            InitializeComponent();

            GameInfo = gameInfo; 

        }

        private void frmResult_Load(object sender, EventArgs e)
        {

            if (GameInfo.WrongAnswer > GameInfo.CorrectAnswer)
            {
                BackColor = Color.Red;
                lbFinalResult.Text = "Fail";
                SoundPlayer Player = new SoundPlayer();
                Player.SoundLocation = @"C:\Users\good1\Downloads\8-bit-video-game-lose-sound-version-1-145828.wav";
                Player.Play();
            }
            else
            {
                BackColor = Color.Green;
                lbFinalResult.Text = "Pass";
                SoundPlayer Player = new SoundPlayer();
                Player.SoundLocation = @"C:\Users\good1\Downloads\8-bit-video-game-win-level-sound-version-1-145827.wav";
                Player.Play();
            }

            lbNumberOfQuesations.Text = GameInfo.NumberOfQuestion.ToString();
            lbOperationLevel.Text = GameInfo.Operation.ToString();
            lbWrongQuesation.Text = GameInfo.WrongAnswer.ToString();
            lbRigthQuesation.Text = GameInfo.CorrectAnswer.ToString();
            lbQuesationLevel.Text = GameInfo.Level.ToString();

        }

        private void lbRestartGame_Click(object sender, EventArgs e)
        {
            frmStatringPage frmStatringPage = new frmStatringPage();

            this.Close();

            frmStatringPage.ShowDialog();

        }
    }
}
