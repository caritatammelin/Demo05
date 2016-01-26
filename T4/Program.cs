using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Laundry shirt = new Laundry { Color = "Red", Fabric = "Cotton", Garment = "Shirt" };
            Laundry pants = new Laundry { Color = "Black", Fabric = "Cotton", Garment = "Pants" };
            Laundry socks = new Laundry { Color = "Striped", Fabric = "Cotton", Garment = "Socks" };
            Detergent detergent = new Detergent { Name = "Omo", Scent = "Lilies" };

            WashingMachine washer = new WashingMachine { Model = "Bosch", Temperature = 40};
            washer.AddDetergent(detergent);
            washer.AddLaundry(shirt);
            washer.AddLaundry(pants);
            washer.AddLaundry(socks);
            washer.AddLaundry(shirt);
            washer.AddLaundry(pants);
            washer.AddLaundry(shirt);
            washer.AddLaundry(pants);
            washer.AddLaundry(socks);

            Console.WriteLine(washer.ToString());
            Console.ReadLine();
        }
    }
}
