using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPexam
{
    internal abstract class Question
    {
        #region Properities
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] Answers { get; set; }
        public int RightAnswer { get; set; }
        #endregion
        #region Constructor
        public Question(string header, string body, int mark, Answer[] answers,int rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = answers;
            RightAnswer = rightAnswer;


        }
        #endregion

        public abstract void DisplayQuestion();
    }
}
