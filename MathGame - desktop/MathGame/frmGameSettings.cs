using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            short NumberOfQuesation = (short)numericUpDown1.Value;
            short Level = 0, Operation = 0; 

            if (rbEasy.Checked)
                Level = 1;
            else if (rbMed.Checked)
                Level = 2;
            else
                Level = 3;


            if (rbAdd.Checked)
                Operation = 1;
            else if (rbSub.Checked)
                Operation = 2;
            else if (rbMult.Checked)
                Operation = 3;
            else if (rbDiv.Checked)
                Operation = 4;


             if (rbMix.Checked)
                Operation = 5;

            frmQuestionBoard quesationBoard = new frmQuestionBoard(NumberOfQuesation, Level, Operation);

            this.Close();

            quesationBoard.Show();

        }
    }
}
