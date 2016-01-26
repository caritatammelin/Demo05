using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create tyre
            Tyre tyre = new Tyre { Name = "Nokia", Model = "Hakkapeliitta", Size = "205R16" };

            Vehicle car = new Vehicle { Name = "Porsche", Model = "911" };
            car.AddTyre(tyre); // car contains tyres... D:
            car.AddTyre(tyre); // car contains tyres... D:
            car.AddTyre(tyre); // car contains tyres... D:
            car.AddTyre(tyre); // car contains tyres... D:

            Console.WriteLine(car.ToString());
            Console.ReadLine();
        }
    }
}
