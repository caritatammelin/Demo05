using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Laundry
    {
        public string Color { get; set; }
        public string Fabric { get; set; }
        public string Garment { get; set; }
       

        public override string ToString()
        {
            return "Color: " + Color + " Fabric: " + Fabric + " Garment: " + Garment;
        }
    }
}
