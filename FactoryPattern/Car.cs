using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("your buying a new Car");
        }
        public string color { get; set; }
        public int WheelSize { get; set; }
    }
}
