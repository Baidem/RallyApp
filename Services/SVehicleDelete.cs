using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class SVehicleDelete
    {
        public static void ByVehicle(Vehicle? vehicle, DataVehicle datavehicle)
        {
            if (vehicle == null)
                return;

            bool isExiste = datavehicle.Vehicles.Any(v => v == vehicle);

            datavehicle.Vehicles.Remove(vehicle);

            isExiste = datavehicle.Vehicles.Any(v => v == vehicle);
        }
    }
}
