using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSys.Question0
{
    internal class MCQ : Question
    {
        public string[] Answar { get; set; } = new string[3];
        public override void EnterQuestion()
        {
            int T;
            Console.Clear();
            Console.WriteLine("Mcq question");
            Console.WriteLine();
                Console.WriteLine("please enter the body ");
                 Body = Console.ReadLine();
            Console.WriteLine();
            do {
                Console.WriteLine("please enter question mark");
            }while (!int.TryParse(Console.ReadLine(),out T)   || T < 0 ||T==0 );
            Mark = T;
            
            Console.WriteLine();
            for(int i = 0; i < Answar.Length; i++)
            {
                Console.WriteLine($"please enter choice num{i+1}: ");
                Answar[i] = Console.ReadLine();
                Console.WriteLine();
            }
            do
            {
                Console.WriteLine("please enter the right answer");
            }while (!int.TryParse(Console.ReadLine(), out T) || T > 3 ||T<=0 );
            Rightanswer = T;
                

            


        }
    }
}
