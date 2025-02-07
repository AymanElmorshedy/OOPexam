namespace OOPexam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Subject subject = new Subject(1,"Math");
            subject.CreateExam();
            Console.Clear();
            Console.WriteLine("Do you want to start exam?  yes for start");
            //string StartExam=Console.ReadLine().Trim().ToLower();
            if (StartExam == "yes")
            {
                subject.StartExam();
            }
            else
                Console.WriteLine("exam is canceled ");
            

        
        }
    }
}
