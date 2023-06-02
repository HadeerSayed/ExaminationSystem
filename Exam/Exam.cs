using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    enum ExamType
    {
        practical,final
    }

    internal class Exam
    {
       public Dictionary<Question,List< string>> questions;

        public int questionCount {

            get
            {
                return questions.Count;
            }
        
        }
        public  int TotalGrade { get; set; }

        public string subject { get; set; }

        public Exam( Dictionary<Question, List<string>> Questions,string Subject)
        {
            questions = Questions;
            subject = Subject;
        }


        public void CorrectExam()
        {

            foreach (var q in questions)
            {
                string[]StudentAnswer = q.Key.answers.Student_Answer.Split('/');
                int counter = 0;

                foreach (string answer in StudentAnswer)
                {
                    foreach(string correctAnswer in q.Value)
                    {
                        if (answer == correctAnswer)
                        {
                            counter++;
                            break;
                        }
                      
                    }
              
                }

                if (counter == q.Value.Count)
                {             
                    TotalGrade += q.Key.Mark;
                }
            }  

        }

        public void QuestionCount()
        {
            Console.WriteLine($"Number Of Quetions: {questionCount}");
        }

        public void examsubject()
        {
            Console.Write($"Exam Subject is {subject} \t\t\t\t\t ");
        }
        public void showTotalGrade()
        {
            CorrectExam();
            Console.WriteLine($"---------- Your Total Grade is {TotalGrade}");
        }

        public virtual void ShowExam()
        {
   
        }
  
    }
}
