using Data;
using Entities;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class SVehicleCreate
    {
        public static void VehicleCreate(Vehicle vh, DataVehicle dataVehicle)
        {
            dataVehicle.Vehicles.Add(vh);

            var vhAdded = dataVehicle.GetVehicleByNumber(vh.Number);
            if (vhAdded != null)
                Console.WriteLine($"Véhicule créé : {vhAdded}");
            else
                Console.WriteLine("Echec Création");
        }
    }
}
