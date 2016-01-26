using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Human : Mammal
    {
        public double Weight { get; set; }
        public double Height { get; set; }
        public string Name { get; set; }

        public override void Move()
        {
            Console.WriteLine("I am moving.");
        }

        public void Age()
        {
            Currentage++;
        }
    }
}
