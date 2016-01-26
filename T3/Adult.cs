using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Adult : Human
    {
        public string Car { get; set; }
        public override void Move()
        {
            Console.WriteLine("I am walking.");
        }
    }
}
