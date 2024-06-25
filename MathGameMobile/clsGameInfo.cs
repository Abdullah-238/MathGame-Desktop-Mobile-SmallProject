using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public class clsGameInfo
    {
        Random random = new Random();
        public enum enLevel { Easy = 1, Med = 2, Hard = 3 };
        public enum enOperation { Add = 1, Sub = 2, Multi = 3, Div = 4, Mix = 5 };


        public enLevel Level;

        public enOperation Operation;

        public short NumberOfQuestion;

        public double Num1;

        public double Num2;

        public double Result;

        public double UserInput;

        public int QuestionNumber;

        public string OperationText;


        public int CorrectAnswer;

        public int WrongAnswer;


    }
}
