using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public abstract class Animal
    {
        public string? Name;
        public int? Age;
        public string? Species;

        public abstract void MakeSound();
    }
}
