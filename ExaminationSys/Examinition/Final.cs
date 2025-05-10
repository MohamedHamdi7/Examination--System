using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSys.Question0;

namespace ExaminationSys.Examinition
{
    internal class Final : Exam
    {
        MCQ[] mCQs;




        public override void CreateExam()
        {
            bool flag;
            int T;
            int x;
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
            } while (flag == false || !(T > 0 && T < 50));
            Numofquestion = T;
            Console.WriteLine();
            mCQs = new MCQ[Numofquestion];
            for (int i = 0; i < Numofquestion; i++)
            {
                Console.Clear();
                do
                {
                    Console.WriteLine("Please Enter Type Of Question (1 for Mcq | 2 for True or False)");
                    flag = int.TryParse(Console.ReadLine(), out x);



                    if (x == 1)
                    {
                        MCQ mCQ = new MCQ();

                        mCQ.EnterQuestion();
                        mCQs[i] = new MCQ();
                        mCQs[i].Body = mCQ.Body;
                        mCQs[i].Answar = mCQ.Answar;
                        mCQs[i].Rightanswer = mCQ.Rightanswer;
                        mCQs[i].Mark = mCQ.Mark;

                        Exammark += mCQs[i].Mark;

                    }
                    if (x == 2)
                    {
                        TorF torF = new TorF();
                        torF.EnterQuestion();
                        mCQs[i] = new MCQ();
                        mCQs[i].Body = torF.Body;
                        mCQs[i].Answar = torF.Answar;
                        mCQs[i].Rightanswer = torF.Rightanswer;
                        mCQs[i].Mark = torF.Mark;

                        Exammark += mCQs[i].Mark;



                    }
                } while (flag == false || x <= 0 || x > 2);

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
                        Console.WriteLine($"Question {i + 1}: {mCQs[i].Body}          MARK: {mCQs[i].Mark}");
                        Console.WriteLine();
                        for (int j = 0; j < mCQs[i].Answar.Length; j++)
                        {

                            Console.WriteLine($"{j + 1} : {mCQs[i].Answar[j]}");
                        }
                        Console.WriteLine();
                        mCQs[i].Answers = new Answers();
                        do
                        {

                            Console.Write("Enter Answer id :");

                        } while (!int.TryParse(Console.ReadLine(), out t) || t <= 0 || t > mCQs[i].Answar.Length);
                        mCQs[i].Answers.Answerid = t;
                        Console.WriteLine();

                    }
                }
           



            }while (s != "y");

        }

        public override void ShowExam()
        {
            Console.Clear();

            for (int i = 0; i <mCQs.Length; i++)
            {
                Console.WriteLine($"Question{i + 1}: {mCQs[i].Body}");
                Console.WriteLine();
                Console.WriteLine($"Your Answer:{mCQs[i].Answar[mCQs[i].Answers.Answerid - 1]}");
                Console.WriteLine();
                
                
                    Console.WriteLine($"Right Answer:{mCQs[i].Answar[mCQs[i].Rightanswer - 1]}");
                Console.WriteLine();
                
                

                if (mCQs[i].Answers.Answerid == mCQs[i].Rightanswer)
                {
                    Studentmark += mCQs[i].Mark;
                }

            }

            Console.Write($"Your Grade is : {Studentmark} From : {Exammark}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("THANK YOU");




        }


        public void Fun02()
        {
         CreateExam();
         StartExam();
         ShowExam();
        }
    }
}
