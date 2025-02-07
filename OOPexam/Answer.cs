using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPexam
{
    internal class Answer
    {
        public Answer(int answerid, string answerText)
        {
            Answerid = answerid;
            AnswerText = answerText;
        }

        public int Answerid { get; set; }
        public string AnswerText { get; set; }
    }
}
