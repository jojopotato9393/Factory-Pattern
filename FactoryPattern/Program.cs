using System.Drawing;
using System.Runtime.InteropServices;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME \n Are you looking for a Car or a Motorcycle");
            string user = Console.ReadLine();
           
            if (user.ToLower() == "car")
            {
                string user1 = "four";
            }
            else if (user.ToLower() == "motorcycle")
            {
                string user1 = "two";
            }
            var userCar = VehicleFactory.GetVehivles(user);
            userCar.Drive();
            Console.WriteLine($"what do you wnat to put on ur new vehicle");
            Custom();
        }
        public static void Custom()
        {
            Console.WriteLine("what color do you want");
            string color = Console.ReadLine();
            Console.WriteLine("What size wheels");
            int wheel = int.Parse(Console.ReadLine());
            Console.WriteLine($"your new vehicle is {color} with {wheel}in wheels");
          
        }
    }
}
