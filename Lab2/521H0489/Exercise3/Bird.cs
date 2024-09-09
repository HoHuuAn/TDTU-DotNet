using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Bird : Animal, IFlyable
    {
        public double Wingspan;

        public override void MakeSound()
        {
            Console.WriteLine("Bird sound: buzz buzz buzz buzz");
        }

        public void Fly()
        {
            Console.WriteLine("Flying ......");
        }
    }
}
