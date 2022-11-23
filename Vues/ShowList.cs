using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entities;

namespace Vues
{
    public static class ShowList
    {
        public static void Vehicle(List<Vehicle> vehicleList)
        {
            if (vehicleList.Count == 0)
            {
                Console.WriteLine("La liste de vehicule est vide.");
                return;
            }
            if (vehicleList != null)
                foreach (var v in vehicleList) { Console.WriteLine(v);}
            else
                Console.WriteLine("Liste Vide");
        }
        [Obsolete("Not useful", true)]
        public static void Brand(string brand, DataVehicle dataVehicle)
        {
            if (dataVehicle.Vehicles.Count == 0)
            {
                Console.WriteLine("La liste de vehicule est vide.");
                return;
            }
            var vehicleList = dataVehicle.Vehicles.Where(b => (b.Brand == brand));
            if (vehicleList != null)
                foreach (var v in vehicleList) { Console.WriteLine(v); }
            else
                Console.WriteLine("Liste Vide");
        }

    }
}
