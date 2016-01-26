using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Detergent
    {
        public string Name { get; set; }
        public string Scent { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + " Scent: " + Scent;
        }
    }
}
