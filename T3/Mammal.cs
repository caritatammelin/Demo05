using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    abstract class Mammal
    {
        public int Currentage { get; set; }

        public abstract void Move();
    }
}
