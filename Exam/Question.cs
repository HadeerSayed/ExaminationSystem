using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exam
{
    internal abstract class Question
    {
        public int Mark { get; set; }
        public string Body { get; set; }
        public Answers answers { get; set; }

        public abstract string QutionType();

        public abstract void Header();

        //add Question to txt file
        public void Add(Question Q)
        {

            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("D:\\ITI\\.Net Track\\Advanced C#\\Labs\\Day 3\\ExamLastVersion\\Questions.txt", true);
                //Write a line of text
                sw.WriteLine(Q.Body);
                //Write a second line of text
                sw.WriteLine(string.Join(",", Q.answers.choices));

                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }

        public void ShowQuestion()
        {
            Console.Write($"{Body}\t\t\t\t");
        }

        public void ShowMark()
        {
            Console.WriteLine($"{Mark} Mark");
        }


        



    }
}
