using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Reptile : Animal
    {
        public bool IsVenomous;

        public override void MakeSound()
        {
            Console.WriteLine("Reptile sound: eeeeeeeeeee");
        }
    }
}
