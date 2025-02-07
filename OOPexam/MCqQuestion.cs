using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPexam
{
    internal class MCqQuestion : Question
    {
        public int MyProperty { get; set; }
        public MCqQuestion(string header, string body, int mark, Answer[] answers, int rightAnswer) : base(header, body, mark, answers,rightAnswer)
        {

        }

        public override void DisplayQuestion()
        {
            Console.WriteLine($"{Header}: {Body}");
            foreach (var answer in Answers)
            {
                Console.WriteLine($"{answer.Answerid}. {answer.AnswerText}");
            }
        }
    }
}
