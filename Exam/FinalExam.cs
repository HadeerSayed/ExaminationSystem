using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class FinalExam : Exam
    {
        public FinalExam(Dictionary<Question, List<string>> questions,string subject) : base(questions, subject)
        {
        }


        public override void ShowExam()
        {

            Console.WriteLine("-----------------------You Are Finshed The Exam---------------");

            foreach (var q in questions)
            {
                q.Key.ShowQuestion();
                Console.Write("Your Answer Is:");
                q.Key.answers.ShowStudentAnswers();
            }

           
        }

    }
}
