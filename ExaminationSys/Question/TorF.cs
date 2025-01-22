using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSys.Question0
{
    internal class TorF : Question
    {
        public string[] Answar { get; set; } = { "false", "true" };
        public override void EnterQuestion()
        {
            int T;
            Console.Clear();
            Console.WriteLine("True or False Question");
            Console.WriteLine();
            Console.WriteLine("please Enter Body");
            Body = Console.ReadLine();
            Console.WriteLine();
            do
            {
                Console.WriteLine("please Enter The Question Mark");

            } while (!int.TryParse(Console.ReadLine(), out T) || T == 0 || T < 0);
            Mark = T;
         
            Console.WriteLine();
            do
            {
                Console.WriteLine("Please Enter The Right Answer id (1 for false | 2 for true ) ");
            } while (!int.TryParse(Console.ReadLine(), out T) || T <= 0 || T > 2);
            Rightanswer = T;
            
        }

    }
}
