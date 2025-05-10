using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSys.Examinition;
using ExaminationSys.Question0;

namespace ExaminationSys
{
    internal class Subject
    {
        //public int SubId { get; set; }
        //public string SubName { get; set; }

        public void EnterExam()
        {
            int x;
            bool flag;
            do
            {
                Console.WriteLine("Please Enter The Type Of Exam (1 For Practical | 2 For Final)");
                flag = int.TryParse(Console.ReadLine(),out x);
                Console.WriteLine();

                if (x == 1)
                {

                    Partictal partictal = new Partictal();
                    //partictal.CreateExam();
                    //partictal.StartExam();
                    //partictal.ShowExam();
                    partictal.Fun01();
                }
                else if (x == 2)
                {
                    Final final = new Final();
                    //final.CreateExam();
                    //final.StartExam();
                    //final.ShowExam();

                    final.Fun02();
                }
            }while (flag==false ||x<=0 || x>2);

            
        }


       
    }


}











