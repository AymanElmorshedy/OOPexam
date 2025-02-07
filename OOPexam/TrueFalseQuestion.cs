using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPexam
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, int mark, Answer[] answers,int rightAnswer) : base(header, body, mark, answers, rightAnswer)
        {

        }

        public override void DisplayQuestion()
        {
            Console.WriteLine($"{Header}:{Body}(Mark):{Mark}");
            Console.WriteLine("1.True\t2.False");
        }
    }
}
