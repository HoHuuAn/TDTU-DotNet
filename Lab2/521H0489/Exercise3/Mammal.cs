using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Mammal : Animal
    {
        public int NumberOfLegs;
        public override void MakeSound()
        {
            Console.WriteLine("Mammal sound: uuuuuuuuuuuuu");
        }

        public virtual void GiveBirth()
        {
            Console.WriteLine("Giving birth");
        }

    }
}
