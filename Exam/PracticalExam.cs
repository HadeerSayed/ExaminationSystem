using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(Dictionary<Question, List<string>> questions, string subject) : base(questions,subject)
        {
        }


        public override void ShowExam()
        {

            Console.WriteLine("-----------------------You Are Finshed The Exam---------------");
            showTotalGrade();

            foreach (var q in questions)
            {
                q.Key.ShowQuestion();
                Console.WriteLine($"The Correct Answer Is: {string.Join("/", q.Value)}");

            }

          


        }
    }
}
