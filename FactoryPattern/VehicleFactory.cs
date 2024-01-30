using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal static class VehicleFactory
    {
        public static IVehicle GetVehivles(string choice)
        {
            switch (choice.ToLower())
            {
                case "four":
                    return new Car();
                case "two":
                    return new Motorcycle();
                default:
                    return new Car();
            }
        }
    }
}
