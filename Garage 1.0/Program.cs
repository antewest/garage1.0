using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garage_1._0.Vehicles;

namespace Garage_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            GarageMaster master = new GarageMaster();

            List<Vehicle> exampleVehicles = new List<Vehicle>()
            {
                new Car("GNU-453",4,"Red",5,false, false),
                new Boat("FUU-123", 0, "White", 16, false, 50),
                new Bus("LUL-000",4,"Blue", 50, true, 25.00f),
                new Airplane("HUE-001", 18, "White", 118, "RyanAir", false),
                new Airplane("HUE-002", 18, "Blue", 118, "FlyEmirates", false),
                new Airplane("HUE-003", 18, "Red", 118, "SAS", false)
            };

            foreach (var vehicle in exampleVehicles)
            {
                Console.WriteLine(master.AddVehicle(0, vehicle));
            }

            //var query = master.GetAll(0).Where(b => b.GetType() == typeof(Airplane));
            var query = master.GetAll(0).GroupBy(b => b.GetType()).Select(b => b.First());

            foreach (var vehicle in query)
            {
                Console.WriteLine(vehicle);
            }

            Console.ReadKey();
        }
    }
}
