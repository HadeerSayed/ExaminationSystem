using System.Collections.Generic;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Set Questions and create Exam

            Dictionary<Question, List<string>> questions = new Dictionary<Question, List<string>>() {

                {   new ChooseAllQ(){  Body="1- Which Access Modifier are allowed in The namespace",Mark=1,
                    answers=new Answers(){choices=new List<string>(){   "a) Public","b) Protected", "c) Internal", "d) private" } }},new List<string>{"a","c"}
                }
                ,

                { new ChooseAllQ(){  Body="2- What are types of classes",Mark=1,
                    answers=new Answers(){choices=new List<string>(){"a) Static", "b) Concret", "c) Virtual","d) Abstract"} }},new List<string>{"a","b","d" }
                }
                ,

                {   new ChooseOneQ(){  Body="3- Which class can have member functions without their implementation",Mark=1,
                    answers=new Answers(){choices=new List<string>(){   "a) Default class", "b) String class","c) Template class","d) Abstract class" } }},new List<string>{"d"}
                }
                ,

                { new ChooseOneQ(){  Body="4- What is the scope of a class nested inside another class?",Mark=1,
                    answers=new Answers(){choices=new List<string>(){"a) Protected scope", "b) Private scope", "c) Global scope", "d) Depends on access specifier and inheritance used" } }},new List<string>{"d" }
                }

                ,


                {   new TFQ(){  Body="5- Super classes are also called Parent classes/Base classes",Mark=1,
                    answers=new Answers(){choices=new List<string>(){ "a)True", "b)False" } }},new List<string>{"a" }
                }
                ,

                { new TFQ(){  Body="6- It is not possible to achieve inheritance of structures in c#",Mark=1,
                    answers=new Answers(){choices=new List<string>(){ "a)True", "b)False" } }},new List<string>{"a" }
                }
            };


            foreach (var q in questions)
            {
                q.Key.Add(q.Key);

            }


            //create exam
            Exam e = new Exam(questions, "OOP");

            //display exam subject and question count
            e.examsubject();
            e.QuestionCount();

            #endregion




            //scan Exam Type

            ExamType examType;
      
            do
            {
                Console.WriteLine("Choose Exam Type final or practical");
        
            } while (!Enum.TryParse<ExamType>(Console.ReadLine(), out examType));




            #region show exam Questions and scan answers

            string answer;
            string[] answerArr;
            bool isParsed = false;

          
           
            foreach (var q in e.questions)
            {

                q.Key.Header();
                q.Key.ShowQuestion();
                q.Key.ShowMark();
                q.Key.answers.showchoices();

                if (q.Key.QutionType() == "ChAll")
                {

                    do
                    {
                        Console.WriteLine("Choose all correct in this formate a/b/c/d");
                        answer = Console.ReadLine();
                        answerArr = answer.Split("/");

                        foreach (string ans in answerArr)
                        {
                            isParsed = Enum.TryParse<chOneAllAnswers>(ans, out chOneAllAnswers Enumanswer);
                            if (!isParsed)
                            {
                                break;
                            }

                        }

                    } while (!isParsed);

                    q.Key.answers.Student_Answer = string.Join("/", answerArr);


                }
                else if (q.Key.QutionType() == "ChOne")
                {

                    do
                    {
                        Console.WriteLine("Choose a or b or c or d");
                        answer = Console.ReadLine();
                    } while (!Enum.TryParse<chOneAllAnswers>(answer, out chOneAllAnswers Enumanswer));

                    q.Key.answers.Student_Answer = answer;
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Choose a or b");
                        answer = Console.ReadLine();
                    } while (!Enum.TryParse<TFAnswers>(answer, out TFAnswers Enumanswer));

                    q.Key.answers.Student_Answer = answer;
                }

        }

        

            #endregion



            #region check exam type

            switch (examType) {
                case ExamType.practical:

                    PracticalExam practical = new PracticalExam(e.questions,e.subject);
                    practical.ShowExam();
                    break;

                case ExamType.final:

                    FinalExam final= new FinalExam(e.questions,e.subject);   
                    final.ShowExam();
                    break;
            }

            #endregion

        }
    }
}