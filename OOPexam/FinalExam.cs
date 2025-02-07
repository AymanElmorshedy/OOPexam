using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPexam
{
    internal class FinalExam : Exam
    {
        public FinalExam(int timeOfExam, int noOfQuestions) : base(timeOfExam, noOfQuestions)
        {

        }

        public override void DisplayExam()
        {
            int totalMarks = 0;
            Console.WriteLine("Practical Exam");
            foreach (var question in Questions)
            {
                question.DisplayQuestion();
                int Answer;
                bool AnswerCheck;
                do
                {
                    Console.WriteLine("Enter your answer");
                    AnswerCheck = int.TryParse(Console.ReadLine(), out Answer);
                } while (!AnswerCheck);
                if (Answer == question.RightAnswer)
                {
                    totalMarks += question.Mark;
                }

            }
            Console.Clear();
            Console.WriteLine(" Evaluation");
            foreach (var question in Questions)
            {
                question.DisplayQuestion();
                int rightAnswer = question.RightAnswer - 1;
                Console.WriteLine($"the right answer is {question.Answers[rightAnswer].AnswerText}");

            }
            Console.WriteLine($"total mark ={totalMarks}");
        }
    }
}
