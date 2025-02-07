using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPexam
{
    internal class Subject
    {
        public Subject(int subjectId, string? subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public Exam exam { get; set; }
        public void CreateExam()
        {
            int ExamType;
            bool examTypecheck;
            do
            {
                Console.WriteLine("Create Practical (2)  Final (1) Exam?");
                examTypecheck = int.TryParse(Console.ReadLine(), out ExamType);
            } while (!examTypecheck);
            if (ExamType == 1)
            {
                int NoOfQuestions;
                bool NOOfQuestionCheck;
                do
                {
                    Console.WriteLine("Enter no of Questions");
                    NOOfQuestionCheck = int.TryParse(Console.ReadLine(), out NoOfQuestions);
                } while (!NOOfQuestionCheck);

                int TimeOfExam;
                bool TimeExamCheck;
                do
                {
                    Console.WriteLine("enter time of exam");
                    TimeExamCheck = int.TryParse(Console.ReadLine(), out TimeOfExam);
                } while (!TimeExamCheck);
                FinalExam exam = new FinalExam(TimeOfExam, NoOfQuestions);
                this.exam = exam;
                for (int i = 0; i < NoOfQuestions; i++)
                {
                    
                    int QuestionType;
                    bool QuestionTypeCheck;
                    do
                    {
                        Console.WriteLine($"Please enter the type of question number{i+1}  1 for Mcq and 2 for T,F");
                        QuestionTypeCheck = int.TryParse(Console.ReadLine(), out QuestionType);
                    } while (!QuestionTypeCheck);
                    if (QuestionType == 1)
                    {
                        Console.WriteLine("Please enter header of question");
                        string Header = Console.ReadLine();
                        Console.WriteLine("Please enter Body of question");
                        string Body = Console.ReadLine();

                        int Mark;
                        bool MarkCheck;
                        do
                        {
                            Console.WriteLine("Please enter a mark of question");
                            MarkCheck = int.TryParse(Console.ReadLine(), out Mark);
                        } while (!MarkCheck);


                        Answer[] answers = new Answer[4];
                        for (int j = 0; j < answers.Length; j++)
                        {
                            Console.WriteLine("please enter answer");
                            string answerText = Console.ReadLine();
                            answers[j] = new Answer(j + 1, answerText);
                        }
                        int RightAnswer;
                        bool RightAnswerCheck;
                        do
                        {
                            Console.WriteLine("Please enter right answer index");
                            RightAnswerCheck = int.TryParse(Console.ReadLine(), out RightAnswer);
                        } while (!RightAnswerCheck);
                        MCqQuestion mCqQuestion = new MCqQuestion(Header, Body, Mark, answers, RightAnswer);
                        exam.Questions.Add(mCqQuestion);

                    }
                    else if (QuestionType == 2)
                    {
                        Console.WriteLine("Please enter header of question");
                        string Header = Console.ReadLine();
                        Console.WriteLine("Please enter Body of question");
                        string Body = Console.ReadLine();

                        int Mark;
                        bool MarkCheck;
                        do
                        {
                            Console.WriteLine("Please enter a mark of question");
                            MarkCheck = int.TryParse(Console.ReadLine(), out Mark);
                        } while (!MarkCheck);


                        Answer[] answers = new Answer[2];
                        for (int j = 0; j < answers.Length; j++)
                        {
                            Console.WriteLine("please enter answer");
                            string answerText = Console.ReadLine();
                            answers[j] = new Answer(j + 1, answerText);
                        }
                        int RightAnswer;
                        bool RightAnswerCheck;
                        do
                        {
                            Console.WriteLine("Please enter a right answer index");
                            RightAnswerCheck = int.TryParse(Console.ReadLine(), out RightAnswer);
                        } while (!RightAnswerCheck);
                        TrueFalseQuestion trueFalseQuestion = new TrueFalseQuestion(Header, Body, Mark, answers, RightAnswer);
                        exam.Questions.Add(trueFalseQuestion);
                    }
                }
            }
            else if (ExamType == 2)
            {
                int NoOfQuestions;
                bool NOOfQuestionCheck;
                do
                {
                    Console.WriteLine("Enter Number of questions");
                    NOOfQuestionCheck = int.TryParse(Console.ReadLine(), out NoOfQuestions);
                } while (!NOOfQuestionCheck);

                int TimeOfExam;
                bool TimeExamCheck;
                do
                {
                    Console.WriteLine("enter time of exam");
                    TimeExamCheck = int.TryParse(Console.ReadLine(), out TimeOfExam);
                } while (!TimeExamCheck);
                PracticalExam exam = new PracticalExam(TimeOfExam, NoOfQuestions);
                this.exam = exam;
                for (int i = 0; i < NoOfQuestions; i++)
                {
                    
                    int QuestionType;
                    bool QuestionTypeCheck;
                    do
                    {
                        Console.WriteLine("Please enter the type of question 1 for Mcq and 2 for T,F");
                        QuestionTypeCheck = int.TryParse(Console.ReadLine(), out QuestionType);
                    } while (!QuestionTypeCheck);

                    Console.WriteLine("Please enter header of question");
                    string Header = Console.ReadLine();
                    Console.WriteLine("Please enter Body of question");
                    string Body = Console.ReadLine();

                    int Mark;
                    bool MarkCheck;
                    do
                    {
                        Console.WriteLine("Please enter a mark of question");
                        MarkCheck = int.TryParse(Console.ReadLine(), out Mark);
                    } while (!MarkCheck);


                    Answer[] answers = new Answer[4];
                    for (int j = 0; j < answers.Length; j++)
                    {
                        Console.WriteLine("please enter answer");
                        string answerText = Console.ReadLine();
                        answers[j] = new Answer(j + 1, answerText);
                    }
                    int RightAnswer;
                    bool RightAnswerCheck;
                    do
                    {
                        Console.WriteLine("enter right answer index");
                        RightAnswerCheck = int.TryParse(Console.ReadLine(), out RightAnswer);
                    } while (!RightAnswerCheck);
                    MCqQuestion mCqQuestion = new MCqQuestion(Header, Body, Mark, answers, RightAnswer);
                    exam.Questions.Add(mCqQuestion);






                }
            }

        }

        public void StartExam()
        {
            exam.DisplayExam();
        }
    }    }


