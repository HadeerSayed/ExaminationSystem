using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class TFQ : Question 
    {
        public override string QutionType() {
            return "TF";
        }
        public override void Header()
        {
            Console.WriteLine("Put True Or False For The Folowing Question");
        }
        


    }
}
