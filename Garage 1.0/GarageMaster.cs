using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0
{
    class GarageMaster
    {
        private List<Garage<Vehicle>> garageList = new List<Garage<Vehicle>>();

        public GarageMaster()
        {
            CreateGarage(10);
        }

        public string AddVehicle(int garageIndex, Vehicle vehicle)
        {
            if (garageList[garageIndex].Count() >= garageList[garageIndex].slots)
                return "Sorry, the garage is full";
          
            garageList[garageIndex].AddVehicle(vehicle);
            return "Vehicle Added"; //String.Format("Added\n{0}", vehicle.ToString());
        }

        public void CreateGarage(int numslots)
        {
            Garage<Vehicle> garage = new Garage<Vehicle>{slots = numslots};
            garageList.Add(garage);
        }

        public List<Vehicle> GetAll(int garageIndex)
        {
            return garageList[garageIndex].GetVehicles();
        }
    }
}
