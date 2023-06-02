using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class ChooseOneQ : Question
    {

        public override string QutionType()
        {
            return "ChOne";
        }

        public override void Header()
        {
            Console.WriteLine("Choose The Correct Answer From The Folowing :- ");
        }
      
    

     
    }
}
