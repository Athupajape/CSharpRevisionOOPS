using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRevisionOOPS
{

    public class Trainer
    {
        public string _firstname = "FN";
        public string _lastname = "LN";

        public virtual void printname()
        {
            Console.WriteLine("The firstname and lastname is : "+ _firstname+ " " + _lastname);
        }
    }

    public class FullTimeTrainer :Trainer
    {
        public override void printname()
        {
            Console.WriteLine("The firstname and lastname is : " + _firstname +" "+ _lastname + " and I'm Fulltime trainer");
        }
    }

    public class PartTimeTrainer : Trainer
    {
        public override void printname()
        {
            Console.WriteLine("The firstname and lastname is : " + _firstname + " " + _lastname + " and I'm Parttime trainer");
        }
    }

    public class Polymorphism
    {
        public static void Main(string[] args)
        {
            Trainer[] trainers = new Trainer[3];
            trainers[0] = new Trainer();
            trainers[1] = new FullTimeTrainer();
            trainers[2] = new PartTimeTrainer();

            foreach(Trainer trainer in trainers)
            {
                trainer.printname();
            }
        }
    }
}
