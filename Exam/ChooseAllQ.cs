using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class ChooseAllQ : Question
    {
     
        public override string QutionType()
        {
            return "ChAll";
        }
        public override void Header()
        {
            Console.WriteLine("Choose All Correct Answer From The Folowing :- ");
        }
       

       
    }
}
