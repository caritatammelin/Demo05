using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class WashingMachine
    {
        public string Model { get; set; }
        private readonly int maxTemperature = 60;
        private readonly int minTemperature = 20;
        private int temperature;
        public int Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                if (value <= maxTemperature && value >= minTemperature) temperature = value;
                else
                {
                    Console.WriteLine("No such washing temperature!");
                }
            }
        }
        public List<Laundry> Laundries { get; }
        public List<Detergent> Detergents { get; }
        public WashingMachine()
        {
            Laundries = new List<Laundry>();
            Detergents = new List<Detergent>();
        }
        public void AddLaundry(Laundry laundry)
        {
            Laundries.Add(laundry);
        }

        public void AddDetergent(Detergent detergent)
        {
            Detergents.Add(detergent);
        }

        public override string ToString()
        {
            string sWashingMachine = "Washing Machine Model: " + Model + " Temperature: " + Temperature + "\nDetergent: "; // \n rivinvaihto
            foreach (Detergent detergent in Detergents)
            {
                sWashingMachine += detergent.ToString() + "\nLaundry:\n";
            }
            foreach (Laundry laundry in Laundries)
            {
                sWashingMachine += laundry.ToString() + "\n";
            }
            return sWashingMachine;
        }
    }
}
