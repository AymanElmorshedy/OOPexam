using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPexam
{
    internal abstract class Exam
    {

        #region Properities
        public int TimeOfExam { get; set; }
        public int NoOfQuestions { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();
        #endregion
        #region Constructor
        protected Exam(int timeOfExam, int noOfQuestions)
        {
            TimeOfExam = timeOfExam;
            NoOfQuestions = noOfQuestions;
            
        }
        #endregion

        #region Methods
        public abstract void DisplayExam(); 
        #endregion

    }
}
