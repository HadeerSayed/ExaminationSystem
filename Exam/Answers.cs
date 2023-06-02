using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    enum chOneAllAnswers
    {
        a,b,c,d
    }
    enum TFAnswers
    {
        a, b
    }
    public class Answers
    {

        public List<string> choices { set; get; }
        public string Student_Answer { get; set; }

        
        public void showchoices()
        {
           Console.WriteLine( string.Join(" , ", choices));
        }

        public void ShowStudentAnswers()
        {
            Console.WriteLine(Student_Answer);

        }
    }
}
