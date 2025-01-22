using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSys.Examinition
{
    internal abstract class Exam
    {

        public int Time { get; set; }
        public int Numofquestion { get; set; }
        public  int Studentmark { get; set; }
        public int Exammark { get; set; }



        public abstract void CreateExam();
        public abstract void ShowExam();
    }
}
