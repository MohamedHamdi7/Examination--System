using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ExaminationSys.Question0;

namespace ExaminationSys.Examinition
{
    internal class Partictal : Exam
    {
        public MCQ[] mCQs;



        public override void CreateExam()
        {
            bool flag;
            int T;
            do
            {
                Console.WriteLine("Please Enter The Time For Exam (30 min to 180 min) ");


            } while (!(int.TryParse(Console.ReadLine(), out T) && (T >= 30 && T <= 180)));
            Time = T;

            Console.WriteLine();
            do
            {
                Console.WriteLine("Please Enter The Number Of Questions");
                flag = int.TryParse(Console.ReadLine(), out T);
            } while (flag == false || !(T >0 && T<50));
            Numofquestion = T;
                
                mCQs = new MCQ[Numofquestion];
                for (int i = 0; i < Numofquestion; i++)
                {
                    Console.Clear();
                    MCQ mCQ = new MCQ();
                    mCQ.EnterQuestion();
                    mCQs[i] = new MCQ();
                    mCQs[i].Body = mCQ.Body;
                    mCQs[i].Answar = mCQ.Answar;
                    mCQs[i].Rightanswer = mCQ.Rightanswer;
                    mCQs[i].Mark = mCQ.Mark;
                    Exammark += mCQs[i].Mark;
                }
               
         }
        public void StartExam()
        {
            int t;
            string s;
            Console.Clear();
            do
            {
                Console.WriteLine("Do You Want Start Exam (Y | N)");
                 s = Console.ReadLine();

                Console.WriteLine();
                if (s == "y" || s == "Y")

                {
                    for (int i = 0; i < mCQs.Length; i++)
                    {
                        Console.WriteLine($"Question{i + 1}: {mCQs[i].Body}            MARK : {mCQs[i].Mark}");
                        Console.WriteLine();
                        for (int j = 0; j < mCQs[i].Answar.Length; j++)
                        {
                            Console.WriteLine($"Choise {j + 1} : {mCQs[i].Answar[j]}");
                            Console.WriteLine();
                        }
                        mCQs[i].Answers = new Answers();
                        do
                        {
                            Console.Write("Enter Answer id :");

                        } while (!int.TryParse(Console.ReadLine(), out t) || t <= 0 || t > 3);
                        mCQs[i].Answers.Answerid = t;

                        Console.WriteLine();
                        


                    }
                }


            } while (s != "y");

            
        }



        public override void ShowExam()
        {
            Console.Clear ();
            for (int i = 0;i < mCQs.Length;i++)
            {
                Console.WriteLine($"Question{i + 1}:{mCQs[i].Body}");
                Console.WriteLine();
                Console.WriteLine($"Your Answer:{mCQs[i].Answar[mCQs[i].Answers.Answerid-1]}");
                Console.WriteLine();
                Console.WriteLine($"Right Answer:{mCQs[i].Answar[mCQs[i].Rightanswer-1]}");
                Console.WriteLine();

                if (mCQs[i].Rightanswer == mCQs[i].Answers.Answerid)
                {
                    Studentmark += mCQs[i].Mark;

                   
                }
            }
            
            Console.Write($"Your Grade is : {Studentmark} From : {Exammark}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("THANK YOU");


            
           

           
        }


        public void Fun01()
        {
            CreateExam();
            StartExam();
            ShowExam();
        }


    }
}
