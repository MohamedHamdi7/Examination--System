using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSys.Examinition;

namespace ExaminationSys.Question0
{
    internal  class Question
    {
        
        
        public string Body { get; set; }
        public int Mark { get; set; }
        public int Rightanswer { get; set; }
        public Answers Answers { get; set; }


        public virtual void EnterQuestion()
        {
            Console.WriteLine("");
        }
        
         
        
    }
    internal class Answers
    {
        public int Answerid { get; set; }
        //public string Answertext { get; set; }
    }

    
}
